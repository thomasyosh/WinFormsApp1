using WinFormsApp1.Controller;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text,textBox2.Text);
            UserController userController = new UserController(user);
            //MessageBox.Show(userController.AddUser());
            bool result = userController.isValidUser(user);
            MessageBox.Show(result.ToString());
        }
    }
}
