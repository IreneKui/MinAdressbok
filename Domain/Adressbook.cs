using System.Collections.Generic;
public class AddressBook
{
    private List<Contact> contactList = new List<Contact>();

    public void Add(Contact contact)
    {
        contactList.Add(contact);
    }

    public void AddContacts(List<Contact> contacts)
    {
        contactList.AddRange(contacts);
    }

    public List<Contact> GetContacts()
    {
        return new List<Contact>(contactList);
    }
}