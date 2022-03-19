using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTIS.Models
{
    public class HumanResourcesSpecialist
    {
        [Key]
        public int Id { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
    }
}
