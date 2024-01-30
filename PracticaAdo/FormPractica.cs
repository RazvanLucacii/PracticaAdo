using PracticaAdo.Models;
using PracticaAdo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAdo
{
    public partial class FormPractica : Form
    {
        RepositoryEmpleados repo;
        public FormPractica()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleados();
            this.LoadClientes();
        }

        private void LoadClientes()
        {
            List<string> clientes = this.repo.GetEmpleados();
            foreach (string cliente in clientes)
            {
                this.cmbclientes.Items.Add(cliente);
            }
        }
        private void lstpedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = this.cmbclientes.SelectedItem.ToString();
            DatosPedidos resumen = this.repo.GetPedidos(codigo);
            this.lstpedidos.Items.Clear();
            foreach (string datos in resumen.Pedidos)
            {
                this.lstpedidos.Items.Add(datos);
            }
        }


        private void btnnuevopedido_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarpedido_Click(object sender, EventArgs e)
        {

        }
    }
}
