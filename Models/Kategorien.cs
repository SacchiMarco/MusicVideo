using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Kategorien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int a_id { get; set; }
        public string a_name { get; set; }
        
        [ForeignKey("fk_a_id")]
        public ICollection<Videos> Videos { get; set; }
    }
}