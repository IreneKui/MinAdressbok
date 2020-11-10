using System;

namespace Addressbok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa adressbok
            AddressBook addressBook = new AddressBook();

            //Lägg in några kontakter från början
            GenerateFakecontacts(addressBook);

            //Lista kontakter:
            foreach (Contact minKontakt in addressBook.GetContacts())
            {
                PrintContact(minKontakt);
            }
        }

        static void PrintContact(Contact minKontakt)
        {
            Console.WriteLine("FirstName: " + minKontakt.FirstName);
            Console.WriteLine("LastName: " + minKontakt.LastName);

            BusinessContact bs = minKontakt as BusinessContact;

            Type typen = minKontakt.GetType();

            // typeof(Contact);
            if(minKontakt is PrivateContact privateContact)
            {
                Console.WriteLine("Birthday: " + privateContact.Birthday.ToString("yyyy/MM/dd"));
            }
            else if (minKontakt is BusinessContact bc)
            {
                Console.WriteLine("Company: " + bc.Company);
            }
            Console.WriteLine();
        }

        static void GenerateFakecontacts(AddressBook addressBook)
        {
            //1. Lägg till kontakt via UI så småningom
            BusinessContact nyKontakt;
            nyKontakt = new BusinessContact();
            nyKontakt.FirstName = "Lisa";
            nyKontakt.Company ="BY";

            addressBook.Add(nyKontakt);

            PrivateContact nyPrivatKontakt = new PrivateContact();
            nyPrivatKontakt.FirstName = "Arne";
            nyPrivatKontakt.RelationType ="It's compicated";
            nyPrivatKontakt.Birthday = new DateTime(1981, 6 , 1);

            addressBook.Add(nyPrivatKontakt);
        }
    }
}
