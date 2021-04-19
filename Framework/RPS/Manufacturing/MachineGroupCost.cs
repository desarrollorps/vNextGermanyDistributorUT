    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MachineGroupCost
{
    //RPS VERSION 1.0.0.0
    public partial class MachineGroupCost:Screen
    {
        public MachineGroupCost():base()
        {
            this.URL = "manufacturing.machinegroupcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineGroupCostCollectionView  = new MachineGroupCostCollectionView(this); 
            MachineGroupCostEntityView  = new MachineGroupCostEntityView(this); 
            MachineGroupCostDetailView  = new MachineGroupCostDetailView(this); 
            MachineGroupCostCollectionView.InitializeControls(); 
            MachineGroupCostEntityView.InitializeControls(); 
            MachineGroupCostDetailView.InitializeControls(); 
           
        }
      
            public MachineGroupCostCollectionView MachineGroupCostCollectionView {get; set; } 
            public MachineGroupCostEntityView MachineGroupCostEntityView {get; set; } 
            public MachineGroupCostDetailView MachineGroupCostDetailView {get; set; } 
    }
            
    public partial class MachineGroupCostCollectionView : View
    {
        public MachineGroupCostCollectionView(MachineGroupCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineGroupCostCollectionView,MachineGroupCostEntityView>( this,Screen.MachineGroupCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "124ae308-9830-4efd-9722-d2242718f4f1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineGroupCostCollectionView,MachineGroupCostEntityView>( params_MainConsult,this,Screen.MachineGroupCostEntityView);
 

        }
        public IRPSButton<MachineGroupCostCollectionView,MachineGroupCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineGroupCostCollectionView,MachineGroupCostEntityView> MainConsult { get; set; } 
        public MachineGroupCost Screen { get; set; }
        public MachineGroupCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineGroupCostEntityView : View
    {
        public MachineGroupCostEntityView(MachineGroupCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineGroupCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineGroupCostEntityView,MachineGroupCostCollectionView>( this,Screen.MachineGroupCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineGroupCostEntityView,MachineGroupCostCollectionView>( this,Screen.MachineGroupCostCollectionView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<MachineGroupCostEntityView>("f2fde39c-4da3-437a-9d82-f4ea0300e5a2","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostEntityView>("f641d261-3dec-45be-8f5f-fbd489913606","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineGroupCostEntityView>("0d44c0c6-6282-4f28-b856-e2c029915c07","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostEntityView>("7a3c256a-fcff-4fa2-99f6-dcc30de321c0","","",true, this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<MachineGroupCostEntityView>( "d48be885-64be-4cdf-a353-86dfff24f3e5","","",this);
 
            CollectionInit params_MachineGroupCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e68e1f1-b87f-4d9a-a4ce-478be3ed4cb6",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupCostDetailCollectionEditor<MachineGroupCostEntityView>,MachineGroupCostEntityView>( params_MachineGroupCostDetail,this);
 

        }
        public IRPSSaveButton<MachineGroupCostEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineGroupCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostEntityView,MachineGroupCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineGroupCostEntityView,MachineGroupCostCollectionView> BackButton { get; set; } 
        public IRPSComboBox<MachineGroupCostEntityView> IDMachineGroup { get; set; } 
        public IRPSComboBox<MachineGroupCostEntityView> IDHourType { get; set; } 
        public IRPSTextBox<MachineGroupCostEntityView> DateFrom { get; set; } 
        public IRPSTextBox<MachineGroupCostEntityView> CostPrice { get; set; } 
        public IRPSButton<MachineGroupCostEntityView> LinkNavigationCommand { get; set; } 
        public MachineGroupCostDetailCollectionEditor<MachineGroupCostEntityView> MachineGroupCostDetail { get; set; } 
        public MachineGroupCost Screen { get; set; }
        public MachineGroupCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineGroupCostDetailCollectionEditor<MachineGroupCostEntityView>:RPSCollectionEditor<MachineGroupCostEntityView> where MachineGroupCostEntityView : class, IView
    {
        public  MachineGroupCostDetailGridView<MachineGroupCostEntityView> GridView {get;set;}
    }
    public partial class MachineGroupCostDetailGridView <MachineGroupCostEntityView> :  RPSGridView<MachineGroupCostEntityView> where MachineGroupCostEntityView : class, IView
    {
        public MachineGroupCostDetailGridView(MachineGroupCostEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class MachineGroupCostDetailView : View
    {
        public MachineGroupCostDetailView(MachineGroupCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupCostDetailView>( this);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostDetailView>("b5635363-4c61-4bd9-b417-080b8bcd3299","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostDetailView>("3cb75cc4-f10c-4c64-ba41-3a86445b73d6","","",true, this);
 

        }
        public IRPSSaveButton<MachineGroupCostDetailView> SaveButton { get; set; } 
        public IRPSComboBox<MachineGroupCostDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineGroupCostDetailView> CostPrice { get; set; } 
        public MachineGroupCost Screen { get; set; }
        public MachineGroupCostDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}