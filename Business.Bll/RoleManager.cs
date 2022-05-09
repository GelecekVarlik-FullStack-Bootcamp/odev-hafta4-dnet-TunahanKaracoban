﻿using Business.Entity.Dto;
using Business.Entity.Models;
using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Bll
{
    public class RoleManager:GenericManager<Role,DtoRole>,IRoleService
    {
        public RoleManager(IServiceProvider service):base(service)
        {

        }
    }
}
