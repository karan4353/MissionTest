using DomainLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class AssetService : ICreateAsset
    {
        
        private readonly AppDBContext _dbContext;
        public AssetService(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            

        }

        public string AddAsset(AssetMasterTable assetmaster)
        {
            this._dbContext.AssetMasterTables.Add(assetmaster);
            this._dbContext.SaveChanges();
            return ("Asset Created");
        }

        public List<AssetMasterTable> GetAllAssets()
        {
            throw new NotImplementedException();
        }
    }
}
