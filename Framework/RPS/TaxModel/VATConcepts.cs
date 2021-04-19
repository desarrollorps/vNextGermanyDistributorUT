    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.VATConcepts
{
    //RPS VERSION 1.0.0.0
    public partial class VATConcepts:Screen
    {
        public VATConcepts():base()
        {
            this.URL = "taxmodel.vatconcepts";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATConceptDetailVMCollectionView  = new VATConceptDetailVMCollectionView(this); 
            VATConceptDetailVMEntityView  = new VATConceptDetailVMEntityView(this); 
            ImportVATConceptsFromXMLDialogView  = new ImportVATConceptsFromXMLDialogView(this); 
            VATConceptDetailVMCollectionView.InitializeControls(); 
            VATConceptDetailVMEntityView.InitializeControls(); 
            ImportVATConceptsFromXMLDialogView.InitializeControls(); 
           
        }
      
            public VATConceptDetailVMCollectionView VATConceptDetailVMCollectionView {get; set; } 
            public VATConceptDetailVMEntityView VATConceptDetailVMEntityView {get; set; } 
            public ImportVATConceptsFromXMLDialogView ImportVATConceptsFromXMLDialogView {get; set; } 
    }
            
    public partial class VATConceptDetailVMCollectionView : View
    {
        public VATConceptDetailVMCollectionView(VATConcepts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            VATConcept = RPSControlFactory.CreateRPSEnumComboBox<VATConceptDetailVMCollectionView>("a1583caa-88bf-4056-ac72-d0a19325f6ed","","",false, this);
 
            ImportVATConceptsFromXMLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<VATConceptDetailVMCollectionView,ImportVATConceptsFromXMLDialogView>("2f52bd25-93c2-4d0c-b9be-6cbc6547d976","","", this,Screen.ImportVATConceptsFromXMLDialogView);
 
            ExecuteExportVATConceptsToXMLButton = RPSControlFactory.CreateRPSButton<VATConceptDetailVMCollectionView>( "03e8eaed-649e-4422-8d38-360a12b14657","","",this);
 
            CollectionInit params_VATConceptsSourceQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bb4fe3ad-5f01-42c0-ad7f-ba0b35afa11d",CSSSelectorGrid="",XPathGrid=""};
            VATConceptsSourceQuery = RPSControlFactory.RPSCreateCollectionWithGrid<VATConceptsSourceQueryCollectionEditor<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView>,VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView>( params_VATConceptsSourceQuery,this,Screen.VATConceptDetailVMEntityView);
 

        }
        public IRPSComboBox<VATConceptDetailVMCollectionView> VATConcept { get; set; } 
        public IRPSButton<VATConceptDetailVMCollectionView,ImportVATConceptsFromXMLDialogView> ImportVATConceptsFromXMLNavigationCommandButton { get; set; } 
        public IRPSButton<VATConceptDetailVMCollectionView> ExecuteExportVATConceptsToXMLButton { get; set; } 
        public VATConceptsSourceQueryCollectionEditor<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView> VATConceptsSourceQuery { get; set; } 
        public VATConcepts Screen { get; set; }
        public VATConceptDetailVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VATConceptsSourceQueryCollectionEditor<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView>:RPSCollectionEditor<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView> where VATConceptDetailVMCollectionView : class, IView where VATConceptDetailVMEntityView : class, IView
    {
        public  VATConceptsSourceQueryGridView<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView> GridView {get;set;}
    }
    public partial class VATConceptsSourceQueryGridView <VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView> :  RPSGridView<VATConceptDetailVMCollectionView,VATConceptDetailVMEntityView> where VATConceptDetailVMCollectionView : class, IView where VATConceptDetailVMEntityView : class, IView
    {
        public VATConceptsSourceQueryGridView(VATConceptDetailVMCollectionView currentView,VATConceptDetailVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VATConcept = RPSControlFactory.CreateRPSGridEnumComboBox<VATConceptDetailVMCollectionView>("","#bb4fe3ad-5f01-42c0-ad7f-ba0b35afa11d .ag-row[role='row']@ROWINDEX [col-id='cVATConcept']","",true, this.CurrentView);
 
            CodVoucherType = RPSControlFactory.CreateRPSGridEnumComboBox<VATConceptDetailVMCollectionView>("","#bb4fe3ad-5f01-42c0-ad7f-ba0b35afa11d .ag-row[role='row']@ROWINDEX [col-id='cCodVoucherType']","",false, this.CurrentView);
 
            CodVAT = RPSControlFactory.CreateRPSGridEnumComboBox<VATConceptDetailVMCollectionView>("","#bb4fe3ad-5f01-42c0-ad7f-ba0b35afa11d .ag-row[role='row']@ROWINDEX [col-id='cCodVAT']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<VATConceptDetailVMCollectionView> VATConcept { get; set; } 
        public IRPSGridComboBox<VATConceptDetailVMCollectionView> CodVoucherType { get; set; } 
        public IRPSGridComboBox<VATConceptDetailVMCollectionView> CodVAT { get; set; } 
                     
    }
 
    }
  
            
    public partial class VATConceptDetailVMEntityView : View
    {
        public VATConceptDetailVMEntityView(VATConcepts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATConceptDetailVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView>( this,Screen.VATConceptDetailVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView>( this,Screen.VATConceptDetailVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView>( this,Screen.VATConceptDetailVMCollectionView);
 
            VATConcept = RPSControlFactory.CreateRPSEnumComboBox<VATConceptDetailVMEntityView>("205e2093-38bc-4db3-804f-0e5a1374c5ef","","",true, this);
 
            CodVoucherType = RPSControlFactory.CreateRPSEnumComboBox<VATConceptDetailVMEntityView>("094ac71d-f35f-49f0-8ccb-4f4d64c55e22","","",false, this);
 
            CodVAT = RPSControlFactory.CreateRPSEnumComboBox<VATConceptDetailVMEntityView>("3b86a1a2-756c-461f-9b89-ee85703a7bfe","","",false, this);
 

        }
        public IRPSButton<VATConceptDetailVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<VATConceptDetailVMEntityView,VATConceptDetailVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<VATConceptDetailVMEntityView> VATConcept { get; set; } 
        public IRPSComboBox<VATConceptDetailVMEntityView> CodVoucherType { get; set; } 
        public IRPSComboBox<VATConceptDetailVMEntityView> CodVAT { get; set; } 
        public VATConcepts Screen { get; set; }
        public VATConceptDetailVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportVATConceptsFromXMLDialogView : View
    {
        public ImportVATConceptsFromXMLDialogView(VATConcepts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public VATConcepts Screen { get; set; }
        public ImportVATConceptsFromXMLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}