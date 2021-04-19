    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.PackFileDownloadCenter
{
    //RPS VERSION 1.0.0.0
    public partial class PackFileDownloadCenter:Screen
    {
        public PackFileDownloadCenter():base()
        {
            this.URL = "general.packfiledownloadcenter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PackFileDownloadCenterQueryView  = new PackFileDownloadCenterQueryView(this); 
            PackFileView  = new PackFileView(this); 
            PackFileDownloadCenterQueryView.InitializeControls(); 
            PackFileView.InitializeControls(); 
           
        }
      
            public PackFileDownloadCenterQueryView PackFileDownloadCenterQueryView {get; set; } 
            public PackFileView PackFileView {get; set; } 
    }
            
    public partial class PackFileDownloadCenterQueryView : View
    {
        public PackFileDownloadCenterQueryView(PackFileDownloadCenter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_PackFileToDownload = new CollectionInit(){IDDescriptor = "b2b6bede-cc77-4a02-b23e-b109e4770643",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f22bf63c-1e76-4321-973b-8d5f99d5f88b",CSSSelectorGrid="",XPathGrid=""};
            PackFileToDownload = RPSControlFactory.RPSCreateCollectionWithGrid<PackFileToDownloadCollectionEditor<PackFileDownloadCenterQueryView>,PackFileDownloadCenterQueryView>( params_PackFileToDownload,this);
 

        }
        public PackFileToDownloadCollectionEditor<PackFileDownloadCenterQueryView> PackFileToDownload { get; set; } 
        public PackFileDownloadCenter Screen { get; set; }
        public PackFileDownloadCenterQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackFileToDownloadCollectionEditor<PackFileDownloadCenterQueryView>:RPSCollectionEditor<PackFileDownloadCenterQueryView> where PackFileDownloadCenterQueryView : class, IView
    {
        public  PackFileToDownloadGridView<PackFileDownloadCenterQueryView> GridView {get;set;}
    }
    public partial class PackFileToDownloadGridView <PackFileDownloadCenterQueryView> :  RPSGridView<PackFileDownloadCenterQueryView> where PackFileDownloadCenterQueryView : class, IView
    {
        public PackFileToDownloadGridView(PackFileDownloadCenterQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DownloadCommand = RPSControlFactory.CreateRPSGridButton<PackFileDownloadCenterQueryView>( "","#f22bf63c-1e76-4321-973b-8d5f99d5f88b .ag-row[role='row']@ROWINDEX [col-id='cDownloadCommand']","",this.CurrentView);
 
            PackFile_PublicationDate = RPSControlFactory.CreateRPSGridTextBox<PackFileDownloadCenterQueryView>("","#f22bf63c-1e76-4321-973b-8d5f99d5f88b .ag-row[role='row']@ROWINDEX [col-id='cPackFile_PublicationDate']","",false, this.CurrentView);
 
            ExpiredDate = RPSControlFactory.CreateRPSGridTextBox<PackFileDownloadCenterQueryView>("","#f22bf63c-1e76-4321-973b-8d5f99d5f88b .ag-row[role='row']@ROWINDEX [col-id='cExpiredDate']","",false, this.CurrentView);
 
            PackFile_Comment = RPSControlFactory.CreateRPSGridMemoTextBox<PackFileDownloadCenterQueryView>("","#f22bf63c-1e76-4321-973b-8d5f99d5f88b .ag-row[role='row']@ROWINDEX [col-id='cPackFile_Comment']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<PackFileDownloadCenterQueryView> DownloadCommand { get; set; } 
        public IRPSGridTextBox<PackFileDownloadCenterQueryView> PackFile_PublicationDate { get; set; } 
        public IRPSGridTextBox<PackFileDownloadCenterQueryView> ExpiredDate { get; set; } 
        public IRPSGridTextBox<PackFileDownloadCenterQueryView> PackFile_Comment { get; set; } 
                     
    }
 
    }
  
            
    public partial class PackFileView : View
    {
        public PackFileView(PackFileDownloadCenter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PackFileView>( this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PackFileView>("6232b7d4-40cf-487f-b97c-dd37a617e0f9","","",false, this);
 
            DownLoadCommandButton = RPSControlFactory.CreateRPSButton<PackFileView>( "74455170-92c6-4b12-94b5-f209b8c84e3a","","",this);
 
            LinkPackFileCommandButton = RPSControlFactory.CreateRPSButton<PackFileView>( "5e0c02b1-9c50-4338-9875-c1a8ca022ed5","","",this);
 

        }
        public IRPSSaveButton<PackFileView> SaveButton { get; set; } 
        public IRPSTextBox<PackFileView> Comment { get; set; } 
        public IRPSButton<PackFileView> DownLoadCommandButton { get; set; } 
        public IRPSButton<PackFileView> LinkPackFileCommandButton { get; set; } 
        public PackFileDownloadCenter Screen { get; set; }
        public PackFileView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}