using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTIS.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public int OfficeNo { get; set; }
        public DateTime WorkingHour { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

    }


}
