using BlazorDemo.Dtos;
using System;
using System.Collections.Generic;

namespace BlazorDemo.Services
{
    public class ContactService : IContactService
    {
        public List<ContactModel> Contacts { get; set; }

        public ContactService()
        {
            Contacts = new List<ContactModel>()
{
            new ContactModel
            {
                Id=Guid.NewGuid(),
                Name = "Alfreds Futterkiste",
                Country = "Germany",
            },
            new ContactModel
            {
                Id=Guid.NewGuid(),
                Name = "Berglunds snabbkop",
                Country = "Sweden",
            },
            new ContactModel
            {
                Id=Guid.NewGuid(),
                Name = "Island Trading",
                Country = "UK",
            },
            new ContactModel
            {
                Id=Guid.NewGuid(),
                Name = "Koniglich Essen",
                Country = "Germany",
            }
        };
        }

        public void CreateContact(CreateContactModel createContactModel)
        {
            Contacts.Add(new ContactModel
            {
                Id = Guid.NewGuid(),
                Name = createContactModel.Name,
                Country = createContactModel.Country,
                Address = createContactModel.Address,
                PhoneNumber = createContactModel.PhoneNumber
            });
        }
    }
}
