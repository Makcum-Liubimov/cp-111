using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_1
{
    public partial class LoginForm : Form
    {
        public static string UserType { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Перевірка логіну і паролю (можна змінити на ваші умови)
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "password")
            {
                // Визначення типу користувача
                if (passengerRadioButton.Checked)
                {
                    UserType = "Пасажир";
                }
                else if (driverRadioButton.Checked)
                {
                    UserType = "Машиніст";
                }
                else
                {
                    MessageBox.Show("Виберіть тип користувача.");
                    return;
                }

                // Якщо логін успішний, відкриваємо головну форму
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide(); // Приховуємо форму логіну
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль.");
            }
        }
    }
}
