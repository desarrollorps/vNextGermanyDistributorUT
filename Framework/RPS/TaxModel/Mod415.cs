    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod415
{
    //RPS VERSION 1.0.0.0
    public partial class Mod415:Screen
    {
        public Mod415():base()
        {
            this.URL = "taxmodel.mod415";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod415View  = new Mod415View(this); 
            Mod415View.InitializeControls(); 
           
        }
      
            public Mod415View Mod415View {get; set; } 
    }
            
    public partial class Mod415View : View
    {
        public Mod415View(Mod415 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod415View>("6b3c9e12-14f6-4798-bca3-125379d4331b","","",true, this);
 
            OpenVoucherNo = RPSControlFactory.CreateRPSFormattedTextBox<Mod415View>("f1674bba-4e41-4a18-9fe7-0ca17dc1269a","","",false, this);
 
            TypeAmount = RPSControlFactory.CreateRPSEnumComboBox<Mod415View>("5f65866e-7ae4-48e4-83ef-4c06a46b8ff0","","",true, this);
 
            MinAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod415View>("a2fcab8c-4bc7-4b28-bada-166f3aec5e80","","",true, this);
 
            SelectionTypes = RPSControlFactory.CreateRPSEnumComboBox<Mod415View>("abcb9473-636c-456f-88bd-c2be9849e41a","","",true, this);
 
            DeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod415View>("6e083045-2470-42aa-8549-819e4c199a7a","","",false, this);
 
            Country = RPSControlFactory.CreateRPSCollectionComboBox<Mod415View>("7df0a367-d811-484d-bd9f-5f1e7ee92b3a","","",false, this);
 
            VoucherTypePurchase = RPSControlFactory.CreateRPSCollectionComboBox<Mod415View>("abf486d4-991b-498b-876d-cd0812bcf945","","",false, this);
 
            VoucherTypeSales = RPSControlFactory.CreateRPSCollectionComboBox<Mod415View>("7179dd79-cd96-4dba-a581-ae19cb701081","","",false, this);
 
            Account = RPSControlFactory.CreateRPSCollectionComboBox<Mod415View>("77eb6cb0-5537-404e-9925-e5a2ce691105","","",false, this);
 
            ExecuteGenerateMod415Button = RPSControlFactory.CreateRPSButton<Mod415View>( "83fba4b4-e29e-4406-8188-8cbf4d601537","","",this);
 

        }
        public IRPSTextBox<Mod415View> Exercise { get; set; } 
        public IRPSTextBox<Mod415View> OpenVoucherNo { get; set; } 
        public IRPSComboBox<Mod415View> TypeAmount { get; set; } 
        public IRPSTextBox<Mod415View> MinAmount { get; set; } 
        public IRPSComboBox<Mod415View> SelectionTypes { get; set; } 
        public IRPSTextBox<Mod415View> DeclarationNumber { get; set; } 
        public IRPSCollectionComboBox<Mod415View> Country { get; set; } 
        public IRPSCollectionComboBox<Mod415View> VoucherTypePurchase { get; set; } 
        public IRPSCollectionComboBox<Mod415View> VoucherTypeSales { get; set; } 
        public IRPSCollectionComboBox<Mod415View> Account { get; set; } 
        public IRPSButton<Mod415View> ExecuteGenerateMod415Button { get; set; } 
        public Mod415 Screen { get; set; }
        public Mod415View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}