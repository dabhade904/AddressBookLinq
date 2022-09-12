using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
                while (anotheruser)
                {
                    var addressBookData = new AddressBookModel();
                    /*    Console.WriteLine("Enter first name");
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
                        addressBookData.PhoneNumber = Console.ReadLine(); */
                    addressList.Add(new AddressBookModel("harsh", "dabhade", "shekta", "paithan", "mh", "dabhade904@gmail.com", "8888948943", 431105));
                    addressList.Add(new AddressBookModel("sachin", "dabhade", "shekta", "shekta", "mh", "dabhade904@gmail.com", "8888948943", 431105));
                    addressList.Add(new AddressBookModel("kamlesh", "dabhade", "shekta", "bidkeen", "mh", "dabhade904@gmail.com", "8888948943", 431105));
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
                Console.WriteLine($"Name: {address.FirstName + " " + address.LastName}, Email ID: {address.Email}, Phone Number: {address.PhoneNumber}, City: {address.City}, Address: {address.Address} , State {address.State}, Zip {address.Zip}");
            }
        }
        public static void UpdateFieldUsingName()
        {
            foreach (var updateData in addressList)
            {
                Console.WriteLine("Enter first Name ");
                string? firstName = Console.ReadLine();
                if (updateData.FirstName == firstName)
                {
                    Console.WriteLine("Enter first name");
                    updateData.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    updateData.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Email Id name");
                    updateData.Email = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number name");
                    updateData.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter State name");
                    updateData.State = Console.ReadLine();
                    Console.WriteLine("Enter Address name");
                    updateData.Address = Console.ReadLine();
                    Console.WriteLine("Enter City name");
                    updateData.City = Console.ReadLine();
                    Console.WriteLine("Enter Zip name");
                    updateData.Zip = 322344;
                }
            }
        }
        public static void RemoveList()
        {
            if (addressList.Count != 0)
            {
                Console.WriteLine("Enter First Name ");
                string? firstName = Console.ReadLine();
                var removeData = addressList.RemoveAll((x) => x.FirstName == firstName);
                Console.WriteLine("Data removed ");
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }
        public static void RetriveDataUsingCityAndState()
        {
            Console.WriteLine("Enter City ");
            string? city = Console.ReadLine();
            Console.WriteLine("Enter State ");
            string? state = Console.ReadLine();
            var selectedRecords = from data in addressList
                                  where (data.City==city || data.State==state)
                                  select data;
            Console.WriteLine("Date Fetched");
            foreach (AddressBookModel address in selectedRecords)
            {
                Console.WriteLine($"Name: {address.FirstName + " " + address.LastName}, Email ID: {address.Email}, Phone Number: {address.PhoneNumber}, City: {address.City}, Address: {address.Address} , State {address.State}, Zip {address.Zip}");
            }
        }

        public static void GetCountOfRecords()
        {
            var recordData = addressList
                .GroupBy(user => user.City )
                .Select(user => new { data = user.Key, Count = user.Count() });
            foreach (var reocrdCount in recordData)
            {
                Console.WriteLine(reocrdCount.data + " ------- " + recordData.Count());
            }
        }
    }
}
