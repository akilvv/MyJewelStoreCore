using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyJewelStoreCore.Context;
using MyJewelStoreCore.Context.Config;
using MyJewelStoreCore.Context.Enum;
using MyJewelStoreCore.Context.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Repository
{
    public class DataRepository: IDataRepository
    {
        private JewelStoreDbContext myDbContext;

        public DataRepository(JewelStoreDbContext context)
        {
            myDbContext = context;
        }

        public UserMaster AuthorizeUser(string userName, string encryptPass)
        {
            UserMaster user = new UserMaster();
            try
            {
                    user = myDbContext.userMaster.Where(a => a.UserName == userName && a.Password == encryptPass && a.ActiveFlag == Status.Active).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return user;
        }

        public string GetConfig(string key)
        {
            string value = string.Empty;
            ConfigMaster config = new ConfigMaster();
            try
            {
                    config = myDbContext.configMaster.Where(a => a.Key == key).FirstOrDefault();
               
                if (config != null)
                    value = config.Value;
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return value;
        }
    }
}
