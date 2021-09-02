using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class AssetDefination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ad_id { get; set; }
       
        public string ad_name { get; set; }
        
        public string ad_class { get; set; }

        public int? at_id { get; set; }

        [ForeignKey("at_id")]
        public virtual AssetType AssetTypes { get; set; }

    }
}
