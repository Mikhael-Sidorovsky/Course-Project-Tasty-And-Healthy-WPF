using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using TastyAndHealthy.Commands;
using TastyAndHealthy.Models;
using TastyAndHealthy.Resources;
using TastyAndHealthy.Views;

namespace TastyAndHealthy.ViewModels
{
    class RegistrationViewModel : DependencyObject, IDataErrorInfo
    {
        #region Properties
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(RegistrationViewModel), new PropertyMetadata(""));

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(RegistrationViewModel), new PropertyMetadata(""));

        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(RegistrationViewModel), new PropertyMetadata(0));

        public int Height
        {
            get { return (int)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(int), typeof(RegistrationViewModel), new PropertyMetadata(0));

        public double CurrentWeight
        {
            get { return (double)GetValue(CurrentWeightProperty); }
            set { SetValue(CurrentWeightProperty, value); }
        }

        public static readonly DependencyProperty CurrentWeightProperty =
            DependencyProperty.Register("CurrentWeight", typeof(double), typeof(RegistrationViewModel), new PropertyMetadata(0.0));

        public double TargetWeight
        {
            get { return (double)GetValue(TargetWeightProperty); }
            set { SetValue(TargetWeightProperty, value); }
        }

        public static readonly DependencyProperty TargetWeightProperty =
            DependencyProperty.Register("TaegetWeight", typeof(double), typeof(RegistrationViewModel), new PropertyMetadata(0.0));

        public string BloodType
        {
            get { return (string)GetValue(BloodTypeProperty); }
            set { SetValue(BloodTypeProperty, value); }
        }

        public static readonly DependencyProperty BloodTypeProperty =
            DependencyProperty.Register("BloodType", typeof(string), typeof(RegistrationViewModel), new PropertyMetadata(""));

        public string Sex
        {
            get { return (string)GetValue(SexProperty); }
            set { SetValue(SexProperty, value); }
        }

        public static readonly DependencyProperty SexProperty =
            DependencyProperty.Register("Sex", typeof(string), typeof(RegistrationViewModel), new PropertyMetadata(""));

        private string Password;

        private string ConfirmPassword;
        #endregion

        #region Commands

        private Command cancelCommand;
        public Command CancelCommand
        {
            get
            {
                return cancelCommand ?? (cancelCommand = new Command(Cancel, CanCancel));
            }
        }

        private void Cancel(object obj)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            foreach (Window el in Application.Current.Windows)
            {
                if (el.ToString().Contains("Registration"))
                {
                    el.Close();
                    break;
                }
            }
        }

        private bool CanCancel(object obj)
        {
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
            if (Password == ConfirmPassword)
            {
                using (TastyAndHealthyContext context = new TastyAndHealthyContext())
                {
                    if (!context.Users.Where(x => (x.Email == Email || x.Email == Name || x.Login == Email || x.Login == Name)).Any())
                    {
                        User user = new User();
                        user.Login = Name;
                        user.Email = Email;
                        user.Password = EncryptionUtility.EncryptData(Password);
                        user.Age = Age;
                        user.Height = Height;
                        user.CurrentWeight = CurrentWeight;
                        user.TargetWeight = TargetWeight;
                        user.BloodType = context.BloodTypes
                            .Where(x => x.Name == BloodType).FirstOrDefault();
                        user.Sex = Sex;
                        context.Users.Add(user);
                        context.SaveChanges();
                        MainWindow mainWindow = new MainWindow(user);
                        mainWindow.Show();
                        foreach (Window el in Application.Current.Windows)
                        {
                            if (el.ToString().Contains("Registration"))
                            {
                                el.Close();
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (context.Users.Where(x => x.Email == Email).Any())
                            MessageBox.Show("User with this email already exists!!!");
                        else
                            MessageBox.Show("User with this login already exists!!!");
                    }
                }
            }
            else
                MessageBox.Show("Password confirmation does not match password");
        }

        private bool CanRegistration(object obj)
        {
            if (!IsValidEmail || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Name)
                || Password.Length < 6 || ConfirmPassword != Password
                || (Age < 12 && Age > 100) || Height < 0 || CurrentWeight < 0
                || TargetWeight < 0 || BloodType == "" || Sex == "")
                return false;
            else
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

        private Command confirmPasswordChangedCommand;
        public Command ConfirmPasswordChangedCommand
        {
            get
            {
                return confirmPasswordChangedCommand ?? (confirmPasswordChangedCommand = new Command(ConfirmPasswordChanged, CanConfirmPasswordChanged));
            }
        }

        private void ConfirmPasswordChanged(object obj)
        {
            if (obj != null)
                ConfirmPassword = (obj as PasswordBox).Password;
        }

        private bool CanConfirmPasswordChanged(object obj)
        {
            return true;
        }

        #endregion

        #region Implementation IDataErrorInfo
        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":
                        if (Age < 12)
                        {
                            error = "Incorrect input (Age > 12)";
                        }
                        break;
                    case "Height":
                        if (Height < 100)
                        {
                            error = "Incorrect input (Height >= 100)";
                        }
                        break;
                    case "CurrentWeight":
                        if (CurrentWeight < 20.0)
                        {
                            error = "Incorrect input (Current weight >= 20)";
                        }
                        break;
                    case "TargetWeight":
                        if (TargetWeight < 12.0)
                        {
                            error = "Incorrect input (Target weight >= 12)";
                        }
                        break;
                    case "Email":
                        if (string.IsNullOrEmpty(Email))
                        {
                            error = "Email является обязательным полем!";
                        }
                        else if (!IsValidEmail)
                        {
                            error = "Некорректный ввод Email!";
                        }
                        break;
                }
                return error;
            }
        }

        private Regex emailReg;

        public bool IsValidEmail
        {
            get { return emailReg.IsMatch(Email); }
        }
        #endregion

        public RegistrationViewModel()
        {
            emailReg = new Regex(@"^([\w\.\-]+)@([a-z\-]+)((\.([a-z]){2,3})+)$");
            Password = "";
            ConfirmPassword = "";
        }
    }
}
