using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.BusinessServices
{
    public interface IAuthService
    {
        Dictionary<string, string> AuthorizeUser(string userName, string password);
    }
}
