using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudCSharp
{
    public partial class RegisterLogin : Form
    {
        public RegisterLogin()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Datos para la inserción            
            string name = userTxt.Text;
            string email = emailTxt.Text;
            string pass = passTxt.Text;
            string pass2 = pass2Txt.Text;

            if (pass == pass2)
            {
                if (existUserEmail(name, email))
                {
                    MessageBox.Show("That username or email is already registered.", "Info");
                }
                else
                { //no existe
                  // Consulta SQL para la inserción
                    string insertQuery = "insert INTO User(name, email, password) values(@name,@email,@pass)";

                    // Crear una conexión y un comando
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Asignar parámetros de la consulta                
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@pass", pass);

                        try
                        {
                            // Ejecutar la consulta
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Successful insertion.");
                                MessageBox.Show("Successful insertion.", "Info");

                                LoginForm form = new LoginForm();
                                form.Show();
                                this.Hide();

                            }
                            else
                            {
                                Console.WriteLine("No se insertaron filas.");
                                MessageBox.Show("No se insertaron filas.", "Info");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match.", "Info");
            }

        }

        private Boolean existUserEmail(string user, string email)
        {

            string textoBuscado = userTxt.Text;
            string pass = passTxt.Text;
            Boolean exist = false;

            // Cadena de conexión a la base de datos SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Consulta SQL para verificar si existe el usuario y obtener el correo
            string consulta = "SELECT * FROM User WHERE name = @NombreUsuario or password = @pass";

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    // Parámetro para el nombre de usuario
                    comando.Parameters.AddWithValue("@NombreUsuario", textoBuscado);
                    comando.Parameters.AddWithValue("@pass", pass);

                    // Ejecutar la consulta y obtener el resultado
                    using (SQLiteDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int cantidadUsuarios = lector.GetInt32(0);

                            if (cantidadUsuarios > 0)
                            {
                                exist = true;
                            }

                        }
                    }
                    return exist;
                }
            }
        }

        private void RegisterLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
