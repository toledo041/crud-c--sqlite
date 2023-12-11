using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CrudCSharp
{
    public partial class ForgotForm : Form
    {
        public ForgotForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string textoBuscado = userTxt.Text;
            string pass = passTxt.Text;
            string pass2 = pass2Txt.Text;

            int iduser = 0;
            // Cadena de conexión a la base de datos SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Consulta SQL para verificar si existe el usuario y obtener el correo
            string consulta = "SELECT COUNT(*), idUser FROM User WHERE name = @NombreUsuario";
            if (pass == pass2)
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        // Parámetro para el nombre de usuario
                        comando.Parameters.AddWithValue("@NombreUsuario", textoBuscado);


                        // Ejecutar la consulta y obtener el resultado
                        using (SQLiteDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int cantidadUsuarios = lector.GetInt32(0);

                                if (cantidadUsuarios > 0)
                                {
                                    // El usuario existe, obtener el correo electrónico
                                    iduser = lector.GetInt32(1);
                                    //MessageBox.Show($"usuario: {iduser}", "Mensaje");
                                    
                                }
                                else
                                {
                                    // El usuario no existe, informar al usuario
                                    Console.WriteLine("El usuario no existe.");
                                    MessageBox.Show("Usuer not exist.", "Info");

                                 
                                }
                            }
                        }
                        if(iduser != 0) { 
                            try
                            {
                                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                                {

                                    conn.Open();

                                    string update = "UPDATE User SET password = @pass WHERE idUser = @ID";

                                    using (SQLiteCommand command = new SQLiteCommand(update, conn))
                                    {
                                        command.Parameters.AddWithValue("@pass", pass);
                                        command.Parameters.AddWithValue("@ID", iduser);

                                        int rowsAffected = command.ExecuteNonQuery();

                                        try
                                        {
                                            // Ejecutar la consulta
                                            //int rowsAffected = comando.ExecuteNonQuery();

                                            if (rowsAffected > 0)
                                            {
                                                MessageBox.Show("Successful update.", "Info");
                                            }
                                            else
                                            {
                                                MessageBox.Show("No rows updated.", "Info");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error: " + ex.Message);

                                        }
                                        conn.Close();
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error updating user: " + ex.Message);
                                conexion.Close();
                            }

                            LoginForm form = new LoginForm();
                            // Mostrar el segundo formulario
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}
