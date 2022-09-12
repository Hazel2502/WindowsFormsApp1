
namespace WindowsFormsApp1
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.comboOperaciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumero1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNumero1.Location = new System.Drawing.Point(68, 41);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(70, 17);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumero2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNumero2.Location = new System.Drawing.Point(491, 41);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(70, 17);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2";
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOperaciones.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOperaciones.Location = new System.Drawing.Point(68, 198);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(89, 17);
            this.lblOperaciones.TabIndex = 2;
            this.lblOperaciones.Text = "Operaciones";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.Gray;
            this.txtNum1.ForeColor = System.Drawing.Color.Black;
            this.txtNum1.Location = new System.Drawing.Point(18, 71);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(171, 22);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.Gray;
            this.txtNum2.ForeColor = System.Drawing.Color.Black;
            this.txtNum2.Location = new System.Drawing.Point(431, 71);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(189, 22);
            this.txtNum2.TabIndex = 4;
            // 
            // comboOperaciones
            // 
            this.comboOperaciones.BackColor = System.Drawing.Color.Gray;
            this.comboOperaciones.FormattingEnabled = true;
            this.comboOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.comboOperaciones.Location = new System.Drawing.Point(18, 244);
            this.comboOperaciones.Name = "comboOperaciones";
            this.comboOperaciones.Size = new System.Drawing.Size(171, 24);
            this.comboOperaciones.TabIndex = 5;
            this.comboOperaciones.SelectedIndexChanged += new System.EventHandler(this.comboOperaciones_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(431, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 68);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 370);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboOperaciones);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox comboOperaciones;
        private System.Windows.Forms.Button btnCalcular;
    }
}

