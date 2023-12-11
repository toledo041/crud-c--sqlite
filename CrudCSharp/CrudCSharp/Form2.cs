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

namespace CrudCSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string textoBuscado = userTxt.Text;
            string pass = passTxt.Text;

            // Cadena de conexión a la base de datos SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Consulta SQL para verificar si existe el usuario y obtener el correo
            string consulta = "SELECT COUNT(*), idUser FROM User WHERE name = @NombreUsuario and password = @pass";

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
                                // El usuario existe, obtener el correo electrónico
                                int iduser = lector.GetInt32(1);

                                Form1 form = new Form1();
                                form.idUser = "" + iduser;
                                // Mostrar el segundo formulario
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                // El usuario no existe, informar al usuario
                                Console.WriteLine("El usuario no existe.");
                                MessageBox.Show("El usuario no existe.", "Mensaje");
                                // Puedes agregar aquí la lógica para mostrar un mensaje al usuario
                            }
                        }
                    }
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterLogin form = new RegisterLogin();
            form.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void forgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotForm form = new ForgotForm();
            form.Show();
            this.Hide();
        }
    }
}
