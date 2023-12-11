
using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace CrudCSharp
{
    public partial class Form1 : Form
    {

        private SQLiteConnection conexion;
        private SQLiteDataAdapter adaptador;
        private DataTable tabla;
        public string idUser { get; set; }

        public Form1()
        {
            InitializeComponent();
            ConfigurarConexion();
            ConfigurarDataGridView();
            CargarDatos();

        }

        private void ConfigurarConexion()
        {
            conexion = new SQLiteConnection("Data Source=.\\Vinculation.db;Version=3;");
            adaptador = new SQLiteDataAdapter();
            tabla = new DataTable();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = tabla;
        }

        public void limpiarTabla()
        {
            try
            {
                // Limpiar las filas existentes en el DataGridView
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                tabla = new DataTable();
                ConfigurarDataGridView();
            }
        }

        public void CargarDatos()
        {


            try
            {
                conexion.Open();

                string consulta = "select idStudent, Student.name, Student.lastname, mothersthestName, enrollment, birthdate,curp, Student.phone, rfc,socialSegurity, Student.idEmployee, Employee.name||' '||Employee.lastname||' '||Employee.mothersLastName employee_name from Student INNER JOIN Employee ON Employee.idEmployee = Student.idEmployee";
                adaptador.SelectCommand = new SQLiteCommand(consulta, conexion);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            RegistroActualizaFrm form2 = new RegistroActualizaFrm(this);
            form2.accion = "crear";
            form2.actualizaOpciones();
            form2.idUser = idUser;
            // Mostrar el segundo formulario
            form2.Show();

            // Opcional: Ocultar el primer formulario si es necesario
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de botones Actualizar o Eliminar
            //&& (e.ColumnIndex == dataGridView1.Columns["Actualizar"].Index || e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            if (e.RowIndex >= 0)
            {
                // Obtener la información de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Datos para la inserción            
                // Obtener los valores de las celdas
                string id = filaSeleccionada.Cells["idStudent"].Value.ToString();
                string name = filaSeleccionada.Cells["name"].Value.ToString();
                string last = filaSeleccionada.Cells["lastname"].Value.ToString();
                string mother = filaSeleccionada.Cells["mothersthestName"].Value.ToString();
                string enrollment = filaSeleccionada.Cells["enrollment"].Value.ToString();
                string birthdate = filaSeleccionada.Cells["birthdate"].Value.ToString();
                string curp = filaSeleccionada.Cells["curp"].Value.ToString();
                string phone = filaSeleccionada.Cells["phone"].Value.ToString();
                string socialNumber = filaSeleccionada.Cells["socialSegurity"].Value.ToString();
                string idEmployee = filaSeleccionada.Cells["idEmployee"].Value.ToString();
                string nameEmployee = filaSeleccionada.Cells["employee_name"].Value.ToString();
                string rfc = filaSeleccionada.Cells["rfc"].Value.ToString();

                // Crear una instancia del segundo formulario (Form2)
                RegistroActualizaFrm form2 = new RegistroActualizaFrm(this);
                form2.id = id;
                form2.accion = "modificar";
                form2.name = name;
                form2.lastname = last;
                form2.mothersthestName = mother;
                form2.enrollment = enrollment;
                form2.birthdate = birthdate;
                form2.curp = curp;
                form2.phone = phone;
                form2.socialSegurity = socialNumber;
                form2.idEmployee = idEmployee;
                form2.employee_name = nameEmployee;
                form2.rfc = rfc;
                form2.idUser = idUser;
                // Mostrar el segundo formulario
                form2.actualizaOpciones();
                form2.pintarDatos();
                form2.Show();

                // Opcional: Ocultar el primer formulario si es necesario
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
