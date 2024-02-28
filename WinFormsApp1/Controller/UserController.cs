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

        public void AddUser() {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            db.Add(user);
            db.SaveChanges();
        }

        public bool isValidUser(User _user) {
            User user = db.Users.FirstOrDefault(u => u.UserName == _user.UserName);        
            return BCrypt.Net.BCrypt.Verify(_user.Password, user.Password);
        }
    }
}
