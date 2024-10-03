using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norten
{
    public partial class FrmConsultaFerias : Form
    {
        SqlConnection conn;

        public FrmConsultaFerias()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");

        }

        private void FrmConsultaFerias_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menuprincipal = new FrmMenu();
            this.Hide();
            menuprincipal.Show();
            conn.Close();
        }

        private void btnConsultarFerias_Click(object sender, EventArgs e)
        {
           
                string cpf = txtboxFerias_CPF.Text;
                DateTime dataFeriasDesejadas = datetimeFerias.Value; // Obtendo a data do DateTimePicker

                try
                {
                    conn.Open();

                    string sql = "SELECT Func_CPF, Func_DataAdmissao FROM Funcionarios WHERE Func_CPF = @CPF";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CPF", cpf);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string cpfEncontrado = reader["Func_CPF"].ToString();
                        DateTime dataAdmissao = Convert.ToDateTime(reader["Func_DataAdmissao"]);

                        TimeSpan diferenca = dataFeriasDesejadas - dataAdmissao; // Calcula a diferença em dias

                        int anosDeAdmissao = (int)(diferenca.TotalDays / 365);

                        if (anosDeAdmissao >= 1)
                        {
                            MessageBox.Show("O funcionário com CPF " + cpfEncontrado + " é elegível para férias.", "Elegível", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O funcionário com CPF " + cpfEncontrado + " não é elegível para férias.", "Não Elegível", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

