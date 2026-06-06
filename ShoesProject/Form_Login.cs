using ShoesProject.Models;
using System.Data;

namespace ShoesProject
{
    public partial class Form_Login : Form
    {
        // 1. Свойства сделаны статическими (static), чтобы к ним можно было обращаться через Form_Login.CurrentUser
        public static User CurrentUser { get; private set; }
        public static bool IsGuest { get; private set; }

        // 2. Статический метод, чтобы работал вызов Form_Login.ShowDialog()
        public static new DialogResult ShowDialog()
        {
            using (var instance = new Form_Login())
            {
                return instance.ShowDialogBase();
            }
        }

        // Вспомогательный метод для обхода бесконечной рекурсии
        private DialogResult ShowDialogBase()
        {
            return base.ShowDialog();
        }

        public Form_Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pblogo_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DbShop2Context())
            {
                var user = db.Users.Where(w => w.Login == txtLogin.Text && w.Pass == txtPassword.Text).FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
