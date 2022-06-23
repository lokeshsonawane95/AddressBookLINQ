﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    public class AddressBookManagement
    {
        public DataTable UpdatedContactDetails(DataTable dataTable)
        {
            var recordedData = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals("Lokesh")).FirstOrDefault();
            recordedData["address"] = "Viman Nagar";
            Console.WriteLine("Updated Data is : \n");
            Console.WriteLine("First Name : " + recordedData.Field<string>("firstName"));
            Console.WriteLine("Last Name : " + recordedData.Field<string>("lastName"));
            Console.WriteLine("Address : " + recordedData.Field<string>("address"));
            Console.WriteLine("City : " + recordedData.Field<string>("city"));
            Console.WriteLine("State : " + recordedData.Field<string>("state"));
            Console.WriteLine("Zip : " + Convert.ToInt32(recordedData.Field<int>("zip")));
            Console.WriteLine("Phone Number : " + Convert.ToDouble(recordedData.Field<double>("phoneNumber")));
            Console.WriteLine("eMail : " + recordedData.Field<string>("eMail"));
            Console.WriteLine();

            return dataTable;
        }

        public void DisplayAllData(DataTable dataTable)
        {
            Console.WriteLine("Address Book contains : \n");
            foreach (var data in dataTable.AsEnumerable())
            {
                Console.WriteLine("First Name : " + data.Field<string>("firstName"));
                Console.WriteLine("Last Name : " + data.Field<string>("lastName"));
                Console.WriteLine("Address : " + data.Field<string>("address"));
                Console.WriteLine("City : " + data.Field<string>("city"));
                Console.WriteLine("State : " + data.Field<string>("state"));
                Console.WriteLine("Zip : " + Convert.ToInt32(data.Field<int>("zip")));
                Console.WriteLine("Phone Number : " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
                Console.WriteLine("eMail : " + data.Field<string>("eMail"));
                Console.WriteLine();
            }
        }
    }
}