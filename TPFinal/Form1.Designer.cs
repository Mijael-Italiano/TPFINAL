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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnMostrarPorProfesor = new Button();
            cmbDisciplinaProfesor = new ComboBox();
            label1 = new Label();
            btnVerListaCompleta = new Button();
            button7 = new Button();
            txtIdClaseInscripto = new TextBox();
            label2 = new Label();
            button8 = new Button();
            cmbDisciplinaClase = new ComboBox();
            label3 = new Label();
            btnMostrarListaCompletaClases = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).BeginInit();
            SuspendLayout();
            // 
            // grillaInscripto
            // 
            grillaInscripto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInscripto.Location = new Point(47, 12);
            grillaInscripto.Name = "grillaInscripto";
            grillaInscripto.Size = new Size(569, 382);
            grillaInscripto.TabIndex = 0;
            // 
            // grillaClase
            // 
            grillaClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClase.Location = new Point(705, 12);
            grillaClase.Name = "grillaClase";
            grillaClase.Size = new Size(560, 382);
            grillaClase.TabIndex = 1;
            // 
            // grillaProfesor
            // 
            grillaProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProfesor.Location = new Point(359, 457);
            grillaProfesor.Name = "grillaProfesor";
            grillaProfesor.Size = new Size(693, 208);
            grillaProfesor.TabIndex = 3;
            // 
            // btnDetalleClase
            // 
            btnDetalleClase.Location = new Point(705, 402);
            btnDetalleClase.Name = "btnDetalleClase";
            btnDetalleClase.Size = new Size(122, 38);
            btnDetalleClase.TabIndex = 4;
            btnDetalleClase.Text = "Ver detalle clase";
            btnDetalleClase.UseVisualStyleBackColor = true;
            btnDetalleClase.Click += btnDetalleClase_Click;
            // 
            // btnAgregarInscripto
            // 
            btnAgregarInscripto.Location = new Point(47, 401);
            btnAgregarInscripto.Name = "btnAgregarInscripto";
            btnAgregarInscripto.Size = new Size(121, 40);
            btnAgregarInscripto.TabIndex = 5;
            btnAgregarInscripto.Text = "Agregar Inscripto";
            btnAgregarInscripto.UseVisualStyleBackColor = true;
            btnAgregarInscripto.Click += btnAgregarInscripto_Click;
            // 
            // btnModificarInscripto
            // 
            btnModificarInscripto.Location = new Point(197, 403);
            btnModificarInscripto.Name = "btnModificarInscripto";
            btnModificarInscripto.Size = new Size(123, 38);
            btnModificarInscripto.TabIndex = 6;
            btnModificarInscripto.Text = "Modificar Inscripto";
            btnModificarInscripto.UseVisualStyleBackColor = true;
            btnModificarInscripto.Click += btnModificarInscripto_Click;
            // 
            // btnEliminarInscripto
            // 
            btnEliminarInscripto.Location = new Point(349, 403);
            btnEliminarInscripto.Name = "btnEliminarInscripto";
            btnEliminarInscripto.Size = new Size(123, 37);
            btnEliminarInscripto.TabIndex = 7;
            btnEliminarInscripto.Text = "Eliminar Inscripto";
            btnEliminarInscripto.UseVisualStyleBackColor = true;
            btnEliminarInscripto.Click += btnEliminarInscripto_Click;
            // 
            // BtnAsignarClase
            // 
            BtnAsignarClase.Location = new Point(493, 403);
            BtnAsignarClase.Name = "BtnAsignarClase";
            BtnAsignarClase.Size = new Size(123, 37);
            BtnAsignarClase.TabIndex = 8;
            BtnAsignarClase.Text = "Asignar clase";
            BtnAsignarClase.UseVisualStyleBackColor = true;
            BtnAsignarClase.Click += BtnAsignarClase_Click;
            // 
            // button1
            // 
            button1.Location = new Point(851, 401);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 9;
            button1.Text = "Agregar clase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1135, 404);
            button2.Name = "button2";
            button2.Size = new Size(119, 38);
            button2.TabIndex = 10;
            button2.Text = "Borrar clase";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1002, 403);
            button3.Name = "button3";
            button3.Size = new Size(107, 39);
            button3.TabIndex = 11;
            button3.Text = "Modificar clase";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(687, 671);
            button4.Name = "button4";
            button4.Size = new Size(112, 36);
            button4.TabIndex = 12;
            button4.Text = "Agregar profesor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(820, 670);
            button5.Name = "button5";
            button5.Size = new Size(127, 37);
            button5.TabIndex = 13;
            button5.Text = "Modificar profesor";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(964, 671);
            button6.Name = "button6";
            button6.Size = new Size(121, 36);
            button6.TabIndex = 14;
            button6.Text = "Eliminar profesor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnMostrarPorProfesor
            // 
            btnMostrarPorProfesor.Location = new Point(419, 673);
            btnMostrarPorProfesor.Name = "btnMostrarPorProfesor";
            btnMostrarPorProfesor.Size = new Size(116, 36);
            btnMostrarPorProfesor.TabIndex = 15;
            btnMostrarPorProfesor.Text = "Mostrar";
            btnMostrarPorProfesor.UseVisualStyleBackColor = true;
            btnMostrarPorProfesor.Click += btnMostrarPorProfesor_Click;
            // 
            // cmbDisciplinaProfesor
            // 
            cmbDisciplinaProfesor.FormattingEnabled = true;
            cmbDisciplinaProfesor.Location = new Point(277, 679);
            cmbDisciplinaProfesor.Name = "cmbDisciplinaProfesor";
            cmbDisciplinaProfesor.Size = new Size(121, 23);
            cmbDisciplinaProfesor.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 677);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 17;
            label1.Text = "Mostrar profesores \r\npor actividad";
            // 
            // btnVerListaCompleta
            // 
            btnVerListaCompleta.Location = new Point(554, 673);
            btnVerListaCompleta.Name = "btnVerListaCompleta";
            btnVerListaCompleta.Size = new Size(113, 36);
            btnVerListaCompleta.TabIndex = 18;
            btnVerListaCompleta.Text = "Ver lista completa";
            btnVerListaCompleta.UseVisualStyleBackColor = true;
            btnVerListaCompleta.Click += btnVerListaCompleta_Click;
            // 
            // button7
            // 
            button7.Location = new Point(93, 518);
            button7.Name = "button7";
            button7.Size = new Size(101, 47);
            button7.TabIndex = 19;
            button7.Text = "Mostrar por ID";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtIdClaseInscripto
            // 
            txtIdClaseInscripto.Location = new Point(171, 472);
            txtIdClaseInscripto.Name = "txtIdClaseInscripto";
            txtIdClaseInscripto.Size = new Size(100, 23);
            txtIdClaseInscripto.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 465);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 21;
            label2.Text = "Ingrese el valor\r\ndel ID de la clase";
            // 
            // button8
            // 
            button8.Location = new Point(222, 519);
            button8.Name = "button8";
            button8.Size = new Size(109, 46);
            button8.TabIndex = 22;
            button8.Text = "Ver lista de inscriptos \r\ncompleta";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // cmbDisciplinaClase
            // 
            cmbDisciplinaClase.FormattingEnabled = true;
            cmbDisciplinaClase.Location = new Point(1116, 504);
            cmbDisciplinaClase.Name = "cmbDisciplinaClase";
            cmbDisciplinaClase.Size = new Size(104, 23);
            cmbDisciplinaClase.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1123, 465);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 24;
            label3.Text = "Mostrar clases\r\npor disciplina";
            // 
            // btnMostrarListaCompletaClases
            // 
            btnMostrarListaCompletaClases.Location = new Point(1190, 542);
            btnMostrarListaCompletaClases.Name = "btnMostrarListaCompletaClases";
            btnMostrarListaCompletaClases.Size = new Size(75, 55);
            btnMostrarListaCompletaClases.TabIndex = 25;
            btnMostrarListaCompletaClases.Text = "Mostrar lista \r\ncompleta";
            btnMostrarListaCompletaClases.UseVisualStyleBackColor = true;
            btnMostrarListaCompletaClases.Click += btnMostrarListaCompletaClases_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1088, 542);
            button10.Name = "button10";
            button10.Size = new Size(84, 55);
            button10.TabIndex = 26;
            button10.Text = "Mostrar por \r\ndisciplina";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 718);
            Controls.Add(button10);
            Controls.Add(btnMostrarListaCompletaClases);
            Controls.Add(label3);
            Controls.Add(cmbDisciplinaClase);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(txtIdClaseInscripto);
            Controls.Add(button7);
            Controls.Add(btnVerListaCompleta);
            Controls.Add(label1);
            Controls.Add(cmbDisciplinaProfesor);
            Controls.Add(btnMostrarPorProfesor);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            PerformLayout();
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnMostrarPorProfesor;
        private ComboBox cmbDisciplinaProfesor;
        private Label label1;
        private Button btnVerListaCompleta;
        private Button button7;
        private TextBox txtIdClaseInscripto;
        private Label label2;
        private Button button8;
        private ComboBox cmbDisciplinaClase;
        private Label label3;
        private Button btnMostrarListaCompletaClases;
        private Button button10;
    }
}
