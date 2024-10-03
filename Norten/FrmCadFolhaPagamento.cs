using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Norten
{
    public partial class FrmCadFolhaPagamento : Form
    {
        SqlConnection conn;

        public FrmCadFolhaPagamento()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");

        }

        public class FolhaDePagamento
        {
            public int ID_Func { get; set; }
            public decimal SalarioBase { get; set; }
            public decimal AdicionalNoturno { get; set; }
            public decimal AdiantamentoQuinzenal { get; set; }
            public decimal PlanoDeSaude { get; set; }
            public decimal INSS { get; set; }
            public decimal ValeRefeicao { get; set; }
            public decimal ValeTransporte { get; set; }
            public decimal FGTS { get; set; }
            public decimal DecimoTerceiro { get; set; }
            public decimal Ferias { get; set; }

            public void CalcularFolhaDePagamento()
            {
                AdicionalNoturno = SalarioBase * 0.2m;
                AdiantamentoQuinzenal = 100.00m;
                PlanoDeSaude = 50.00m;
                INSS = 200.00m;
                ValeRefeicao = 900.00m;
                ValeTransporte = 400.00m;
                FGTS = SalarioBase * 0.08m;
                DecimoTerceiro = SalarioBase / 12;
                Ferias = SalarioBase * 1.33m;
            }

            public decimal CalcularTotalFolhaDePagamento()
            {
                return SalarioBase + AdicionalNoturno + AdiantamentoQuinzenal + PlanoDeSaude - INSS - ValeRefeicao - ValeTransporte + FGTS + DecimoTerceiro + Ferias;
            }
        }

        public int ObterIDFuncionarioPorCPF(string cpf)
        {
            int id = -1; // Define um valor padrão para o caso do CPF não ser encontrado.

            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT ID_Func FROM Funcionarios WHERE Func_CPF = @CPF";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }

            return id;
        }


        public void btnCadFolhaPagamento_Click(object sender, EventArgs e)
        {
            string cpf = txtboxFolha_CPF.Text;
            int idFuncionario = ObterIDFuncionarioPorCPF(cpf);

            if (idFuncionario != -1)
            {
                decimal salarioBase = decimal.Parse(txtboxFolha_Salario.Text);

                // Calculando os valores das colunas calculadas
                decimal adicionalNoturno = salarioBase * 0.2m;
                decimal fgts = salarioBase * 0.8m;
                decimal decimoTerceiro = salarioBase / 12;
                decimal feriasconta = salarioBase / 3m;
                decimal ferias = salarioBase + feriasconta;

                try
                {
                    conn.Open();

                    string sql = "INSERT INTO FolhaDePagamento (ID_Func, Conta, SalarioBase, AdicionalNoturno, FGTS, DecimoTerceiro, Ferias) " +
                                 "VALUES (@ID_Func, @Conta, @SalarioBase, @AdicionalNoturno, @FGTS, @DecimoTerceiro, @Ferias)";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@ID_Func", idFuncionario);
                        command.Parameters.AddWithValue("@Conta", "Conta do Funcionário");
                        command.Parameters.AddWithValue("@SalarioBase", salarioBase);
                        command.Parameters.AddWithValue("@AdicionalNoturno", adicionalNoturno);
                        command.Parameters.AddWithValue("@FGTS", fgts);
                        command.Parameters.AddWithValue("@DecimoTerceiro", decimoTerceiro);
                        command.Parameters.AddWithValue("@Ferias", ferias);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Folha de pagamento inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Funcionário não encontrado. Verifique o CPF inserido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void FrmCadFolhaPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmFolhaPagamento FP = new FrmFolhaPagamento();
            this.Hide();
            FP.Show();
            conn.Close();
        }
    }
}
