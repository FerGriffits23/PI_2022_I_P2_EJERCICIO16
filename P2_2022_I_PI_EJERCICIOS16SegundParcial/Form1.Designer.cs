namespace P2_2022_I_PI_EJERCICIOS16SegundParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMontoPrincipal = new System.Windows.Forms.Label();
            this.lblTzadeinteres = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.ricUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtmontoprincipal = new System.Windows.Forms.TextBox();
            this.txttazadeinteres = new System.Windows.Forms.TextBox();
            this.pnlsalida = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ricUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoPrincipal
            // 
            this.lblMontoPrincipal.AutoSize = true;
            this.lblMontoPrincipal.Location = new System.Drawing.Point(193, 58);
            this.lblMontoPrincipal.Name = "lblMontoPrincipal";
            this.lblMontoPrincipal.Size = new System.Drawing.Size(92, 15);
            this.lblMontoPrincipal.TabIndex = 0;
            this.lblMontoPrincipal.Text = "Monto Principal";
            this.lblMontoPrincipal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTzadeinteres
            // 
            this.lblTzadeinteres.AutoSize = true;
            this.lblTzadeinteres.Location = new System.Drawing.Point(193, 114);
            this.lblTzadeinteres.Name = "lblTzadeinteres";
            this.lblTzadeinteres.Size = new System.Drawing.Size(86, 15);
            this.lblTzadeinteres.TabIndex = 1;
            this.lblTzadeinteres.Text = "Taxe de iNteres";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(193, 170);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(34, 15);
            this.lblAnos.TabIndex = 2;
            this.lblAnos.Text = "Anos";
            // 
            // ricUpDown1
            // 
            this.ricUpDown1.Location = new System.Drawing.Point(249, 173);
            this.ricUpDown1.Name = "ricUpDown1";
            this.ricUpDown1.Size = new System.Drawing.Size(120, 23);
            this.ricUpDown1.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(450, 78);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "calcaulr";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtmontoprincipal
            // 
            this.txtmontoprincipal.Location = new System.Drawing.Point(291, 55);
            this.txtmontoprincipal.Name = "txtmontoprincipal";
            this.txtmontoprincipal.Size = new System.Drawing.Size(100, 23);
            this.txtmontoprincipal.TabIndex = 5;
            // 
            // txttazadeinteres
            // 
            this.txttazadeinteres.Location = new System.Drawing.Point(297, 118);
            this.txttazadeinteres.Name = "txttazadeinteres";
            this.txttazadeinteres.Size = new System.Drawing.Size(100, 23);
            this.txttazadeinteres.TabIndex = 6;
            // 
            // pnlsalida
            // 
            this.pnlsalida.Location = new System.Drawing.Point(324, 231);
            this.pnlsalida.Name = "pnlsalida";
            this.pnlsalida.Size = new System.Drawing.Size(294, 124);
            this.pnlsalida.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlsalida);
            this.Controls.Add(this.txttazadeinteres);
            this.Controls.Add(this.txtmontoprincipal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ricUpDown1);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblTzadeinteres);
            this.Controls.Add(this.lblMontoPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ricUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMontoPrincipal;
        private Label lblTzadeinteres;
        private Label lblAnos;
        private NumericUpDown ricUpDown1;
        private Button btnCalcular;
        private TextBox txtmontoprincipal;
        private TextBox txttazadeinteres;
        private Panel pnlsalida;
    }
}