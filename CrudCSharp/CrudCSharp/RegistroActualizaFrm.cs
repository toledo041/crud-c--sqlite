using CrudCSharp.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCSharp
{
    public partial class RegistroActualizaFrm : Form
    {
        private Form1 referenciaForm1;
        public string accion { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string mothersthestName { get; set; }
        public string enrollment { get; set; }
        public string birthdate { get; set; }
        public string curp { get; set; }
        public string phone { get; set; }
        public string rfc { get; set; }
        public string socialSegurity { get; set; }
        public string idEmployee { get; set; }
        public string employee_name { get; set; }

        public string idUser { get; set; }

        // Constructor que acepta una referencia a Form1
        public RegistroActualizaFrm(Form1 form1)
        {
            InitializeComponent();
            referenciaForm1 = form1;
        }


        private void guardarBtn_Click(object sender, EventArgs e)
        {

            // Cadena de conexión a la base de datos SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Datos para la inserción            
            string name = nameTxt.Text;
            string last = lastNameTxt.Text;
            string mother = motherLastNameTxt.Text;
            string enrollment = enrollmentTxt.Text;
            string birthdate = birthDatePicker.Text;
            string curp = curpTxt.Text;
            string phone = phoneTxt.Text;
            string rfc = rfcTxt.Text;
            string socialNumber = socialSegurityTxt.Text;


            if (name == "" || last == "" || mother == "" || enrollment == "" || birthdate == "" || curp == "" || phone == "" || rfc == "" || rfc == "" || socialNumber == "" )
            {
                MessageBox.Show("You must capture all fields to continue.", "Info");
                return;
            }

            int employeeId = 0;
            try
            {
                ComboboxItem selectedItem = (ComboboxItem)comboBox1.SelectedItem;
                if(selectedItem != null) { 
                    employeeId = selectedItem.Value;
                    string employeeName = selectedItem.Text;
                }else
                    employeeId = int.Parse(idEmployee);
            }
            catch (Exception) {
                employeeId = int.Parse(idEmployee);
            }

           
            
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Formatear la fecha en un formato personalizado
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

            if (accion == "crear")
            {

                // Consulta SQL para la inserción
                string insertQuery = "insert INTO Student(name, lastname, mothersthestName, enrollment, birthdate, curp, phone, rfc, socialSegurity, idEmployee, idUserCreate, dateCreate) " +
                    "values(@name,@last,@mother,@enrollment,@birthdate,@curp,@phone,@rfc,@socialNumber,@idEmployee,@idUser,@create)";

                Console.WriteLine("QUERY: " + insertQuery);
                // Crear una conexión y un comando
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Asignar parámetros de la consulta                
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@last", last);
                    command.Parameters.AddWithValue("@mother", mother);
                    command.Parameters.AddWithValue("@enrollment", enrollment);
                    command.Parameters.AddWithValue("@birthdate", birthdate);
                    command.Parameters.AddWithValue("@curp", curp);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@rfc", rfc);
                    command.Parameters.AddWithValue("@socialNumber", socialNumber);
                    command.Parameters.AddWithValue("@idEmployee", employeeId);
                    command.Parameters.AddWithValue("@idUser", idUser);
                    command.Parameters.AddWithValue("@create", fechaFormateada);

                    try
                    {
                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Inserción exitosa.");
                            MessageBox.Show("Successful insertion.", "Info");
                        }
                        else
                        {
                            Console.WriteLine("No se insertaron filas.");
                            MessageBox.Show("No rows were inserted.", "Info");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                //modificar
                try
                {
                    using (SQLiteConnection conexion = new SQLiteConnection("Data Source=.\\Vinculation.db;Version=3;"))
                    {

                        // Obtener la fecha actual
                        fechaActual = DateTime.Now;

                        // Formatear la fecha en un formato personalizado
                        fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

                        conexion.Open();

                        string consulta = "UPDATE Student SET name = @name, lastname = @last, mothersthestName = @mother, enrollment = @enrollment, birthdate = @birthdate, curp = @curp, phone = @phone, rfc = @rfc, socialSegurity = @socialNumber, idEmployee = @idEmployee, idUserModified = @idUser, dateModified = @modi WHERE idStudent = @ID";

                        using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@name", name);
                            comando.Parameters.AddWithValue("@last", last);
                            comando.Parameters.AddWithValue("@mother", mother);
                            comando.Parameters.AddWithValue("@enrollment", enrollment);
                            comando.Parameters.AddWithValue("@birthdate", birthdate);
                            comando.Parameters.AddWithValue("@curp", curp);
                            comando.Parameters.AddWithValue("@phone", phone);
                            comando.Parameters.AddWithValue("@rfc", rfc);
                            comando.Parameters.AddWithValue("@socialNumber", socialNumber);
                            comando.Parameters.AddWithValue("@idEmployee", employeeId);
                            comando.Parameters.AddWithValue("@idUser", idUser);
                            comando.Parameters.AddWithValue("@modi", fechaFormateada);
                            comando.Parameters.AddWithValue("@ID", id);

                            int rowsAffected = comando.ExecuteNonQuery();

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
                                    MessageBox.Show("No rows were updated.", "Info");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Mostrar Form1 utilizando la referencia almacenada
            referenciaForm1.limpiarTabla();
            referenciaForm1.CargarDatos();
            referenciaForm1.idUser = idUser;
            referenciaForm1.Show();

            // Cerrar el segundo formulario si es necesario
            this.Close();
        }

        public void actualizaOpciones()
        {
            if (accion == "crear")
            {
                guardarBtn.Text = "Registrar";
                borrarBtn.Visible = false;
            }
            else
            {
                guardarBtn.Text = "Actualizar";
                borrarBtn.Visible = true;
            }

        }

        public void pintarDatos()
        {
            // Datos para la inserción            
            nameTxt.Text = name;
            lastNameTxt.Text = lastname;
            motherLastNameTxt.Text = mothersthestName;
            enrollmentTxt.Text = enrollment;
            birthDatePicker.Text = birthdate;
            curpTxt.Text = curp;
            phoneTxt.Text = phone;
            rfcTxt.Text = rfc;
            socialSegurityTxt.Text = socialSegurity;
            int resultado = int.Parse(idEmployee);

            ComboboxItem seletedItem = new ComboboxItem(); //new ComboboxItem { Value = resultado, Text = employee_name };
                

            PoblarComboBox();
            foreach (var item in comboBox1.Items)
            {
                // Suponiendo que tu clase de objeto tiene una propiedad "Description"
                int currentDescription = ((ComboboxItem)item).Value;

                // Comparar la descripción actual con la deseada
                if (currentDescription == resultado)
                {
                    // Si hay coincidencia, obtén el valor del objeto o realiza la acción necesaria
                    //int desiredID = ((ComboboxItem)item).Value;
                    seletedItem = ((ComboboxItem)item);
                    Console.WriteLine("selected "+seletedItem.Text);
                    //MessageBox.Show("selected " + seletedItem.Text, "Info");
                    break;  // Puedes salir del bucle si encuentras la coincidencia
                }
            }
           comboBox1.SelectedItem = seletedItem;
           
            

        }

        private void RegistroActualizaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RegistroActualizaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            referenciaForm1.idUser = idUser;
            referenciaForm1.Show();

        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection("Data Source=.\\Vinculation.db;Version=3;"))
                {
                    conexion.Open();

                    string consulta = "UPDATE Student SET status = 0 WHERE idStudent = @ID";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", id);

                        //comando.ExecuteNonQuery();
                        int rowsAffected = comando.ExecuteNonQuery();

                        try
                        {

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item was successfully deleted.", "Info");
                            }
                            else
                            {
                                MessageBox.Show("No items were deleted.", "Info");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }

                // Actualizar la tabla después de la eliminación

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // Mostrar Form1 utilizando la referencia almacenada
            referenciaForm1.limpiarTabla();
            referenciaForm1.CargarDatos();
            referenciaForm1.idUser = idUser;
            referenciaForm1.Show();

            // Cerrar el segundo formulario si es necesario
            this.Close();
        }

        private void PoblarComboBox()
        {
            // Configura la cadena de conexión para SQLite
            string connectionString = "Data Source=.\\Vinculation.db;Version=3;";

            // Define la consulta SQL
            string query = "SELECT idEmployee, name||' '||lastname||' '||mothersLastName name FROM Employee";

            // Crea una conexión SQLite
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();

                // Crea un comando SQLite
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Crea un lector de datos SQLite
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Limpia el ComboBox antes de agregar nuevos elementos                        
                        comboBox1.Items.Clear();

                        // Agrega los elementos al ComboBox
                        while (reader.Read())
                        {
                            // Asegúrate de adaptar el índice a tus necesidades
                            int id = Convert.ToInt32(reader["idEmployee"]);
                            string nombre = reader["name"].ToString();

                            // Agrega el elemento al ComboBox
                            comboBox1.Items.Add(new ComboboxItem { Value = id, Text = nombre });
                        }
                        comboBox1.SelectedIndex = 1;
                    }
                }
            }
        }

        private void RegistroActualizaFrm_Load(object sender, EventArgs e)
        {
            PoblarComboBox();
        }
    }

}

// Clase auxiliar para almacenar el Id y el Texto en el ComboBox
public class ComboboxItem
{
    public int Value { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
