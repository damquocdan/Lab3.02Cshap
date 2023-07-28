using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._02Cshap
{
    internal class Contact
    {
        //Khai báo các trường
        public int id;
        public string firstName;
        public string lastName;
        public string address;
        public string phone;
        public string email;
        // tạo contructor không tham số
        public Contact()
        {

        }
        // tạo contructor với các tham số
        public Contact(int id, string firstName, string lastName, string address, string phone, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        //tạo thuộc tính cho các trường
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {

            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        // Định nghĩa phương thức Display

        public void Display()
        {
            Console.WriteLine("Mã số:" + id);
            Console.WriteLine("Họ và tên:{0} {1}",firstName,lastName);
            Console.WriteLine("Địa chỉ:" + address);
            Console.WriteLine("Điện thoại" + phone);
            Console.WriteLine("Email:" + email);
        }
    }
}
