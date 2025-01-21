using BlazorServerAppDemo.Models;
using BlazorServerAppDemo.Pages.ContactComponents;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService ContactService {  get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        private List<Contact> contacts;
        private ContactList ContactList; // Here, we have done the component reference thing.
        private bool isContactDisplayed = true;

        private Dictionary<string, object> MyTextAttributes = new() {
            {"placeholder", "Placeholder 03"},
            {"type", "number"}
        };

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);

            contacts = ContactService.GetContacts();
            contacts = new List<Contact>
            {
                new() {
                    FirstName = "Sreejan",
                    LastName = "Chowdhury",
                    Email = "sc@gmail.com"
                },
                new() {
                    FirstName = "Akash",
                    LastName = "Derasree",
                    Email = "skyad@gmail.com"
                }
            };

            await base.OnInitializedAsync();

        }

        private void HideContacts()
        {
            isContactDisplayed = !isContactDisplayed;

            if (isContactDisplayed)
                ContactList.ShowContacts();
            else
                ContactList.HideContacts();
        }

        private void NavigateToTest()
        {
            NavigationManager.NavigateTo("./testpage");
        }
    }
}
