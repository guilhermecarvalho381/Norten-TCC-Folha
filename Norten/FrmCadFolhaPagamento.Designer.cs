namespace Norten
{
    partial class FrmCadFolhaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxFolha_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFolha_Salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadFolhaPagamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro Folha de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxFolha_CPF
            // 
            this.txtboxFolha_CPF.Location = new System.Drawing.Point(119, 56);
            this.txtboxFolha_CPF.Name = "txtboxFolha_CPF";
            this.txtboxFolha_CPF.Size = new System.Drawing.Size(142, 20);
            this.txtboxFolha_CPF.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "CPF:";
            // 
            // txtboxFolha_Salario
            // 
            this.txtboxFolha_Salario.Location = new System.Drawing.Point(119, 91);
            this.txtboxFolha_Salario.Name = "txtboxFolha_Salario";
            this.txtboxFolha_Salario.Size = new System.Drawing.Size(142, 20);
            this.txtboxFolha_Salario.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Salario Base:";
            // 
            // btnCadFolhaPagamento
            // 
            this.btnCadFolhaPagamento.Location = new System.Drawing.Point(306, 88);
            this.btnCadFolhaPagamento.Name = "btnCadFolhaPagamento";
            this.btnCadFolhaPagamento.Size = new System.Drawing.Size(75, 23);
            this.btnCadFolhaPagamento.TabIndex = 32;
            this.btnCadFolhaPagamento.Text = "Cadastrar Folha";
            this.btnCadFolhaPagamento.UseVisualStyleBackColor = true;
            this.btnCadFolhaPagamento.Click += new System.EventHandler(this.btnCadFolhaPagamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(119, 167);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 20);
            this.txtTotal.TabIndex = 34;
            // 
            // FrmCadFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(539, 199);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadFolhaPagamento);
            this.Controls.Add(this.txtboxFolha_Salario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxFolha_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadFolhaPagamento";
            this.Text = "Cadastro de Folha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadFolhaPagamento_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxFolha_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFolha_Salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadFolhaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
    }
}