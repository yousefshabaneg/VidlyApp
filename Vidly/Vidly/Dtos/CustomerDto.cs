using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        
        [Required, StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        // We Commented this Attribute because the In this attribute we casting the instanse
        // to a Customer Object so,
        // if we passing to it a CustomerDto object we will get an exception!!!. video(IHttpActionResult IN API Section)
        public DateTime? BirthDate { get; set; }
    }
}