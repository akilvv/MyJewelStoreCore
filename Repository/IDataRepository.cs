using MyJewelStoreCore.Context.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Repository
{
    public interface IDataRepository
    {
        UserMaster AuthorizeUser(string userName, string encryptPass);
        string GetConfig(string key);
    }
}
