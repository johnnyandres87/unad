using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelUnad
{
    public partial class Reporte : Form
    {

        private String name;
        private int id;
        private String gender;
        private int days;
        private String typeRoom;
        private double payValue;
        private DateTime dateIngress;
        private double payRoom;

        

        
        public Reporte()
        {
            InitializeComponent();
           
        }

        public double getPayRoom() {
            return payRoom;
         }

        public void setPayRoom(double payRoom) {
            this.payRoom = payRoom;
        }

        public DateTime getDateIngress()
        {
            return dateIngress;
        }

        public void setDateIngress(DateTime dateIngress) { 
            this.dateIngress = dateIngress;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getGender()
        {
            return gender;
        }
        public void setGender(String gender)
        {
            this.gender = gender;
        }
        public int getDays()
        {
            return days;
        }
        public void setDays(int days)
        {
            this.days = days;
        }
        public String getTypeRoom()
        {
            return typeRoom;
        }
        public void setTypeRoom(String typeRoom)
        {
            this.typeRoom = typeRoom;
        }
        public double getPayValue()
        {
            return payValue;
        }
        public void setPayValue(double payValue)
        {
            this.payValue = payValue;
        }

        public void addInfo() {

            textBoxCustomer.Text = name.ToString();
            textBoxIdCustomer.Text = id.ToString();
            textBoxGenderCostume.Text = gender.ToString();
            textBoxDays.Text = days.ToString();
            textBoxTypeRoom.Text = typeRoom.ToString();
            textBoxPayValue.Text = "$"+payValue.ToString();
            textBoxDate.Text = dateIngress.ToString();
            textBoxPayRoom.Text ="$"+ payRoom.ToString();
            
        }

        public void cleanWindow() {
            textBoxCustomer.Text = "";
            textBoxIdCustomer.Text = "";
            textBoxGenderCostume.Text = "";
            textBoxDays.Text = "";
            textBoxTypeRoom.Text = "";
            textBoxPayValue.Text = "";
            textBoxDate.Text = "";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            cleanWindow();
            this.Close();

        }
    }
}
