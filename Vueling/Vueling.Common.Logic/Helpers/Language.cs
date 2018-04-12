using System;
using System.Globalization;
using System.Threading;

namespace Vueling.Common.Logic.Helpers
{
    public static class Language
    {
        public static string AppLanguage { get; set; }

        public static void InitializeLanguage()
        {            
            string idioma = Environment.GetEnvironmentVariable("Language", EnvironmentVariableTarget.User);
            
            if (String.IsNullOrEmpty(idioma))
            {
                AppLanguage = "es-ES";
                Environment.SetEnvironmentVariable("Language", "es-ES", EnvironmentVariableTarget.User);
                ChangeLanguage("es-ES");
            }
            else
            {
                AppLanguage = idioma;
                ChangeLanguage(idioma);                
            }            
        }
        public static void ChangeLanguage(string idioma)
        {
            Environment.SetEnvironmentVariable("Language", idioma, EnvironmentVariableTarget.User);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(idioma);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(idioma);
        }
    }
}
