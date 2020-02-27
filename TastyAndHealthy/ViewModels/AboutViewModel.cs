using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TastyAndHealthy.Commands;
using TastyAndHealthy.Views;

namespace TastyAndHealthy.ViewModels
{
    class AboutViewModel
    {
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
            LoginWindow aboutWindow = new LoginWindow();
            aboutWindow.Show();
            foreach (Window el in Application.Current.Windows)
            {
                if (el.ToString().Contains("About"))
                {
                    el.Close();
                    break;
                }
            }
        }

        private bool CanLogin(object obj)
        {
            return true;
        }

        private Command exitCommand;
        public Command ExitCommand
        {
            get
            {
                return exitCommand ?? (exitCommand = new Command(Exit, CanExit));
            }
        }

        private void Exit(object obj)
        {
            foreach (Window el in Application.Current.Windows)
            {
                if (el.ToString().Contains("About"))
                {
                    el.Close();
                    break;
                }
            }
        }

        private bool CanExit(object obj)
        {
            return true;
        }
    }
}
