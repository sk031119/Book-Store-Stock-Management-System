using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class UsersDB
    {
        public static List<User> GetUsers()
        {
            using (var context = new CsdbContext())
            {
                return context.Users.OrderBy(u => u.Username).ToList();
            }
        }

        public static void AddUser(User user)
        {
            using (var context = new CsdbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static void UpdateUser(User updatedUser)
        {
            using (var context = new CsdbContext())
            {
                var existing = context.Users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
                if (existing != null)
                {
                    existing.Username = updatedUser.Username;
                    existing.Role = updatedUser.Role;
                    context.SaveChanges();
                }
            }
        }

        public static void ChangePassword(int userId, string newPassword)
        {
            using (var context = new CsdbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    user.Password = newPassword;
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            using (var context = new CsdbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        public static bool UsernameExists(string username, int? ignoreUserId = null)
        {
            using (var context = new CsdbContext())
            {
                return context.Users.Any(u =>
                    u.Username.ToLower() == username.ToLower() &&
                    (!ignoreUserId.HasValue || u.UserId != ignoreUserId.Value));
            }
        }
    }
}
