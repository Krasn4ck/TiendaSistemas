using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaElectronica
{
    public partial class PanelGeneral : Form
    {
        public PanelGeneral()
        {
            InitializeComponent();
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BT_Productos_Click(object sender, EventArgs e)
        {
            PN_Proveedores.Visible = false;
            PN_Ventas.Visible = false;
            PN_Productos.Visible = true;
        }

        private void BT_Ventas_Click(object sender, EventArgs e)
        {
            PN_Ventas.Visible = true;
            PN_Productos.Visible = false;
            PN_Proveedores.Visible = false;
        }

        private void BT_Proveedores_Click(object sender, EventArgs e)
        {
            PN_Ventas.Visible = false;
            PN_Productos.Visible = false;
            PN_Proveedores.Visible = true;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Realmente quiere actualizar los datos del proveedor?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Erasebutton_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Realmente quiere eliminar los datos del proveedor?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Esta seguro de querer cancelar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Esta seguro de querer cancelar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Esta seguro de querer cancelar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Esta seguro de querer cancelar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Realmente quiere actualizar los datos del producto?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Realmente quiere eliminar los datos del producto?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Busqueda mostrar = new Busqueda();
            mostrar.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Busqueda mostrar = new Busqueda();
            mostrar.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
             string pdfPath = Path.Combine(Application.StartupPath, @"C:\Users\muere\Documents\REPORTE DE INVENTARIO.pdf");
            Process.Start(pdfPath);
            //FileStream file = new FileStream("C:/Users/muere/Documents/REPORTE DE INVENTARIO.pdf", FileMode.Open);
        }

        private void AddPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog source = new OpenFileDialog();
            source.ShowDialog();
        }
    }
}
