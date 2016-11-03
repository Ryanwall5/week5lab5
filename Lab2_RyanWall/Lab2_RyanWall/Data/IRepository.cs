﻿using Lab2_RyanWall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_RyanWall.Data
{
    public interface IRepository
    {
        List<User> GetAllUsers();
        void AddUser(User user);
        User GetUser(int id);
        void UpdateUser(User id);
        void RemoveUser(User id);
        List<Pet> GetAllPets();

    }
}