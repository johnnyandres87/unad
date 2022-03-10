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

        public Estadia(String fullName, int idUser, String genderUser, String typeRoom) { 
            this.fullName = fullName;
            this.idUser = idUser;
            this.genderUser = genderUser;
            this.typeRoom = typeRoom;
        }

        public Estadia() { 
        }

        public string FullName { get => fullName; set => fullName = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string GenderUser { get => genderUser; set => genderUser = value; }
        public string TypeRoom { get => typeRoom; set => typeRoom = value; }
        public int StayDays { get => stayDays; set => stayDays = value; }
        public double PayValue { get => payValue; set => payValue = value; }

        public Double calculatePay(int stayDays, double payValue) {

            double totalPay=stayDays*payValue;
            return totalPay;
        }
    }
}
