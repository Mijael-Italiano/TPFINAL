namespace TPFinal
{
    partial class FormModificarProfesor
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
            btnModificarProfesor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreProfesor = new TextBox();
            txtApellidoProfesor = new TextBox();
            txtDNIProfesor = new TextBox();
            txtSueldoProfesor = new TextBox();
            SuspendLayout();
            // 
            // btnModificarProfesor
            // 
            btnModificarProfesor.Location = new Point(176, 305);
            btnModificarProfesor.Name = "btnModificarProfesor";
            btnModificarProfesor.Size = new Size(119, 40);
            btnModificarProfesor.TabIndex = 0;
            btnModificarProfesor.Text = "Modificar";
            btnModificarProfesor.UseVisualStyleBackColor = true;
            btnModificarProfesor.Click += btnModificarProfesor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 160);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 220);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Sueldo";
            // 
            // txtNombreProfesor
            // 
            txtNombreProfesor.Location = new Point(94, 60);
            txtNombreProfesor.Name = "txtNombreProfesor";
            txtNombreProfesor.Size = new Size(100, 23);
            txtNombreProfesor.TabIndex = 5;
            // 
            // txtApellidoProfesor
            // 
            txtApellidoProfesor.Location = new Point(94, 117);
            txtApellidoProfesor.Name = "txtApellidoProfesor";
            txtApellidoProfesor.Size = new Size(100, 23);
            txtApellidoProfesor.TabIndex = 6;
            // 
            // txtDNIProfesor
            // 
            txtDNIProfesor.Location = new Point(93, 178);
            txtDNIProfesor.Name = "txtDNIProfesor";
            txtDNIProfesor.Size = new Size(100, 23);
            txtDNIProfesor.TabIndex = 7;
            // 
            // txtSueldoProfesor
            // 
            txtSueldoProfesor.Location = new Point(94, 238);
            txtSueldoProfesor.Name = "txtSueldoProfesor";
            txtSueldoProfesor.Size = new Size(100, 23);
            txtSueldoProfesor.TabIndex = 8;
            // 
            // FormModificarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 357);
            Controls.Add(txtSueldoProfesor);
            Controls.Add(txtDNIProfesor);
            Controls.Add(txtApellidoProfesor);
            Controls.Add(txtNombreProfesor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificarProfesor);
            Name = "FormModificarProfesor";
            Text = "FormModificarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarProfesor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreProfesor;
        private TextBox txtApellidoProfesor;
        private TextBox txtDNIProfesor;
        private TextBox txtSueldoProfesor;
    }
}