using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Kuenstler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int k_id { get; set; }
        public string k_name { get; set; }

        [ForeignKey("fk_k_id")]
        [Display(Name = "Künstler")]
        public ICollection<Videos> Videos { get; set; }
    }
}