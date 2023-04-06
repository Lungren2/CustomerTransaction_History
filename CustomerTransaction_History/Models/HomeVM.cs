using CustomerTransaction_History.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ClientQuery.Models
{
    public class HomeVM

    {
        private SelectList _ClientDropdown { get; set; }

        public SelectList ClientDropdown
        {
            get
            {
                if (_ClientDropdown == null) { 
                    return _ClientDropdown;  
                }
                return new SelectList(GetClients(), "ClientName", "ClientBalance");
            }

            set
            {
                _ClientDropdown = value;
            }
        }

        public List<Clients> GetClients() 
        {
            var Clients = new List<Clients>();
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            return Clients;
        }
    }

}
