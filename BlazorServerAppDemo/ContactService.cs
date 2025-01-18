using BlazorServerAppDemo.Models;
using System.Collections.Generic;

namespace BlazorServerAppDemo
{
    public class ContactService : IContactService
    {
        public List<Contact> Contacts = new();

        public List<Contact> GetContacts() { return Contacts; }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

    }
}
