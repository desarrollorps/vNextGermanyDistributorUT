    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoicingType
{
    //RPS VERSION 1.0.0.0
    public partial class InvoicingType:Screen
    {
        public InvoicingType():base()
        {
            this.URL = "purchase.invoicingtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoicingTypeCollectionView  = new InvoicingTypeCollectionView(this); 
            InvoicingTypeEntityView  = new InvoicingTypeEntityView(this); 
            InvoicingTypeCollectionView.InitializeControls(); 
            InvoicingTypeEntityView.InitializeControls(); 
           
        }
      
            public InvoicingTypeCollectionView InvoicingTypeCollectionView {get; set; } 
            public InvoicingTypeEntityView InvoicingTypeEntityView {get; set; } 
    }
            
    public partial class InvoicingTypeCollectionView : View
    {
        public InvoicingTypeCollectionView(InvoicingType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoicingTypeCollectionView,InvoicingTypeEntityView>( this,Screen.InvoicingTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bd3f645e-0b80-47a6-be42-b6bb5e92ab65",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoicingTypeCollectionView,InvoicingTypeEntityView>( params_MainConsult,this,Screen.InvoicingTypeEntityView);
 

        }
        public IRPSButton<InvoicingTypeCollectionView,InvoicingTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoicingTypeCollectionView,InvoicingTypeEntityView> MainConsult { get; set; } 
        public InvoicingType Screen { get; set; }
        public InvoicingTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoicingTypeEntityView : View
    {
        public InvoicingTypeEntityView(InvoicingType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoicingTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoicingTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoicingTypeEntityView,InvoicingTypeCollectionView>( this,Screen.InvoicingTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoicingTypeEntityView,InvoicingTypeCollectionView>( this,Screen.InvoicingTypeCollectionView);
 
            CodInvoicingType = RPSControlFactory.CreateRPSTextBox<InvoicingTypeEntityView>("731553b5-2135-43c3-aad6-f9a386786da9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoicingTypeEntityView>("cf3d6245-c069-4472-8385-2abda6d08218","","",false, this);
 
            CodAccType = RPSControlFactory.CreateRPSEnumComboBox<InvoicingTypeEntityView>("ac66a904-f92e-4f3f-be78-0843e9f1981c","","",false, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoicingTypeEntityView>("05cb8978-02de-4948-a000-a6f413816c59","","",true, this);
 

        }
        public IRPSSaveButton<InvoicingTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoicingTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoicingTypeEntityView,InvoicingTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoicingTypeEntityView,InvoicingTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoicingTypeEntityView> CodInvoicingType { get; set; } 
        public IRPSTextBox<InvoicingTypeEntityView> Description { get; set; } 
        public IRPSComboBox<InvoicingTypeEntityView> CodAccType { get; set; } 
        public IRPSCheckbox<InvoicingTypeEntityView> VAT { get; set; } 
        public InvoicingType Screen { get; set; }
        public InvoicingTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}