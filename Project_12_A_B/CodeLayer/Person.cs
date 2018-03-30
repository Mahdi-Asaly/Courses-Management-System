using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Person
    {
        protected string id;
        protected string firstName;
        protected string lastName;
        protected string address;
        protected string email;
        protected string tel;
        protected DateTime birthDay;
        //protected Image img;
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public DateTime BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }

        public Person()
        {

        }
        public Person(string _id, string _firstName, string _lastName, string _address, string _email, string _tel, DateTime _birthDay)
        {
            this.id = _id;
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.address = _address;
            this.email = _email;
            this.tel = _tel;
            this.birthDay = _birthDay;
        }

        public string getId()
        {
            return this.id;
        }
    }
}
