using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaElectronica
{
    public partial class CapturaProductos : Form
    {
        public CapturaProductos()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RealTime.Text = DateTime.Now.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void AddPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog source = new OpenFileDialog();
            source.ShowDialog();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Erasebutton.Visible = false;
            Updatebutton.Visible = false;
            label10.Visible = false;
            SearchProd.Visible = false;
            button4.Visible = false;
        }

        private void EditRadio_CheckedChanged(object sender, EventArgs e)
        {
            Erasebutton.Visible = true;
            Updatebutton.Visible = true;
            label10.Visible = true;
            SearchProd.Visible = true;
            button4.Visible = true;
        }

     
    }
}
