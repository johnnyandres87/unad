using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUnad
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Principal objPrincipal = new Principal();
            objPrincipal.Visible = true;
           
        }
    }
}
