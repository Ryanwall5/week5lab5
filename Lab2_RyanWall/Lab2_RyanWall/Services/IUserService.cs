using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2_RyanWall.Models;

namespace Lab2_RyanWall
{
    public interface IUserService
    {
       bool UserIsCool(User user);
    }
}