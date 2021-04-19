    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.VersionResponsibleLists
{
    //RPS VERSION 1.0.0.0
    public partial class VersionResponsibleLists:Screen
    {
        public VersionResponsibleLists():base()
        {
            this.URL = "quality.versionresponsiblelists";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VersionResponsibleListsVMQueryView  = new VersionResponsibleListsVMQueryView(this); 
            VersionResponsibleListsVMEntityView  = new VersionResponsibleListsVMEntityView(this); 
            ResponsibleTaskAssignationView  = new ResponsibleTaskAssignationView(this); 
            VersionResponsibleListsVMQueryView.InitializeControls(); 
            VersionResponsibleListsVMEntityView.InitializeControls(); 
            ResponsibleTaskAssignationView.InitializeControls(); 
           
        }
      
            public VersionResponsibleListsVMQueryView VersionResponsibleListsVMQueryView {get; set; } 
            public VersionResponsibleListsVMEntityView VersionResponsibleListsVMEntityView {get; set; } 
            public ResponsibleTaskAssignationView ResponsibleTaskAssignationView {get; set; } 
    }
            
    public partial class VersionResponsibleListsVMQueryView : View
    {
        public VersionResponsibleListsVMQueryView(VersionResponsibleLists screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView>( this,Screen.VersionResponsibleListsVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<VersionResponsibleListsVMQueryView>( this);
 
            User = RPSControlFactory.CreateRPSCollectionComboBox<VersionResponsibleListsVMQueryView>("43863bc2-acb4-4a49-ae0d-2bd4067568b3","","",false, this);
 
            Role = RPSControlFactory.CreateRPSCollectionComboBox<VersionResponsibleListsVMQueryView>("e20f9ce9-6ad9-464a-9a1a-8d7bd42628d1","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<VersionResponsibleListsVMQueryView>("1b88b8cb-7460-4748-9338-bfcd995b711d","","",false, this);
 
            QualityDocumentType = RPSControlFactory.CreateRPSCollectionComboBox<VersionResponsibleListsVMQueryView>("169f60a2-1296-4c23-b83b-72b5d0acce9e","","",false, this);
 
            CollectionInit params_VersionResponsibleListsQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c8af3079-d563-484c-8457-a64b6cc403fd",CSSSelectorGrid="",XPathGrid=""};
            VersionResponsibleListsQuery = RPSControlFactory.RPSCreateCollectionWithGrid<VersionResponsibleListsQueryCollectionEditor<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView>,VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView>( params_VersionResponsibleListsQuery,this,Screen.VersionResponsibleListsVMEntityView);
 

        }
        public IRPSButton<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> NewButton { get; set; } 
        public IRPSButton<VersionResponsibleListsVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<VersionResponsibleListsVMQueryView> User { get; set; } 
        public IRPSCollectionComboBox<VersionResponsibleListsVMQueryView> Role { get; set; } 
        public IRPSCollectionComboBox<VersionResponsibleListsVMQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<VersionResponsibleListsVMQueryView> QualityDocumentType { get; set; } 
        public VersionResponsibleListsQueryCollectionEditor<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> VersionResponsibleListsQuery { get; set; } 
        public VersionResponsibleLists Screen { get; set; }
        public VersionResponsibleListsVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VersionResponsibleListsQueryCollectionEditor<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView>:RPSCollectionEditor<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> where VersionResponsibleListsVMQueryView : class, IView where VersionResponsibleListsVMEntityView : class, IView
    {
        public  VersionResponsibleListsQueryGridView<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> GridView {get;set;}
    }
    public partial class VersionResponsibleListsQueryGridView <VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> :  RPSGridView<VersionResponsibleListsVMQueryView,VersionResponsibleListsVMEntityView> where VersionResponsibleListsVMQueryView : class, IView where VersionResponsibleListsVMEntityView : class, IView
    {
        public VersionResponsibleListsQueryGridView(VersionResponsibleListsVMQueryView currentView,VersionResponsibleListsVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            responsibleDescription = RPSControlFactory.CreateRPSGridTextBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cresponsibleDescription']","",false, this.CurrentView);
 
            ApprOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cApprOrder']","",false, this.CurrentView);
 
            Approval = RPSControlFactory.CreateRPSGridCheckBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cApproval']","",false, this.CurrentView);
 
            Revise = RPSControlFactory.CreateRPSGridCheckBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cRevise']","",false, this.CurrentView);
 
            Receipt = RPSControlFactory.CreateRPSGridCheckBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cReceipt']","",false, this.CurrentView);
 
            EditFinishedVers = RPSControlFactory.CreateRPSGridCheckBox<VersionResponsibleListsVMQueryView>("","#c8af3079-d563-484c-8457-a64b6cc403fd .ag-row[role='row']@ROWINDEX [col-id='cEditFinishedVers']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VersionResponsibleListsVMQueryView> responsibleDescription { get; set; } 
        public IRPSGridTextBox<VersionResponsibleListsVMQueryView> ApprOrder { get; set; } 
        public IRPSGridCheckbox<VersionResponsibleListsVMQueryView> Approval { get; set; } 
        public IRPSGridCheckbox<VersionResponsibleListsVMQueryView> Revise { get; set; } 
        public IRPSGridCheckbox<VersionResponsibleListsVMQueryView> Receipt { get; set; } 
        public IRPSGridCheckbox<VersionResponsibleListsVMQueryView> EditFinishedVers { get; set; } 
                     
    }
 
    }
  
            
    public partial class VersionResponsibleListsVMEntityView : View
    {
        public VersionResponsibleListsVMEntityView(VersionResponsibleLists screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VersionResponsibleListsVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VersionResponsibleListsVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VersionResponsibleListsVMEntityView,VersionResponsibleListsVMQueryView>( this,Screen.VersionResponsibleListsVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<VersionResponsibleListsVMEntityView,VersionResponsibleListsVMQueryView>( this,Screen.VersionResponsibleListsVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<VersionResponsibleListsVMEntityView>("5eb846f1-ef37-4bec-a6c2-fd0d4699d738","","",false, this);
 
            IDQualityDocumentType = RPSControlFactory.CreateRPSComboBox<VersionResponsibleListsVMEntityView>("d5427392-914e-41a0-9f4f-cce816745033","","",false, this);
 
            ApprOrder = RPSControlFactory.CreateRPSFormattedTextBox<VersionResponsibleListsVMEntityView>("24c70e2f-35f6-4b60-a228-0c3b969874c5","","",false, this);
 
            Approval = RPSControlFactory.CreateRPSCheckBox<VersionResponsibleListsVMEntityView>("6e97447e-4c07-4cd4-9022-80cbe8ab8c09","","",false, this);
 
            Revise = RPSControlFactory.CreateRPSCheckBox<VersionResponsibleListsVMEntityView>("0bf3ae00-cee7-4ca4-ac50-6e3dabc3d81f","","",false, this);
 
            Receipt = RPSControlFactory.CreateRPSCheckBox<VersionResponsibleListsVMEntityView>("4cd8b51b-b9cf-439c-afd7-69511fecf01e","","",false, this);
 
            ModifyFinishedVersions = RPSControlFactory.CreateRPSCheckBox<VersionResponsibleListsVMEntityView>("b9b79ef8-4284-4553-adea-45a66b6028da","","",true, this);
 
            CollectionInit params_ResponsibleTaskAssignations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb8589fb-f936-475b-8b89-2eb871858d8b",CSSSelectorGrid="",XPathGrid=""};
            ResponsibleTaskAssignations = RPSControlFactory.RPSCreateCollectionWithGrid<ResponsibleTaskAssignationsCollectionEditor<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView>,VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView>( params_ResponsibleTaskAssignations,this,Screen.ResponsibleTaskAssignationView);
 

        }
        public IRPSSaveButton<VersionResponsibleListsVMEntityView> SaveButton { get; set; } 
        public IRPSButton<VersionResponsibleListsVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<VersionResponsibleListsVMEntityView,VersionResponsibleListsVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VersionResponsibleListsVMEntityView,VersionResponsibleListsVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<VersionResponsibleListsVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<VersionResponsibleListsVMEntityView> IDQualityDocumentType { get; set; } 
        public IRPSTextBox<VersionResponsibleListsVMEntityView> ApprOrder { get; set; } 
        public IRPSCheckbox<VersionResponsibleListsVMEntityView> Approval { get; set; } 
        public IRPSCheckbox<VersionResponsibleListsVMEntityView> Revise { get; set; } 
        public IRPSCheckbox<VersionResponsibleListsVMEntityView> Receipt { get; set; } 
        public IRPSCheckbox<VersionResponsibleListsVMEntityView> ModifyFinishedVersions { get; set; } 
        public ResponsibleTaskAssignationsCollectionEditor<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView> ResponsibleTaskAssignations { get; set; } 
        public VersionResponsibleLists Screen { get; set; }
        public VersionResponsibleListsVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ResponsibleTaskAssignationsCollectionEditor<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView>:RPSCollectionEditor<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView> where VersionResponsibleListsVMEntityView : class, IView where ResponsibleTaskAssignationView : class, IView
    {
        public  ResponsibleTaskAssignationsGridView<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView> GridView {get;set;}
    }
    public partial class ResponsibleTaskAssignationsGridView <VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView> :  RPSGridView<VersionResponsibleListsVMEntityView,ResponsibleTaskAssignationView> where VersionResponsibleListsVMEntityView : class, IView where ResponsibleTaskAssignationView : class, IView
    {
        public ResponsibleTaskAssignationsGridView(VersionResponsibleListsVMEntityView currentView,ResponsibleTaskAssignationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<VersionResponsibleListsVMEntityView>("","#eb8589fb-f936-475b-8b89-2eb871858d8b .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            CodRole = RPSControlFactory.CreateRPSGridComboBox<VersionResponsibleListsVMEntityView>("","#eb8589fb-f936-475b-8b89-2eb871858d8b .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<VersionResponsibleListsVMEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<VersionResponsibleListsVMEntityView> CodRole { get; set; } 
                     
    }
 
    }
  
            
    public partial class ResponsibleTaskAssignationView : View
    {
        public ResponsibleTaskAssignationView(VersionResponsibleLists screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ResponsibleTaskAssignationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView>( this,Screen.VersionResponsibleListsVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView>( this,Screen.VersionResponsibleListsVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView>( this,Screen.VersionResponsibleListsVMEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ResponsibleTaskAssignationView>("38dbb52b-863a-4d4f-b51a-4bb9a8104377","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<ResponsibleTaskAssignationView>("812ca3e1-2796-45ca-a777-c4cd8de08ee0","","",false, this);
 

        }
        public IRPSButton<ResponsibleTaskAssignationView> DeleteButton { get; set; } 
        public IRPSButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ResponsibleTaskAssignationView,VersionResponsibleListsVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ResponsibleTaskAssignationView> CodUser { get; set; } 
        public IRPSComboBox<ResponsibleTaskAssignationView> CodRole { get; set; } 
        public VersionResponsibleLists Screen { get; set; }
        public ResponsibleTaskAssignationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}