    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ImportDocumentType
{
    //RPS VERSION 1.0.0.0
    public partial class ImportDocumentType:Screen
    {
        public ImportDocumentType():base()
        {
            this.URL = "purchase.importdocumenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImportDocumentTypeCollectionView  = new ImportDocumentTypeCollectionView(this); 
            ImportDocumentTypeEntityView  = new ImportDocumentTypeEntityView(this); 
            ImportDocumentTypeCollectionView.InitializeControls(); 
            ImportDocumentTypeEntityView.InitializeControls(); 
           
        }
      
            public ImportDocumentTypeCollectionView ImportDocumentTypeCollectionView {get; set; } 
            public ImportDocumentTypeEntityView ImportDocumentTypeEntityView {get; set; } 
    }
            
    public partial class ImportDocumentTypeCollectionView : View
    {
        public ImportDocumentTypeCollectionView(ImportDocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImportDocumentTypeCollectionView,ImportDocumentTypeEntityView>( this,Screen.ImportDocumentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d23d31ab-b4ab-4599-95db-45e9d826a843",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ImportDocumentTypeCollectionView,ImportDocumentTypeEntityView>( params_MainConsult,this,Screen.ImportDocumentTypeEntityView);
 

        }
        public IRPSButton<ImportDocumentTypeCollectionView,ImportDocumentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ImportDocumentTypeCollectionView,ImportDocumentTypeEntityView> MainConsult { get; set; } 
        public ImportDocumentType Screen { get; set; }
        public ImportDocumentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportDocumentTypeEntityView : View
    {
        public ImportDocumentTypeEntityView(ImportDocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImportDocumentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImportDocumentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImportDocumentTypeEntityView,ImportDocumentTypeCollectionView>( this,Screen.ImportDocumentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImportDocumentTypeEntityView,ImportDocumentTypeCollectionView>( this,Screen.ImportDocumentTypeCollectionView);
 
            CodDocumentType = RPSControlFactory.CreateRPSTextBox<ImportDocumentTypeEntityView>("0cc1613c-c4c2-4aa7-b3a3-408070354463","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImportDocumentTypeEntityView>("fd96738c-8d6b-4277-a44f-5fcb884492da","","",false, this);
 
            ExpenseType = RPSControlFactory.CreateRPSEnumComboBox<ImportDocumentTypeEntityView>("4813c009-69f6-4e09-a714-ef9bc98bdb3e","","",true, this);
 
            ApportionmentType = RPSControlFactory.CreateRPSEnumComboBox<ImportDocumentTypeEntityView>("ae68d7a7-e4c3-4cb0-8366-f5c6ca051f7e","","",true, this);
 
            PorcCalc = RPSControlFactory.CreateRPSFormattedTextBox<ImportDocumentTypeEntityView>("1e76f695-612c-4a8c-8043-57495ce7952e","","",true, this);
 
            ManValue = RPSControlFactory.CreateRPSFormattedTextBox<ImportDocumentTypeEntityView>("46c71a7c-1f68-49e7-91ed-d0ac61da1199","","",true, this);
 
            BreakDownPar = RPSControlFactory.CreateRPSCheckBox<ImportDocumentTypeEntityView>("9a1b9f79-ae11-49fa-9578-804a79d2b2fe","","",true, this);
 

        }
        public IRPSSaveButton<ImportDocumentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ImportDocumentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImportDocumentTypeEntityView,ImportDocumentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImportDocumentTypeEntityView,ImportDocumentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ImportDocumentTypeEntityView> CodDocumentType { get; set; } 
        public IRPSTextBox<ImportDocumentTypeEntityView> Description { get; set; } 
        public IRPSComboBox<ImportDocumentTypeEntityView> ExpenseType { get; set; } 
        public IRPSComboBox<ImportDocumentTypeEntityView> ApportionmentType { get; set; } 
        public IRPSTextBox<ImportDocumentTypeEntityView> PorcCalc { get; set; } 
        public IRPSTextBox<ImportDocumentTypeEntityView> ManValue { get; set; } 
        public IRPSCheckbox<ImportDocumentTypeEntityView> BreakDownPar { get; set; } 
        public ImportDocumentType Screen { get; set; }
        public ImportDocumentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}