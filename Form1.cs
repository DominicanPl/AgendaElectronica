using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Text;


namespace AgendaElectronica
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=Domi,Database=AgendaEDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }


        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertarContacto_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Contactos (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, Correo) " +
                               "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @Correo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@FechaNacimiento", txtCorreo.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    command.Parameters.AddWithValue("@EstadoCivil", txtEstadoCivil.Text);
                    command.Parameters.AddWithValue("@Movil", txtMovil.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    Console.WriteLine(command.ExecuteScalar());
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        private void ModificarContacto_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, " +
                               "Direccion = @Direccion, Genero = @Genero, EstadoCivil = @EstadoCivil, Movil = @Movil, " +
                               "Telefono = @Telefono, Correo = @Correo WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    command.Parameters.AddWithValue("@EstadoCivil", txtEstadoCivil.Text);
                    command.Parameters.AddWithValue("@Movil", txtMovil.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarContactos_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Contactos WHERE Nombre LIKE '%' + @Nombre + '%' OR Apellido LIKE '%' + @Apellido + '%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtBuscarNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtBuscarApellido.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewContactos.DataSource = table;
                }
            }
        }

        private void EliminarContacto_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "DELETE FROM Contactos WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
