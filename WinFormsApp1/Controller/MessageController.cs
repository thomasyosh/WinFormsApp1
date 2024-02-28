using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.View;
using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class MessageController
    {
        public MessageController(IQueryable<User> user) {
            Form2 form2 = new Form2(user);
        }
        
        
    }
}
