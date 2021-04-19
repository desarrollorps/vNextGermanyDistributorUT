    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ShippingVehicle
{
    //RPS VERSION 1.0.0.0
    public partial class ShippingVehicle:Screen
    {
        public ShippingVehicle():base()
        {
            this.URL = "purchase.shippingvehicle";
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
        public ShippingVehicleSLCollectionView(ShippingVehicle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView>( this,Screen.ShippingVehicleSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d61ab631-5f16-440e-846a-fe5440dfe4b5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView>( params_MainConsult,this,Screen.ShippingVehicleSLEntityView);
 

        }
        public IRPSButton<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ShippingVehicleSLCollectionView,ShippingVehicleSLEntityView> MainConsult { get; set; } 
        public ShippingVehicle Screen { get; set; }
        public ShippingVehicleSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ShippingVehicleSLEntityView : View
    {
        public ShippingVehicleSLEntityView(ShippingVehicle screen) : base()
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
 
            RegistrationNumber = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("a6e63efb-a105-45a2-8d27-7cd1dd4ae4a9","","",true, this);
 
            RegistrationNumberTow = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("37b2d943-1916-440d-b867-8deba8d15732","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("26d1fdaf-7eb7-4293-ae9b-ea958cac5374","","",false, this);
 
            BoxesCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("15e4c6fe-2f22-4228-b784-5dbe28cae08c","","",true, this);
 
            GrossWeightCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("c16f1452-0e4f-4fe2-aa1d-82ef8d5e1369","","",true, this);
 
            NetWeightCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("2c307c4f-4ffe-46d9-9ad9-d98abe45dafe","","",true, this);
 
            VolumeCapacity = RPSControlFactory.CreateRPSFormattedTextBox<ShippingVehicleSLEntityView>("c66738c2-6d62-4974-8099-ba32c7b76de4","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ShippingVehicleSLEntityView>("9707ecdb-7a01-4495-85d5-223d4c7b18d6","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<ShippingVehicleSLEntityView>( "","ul li[rpsid='ffdad1f0-1c21-4ad3-a132-3fe5cca40387']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ShippingVehicleSLEntityView>( "","ul li[rpsid='8f91ab3e-8e58-41de-93c6-2cc3c17ffc6a']","",this);
 

        }
        public IRPSSaveButton<ShippingVehicleSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ShippingVehicleSLEntityView,ShippingVehicleSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> RegistrationNumber { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> RegistrationNumberTow { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> Description { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> BoxesCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> GrossWeightCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> NetWeightCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> VolumeCapacity { get; set; } 
        public IRPSTextBox<ShippingVehicleSLEntityView> Comment { get; set; } 
        public IRPSSection<ShippingVehicleSLEntityView> Section { get; set; } 
        public IRPSSection<ShippingVehicleSLEntityView> Section1 { get; set; } 
        public ShippingVehicle Screen { get; set; }
        public ShippingVehicleSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}