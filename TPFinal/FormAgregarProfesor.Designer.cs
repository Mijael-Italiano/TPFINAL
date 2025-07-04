namespace TPFinal
{
    partial class FormAgregarProfesor
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            txtAgregarProfesorNombre = new TextBox();
            txtAgregarProfesorApellido = new TextBox();
            txtAgregarProfesorDNI = new TextBox();
            cmbAgregarProfesorDisciplina = new ComboBox();
            txtAgregarProfesorSueldo = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 129);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // button1
            // 
            button1.Location = new Point(187, 264);
            button1.Name = "button1";
            button1.Size = new Size(156, 39);
            button1.TabIndex = 3;
            button1.Text = "Agregar profesor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 175);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Disciplina";
            // 
            // txtAgregarProfesorNombre
            // 
            txtAgregarProfesorNombre.Location = new Point(60, 40);
            txtAgregarProfesorNombre.Name = "txtAgregarProfesorNombre";
            txtAgregarProfesorNombre.Size = new Size(117, 23);
            txtAgregarProfesorNombre.TabIndex = 5;
            // 
            // txtAgregarProfesorApellido
            // 
            txtAgregarProfesorApellido.Location = new Point(60, 94);
            txtAgregarProfesorApellido.Name = "txtAgregarProfesorApellido";
            txtAgregarProfesorApellido.Size = new Size(117, 23);
            txtAgregarProfesorApellido.TabIndex = 6;
            // 
            // txtAgregarProfesorDNI
            // 
            txtAgregarProfesorDNI.Location = new Point(60, 147);
            txtAgregarProfesorDNI.Name = "txtAgregarProfesorDNI";
            txtAgregarProfesorDNI.Size = new Size(117, 23);
            txtAgregarProfesorDNI.TabIndex = 7;
            // 
            // cmbAgregarProfesorDisciplina
            // 
            cmbAgregarProfesorDisciplina.FormattingEnabled = true;
            cmbAgregarProfesorDisciplina.Location = new Point(60, 193);
            cmbAgregarProfesorDisciplina.Name = "cmbAgregarProfesorDisciplina";
            cmbAgregarProfesorDisciplina.Size = new Size(121, 23);
            cmbAgregarProfesorDisciplina.TabIndex = 8;
            // 
            // txtAgregarProfesorSueldo
            // 
            txtAgregarProfesorSueldo.Location = new Point(60, 247);
            txtAgregarProfesorSueldo.Name = "txtAgregarProfesorSueldo";
            txtAgregarProfesorSueldo.Size = new Size(117, 23);
            txtAgregarProfesorSueldo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 229);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Sueldo";
            // 
            // FormAgregarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 315);
            Controls.Add(label5);
            Controls.Add(txtAgregarProfesorSueldo);
            Controls.Add(cmbAgregarProfesorDisciplina);
            Controls.Add(txtAgregarProfesorDNI);
            Controls.Add(txtAgregarProfesorApellido);
            Controls.Add(txtAgregarProfesorNombre);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregarProfesor";
            Text = "FormAgregarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox txtAgregarProfesorNombre;
        private TextBox txtAgregarProfesorApellido;
        private TextBox txtAgregarProfesorDNI;
        private ComboBox cmbAgregarProfesorDisciplina;
        private TextBox txtAgregarProfesorSueldo;
        private Label label5;
    }
}