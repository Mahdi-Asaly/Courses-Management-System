using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Lecturer : Employee
    {
        private string department;
        private string degree;
        private int hoursPerWeek;
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public string Degree
        {
            get { return this.degree; }
            set { this.degree = value; }
        }
        public int HoursPerWeek
        {
            get { return this.hoursPerWeek; }
            set { this.hoursPerWeek = value; }
        }

        public Lecturer()
        {

        }

        public Lecturer(string _id, string _firstName, string _lastName, string _address, string _email, string _tel, DateTime _birthDay, string _login, string _password, string _department, string _degree, int _hoursPerWeek)
        {
            this.id = _id;
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.address = _address;
            this.email = _email;
            this.tel = _tel;
            this.birthDay = _birthDay;
            this.login = _login;
            this.password = _password;
            this.department = _department;
            this.degree = _degree;
            this.hoursPerWeek = _hoursPerWeek;
        }

    }
}
