using BlazorServerAppDemo.Models;
using System.Collections.Generic;

namespace BlazorServerAppDemo
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        List<Contact> GetContacts();
    }
}