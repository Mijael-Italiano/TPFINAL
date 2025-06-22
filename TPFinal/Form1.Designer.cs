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
            btnAgregarInscripto = new Button();
            btnModificarInscripto = new Button();
            btnEliminarInscripto = new Button();
            BtnAsignarClase = new Button();
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
            grillaInscripto.Size = new Size(569, 382);
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
            grillaProfesor.Location = new Point(661, 481);
            grillaProfesor.Name = "grillaProfesor";
            grillaProfesor.Size = new Size(509, 115);
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
            // btnAgregarInscripto
            // 
            btnAgregarInscripto.Location = new Point(47, 421);
            btnAgregarInscripto.Name = "btnAgregarInscripto";
            btnAgregarInscripto.Size = new Size(121, 40);
            btnAgregarInscripto.TabIndex = 5;
            btnAgregarInscripto.Text = "Agregar Inscripto";
            btnAgregarInscripto.UseVisualStyleBackColor = true;
            btnAgregarInscripto.Click += btnAgregarInscripto_Click;
            // 
            // btnModificarInscripto
            // 
            btnModificarInscripto.Location = new Point(193, 421);
            btnModificarInscripto.Name = "btnModificarInscripto";
            btnModificarInscripto.Size = new Size(123, 38);
            btnModificarInscripto.TabIndex = 6;
            btnModificarInscripto.Text = "Modificar Inscripto";
            btnModificarInscripto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarInscripto
            // 
            btnEliminarInscripto.Location = new Point(343, 421);
            btnEliminarInscripto.Name = "btnEliminarInscripto";
            btnEliminarInscripto.Size = new Size(123, 37);
            btnEliminarInscripto.TabIndex = 7;
            btnEliminarInscripto.Text = "Eliminar Inscripto";
            btnEliminarInscripto.UseVisualStyleBackColor = true;
            // 
            // BtnAsignarClase
            // 
            BtnAsignarClase.Location = new Point(493, 421);
            BtnAsignarClase.Name = "BtnAsignarClase";
            BtnAsignarClase.Size = new Size(123, 37);
            BtnAsignarClase.TabIndex = 8;
            BtnAsignarClase.Text = "Asignar clase";
            BtnAsignarClase.UseVisualStyleBackColor = true;
            BtnAsignarClase.Click += BtnAsignarClase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 618);
            Controls.Add(BtnAsignarClase);
            Controls.Add(btnEliminarInscripto);
            Controls.Add(btnModificarInscripto);
            Controls.Add(btnAgregarInscripto);
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
        private Button btnAgregarInscripto;
        private Button btnModificarInscripto;
        private Button btnEliminarInscripto;
        private Button BtnAsignarClase;
    }
}
