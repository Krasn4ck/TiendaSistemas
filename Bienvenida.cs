using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TiendaElectronica
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Progreso();
        }

        public void Progreso()
        {
            BarProgresss.Increment(1);
            if(BarProgresss.Value==BarProgresss.Maximum)
            {
                timer1.Stop();
                Counter.Text = BarProgresss.Value.ToString() + "%";
                this.Hide();
                ///CapturaProductos Instant = new CapturaProductos();
                ///VentanaVenta Create = new VentanaVenta();
                ///Create.Show();
                ///Instant.Show();
                PanelGeneral panelGeneral = new PanelGeneral();
                panelGeneral.Show();
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            Counter.Parent = pictureBox1;
            Counter.BackColor = Color.Transparent;
        }

      
    }
}
