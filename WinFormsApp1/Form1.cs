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

                DBconnection dbCredentials = new DBconnection();

                dbCredentials.DataBase = "postgres";
                dbCredentials.Password = "OptzTech2025";
                dbCredentials.Username = "postgres";
                dbCredentials.Host = "192.168.50.160";
                dbCredentials.Port = "5432";
                dbCredentials.CreateConnection();
                var connection = dbCredentials.connectionString;


                using var conn = new NpgsqlConnection(connection);
                try
                {
                    conn.Open();

                    using var cmd = new NpgsqlCommand(@"SELECT DISTINCT fornecedor_cnpj, fornecedor_codigo_sap, fornecedor_nome, fornecedor_endereco, fornecedor_telefone, fornecedor_email, material_nome FROM importacao i WHERE material_codigo_sap = '30040866' AND fornecedor_cnpj IS NOT NULL AND fornecedor_codigo_sap IS NOT NULL AND fornecedor_nome IS NOT NULL;", conn);
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
