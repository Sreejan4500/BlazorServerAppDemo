using BlazorServerAppDemo.Models;
using System.Collections.Generic;

namespace BlazorServerAppDemo
{
    public class ContactService
    {
        public List<Contact> Contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

    }
}
