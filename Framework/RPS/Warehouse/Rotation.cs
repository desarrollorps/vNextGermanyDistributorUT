    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Rotation
{
    //RPS VERSION 1.0.0.0
    public partial class Rotation:Screen
    {
        public Rotation():base()
        {
            this.URL = "warehouse.rotation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RotationQueryView  = new RotationQueryView(this); 
            RotationQueryView.InitializeControls(); 
           
        }
      
            public RotationQueryView RotationQueryView {get; set; } 
    }
            
    public partial class RotationQueryView : View
    {
        public RotationQueryView(Rotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSOption<RotationQueryView>( "5457f742-4aef-4173-a559-b27d30746104","","",this);
 
            Site = RPSControlFactory.CreateRPSOption<RotationQueryView>( "a22e699a-47ad-4c5a-b1ea-c0363dc69bc9","","",this);
 
            Warehouse = RPSControlFactory.CreateRPSOption<RotationQueryView>( "2681d241-c818-4c17-89c6-55c46b485dac","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("4447c73f-475d-455a-9001-e4f43741e124","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("e88d2131-d142-425a-aa27-7fbe8f5e0dc7","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("398e7277-c9c8-419b-a434-268c915d1fa5","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("37d47254-d167-4fd5-ba79-3d2f49a61b5b","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("28ca05f7-c0d1-4099-8d89-00d216410bd4","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<RotationQueryView>("bdb6ec7f-e823-40cb-ad47-e697a14ed1cf","","",false, this);
 
            MovementDateFrom = RPSControlFactory.CreateRPSTextBox<RotationQueryView>("726d2d8d-eb11-4f9f-a975-9a4d8821f1aa","","",false, this);
 
            MovementDateTo = RPSControlFactory.CreateRPSTextBox<RotationQueryView>("dda84eea-76e2-414d-ad29-8873a52d0519","","",false, this);
 
            UpdateRotationIndexCommandButton = RPSControlFactory.CreateRPSButton<RotationQueryView>( "d4954084-2039-4af9-8917-40b78916d9a7","","",this);
 
            CollectionInit params_Rotation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="29e8786c-e292-4519-bb08-5e7c86f7e527",CSSSelectorGrid="",XPathGrid=""};
            Rotation = RPSControlFactory.RPSCreateCollectionWithGrid<RotationCollectionEditor<RotationQueryView>,RotationQueryView>( params_Rotation,this);
 

        }
        public IRPSOption<RotationQueryView> Article { get; set; } 
        public IRPSOption<RotationQueryView> Site { get; set; } 
        public IRPSOption<RotationQueryView> Warehouse { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> Article1 { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> Site1 { get; set; } 
        public IRPSCollectionComboBox<RotationQueryView> WareHouse { get; set; } 
        public IRPSTextBox<RotationQueryView> MovementDateFrom { get; set; } 
        public IRPSTextBox<RotationQueryView> MovementDateTo { get; set; } 
        public IRPSButton<RotationQueryView> UpdateRotationIndexCommandButton { get; set; } 
        public RotationCollectionEditor<RotationQueryView> Rotation { get; set; } 
        public Rotation Screen { get; set; }
        public RotationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RotationCollectionEditor<RotationQueryView>:RPSCollectionEditor<RotationQueryView> where RotationQueryView : class, IView
    {
        public  RotationGridView<RotationQueryView> GridView {get;set;}
    }
    public partial class RotationGridView <RotationQueryView> :  RPSGridView<RotationQueryView> where RotationQueryView : class, IView
    {
        public RotationGridView(RotationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RotationIndex = RPSControlFactory.CreateRPSGridFormattedTextBox<RotationQueryView>("","#29e8786c-e292-4519-bb08-5e7c86f7e527 .ag-row[role='row']@ROWINDEX [col-id='cRotationIndex']","",false, this.CurrentView);
 
            RotationIndexCalculated = RPSControlFactory.CreateRPSGridFormattedTextBox<RotationQueryView>("","#29e8786c-e292-4519-bb08-5e7c86f7e527 .ag-row[role='row']@ROWINDEX [col-id='cRotationIndexCalculated']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RotationQueryView> RotationIndex { get; set; } 
        public IRPSGridTextBox<RotationQueryView> RotationIndexCalculated { get; set; } 
                     
    }
 
    }
  
    

}