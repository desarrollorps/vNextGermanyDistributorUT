    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ArticleQualityManagement
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleQualityManagement:Screen
    {
        public ArticleQualityManagement():base()
        {
            this.URL = "quality.articlequalitymanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleVersionView  = new ArticleVersionView(this); 
            ArticleResidueControlView  = new ArticleResidueControlView(this); 
            ArticleResidueView  = new ArticleResidueView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleVersionView.InitializeControls(); 
            ArticleResidueControlView.InitializeControls(); 
            ArticleResidueView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleVersionView ArticleVersionView {get; set; } 
            public ArticleResidueControlView ArticleResidueControlView {get; set; } 
            public ArticleResidueView ArticleResidueView {get; set; } 
    }
            
    public partial class ArticleCollectionView : View
    {
        public ArticleCollectionView(ArticleQualityManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleCollectionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1c9df615-5ac1-4063-b35a-99a718c7b48e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleCollectionView,ArticleEntityView>( params_MainConsult,this,Screen.ArticleEntityView);
 

        }
        public IRPSButton<ArticleCollectionView,ArticleEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleCollectionView,ArticleEntityView> MainConsult { get; set; } 
        public ArticleQualityManagement Screen { get; set; }
        public ArticleCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleEntityView : View
    {
        public ArticleEntityView(ArticleQualityManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            CollectionInit params_ArticleVersions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="17d603e6-2c35-40bb-9dfd-4717940d9237",CSSSelectorGrid="",XPathGrid=""};
            ArticleVersions = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleVersionsCollectionEditor<ArticleEntityView,ArticleVersionView>,ArticleEntityView,ArticleVersionView>( params_ArticleVersions,this,Screen.ArticleVersionView);
 
            CollectionInit params_ArticleResidues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="66c279a4-ab62-4165-a875-2774858fddf1",CSSSelectorGrid="",XPathGrid=""};
            ArticleResidues = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleResiduesCollectionEditor<ArticleEntityView,ArticleVersionView>,ArticleEntityView,ArticleVersionView>( params_ArticleResidues,this,Screen.ArticleVersionView);
 
            CollectionInit params_ArticleResidueControls = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3fb3eff4-3a70-461b-b9cb-adebd5e3576f",CSSSelectorGrid="",XPathGrid=""};
            ArticleResidueControls = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleResidueControlsCollectionEditor<ArticleEntityView,ArticleVersionView>,ArticleEntityView,ArticleVersionView>( params_ArticleResidueControls,this,Screen.ArticleVersionView);
 
            Versions = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='6bf0f821-e936-4136-8b2d-8186bbe47eec']","",this);
 
            TreatmentOfResidue = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='8d298149-26d9-4212-b4c2-7554bc7a4fde']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public ArticleVersionsCollectionEditor<ArticleEntityView,ArticleVersionView> ArticleVersions { get; set; } 
        public ArticleResiduesCollectionEditor<ArticleEntityView,ArticleVersionView> ArticleResidues { get; set; } 
        public ArticleResidueControlsCollectionEditor<ArticleEntityView,ArticleVersionView> ArticleResidueControls { get; set; } 
        public IRPSSection<ArticleEntityView> Versions { get; set; } 
        public IRPSSection<ArticleEntityView> TreatmentOfResidue { get; set; } 
        public ArticleQualityManagement Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleVersionsCollectionEditor<ArticleEntityView,ArticleVersionView>:RPSCollectionEditor<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public  ArticleVersionsGridView<ArticleEntityView,ArticleVersionView> GridView {get;set;}
    }
    public partial class ArticleVersionsGridView <ArticleEntityView,ArticleVersionView> :  RPSGridView<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public ArticleVersionsGridView(ArticleEntityView currentView,ArticleVersionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Source = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cSource']","",false, this.CurrentView);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cIDStructureManufacturing']","",false, this.CurrentView);
 
            IDProject = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cIDProject']","",false, this.CurrentView);
 
            DoneDate = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cDoneDate']","",true, this.CurrentView);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cCodUserDoneBy']","",false, this.CurrentView);
 
            ApprovedDate = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cApprovedDate']","",false, this.CurrentView);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cCodUserApprovedBy']","",false, this.CurrentView);
 
            Obsolete = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#17d603e6-2c35-40bb-9dfd-4717940d9237 .ag-row[role='row']@ROWINDEX [col-id='cObsolete']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleEntityView> Version { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Source { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDStructureManufacturing { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDProject { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> DoneDate { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> CodUserDoneBy { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> ApprovedDate { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> CodUserApprovedBy { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> Obsolete { get; set; } 
                     
    }
 
        public partial class ArticleResiduesCollectionEditor<ArticleEntityView,ArticleVersionView>:RPSCollectionEditor<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public  ArticleResiduesGridView<ArticleEntityView,ArticleVersionView> GridView {get;set;}
    }
    public partial class ArticleResiduesGridView <ArticleEntityView,ArticleVersionView> :  RPSGridView<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public ArticleResiduesGridView(ArticleEntityView currentView,ArticleVersionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleManufactured = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#66c279a4-ab62-4165-a875-2774858fddf1 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleManufactured']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#66c279a4-ab62-4165-a875-2774858fddf1 .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IDItemTaskSelector = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#66c279a4-ab62-4165-a875-2774858fddf1 .ag-row[role='row']@ROWINDEX [col-id='cIDItemTaskSelector']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDArticleManufactured { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDItemTaskSelector { get; set; } 
                     
    }
 
        public partial class ArticleResidueControlsCollectionEditor<ArticleEntityView,ArticleVersionView>:RPSCollectionEditor<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public  ArticleResidueControlsGridView<ArticleEntityView,ArticleVersionView> GridView {get;set;}
    }
    public partial class ArticleResidueControlsGridView <ArticleEntityView,ArticleVersionView> :  RPSGridView<ArticleEntityView,ArticleVersionView> where ArticleEntityView : class, IView where ArticleVersionView : class, IView
    {
        public ArticleResidueControlsGridView(ArticleEntityView currentView,ArticleVersionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumActivity = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#3fb3eff4-3a70-461b-b9cb-adebd5e3576f .ag-row[role='row']@ROWINDEX [col-id='cNumActivity']","",true, this.CurrentView);
 
            Activity = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#3fb3eff4-3a70-461b-b9cb-adebd5e3576f .ag-row[role='row']@ROWINDEX [col-id='cActivity']","",true, this.CurrentView);
 
            ResponsibleType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#3fb3eff4-3a70-461b-b9cb-adebd5e3576f .ag-row[role='row']@ROWINDEX [col-id='cResponsibleType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#3fb3eff4-3a70-461b-b9cb-adebd5e3576f .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            Observation = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#3fb3eff4-3a70-461b-b9cb-adebd5e3576f .ag-row[role='row']@ROWINDEX [col-id='cObservation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleEntityView> NumActivity { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Activity { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> ResponsibleType { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Observation { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleVersionView : View
    {
        public ArticleVersionView(ArticleQualityManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleVersionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleVersionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleVersionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleVersionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<ArticleVersionView>("b97a8736-4c1d-4d4d-b99b-2ec00a1fa0a3","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("65237486-5c62-4ed6-b774-04fe34620b38","","",true, this);
 
            Source = RPSControlFactory.CreateRPSEnumComboBox<ArticleVersionView>("0dbaab8c-8b25-4056-93a5-57f096fa788f","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ArticleVersionView>("cdb63499-c8ee-4d32-b6af-6d5fba573efc","","",false, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<ArticleVersionView>("93cbf9c0-ba67-41d9-991d-529b3fce5a93","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("920966d3-7316-498a-a101-8c8e4b696037","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("83149ab4-43ed-4d3a-8e5e-f0fdf0445238","","",false, this);
 
            DrawingDate = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("2af65c06-78c4-4092-a526-2f7f7aa6239e","","",false, this);
 
            DrawingLevel = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("c36628b2-c599-465f-9828-f4044fd63c33","","",false, this);
 
            Drawing = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("67ee1853-6c6b-45b4-9666-7ef2d38a596a","","",false, this);
 
            IDStatusDrawing = RPSControlFactory.CreateRPSComboBox<ArticleVersionView>("54d030f6-1d97-4364-a3a4-807df288d73f","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<ArticleVersionView>("b5c3b889-1971-4afe-80be-5baf583965f3","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("eed9c624-08ae-40b9-828c-967a42e8198d","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("7b1fd31d-a283-457b-a143-0625c52d4145","","",false, this);
 
            PendingRevision = RPSControlFactory.CreateRPSCheckBox<ArticleVersionView>("fc0e4b74-ba9a-4d45-baa8-b9899ee8b8ad","","",false, this);
 
            Obsolete = RPSControlFactory.CreateRPSCheckBox<ArticleVersionView>("d04f2f58-d250-4d5b-af86-84361c818b09","","",false, this);
 
            PendingReceipt = RPSControlFactory.CreateRPSCheckBox<ArticleVersionView>("dbf6789f-226b-45f1-8db5-c208e2335aec","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleVersionView>("1fd4ebb4-76f8-4933-9415-3aba2a127678","","",false, this);
 
            ApproveCommandButton = RPSControlFactory.CreateRPSButton<ArticleVersionView>( "e4c5e793-3fb2-4996-87ab-50d6cff84041","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<ArticleVersionView>( "96e360a1-3326-4164-a3c1-f8151974886d","","",this);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<ArticleVersionView>( "be11c948-52da-46a3-8c68-28f8661e4491","","",this);
 
            Section = RPSControlFactory.CreateRPSSection<ArticleVersionView>( "","ul li[rpsid='2aeb2092-e65e-4884-98b7-fc9e86bc1e54']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ArticleVersionView>( "","ul li[rpsid='b07a6272-859e-47fc-ae38-1a2b521bc35a']","",this);
 

        }
        public IRPSButton<ArticleVersionView> DeleteButton { get; set; } 
        public IRPSButton<ArticleVersionView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleVersionView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleVersionView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleVersionView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<ArticleVersionView> Version { get; set; } 
        public IRPSComboBox<ArticleVersionView> Source { get; set; } 
        public IRPSComboBox<ArticleVersionView> IDProject { get; set; } 
        public IRPSComboBox<ArticleVersionView> IDStructureManufacturing { get; set; } 
        public IRPSTextBox<ArticleVersionView> DoneDate { get; set; } 
        public IRPSTextBox<ArticleVersionView> Description { get; set; } 
        public IRPSTextBox<ArticleVersionView> DrawingDate { get; set; } 
        public IRPSTextBox<ArticleVersionView> DrawingLevel { get; set; } 
        public IRPSTextBox<ArticleVersionView> Drawing { get; set; } 
        public IRPSComboBox<ArticleVersionView> IDStatusDrawing { get; set; } 
        public IRPSComboBox<ArticleVersionView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<ArticleVersionView> ApprovedDate { get; set; } 
        public IRPSTextBox<ArticleVersionView> PendingRevisionCause { get; set; } 
        public IRPSCheckbox<ArticleVersionView> PendingRevision { get; set; } 
        public IRPSCheckbox<ArticleVersionView> Obsolete { get; set; } 
        public IRPSCheckbox<ArticleVersionView> PendingReceipt { get; set; } 
        public IRPSTextBox<ArticleVersionView> Notes { get; set; } 
        public IRPSButton<ArticleVersionView> ApproveCommandButton { get; set; } 
        public IRPSButton<ArticleVersionView> ReviseCommandButton { get; set; } 
        public IRPSButton<ArticleVersionView> ReceiptCommandButton { get; set; } 
        public IRPSSection<ArticleVersionView> Section { get; set; } 
        public IRPSSection<ArticleVersionView> Section1 { get; set; } 
        public ArticleQualityManagement Screen { get; set; }
        public ArticleVersionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleResidueControlView : View
    {
        public ArticleResidueControlView(ArticleQualityManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleResidueControlView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleResidueControlView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleResidueControlView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleResidueControlView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            NumActivity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleResidueControlView>("8d10207c-32f3-4c38-abc8-55c8728737a3","","",true, this);
 
            Activity = RPSControlFactory.CreateRPSTextBox<ArticleResidueControlView>("62eb1a5c-57f6-4dff-99e2-43b0aaf68277","","",true, this);
 
            ResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<ArticleResidueControlView>("4ee51d12-512c-4859-babd-6d26fb9d7130","","",true, this);
 
            ResponsibleEmployee = RPSControlFactory.CreateRPSComboBox<ArticleResidueControlView>("f7cddb5a-da2c-4ec9-b540-27b8c3a0dfa7","","",false, this);
 
            ResponsibleQualify = RPSControlFactory.CreateRPSComboBox<ArticleResidueControlView>("95331d2a-0a26-465b-909e-7b1cd7d44908","","",false, this);
 
            ResponsibleSupplier = RPSControlFactory.CreateRPSComboBox<ArticleResidueControlView>("438eb95f-0cb9-4235-a860-b34cca114c45","","",false, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<ArticleResidueControlView>("1fd3f667-0909-4f5e-9e58-960b29dcd877","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<ArticleResidueControlView>( "","ul li[rpsid='c98f5e60-f291-4afa-9813-2383fa906f75']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ArticleResidueControlView>( "","ul li[rpsid='e3011554-6bc8-42ff-95eb-1b722f51e4f5']","",this);
 

        }
        public IRPSButton<ArticleResidueControlView> DeleteButton { get; set; } 
        public IRPSButton<ArticleResidueControlView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleResidueControlView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleResidueControlView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ArticleResidueControlView> NumActivity { get; set; } 
        public IRPSTextBox<ArticleResidueControlView> Activity { get; set; } 
        public IRPSComboBox<ArticleResidueControlView> ResponsibleType { get; set; } 
        public IRPSComboBox<ArticleResidueControlView> ResponsibleEmployee { get; set; } 
        public IRPSComboBox<ArticleResidueControlView> ResponsibleQualify { get; set; } 
        public IRPSComboBox<ArticleResidueControlView> ResponsibleSupplier { get; set; } 
        public IRPSTextBox<ArticleResidueControlView> Observation { get; set; } 
        public IRPSSection<ArticleResidueControlView> Section { get; set; } 
        public IRPSSection<ArticleResidueControlView> Section1 { get; set; } 
        public ArticleQualityManagement Screen { get; set; }
        public ArticleResidueControlView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleResidueView : View
    {
        public ArticleResidueView(ArticleQualityManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleResidueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleResidueView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleResidueView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleResidueView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            IDArticleManufactured = RPSControlFactory.CreateRPSComboBox<ArticleResidueView>("335bc6b1-9e0b-4d80-a0f0-d23c74c0dca9","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ArticleResidueView>("8c18c2d1-6f25-439a-9c96-50048baac194","","",false, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<ArticleResidueView>("54209e32-cc8f-4ecd-942a-35f897de10fa","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<ArticleResidueView>("18cb58a0-83b2-44aa-9721-4c53806b2c41","","",false, this);
 
            ManufacturingTask = RPSControlFactory.CreateRPSComboBox<ArticleResidueView>("e413be9c-8868-47f1-b085-7c3ebc521c56","","",false, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<ArticleResidueView>("68a5c10e-4d12-459c-9e9c-b0de5413315d","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<ArticleResidueView>( "","ul li[rpsid='dd5a66f5-b362-4209-aa20-f36a4ba1dc49']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ArticleResidueView>( "","ul li[rpsid='43de2b36-33a9-4d31-a08d-256fd96c94f2']","",this);
 

        }
        public IRPSButton<ArticleResidueView> DeleteButton { get; set; } 
        public IRPSButton<ArticleResidueView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleResidueView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleResidueView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleResidueView> IDArticleManufactured { get; set; } 
        public IRPSComboBox<ArticleResidueView> IDProject { get; set; } 
        public IRPSComboBox<ArticleResidueView> IDStructureManufacturing { get; set; } 
        public IRPSComboBox<ArticleResidueView> ProjectTask { get; set; } 
        public IRPSComboBox<ArticleResidueView> ManufacturingTask { get; set; } 
        public IRPSTextBox<ArticleResidueView> Observation { get; set; } 
        public IRPSSection<ArticleResidueView> Section { get; set; } 
        public IRPSSection<ArticleResidueView> Section1 { get; set; } 
        public ArticleQualityManagement Screen { get; set; }
        public ArticleResidueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}