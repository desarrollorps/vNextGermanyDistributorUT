using RPSSeleniumProperties;
using System;
namespace vNextGermanyDistributorUT
{
    public sealed class SeleniumConfig
    {
        public static SeleniumConfig Current = new SeleniumConfig();        
        public string rpsurl = "https://rpsnextsp1distributor.westeurope.cloudapp.azure.com/rpsnextservice/";
        public string user = "admin";
        public string password = "admin";
        public string company = "LIPR";
        
        public SeleniumConfig()
        {            
            RPSEnvironment.RPSBaseURL = rpsurl;
            RPSEnvironment.DefaultUser = user;
            RPSEnvironment.DefaultPassword = password;
            RPSEnvironment.DefaultCodCompany = company;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                RPSEnvironment.Visible = false;
            }
            else
            {
                RPSEnvironment.Visible = false;
            }
        }
        ~SeleniumConfig()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);

            // Run at end
        }
    }
}