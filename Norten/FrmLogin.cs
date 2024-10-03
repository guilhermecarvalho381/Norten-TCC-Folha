using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Norten
{
    public partial class FrmLogin : Form
    {
        //Referencia de Conexão
        //Mudar Data Source e se possivel Initial Catalog
        //Data Source = Servidor do Banco (Localhost / Servidor)
        //Initial Catalog = Banco de Dados em si (Norten/Cadastro)

        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Norten;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
            txtFunc_RH_User.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            conn.Open();

            //Iniciando processo de Select
            string sqlSelect = "SELECT * FROM Func_Usuario_RH WHERE RH_Login ='" + txtFunc_RH_User.Text + "' AND RH_senha ='" + txtSenha.Text + "' ";
            SqlDataAdapter dp = new SqlDataAdapter(sqlSelect, conn);
            DataTable dt = new DataTable();
            dp.Fill(dt);

           
            if (dt.Rows.Count == 1)
            {
                FrmMenu menuprincipal = new FrmMenu();
                this.Hide();
                menuprincipal.Show();
                conn.Close();
            }

            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFunc_RH_User.Text = "";
                txtSenha.Text = "";
                txtFunc_RH_User.Select();
                conn.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
