namespace TPFinal
{
    partial class FormModificarDetalleClase
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
            txtHorarioInicioModificar = new TextBox();
            txtHorarioFinModificar = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Horario inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Horario fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 173);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Dia";
            // 
            // txtHorarioInicioModificar
            // 
            txtHorarioInicioModificar.Location = new Point(73, 69);
            txtHorarioInicioModificar.Name = "txtHorarioInicioModificar";
            txtHorarioInicioModificar.Size = new Size(100, 23);
            txtHorarioInicioModificar.TabIndex = 3;
            // 
            // txtHorarioFinModificar
            // 
            txtHorarioFinModificar.Location = new Point(73, 128);
            txtHorarioFinModificar.Name = "txtHorarioFinModificar";
            txtHorarioFinModificar.Size = new Size(100, 23);
            txtHorarioFinModificar.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(73, 252);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 234);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Profesor";
            // 
            // button1
            // 
            button1.Location = new Point(254, 270);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 8;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormModificarDetalleClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 333);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtHorarioFinModificar);
            Controls.Add(txtHorarioInicioModificar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormModificarDetalleClase";
            Text = "FormModificarDetalleClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHorarioInicioModificar;
        private TextBox txtHorarioFinModificar;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Button button1;
    }
}