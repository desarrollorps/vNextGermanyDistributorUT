    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.ConfigurationSII
{
    //RPS VERSION 1.0.0.0
    public partial class ConfigurationSII:Screen
    {
        public ConfigurationSII():base()
        {
            this.URL = "taxmodel.configurationsii";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConfigurationSIIView  = new ConfigurationSIIView(this); 
            ConfigurationSIIView.InitializeControls(); 
           
        }
      
            public ConfigurationSIIView ConfigurationSIIView {get; set; } 
    }
            
    public partial class ConfigurationSIIView : View
    {
        public ConfigurationSIIView(ConfigurationSII screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UserServerCertificate = RPSControlFactory.CreateRPSCheckBox<ConfigurationSIIView>("06ad0d8e-7fe4-4079-9f9d-49c6a4b75c30","","",false, this);
 
            eRunMode = RPSControlFactory.CreateRPSEnumComboBox<ConfigurationSIIView>("eca5a5d2-99bd-41a5-a90e-6ea0e1cc8d54","","",false, this);
 
            eTaxZone = RPSControlFactory.CreateRPSEnumComboBox<ConfigurationSIIView>("02c474ec-bed2-4075-9f2b-28e07eb2d949","","",false, this);
 
            eVersion = RPSControlFactory.CreateRPSEnumComboBox<ConfigurationSIIView>("93b0a03b-3014-48f7-b719-46c570673c9a","","",false, this);
 
            ExecuteCheckWebServices = RPSControlFactory.CreateRPSButton<ConfigurationSIIView>( "3068c881-5b4c-486e-a082-96f4a80fffd3","","",this);
 
            ResetEnvios = RPSControlFactory.CreateRPSButton<ConfigurationSIIView>( "d8312435-772c-4ee7-8df2-bda328332010","","",this);
 
            UseVoucherDate = RPSControlFactory.CreateRPSOption<ConfigurationSIIView>( "53f4e883-5912-4987-b9dd-542353be7890","","",this);
 
            UseTodayDate = RPSControlFactory.CreateRPSOption<ConfigurationSIIView>( "a49349a9-1c90-4a96-bb85-59076b203553","","",this);
 
            ePeriodType = RPSControlFactory.CreateRPSEnumComboBox<ConfigurationSIIView>("985c9106-18d0-4370-b421-1fe58f36ca70","","",false, this);
 
            ShowAtGL = RPSControlFactory.CreateRPSCheckBox<ConfigurationSIIView>("9323248f-0f1b-4c95-8bdf-15cecb318d5b","","",false, this);
 
            AllowModifyVoucher = RPSControlFactory.CreateRPSCheckBox<ConfigurationSIIView>("3ed50832-85e1-4593-8467-5a26f88f753b","","",false, this);
 
            UseForVATModels = RPSControlFactory.CreateRPSCheckBox<ConfigurationSIIView>("43522177-1c71-4bd8-abac-1e666c8ccf0d","","",false, this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<ConfigurationSIIView>( "7b0c5e37-f655-4e62-8f9a-a89baf62923e","","",this);
 

        }
        public IRPSCheckbox<ConfigurationSIIView> UserServerCertificate { get; set; } 
        public IRPSComboBox<ConfigurationSIIView> eRunMode { get; set; } 
        public IRPSComboBox<ConfigurationSIIView> eTaxZone { get; set; } 
        public IRPSComboBox<ConfigurationSIIView> eVersion { get; set; } 
        public IRPSButton<ConfigurationSIIView> ExecuteCheckWebServices { get; set; } 
        public IRPSButton<ConfigurationSIIView> ResetEnvios { get; set; } 
        public IRPSOption<ConfigurationSIIView> UseVoucherDate { get; set; } 
        public IRPSOption<ConfigurationSIIView> UseTodayDate { get; set; } 
        public IRPSComboBox<ConfigurationSIIView> ePeriodType { get; set; } 
        public IRPSCheckbox<ConfigurationSIIView> ShowAtGL { get; set; } 
        public IRPSCheckbox<ConfigurationSIIView> AllowModifyVoucher { get; set; } 
        public IRPSCheckbox<ConfigurationSIIView> UseForVATModels { get; set; } 
        public IRPSButton<ConfigurationSIIView> SaveCommandButton { get; set; } 
        public ConfigurationSII Screen { get; set; }
        public ConfigurationSIIView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}