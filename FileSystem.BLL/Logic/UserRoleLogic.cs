using FileSystem.DAL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.BLL
{
   public class UserRoleLogic: BaseLogic<UserRoleService>
    {
        public bool  AddUsrRole(UserRole ur)
        {
            return Service.AddRoleUser(ur);

        }
        public bool DeleteRoleUser(UserRole ur)
        {
            return Service.DeleteRoleUser(ur.RoleID ,ur.UserID );
        }
    }
}
