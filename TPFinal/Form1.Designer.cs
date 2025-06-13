namespace TPFinal
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
            grillaInscripto = new DataGridView();
            grillaClase = new DataGridView();
            grillaProfesor = new DataGridView();
            btnDetalleClase = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).BeginInit();
            SuspendLayout();
            // 
            // grillaInscripto
            // 
            grillaInscripto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInscripto.Location = new Point(47, 21);
            grillaInscripto.Name = "grillaInscripto";
            grillaInscripto.Size = new Size(548, 382);
            grillaInscripto.TabIndex = 0;
            // 
            // grillaClase
            // 
            grillaClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClase.Location = new Point(661, 21);
            grillaClase.Name = "grillaClase";
            grillaClase.Size = new Size(509, 382);
            grillaClase.TabIndex = 1;
            // 
            // grillaProfesor
            // 
            grillaProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProfesor.Location = new Point(684, 484);
            grillaProfesor.Name = "grillaProfesor";
            grillaProfesor.Size = new Size(537, 115);
            grillaProfesor.TabIndex = 3;
            // 
            // btnDetalleClase
            // 
            btnDetalleClase.Location = new Point(661, 416);
            btnDetalleClase.Name = "btnDetalleClase";
            btnDetalleClase.Size = new Size(122, 38);
            btnDetalleClase.TabIndex = 4;
            btnDetalleClase.Text = "Ver detalle clase";
            btnDetalleClase.UseVisualStyleBackColor = true;
            btnDetalleClase.Click += btnDetalleClase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 618);
            Controls.Add(btnDetalleClase);
            Controls.Add(grillaProfesor);
            Controls.Add(grillaClase);
            Controls.Add(grillaInscripto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaInscripto;
        private DataGridView grillaClase;
        private DataGridView grillaProfesor;
        private Button btnDetalleClase;
    }
}
