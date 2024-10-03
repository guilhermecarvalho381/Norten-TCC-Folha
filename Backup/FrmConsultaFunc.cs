using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norten
{
    public partial class FrmConsultaFunc : Form
    {
       SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");

        public FrmConsultaFunc()
        {
            InitializeComponent();
        }

        private void FrmConsultaFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menuprincipal = new FrmMenu();
            this.Hide();
            menuprincipal.Show();
            conn.Close();
        }

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            string cpf = txtboxConsultaCad_CPF.Text;

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Funcionarios WHERE Func_CPF = @CPF";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CPF", cpf);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Remove as colunas de login, senha e id
                dataTable.Columns.Remove("idLogin");
                dataTable.Columns.Remove("Func_Senha");

                dataGridViewConsultaFunc.DataSource = dataTable;

                if (dataTable.Rows.Count > 0)
                {
                    byte[] fotoBytes = (byte[])dataTable.Rows[0]["Func_Foto"];
                    MemoryStream ms = new MemoryStream(fotoBytes);
                    picboxFunc_Foto.Image = Image.FromStream(ms);
                }
                else
                {
                    picboxFunc_Foto.Image = null; // Limpa a imagem se nenhum registro for encontrado
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
