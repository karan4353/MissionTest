﻿using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IUser
    {
        //RegisterUser
        Task<object> RegisterUser([FromBody] AddUpdateRegisterUserBindingModel model);
        //GetAllUser
        Task<object> GetAllUsers();
        //Login
        Task<object> Login([FromBody] loginBindingModel model);
        //AddRole
        Task<Object> AddRole([FromBody] AddRoleBindingModel model);
        //GetRoles
        Task<object> GetRoles();
        //GenerateToken
        //string GenerateToken(AppUser user, string role);
    }
}
