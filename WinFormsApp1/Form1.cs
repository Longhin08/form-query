using Npgsql;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txCodSap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            string param = txCodSap.Text;

            if (param != "")
            {

                // Instance your connection
                DBconnection dbCredentials = new DBconnection("HOST_DATABASE", "PORT", "USERNAME", "PASSWORD", "DATABASE");
                dbCredentials.CreateConnection();
                var connection = dbCredentials.ConnectionString;

                // Connecting to the database
                using var conn = new NpgsqlConnection(connection);

                //Trying to execute query
                try
                {
                    conn.Open();

                    using var cmd = new NpgsqlCommand("Your QUERY", conn);
                    using var adapter = new NpgsqlDataAdapter(cmd);
                    var result = cmd.ExecuteScalar();
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dvFornecedores.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar no banco: {ex}");
                }

            }
            else
            {
                MessageBox.Show("Erro");
            }


        }

        private void dvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
