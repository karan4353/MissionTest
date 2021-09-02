using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class VendorTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int v_id { get; set; }
        [Required]
        public string v_name { get; set; }
        [Required]
        public string v_type { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime v_from { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime v_to { get; set; }

        public int? at_id { get; set; }

        [ForeignKey("at_id")]
        public virtual AssetType AssetTypes { get; set; }
    }
}
