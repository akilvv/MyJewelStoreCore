using MyJewelStoreCore.Context.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Context.Master
{
    [Table("UserMaster")]
    public class UserMaster
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserType UserType { get; set; } = UserType.normalUser;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Status ActiveFlag { get; set; } = Status.Active;
    }
}
