using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelUnad
{
    public partial class Principal : Form
    {

        Estadia objEstadia = new Estadia();
        
        private int id;
        private string name;
        private string gender;
        private string typeRoom;
        
        public Principal()
        {
            InitializeComponent();
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id) {
            this.id = id;
        }

        public string getName() { 
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public string getGender()
        {
            return gender;
        }

        public void setGender(string gender) { 
            this.gender = gender;
        }

        public String getTypeRoom() { 
            return typeRoom;
        }

        public void setTypeRoom(String typeRoom)
        {
            this.typeRoom = typeRoom;
        }


        public Boolean validateStateFields() {
            
            Boolean status = (textBoxId.Equals("")||textBoxName.Equals("")
                ||comboBoxGender.SelectedIndex
                .Equals(0)||comboBoxRoom.SelectedIndex.Equals(0))?true:false;
            return status;
        }

        public void getPayment() {

            if (validateStateFields())
            {
                id = int.Parse(textBoxId.Text);
                name = textBoxName.Text;
                gender = comboBoxGender.SelectedText;
                typeRoom = comboBoxRoom.SelectedText;
            }
            else
            {
                MessageBox.Show("aun hay campos vacios","Error",MessageBoxButtons.OKCancel);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getPayment();
        }

        
    }
}
