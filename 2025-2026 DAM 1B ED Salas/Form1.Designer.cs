namespace _2025_2026_DAM_1B_ED_Salas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.nudAforo = new System.Windows.Forms.NumericUpDown();
            this.nudOcupadas = new System.Windows.Forms.NumericUpDown();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb65 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Película";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aforo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocupadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(46, 12);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(742, 21);
            this.cbSala.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Controls.Add(this.rb65);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.nudOcupadas);
            this.groupBox1.Controls.Add(this.nudAforo);
            this.groupBox1.Controls.Add(this.txtPelicula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 370);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(68, 19);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(702, 20);
            this.txtPelicula.TabIndex = 5;
            // 
            // nudAforo
            // 
            this.nudAforo.Location = new System.Drawing.Point(68, 45);
            this.nudAforo.Name = "nudAforo";
            this.nudAforo.Size = new System.Drawing.Size(120, 20);
            this.nudAforo.TabIndex = 6;
            // 
            // nudOcupadas
            // 
            this.nudOcupadas.Location = new System.Drawing.Point(68, 71);
            this.nudOcupadas.Name = "nudOcupadas";
            this.nudOcupadas.Size = new System.Drawing.Size(120, 20);
            this.nudOcupadas.TabIndex = 7;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(721, 45);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(40, 17);
            this.rb5.TabIndex = 8;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 €";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb65
            // 
            this.rb65.AutoSize = true;
            this.rb65.Location = new System.Drawing.Point(721, 68);
            this.rb65.Name = "rb65";
            this.rb65.Size = new System.Drawing.Size(49, 17);
            this.rb65.TabIndex = 9;
            this.rb65.TabStop = true;
            this.rb65.Text = "6,5 €";
            this.rb65.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(721, 91);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(40, 17);
            this.rb8.TabIndex = 10;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 €";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(12, 415);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(776, 23);
            this.btnTerminado.TabIndex = 7;
            this.btnTerminado.Text = "TERMINADO";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb65;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.NumericUpDown nudOcupadas;
        private System.Windows.Forms.NumericUpDown nudAforo;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Button btnTerminado;
    }
}

