    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod111
{
    //RPS VERSION 1.0.0.0
    public partial class Mod111:Screen
    {
        public Mod111():base()
        {
            this.URL = "taxmodel.mod111";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod111View  = new Mod111View(this); 
            Mod111View.InitializeControls(); 
           
        }
      
            public Mod111View Mod111View {get; set; } 
    }
            
    public partial class Mod111View : View
    {
        public Mod111View(Mod111 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("2fe3f762-5990-4971-8581-a1ee40aa8ac0","","",true, this);
 
            OptionMonthQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("19cf2feb-0766-4e22-bc18-f4ad0a14f3e6","","",true, this);
 
            OptionQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("40e4f927-286b-4c1c-b972-571a46b2c6d4","","",false, this);
 
            OptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("f50e4ef4-666d-4c55-9db2-0ed945b42240","","",false, this);
 
            OptionEjercicio = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("ffbfe942-7c55-4403-90f7-a2d905149f81","","",true, this);
 
            ExecuteGetMod111Data = RPSControlFactory.CreateRPSButton<Mod111View>( "108eaa39-1e16-4ab6-b6db-43d4a1f9ab74","","",this);
 
            DeclarationType = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("c3ad36fc-beda-45d4-a67b-6949c407aa46","","",true, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod111View>("f1307756-62b4-4bff-aae0-ad8ca03e3861","","",false, this);
 
            PreviousAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("54125a7f-cac1-4fb3-8006-8986efe516f1","","",false, this);
 
            OptionResultType = RPSControlFactory.CreateRPSEnumComboBox<Mod111View>("7b72fb68-9c29-47d0-8e1e-05e75d1437e6","","",true, this);
 
            BankAccountCompany = RPSControlFactory.CreateRPSComboBox<Mod111View>("a5246d15-3593-4aa8-af26-1e13be7d5473","","",false, this);
 
            Count_I = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("003642ed-2db1-4032-a755-389bf1b58a2f","","",false, this);
 
            Count_II = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("339cad6b-2d40-4b9f-beec-4573de6e0d26","","",false, this);
 
            Count_III = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("a3cff7d8-a0e1-4a71-8cbc-3da250bfeaa4","","",false, this);
 
            Count_IV = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("cccce5e9-fa2b-47cc-82eb-a3d937e71b29","","",false, this);
 
            Count_V = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("a5889e92-745a-4d95-b58f-e755fed2bda4","","",false, this);
 
            ResultAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod111View>("e0809d4e-14fe-4aa3-96b2-46aee84ab2ec","","",false, this);
 
            ExecuteGenerateMod111Button = RPSControlFactory.CreateRPSButton<Mod111View>( "0274cf0c-ba8a-48e1-be49-eccf01f1395a","","",this);
 

        }
        public IRPSTextBox<Mod111View> Year { get; set; } 
        public IRPSComboBox<Mod111View> OptionMonthQuarter { get; set; } 
        public IRPSComboBox<Mod111View> OptionQuarter { get; set; } 
        public IRPSComboBox<Mod111View> OptionMes { get; set; } 
        public IRPSComboBox<Mod111View> OptionEjercicio { get; set; } 
        public IRPSButton<Mod111View> ExecuteGetMod111Data { get; set; } 
        public IRPSComboBox<Mod111View> DeclarationType { get; set; } 
        public IRPSTextBox<Mod111View> NumJustificanteAnterior { get; set; } 
        public IRPSTextBox<Mod111View> PreviousAmount { get; set; } 
        public IRPSComboBox<Mod111View> OptionResultType { get; set; } 
        public IRPSComboBox<Mod111View> BankAccountCompany { get; set; } 
        public IRPSTextBox<Mod111View> Count_I { get; set; } 
        public IRPSTextBox<Mod111View> Count_II { get; set; } 
        public IRPSTextBox<Mod111View> Count_III { get; set; } 
        public IRPSTextBox<Mod111View> Count_IV { get; set; } 
        public IRPSTextBox<Mod111View> Count_V { get; set; } 
        public IRPSTextBox<Mod111View> ResultAmount { get; set; } 
        public IRPSButton<Mod111View> ExecuteGenerateMod111Button { get; set; } 
        public Mod111 Screen { get; set; }
        public Mod111View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}