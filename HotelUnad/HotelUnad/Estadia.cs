using System;
using System.Collections.Generic;
using System.Text;

namespace HotelUnad
{
    public class Estadia
    {
		private String fullName;
		private int idUser;
		private String genderUser;
		private String typeRoom;
		private int stayDays;
		private double payValue;
        private double totalPay;
        private DateTime dateIngress;
        
        public Estadia(String fullName, int idUser, String genderUser, String typeRoom, int stayDays) { 
            this.fullName = fullName;
            this.idUser = idUser;
            this.genderUser = genderUser;
            this.typeRoom = typeRoom;
            this.stayDays = stayDays;
        }

        public Estadia() { 
        }

        public string FullName { get => fullName; set => fullName = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string GenderUser { get => genderUser; set => genderUser = value; }
        public string TypeRoom { get => typeRoom; set => typeRoom = value; }
        public int StayDays { get => stayDays; set => stayDays = value; }
        public double PayValue { get => payValue; set => payValue = value; }
        public double TotalPay { get => totalPay; set => totalPay = value; }
        public DateTime DateIngress { get => dateIngress; set => dateIngress = value; }

        public Double calculatePay(int stayDays, double payValue) {

            double totalPay=stayDays*payValue;
            return totalPay;
        }
        public override string ToString()
        {
            String msj = "El nombre del usuario es " + fullName 
                        +"\nEl id del usuario es:  " + idUser
                        +"\n el genero de usuario es: " + genderUser
                        +"\n el Tipo de cuadro es: " + typeRoom
                        + "\n el total de dias es:" + stayDays
                        + "\n el total por noche es:" + payValue
                        + "\n el total a pagar es: " + totalPay;
                        
            return msj;          
        }
        
    }
}
