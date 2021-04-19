    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Bank
{
    //RPS VERSION 1.0.0.0
    public partial class Bank:Screen
    {
        public Bank():base()
        {
            this.URL = "general.bank";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankCollectionView  = new BankCollectionView(this); 
            BankEntityView  = new BankEntityView(this); 
            BankBranchView  = new BankBranchView(this); 
            BankCollectionView.InitializeControls(); 
            BankEntityView.InitializeControls(); 
            BankBranchView.InitializeControls(); 
           
        }
      
            public BankCollectionView BankCollectionView {get; set; } 
            public BankEntityView BankEntityView {get; set; } 
            public BankBranchView BankBranchView {get; set; } 
    }
            
    public partial class BankCollectionView : View
    {
        public BankCollectionView(Bank screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BankCollectionView,BankEntityView>( this,Screen.BankEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "82624307-6e85-4eb0-9b16-fdc782392bbd",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BankCollectionView,BankEntityView>( params_MainConsult,this,Screen.BankEntityView);
 

        }
        public IRPSButton<BankCollectionView,BankEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BankCollectionView,BankEntityView> MainConsult { get; set; } 
        public Bank Screen { get; set; }
        public BankCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BankEntityView : View
    {
        public BankEntityView(Bank screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BankEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankEntityView,BankCollectionView>( this,Screen.BankCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankEntityView,BankCollectionView>( this,Screen.BankCollectionView);
 
            CodBank = RPSControlFactory.CreateRPSTextBox<BankEntityView>("3f469e98-6274-4e80-bff1-e275dbee489d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BankEntityView>("b7f38947-fd41-4c57-9cfc-6ace57f2d2d2","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<BankEntityView>("2262bf17-7e33-403a-ab43-cfe236f62c6e","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<BankEntityView>("7b8b4d4b-daba-4ddc-8262-5dc6fc263bac","","",false, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<BankEntityView>("062207a8-0e9a-4f08-9e56-0ba808fe3e41","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<BankEntityView>("808af603-2c6e-45b9-98ba-537237234b09","","",true, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<BankEntityView>("eb3c96c8-9741-4f47-9554-73fb96fb5a91","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<BankEntityView>("7b1eb02b-d41c-4c82-ad14-18cc8e06bb8d","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<BankEntityView>("20eea214-ef13-422b-baa1-4c16a5ffb7ec","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<BankEntityView>("76f3e839-f85d-4074-a7f5-faf1874be09c","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<BankEntityView>("22eff6b9-b258-4b1e-9212-20bf77e08b25","","",false, this);
 
            CollectionInit params_BankBranchs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="faa6c95c-64dd-4337-987e-45e1c3589d97",CSSSelectorGrid="",XPathGrid=""};
            BankBranchs = RPSControlFactory.RPSCreateCollectionWithGrid<BankBranchsCollectionEditor<BankEntityView,BankBranchView>,BankEntityView,BankBranchView>( params_BankBranchs,this,Screen.BankBranchView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<BankEntityView>( "","ul li[rpsid='b5fd27ed-e9b6-4c7f-a18d-998963426401']","",this);
 
            BankBranches = RPSControlFactory.CreateRPSSection<BankEntityView>( "","ul li[rpsid='ccd0f798-7df5-4dcc-a44a-86f3e338ed99']","",this);
 

        }
        public IRPSSaveButton<BankEntityView> SaveButton { get; set; } 
        public IRPSButton<BankEntityView> DeleteButton { get; set; } 
        public IRPSButton<BankEntityView,BankCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankEntityView,BankCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BankEntityView> CodBank { get; set; } 
        public IRPSTextBox<BankEntityView> Description { get; set; } 
        public IRPSTextBox<BankEntityView> CompanyName { get; set; } 
        public IRPSTextBox<BankEntityView> VATNumber { get; set; } 
        public IRPSTextBox<BankEntityView> SWIFTCode { get; set; } 
        public IRPSComboBox<BankEntityView> CodCountry { get; set; } 
        public IRPSTextBox<BankEntityView> ZipCode { get; set; } 
        public IRPSComboBox<BankEntityView> IDState { get; set; } 
        public IRPSComboBox<BankEntityView> IDCounty { get; set; } 
        public IRPSTextBox<BankEntityView> Address { get; set; } 
        public IRPSTextBox<BankEntityView> City { get; set; } 
        public BankBranchsCollectionEditor<BankEntityView,BankBranchView> BankBranchs { get; set; } 
        public IRPSSection<BankEntityView> GeneralData { get; set; } 
        public IRPSSection<BankEntityView> BankBranches { get; set; } 
        public Bank Screen { get; set; }
        public BankEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BankBranchsCollectionEditor<BankEntityView,BankBranchView>:RPSCollectionEditor<BankEntityView,BankBranchView> where BankEntityView : class, IView where BankBranchView : class, IView
    {
        public  BankBranchsGridView<BankEntityView,BankBranchView> GridView {get;set;}
    }
    public partial class BankBranchsGridView <BankEntityView,BankBranchView> :  RPSGridView<BankEntityView,BankBranchView> where BankEntityView : class, IView where BankBranchView : class, IView
    {
        public BankBranchsGridView(BankEntityView currentView,BankBranchView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodBankBranch = RPSControlFactory.CreateRPSGridTextBox<BankEntityView>("","#faa6c95c-64dd-4337-987e-45e1c3589d97 .ag-row[role='row']@ROWINDEX [col-id='cCodBankBranch']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<BankEntityView>("","#faa6c95c-64dd-4337-987e-45e1c3589d97 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            SwiftCode = RPSControlFactory.CreateRPSGridTextBox<BankEntityView>("","#faa6c95c-64dd-4337-987e-45e1c3589d97 .ag-row[role='row']@ROWINDEX [col-id='cSwiftCode']","",false, this.CurrentView);
 
            TelephoneNumber = RPSControlFactory.CreateRPSGridTextBox<BankEntityView>("","#faa6c95c-64dd-4337-987e-45e1c3589d97 .ag-row[role='row']@ROWINDEX [col-id='cTelephoneNumber']","",false, this.CurrentView);
 
            MailAddress = RPSControlFactory.CreateRPSGridEmailTextBox<BankEntityView>("","#faa6c95c-64dd-4337-987e-45e1c3589d97 .ag-row[role='row']@ROWINDEX [col-id='cMailAddress']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankEntityView> CodBankBranch { get; set; } 
        public IRPSGridTextBox<BankEntityView> Description { get; set; } 
        public IRPSGridTextBox<BankEntityView> SwiftCode { get; set; } 
        public IRPSGridTextBox<BankEntityView> TelephoneNumber { get; set; } 
        public IRPSGridTextBox<BankEntityView> MailAddress { get; set; } 
                     
    }
 
    }
  
            
    public partial class BankBranchView : View
    {
        public BankBranchView(Bank screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankBranchView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankBranchView,BankEntityView>( this,Screen.BankEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankBranchView,BankEntityView>( this,Screen.BankEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BankBranchView,BankEntityView>( this,Screen.BankEntityView);
 
            CodBankBranch = RPSControlFactory.CreateRPSTextBox<BankBranchView>("4dce53dc-b705-41a7-bab9-d8e0698d9692","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BankBranchView>("2d366b32-2ef4-4894-a117-00c9d1d7ac4d","","",false, this);
 
            SwiftCode = RPSControlFactory.CreateRPSTextBox<BankBranchView>("99af9b2c-3ff2-4d6e-b557-8e4c5ae0344d","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<BankBranchView>("177a0a60-e00e-4532-b9af-bb9b70101f8b","","",true, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<BankBranchView>("67009682-8c94-40ed-81f2-4843f724a84e","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<BankBranchView>("3a6f558a-f592-49ba-9ca9-f025d6b7783d","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<BankBranchView>("e20bba1b-e0f5-4c32-8faf-cc808887d820","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<BankBranchView>("5234dced-70a1-4cc2-9066-cf9d4c711cb4","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<BankBranchView>("050e8c1f-ca6d-4d8f-98e7-926c6701c24c","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<BankBranchView>("fd781f15-b3d5-4bd9-b244-cbf7e452bfd0","","",false, this);
 
            TelephoneNumber = RPSControlFactory.CreateRPSTextBox<BankBranchView>("43cf47a6-6cd7-4fd9-96e8-9352b6968f2c","","",false, this);
 
            MailAddress1 = RPSControlFactory.CreateRPSEmailTextBox<BankBranchView>("21a1acb2-0a5b-4270-b6a7-506c1fd21c98","","",false, this);
 

        }
        public IRPSButton<BankBranchView> DeleteButton { get; set; } 
        public IRPSButton<BankBranchView,BankEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankBranchView,BankEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BankBranchView,BankEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<BankBranchView> CodBankBranch { get; set; } 
        public IRPSTextBox<BankBranchView> Description { get; set; } 
        public IRPSTextBox<BankBranchView> SwiftCode { get; set; } 
        public IRPSComboBox<BankBranchView> CodCountry { get; set; } 
        public IRPSTextBox<BankBranchView> ZipCode { get; set; } 
        public IRPSComboBox<BankBranchView> IDState { get; set; } 
        public IRPSComboBox<BankBranchView> IDCounty { get; set; } 
        public IRPSTextBox<BankBranchView> Address { get; set; } 
        public IRPSTextBox<BankBranchView> City { get; set; } 
        public IRPSTextBox<BankBranchView> ContactPerson { get; set; } 
        public IRPSTextBox<BankBranchView> TelephoneNumber { get; set; } 
        public IRPSTextBox<BankBranchView> MailAddress1 { get; set; } 
        public Bank Screen { get; set; }
        public BankBranchView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}