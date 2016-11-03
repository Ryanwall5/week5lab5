using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2_RyanWall.Models;

namespace Lab2_RyanWall.Services
{
    public interface ICoolRatingService
    {
        int GetCoolRating(User user);
    }
}