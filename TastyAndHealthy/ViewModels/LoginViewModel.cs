using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TastyAndHealthy.Commands;
using TastyAndHealthy.Models;
using TastyAndHealthy.Resources;
using TastyAndHealthy.Views;

namespace TastyAndHealthy.ViewModels
{
    class LoginViewModel : DependencyObject
    {
        public string UserLogin
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }

        public static readonly DependencyProperty LoginProperty =
            DependencyProperty.Register("Login", typeof(string), typeof(LoginViewModel), new PropertyMetadata(""));

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(LoginViewModel), new PropertyMetadata(""));

        #region Commands
        private Command loginCommand;
        public Command LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new Command(Login, CanLogin));
            }
        }

        private void Login(object obj)
        {
            try
            {
                using (TastyAndHealthyContext context = new TastyAndHealthyContext())
            {
                User user = context.Users.Where(x => (x.Email == UserLogin || x.Login == UserLogin)).FirstOrDefault();
                    if (user != null)
                    {
                        if (EncryptionUtility.DecryptDate(user.Password) == Password)
                        {
                            MainWindow mainWindow = new MainWindow(user);
                            mainWindow.Show();
                            foreach (Window el in Application.Current.Windows)
                            {
                                if (el.ToString().Contains("Login"))
                                {
                                    el.Close();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!");
                    }
            }
            }
            catch (Exception) { MessageBox.Show("Error connection to database!"); }
        }

        private bool CanLogin(object obj)
        {
            if (string.IsNullOrEmpty(UserLogin) || Password.Length < 6)
                return false;
            else
                return true;
        }

        private Command registrationCommand;
        public Command RegistrationCommand
        {
            get
            {
                return registrationCommand ?? (registrationCommand = new Command(Registration, CanRegistration));
            }
        }

        private void Registration(object obj)
        {
            RegistrationWindow autorizationWindow = new RegistrationWindow();
            autorizationWindow.Show();
            foreach (Window el in Application.Current.Windows)
            {
                if (el.ToString().Contains("Login"))
                {
                    el.Close();
                    break;
                }
            }
        }

        private bool CanRegistration(object obj)
        {
            return true;
        }

        private Command aboutCommand;
        public Command AboutCommand
        {
            get
            {
                return aboutCommand ?? (aboutCommand = new Command(About, CanAbout));
            }
        }

        private void About(object obj)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
            foreach (Window el in Application.Current.Windows)
            {
                if (el.ToString().Contains("Login"))
                {
                    el.Close();
                    break;
                }
            }
        }

        private bool CanAbout(object obj)
        {
            return true;
        }

        private Command passwordChangedCommand;
        public Command PasswordChangedCommand
        {
            get
            {
                return passwordChangedCommand ?? (passwordChangedCommand = new Command(PasswordChanged, CanPasswordChanged));
            }
        }

        private void PasswordChanged(object obj)
        {
            if (obj != null)
                Password = (obj as PasswordBox).Password;
        }

        private bool CanPasswordChanged(object obj)
        {
            return true;
        }
        #endregion
    }
}
