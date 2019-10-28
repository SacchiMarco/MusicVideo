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
        [Display(Name = "Titel *")]
        [Required]
        public string titel { get; set; }

        [Display(Name = "Dateigrösse *")]
        public int dateigroesse { get; set; }

        [Display(Name = "Qualität *")]
        [Range(1,10)]
        public int qualitaet { get; set; }

        // Katergorien Id
        [ForeignKey("fk_a_id")]
        public virtual Kategorien Kategorien { get; set; }
        [Display(Name = "Kategorie *")]
        public int fk_a_id { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(255)]
        [Display(Name = "Anmerkung")]
        public string anmerkung { get; set; }

        [Display(Name = "Benotung *")]
        [Range(1,6)]
        public int benotung { get; set; }

        [Display(Name = "Erscheinungsjahr")]
        public int? erscheinungsjahr { get; set; }

        [Display(Name = "Album")]
        public string album { get; set; }
        
        //Künstler Id$
        [ForeignKey("fk_k_id")]
        public virtual Kuenstler Kuenstler { get; set; }
        [Display(Name = "Künstler *")]
        public int fk_k_id { get; set; }

    }
}