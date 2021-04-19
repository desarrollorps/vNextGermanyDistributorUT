    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Site
{
    //RPS VERSION 1.0.0.0
    public partial class Site:Screen
    {
        public Site():base()
        {
            this.URL = "general.site";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SiteCollectionView  = new SiteCollectionView(this); 
            SiteEntityView  = new SiteEntityView(this); 
            SiteCollectionView.InitializeControls(); 
            SiteEntityView.InitializeControls(); 
           
        }
      
            public SiteCollectionView SiteCollectionView {get; set; } 
            public SiteEntityView SiteEntityView {get; set; } 
    }
            
    public partial class SiteCollectionView : View
    {
        public SiteCollectionView(Site screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SiteCollectionView,SiteEntityView>( this,Screen.SiteEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "82cc81c7-3905-4c52-9f4d-a16f757cbe58",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SiteCollectionView,SiteEntityView>( params_MainConsult,this,Screen.SiteEntityView);
 

        }
        public IRPSButton<SiteCollectionView,SiteEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SiteCollectionView,SiteEntityView> MainConsult { get; set; } 
        public Site Screen { get; set; }
        public SiteCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SiteEntityView : View
    {
        public SiteEntityView(Site screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SiteEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SiteEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SiteEntityView,SiteCollectionView>( this,Screen.SiteCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SiteEntityView,SiteCollectionView>( this,Screen.SiteCollectionView);
 
            CodSite = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("60e80007-be6c-43c2-925e-d07f9ffbad57","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("4692ca21-897c-44d7-865d-4078f193c915","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SiteEntityView>("df0dd208-7dfe-4c5c-b362-184101505d89","","",false, this);
 
            IDWarehouseQuality = RPSControlFactory.CreateRPSComboBox<SiteEntityView>("437be89d-1236-4d20-9ce1-7163f5d0aed4","","",false, this);
 
            IDWarehouseReject = RPSControlFactory.CreateRPSComboBox<SiteEntityView>("649c92de-b75a-44b4-8fac-9ced335a3dce","","",false, this);
 
            MRPCodUser = RPSControlFactory.CreateRPSComboBox<SiteEntityView>("a381649f-4323-4232-ac28-5f77f5ad0ee4","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<SiteEntityView>("5c51ccf0-0a42-4026-89ff-375766455f39","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("5b48905f-5869-466d-8ff8-c49945b67dbc","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("4beea8e4-f05c-4aa3-81a8-ae3e2c9fa18f","","",false, this);
 
            StartDateHol = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("2879d944-9f3b-4e2f-bd9e-65812af4523a","","",false, this);
 
            EndDateHol = RPSControlFactory.CreateRPSTextBox<SiteEntityView>("eec35a58-1c59-4536-8d2e-5688b5e90923","","",false, this);
 
            BasicData = RPSControlFactory.CreateRPSSection<SiteEntityView>( "","ul li[rpsid='46198213-b789-43e9-91ac-55cd271874f3']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<SiteEntityView>( "","ul li[rpsid='cc07f16b-7c9f-4206-99bb-678f63abdb0d']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<SiteEntityView>( "","ul li[rpsid='ea80e663-fcfc-49aa-a7ba-550148396967']","",this);
 

        }
        public IRPSSaveButton<SiteEntityView> SaveButton { get; set; } 
        public IRPSButton<SiteEntityView> DeleteButton { get; set; } 
        public IRPSButton<SiteEntityView,SiteCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SiteEntityView,SiteCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SiteEntityView> CodSite { get; set; } 
        public IRPSTextBox<SiteEntityView> Description { get; set; } 
        public IRPSComboBox<SiteEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<SiteEntityView> IDWarehouseQuality { get; set; } 
        public IRPSComboBox<SiteEntityView> IDWarehouseReject { get; set; } 
        public IRPSComboBox<SiteEntityView> MRPCodUser { get; set; } 
        public IRPSComboBox<SiteEntityView> IDCalendar { get; set; } 
        public IRPSTextBox<SiteEntityView> Comment { get; set; } 
        public IRPSTextBox<SiteEntityView> Comments { get; set; } 
        public IRPSTextBox<SiteEntityView> StartDateHol { get; set; } 
        public IRPSTextBox<SiteEntityView> EndDateHol { get; set; } 
        public IRPSSection<SiteEntityView> BasicData { get; set; } 
        public IRPSSection<SiteEntityView> Comments1 { get; set; } 
        public IRPSSection<SiteEntityView> DPS { get; set; } 
        public Site Screen { get; set; }
        public SiteEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}