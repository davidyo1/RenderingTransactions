using System.Web.Configuration;

namespace BusinessLogic
{
    public class Variables
    {
        public enum ActionValues
        {
            payment, credit
        }
        public enum CurrencyCodeValues
        {
            EUR, JPY, USD
        }

        #region WebConfigKeys
        public static string UserNameAuth
        {
            get
            {
                return WebConfigurationManager.AppSettings["UserNameAuth"];
            }
        }
        public static string PasswordAuth
        {
            get
            {
                return WebConfigurationManager.AppSettings["PasswordAuth"];
            }
        }
        public static string EndpointAuth
        {
            get
            {
                return WebConfigurationManager.AppSettings["EndpointAuth"];
            }
        }
        #endregion
    }
}
