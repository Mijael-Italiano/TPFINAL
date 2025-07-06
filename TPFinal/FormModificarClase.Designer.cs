namespace TPFinal
{
    partial class FormModificarClase
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
            txtModificarCuota = new TextBox();
            txtModificarMaximoInscriptos = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 68);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuota mensual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 141);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Maximo inscriptos";
            // 
            // txtModificarCuota
            // 
            txtModificarCuota.Location = new Point(120, 86);
            txtModificarCuota.Name = "txtModificarCuota";
            txtModificarCuota.Size = new Size(100, 23);
            txtModificarCuota.TabIndex = 3;
            // 
            // txtModificarMaximoInscriptos
            // 
            txtModificarMaximoInscriptos.Location = new Point(120, 159);
            txtModificarMaximoInscriptos.Name = "txtModificarMaximoInscriptos";
            txtModificarMaximoInscriptos.Size = new Size(100, 23);
            txtModificarMaximoInscriptos.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(115, 237);
            button1.Name = "button1";
            button1.Size = new Size(123, 39);
            button1.TabIndex = 6;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormModificarClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 323);
            Controls.Add(button1);
            Controls.Add(txtModificarMaximoInscriptos);
            Controls.Add(txtModificarCuota);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormModificarClase";
            Text = "FormModificarClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtModificarCuota;
        private TextBox txtModificarMaximoInscriptos;
        private Button button1;
    }
}