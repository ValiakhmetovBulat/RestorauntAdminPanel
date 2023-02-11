using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Data.Entities
{
    public class MenuPosition
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string? Decription { get; set; }
        public int SectionId { get; set; }
        public Section? Section { get; set; }
        public int PositionTypeId { get; set; }
        public PositionType? PositionType { get; set; }
    }
}
