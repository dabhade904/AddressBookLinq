using static System.Net.Mime.MediaTypeNames;
namespace AddressBookLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice: \n 1. Create Person Details \n 2. Display Person Data \n 3. Update Data \n 4. Remove Data \n 5.Retrive Data Using City And State \n 0 .Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddressBookHandler.ListOfRecords();
                        break;
                    case 2:
                        AddressBookHandler.Display();
                        break;
                    case 3:
                        AddressBookHandler.UpdateFieldUsingName();
                        break;
                    case 4:
                        AddressBookHandler.RemoveList();
                        break;
                    case 5:
                        AddressBookHandler.RetriveDataUsingCityAndState();
                        break;
                    case 6:
                        AddressBookHandler.GetCountOfRecords();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
