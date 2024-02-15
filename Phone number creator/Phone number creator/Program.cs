using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_number_creator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USA = 1 , DE = 49 , FR = 33 , PL = 48 , TR = 90");
            int cou_code = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            string randomPhoneNumber = GenerateRandomPhoneNumber(random);
            Console.Clear();
            Console.WriteLine("Phone number : " + "+" + cou_code + " " + randomPhoneNumber);
            Console.ReadLine();
        }


        static string GenerateRandomPhoneNumber(Random random)
        {

            string phoneNumber = $"{random.Next(0, 999)}-{random.Next(100, 999)}-{random.Next(1000, 9999)}";
            return phoneNumber;
        }
    }
}

