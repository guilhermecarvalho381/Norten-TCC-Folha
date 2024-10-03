namespace Norten
{
    partial class FrmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFolhaPagamento));
            this.dataGridViewFolhaPagamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFolha_CPF = new System.Windows.Forms.TextBox();
            this.btnBuscarFolha = new System.Windows.Forms.Button();
            this.btnFormCADFolhaPagamento = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolhaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFolhaPagamento
            // 
            this.dataGridViewFolhaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFolhaPagamento.Location = new System.Drawing.Point(12, 236);
            this.dataGridViewFolhaPagamento.Name = "dataGridViewFolhaPagamento";
            this.dataGridViewFolhaPagamento.Size = new System.Drawing.Size(568, 227);
            this.dataGridViewFolhaPagamento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folha de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // txtboxFolha_CPF
            // 
            this.txtboxFolha_CPF.Location = new System.Drawing.Point(15, 188);
            this.txtboxFolha_CPF.Name = "txtboxFolha_CPF";
            this.txtboxFolha_CPF.Size = new System.Drawing.Size(142, 20);
            this.txtboxFolha_CPF.TabIndex = 27;
            // 
            // btnBuscarFolha
            // 
            this.btnBuscarFolha.Location = new System.Drawing.Point(510, 210);
            this.btnBuscarFolha.Name = "btnBuscarFolha";
            this.btnBuscarFolha.Size = new System.Drawing.Size(70, 20);
            this.btnBuscarFolha.TabIndex = 28;
            this.btnBuscarFolha.Text = "Buscar";
            this.btnBuscarFolha.UseVisualStyleBackColor = true;
            this.btnBuscarFolha.Click += new System.EventHandler(this.BtnBuscarFolha_Click);
            // 
            // btnFormCADFolhaPagamento
            // 
            this.btnFormCADFolhaPagamento.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFormCADFolhaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormCADFolhaPagamento.FlatAppearance.BorderSize = 0;
            this.btnFormCADFolhaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormCADFolhaPagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormCADFolhaPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnFormCADFolhaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCADFolhaPagamento.Location = new System.Drawing.Point(8, 51);
            this.btnFormCADFolhaPagamento.Name = "btnFormCADFolhaPagamento";
            this.btnFormCADFolhaPagamento.Size = new System.Drawing.Size(255, 37);
            this.btnFormCADFolhaPagamento.TabIndex = 30;
            this.btnFormCADFolhaPagamento.Text = "Cadastrar Folha de Pagamento";
            this.btnFormCADFolhaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCADFolhaPagamento.UseVisualStyleBackColor = false;
            this.btnFormCADFolhaPagamento.Click += new System.EventHandler(this.btnFormCADFolhaPagamento_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // FrmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(592, 475);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFormCADFolhaPagamento);
            this.Controls.Add(this.btnBuscarFolha);
            this.Controls.Add(this.txtboxFolha_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFolhaPagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Norten - Folha de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFolhaPagamento_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolhaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFolhaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFolha_CPF;
        private System.Windows.Forms.Button btnBuscarFolha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFormCADFolhaPagamento;
    }
}