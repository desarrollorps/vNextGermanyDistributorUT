    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProManUsualTest
{
    //RPS VERSION 1.0.0.0
    public partial class ProManUsualTest:Screen
    {
        public ProManUsualTest():base()
        {
            this.URL = "project.promanusualtest";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UsualTestCollectionView  = new UsualTestCollectionView(this); 
            UsualTestEntityView  = new UsualTestEntityView(this); 
            UsualTestDetailView  = new UsualTestDetailView(this); 
            UsualTestCollectionView.InitializeControls(); 
            UsualTestEntityView.InitializeControls(); 
            UsualTestDetailView.InitializeControls(); 
           
        }
      
            public UsualTestCollectionView UsualTestCollectionView {get; set; } 
            public UsualTestEntityView UsualTestEntityView {get; set; } 
            public UsualTestDetailView UsualTestDetailView {get; set; } 
    }
            
    public partial class UsualTestCollectionView : View
    {
        public UsualTestCollectionView(ProManUsualTest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UsualTestCollectionView,UsualTestEntityView>( this,Screen.UsualTestEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "850b6c8c-c218-4e33-b097-4fc02ac5d89c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UsualTestCollectionView,UsualTestEntityView>( params_MainConsult,this,Screen.UsualTestEntityView);
 

        }
        public IRPSButton<UsualTestCollectionView,UsualTestEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UsualTestCollectionView,UsualTestEntityView> MainConsult { get; set; } 
        public ProManUsualTest Screen { get; set; }
        public UsualTestCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UsualTestEntityView : View
    {
        public UsualTestEntityView(ProManUsualTest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UsualTestEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UsualTestEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UsualTestEntityView,UsualTestCollectionView>( this,Screen.UsualTestCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UsualTestEntityView,UsualTestCollectionView>( this,Screen.UsualTestCollectionView);
 
            CodUsualTest = RPSControlFactory.CreateRPSTextBox<UsualTestEntityView>("fa6b4828-6897-4377-a549-6848d530387c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UsualTestEntityView>("42ba02ed-5ec9-4715-ad6b-ab41fe8f454a","","",false, this);
 
            CollectionInit params_UsualTestDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="594f549b-81ed-4fea-95f2-068e4ec4d912",CSSSelectorGrid="",XPathGrid=""};
            UsualTestDetails = RPSControlFactory.RPSCreateCollectionWithGrid<UsualTestDetailsCollectionEditor<UsualTestEntityView,UsualTestDetailView>,UsualTestEntityView,UsualTestDetailView>( params_UsualTestDetails,this,Screen.UsualTestDetailView);
 

        }
        public IRPSSaveButton<UsualTestEntityView> SaveButton { get; set; } 
        public IRPSButton<UsualTestEntityView> DeleteButton { get; set; } 
        public IRPSButton<UsualTestEntityView,UsualTestCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UsualTestEntityView,UsualTestCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UsualTestEntityView> CodUsualTest { get; set; } 
        public IRPSTextBox<UsualTestEntityView> Description { get; set; } 
        public UsualTestDetailsCollectionEditor<UsualTestEntityView,UsualTestDetailView> UsualTestDetails { get; set; } 
        public ProManUsualTest Screen { get; set; }
        public UsualTestEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UsualTestDetailsCollectionEditor<UsualTestEntityView,UsualTestDetailView>:RPSCollectionEditor<UsualTestEntityView,UsualTestDetailView> where UsualTestEntityView : class, IView where UsualTestDetailView : class, IView
    {
        public  UsualTestDetailsGridView<UsualTestEntityView,UsualTestDetailView> GridView {get;set;}
    }
    public partial class UsualTestDetailsGridView <UsualTestEntityView,UsualTestDetailView> :  RPSGridView<UsualTestEntityView,UsualTestDetailView> where UsualTestEntityView : class, IView where UsualTestDetailView : class, IView
    {
        public UsualTestDetailsGridView(UsualTestEntityView currentView,UsualTestDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTestEntityView>("","#594f549b-81ed-4fea-95f2-068e4ec4d912 .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",true, this.CurrentView);
 
            IDControlType = RPSControlFactory.CreateRPSGridComboBox<UsualTestEntityView>("","#594f549b-81ed-4fea-95f2-068e4ec4d912 .ag-row[role='row']@ROWINDEX [col-id='cIDControlType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<UsualTestEntityView>("","#594f549b-81ed-4fea-95f2-068e4ec4d912 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTestEntityView>("","#594f549b-81ed-4fea-95f2-068e4ec4d912 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<UsualTestEntityView>("","#594f549b-81ed-4fea-95f2-068e4ec4d912 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UsualTestEntityView> NumLine { get; set; } 
        public IRPSGridComboBox<UsualTestEntityView> IDControlType { get; set; } 
        public IRPSGridTextBox<UsualTestEntityView> Description { get; set; } 
        public IRPSGridTextBox<UsualTestEntityView> Order { get; set; } 
        public IRPSGridTextBox<UsualTestEntityView> Notes { get; set; } 
                     
    }
 
    }
  
            
    public partial class UsualTestDetailView : View
    {
        public UsualTestDetailView(ProManUsualTest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<UsualTestDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UsualTestDetailView,UsualTestEntityView>( this,Screen.UsualTestEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<UsualTestDetailView,UsualTestEntityView>( this,Screen.UsualTestEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<UsualTestDetailView,UsualTestEntityView>( this,Screen.UsualTestEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<UsualTestDetailView>("ceb9e63c-9510-49b6-ab96-4a8f65a2df17","","",false, this);
 
            IDControlType = RPSControlFactory.CreateRPSComboBox<UsualTestDetailView>("ef40b8f4-20cf-4dbc-ab07-99b4696d08b2","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<UsualTestDetailView>("ef1aa26d-8274-4898-87b3-7e9f317cc764","","",true, this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<UsualTestDetailView>("f420bda4-702c-485d-a56e-6203be22741e","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<UsualTestDetailView>("3a9b5254-0525-49f5-9286-286e4e450ed4","","",false, this);
 

        }
        public IRPSButton<UsualTestDetailView> DeleteButton { get; set; } 
        public IRPSButton<UsualTestDetailView,UsualTestEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UsualTestDetailView,UsualTestEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<UsualTestDetailView,UsualTestEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<UsualTestDetailView> Description { get; set; } 
        public IRPSComboBox<UsualTestDetailView> IDControlType { get; set; } 
        public IRPSTextBox<UsualTestDetailView> Order { get; set; } 
        public IRPSTextBox<UsualTestDetailView> NumLine { get; set; } 
        public IRPSTextBox<UsualTestDetailView> Notes { get; set; } 
        public ProManUsualTest Screen { get; set; }
        public UsualTestDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}