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
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).BeginInit();
            SuspendLayout();
            // 
            // grillaClaseDetalle
            // 
            grillaClaseDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClaseDetalle.Location = new Point(46, 55);
            grillaClaseDetalle.Name = "grillaClaseDetalle";
            grillaClaseDetalle.Size = new Size(689, 197);
            grillaClaseDetalle.TabIndex = 0;
            // 
            // FormDetalleClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grillaClaseDetalle);
            Name = "FormDetalleClase";
            Text = "FormDetalleClase";
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaClaseDetalle;
    }
}