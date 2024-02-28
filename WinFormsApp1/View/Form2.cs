using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1.View
{
    public partial class Form2 : Form
    {
        public Form2(IQueryable<User> user)
        {
            InitializeComponent();
            this.Show();
            foreach (var item in user) {
                comboBox1.Items.Add(item.UserName);
            }
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
