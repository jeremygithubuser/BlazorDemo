using BlazorDemo.Dtos;
using System.Collections.Generic;

namespace BlazorDemo.Services
{
    public class ContactService : IContactService
    {
        public List<Contact> Contacts { get; set; }

        public ContactService()
        {
            Contacts = new List<Contact>()
{
            new Contact
            {
                Id=1,
                Name = "Alfreds Futterkiste",
                Country = "Germany",
            },
            new Contact
            {
                 Id=2,
                Name = "Berglunds snabbkop",
                Country = "Sweden",
            },
            new Contact
            {
                Id=3,
                Name = "Island Trading",
                Country = "UK",
            },
            new Contact
            {
                Id=4,
                Name = "Koniglich Essen",
                Country = "Germany",
            }
        };
        }

    }
}
