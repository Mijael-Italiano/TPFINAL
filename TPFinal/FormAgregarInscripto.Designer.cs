namespace TPFinal
{
    partial class FormAgregarInscripto
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAlta = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 92);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(184, 138);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(184, 196);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 141);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 199);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(158, 262);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(126, 28);
            btnAlta.TabIndex = 6;
            btnAlta.Text = "Aceptar";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(158, 27);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 7;
            label4.Text = "Alta inscripción";
            // 
            // FormAgregarInscripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 316);
            Controls.Add(label4);
            Controls.Add(btnAlta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormAgregarInscripto";
            Text = "FormAgregarInscripto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label2;
        private Label label3;
        private Button btnAlta;
        private Label label4;
    }
}