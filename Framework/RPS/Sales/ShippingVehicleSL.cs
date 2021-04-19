    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ShippingVehicleSL
{
    //RPS VERSION 1.0.0.0
    public partial class ShippingVehicleSL:Screen
    {
        public ShippingVehicleSL():base()
        {
            this.URL = "sales.shippingvehiclesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ShippingVehicleSLCollectionView  = new ShippingVehicleSLCollectionView(this); 
            ShippingVehicleSLEntityView  = new ShippingVehicleSLEntityView(this); 
            ShippingVehicleSLCollectionView.InitializeControls(); 
            ShippingVehicleSLEntityView.InitializeControls(); 
           
        }
      
            public ShippingVehicleSLCollectionView ShippingVehicleSLCollectionView {get; set; } 
            public ShippingVehicleSLEntityView ShippingVehicleSLEntityView {get; set; } 
    }
            
    public partial class ShippingVehicleSLCollectionView : View
    {
        public ShippingVehicleSLCollectionView(ShippingVehicleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView>( this,Screen.ShippingVehicleSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "131cf82e-f86d-4785-80a3-247a2fc948f3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView>( params_MainConsult,this,Screen.ShippingVehicleSLEntityView);
 

        }
        public IRPSButton<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView> MainConsult { get; set; } 
        public ShippingVehicleSL Screen { get; set; }
        public ShippingVehicleSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ShippingVehicleSLEntityView : View
    {
        public ShippingVehicleSLEntityView(ShippingVehicleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ShippingVehicleSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ShippingVehicleSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView>( this,Screen.ShippingVehicleSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView>( this,Screen.ShippingVehicleSLCollectionView);
 
            RegistrationNumber = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("032d568b-7929-4c5a-9030-8c82ffa39bad","","",true, this);
 
            RegistrationNumberTow = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("42f4325b-8c02-4864-8ddb-8d41795f39a9","","",false, this);
 
            RoadMapAutomatic = RPSControlFactory.CreateRPSEnumComboBox<ShippingVehicleSLEntityView>("471154e6-c868-4cf6-a43a-ec309c24b623","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("35eca9d7-d489-4fd8-a846-868bd1ac164d","","",false, this);
 
            BoxesCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("04f50044-29ce-4329-a680-5a54ee100c7d","","",true, this);
 
            GrossWeightCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("cfcf6624-fde7-48e7-8fa8-6e5525891338","","",true, this);
 
            NetWeightCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("113fffdf-6bdc-4ce0-a9f0-ca135e03887f","","",true, this);
 
            VolumeCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("f6f2fc45-7297-4b77-a475-a8f4e2e198f8","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("62fcb074-32cd-4086-8dfb-628b936b267a","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<ShippingVehicleSLEntityView>( "","ul li[rpsid='21940997-c101-44c1-b764-588475e8682b']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<ShippingVehicleSLEntityView>( "","ul li[rpsid='69eecf67-cc1f-4802-9db3-40cd151c79a0']","",this);
 

        }
        public IRPSSaveButton<ShippingVehicleSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> RegistrationNumber { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> RegistrationNumberTow { get; set; } 
        public IRPSComboBox<ShippingVehicleSLEntityView> RoadMapAutomatic { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> Description { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> BoxesCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> GrossWeightCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> NetWeightCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> VolumeCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> Comment { get; set; } 
        public IRPSSection<ShippingVehicleSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<ShippingVehicleSLEntityView> CommentSection { get; set; } 
        public ShippingVehicleSL Screen { get; set; }
        public ShippingVehicleSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}