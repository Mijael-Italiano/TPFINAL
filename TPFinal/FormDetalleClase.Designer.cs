namespace TPFinal
{
    partial class FormDetalleClase
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
            grillaClaseDetalle = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).BeginInit();
            SuspendLayout();
            // 
            // grillaClaseDetalle
            // 
            grillaClaseDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClaseDetalle.Location = new Point(46, 55);
            grillaClaseDetalle.Name = "grillaClaseDetalle";
            grillaClaseDetalle.Size = new Size(689, 237);
            grillaClaseDetalle.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(46, 308);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 42);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(186, 308);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 42);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(320, 308);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 42);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormDetalleClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(grillaClaseDetalle);
            Name = "FormDetalleClase";
            Text = "FormDetalleClase";
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaClaseDetalle;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}