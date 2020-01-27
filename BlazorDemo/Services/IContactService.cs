using BlazorDemo.Dtos;
using System.Collections.Generic;

namespace BlazorDemo.Services
{
    public interface IContactService
    {
        public List<ContactModel> Contacts { get; set; }

        public void CreateContact(CreateContactModel createContactModel);
    }
}