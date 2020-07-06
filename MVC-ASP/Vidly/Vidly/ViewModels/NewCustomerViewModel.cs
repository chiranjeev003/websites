using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public int? Id { get; set; }
        public string Title
        {
            get
            {
                //return Id != null ? "Edit Customer" : "New Customer";
                if(Id != null)
                {
                    return "Edit Customer";
                }
                else
                {
                    return "New Customer";
                }
            }
        }
    }
}