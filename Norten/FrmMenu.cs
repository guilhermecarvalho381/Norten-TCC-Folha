using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norten
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnFormCadFunc_Click(object sender, EventArgs e)
        {
            FrmCadFunc cadFunc = new FrmCadFunc();
            this.Hide();
            cadFunc.Show();
        }

        private void btnFormFolhaPagamento_Click(object sender, EventArgs e)
        {
            FrmFolhaPagamento FP = new FrmFolhaPagamento();
            this.Hide();
            FP.Show();
        }

        private void btnConsultaFerias_Click(object sender, EventArgs e)
        {
            FrmConsultaFerias CF = new FrmConsultaFerias();
            this.Hide();
            CF.Show();
        }

        private void btnFormListFunc_Click(object sender, EventArgs e)
        {
            FrmConsultaFunc CFunc = new FrmConsultaFunc();
            this.Hide();
            CFunc.Show();
        }
    }
}
