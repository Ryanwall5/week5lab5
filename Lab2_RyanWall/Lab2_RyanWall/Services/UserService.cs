
using Lab2_RyanWall.Models;

namespace Lab2_RyanWall.Services
{
    public class UserService : IUserService
    {
        private readonly ICoolRatingService _coolratingservice;
        public static int Coolthreshold = 70;

        public UserService(ICoolRatingService coolratingservice)
        {
            _coolratingservice = coolratingservice;
        }

        public bool UserIsCool(User user)
        {

            var CoolRating = _coolratingservice.GetCoolRating(user);
            return user.FavoriteNBATeam.Equals("Blazers") && CoolRating > Coolthreshold;

        }
    }


}