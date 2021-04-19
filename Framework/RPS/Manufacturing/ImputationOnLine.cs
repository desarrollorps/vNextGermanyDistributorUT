    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ImputationOnLine
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationOnLine:Screen
    {
        public ImputationOnLine():base()
        {
            this.URL = "manufacturing.imputationonline";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationOnLineVMQueryView  = new ImputationOnLineVMQueryView(this); 
            ImputationOnLineVMEntityView  = new ImputationOnLineVMEntityView(this); 
            GenerateChildDialogView  = new GenerateChildDialogView(this); 
            ImputationOnLineVMQueryView.InitializeControls(); 
            ImputationOnLineVMEntityView.InitializeControls(); 
            GenerateChildDialogView.InitializeControls(); 
           
        }
      
            public ImputationOnLineVMQueryView ImputationOnLineVMQueryView {get; set; } 
            public ImputationOnLineVMEntityView ImputationOnLineVMEntityView {get; set; } 
            public GenerateChildDialogView GenerateChildDialogView {get; set; } 
    }
            
    public partial class ImputationOnLineVMQueryView : View
    {
        public ImputationOnLineVMQueryView(ImputationOnLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView>( this,Screen.ImputationOnLineVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationOnLineVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMQueryView>("6f7cf731-6447-4e34-a4a9-532644f6c828","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ImputationOnLineVMQueryView>("b16ba639-ece4-4dd3-8844-0b9547590b6c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMQueryView>("a32f810d-e6b8-40f6-9c0c-a5d0bb65921e","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMQueryView>("7c3a29fb-29eb-4daf-a816-a80fc81b2be8","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ImputationOnLineVMQueryView>( "7810fce6-31c2-4d65-a18b-1a030d0c1131","","",this);
 
            Started = RPSControlFactory.CreateRPSOption<ImputationOnLineVMQueryView>( "2d5f24b2-d736-40b3-abe9-031b38bc8fc5","","",this);
 
            Finished = RPSControlFactory.CreateRPSOption<ImputationOnLineVMQueryView>( "55649b77-606e-4978-9723-8c7ce1d31474","","",this);
 
            GenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ImputationOnLineVMQueryView,GenerateChildDialogView>("2e111a5e-f9f3-4f2d-80df-9ae7b7476912","","", this,Screen.GenerateChildDialogView);
 
            CollectionInit params_ImputationOnline = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c16ff5b5-10c8-415b-8f43-afa302751d1f",CSSSelectorGrid="",XPathGrid=""};
            ImputationOnline = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationOnlineCollectionEditor<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView>,ImputationOnLineVMQueryView,ImputationOnLineVMEntityView>( params_ImputationOnline,this,Screen.ImputationOnLineVMEntityView);
 

        }
        public IRPSButton<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationOnLineVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationOnLineVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationOnLineVMQueryView> ManufacturingOrder { get; set; } 
        public IRPSTextBox<ImputationOnLineVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationOnLineVMQueryView> DateTo { get; set; } 
        public IRPSOption<ImputationOnLineVMQueryView> All { get; set; } 
        public IRPSOption<ImputationOnLineVMQueryView> Started { get; set; } 
        public IRPSOption<ImputationOnLineVMQueryView> Finished { get; set; } 
        public IRPSButton<ImputationOnLineVMQueryView,GenerateChildDialogView> GenerateChildNavigationCommandButton { get; set; } 
        public ImputationOnlineCollectionEditor<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> ImputationOnline { get; set; } 
        public ImputationOnLine Screen { get; set; }
        public ImputationOnLineVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationOnlineCollectionEditor<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView>:RPSCollectionEditor<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> where ImputationOnLineVMQueryView : class, IView where ImputationOnLineVMEntityView : class, IView
    {
        public  ImputationOnlineGridView<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> GridView {get;set;}
    }
    public partial class ImputationOnlineGridView <ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> :  RPSGridView<ImputationOnLineVMQueryView,ImputationOnLineVMEntityView> where ImputationOnLineVMQueryView : class, IView where ImputationOnLineVMEntityView : class, IView
    {
        public ImputationOnlineGridView(ImputationOnLineVMQueryView currentView,ImputationOnLineVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationOnLine_ResourceType = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLineVMQueryView>("","#c16ff5b5-10c8-415b-8f43-afa302751d1f .ag-row[role='row']@ROWINDEX [col-id='cImputationOnLine_ResourceType']","",false, this.CurrentView);
 
            ImputationOnLine_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLineVMQueryView>("","#c16ff5b5-10c8-415b-8f43-afa302751d1f .ag-row[role='row']@ROWINDEX [col-id='cImputationOnLine_ImputationDate']","",false, this.CurrentView);
 
            StartHour = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLineVMQueryView>("","#c16ff5b5-10c8-415b-8f43-afa302751d1f .ag-row[role='row']@ROWINDEX [col-id='cStartHour']","",false, this.CurrentView);
 
            EndHour = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLineVMQueryView>("","#c16ff5b5-10c8-415b-8f43-afa302751d1f .ag-row[role='row']@ROWINDEX [col-id='cEndHour']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationOnLineVMQueryView> ImputationOnLine_ResourceType { get; set; } 
        public IRPSGridTextBox<ImputationOnLineVMQueryView> ImputationOnLine_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationOnLineVMQueryView> StartHour { get; set; } 
        public IRPSGridTextBox<ImputationOnLineVMQueryView> EndHour { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationOnLineVMEntityView : View
    {
        public ImputationOnLineVMEntityView(ImputationOnLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationOnLineVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationOnLineVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationOnLineVMEntityView,ImputationOnLineVMQueryView>( this,Screen.ImputationOnLineVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationOnLineVMEntityView,ImputationOnLineVMQueryView>( this,Screen.ImputationOnLineVMQueryView);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("bf2dfb1e-aad8-4df5-a4eb-c69ae6219b23","","",true, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("5bd8682a-1ea3-42d3-8707-2d3a8135568e","","",true, this);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("befa369f-a667-4697-9a01-fa15c3c859a2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("08c48d47-ad4f-4606-8e9d-56a35fdc435d","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("02bb475b-d516-4eaf-8b63-a2336a7f552c","","",true, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("1a880d17-5ec0-4630-a3ef-af54ebe60199","","",true, this);
 
            ImputationEndDate = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("5c2b86ea-b7f7-43b3-946c-603347266928","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("71b09ab4-1ed7-47fa-9458-d8fccafc04d5","","",true, this);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<ImputationOnLineVMEntityView>("f87082da-27e6-4777-8da2-d91a61a83b84","","",false, this);
 
            IDMOResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("96e47eef-214c-45c7-9217-389b865d9aa2","","",false, this);
 
            IDMOResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("4c073704-12ca-4d76-bea5-b3072c79924c","","",false, this);
 
            IDMOResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("5ef46638-f42b-4cea-b20c-7d8b3cd5394e","","",false, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("eac149e2-7ef7-49b5-952b-a31988e4c81e","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("ac677865-2e30-46bc-8e62-b18e12f0abec","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("cca8fcaa-3007-4581-a80b-e69206adac64","","",false, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLineVMEntityView>("cbc84e3f-90d6-47ce-9754-8e71c420539f","","",true, this);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLineVMEntityView>("c5aad98f-b3da-42db-b334-21f9475b45c8","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLineVMEntityView>("7281e973-999a-43f1-8c4c-72e23d91c464","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLineVMEntityView>("9853bd79-871f-499b-b3a4-3a9a7c94d36b","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLineVMEntityView>("084ad63c-a5f7-46d9-8436-fb4f07c2290f","","",true, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationOnLineVMEntityView>("9d7c2f98-59df-406e-b21a-61d77c102e88","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("2a423ad2-3235-4c69-9472-0c6a0edd0a5f","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<ImputationOnLineVMEntityView>("33ff2fe3-4cca-4a44-8642-4a03694d54f3","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("918efe4f-9691-45db-9e77-d6b5d93462f1","","",false, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationOnLineVMEntityView>("57024f7c-82a4-41f2-8cea-a354b374cb2b","","",false, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationOnLineVMEntityView>("100d49a7-2c84-43de-a175-f917ca2db287","","",true, this);
 
            Preparation = RPSControlFactory.CreateRPSCheckBox<ImputationOnLineVMEntityView>("30ba8200-577b-4af4-909d-709439c5901a","","",true, this);
 
            CollectionInit params_ImputationOnLineRejects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c067deac-9e64-4f8e-b5ec-1189fcbb2b52",CSSSelectorGrid="",XPathGrid=""};
            ImputationOnLineRejects = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationOnLineRejectsCollectionEditor<ImputationOnLineVMEntityView>,ImputationOnLineVMEntityView>( params_ImputationOnLineRejects,this);
 

        }
        public IRPSSaveButton<ImputationOnLineVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationOnLineVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationOnLineVMEntityView,ImputationOnLineVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationOnLineVMEntityView,ImputationOnLineVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDMOTask { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> WorkSheetNumber { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> Description { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> ImputationDate { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> StartHour { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> ImputationEndDate { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> EndHour { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> ResourceType { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDMOResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDMOResourceMachine { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDMOResourceTool { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDResourceMachine { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDResourceTool { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> CostQuantity { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> ManufacturedQuantity { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> PercentProgress { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> DedicationPercent { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationOnLineVMEntityView> DocumentNumber { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDHourType { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> CostType { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDMachine { get; set; } 
        public IRPSComboBox<ImputationOnLineVMEntityView> IDUnproductiveType { get; set; } 
        public IRPSCheckbox<ImputationOnLineVMEntityView> Unproductive { get; set; } 
        public IRPSCheckbox<ImputationOnLineVMEntityView> Preparation { get; set; } 
        public ImputationOnLineRejectsCollectionEditor<ImputationOnLineVMEntityView> ImputationOnLineRejects { get; set; } 
        public ImputationOnLine Screen { get; set; }
        public ImputationOnLineVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationOnLineRejectsCollectionEditor<ImputationOnLineVMEntityView>:RPSCollectionEditor<ImputationOnLineVMEntityView> where ImputationOnLineVMEntityView : class, IView
    {
        public  ImputationOnLineRejectsGridView<ImputationOnLineVMEntityView> GridView {get;set;}
    }
    public partial class ImputationOnLineRejectsGridView <ImputationOnLineVMEntityView> :  RPSGridView<ImputationOnLineVMEntityView> where ImputationOnLineVMEntityView : class, IView
    {
        public ImputationOnLineRejectsGridView(ImputationOnLineVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RejectedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationOnLineVMEntityView>("","#c067deac-9e64-4f8e-b5ec-1189fcbb2b52 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQuantity']","",true, this.CurrentView);
 
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<ImputationOnLineVMEntityView>("","#c067deac-9e64-4f8e-b5ec-1189fcbb2b52 .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationOnLineVMEntityView> RejectedQuantity { get; set; } 
        public IRPSGridComboBox<ImputationOnLineVMEntityView> IDRejectionCause { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateChildDialogView : View
    {
        public GenerateChildDialogView(ImputationOnLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OnlyPendingQuantity = RPSControlFactory.CreateRPSOption<GenerateChildDialogView>( "d7c47a09-2a4a-42ba-9c0e-6a67494f1836","","",this);
 
            Quantity = RPSControlFactory.CreateRPSOption<GenerateChildDialogView>( "1a82c83a-0403-4640-a118-92ffd6f0d896","","",this);
 

        }
        public IRPSOption<GenerateChildDialogView> OnlyPendingQuantity { get; set; } 
        public IRPSOption<GenerateChildDialogView> Quantity { get; set; } 
        public ImputationOnLine Screen { get; set; }
        public GenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}