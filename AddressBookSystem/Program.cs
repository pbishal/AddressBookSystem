using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddressBook obj = new AddressBook();//create object of AddressBook class


            Console.WriteLine("Welcome in Address book System");
            Console.WriteLine("*********************");
            //creating dictionary abDict
            Dictionary<string, AddressBook> abDict = new Dictionary<string, AddressBook>();//store Key ValuePair String is Key and AddressBook is value
            bool Result = true;

            Console.WriteLine("\nHow many address Book you want to create : ");
            int numAddressBooks = Convert.ToInt32(Console.ReadLine());//covert string into int with the help of ToInt32()
            for (int i = 1; i <= numAddressBooks; i++)
            {
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string bookName = Console.ReadLine();
                AddressBook addressBook = new AddressBook();//create obj 
                abDict.Add(bookName, addressBook);//Add bookName in dictionary
            }
            Console.WriteLine("\nYou have created following Address Books : ");
            foreach (var item in abDict) //var is used and it is store any data type value.
            {
                Console.WriteLine("{0}", item.Key);
            }
            while (Result)
            {
                Console.WriteLine("\nChoose option \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Search Person By City & State \n6.Display Contacts Same City \n7.Display Contacts Same State \n8.View number of contacts of city and state  \n9.Display Contacts in Sorted \n10.Display contact in sorted by state or by city \n11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                        string contactName = Console.ReadLine();
                        if (abDict.ContainsKey(contactName))//DEtermine whether the dictionary contains specified key
                        {
                            Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                            int numberOfContacts = Convert.ToInt32(Console.ReadLine());//taling i/p from user and convert into int with the help of ToInt32()
                            for (int i = 1; i <= numberOfContacts; i++)
                            {
                                addContactBook(abDict[contactName]);
                            }
                            abDict[contactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No AddressBook exist with name {0}", contactName);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book Name for edit contact");
                        string editcontactName = Console.ReadLine();
                        if (abDict.ContainsKey(editcontactName))//check whether the dictionary contains specified key
                        {
                            abDict[editcontactName].editPerson();
                            abDict[editcontactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Address Book Name for delete contact");
                        string deleteContact = Console.ReadLine();
                        if (abDict.ContainsKey(deleteContact))
                        {
                            abDict[deleteContact].deletePerson();
                            abDict[deleteContact].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Address Book Name for display contacts");
                        string displayContactsInAddressBook = Console.ReadLine();
                        abDict[displayContactsInAddressBook].displayPerson();
                        break;
                    case 5:
                        Console.WriteLine("\n Enter address book name :");
                        string searchContacts = Console.ReadLine();
                        if (abDict.ContainsKey(searchContacts))
                        {
                            abDict[searchContacts].searchPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", searchContacts);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n Enter address book name :");
                        string displayContacts = Console.ReadLine();
                        if (abDict.ContainsKey(displayContacts))
                        {
                            abDict[displayContacts].sameCityPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts);
                        }
                        break;
                    case 7:
                        Console.WriteLine("\n Enter address book name :");
                        string displayContacts2 = Console.ReadLine();
                        if (abDict.ContainsKey(displayContacts2))
                        {
                            abDict[displayContacts2].sameStatePerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts2);
                        }
                        break;
                    case 8:
                        Console.WriteLine("\n Enter address book name :For counting same city or state");
                        string displayContacts3 = Console.ReadLine();
                        if (abDict.ContainsKey(displayContacts3))
                        {
                            abDict[displayContacts3].findCountSameStateOrCityPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts3);
                        }
                        break;

                    case 9:
                        Console.WriteLine("\nEnter Address Book Name for display contacts in sorted order");
                        string nameAddressBook = Console.ReadLine();
                        abDict[nameAddressBook].displayPersonInOrder();
                        break;
                    case 10:
                        Console.WriteLine("\nEnter Address Book Name for Sort contacts based on City or State");
                        string nameAddressBookforSorting = Console.ReadLine();
                        Console.WriteLine("\nChoose option for sorting \n1.By City  \n2.By State \n3.By Zip");
                        int choiceSorting = Convert.ToInt32(Console.ReadLine());
                        switch (choiceSorting)
                        {
                            case 1:
                                abDict[nameAddressBookforSorting].displayPersonInOrderByCity();//call method
                                break;
                            case 2:
                                abDict[nameAddressBookforSorting].displayPersonInOrderByState();
                                break;
                            case 3:
                                abDict[nameAddressBookforSorting].displayPersonInOrderByZip();
                                break;
                        }
                        break;

                    case 11:
                        Result = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }
            void addContactBook(AddressBook addressBook)
            {
                Console.WriteLine("Enter First Name : ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name : ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State : ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Phone Number : ");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email id :");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Zip : ");
                int zip = Convert.ToInt32(Console.ReadLine());
                addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email, zip);
            }

        }
    }
}
