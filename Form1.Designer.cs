namespace ReservaTalleres
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpTaller = new GroupBox();
            lblTaller = new Label();
            cmbTaller = new ComboBox();
            lblDisponibles = new Label();
            grpReserva = new GroupBox();
            lblResponsable = new Label();
            txtResponsable = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            grpPreferencias = new GroupBox();
            lblTurno = new Label();
            rbMatutino = new RadioButton();
            rbVespertino = new RadioButton();
            chkMaterial = new CheckBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            dgvReservas = new DataGridView();
            colResponsable = new DataGridViewTextBoxColumn();
            colTaller = new DataGridViewTextBoxColumn();
            colLugares = new DataGridViewTextBoxColumn();
            colTurno = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewCheckBoxColumn();
            lblReservas = new Label();
            lblOcupados = new Label();
            grpTaller.SuspendLayout();
            grpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            //
            // grpTaller
            //
            grpTaller.Controls.Add(lblTaller);
            grpTaller.Controls.Add(cmbTaller);
            grpTaller.Controls.Add(lblDisponibles);
            grpTaller.Location = new Point(12, 12);
            grpTaller.Name = "grpTaller";
            grpTaller.Size = new Size(270, 130);
            grpTaller.TabIndex = 0;
            grpTaller.TabStop = false;
            grpTaller.Text = "1. Selección de taller";
            //
            // lblTaller
            //
            lblTaller.AutoSize = true;
            lblTaller.Location = new Point(15, 30);
            lblTaller.Name = "lblTaller";
            lblTaller.Size = new Size(36, 15);
            lblTaller.Text = "Taller";
            //
            // cmbTaller
            //
            cmbTaller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTaller.Location = new Point(15, 50);
            cmbTaller.Name = "cmbTaller";
            cmbTaller.Size = new Size(240, 23);
            cmbTaller.TabIndex = 0;
            cmbTaller.SelectedIndexChanged += cmbTaller_SelectedIndexChanged;
            //
            // lblDisponibles
            //
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisponibles.Location = new Point(15, 90);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(120, 15);
            lblDisponibles.Text = "Lugares disponibles: 0";
            //
            // grpReserva
            //
            grpReserva.Controls.Add(lblResponsable);
            grpReserva.Controls.Add(txtResponsable);
            grpReserva.Controls.Add(lblCantidad);
            grpReserva.Controls.Add(nudCantidad);
            grpReserva.Location = new Point(292, 12);
            grpReserva.Name = "grpReserva";
            grpReserva.Size = new Size(300, 130);
            grpReserva.TabIndex = 1;
            grpReserva.TabStop = false;
            grpReserva.Text = "2. Datos de la reserva";
            //
            // lblResponsable
            //
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(15, 30);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(70, 15);
            lblResponsable.Text = "Responsable";
            //
            // txtResponsable
            //
            txtResponsable.Location = new Point(15, 50);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(270, 23);
            txtResponsable.TabIndex = 0;
            //
            // lblCantidad
            //
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 92);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(110, 15);
            lblCantidad.Text = "Cantidad de lugares";
            //
            // nudCantidad
            //
            nudCantidad.Location = new Point(200, 88);
            nudCantidad.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(85, 23);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // grpPreferencias
            //
            grpPreferencias.Controls.Add(lblTurno);
            grpPreferencias.Controls.Add(rbMatutino);
            grpPreferencias.Controls.Add(rbVespertino);
            grpPreferencias.Controls.Add(chkMaterial);
            grpPreferencias.Location = new Point(602, 12);
            grpPreferencias.Name = "grpPreferencias";
            grpPreferencias.Size = new Size(270, 130);
            grpPreferencias.TabIndex = 2;
            grpPreferencias.TabStop = false;
            grpPreferencias.Text = "3. Preferencias";
            //
            // lblTurno
            //
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(15, 30);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(38, 15);
            lblTurno.Text = "Turno";
            //
            // rbMatutino
            //
            rbMatutino.AutoSize = true;
            rbMatutino.Location = new Point(15, 55);
            rbMatutino.Name = "rbMatutino";
            rbMatutino.Size = new Size(76, 19);
            rbMatutino.TabIndex = 0;
            rbMatutino.Text = "Matutino";
            //
            // rbVespertino
            //
            rbVespertino.AutoSize = true;
            rbVespertino.Location = new Point(135, 55);
            rbVespertino.Name = "rbVespertino";
            rbVespertino.Size = new Size(82, 19);
            rbVespertino.TabIndex = 1;
            rbVespertino.Text = "Vespertino";
            //
            // chkMaterial
            //
            chkMaterial.AutoSize = true;
            chkMaterial.Location = new Point(15, 92);
            chkMaterial.Name = "chkMaterial";
            chkMaterial.Size = new Size(116, 19);
            chkMaterial.TabIndex = 2;
            chkMaterial.Text = "Requiere material";
            //
            // btnRegistrar
            //
            btnRegistrar.Location = new Point(12, 155);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 30);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar reserva";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(162, 155);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar seleccionada";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new Point(312, 155);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar captura";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // dgvReservas
            //
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Columns.AddRange(new DataGridViewColumn[] { colResponsable, colTaller, colLugares, colTurno, colMaterial });
            dgvReservas.Location = new Point(12, 195);
            dgvReservas.MultiSelect = false;
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersVisible = false;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(860, 260);
            dgvReservas.TabIndex = 6;
            //
            // colResponsable
            //
            colResponsable.DataPropertyName = "Responsable";
            colResponsable.HeaderText = "Responsable";
            colResponsable.Name = "colResponsable";
            colResponsable.ReadOnly = true;
            colResponsable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            // colTaller
            //
            colTaller.DataPropertyName = "Taller";
            colTaller.HeaderText = "Taller";
            colTaller.Name = "colTaller";
            colTaller.ReadOnly = true;
            colTaller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            // colLugares
            //
            colLugares.DataPropertyName = "Cantidad";
            colLugares.HeaderText = "Lugares";
            colLugares.Name = "colLugares";
            colLugares.ReadOnly = true;
            colLugares.Width = 80;
            //
            // colTurno
            //
            colTurno.DataPropertyName = "Turno";
            colTurno.HeaderText = "Turno";
            colTurno.Name = "colTurno";
            colTurno.ReadOnly = true;
            colTurno.Width = 110;
            //
            // colMaterial
            //
            colMaterial.DataPropertyName = "Material";
            colMaterial.HeaderText = "Material";
            colMaterial.Name = "colMaterial";
            colMaterial.ReadOnly = true;
            colMaterial.Width = 80;
            //
            // lblReservas
            //
            lblReservas.AutoSize = true;
            lblReservas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReservas.Location = new Point(12, 468);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(120, 15);
            lblReservas.Text = "Reservas registradas: 0";
            //
            // lblOcupados
            //
            lblOcupados.AutoSize = true;
            lblOcupados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOcupados.Location = new Point(300, 468);
            lblOcupados.Name = "lblOcupados";
            lblOcupados.Size = new Size(120, 15);
            lblOcupados.Text = "Lugares ocupados: 0";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 501);
            Controls.Add(grpTaller);
            Controls.Add(grpReserva);
            Controls.Add(grpPreferencias);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvReservas);
            Controls.Add(lblReservas);
            Controls.Add(lblOcupados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de reservas de talleres";
            Load += Form1_Load;
            grpTaller.ResumeLayout(false);
            grpTaller.PerformLayout();
            grpReserva.ResumeLayout(false);
            grpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grpPreferencias.ResumeLayout(false);
            grpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTaller;
        private Label lblTaller;
        private ComboBox cmbTaller;
        private Label lblDisponibles;
        private GroupBox grpReserva;
        private Label lblResponsable;
        private TextBox txtResponsable;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private GroupBox grpPreferencias;
        private Label lblTurno;
        private RadioButton rbMatutino;
        private RadioButton rbVespertino;
        private CheckBox chkMaterial;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private DataGridView dgvReservas;
        private DataGridViewTextBoxColumn colResponsable;
        private DataGridViewTextBoxColumn colTaller;
        private DataGridViewTextBoxColumn colLugares;
        private DataGridViewTextBoxColumn colTurno;
        private DataGridViewCheckBoxColumn colMaterial;
        private Label lblReservas;
        private Label lblOcupados;
    }
}
