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
