namespace _2025_2026_DAM_1B_ED_Salas
{
    partial class Form2
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
            this.lblLibres = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir sala";
            // 
            // lblLibres
            // 
            this.lblLibres.AutoSize = true;
            this.lblLibres.Location = new System.Drawing.Point(70, 65);
            this.lblLibres.Name = "lblLibres";
            this.lblLibres.Size = new System.Drawing.Size(73, 13);
            this.lblLibres.TabIndex = 1;
            this.lblLibres.Text = "Butacas libres";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(70, 78);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(126, 13);
            this.lblOcupacion.TabIndex = 2;
            this.lblOcupacion.Text = "Porcentaje de ocupación";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(485, 65);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(95, 13);
            this.lblIngresos.TabIndex = 3;
            this.lblIngresos.Text = "Ingresos de la sala";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(485, 78);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(81, 13);
            this.lblTotales.TabIndex = 4;
            this.lblTotales.Text = "Ingresos totales";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(73, 39);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(300, 23);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "VENDER ENTRADA";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(488, 39);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(300, 23);
            this.btnVaciar.TabIndex = 6;
            this.btnVaciar.Text = "VACIAR SALA";
            this.btnVaciar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(715, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 111);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblLibres);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLibres;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}