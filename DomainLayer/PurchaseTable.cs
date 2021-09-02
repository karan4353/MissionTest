using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class PurchaseTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int p_id { get; set; }
        [Required]
        public int order_no { get; set; }
        [Required]
        public int qty { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime order_date { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime del_date { get; set; }
        [Required]
        public string status { get; set; }

        public int? v_id { get; set; }
        public int? ad_id { get; set; }
        public int? at_id { get; set; }

        [ForeignKey("at_id")]
        public virtual AssetType AssetTypes { get; set; }

        [ForeignKey("ad_id")]
        public virtual AssetDefination AssetDefinations { get; set; }

        [ForeignKey("v_id")]
        public virtual VendorTable VendorTables { get; set; }

    }
}
