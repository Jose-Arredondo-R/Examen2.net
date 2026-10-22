using System.ComponentModel;

namespace ReservaTalleres
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Reserva> reservas = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbTaller.Items.Add(new Taller { Nombre = "Programación C#", CupoMaximo = 5 });
            cmbTaller.Items.Add(new Taller { Nombre = "Diseño Web", CupoMaximo = 4 });
            cmbTaller.Items.Add(new Taller { Nombre = "Redes Básicas", CupoMaximo = 6 });
            cmbTaller.SelectedIndex = 0;

            dgvReservas.DataSource = reservas;
            ActualizarIndicadores();
        }

        private int LugaresDisponibles(Taller taller)
        {
            int ocupados = reservas.Where(r => r.Taller == taller).Sum(r => r.Cantidad);
            return taller.CupoMaximo - ocupados;
        }

        private void ActualizarIndicadores()
        {
            if (cmbTaller.SelectedItem is Taller taller)
                lblDisponibles.Text = "Lugares disponibles: " + LugaresDisponibles(taller);
            else
                lblDisponibles.Text = "Lugares disponibles: 0";

            lblReservas.Text = "Reservas registradas: " + reservas.Count;
            lblOcupados.Text = "Lugares ocupados: " + reservas.Sum(r => r.Cantidad);
        }

        private void cmbTaller_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ActualizarIndicadores();
        }

        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            string responsable = txtResponsable.Text.Trim();
            if (responsable == "")
            {
                MessageBox.Show("Escribe el nombre del responsable.");
                txtResponsable.Focus();
                return;
            }

            if (cmbTaller.SelectedItem is not Taller taller)
            {
                MessageBox.Show("Elige un taller.");
                return;
            }

            if (!rbMatutino.Checked && !rbVespertino.Checked)
            {
                MessageBox.Show("Elige un turno.");
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            if (cantidad < 1 || cantidad > 3)
            {
                MessageBox.Show("La cantidad debe estar entre 1 y 3 lugares.");
                return;
            }

            int disponibles = LugaresDisponibles(taller);
            if (cantidad > disponibles)
            {
                MessageBox.Show("No hay cupo suficiente. Lugares disponibles: " + disponibles);
                return;
            }

            reservas.Add(new Reserva
            {
                Responsable = responsable,
                Taller = taller,
                Cantidad = cantidad,
                Turno = rbMatutino.Checked ? "Matutino" : "Vespertino",
                Material = chkMaterial.Checked
            });

            ActualizarIndicadores();
            LimpiarCaptura();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona la reserva que quieres cancelar.");
                return;
            }

            if (dgvReservas.SelectedRows[0].DataBoundItem is Reserva reserva)
            {
                reservas.Remove(reserva);
                ActualizarIndicadores();
            }
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCaptura();
        }

        private void LimpiarCaptura()
        {
            txtResponsable.Clear();
            nudCantidad.Value = 1;
            rbMatutino.Checked = false;
            rbVespertino.Checked = false;
            chkMaterial.Checked = false;
            txtResponsable.Focus();
        }
    }
}
