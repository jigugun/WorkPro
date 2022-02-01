using Microsoft.Extensions.Configuration;
using Microsoft.UI.Xaml;
using Playground.Classes;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Playground
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            //load json settings
            LoadJsonSettings();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            //set default language
            SelectCulture("zh-CN");

            //stating first window
            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;

        //select language culture
        private static void SelectCulture(string culture)
        {
            if (string.IsNullOrEmpty(culture))
            {
                return;
            }

            //get all dictionaries into a list
            var dictionaryList = Application.Current.Resources.MergedDictionaries.ToList();

            //search for specified culture
            string requestedCulture = string.Format("{0}.xaml", culture);
            var resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Contains(requestedCulture));
            if (resourceDictionary == null)
            {
                //if not found, then select default language
                culture = "en-US";
                requestedCulture = $"{culture}.xaml";
                resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Contains(requestedCulture));
            }

            //if we have the requested resource, remove it from the list and place at the end
            //then this language will be our string table to use
            if (resourceDictionary != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
            }

            //inform the threads of the new culture
            var cultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        private void LoadJsonSettings()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var appSettings = config.GetSection(nameof(AppSettings)).Get<AppSettings>();


            Console.WriteLine(config.GetSection("settings"));
        }
    }
}


