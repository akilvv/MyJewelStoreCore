using MyJewelStoreCore.Context.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Context.Config
{
    [Table("ConfigMaster")]
    public class ConfigMaster
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Status ActiveFlag { get; set; } = Status.Active;
    }
}
