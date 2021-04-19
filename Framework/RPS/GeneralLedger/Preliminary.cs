    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Preliminary
{
    //RPS VERSION 1.0.0.0
    public partial class Preliminary:Screen
    {
        public Preliminary():base()
        {
            this.URL = "generalledger.preliminary";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FAPreliminaryCollectionView  = new FAPreliminaryCollectionView(this); 
            FAPreliminaryEntityView  = new FAPreliminaryEntityView(this); 
            FAPreliminaryCollectionView.InitializeControls(); 
            FAPreliminaryEntityView.InitializeControls(); 
           
        }
      
            public FAPreliminaryCollectionView FAPreliminaryCollectionView {get; set; } 
            public FAPreliminaryEntityView FAPreliminaryEntityView {get; set; } 
    }
            
    public partial class FAPreliminaryCollectionView : View
    {
        public FAPreliminaryCollectionView(Preliminary screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FAPreliminaryCollectionView,FAPreliminaryEntityView>( this,Screen.FAPreliminaryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5c2db92b-c544-4349-af95-4abe621d12df",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FAPreliminaryCollectionView,FAPreliminaryEntityView>( params_MainConsult,this,Screen.FAPreliminaryEntityView);
 

        }
        public IRPSButton<FAPreliminaryCollectionView,FAPreliminaryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FAPreliminaryCollectionView,FAPreliminaryEntityView> MainConsult { get; set; } 
        public Preliminary Screen { get; set; }
        public FAPreliminaryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAPreliminaryEntityView : View
    {
        public FAPreliminaryEntityView(Preliminary screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FAPreliminaryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FAPreliminaryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FAPreliminaryEntityView,FAPreliminaryCollectionView>( this,Screen.FAPreliminaryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FAPreliminaryEntityView,FAPreliminaryCollectionView>( this,Screen.FAPreliminaryCollectionView);
 
            UIIDInvoice = RPSControlFactory.CreateRPSComboBox<FAPreliminaryEntityView>("e65d9b37-7d8c-4bf9-a41d-cc03e3d4f7f5","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<FAPreliminaryEntityView>("714f936f-c8b7-4458-8ff8-cb6cc52e71a1","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<FAPreliminaryEntityView>("0ebe6218-f9bc-42c6-be52-aff8780baa35","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<FAPreliminaryEntityView>("56586a9a-3f27-41fe-992a-484fb7b1e3dc","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<FAPreliminaryEntityView>("35a8564c-4899-4e68-8a23-7fc705340eed","","",true, this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<FAPreliminaryEntityView>("4d557538-5036-437c-b0f8-8f54599e6a5e","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FAPreliminaryEntityView>("9c24e88d-1618-4566-9367-38b405a8ea16","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FAPreliminaryEntityView>("0f553812-a1cd-4420-b946-a49a9c95647c","","",false, this);
 

        }
        public IRPSSaveButton<FAPreliminaryEntityView> SaveButton { get; set; } 
        public IRPSButton<FAPreliminaryEntityView> DeleteButton { get; set; } 
        public IRPSButton<FAPreliminaryEntityView,FAPreliminaryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FAPreliminaryEntityView,FAPreliminaryCollectionView> BackButton { get; set; } 
        public IRPSComboBox<FAPreliminaryEntityView> UIIDInvoice { get; set; } 
        public IRPSTextBox<FAPreliminaryEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<FAPreliminaryEntityView> InvoiceDate { get; set; } 
        public IRPSComboBox<FAPreliminaryEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<FAPreliminaryEntityView> Amount { get; set; } 
        public IRPSTextBox<FAPreliminaryEntityView> NumLine { get; set; } 
        public IRPSComboBox<FAPreliminaryEntityView> IDArticle { get; set; } 
        public IRPSTextBox<FAPreliminaryEntityView> Description { get; set; } 
        public Preliminary Screen { get; set; }
        public FAPreliminaryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}