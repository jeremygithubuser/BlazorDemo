using BlazorDemo.Dtos;
using System.Collections.Generic;

namespace BlazorDemo.Services
{
    public interface IContactService
    {
        public List<Contact> Contacts { get; set; }
    }
}