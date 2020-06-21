using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TastyAndHealthy.Resources;
using TastyAndHealthy.Views;

namespace TastyAndHealthy
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            LoginWindow wnd = new LoginWindow();
            // Присваиваем имя алгоритму шифрования 
            EncryptionUtility.AlgorithmName = "DES";
            var location = AppDomain.CurrentDomain.BaseDirectory;
            //Для выделения пути к каталогу воспользуемся `System.IO.Path`:
            EncryptionUtility.KeyFile = Path.GetDirectoryName(location) + "/key.config";
            if (!File.Exists(EncryptionUtility.KeyFile))
                EncryptionUtility.GenerateKey();
            wnd.Show();
        }
    }
}
