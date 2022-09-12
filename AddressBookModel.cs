using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBookModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        public int? Zip { get; set; }

    }
}
