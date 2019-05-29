using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mike.models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Header { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Content { get; set; }

        public int? ParentSectionId { get; set; }

        [ForeignKey("ParentSectionId")]
        public Section ParentSection { get; set; }

        public IEnumerable<Section> Subsections { get; set; }
    }
}
