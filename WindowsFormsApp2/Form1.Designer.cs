
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblTDI = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPDT = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTDI = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCapital.Location = new System.Drawing.Point(76, 24);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(51, 17);
            this.lblCapital.TabIndex = 0;
            this.lblCapital.Text = "Capital";
            // 
            // lblTDI
            // 
            this.lblTDI.AutoSize = true;
            this.lblTDI.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTDI.Location = new System.Drawing.Point(432, 24);
            this.lblTDI.Name = "lblTDI";
            this.lblTDI.Size = new System.Drawing.Size(107, 17);
            this.lblTDI.TabIndex = 1;
            this.lblTDI.Text = "Tasa de interés";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTiempo.Location = new System.Drawing.Point(76, 219);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(55, 17);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblPDT
            // 
            this.lblPDT.AutoSize = true;
            this.lblPDT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPDT.ForeColor = System.Drawing.Color.Black;
            this.lblPDT.Location = new System.Drawing.Point(431, 219);
            this.lblPDT.Name = "lblPDT";
            this.lblPDT.Size = new System.Drawing.Size(127, 17);
            this.lblPDT.TabIndex = 3;
            this.lblPDT.Text = "Periodo de tiempo:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTiempo.Location = new System.Drawing.Point(30, 251);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(144, 22);
            this.txtTiempo.TabIndex = 4;
            // 
            // txtTDI
            // 
            this.txtTDI.BackColor = System.Drawing.SystemColors.Info;
            this.txtTDI.Location = new System.Drawing.Point(390, 53);
            this.txtTDI.Name = "txtTDI";
            this.txtTDI.Size = new System.Drawing.Size(175, 22);
            this.txtTDI.TabIndex = 5;
            // 
            // txtCapital
            // 
            this.txtCapital.BackColor = System.Drawing.SystemColors.Info;
            this.txtCapital.Location = new System.Drawing.Point(30, 53);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(144, 22);
            this.txtCapital.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Diario"});
            this.comboBox1.Location = new System.Drawing.Point(390, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gold;
            this.btnCalcular.Location = new System.Drawing.Point(255, 321);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 405);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtTDI);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblPDT);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTDI);
            this.Controls.Add(this.lblCapital);
            this.Name = "Form1";
            this.Text = "Calculo de interés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblTDI;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPDT;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTDI;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

