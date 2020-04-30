using System;
using System.Collections.Generic;
using System.Text;

namespace crm
{
    class Customer
    {

       public DateTime Created { get; private set; }

       public string Firstname { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public string VatNumber { get; private set; }
       public string Mobile { get; set; }
       public decimal TotalGross { get; private set; }
       public bool IsActive { get; set; }
       

        public Customer(string vatNumber)
        {
            if (!IsValidVatumber(vatNumber))
            {
                throw new Exception("Invalid Vatnunmber");
            }
            VatNumber = vatNumber;
            Created = DateTime.Now;
        }

      public bool IsValidVatumber(string vatNumber)
        {
            return    
                !string.IsNullOrWhiteSpace(vatNumber) && vatNumber.Length == 9;
        }

    }
}
