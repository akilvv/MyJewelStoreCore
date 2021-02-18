using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Constants
{
    public class ConfigConstants
    {
        //ConfigTable
        public const string Config_AuthKey = "JewelStore.EncryptKey";
        public const string Config_Discount = "JewelStore.Discount";

        //AuthService Dictionary variables
        public const string Auth_Status = "Status";
        public const string Auth_UserType  = "UserType";

        //ConnnectionString
        public const string Conn_String = "accessModelContext";
    }
}
