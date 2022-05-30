using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_EF_CRUD_PostgreSQL.Models
{
    [Table("emp",Schema ="public")]
    public class Emp
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public string empaddress { get; set; }
        public string email { get; set; }
        public int salary { get; set; }
    }
}