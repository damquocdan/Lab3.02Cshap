using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._02Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tạo đối tượng cho contact với contructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 1;
            ct1.FirstName = "Đàm Quốc";
            ct1.LastName = "Dân";
            ct1.Address = "Từ sơn";
            ct1.Email = "damquocdan@gmail.com";
            ct1.Phone = "1234567890";


            // tạo đối tượng contact với contructor có tham số
            Contact ct2 = new Contact(2,"Trần thị","Linh","Bắc Ninh","0987654321","bupbecotinhye@hihi.com");
            // hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();

            Console.ReadKey();

        }

    }
}
