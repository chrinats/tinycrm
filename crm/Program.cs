using System;

namespace crm
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var chrinats = new Customer("123456789");
            } catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
          //  chrinats.IsValidVatnumber = "12345678";
         //   chrinats.Email = "chrinats@gmail.com";
//chrinats.Mobile = "9999999999";
            // chrinats.TotalGross = 150M;

          //  Console.WriteLine(chrinats.VatNumber); 
          //  chrinats.IsValidAfm();
           // chrinats.IsValidEmail();
        }
    }
}
