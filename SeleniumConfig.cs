using RPSSeleniumProperties;
using System;
using System.IO;
using System.Net.Http;
using Xunit;

namespace vNextGermanyDistributorUT
{
    [Collection("BaseTest")]
    public class BaseTest : IDisposable
    {
        public void Dispose()
        {
           
        }
    }
    public sealed class SeleniumConfig
    {
        public static SeleniumConfig Current = new SeleniumConfig();        
        public string rpsurl = "https://rpsnextsp1distributor.westeurope.cloudapp.azure.com/rpsnextservice/";
        //public string rpsurl = "http://localhost/rpsnextserviceut/";
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
                RPSEnvironment.Visible = true;
            }
            else
            {
                RPSEnvironment.Visible = false;
            }
            /*Launch a query to start environment*/
            RPSHealthCheck();
        }
        ~SeleniumConfig()
        {
            Dispose();
        }
        public void RPSHealthCheck()
        {
            
            using (var client = new HttpClient())
            {
                var webRequest = new HttpRequestMessage(HttpMethod.Get, rpsurl + "status");
                client.Timeout = new TimeSpan(0, 5, 0);

                var response = client.Send(webRequest);
                if (response.IsSuccessStatusCode)
                {
                    using (var reader = new StreamReader(response.Content.ReadAsStream()))
                    {
                        string text = reader.ReadToEnd();
                        if (!text.Contains("\"IsRunning\":true"))
                        {
                            throw new Exception($"Sorry, RPS at {rpsurl} does not have the expected status:{text}");
                        }
                    }

                }
                else
                {

                    throw new Exception($"Sorry, RPS at {rpsurl} is not ready statuscode:{response.StatusCode}");
                }
            }

            
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

            // Run at end
        }
    }
}