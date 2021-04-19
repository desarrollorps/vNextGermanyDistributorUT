    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MultiImputation
{
    //RPS VERSION 1.0.0.0
    public partial class MultiImputation:Screen
    {
        public MultiImputation():base()
        {
            this.URL = "maintenance.multiimputation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MultiImputationMANCollectionView  = new MultiImputationMANCollectionView(this); 
            MultiImputationMANEntityView  = new MultiImputationMANEntityView(this); 
            MultiImputationMANOrderView  = new MultiImputationMANOrderView(this); 
            MultiImputationMANCollectionView.InitializeControls(); 
            MultiImputationMANEntityView.InitializeControls(); 
            MultiImputationMANOrderView.InitializeControls(); 
           
        }
      
            public MultiImputationMANCollectionView MultiImputationMANCollectionView {get; set; } 
            public MultiImputationMANEntityView MultiImputationMANEntityView {get; set; } 
            public MultiImputationMANOrderView MultiImputationMANOrderView {get; set; } 
    }
            
    public partial class MultiImputationMANCollectionView : View
    {
        public MultiImputationMANCollectionView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MultiImputationMANCollectionView,MultiImputationMANEntityView>( this,Screen.MultiImputationMANEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f8674d28-8a57-4faa-acf4-5a953f010ef1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MultiImputationMANCollectionView,MultiImputationMANEntityView>( params_MainConsult,this,Screen.MultiImputationMANEntityView);
 

        }
        public IRPSButton<MultiImputationMANCollectionView,MultiImputationMANEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MultiImputationMANCollectionView,MultiImputationMANEntityView> MainConsult { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationMANCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MultiImputationMANEntityView : View
    {
        public MultiImputationMANEntityView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MultiImputationMANEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationMANEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationMANEntityView,MultiImputationMANCollectionView>( this,Screen.MultiImputationMANCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationMANEntityView,MultiImputationMANCollectionView>( this,Screen.MultiImputationMANCollectionView);
 
            CodWork = RPSControlFactory.CreateRPSTextBox<MultiImputationMANEntityView>("131e4c74-0d6f-4af0-a8d3-b39a8a7474be","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MultiImputationMANEntityView>("31c163a5-67d3-4cae-a762-73c59bc2d47f","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MultiImputationMANEntityView>("4b5cb62e-f356-4cd4-aa8a-2e5d3eb052a4","","",true, this);
 
            UIExpectedTime = RPSControlFactory.CreateRPSDurationTextBox<MultiImputationMANEntityView>("3e56f7a7-ef47-4fa8-903e-3cb31fdf6b38","","",false, this);
 
            WorkDate = RPSControlFactory.CreateRPSTextBox<MultiImputationMANEntityView>("92be934b-d12e-48e7-83f7-21841b948fb6","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MultiImputationMANEntityView>("1be34760-cc82-42fb-a3f2-b9e4d0ad7f62","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MultiImputationMANEntityView>("3df99308-8070-41da-9cdf-cfae29bdfd56","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MultiImputationMANEntityView>("13075010-a5be-4e77-94b5-e207f172afce","","",true, this);
 
            Ended = RPSControlFactory.CreateRPSCheckBox<MultiImputationMANEntityView>("0b4fc808-2c8e-4821-9252-e86b0badb8e4","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<MultiImputationMANEntityView>("41ea33b8-2ba8-4232-850c-c94c907d6801","","",false, this);
 
            ExecuteMultiImputationLoadDefaultOrdersButton = RPSControlFactory.CreateRPSButton<MultiImputationMANEntityView>( "e620fe9f-007e-4140-aa51-a497b19a1ef0","","",this);
 
            ExecuteMultiImputationSetProportionalDurationButton = RPSControlFactory.CreateRPSButton<MultiImputationMANEntityView>( "a9269cbd-2d54-48af-81f5-811df15887d3","","",this);
 
            ExecuteMultiImputationFinishButton = RPSControlFactory.CreateRPSButton<MultiImputationMANEntityView>( "7cee0ccb-f223-4899-ba4f-a4e2774a6fdb","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<MultiImputationMANEntityView>( "7833b0de-f68d-4d4d-a918-f5232b864186","","",this);
 
            CollectionInit params_MultiImputationMANOrders = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8e3b8497-2a8c-4925-8e1c-6b45aae71cf5",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationMANOrders = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationMANOrdersCollectionEditor<MultiImputationMANEntityView,MultiImputationMANOrderView>,MultiImputationMANEntityView,MultiImputationMANOrderView>( params_MultiImputationMANOrders,this,Screen.MultiImputationMANOrderView);
 
            Orders = RPSControlFactory.CreateRPSSection<MultiImputationMANEntityView>( "","ul li[rpsid='56543d1f-977e-4c38-a990-a817c9ff6256']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<MultiImputationMANEntityView>( "","ul li[rpsid='0c4e53f1-006b-4d70-887e-2614b982eb94']","",this);
 

        }
        public IRPSSaveButton<MultiImputationMANEntityView> SaveButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView,MultiImputationMANCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView,MultiImputationMANCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MultiImputationMANEntityView> CodWork { get; set; } 
        public IRPSTextBox<MultiImputationMANEntityView> Description { get; set; } 
        public IRPSComboBox<MultiImputationMANEntityView> IDSite { get; set; } 
        public IRPSDurationTextBox<MultiImputationMANEntityView> UIExpectedTime { get; set; } 
        public IRPSTextBox<MultiImputationMANEntityView> WorkDate { get; set; } 
        public IRPSComboBox<MultiImputationMANEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<MultiImputationMANEntityView> IDHourType { get; set; } 
        public IRPSDurationTextBox<MultiImputationMANEntityView> Duration { get; set; } 
        public IRPSCheckbox<MultiImputationMANEntityView> Ended { get; set; } 
        public IRPSTextBox<MultiImputationMANEntityView> Comment { get; set; } 
        public IRPSButton<MultiImputationMANEntityView> ExecuteMultiImputationLoadDefaultOrdersButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView> ExecuteMultiImputationSetProportionalDurationButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView> ExecuteMultiImputationFinishButton { get; set; } 
        public IRPSButton<MultiImputationMANEntityView> ReportCommandButton { get; set; } 
        public MultiImputationMANOrdersCollectionEditor<MultiImputationMANEntityView,MultiImputationMANOrderView> MultiImputationMANOrders { get; set; } 
        public IRPSSection<MultiImputationMANEntityView> Orders { get; set; } 
        public IRPSSection<MultiImputationMANEntityView> Comment1 { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationMANEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationMANOrdersCollectionEditor<MultiImputationMANEntityView,MultiImputationMANOrderView>:RPSCollectionEditor<MultiImputationMANEntityView,MultiImputationMANOrderView> where MultiImputationMANEntityView : class, IView where MultiImputationMANOrderView : class, IView
    {
        public  MultiImputationMANOrdersGridView<MultiImputationMANEntityView,MultiImputationMANOrderView> GridView {get;set;}
    }
    public partial class MultiImputationMANOrdersGridView <MultiImputationMANEntityView,MultiImputationMANOrderView> :  RPSGridView<MultiImputationMANEntityView,MultiImputationMANOrderView> where MultiImputationMANEntityView : class, IView where MultiImputationMANOrderView : class, IView
    {
        public MultiImputationMANOrdersGridView(MultiImputationMANEntityView currentView,MultiImputationMANOrderView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FinishMaintenanceOrder = RPSControlFactory.CreateRPSGridCheckBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cFinishMaintenanceOrder']","",true, this.CurrentView);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSGridComboBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceOrder']","",true, this.CurrentView);
 
            UIExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cUIExecutionDate']","",false, this.CurrentView);
 
            UIMaintenanceType = RPSControlFactory.CreateRPSGridComboBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cUIMaintenanceType']","",false, this.CurrentView);
 
            UIDescriptionPlanWarning = RPSControlFactory.CreateRPSGridTextBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cUIDescriptionPlanWarning']","",false, this.CurrentView);
 
            UIExpectedTime = RPSControlFactory.CreateRPSGridDurationTextBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cUIExpectedTime']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MultiImputationMANEntityView>("","#8e3b8497-2a8c-4925-8e1c-6b45aae71cf5 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 

        }
        public IRPSGridCheckbox<MultiImputationMANEntityView> FinishMaintenanceOrder { get; set; } 
        public IRPSGridComboBox<MultiImputationMANEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSGridTextBox<MultiImputationMANEntityView> UIExecutionDate { get; set; } 
        public IRPSGridComboBox<MultiImputationMANEntityView> UIMaintenanceType { get; set; } 
        public IRPSGridTextBox<MultiImputationMANEntityView> UIDescriptionPlanWarning { get; set; } 
        public IRPSGridDurationTextBox<MultiImputationMANEntityView> UIExpectedTime { get; set; } 
        public IRPSGridDurationTextBox<MultiImputationMANEntityView> Duration { get; set; } 
                     
    }
 
    }
  
            
    public partial class MultiImputationMANOrderView : View
    {
        public MultiImputationMANOrderView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationMANOrderView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationMANOrderView,MultiImputationMANEntityView>( this,Screen.MultiImputationMANEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationMANOrderView,MultiImputationMANEntityView>( this,Screen.MultiImputationMANEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MultiImputationMANOrderView,MultiImputationMANEntityView>( this,Screen.MultiImputationMANEntityView);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MultiImputationMANOrderView>("a989ff4a-8b3f-414e-9ac3-819461d5b86b","","",true, this);
 
            UIMaintenanceType = RPSControlFactory.CreateRPSComboBox<MultiImputationMANOrderView>("5ef9ce57-772d-439d-8159-5cf95ea96f02","","",false, this);
 
            UIDescriptionPlanWarning = RPSControlFactory.CreateRPSTextBox<MultiImputationMANOrderView>("3e9e7090-5b22-4c3e-ab8f-177f40ff1272","","",false, this);
 
            UIExecutionDate = RPSControlFactory.CreateRPSTextBox<MultiImputationMANOrderView>("ac298d83-f7a6-4655-9640-81531000abc5","","",false, this);
 
            UIExpectedTime = RPSControlFactory.CreateRPSDurationTextBox<MultiImputationMANOrderView>("5cc82edf-0b71-48fc-842a-4c09e49c46c2","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MultiImputationMANOrderView>("bee6dca8-0543-47e0-96b1-3dc053844a51","","",true, this);
 
            FinishMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<MultiImputationMANOrderView>("51f5e0fd-e2d7-4326-8cb3-c5ee9fafd7e0","","",true, this);
 

        }
        public IRPSButton<MultiImputationMANOrderView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationMANOrderView,MultiImputationMANEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationMANOrderView,MultiImputationMANEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MultiImputationMANOrderView,MultiImputationMANEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MultiImputationMANOrderView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<MultiImputationMANOrderView> UIMaintenanceType { get; set; } 
        public IRPSTextBox<MultiImputationMANOrderView> UIDescriptionPlanWarning { get; set; } 
        public IRPSTextBox<MultiImputationMANOrderView> UIExecutionDate { get; set; } 
        public IRPSDurationTextBox<MultiImputationMANOrderView> UIExpectedTime { get; set; } 
        public IRPSDurationTextBox<MultiImputationMANOrderView> Duration { get; set; } 
        public IRPSCheckbox<MultiImputationMANOrderView> FinishMaintenanceOrder { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationMANOrderView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}