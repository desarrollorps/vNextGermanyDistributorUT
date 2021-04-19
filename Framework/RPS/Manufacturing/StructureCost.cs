    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.StructureCost
{
    //RPS VERSION 1.0.0.0
    public partial class StructureCost:Screen
    {
        public StructureCost():base()
        {
            this.URL = "manufacturing.structurecost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StructureCostQueryView  = new StructureCostQueryView(this); 
            StructureCostEvolutionDialogView  = new StructureCostEvolutionDialogView(this); 
            StructureCostQueryView.InitializeControls(); 
            StructureCostEvolutionDialogView.InitializeControls(); 
           
        }
      
            public StructureCostQueryView StructureCostQueryView {get; set; } 
            public StructureCostEvolutionDialogView StructureCostEvolutionDialogView {get; set; } 
    }
            
    public partial class StructureCostQueryView : View
    {
        public StructureCostQueryView(StructureCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<StructureCostQueryView>("0ed43fe7-317b-455b-94e5-846dfb3a3ab3","","",true, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<StructureCostQueryView>("c5e56caf-49fa-4bca-9083-c298fcf652ee","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostQueryView>("4b749e3a-0071-4d09-8d2f-b62c6b1c53f4","","",true, this);
 
            Materials = RPSControlFactory.CreateRPSCheckBox<StructureCostQueryView>("b05d70dd-cc1f-47eb-a3b5-197bf43977fc","","",false, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<StructureCostQueryView>("a63a74d1-3741-416d-bcc5-0ad8cab4ce72","","",true, this);
 
            Route = RPSControlFactory.CreateRPSComboBox<StructureCostQueryView>("31a9f3c0-38f0-4cb4-b6fc-9db89da62194","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<StructureCostQueryView>("826fd5d5-1ca0-4ce8-ab79-5c656d6cfb96","","",true, this);
 
            Resources = RPSControlFactory.CreateRPSCheckBox<StructureCostQueryView>("d2a0966a-2ee3-434c-bdf5-315f80d65300","","",false, this);
 
            StructureCostEvolutionNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StructureCostQueryView,StructureCostEvolutionDialogView>("6fcd66e9-584d-49f0-a8fa-f37347bec474","","", this,Screen.StructureCostEvolutionDialogView);
 
            UIPropagateRoutes = RPSControlFactory.CreateRPSCheckBox<StructureCostQueryView>("e00a4f92-498a-43be-a38f-8b2c16573a59","","",false, this);
 
            TaskDuration = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostQueryView>("066588b0-5aa6-4cbf-a77f-c1eb7196de7f","","",false, this);
 
            Quantity1 = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostQueryView>("d88f0c70-01fa-4fc7-bd8d-c82c849d0b2b","","",false, this);
 

        }
        public IRPSComboBox<StructureCostQueryView> Site { get; set; } 
        public IRPSComboBox<StructureCostQueryView> Article { get; set; } 
        public IRPSTextBox<StructureCostQueryView> Quantity { get; set; } 
        public IRPSCheckbox<StructureCostQueryView> Materials { get; set; } 
        public IRPSComboBox<StructureCostQueryView> Version { get; set; } 
        public IRPSComboBox<StructureCostQueryView> Route { get; set; } 
        public IRPSTextBox<StructureCostQueryView> Date { get; set; } 
        public IRPSCheckbox<StructureCostQueryView> Resources { get; set; } 
        public IRPSButton<StructureCostQueryView,StructureCostEvolutionDialogView> StructureCostEvolutionNavigationCommand { get; set; } 
        public IRPSCheckbox<StructureCostQueryView> UIPropagateRoutes { get; set; } 
        public IRPSTextBox<StructureCostQueryView> TaskDuration { get; set; } 
        public IRPSTextBox<StructureCostQueryView> Quantity1 { get; set; } 
        public StructureCost Screen { get; set; }
        public StructureCostQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureCostEvolutionDialogView : View
    {
        public StructureCostEvolutionDialogView(StructureCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIFrom = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostEvolutionDialogView>("555d8fdb-8867-4ce9-a7af-422ba842a260","","",false, this);
 
            UIUntil = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostEvolutionDialogView>("aca74e20-aad1-42cc-84ff-1f141943d4c3","","",false, this);
 
            UIIncrement = RPSControlFactory.CreateRPSFormattedTextBox<StructureCostEvolutionDialogView>("d164d98e-5ab1-406f-a0de-cfc8c1deab38","","",false, this);
 
            UIPropagateRoutes = RPSControlFactory.CreateRPSCheckBox<StructureCostEvolutionDialogView>("d6499992-4a60-40d7-a817-186b09e598f1","","",false, this);
 
            ExecuteGetTaskCostsByLotButton = RPSControlFactory.CreateRPSButton<StructureCostEvolutionDialogView>( "c992e782-15da-4c85-ac16-ee436a265e60","","",this);
 
            CollectionInit params_GetTaskCostsByLot = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9326019-be1b-4507-b0c1-ca5aeb9e96f5",CSSSelectorGrid="",XPathGrid=""};
            GetTaskCostsByLot = RPSControlFactory.RPSCreateCollectionWithGrid<GetTaskCostsByLotCollectionEditor<StructureCostEvolutionDialogView>,StructureCostEvolutionDialogView>( params_GetTaskCostsByLot,this);
 

        }
        public IRPSTextBox<StructureCostEvolutionDialogView> UIFrom { get; set; } 
        public IRPSTextBox<StructureCostEvolutionDialogView> UIUntil { get; set; } 
        public IRPSTextBox<StructureCostEvolutionDialogView> UIIncrement { get; set; } 
        public IRPSCheckbox<StructureCostEvolutionDialogView> UIPropagateRoutes { get; set; } 
        public IRPSButton<StructureCostEvolutionDialogView> ExecuteGetTaskCostsByLotButton { get; set; } 
        public GetTaskCostsByLotCollectionEditor<StructureCostEvolutionDialogView> GetTaskCostsByLot { get; set; } 
        public StructureCost Screen { get; set; }
        public StructureCostEvolutionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTaskCostsByLotCollectionEditor<StructureCostEvolutionDialogView>:RPSCollectionEditor<StructureCostEvolutionDialogView> where StructureCostEvolutionDialogView : class, IView
    {
        public  GetTaskCostsByLotGridView<StructureCostEvolutionDialogView> GridView {get;set;}
    }
    public partial class GetTaskCostsByLotGridView <StructureCostEvolutionDialogView> :  RPSGridView<StructureCostEvolutionDialogView> where StructureCostEvolutionDialogView : class, IView
    {
        public GetTaskCostsByLotGridView(StructureCostEvolutionDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Lot = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureCostEvolutionDialogView>("","#f9326019-be1b-4507-b0c1-ca5aeb9e96f5 .ag-row[role='row']@ROWINDEX [col-id='cLot']","",false, this.CurrentView);
 
            ResourcesCost = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureCostEvolutionDialogView>("","#f9326019-be1b-4507-b0c1-ca5aeb9e96f5 .ag-row[role='row']@ROWINDEX [col-id='cResourcesCost']","",false, this.CurrentView);
 
            MaterialsCost = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureCostEvolutionDialogView>("","#f9326019-be1b-4507-b0c1-ca5aeb9e96f5 .ag-row[role='row']@ROWINDEX [col-id='cMaterialsCost']","",false, this.CurrentView);
 
            TotalCosts = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureCostEvolutionDialogView>("","#f9326019-be1b-4507-b0c1-ca5aeb9e96f5 .ag-row[role='row']@ROWINDEX [col-id='cTotalCosts']","",false, this.CurrentView);
 
            UnitatianCosts = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureCostEvolutionDialogView>("","#f9326019-be1b-4507-b0c1-ca5aeb9e96f5 .ag-row[role='row']@ROWINDEX [col-id='cUnitatianCosts']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StructureCostEvolutionDialogView> Lot { get; set; } 
        public IRPSGridTextBox<StructureCostEvolutionDialogView> ResourcesCost { get; set; } 
        public IRPSGridTextBox<StructureCostEvolutionDialogView> MaterialsCost { get; set; } 
        public IRPSGridTextBox<StructureCostEvolutionDialogView> TotalCosts { get; set; } 
        public IRPSGridTextBox<StructureCostEvolutionDialogView> UnitatianCosts { get; set; } 
                     
    }
 
    }
  
    

}