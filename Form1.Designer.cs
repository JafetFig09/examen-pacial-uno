namespace ExamenPrimerParcial
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
            btnAgregarPaciente = new Button();
            panelAgregar = new Panel();
            btnAgregrar = new Button();
            label4 = new Label();
            tbDiagnostico = new TextBox();
            label3 = new Label();
            tbNumTel = new TextBox();
            label2 = new Label();
            tbEdad = new TextBox();
            label1 = new Label();
            tbNombre = new TextBox();
            panelBuscar = new Panel();
            rbTodos = new RadioButton();
            btnBuscar = new Button();
            diagnosticoTb = new TextBox();
            nombreTb = new TextBox();
            listBox1 = new ListBox();
            rbDiagnostico = new RadioButton();
            rbNombre = new RadioButton();
            btnBuscarPaciente = new Button();
            panelEliminar = new Panel();
            label9 = new Label();
            label8 = new Label();
            btnEstadicticas = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            tbEliminar = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnEliminarPaciente = new Button();
            lbNumPacientes = new Label();
            lbPromedioPacientes = new Label();
            panelAgregar.SuspendLayout();
            panelBuscar.SuspendLayout();
            panelEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Cursor = Cursors.Hand;
            btnAgregarPaciente.Location = new Point(77, 78);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(192, 43);
            btnAgregarPaciente.TabIndex = 0;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // panelAgregar
            // 
            panelAgregar.BackColor = Color.AliceBlue;
            panelAgregar.Controls.Add(btnAgregrar);
            panelAgregar.Controls.Add(label4);
            panelAgregar.Controls.Add(tbDiagnostico);
            panelAgregar.Controls.Add(label3);
            panelAgregar.Controls.Add(tbNumTel);
            panelAgregar.Controls.Add(label2);
            panelAgregar.Controls.Add(tbEdad);
            panelAgregar.Controls.Add(label1);
            panelAgregar.Controls.Add(tbNombre);
            panelAgregar.Location = new Point(11, 130);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(318, 416);
            panelAgregar.TabIndex = 1;
            // 
            // btnAgregrar
            // 
            btnAgregrar.BackColor = Color.LightSkyBlue;
            btnAgregrar.Cursor = Cursors.Hand;
            btnAgregrar.Location = new Point(64, 325);
            btnAgregrar.Name = "btnAgregrar";
            btnAgregrar.Size = new Size(153, 48);
            btnAgregrar.TabIndex = 8;
            btnAgregrar.Text = "Agregar";
            btnAgregrar.UseVisualStyleBackColor = false;
            btnAgregrar.Click += btnAgregrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 248);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Diagnostico";
            // 
            // tbDiagnostico
            // 
            tbDiagnostico.Location = new Point(116, 218);
            tbDiagnostico.Multiline = true;
            tbDiagnostico.Name = "tbDiagnostico";
            tbDiagnostico.ScrollBars = ScrollBars.Both;
            tbDiagnostico.Size = new Size(144, 71);
            tbDiagnostico.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 159);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "Núm Telefono:";
            // 
            // tbNumTel
            // 
            tbNumTel.Location = new Point(132, 159);
            tbNumTel.Name = "tbNumTel";
            tbNumTel.Size = new Size(128, 27);
            tbNumTel.TabIndex = 4;
            tbNumTel.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 99);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Edad:";
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(136, 92);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(118, 27);
            tbEdad.TabIndex = 2;
            tbEdad.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(136, 35);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(124, 27);
            tbNombre.TabIndex = 0;
            tbNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.AliceBlue;
            panelBuscar.Controls.Add(rbTodos);
            panelBuscar.Controls.Add(btnBuscar);
            panelBuscar.Controls.Add(diagnosticoTb);
            panelBuscar.Controls.Add(nombreTb);
            panelBuscar.Controls.Add(listBox1);
            panelBuscar.Controls.Add(rbDiagnostico);
            panelBuscar.Controls.Add(rbNombre);
            panelBuscar.Location = new Point(359, 135);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(408, 411);
            panelBuscar.TabIndex = 2;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Location = new Point(25, 87);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(163, 24);
            rbTodos.TabIndex = 6;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos Los pacientes";
            rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(147, 369);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 30);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // diagnosticoTb
            // 
            diagnosticoTb.Location = new Point(189, 36);
            diagnosticoTb.Multiline = true;
            diagnosticoTb.Name = "diagnosticoTb";
            diagnosticoTb.ScrollBars = ScrollBars.Both;
            diagnosticoTb.Size = new Size(147, 40);
            diagnosticoTb.TabIndex = 4;
            // 
            // nombreTb
            // 
            nombreTb.Location = new Point(42, 41);
            nombreTb.Name = "nombreTb";
            nombreTb.Size = new Size(91, 27);
            nombreTb.TabIndex = 3;
            nombreTb.TextAlign = HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(42, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 244);
            listBox1.TabIndex = 2;
            // 
            // rbDiagnostico
            // 
            rbDiagnostico.AutoSize = true;
            rbDiagnostico.Location = new Point(200, 11);
            rbDiagnostico.Name = "rbDiagnostico";
            rbDiagnostico.Size = new Size(110, 24);
            rbDiagnostico.TabIndex = 1;
            rbDiagnostico.TabStop = true;
            rbDiagnostico.Text = "Diagnostico";
            rbDiagnostico.UseVisualStyleBackColor = true;
            rbDiagnostico.CheckedChanged += rbDiagnostico_CheckedChanged;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(25, 11);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(85, 24);
            rbNombre.TabIndex = 0;
            rbNombre.TabStop = true;
            rbNombre.Text = "Nombre";
            rbNombre.UseVisualStyleBackColor = true;
            rbNombre.CheckedChanged += rbNombre_CheckedChanged;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.Location = new Point(449, 78);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(170, 40);
            btnBuscarPaciente.TabIndex = 3;
            btnBuscarPaciente.Text = "Buscar Paciente";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // panelEliminar
            // 
            panelEliminar.BackColor = Color.AliceBlue;
            panelEliminar.Controls.Add(label9);
            panelEliminar.Controls.Add(label8);
            panelEliminar.Controls.Add(btnEstadicticas);
            panelEliminar.Controls.Add(btnEliminar);
            panelEliminar.Controls.Add(label7);
            panelEliminar.Controls.Add(tbEliminar);
            panelEliminar.Controls.Add(label6);
            panelEliminar.Controls.Add(label5);
            panelEliminar.Location = new Point(798, 137);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(459, 226);
            panelEliminar.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 177);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 117);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 11;
            // 
            // btnEstadicticas
            // 
            btnEstadicticas.BackColor = Color.LightSkyBlue;
            btnEstadicticas.Location = new Point(337, 138);
            btnEstadicticas.Name = "btnEstadicticas";
            btnEstadicticas.Size = new Size(106, 66);
            btnEstadicticas.TabIndex = 10;
            btnEstadicticas.Text = "Mostrar Estadisticas";
            btnEstadicticas.UseVisualStyleBackColor = false;
            btnEstadicticas.Click += btnEstadicticas_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightSkyBlue;
            btnEliminar.Location = new Point(337, 57);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 176);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 7;
            label7.Text = "Promedio de Edad:";
            // 
            // tbEliminar
            // 
            tbEliminar.Location = new Point(39, 60);
            tbEliminar.Name = "tbEliminar";
            tbEliminar.Size = new Size(204, 27);
            tbEliminar.TabIndex = 1;
            tbEliminar.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 117);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 6;
            label6.Text = "Número de Pacientes:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 13);
            label5.Name = "label5";
            label5.Size = new Size(358, 20);
            label5.TabIndex = 0;
            label5.Text = "Introduzca el nombre del usuario que desea eliminar";
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Cursor = Cursors.Hand;
            btnEliminarPaciente.Location = new Point(944, 78);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(139, 36);
            btnEliminarPaciente.TabIndex = 5;
            btnEliminarPaciente.Text = "Eliminar Paciente";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // lbNumPacientes
            // 
            lbNumPacientes.AutoSize = true;
            lbNumPacientes.Location = new Point(991, 313);
            lbNumPacientes.Name = "lbNumPacientes";
            lbNumPacientes.Size = new Size(0, 20);
            lbNumPacientes.TabIndex = 8;
            // 
            // lbPromedioPacientes
            // 
            lbPromedioPacientes.AutoSize = true;
            lbPromedioPacientes.Location = new Point(957, 366);
            lbPromedioPacientes.Name = "lbPromedioPacientes";
            lbPromedioPacientes.Size = new Size(0, 20);
            lbPromedioPacientes.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1503, 856);
            Controls.Add(lbPromedioPacientes);
            Controls.Add(lbNumPacientes);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(panelEliminar);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(panelBuscar);
            Controls.Add(panelAgregar);
            Controls.Add(btnAgregarPaciente);
            Name = "Form1";
            Text = "Hospital El Faro del Mayab";
            panelAgregar.ResumeLayout(false);
            panelAgregar.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPaciente;
        private Panel panelAgregar;
        private TextBox tbNombre;
        private TextBox tbNumTel;
        private Label label2;
        private TextBox tbEdad;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbDiagnostico;
        private Button btnAgregrar;
        private Panel panelBuscar;
        private TextBox nombreTb;
        private ListBox listBox1;
        private RadioButton rbDiagnostico;
        private RadioButton rbNombre;
        private Button btnBuscarPaciente;
        private Button btnBuscar;
        private TextBox diagnosticoTb;
        private RadioButton rbTodos;
        private Panel panelEliminar;
        private Button btnEliminarPaciente;
        private Label label5;
        private Button btnEliminar;
        private TextBox tbEliminar;
        private Label label6;
        private Label label7;
        private Label lbNumPacientes;
        private Label lbPromedioPacientes;
        private Label label9;
        private Label label8;
        private Button btnEstadicticas;
    }
}