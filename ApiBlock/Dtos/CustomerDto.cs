using ApiBlock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiBlock.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public bool IsSubcribeToNewsletter { get; set; }
       
        public byte MembershipTypeId { get; set; }
        
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
    }
}