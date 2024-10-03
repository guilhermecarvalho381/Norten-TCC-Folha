using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Norten
{
    public partial class FrmFolhaPagamento : Form
    {
        SqlConnection conn;

        public FrmFolhaPagamento()
        {
            InitializeComponent();

            // Inicialize a conexão no construtor
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");
        }

        // ...

        public void ExibirFolhaPagamento(int idFuncionario)
        {
            string cpf = txtboxFolha_CPF.Text;

            try
            {
                conn.Open();

                string sql = "SELECT ID, Conta, SalarioBase, AdicionalNoturno, AdiantamentoQuinzenal, PlanoDeSaude, " +
                             "INSS, ValeRefeicao, ValeTransporte, FGTS, DecimoTerceiro, Ferias FROM FolhaDePagamento " +
                             "WHERE ID_Func IN (SELECT ID_Func FROM Funcionarios WHERE Func_CPF = @CPF)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFolhaPagamento.DataSource = dt;

                    if (dataGridViewFolhaPagamento.Columns.Contains("ID_Func"))
                    {
                        dataGridViewFolhaPagamento.Columns["ID_Func"].Visible = false;
                    }

                    if (dataGridViewFolhaPagamento.Columns.Contains("ID"))
                    {
                        dataGridViewFolhaPagamento.Columns["ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }



        public int ObterIDFuncionarioPorCPF(string cpf)
        {
            try
            {
                conn.Open();

                string query = "SELECT ID_Func FROM Funcionarios WHERE Func_CPF = @CPF";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void BtnBuscarFolha_Click(object sender, EventArgs e)
        {
            string cpf = txtboxFolha_CPF.Text;
            int idFuncionario = ObterIDFuncionarioPorCPF(cpf);

            if (idFuncionario != -1)
            {
                ExibirFolhaPagamento(idFuncionario);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado. Verifique o CPF inserido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCadFolhaPagamento_Click(object sender, EventArgs e)
        {
            // Implemente aqui o código para cadastrar a folha de pagamento
        }

        private void FrmFolhaPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menuprincipal = new FrmMenu();
            this.Hide();
            menuprincipal.Show();
            conn.Close();
        }

        private void btnFormCADFolhaPagamento_Click(object sender, EventArgs e)
        {
            FrmCadFolhaPagamento CadFolha = new FrmCadFolhaPagamento();
            this.Hide();
            CadFolha.Show();
            conn.Close();
        }
    }
}
