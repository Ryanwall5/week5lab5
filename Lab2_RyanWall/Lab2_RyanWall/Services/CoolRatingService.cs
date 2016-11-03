using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2_RyanWall.Models;

namespace Lab2_RyanWall.Services
{
    public class CoolRatingService : ICoolRatingService
    {
        //private readonly char[] teamname = new[] { 'b', 'l', 'a', 'z', 'e', 'r', 's'};
        public int GetCoolRating(User user)
        {
            int rating = 0;

            if (user.FavoriteNBATeam == "blazers" || user.FavoriteNBATeam == "Blazers")
                rating = 100;

            else if (user.FavoriteNBATeam == "Warriors" || user.FavoriteNBATeam == "warriors")
                rating = 0;

            else
                rating = 50;

            return rating;
        }
    }
}