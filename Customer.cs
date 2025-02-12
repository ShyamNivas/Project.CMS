using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;




namespace Demo.Serialization
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long ContactNumber { get; set; }

        public void SerializeCustomerData()
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream("C:\\DemoFolder\\CustomerData.txt", FileMode.Create, FileAccess.ReadWrite);
                Customer customer = new Customer() { CustomerId = 101, CustomerName = "Rocks", ContactNumber = 9003090030 };
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, customer);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void DeserializeCustomerData() { 
        
        }

    }
}
