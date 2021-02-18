using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyJewelStoreCore.Context.Config;
using MyJewelStoreCore.Context.Enum;
using MyJewelStoreCore.Context.Master;

namespace MyJewelStoreCore.Context
{
    public class JewelStoreDbContext: DbContext
    {
        public JewelStoreDbContext(DbContextOptions<JewelStoreDbContext> options) : base(options)
        {
        }

        public DbSet<UserMaster> userMaster { get; set; }
        public DbSet<ConfigMaster> configMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaster>().HasData(
                new UserMaster()
                {
                    Id = 1,
                    FirstName = "Test1",
                    LastName = "User1",
                    UserName = "Test1.User1",
                    Password = "167d99fdbdd3b221908cc963a306a762",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    UserType = UserType.normalUser,
                    ActiveFlag = Status.Active
                },
                new UserMaster()
                {
                    Id = 2,
                    FirstName = "Test2",
                    LastName = "User2",
                    UserName = "Test2.User2",
                    Password = "167d99fdbdd3b221908cc963a306a762",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    UserType = UserType.privilaged,
                    ActiveFlag = Status.Active
                });

            modelBuilder.Entity<ConfigMaster>().HasData(
             new ConfigMaster()
             {
                 Id = 1,
                 Key = "JewelStore.Discount",
                 Value = "10",
                 CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                 ActiveFlag = Status.Active
             },
             new ConfigMaster()
             {
                 Id = 2,
                 Key = "JewelStore.EncryptKey",
                 Value = "abcde",
                 CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                 ActiveFlag = Status.Active
             }); ;



        }
    }
}
