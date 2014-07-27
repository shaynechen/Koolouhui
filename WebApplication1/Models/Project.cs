using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Koo.Web.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(150)]
        public string ShortDescription { get; set; }

        [Required]
        public string Description { get; set; }

        public string CoverImageUrl { get; set; }

        /// <summary>
        /// should be removed
        /// </summary>
        public bool IsHighlighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RatingValue { get; set; }

        public string Status { get; set; }

    }
}