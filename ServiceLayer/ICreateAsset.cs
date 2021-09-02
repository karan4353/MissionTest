using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface ICreateAsset
    {
        //create Asset
        string AddAsset(AssetMasterTable assetmaster);

        //GetAll Assets
        List<AssetMasterTable> GetAllAssets();
    }
}
