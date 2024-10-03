namespace Norten
{
    partial class FrmConsultaFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFerias));
            this.datetimeFerias = new System.Windows.Forms.DateTimePicker();
            this.txtboxFerias_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarFerias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datetimeFerias
            // 
            this.datetimeFerias.Location = new System.Drawing.Point(87, 192);
            this.datetimeFerias.Name = "datetimeFerias";
            this.datetimeFerias.Size = new System.Drawing.Size(234, 20);
            this.datetimeFerias.TabIndex = 0;
            // 
            // txtboxFerias_CPF
            // 
            this.txtboxFerias_CPF.Location = new System.Drawing.Point(87, 115);
            this.txtboxFerias_CPF.Name = "txtboxFerias_CPF";
            this.txtboxFerias_CPF.Size = new System.Drawing.Size(234, 20);
            this.txtboxFerias_CPF.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data desejada:";
            // 
            // btnConsultarFerias
            // 
            this.btnConsultarFerias.Location = new System.Drawing.Point(166, 244);
            this.btnConsultarFerias.Name = "btnConsultarFerias";
            this.btnConsultarFerias.Size = new System.Drawing.Size(70, 20);
            this.btnConsultarFerias.TabIndex = 31;
            this.btnConsultarFerias.Text = "Consultar";
            this.btnConsultarFerias.UseVisualStyleBackColor = true;
            this.btnConsultarFerias.Click += new System.EventHandler(this.btnConsultarFerias_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Consultar Férias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultaFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(402, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultarFerias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxFerias_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetimeFerias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Norten - Consultar Férias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaFerias_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimeFerias;
        private System.Windows.Forms.TextBox txtboxFerias_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarFerias;
        private System.Windows.Forms.Label label3;
    }
}