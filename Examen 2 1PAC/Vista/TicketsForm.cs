using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Vista
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        List<DetalleTicket> listaDetalles = new List<DetalleTicket>();
        TicketDB ticketDB = new TicketDB();
        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;


        private void RegresarButton_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            Close();
            menu.Show();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadTextBox.Text = miCliente.Identidad;
            ClienteTextBox.Text = miCliente.Nombre;
        }



        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverCliente(IdentidadTextBox.Text);
                ClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                ClienteTextBox.Clear();
            }
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TipoSoporteComboBox.Text == string.Empty )
            {
                errorProvider1.SetError(TipoSoporteComboBox, "Ingrese un tipo de soporte");
                UsuarioTextBox.Focus();
                return;
                
            }
            errorProvider1.Clear();

            if (PrecioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese un precio para la solicitud");
                UsuarioTextBox.Focus();
                return;

            }
            errorProvider1.Clear();

            if (DescuentoTextBox.Text == string.Empty)
            {
                DialogResult resultado = MessageBox.Show("Si no ha ingresado un monto para el descuento, seleccione SI para dejar el descuento en 0, seleccione NO para ingresar un descuento ", "¿NO ha puesto un monto para el descuento?", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    DescuentoTextBox.Text = "0";

                }
                else
                {
                    errorProvider1.SetError(DescuentoTextBox, "Ingrese un Descuento");
                    UsuarioTextBox.Focus();
                    return;
                }

            }
            errorProvider1.Clear();

            if (DescripcionSolicitudTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripcionSolicitudTextBox, "Ingrese una descripcion para la solicitud");
                UsuarioTextBox.Focus();
                return;

            }
            errorProvider1.Clear();

            if (DescripcionRespuestaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripcionRespuestaTextBox, "Ingrese una respuesta para la solicitud");
                UsuarioTextBox.Focus();
                return;

            }
            errorProvider1.Clear();



            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                if (!string.IsNullOrEmpty(TipoSoporteComboBox.Text))
                {

                   if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
                   {
                       e.Handled = true;
                   }

                   if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
                   {
                       e.Handled = true;
                   }

                       DetalleTicket detalle = new DetalleTicket();
                       detalle.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                       detalle.Total = Convert.ToInt32(CantidadTextBox.Text) * detalle.Precio;
                       detalle.TipoSoporte = TipoSoporteComboBox.Text;
                       detalle.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                       detalle.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
                       decimal descuento = Convert.ToDecimal(DescuentoTextBox.Text);

                       subTotal += detalle.Total;
                       isv = subTotal * 0.15M;
                       totalAPagar = subTotal + isv - descuento;

                       listaDetalles.Add(detalle);
                       DetalleDataGridView.DataSource = null;
                       DetalleDataGridView.DataSource = listaDetalles;

                       SubTotalTextBox.Text = subTotal.ToString("N2");
                       ImpuestoTextBox.Text = isv.ToString("N2");
                       TotalTextBox.Text = totalAPagar.ToString("N2");
                }
            }
        }



        private void LimpiarControles()
        {
            miCliente = null;
            listaDetalles = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            ClienteTextBox.Clear();
            DescripcionSolicitudTextBox.Clear();
            DescripcionRespuestaTextBox.Clear();
            CantidadTextBox.Clear();
            DetalleDataGridView.DataSource = null;
            subTotal = 0;
            SubTotalTextBox.Clear();
            isv = 0;
            ImpuestoTextBox.Clear();
            DescuentoTextBox.Clear();
            totalAPagar = 0;
            TotalTextBox.Clear();
            PrecioTextBox.Clear();
            TipoSoporteComboBox.Text = null;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Ticket miTicket = new Ticket();
            miTicket.Fecha = FechaDateTimePicker.Value;
            miTicket.IdentidadCliente = miCliente.Identidad;
            miTicket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miTicket.SubTotal = subTotal;
            miTicket.ISV = isv;
            miTicket.Descuento = Convert.ToDecimal(DescuentoTextBox.Text);
            miTicket.Total = totalAPagar;

            bool inserto = ticketDB.Guardar(miTicket, listaDetalles);

            if (inserto)
            {
                LimpiarControles();
                IdentidadTextBox.Focus();
                MessageBox.Show("Ticket registrado exitosamente");
            }
            else
                MessageBox.Show("No se pudo registrar el Ticket");
        }
    }
}
