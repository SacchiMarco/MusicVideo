using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Videos
    {
        [Key]
        public int v_id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string titel { get; set; }
        public int dateigroesse { get; set; }
        public int qualitaet { get; set; }
        // Katergorien Id
        [ForeignKey("fk_a_id")]
        public virtual Kategorien Kategorien { get; set; }
        public int fk_a_id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string anmerkung { get; set; }
        public int benotung { get; set; }
        public int erscheinungsjahr { get; set; }
        public string album { get; set; }
        //Künstler Id$
        [ForeignKey("fk_k_id")]
        public virtual Kuenstler Kuenstler { get; set; }
        public int fk_k_id { get; set; }

    }
}