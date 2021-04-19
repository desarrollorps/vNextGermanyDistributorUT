    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.InventoryDelete
{
    //RPS VERSION 1.0.0.0
    public partial class InventoryDelete:Screen
    {
        public InventoryDelete():base()
        {
            this.URL = "warehouse.inventorydelete";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InventoryDeleteView  = new InventoryDeleteView(this); 
            InventoryDeleteView.InitializeControls(); 
           
        }
      
            public InventoryDeleteView InventoryDeleteView {get; set; } 
    }
            
    public partial class InventoryDeleteView : View
    {
        public InventoryDeleteView(InventoryDelete screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveSnapshot = RPSControlFactory.CreateRPSOption<InventoryDeleteView>( "66c33455-8e7d-4f68-b620-e8102b984389","","",this);
 
            SaveSnapshotToDate = RPSControlFactory.CreateRPSOption<InventoryDeleteView>( "b2aca530-55ed-4329-9959-15d2c83fa37b","","",this);
 
            DeleteSnapshot = RPSControlFactory.CreateRPSOption<InventoryDeleteView>( "1ec0efa5-df37-4701-8a7d-0984434efd26","","",this);
 
            Inventary = RPSControlFactory.CreateRPSCollectionComboBox<InventoryDeleteView>("d3b18739-123b-49d9-a048-a3bf59013789","","",false, this);
 
            SnapshotDate = RPSControlFactory.CreateRPSTextBox<InventoryDeleteView>("20579a55-e079-4efb-a29e-23cf80126846","","",false, this);
 
            CommandExecuteDelete = RPSControlFactory.CreateRPSButton<InventoryDeleteView>( "03eabf85-881f-494f-9455-47bda388ce61","","",this);
 

        }
        public IRPSOption<InventoryDeleteView> SaveSnapshot { get; set; } 
        public IRPSOption<InventoryDeleteView> SaveSnapshotToDate { get; set; } 
        public IRPSOption<InventoryDeleteView> DeleteSnapshot { get; set; } 
        public IRPSCollectionComboBox<InventoryDeleteView> Inventary { get; set; } 
        public IRPSTextBox<InventoryDeleteView> SnapshotDate { get; set; } 
        public IRPSButton<InventoryDeleteView> CommandExecuteDelete { get; set; } 
        public InventoryDelete Screen { get; set; }
        public InventoryDeleteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}