using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpnoidV4.Models;

namespace UpnoidV4.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}