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
            grillaClaseDetalle = new DataGridView();
            grillaProfesor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).BeginInit();
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
            grillaClase.Location = new Point(56, 484);
            grillaClase.Name = "grillaClase";
            grillaClase.Size = new Size(509, 122);
            grillaClase.TabIndex = 1;
            // 
            // grillaClaseDetalle
            // 
            grillaClaseDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClaseDetalle.Location = new Point(631, 21);
            grillaClaseDetalle.Name = "grillaClaseDetalle";
            grillaClaseDetalle.Size = new Size(590, 370);
            grillaClaseDetalle.TabIndex = 2;
            // 
            // grillaProfesor
            // 
            grillaProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProfesor.Location = new Point(684, 484);
            grillaProfesor.Name = "grillaProfesor";
            grillaProfesor.Size = new Size(537, 115);
            grillaProfesor.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 618);
            Controls.Add(grillaProfesor);
            Controls.Add(grillaClaseDetalle);
            Controls.Add(grillaClase);
            Controls.Add(grillaInscripto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaInscripto;
        private DataGridView grillaClase;
        private DataGridView grillaClaseDetalle;
        private DataGridView grillaProfesor;
    }
}
