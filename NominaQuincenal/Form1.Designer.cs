namespace NominaQuincenal
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
            label1 = new Label();
            cmbCargo = new ComboBox();
            rdbFijo = new RadioButton();
            txtEmpleado = new TextBox();
            btnRegistrar = new Button();
            label2 = new Label();
            rdbTemporal = new RadioButton();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            txtHoras = new TextBox();
            chkTransporte = new CheckBox();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lstNomina = new ListBox();
            lblEmpleados = new Label();
            lblBruto = new Label();
            lblDeducciones = new Label();
            lblNeto = new Label();
            grpDatos = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblEmmpleados = new Label();
            lblEmpleadoss = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(47, 28);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(210, 23);
            cmbCargo.TabIndex = 1;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Location = new Point(70, 75);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(44, 19);
            rdbFijo.TabIndex = 2;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(62, 26);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(195, 23);
            txtEmpleado.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(6, 175);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(245, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 75);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Contrato:";
            // 
            // rdbTemporal
            // 
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(156, 75);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(77, 19);
            rdbTemporal.TabIndex = 6;
            rdbTemporal.TabStop = true;
            rdbTemporal.Text = "Temporal";
            rdbTemporal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 82);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Total neto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 226);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 63);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 12;
            label8.Text = "Total deducciones:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 48);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 13;
            label9.Text = "Total bruto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 33);
            label10.Name = "label10";
            label10.Size = new Size(137, 15);
            label10.TabIndex = 14;
            label10.Text = "Empleados Registrados:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 65);
            label13.Name = "label13";
            label13.Size = new Size(183, 15);
            label13.TabIndex = 17;
            label13.Text = "Horas trabajadas en la quincena:";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(6, 90);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(115, 23);
            txtHoras.TabIndex = 18;
            // 
            // chkTransporte
            // 
            chkTransporte.AutoSize = true;
            chkTransporte.Location = new Point(6, 131);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(198, 19);
            chkTransporte.TabIndex = 19;
            chkTransporte.Text = "Recibe incentivo de transporte";
            chkTransporte.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(61, 386);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(177, 23);
            btnResumen.TabIndex = 20;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(276, 386);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(177, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(486, 386);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(177, 23);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstNomina
            // 
            lstNomina.FormattingEnabled = true;
            lstNomina.Location = new Point(6, 22);
            lstNomina.Name = "lstNomina";
            lstNomina.Size = new Size(232, 169);
            lstNomina.TabIndex = 23;
            lstNomina.SelectedIndexChanged += lstNomina_SelectedIndexChanged;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(106, 129);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(47, 15);
            lblEmpleados.TabIndex = 25;
            lblEmpleados.Text = "label11";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(156, 48);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(47, 15);
            lblBruto.TabIndex = 26;
            lblBruto.Text = "label15";
            // 
            // lblDeducciones
            // 
            lblDeducciones.AutoSize = true;
            lblDeducciones.Location = new Point(156, 63);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(47, 15);
            lblDeducciones.TabIndex = 27;
            lblDeducciones.Text = "label16";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(156, 78);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(47, 15);
            lblNeto.TabIndex = 28;
            lblNeto.Text = "label17";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(txtEmpleado);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(rdbFijo);
            grpDatos.Controls.Add(rdbTemporal);
            grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatos.Location = new Point(61, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(257, 111);
            grpDatos.TabIndex = 29;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbCargo);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(chkTransporte);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(61, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 220);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de pago";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstNomina);
            groupBox2.Controls.Add(lblEmpleados);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(431, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 209);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nomina Registrada";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEmmpleados);
            groupBox3.Controls.Add(lblEmpleadoss);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblNeto);
            groupBox3.Controls.Add(lblBruto);
            groupBox3.Controls.Add(lblDeducciones);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(431, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 130);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblEmmpleados
            // 
            lblEmmpleados.AutoSize = true;
            lblEmmpleados.Location = new Point(156, 33);
            lblEmmpleados.Name = "lblEmmpleados";
            lblEmmpleados.Size = new Size(47, 15);
            lblEmmpleados.TabIndex = 34;
            lblEmmpleados.Text = "label15";
            // 
            // lblEmpleadoss
            // 
            lblEmpleadoss.AutoSize = true;
            lblEmpleadoss.Location = new Point(156, 33);
            lblEmpleadoss.Name = "lblEmpleadoss";
            lblEmpleadoss.Size = new Size(0, 15);
            lblEmpleadoss.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpDatos);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(label7);
            Name = "Form1";
            Text = "Nomina Quincenal";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCargo;
        private RadioButton rdbFijo;
        private TextBox txtEmpleado;
        private Button btnRegistrar;
        private Label label2;
        private RadioButton rdbTemporal;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private TextBox txtHoras;
        private CheckBox chkTransporte;
        private Button btnResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox lstNomina;
        private Label lblEmpleados;
        private Label lblBruto;
        private Label lblDeducciones;
        private Label lblNeto;
        private GroupBox grpDatos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblEmpleadoss;
        private Label lblEmmpleados;
    }
}
