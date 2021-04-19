    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NCConsultations
{
    //RPS VERSION 1.0.0.0
    public partial class NCConsultations:Screen
    {
        public NCConsultations():base()
        {
            this.URL = "quality.ncconsultations";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NCConsultationsQueryView  = new NCConsultationsQueryView(this); 
            NCConsultationsQueryView.InitializeControls(); 
           
        }
      
            public NCConsultationsQueryView NCConsultationsQueryView {get; set; } 
    }
            
    public partial class NCConsultationsQueryView : View
    {
        public NCConsultationsQueryView(NCConsultations screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("c1c0e7dc-ff1d-42ea-a738-68b5eae23c1d","","",false, this);
 
            NCTypeOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("cfe5eb03-b799-415a-b39f-3b9756eb741f","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("d168ae0e-2994-4b0e-97b1-08700fbd5cdb","","",false, this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("f8ea3e56-a34e-4eeb-a49b-3610e4e26f85","","",false, this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("c913728f-9d00-4584-8101-81e3bc2b8471","","",false, this);
 
            CustomerValorationOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("5b49b302-3135-4928-b23d-1f8edbc43802","","",false, this);
 
            SupplierResponseOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("80556dde-8669-4913-a044-038b241f503b","","",false, this);
 
            NCSituationOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("04d83dd2-2e2d-4c27-ae31-18f143e42b12","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<NCConsultationsQueryView>("d3e9e4ff-0f52-46e9-a09b-ca98f0cd6a77","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<NCConsultationsQueryView>("7dae4cb0-a904-4e3b-93cf-8310c619971d","","",false, this);
 
            ClassificationOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("25662841-76e2-43bf-a975-5a02bd8a7012","","",false, this);
 
            RepetitiveOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("6981581f-78fb-41cf-b2a7-5c7d712615f8","","",false, this);
 
            NCStatus = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("0a4d65ab-4b00-4909-99a1-fcd83e530f49","","",false, this);
 
            NCSource = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("01c1a664-8c6f-4084-bd84-b702dea53c23","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("37424d9a-6ae9-4dc3-9e70-8abe07a9d337","","",false, this);
 
            NCReason = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("b7dd467e-da9d-4e05-99ee-5a76bab6d8a9","","",false, this);
 
            ResponsibleforAction = RPSControlFactory.CreateRPSComboBox<NCConsultationsQueryView>("cf1125a3-cd97-4702-8722-1ebf3d992ccd","","",false, this);
 
            ActionSituationOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("e665c41d-aad4-4f8d-9be0-ff415e795b59","","",false, this);
 
            ActionTypeOption = RPSControlFactory.CreateRPSEnumComboBox<NCConsultationsQueryView>("e8124d85-40d4-46da-83b4-2b66695e26b2","","",false, this);
 
            CollectionInit params_NCConsultationsQuery = new CollectionInit(){IDDescriptor = "1ad5d747-3083-40db-826a-0374477b5e64",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8dd518b1-1372-4e88-92bd-dcf87c47459e",CSSSelectorGrid="",XPathGrid=""};
            NCConsultationsQuery = RPSControlFactory.RPSCreateCollectionWithGrid<NCConsultationsQueryCollectionEditor<NCConsultationsQueryView>,NCConsultationsQueryView>( params_NCConsultationsQuery,this);
 
            CollectionInit params_ActionsFromNonConformity = new CollectionInit(){IDDescriptor = "1ad5d747-3083-40db-826a-0374477b5e64",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="89ede08a-72e2-4b9b-90d5-de9b7486fa78",CSSSelectorGrid="",XPathGrid=""};
            ActionsFromNonConformity = RPSControlFactory.RPSCreateCollectionWithGrid<ActionsFromNonConformityCollectionEditor<NCConsultationsQueryView>,NCConsultationsQueryView>( params_ActionsFromNonConformity,this);
 

        }
        public IRPSComboBox<NCConsultationsQueryView> Site { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> NCTypeOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> Employee { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> Supplier1 { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> Customer1 { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> CustomerValorationOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> SupplierResponseOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> NCSituationOption { get; set; } 
        public IRPSTextBox<NCConsultationsQueryView> DateFrom { get; set; } 
        public IRPSTextBox<NCConsultationsQueryView> DateTo { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> ClassificationOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> RepetitiveOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> NCStatus { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> NCSource { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> Article { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> NCReason { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> ResponsibleforAction { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> ActionSituationOption { get; set; } 
        public IRPSComboBox<NCConsultationsQueryView> ActionTypeOption { get; set; } 
        public NCConsultationsQueryCollectionEditor<NCConsultationsQueryView> NCConsultationsQuery { get; set; } 
        public ActionsFromNonConformityCollectionEditor<NCConsultationsQueryView> ActionsFromNonConformity { get; set; } 
        public NCConsultations Screen { get; set; }
        public NCConsultationsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCConsultationsQueryCollectionEditor<NCConsultationsQueryView>:RPSCollectionEditor<NCConsultationsQueryView> where NCConsultationsQueryView : class, IView
    {
        public  NCConsultationsQueryGridView<NCConsultationsQueryView> GridView {get;set;}
    }
    public partial class NCConsultationsQueryGridView <NCConsultationsQueryView> :  RPSGridView<NCConsultationsQueryView> where NCConsultationsQueryView : class, IView
    {
        public NCConsultationsQueryGridView(NCConsultationsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",false, this.CurrentView);
 
            CloseDate = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cCloseDate']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Classification = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cClassification']","",false, this.CurrentView);
 
            Repetitive = RPSControlFactory.CreateRPSGridCheckBox<NCConsultationsQueryView>("","#8dd518b1-1372-4e88-92bd-dcf87c47459e .ag-row[role='row']@ROWINDEX [col-id='cRepetitive']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NCConsultationsQueryView> CreationDate { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> CloseDate { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Description { get; set; } 
        public IRPSGridComboBox<NCConsultationsQueryView> Type { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Classification { get; set; } 
        public IRPSGridCheckbox<NCConsultationsQueryView> Repetitive { get; set; } 
                     
    }
 
        public partial class ActionsFromNonConformityCollectionEditor<NCConsultationsQueryView>:RPSCollectionEditor<NCConsultationsQueryView> where NCConsultationsQueryView : class, IView
    {
        public  ActionsFromNonConformityGridView<NCConsultationsQueryView> GridView {get;set;}
    }
    public partial class ActionsFromNonConformityGridView <NCConsultationsQueryView> :  RPSGridView<NCConsultationsQueryView> where NCConsultationsQueryView : class, IView
    {
        public ActionsFromNonConformityGridView(NCConsultationsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cActionNumber']","",false, this.CurrentView);
 
            ActionType = RPSControlFactory.CreateRPSGridFormattedTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cActionType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            PlannedDate = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cPlannedDate']","",false, this.CurrentView);
 
            RealDate = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cRealDate']","",false, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 
            Efficacy = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cEfficacy']","",false, this.CurrentView);
 
            Progress = RPSControlFactory.CreateRPSGridFormattedTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cProgress']","",false, this.CurrentView);
 
            Verification = RPSControlFactory.CreateRPSGridTextBox<NCConsultationsQueryView>("","#89ede08a-72e2-4b9b-90d5-de9b7486fa78 .ag-row[role='row']@ROWINDEX [col-id='cVerification']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NCConsultationsQueryView> ActionNumber { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> ActionType { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Description { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> PlannedDate { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> RealDate { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> EndDate { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Comments { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Efficacy { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Progress { get; set; } 
        public IRPSGridTextBox<NCConsultationsQueryView> Verification { get; set; } 
                     
    }
 
    }
  
    

}