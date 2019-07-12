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
    public partial class EditorProveedores : Form
    {
        public EditorProveedores()
        {
            InitializeComponent();
        }

        private void AddProv_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            SearchProv.Visible = false;
            button4.Visible = false;
            Updatebutton.Visible = false;
            Erasebutton.Visible = false;
        }

        private void EditProv_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
            SearchProv.Visible = true;
            button4.Visible = true;
            Updatebutton.Visible = true;
            Erasebutton.Visible = true;
        }
    }
}
