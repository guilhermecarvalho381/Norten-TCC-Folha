namespace Norten
{
    partial class FrmConsultaFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFunc));
            this.btnBuscarFunc = new System.Windows.Forms.Button();
            this.txtboxConsultaCad_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewConsultaFunc = new System.Windows.Forms.DataGridView();
            this.picboxFunc_Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFunc_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarFunc
            // 
            this.btnBuscarFunc.Location = new System.Drawing.Point(510, 146);
            this.btnBuscarFunc.Name = "btnBuscarFunc";
            this.btnBuscarFunc.Size = new System.Drawing.Size(70, 20);
            this.btnBuscarFunc.TabIndex = 32;
            this.btnBuscarFunc.Text = "Buscar";
            this.btnBuscarFunc.UseVisualStyleBackColor = true;
            this.btnBuscarFunc.Click += new System.EventHandler(this.btnBuscarFunc_Click);
            // 
            // txtboxConsultaCad_CPF
            // 
            this.txtboxConsultaCad_CPF.Location = new System.Drawing.Point(15, 61);
            this.txtboxConsultaCad_CPF.Name = "txtboxConsultaCad_CPF";
            this.txtboxConsultaCad_CPF.Size = new System.Drawing.Size(142, 20);
            this.txtboxConsultaCad_CPF.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "CPF:";
            // 
            // dataGridViewConsultaFunc
            // 
            this.dataGridViewConsultaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaFunc.Location = new System.Drawing.Point(12, 172);
            this.dataGridViewConsultaFunc.Name = "dataGridViewConsultaFunc";
            this.dataGridViewConsultaFunc.Size = new System.Drawing.Size(568, 197);
            this.dataGridViewConsultaFunc.TabIndex = 29;
            // 
            // picboxFunc_Foto
            // 
            this.picboxFunc_Foto.Image = ((System.Drawing.Image)(resources.GetObject("picboxFunc_Foto.Image")));
            this.picboxFunc_Foto.Location = new System.Drawing.Point(229, 12);
            this.picboxFunc_Foto.Name = "picboxFunc_Foto";
            this.picboxFunc_Foto.Size = new System.Drawing.Size(150, 154);
            this.picboxFunc_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxFunc_Foto.TabIndex = 33;
            this.picboxFunc_Foto.TabStop = false;
            // 
            // FrmConsultaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(600, 381);
            this.Controls.Add(this.picboxFunc_Foto);
            this.Controls.Add(this.btnBuscarFunc);
            this.Controls.Add(this.txtboxConsultaCad_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewConsultaFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Norten - Consulta Funcionários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaFunc_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFunc_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarFunc;
        private System.Windows.Forms.TextBox txtboxConsultaCad_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewConsultaFunc;
        private System.Windows.Forms.PictureBox picboxFunc_Foto;
    }
}