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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Norten
{
    public partial class FrmCadFunc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");

        public FrmCadFunc()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Mostra o painel
                panelFuncRH.Visible = true;
            }
            else
            {
                // Oculta o painel
                panelFuncRH.Visible = false;
            }
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = dialog.FileName;
                picboxFunc_Foto.Image = Image.FromFile(caminhoDaImagem);
            }
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            conn.Open();

            int? idLoginRH = null;

            if (checkBox1.Checked)
            {
                string consultaUsuarioRH = "INSERT INTO Func_Usuario_RH (RH_Login, RH_Senha) VALUES (@LoginRH, @SenhaRH); SELECT SCOPE_IDENTITY();";
                SqlCommand comandoUsuarioRH = new SqlCommand(consultaUsuarioRH, conn);
                comandoUsuarioRH.Parameters.AddWithValue("@LoginRH", txtboxFunc_RH_Login.Text);
                comandoUsuarioRH.Parameters.AddWithValue("@SenhaRH", txtboxFunc_RH_Senha.Text);
                idLoginRH = Convert.ToInt32(comandoUsuarioRH.ExecuteScalar());
            }

            string consultaFuncionario = "INSERT INTO Funcionarios (Func_CPF, Func_NomeCompleto, Func_DataNascimento, Func_Genero, Func_EstadoCivil, Func_Identificacao, Func_Endereco, Func_TelefoneCelular, Func_Email, Func_Cargo, Func_Departamento, Func_DataAdmissao, Func_Salario, Func_CarteiraTrabalho, Func_Foto, Func_Senha, idLogin) VALUES (@CPF, @Nome, @DataNascimento, @Genero, @EstadoCivil, @Identificacao, @Endereco, @Telefone, @Email, @Cargo, @Departamento, @DataAdmissao, @Salario, @CarteiraTrabalho, @Foto, @Senha, @idLogin)";

            SqlCommand comando = new SqlCommand(consultaFuncionario, conn);
            comando.Parameters.AddWithValue("@CPF", txtboxFunc_CPF.Text);
            comando.Parameters.AddWithValue("@Senha", txtboxFunc_Senha.Text);
            comando.Parameters.AddWithValue("@Nome", txtboxFunc_Nome.Text);
            comando.Parameters.AddWithValue("@DataNascimento", dateFunc_DataNasc.Value);
            comando.Parameters.AddWithValue("@Genero", txtboxFunc_Gen.Text);
            comando.Parameters.AddWithValue("@EstadoCivil", txtboxFunc_EC.Text);
            comando.Parameters.AddWithValue("@Identificacao", txtboxFunc_Ident.Text);
            comando.Parameters.AddWithValue("@Endereco", txtboxFunc_End.Text);
            comando.Parameters.AddWithValue("@Telefone", txtboxFunc_Tel.Text);
            comando.Parameters.AddWithValue("@Email", txtboxFunc_Email.Text);
            comando.Parameters.AddWithValue("@Cargo", txtboxFunc_Cargo.Text);
            comando.Parameters.AddWithValue("@Departamento", txtboxFunc_Depart.Text);
            comando.Parameters.AddWithValue("@DataAdmissao", dateFunc_DataAdm.Value);
            comando.Parameters.AddWithValue("@Salario", Convert.ToDecimal(txtboxFunc_Sal.Text));
            comando.Parameters.AddWithValue("@CarteiraTrabalho", txtboxFunc_Carteira.Text);

            if (picboxFunc_Foto.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                picboxFunc_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imagemBytes = ms.ToArray();
                SqlParameter paramFoto = new SqlParameter("@Foto", SqlDbType.VarBinary, -1);
                paramFoto.Value = imagemBytes;
                comando.Parameters.Add(paramFoto);
            }
            else
            {
                comando.Parameters.AddWithValue("@Foto", DBNull.Value);
            }

            if (idLoginRH != null)
            {
                comando.Parameters.AddWithValue("@idLogin", idLoginRH);
            }
            else
            {
                comando.Parameters.AddWithValue("@idLogin", DBNull.Value);
            }

            comando.ExecuteNonQuery();

            conn.Close();

            LimparCampos(panelCadFunc);

            MessageBox.Show("Cadastro concluído com sucesso!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }

        private void btnLimparCampo_Click(object sender, EventArgs e)
        {
            LimparCampos(panelCadFunc);
        }

        public void LimparCampos(Panel panel)
        {
            foreach (TextBox textbox in panel.Controls.OfType<TextBox>())
            {
                textbox.Text = "";
            }
        }

        private void FrmCadFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menuprincipal = new FrmMenu();
            this.Hide();
            menuprincipal.Show();
            conn.Close();
        }
    }
}
