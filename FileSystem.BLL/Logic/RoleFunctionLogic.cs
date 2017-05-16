﻿using FileSystem.DAL.Implement;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.BLL
{
   public class RoleFunctionLogic: BaseLogic<RoleFunctionService>
    {
        public bool AddRoleFunction(Role_Function rf) {
            return Service.AddRoleFunction(rf);
        }
    }
}
