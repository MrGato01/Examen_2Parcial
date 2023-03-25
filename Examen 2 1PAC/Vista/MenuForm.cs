using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void agregarUnNuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsForm ticket = new TicketsForm();
            Close();
            ticket.Show();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Close();
            login.Show();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            Close();
            cliente.Show();
        }
    }
}
