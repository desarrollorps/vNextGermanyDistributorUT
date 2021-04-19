    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoicingTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class InvoicingTypeSL:Screen
    {
        public InvoicingTypeSL():base()
        {
            this.URL = "sales.invoicingtypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoicingTypeSLCollectionView  = new InvoicingTypeSLCollectionView(this); 
            InvoicingTypeSLEntityView  = new InvoicingTypeSLEntityView(this); 
            InvoicingTypeSLCollectionView.InitializeControls(); 
            InvoicingTypeSLEntityView.InitializeControls(); 
           
        }
      
            public InvoicingTypeSLCollectionView InvoicingTypeSLCollectionView {get; set; } 
            public InvoicingTypeSLEntityView InvoicingTypeSLEntityView {get; set; } 
    }
            
    public partial class InvoicingTypeSLCollectionView : View
    {
        public InvoicingTypeSLCollectionView(InvoicingTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoicingTypeSLCollectionView,InvoicingTypeSLEntityView>( this,Screen.InvoicingTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "22263ea2-b0cd-48db-828f-baadbfcbdd20",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoicingTypeSLCollectionView,InvoicingTypeSLEntityView>( params_MainConsult,this,Screen.InvoicingTypeSLEntityView);
 

        }
        public IRPSButton<InvoicingTypeSLCollectionView,InvoicingTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoicingTypeSLCollectionView,InvoicingTypeSLEntityView> MainConsult { get; set; } 
        public InvoicingTypeSL Screen { get; set; }
        public InvoicingTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoicingTypeSLEntityView : View
    {
        public InvoicingTypeSLEntityView(InvoicingTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoicingTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoicingTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoicingTypeSLEntityView,InvoicingTypeSLCollectionView>( this,Screen.InvoicingTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoicingTypeSLEntityView,InvoicingTypeSLCollectionView>( this,Screen.InvoicingTypeSLCollectionView);
 
            CodInvoicingType = RPSControlFactory.CreateRPSTextBox<InvoicingTypeSLEntityView>("8e3cde1e-3d2c-48f7-b4c0-c5903a6c4386","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoicingTypeSLEntityView>("08014a24-6ddf-4777-b1b9-cb02e51f4d52","","",false, this);
 
            CodAccType = RPSControlFactory.CreateRPSEnumComboBox<InvoicingTypeSLEntityView>("e103e4c2-6275-4dee-81e4-d16fa35fafe5","","",true, this);
 
            CodingSeriePrincipalDeliveryNote = RPSControlFactory.CreateRPSCheckBox<InvoicingTypeSLEntityView>("81c61383-1562-4edf-af23-ffa7a76c26e9","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoicingTypeSLEntityView>("24067d81-291e-47e7-8230-2323c7a3dd1d","","",true, this);
 
            CodingSeriePrincipalInvoice = RPSControlFactory.CreateRPSCheckBox<InvoicingTypeSLEntityView>("e3aac13e-c0d9-4ccd-ac08-63867689b84e","","",true, this);
 

        }
        public IRPSSaveButton<InvoicingTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoicingTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoicingTypeSLEntityView,InvoicingTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoicingTypeSLEntityView,InvoicingTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoicingTypeSLEntityView> CodInvoicingType { get; set; } 
        public IRPSTextBox<InvoicingTypeSLEntityView> Description { get; set; } 
        public IRPSComboBox<InvoicingTypeSLEntityView> CodAccType { get; set; } 
        public IRPSCheckbox<InvoicingTypeSLEntityView> CodingSeriePrincipalDeliveryNote { get; set; } 
        public IRPSCheckbox<InvoicingTypeSLEntityView> VAT { get; set; } 
        public IRPSCheckbox<InvoicingTypeSLEntityView> CodingSeriePrincipalInvoice { get; set; } 
        public InvoicingTypeSL Screen { get; set; }
        public InvoicingTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}