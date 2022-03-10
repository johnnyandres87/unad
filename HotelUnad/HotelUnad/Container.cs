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
            Boolean status = textBoxPassword.Text.Equals("123")?true:false;

            if (status){
                Principal objPrincipal = new Principal();
                objPrincipal.Visible = true;
                textBoxPassword.Text = "";
                               
            }
            else{
                MessageBox.Show("Clave incorrecta", "Advertencia",MessageBoxButtons.OK);
                textBoxPassword.Text = "";
            }
           
        }
    }
}
