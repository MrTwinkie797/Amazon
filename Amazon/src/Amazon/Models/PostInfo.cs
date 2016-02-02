using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    [Table("Comment")]
    public class PostInfo
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string Name { get; set; }
        public DateTime? Date {get; set;}
    }
}
