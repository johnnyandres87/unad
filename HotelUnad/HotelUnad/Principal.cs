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

        
        Reporte objReporte = new Reporte();
        List<Estadia> myList;

        private int id;
        private string name;
        private string gender;
        private string typeRoom;
       

        public Principal()
        {
            InitializeComponent();
        }

        public int getId(){
            return id;
        }

        public void setId(int id){
            this.id = id;
        }

        public string getName(){
            return name;
        }

        public void setName(String name){
            this.name = name;
        }

        public string getGender(){
            return gender;
        }

        public void setGender(string gender){
            this.gender = gender;
        }

        public String getTypeRoom(){
            return typeRoom;
        }

        public void setTypeRoom(String typeRoom){
            this.typeRoom = typeRoom;
        }


        public Boolean validateStateFields(){

            Boolean status = ((!String.IsNullOrEmpty(textBoxId.Text)) &&
                (!String.IsNullOrEmpty(textBoxName.Text)) && (!String.IsNullOrEmpty(comboBoxGender.Text))
                && (!String.IsNullOrEmpty(comboBoxRoom.Text)))?true:false;

            return status;
        }

        public Estadia getEstadia(){

            if (validateStateFields()){
                
                Estadia objEstadia = new Estadia();
                id = int.Parse(textBoxId.Text);
                name = textBoxName.Text;
                gender = comboBoxGender.SelectedItem.ToString();
                typeRoom = comboBoxRoom.SelectedItem.ToString();
                DateTime dateIn = DateTime.Now;
                DateTime dateOut = dateTimePickerOut.Value.Date;
                TimeSpan timeSpan = dateOut - dateIn;
                int difDates = timeSpan.Days;
                int payValueRoom = int.Parse(textBoxValue.Text);
                double totalPayLocal = objEstadia.calculatePay(difDates,payValueRoom);

                objEstadia.TotalPay = totalPayLocal;
                objEstadia.FullName = name;
                objEstadia.IdUser = id;
                objEstadia.TypeRoom = typeRoom;
                objEstadia.GenderUser = gender;
                objEstadia.StayDays = difDates;
                objEstadia.PayValue = payValueRoom;
                objEstadia.DateIngress = dateIn;
                return objEstadia;
                
                }
            else
            {

                MessageBox.Show("aun hay campos vacios", "Error", MessageBoxButtons.OKCancel);
                return null;
            }
        }

        

        public void setVisible(Estadia objEstadia)
        {
            objReporte.setName(objEstadia.FullName);
            objReporte.setId(objEstadia.IdUser);
            objReporte.setTypeRoom(objEstadia.TypeRoom);
            objReporte.setGender(objEstadia.GenderUser);
            objReporte.setDays(objEstadia.StayDays);
            objReporte.setPayValue(objEstadia.TotalPay);
            objReporte.setDateIngress(objEstadia.DateIngress);
            objReporte.setPayRoom(objEstadia.PayValue);
            objReporte.addInfo();
            
        }

        public void cleanWindow(){
            textBoxId.Text = "";
            textBoxName.Text = "";
            comboBoxGender.SelectedIndex = 0;
            comboBoxRoom.SelectedIndex = 0;
            textBoxValue.Text = "";
        }

        public void getValueRooms(Object obj , EventArgs e) {

            int sencilla = 70000;
            int doble = 90000;
            int especial = 120000;

            if (comboBoxRoom.SelectedIndex == 1){

                textBoxValue.Text = sencilla.ToString();
            }else if (comboBoxRoom.SelectedIndex == 2){

                textBoxValue.Text = doble.ToString();
            }else if (comboBoxRoom.SelectedIndex == 3){

                textBoxValue.Text = especial.ToString();
            }else if (comboBoxRoom.SelectedIndex == 0){

                textBoxValue.Text = " ";
            }

        }

        private void buttonSave_Click(object sender, EventArgs e){
            getEstadia();
            MessageBox.Show("Datos Almacenados exitosamente", "Datos", MessageBoxButtons.OK);
        }

        private void buttonExit_Click(object sender, EventArgs e){
            DialogResult msj = MessageBox.Show("Desea salir de la aplicacion?", "Warning", MessageBoxButtons.OKCancel);
            if (msj == DialogResult.OK) {

                Application.Exit();
            }
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e){
            getValueRooms(sender, e);
        }

        private void buttonShow_Click(object sender, EventArgs e){
            setVisible(getEstadia());
            objReporte.Visible = true;
            cleanWindow();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
