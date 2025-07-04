namespace TPFinal
{
    partial class FormAgregarClase
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
            cmbAgregarClase = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtAgregarCuotaMensual = new TextBox();
            label3 = new Label();
            lblAgregarClase = new Label();
            btnAgregarClase = new Button();
            txtAgregarMaximoInscriptos = new TextBox();
            SuspendLayout();
            // 
            // cmbAgregarClase
            // 
            cmbAgregarClase.FormattingEnabled = true;
            cmbAgregarClase.Location = new Point(32, 75);
            cmbAgregarClase.Name = "cmbAgregarClase";
            cmbAgregarClase.Size = new Size(121, 23);
            cmbAgregarClase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 57);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Clase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 138);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Maximo de inscriptos";
            // 
            // txtAgregarCuotaMensual
            // 
            txtAgregarCuotaMensual.Location = new Point(32, 237);
            txtAgregarCuotaMensual.Name = "txtAgregarCuotaMensual";
            txtAgregarCuotaMensual.Size = new Size(121, 23);
            txtAgregarCuotaMensual.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 219);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Cuota mensual";
            // 
            // lblAgregarClase
            // 
            lblAgregarClase.AutoSize = true;
            lblAgregarClase.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregarClase.Location = new Point(123, 9);
            lblAgregarClase.Name = "lblAgregarClase";
            lblAgregarClase.Size = new Size(139, 30);
            lblAgregarClase.TabIndex = 6;
            lblAgregarClase.Text = "Agregar clase";
            // 
            // btnAgregarClase
            // 
            btnAgregarClase.Location = new Point(225, 219);
            btnAgregarClase.Name = "btnAgregarClase";
            btnAgregarClase.Size = new Size(146, 41);
            btnAgregarClase.TabIndex = 7;
            btnAgregarClase.Text = "Agregar clase";
            btnAgregarClase.UseVisualStyleBackColor = true;
            btnAgregarClase.Click += btnAgregarClase_Click;
            // 
            // txtAgregarMaximoInscriptos
            // 
            txtAgregarMaximoInscriptos.Location = new Point(32, 156);
            txtAgregarMaximoInscriptos.Name = "txtAgregarMaximoInscriptos";
            txtAgregarMaximoInscriptos.Size = new Size(121, 23);
            txtAgregarMaximoInscriptos.TabIndex = 8;
            // 
            // FormAgregarClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 321);
            Controls.Add(txtAgregarMaximoInscriptos);
            Controls.Add(btnAgregarClase);
            Controls.Add(lblAgregarClase);
            Controls.Add(label3);
            Controls.Add(txtAgregarCuotaMensual);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAgregarClase);
            Name = "FormAgregarClase";
            Text = "FormAgregarClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAgregarClase;
        private Label label1;
        private Label label2;
        private TextBox txtAgregarCuotaMensual;
        private Label label3;
        private Label lblAgregarClase;
        private Button btnAgregarClase;
        private TextBox txtAgregarMaximoInscriptos;
    }
}