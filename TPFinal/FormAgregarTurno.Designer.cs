namespace TPFinal
{
    partial class FormAgregarTurno
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
            btnAgregarTurno = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAgregarInicioTurno = new TextBox();
            txtAgregarFinalizacionTurno = new TextBox();
            cmbAgregarTurnoDia = new ComboBox();
            cmbAgregarTurnoIdProfesor = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregarTurno
            // 
            btnAgregarTurno.Location = new Point(274, 264);
            btnAgregarTurno.Name = "btnAgregarTurno";
            btnAgregarTurno.Size = new Size(124, 37);
            btnAgregarTurno.TabIndex = 0;
            btnAgregarTurno.Text = "Agregar";
            btnAgregarTurno.UseVisualStyleBackColor = true;
            btnAgregarTurno.Click += btnAgregarTurno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 42);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 99);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 164);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Finalizacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 228);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Profesor Apellido";
            // 
            // txtAgregarInicioTurno
            // 
            txtAgregarInicioTurno.Location = new Point(88, 117);
            txtAgregarInicioTurno.Name = "txtAgregarInicioTurno";
            txtAgregarInicioTurno.Size = new Size(121, 23);
            txtAgregarInicioTurno.TabIndex = 5;
            // 
            // txtAgregarFinalizacionTurno
            // 
            txtAgregarFinalizacionTurno.Location = new Point(88, 182);
            txtAgregarFinalizacionTurno.Name = "txtAgregarFinalizacionTurno";
            txtAgregarFinalizacionTurno.Size = new Size(121, 23);
            txtAgregarFinalizacionTurno.TabIndex = 6;
            // 
            // cmbAgregarTurnoDia
            // 
            cmbAgregarTurnoDia.FormattingEnabled = true;
            cmbAgregarTurnoDia.Location = new Point(88, 60);
            cmbAgregarTurnoDia.Name = "cmbAgregarTurnoDia";
            cmbAgregarTurnoDia.Size = new Size(121, 23);
            cmbAgregarTurnoDia.TabIndex = 7;
            // 
            // cmbAgregarTurnoIdProfesor
            // 
            cmbAgregarTurnoIdProfesor.FormattingEnabled = true;
            cmbAgregarTurnoIdProfesor.Location = new Point(88, 247);
            cmbAgregarTurnoIdProfesor.Name = "cmbAgregarTurnoIdProfesor";
            cmbAgregarTurnoIdProfesor.Size = new Size(121, 23);
            cmbAgregarTurnoIdProfesor.TabIndex = 8;
            // 
            // FormAgregarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 323);
            Controls.Add(cmbAgregarTurnoIdProfesor);
            Controls.Add(cmbAgregarTurnoDia);
            Controls.Add(txtAgregarFinalizacionTurno);
            Controls.Add(txtAgregarInicioTurno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarTurno);
            Name = "FormAgregarTurno";
            Text = "FormAgregarTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarTurno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAgregarInicioTurno;
        private TextBox txtAgregarFinalizacionTurno;
        private ComboBox cmbAgregarTurnoDia;
        private ComboBox cmbAgregarTurnoIdProfesor;
    }
}