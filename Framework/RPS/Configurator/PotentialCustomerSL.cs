    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.PotentialCustomerSL
{
    //RPS VERSION 1.0.0.0
    public partial class PotentialCustomerSL:Screen
    {
        public PotentialCustomerSL():base()
        {
            this.URL = "configurator.potentialcustomersl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PotentialCustomerSLCollectionView  = new PotentialCustomerSLCollectionView(this); 
            PotentialCustomerSLEntityView  = new PotentialCustomerSLEntityView(this); 
            PotentialCustomerSLCollectionView.InitializeControls(); 
            PotentialCustomerSLEntityView.InitializeControls(); 
           
        }
      
            public PotentialCustomerSLCollectionView PotentialCustomerSLCollectionView {get; set; } 
            public PotentialCustomerSLEntityView PotentialCustomerSLEntityView {get; set; } 
    }
            
    public partial class PotentialCustomerSLCollectionView : View
    {
        public PotentialCustomerSLCollectionView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PotentialCustomerSLCollectionView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9aa6921a-6db6-4f6d-b4b1-469f00cde358",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PotentialCustomerSLCollectionView,PotentialCustomerSLEntityView>( params_MainConsult,this,Screen.PotentialCustomerSLEntityView);
 

        }
        public IRPSButton<PotentialCustomerSLCollectionView,PotentialCustomerSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PotentialCustomerSLCollectionView,PotentialCustomerSLEntityView> MainConsult { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialCustomerSLEntityView : View
    {
        public PotentialCustomerSLEntityView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PotentialCustomerSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialCustomerSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialCustomerSLEntityView,PotentialCustomerSLCollectionView>( this,Screen.PotentialCustomerSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialCustomerSLEntityView,PotentialCustomerSLCollectionView>( this,Screen.PotentialCustomerSLCollectionView);
 
            CodPotentialCustomer = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("75f2148d-9255-451c-8554-c730521c4348","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("0d54d120-314f-4d55-bfb9-10f42bf0d2da","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("8612a0c3-3a8b-47d9-ac35-defe3f2179b7","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("3c8a1caf-fbe3-45b2-91f9-c7fe8a7f0b93","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<PotentialCustomerSLEntityView>("690b5153-e64b-48fc-83d7-3a35f9a51472","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("72949457-1b75-486a-b4b5-7f49b4105abb","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("e3c3474a-6a9d-4fc4-8021-4b9beddceb8f","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("12aa5857-c369-46f1-aabf-26f62d39baca","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("a6c8b8de-9aed-4cda-b291-7e242f9aff56","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("80d071ea-afe9-4a84-ba2a-f4099d8e247f","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("c38f3635-0f95-40c7-a4e9-eb85347cf412","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("d25524fa-3278-4256-a97e-d00dc725d00b","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("a64bcab9-9c22-4caa-b756-02cd9164fa27","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("8bdbb72c-e6a3-48b3-9ea0-a89738c8758e","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("2b6d3207-2900-4e99-ab39-65b504b67867","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("8577b547-5e8c-4154-82ce-8853072f05f5","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<PotentialCustomerSLEntityView>("58298393-840e-42f0-8228-a37552d51f89","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("40765072-36e4-43e4-a0f9-913b5a937ae2","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='3622ee88-2445-4bd8-879e-ed0335e7876b']","",this);
 

        }
        public IRPSSaveButton<PotentialCustomerSLEntityView> SaveButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView,PotentialCustomerSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView,PotentialCustomerSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CodPotentialCustomer { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Description { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CompanyName { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDState { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Address { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> City { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Position { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Fax { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Email { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> CodLanguage { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> GeneralDataSection { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}