using BlazorServerAppDemo.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService contactService {  get; set; }
        private List<Contact> contacts;

        private Dictionary<string, object> MyTextAttributes = new() {
            {"placeholder", "Placeholder 03"},
            {"type", "number"}
        };

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);

            contacts = contactService.GetContacts();
            //contacts = new List<Contact>
            //{
            //    new() {
            //        FirstName = "Sreejan",
            //        LastName = "Chowdhury",
            //        Email = "sc@gmail.com"
            //    },
            //    new() {
            //        FirstName = "Akash",
            //        LastName = "Derasree",
            //        Email = "skyad@gmail.com"
            //    }
            //};

            await base.OnInitializedAsync();

        }
    }
}
