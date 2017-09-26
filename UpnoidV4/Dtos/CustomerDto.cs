using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UpnoidV4.Dtos;
using UpnoidV4.Models;

namespace UpnoidV4.Dto
{
    public class CustomerDto
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubcribedToNewsletter { get; set; }    
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

       // [Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }
    }
}