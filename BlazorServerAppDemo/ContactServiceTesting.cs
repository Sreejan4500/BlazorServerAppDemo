using BlazorServerAppDemo.Models;
using System.Collections.Generic;

namespace BlazorServerAppDemo
{
    public class ContactServiceTesting : IContactService
    {
        private readonly List<Contact> _contacts = [];
        void IContactService.AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        List<Contact> IContactService.GetContacts()
        {
            return
            [
                new()
                {
                    FirstName = "Test",
                    LastName = "Test",
                    Email = "Test",
                }
            ];
        }
    }
}
