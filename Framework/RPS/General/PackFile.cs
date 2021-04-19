    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.PackFile
{
    //RPS VERSION 1.0.0.0
    public partial class PackFile:Screen
    {
        public PackFile():base()
        {
            this.URL = "general.packfile";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PackFileCollectionView  = new PackFileCollectionView(this); 
            PackFileEntityView  = new PackFileEntityView(this); 
            ExternalUsersDialogView  = new ExternalUsersDialogView(this); 
            FileUploadDialogView  = new FileUploadDialogView(this); 
            PackFileCollectionView.InitializeControls(); 
            PackFileEntityView.InitializeControls(); 
            ExternalUsersDialogView.InitializeControls(); 
            FileUploadDialogView.InitializeControls(); 
           
        }
      
            public PackFileCollectionView PackFileCollectionView {get; set; } 
            public PackFileEntityView PackFileEntityView {get; set; } 
            public ExternalUsersDialogView ExternalUsersDialogView {get; set; } 
            public FileUploadDialogView FileUploadDialogView {get; set; } 
    }
            
    public partial class PackFileCollectionView : View
    {
        public PackFileCollectionView(PackFile screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PackFileCollectionView,PackFileEntityView>( this,Screen.PackFileEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d7366aca-305d-4e0d-84c0-4c9b99308dae",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PackFileCollectionView,PackFileEntityView>( params_MainConsult,this,Screen.PackFileEntityView);
 

        }
        public IRPSButton<PackFileCollectionView,PackFileEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PackFileCollectionView,PackFileEntityView> MainConsult { get; set; } 
        public PackFile Screen { get; set; }
        public PackFileCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PackFileEntityView : View
    {
        public PackFileEntityView(PackFile screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PackFileEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PackFileEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PackFileEntityView,PackFileCollectionView>( this,Screen.PackFileCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PackFileEntityView,PackFileCollectionView>( this,Screen.PackFileCollectionView);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<PackFileEntityView>("ad692509-800a-47af-ba0c-594ebba47a19","","",true, this);
 
            DaysOfValidity = RPSControlFactory.CreateRPSFormattedTextBox<PackFileEntityView>("4af982da-efb6-4075-a02a-7d02756a8a29","","",true, this);
 
            PublicationDate = RPSControlFactory.CreateRPSTextBox<PackFileEntityView>("7e6add61-1c89-42b8-aff0-cb547e18a396","","",false, this);
 
            DownloadFile = RPSControlFactory.CreateRPSTextBox<PackFileEntityView>("51b088c9-0c93-4a15-85fb-ba7d0814caa2","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PackFileEntityView>("20ecc914-0c85-4b28-82fb-6b32e1d6764e","","",false, this);
 
            AddExternalUsersButton = RPSControlFactory.CreateRPSButtonToView<PackFileEntityView,ExternalUsersDialogView>("e88dbb0d-56fa-4e66-b79b-18914d914b25","","", this,Screen.ExternalUsersDialogView);
 
            FileUploadNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PackFileEntityView,FileUploadDialogView>("6414bbba-b1de-49c3-9491-1380532b5989","","", this,Screen.FileUploadDialogView);
 
            ExecutePublishPackFileButton = RPSControlFactory.CreateRPSButton<PackFileEntityView>( "b6742053-e460-49fc-b0b4-d5c58bfeec5c","","",this);
 
            ExecuteDeactivatePackFileButton = RPSControlFactory.CreateRPSButton<PackFileEntityView>( "2c87e5cf-59c8-4062-ae7c-cce7338aae64","","",this);
 
            DownloadCommandButton = RPSControlFactory.CreateRPSButton<PackFileEntityView>( "a8f62514-d2df-421d-8c43-7823f587ec50","","",this);
 
            DeletePackFileCommandButton = RPSControlFactory.CreateRPSButton<PackFileEntityView>( "583b4ee6-8cc1-4113-9cf2-535e132a08d0","","",this);
 
            CollectionInit params_PackFileUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="33beef40-1410-4b28-ae8a-d7e1b37798cd",CSSSelectorGrid="",XPathGrid=""};
            PackFileUsers = RPSControlFactory.RPSCreateCollectionWithGrid<PackFileUsersCollectionEditor<PackFileEntityView,ExternalUsersDialogView>,PackFileEntityView,ExternalUsersDialogView>( params_PackFileUsers,this,Screen.ExternalUsersDialogView);
 
            CollectionInit params_PackFileContents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e95d645-5e21-45a2-9e3a-5c2f33726d11",CSSSelectorGrid="",XPathGrid=""};
            PackFileContents = RPSControlFactory.RPSCreateCollectionWithGrid<PackFileContentsCollectionEditor<PackFileEntityView,ExternalUsersDialogView>,PackFileEntityView,ExternalUsersDialogView>( params_PackFileContents,this,Screen.ExternalUsersDialogView);
 
            CollectionInit params_PackFileDownloads = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7fdb4fc9-c907-4f6c-96e8-d2ebc636bd91",CSSSelectorGrid="",XPathGrid=""};
            PackFileDownloads = RPSControlFactory.RPSCreateCollectionWithGrid<PackFileDownloadsCollectionEditor<PackFileEntityView,ExternalUsersDialogView>,PackFileEntityView,ExternalUsersDialogView>( params_PackFileDownloads,this,Screen.ExternalUsersDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PackFileEntityView>( "","ul li[rpsid='1b687618-48f7-491b-9f72-7910c7bb48df']","",this);
 
            Users = RPSControlFactory.CreateRPSSection<PackFileEntityView>( "","ul li[rpsid='8b603bc0-ac7e-4e59-9d9f-3ec37c4302e8']","",this);
 
            Content = RPSControlFactory.CreateRPSSection<PackFileEntityView>( "","ul li[rpsid='a2ba4420-8587-4b60-af57-e2f39998143f']","",this);
 
            Downloads = RPSControlFactory.CreateRPSSection<PackFileEntityView>( "","ul li[rpsid='33055d63-5b40-4e4f-a5d3-a5bcdd5a9847']","",this);
 

        }
        public IRPSSaveButton<PackFileEntityView> SaveButton { get; set; } 
        public IRPSButton<PackFileEntityView> DeleteButton { get; set; } 
        public IRPSButton<PackFileEntityView,PackFileCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PackFileEntityView,PackFileCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PackFileEntityView> CreationDate { get; set; } 
        public IRPSTextBox<PackFileEntityView> DaysOfValidity { get; set; } 
        public IRPSTextBox<PackFileEntityView> PublicationDate { get; set; } 
        public IRPSTextBox<PackFileEntityView> DownloadFile { get; set; } 
        public IRPSTextBox<PackFileEntityView> Comment { get; set; } 
        public IRPSButton<PackFileEntityView,ExternalUsersDialogView> AddExternalUsersButton { get; set; } 
        public IRPSButton<PackFileEntityView,FileUploadDialogView> FileUploadNavigationCommandButton { get; set; } 
        public IRPSButton<PackFileEntityView> ExecutePublishPackFileButton { get; set; } 
        public IRPSButton<PackFileEntityView> ExecuteDeactivatePackFileButton { get; set; } 
        public IRPSButton<PackFileEntityView> DownloadCommandButton { get; set; } 
        public IRPSButton<PackFileEntityView> DeletePackFileCommandButton { get; set; } 
        public PackFileUsersCollectionEditor<PackFileEntityView,ExternalUsersDialogView> PackFileUsers { get; set; } 
        public PackFileContentsCollectionEditor<PackFileEntityView,ExternalUsersDialogView> PackFileContents { get; set; } 
        public PackFileDownloadsCollectionEditor<PackFileEntityView,ExternalUsersDialogView> PackFileDownloads { get; set; } 
        public IRPSSection<PackFileEntityView> GeneralData { get; set; } 
        public IRPSSection<PackFileEntityView> Users { get; set; } 
        public IRPSSection<PackFileEntityView> Content { get; set; } 
        public IRPSSection<PackFileEntityView> Downloads { get; set; } 
        public PackFile Screen { get; set; }
        public PackFileEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackFileUsersCollectionEditor<PackFileEntityView,ExternalUsersDialogView>:RPSCollectionEditor<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public  PackFileUsersGridView<PackFileEntityView,ExternalUsersDialogView> GridView {get;set;}
    }
    public partial class PackFileUsersGridView <PackFileEntityView,ExternalUsersDialogView> :  RPSGridView<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public PackFileUsersGridView(PackFileEntityView currentView,ExternalUsersDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<PackFileEntityView>("","#33beef40-1410-4b28-ae8a-d7e1b37798cd .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PackFileEntityView> CodUser { get; set; } 
                     
    }
 
        public partial class PackFileContentsCollectionEditor<PackFileEntityView,ExternalUsersDialogView>:RPSCollectionEditor<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public  PackFileContentsGridView<PackFileEntityView,ExternalUsersDialogView> GridView {get;set;}
    }
    public partial class PackFileContentsGridView <PackFileEntityView,ExternalUsersDialogView> :  RPSGridView<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public PackFileContentsGridView(PackFileEntityView currentView,ExternalUsersDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FileName = RPSControlFactory.CreateRPSGridTextBox<PackFileEntityView>("","#1e95d645-5e21-45a2-9e3a-5c2f33726d11 .ag-row[role='row']@ROWINDEX [col-id='cFileName']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<PackFileEntityView>("","#1e95d645-5e21-45a2-9e3a-5c2f33726d11 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            UploadDate = RPSControlFactory.CreateRPSGridTextBox<PackFileEntityView>("","#1e95d645-5e21-45a2-9e3a-5c2f33726d11 .ag-row[role='row']@ROWINDEX [col-id='cUploadDate']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackFileEntityView> FileName { get; set; } 
        public IRPSGridComboBox<PackFileEntityView> Type { get; set; } 
        public IRPSGridTextBox<PackFileEntityView> UploadDate { get; set; } 
                     
    }
 
        public partial class PackFileDownloadsCollectionEditor<PackFileEntityView,ExternalUsersDialogView>:RPSCollectionEditor<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public  PackFileDownloadsGridView<PackFileEntityView,ExternalUsersDialogView> GridView {get;set;}
    }
    public partial class PackFileDownloadsGridView <PackFileEntityView,ExternalUsersDialogView> :  RPSGridView<PackFileEntityView,ExternalUsersDialogView> where PackFileEntityView : class, IView where ExternalUsersDialogView : class, IView
    {
        public PackFileDownloadsGridView(PackFileEntityView currentView,ExternalUsersDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<PackFileEntityView>("","#7fdb4fc9-c907-4f6c-96e8-d2ebc636bd91 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            DownloadDate = RPSControlFactory.CreateRPSGridTextBox<PackFileEntityView>("","#7fdb4fc9-c907-4f6c-96e8-d2ebc636bd91 .ag-row[role='row']@ROWINDEX [col-id='cDownloadDate']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PackFileEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<PackFileEntityView> DownloadDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class ExternalUsersDialogView : View
    {
        public ExternalUsersDialogView(PackFile screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ExternalUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fcd3d703-5e11-4ff9-8840-c2b6f747af74",CSSSelectorGrid="",XPathGrid=""};
            ExternalUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalUsersCollectionEditor<ExternalUsersDialogView>,ExternalUsersDialogView>( params_ExternalUsers,this);
 

        }
        public ExternalUsersCollectionEditor<ExternalUsersDialogView> ExternalUsers { get; set; } 
        public PackFile Screen { get; set; }
        public ExternalUsersDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ExternalUsersCollectionEditor<ExternalUsersDialogView>:RPSCollectionEditor<ExternalUsersDialogView> where ExternalUsersDialogView : class, IView
    {
        public  ExternalUsersGridView<ExternalUsersDialogView> GridView {get;set;}
    }
    public partial class ExternalUsersGridView <ExternalUsersDialogView> :  RPSGridView<ExternalUsersDialogView> where ExternalUsersDialogView : class, IView
    {
        public ExternalUsersGridView(ExternalUsersDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExternalUserDescription = RPSControlFactory.CreateRPSGridTextBox<ExternalUsersDialogView>("","#fcd3d703-5e11-4ff9-8840-c2b6f747af74 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserDescription']","",false, this.CurrentView);
 
            ExternalUserEmailToInvite = RPSControlFactory.CreateRPSGridEmailTextBox<ExternalUsersDialogView>("","#fcd3d703-5e11-4ff9-8840-c2b6f747af74 .ag-row[role='row']@ROWINDEX [col-id='cExternalUserEmailToInvite']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ExternalUsersDialogView> ExternalUserDescription { get; set; } 
        public IRPSGridTextBox<ExternalUsersDialogView> ExternalUserEmailToInvite { get; set; } 
                     
    }
 
    }
  
            
    public partial class FileUploadDialogView : View
    {
        public FileUploadDialogView(PackFile screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocument = RPSControlFactory.CreateRPSComboBox<FileUploadDialogView>("607df31d-cf5d-4c25-acce-1aa5aee51b32","","",false, this);
 
            AddGDocCommand = RPSControlFactory.CreateRPSButton<FileUploadDialogView>( "36c2e127-f219-4abe-b0b2-5b698e629ec7","","",this);
 
            IDDocumentCategory = RPSControlFactory.CreateRPSComboBox<FileUploadDialogView>("85c70b31-6ed3-4de5-b285-f8c491944a5b","","",false, this);
 
            AddCategoryCommand = RPSControlFactory.CreateRPSButton<FileUploadDialogView>( "71ccd4c7-56da-460f-b10e-3217c4940d1a","","",this);
 
            CollectionInit params_GDocDocuments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            GDocDocuments = RPSControlFactory.RPSCreateCollection<FileUploadDialogView>( params_GDocDocuments,this);
 
            CollectionInit params_GDocCategories = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            GDocCategories = RPSControlFactory.RPSCreateCollection<FileUploadDialogView>( params_GDocCategories,this);
 

        }
        public IRPSComboBox<FileUploadDialogView> IDDocument { get; set; } 
        public IRPSButton<FileUploadDialogView> AddGDocCommand { get; set; } 
        public IRPSComboBox<FileUploadDialogView> IDDocumentCategory { get; set; } 
        public IRPSButton<FileUploadDialogView> AddCategoryCommand { get; set; } 
        public IRPSCollectionEditor<FileUploadDialogView> GDocDocuments { get; set; } 
        public IRPSCollectionEditor<FileUploadDialogView> GDocCategories { get; set; } 
        public PackFile Screen { get; set; }
        public FileUploadDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}