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
            
            Boolean status = (getId().Equals("") || getName().Equals("") || getGender().Equals(" ")
                || getTypeRoom().Equals(""))?true:false;
            return status;
        }

        


    }
}
