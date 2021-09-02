using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class AssetMasterTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int am_id { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public int s_num { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime p_date { get; set; }
        [Required]
        public string warrenty { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime d_from { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime d_to { get; set; }

        public int? at_id { get; set; }
        [ForeignKey("at_id")]
        public virtual AssetType AssetTypes { get; set; }
        public int? ad_id { get; set; }
        [ForeignKey("ad_id")]
        public virtual AssetDefination AssetDefinations { get; set; }
        public int? v_id { get; set; }

  
        [ForeignKey("v_id")]
        public virtual VendorTable VendorTables { get; set; }
    }
}
