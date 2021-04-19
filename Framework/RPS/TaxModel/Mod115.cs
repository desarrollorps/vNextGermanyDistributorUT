    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod115
{
    //RPS VERSION 1.0.0.0
    public partial class Mod115:Screen
    {
        public Mod115():base()
        {
            this.URL = "taxmodel.mod115";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod115View  = new Mod115View(this); 
            Mod115View.InitializeControls(); 
           
        }
      
            public Mod115View Mod115View {get; set; } 
    }
            
    public partial class Mod115View : View
    {
        public Mod115View(Mod115 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<Mod115View>("2fe3f762-5990-4971-8581-a1ee40aa8ac0","","",true, this);
 
            OptionMonthQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("f3ea5574-a301-47a0-8f6a-cda8a7e23e4d","","",true, this);
 
            OptionQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("40e4f927-286b-4c1c-b972-571a46b2c6d4","","",false, this);
 
            OptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("f50e4ef4-666d-4c55-9db2-0ed945b42240","","",false, this);
 
            OptionEjercicio = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("ffbfe942-7c55-4403-90f7-a2d905149f81","","",true, this);
 
            ExecuteGetMod115Data = RPSControlFactory.CreateRPSButton<Mod115View>( "f26f5502-6398-473b-acab-3f67e6b8f117","","",this);
 
            OptionDeclarationType = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("59dc4922-6edc-4640-a29b-cd92d1af9e51","","",true, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod115View>("f1307756-62b4-4bff-aae0-ad8ca03e3861","","",false, this);
 
            PreviousAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod115View>("2949f79d-8553-42e4-88ac-a1bb094d3603","","",false, this);
 
            OptionResultType = RPSControlFactory.CreateRPSEnumComboBox<Mod115View>("7b72fb68-9c29-47d0-8e1e-05e75d1437e6","","",true, this);
 
            BankAccountCompany = RPSControlFactory.CreateRPSComboBox<Mod115View>("a5246d15-3593-4aa8-af26-1e13be7d5473","","",false, this);
 
            TotalCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod115View>("f033c2e0-2f0f-4215-9747-f1e600b6b9dd","","",false, this);
 
            ResultAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod115View>("8334f135-9a5c-4936-a2b6-f931769e01e4","","",false, this);
 
            ExecuteGenerateMod115Button = RPSControlFactory.CreateRPSButton<Mod115View>( "8e59310b-9544-491e-8e8e-c5d09d2569b8","","",this);
 

        }
        public IRPSTextBox<Mod115View> Year { get; set; } 
        public IRPSComboBox<Mod115View> OptionMonthQuarter { get; set; } 
        public IRPSComboBox<Mod115View> OptionQuarter { get; set; } 
        public IRPSComboBox<Mod115View> OptionMes { get; set; } 
        public IRPSComboBox<Mod115View> OptionEjercicio { get; set; } 
        public IRPSButton<Mod115View> ExecuteGetMod115Data { get; set; } 
        public IRPSComboBox<Mod115View> OptionDeclarationType { get; set; } 
        public IRPSTextBox<Mod115View> NumJustificanteAnterior { get; set; } 
        public IRPSTextBox<Mod115View> PreviousAmount { get; set; } 
        public IRPSComboBox<Mod115View> OptionResultType { get; set; } 
        public IRPSComboBox<Mod115View> BankAccountCompany { get; set; } 
        public IRPSTextBox<Mod115View> TotalCount { get; set; } 
        public IRPSTextBox<Mod115View> ResultAmount { get; set; } 
        public IRPSButton<Mod115View> ExecuteGenerateMod115Button { get; set; } 
        public Mod115 Screen { get; set; }
        public Mod115View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}