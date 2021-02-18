using MyJewelStoreCore.Common;
using MyJewelStoreCore.Constants;
using MyJewelStoreCore.Context.Enum;
using MyJewelStoreCore.Context.Master;
using MyJewelStoreCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.BusinessServices
{
    public class AuthService: IAuthService
    {
        private IDataRepository _service;
        private IHelper _helper;
        public AuthService(IDataRepository service, IHelper helper)
        {
            this._service = service;
            this._helper = helper;
        }

        public Dictionary<string, string> AuthorizeUser(string userName, string password)
        {
            string authKey = _service.GetConfig(ConfigConstants.Config_AuthKey);
            Dictionary<string, string> retDict = BuildAuthData(Boolean.FalseString, UserType.invalid.ToString());
            try
            {
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                {
                    UserMaster user = _service.AuthorizeUser(userName, _helper.Encrypt(password, authKey));

                    if (user != null)
                    {
                        retDict = BuildAuthData(Boolean.TrueString, user.UserType.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return retDict;
        }

        private Dictionary<string, string> BuildAuthData(string status, string userType)
        {
            Dictionary<string, string> retDict = new Dictionary<string, string>();
            retDict.Add(ConfigConstants.Auth_Status, status);
            retDict.Add(ConfigConstants.Auth_UserType, userType);
            return retDict;
        }
    }
}
