using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Common
{
    public interface IHelper
    {
        string Encrypt(string passWord, string EncKey);
    }
}
