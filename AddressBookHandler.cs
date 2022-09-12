using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AddressBookLinq
{
    public class AddressBookHandler
    {
        public static List<AddressBookModel> addressList = new List<AddressBookModel>();
        public static List<AddressBookModel> ListOfRecords()
        {
            string? next = string.Empty;
            bool anotheruser = true;
            try
            {
                Console.WriteLine("Enter the country you want to add address");
                var addressBook = Console.ReadLine();
                while (anotheruser)
                {
                    var addressBookData = new AddressBookModel();
                    Console.WriteLine("Enter first name");
                    addressBookData.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    addressBookData.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    addressBookData.Address = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    addressBookData.City = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    addressBookData.State = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    addressBookData.Email = Console.ReadLine();
                    Console.WriteLine("Enter  Zip Code");
                    addressBookData.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number ");
                    addressBookData.PhoneNumber = Console.ReadLine();
                    addressList.Add(addressBookData);
                    do
                    {
                        Console.WriteLine("Do you want to add again? press yes/no");
                        next = Console.ReadLine();
                    } while (next != "yes" && next != "no" && next != "Yes" && next != "No");
                    anotheruser = (next == "Yes" || next == "yes");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
            return addressList;
        }
        public static void Display()
        {

            foreach (AddressBookModel address in addressList)
            {
                Console.WriteLine($"Name: {address.FirstName + " " + address.LastName}, Email ID: {address.Email}, Phone Number: {address.PhoneNumber}, City: {address.City},Address: {address.Address} , City{address.City},State {address.State}");
            }
        }


    }
}
