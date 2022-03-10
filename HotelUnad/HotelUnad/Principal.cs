using System;
using System.Collections;
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
        ArrayList myArray = new ArrayList();

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

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
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

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public String getTypeRoom()
        {
            return typeRoom;
        }

        public void setTypeRoom(String typeRoom)
        {
            this.typeRoom = typeRoom;
        }


        public Boolean validateStateFields(){

            Boolean status = ((!String.IsNullOrEmpty(textBoxId.Text)) &&
                (!String.IsNullOrEmpty(textBoxName.Text)) && (!String.IsNullOrEmpty(comboBoxGender.Text))
                && (!String.IsNullOrEmpty(comboBoxRoom.Text)))?true:false;

            return status;
        }

        public void getPayment()
        {

            if (validateStateFields())
            {
                id = int.Parse(textBoxId.Text);
                name = textBoxName.Text;
                gender = comboBoxGender.SelectedText;
                typeRoom = comboBoxRoom.SelectedText;
                DateTime dateIn = dateTimePickerIn.Value.Date;
                DateTime dateOut = dateTimePickerOut.Value.Date;
                TimeSpan timeSpan = dateOut - dateIn;
                int difDates = timeSpan.Days;

                objEstadia.calculatePay(int.Parse(textBoxValue.Text),difDates);
                objEstadia.FullName = name;
                objEstadia.IdUser = id;
                objEstadia.TypeRoom = typeRoom;
                myArray.Add(objEstadia);

                MessageBox.Show("Datos Almacenados " + "dateIn "+ dateIn +
                    " dateOut "+ dateOut + " Total dias " + timeSpan, "", MessageBoxButtons.OKCancel);
            }
            else
            {

                MessageBox.Show("aun hay campos vacios", "Error", MessageBoxButtons.OKCancel);
            }
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getPayment();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sencilla = 70000;
            int doble = 90000;
            int especial = 120000;

            if (comboBoxRoom.SelectedIndex == 1)
            {

                textBoxValue.Text =sencilla.ToString();
            }
            else if (comboBoxRoom.SelectedIndex == 2)
            {

                textBoxValue.Text =doble.ToString();
            }
            else if (comboBoxRoom.SelectedIndex == 3)
            {

                textBoxValue.Text =especial.ToString();
            }
            else if (comboBoxRoom.SelectedIndex == 0)
            {

                textBoxValue.Text = " ";
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            
        }
    }
}
