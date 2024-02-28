using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class UserController
    {
        User user;
        AppDbContext db = new AppDbContext();

        public UserController(User _user) {
            this.user = _user;
        }

        public string AddUser() {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            User temp = db.Users.FirstOrDefault(x => x.UserName == user.UserName);
            if (temp == null)
            {
                db.Add(user);
                db.SaveChanges();
                return "user create successfully";
            }
            else
                return "duplicate use found";
            
        }

        public bool isValidUser(User _user) {
            User user = db.Users.FirstOrDefault(u => u.UserName == _user.UserName);
            if (user != null)
                return BCrypt.Net.BCrypt.Verify(_user.Password, user.Password);
            else
                return false;
        }
    }
}
