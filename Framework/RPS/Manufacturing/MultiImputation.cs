    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MultiImputation
{
    //RPS VERSION 1.0.0.0
    public partial class MultiImputation:Screen
    {
        public MultiImputation():base()
        {
            this.URL = "manufacturing.multiimputation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MultiImputationVMQueryView  = new MultiImputationVMQueryView(this); 
            MultiImputationVMEntityView  = new MultiImputationVMEntityView(this); 
            MultiImputationResourceView  = new MultiImputationResourceView(this); 
            MultiImputationTaskView  = new MultiImputationTaskView(this); 
            GenerateMultiImputationDialogView  = new GenerateMultiImputationDialogView(this); 
            MultiImputationVMQueryView.InitializeControls(); 
            MultiImputationVMEntityView.InitializeControls(); 
            MultiImputationResourceView.InitializeControls(); 
            MultiImputationTaskView.InitializeControls(); 
            GenerateMultiImputationDialogView.InitializeControls(); 
           
        }
      
            public MultiImputationVMQueryView MultiImputationVMQueryView {get; set; } 
            public MultiImputationVMEntityView MultiImputationVMEntityView {get; set; } 
            public MultiImputationResourceView MultiImputationResourceView {get; set; } 
            public MultiImputationTaskView MultiImputationTaskView {get; set; } 
            public GenerateMultiImputationDialogView GenerateMultiImputationDialogView {get; set; } 
    }
            
    public partial class MultiImputationVMQueryView : View
    {
        public MultiImputationVMQueryView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MultiImputationVMQueryView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MultiImputationVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<MultiImputationVMQueryView>("79ccd4c2-79bc-4983-8b9a-95bda3f24cc0","","",false, this);
 
            CollectionInit params_MultiImputationQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d0811aee-cff0-4929-af47-6726d01209b2",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationQuery = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationQueryCollectionEditor<MultiImputationVMQueryView,MultiImputationVMEntityView>,MultiImputationVMQueryView,MultiImputationVMEntityView>( params_MultiImputationQuery,this,Screen.MultiImputationVMEntityView);
 

        }
        public IRPSButton<MultiImputationVMQueryView,MultiImputationVMEntityView> NewButton { get; set; } 
        public IRPSButton<MultiImputationVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<MultiImputationVMQueryView> Site { get; set; } 
        public MultiImputationQueryCollectionEditor<MultiImputationVMQueryView,MultiImputationVMEntityView> MultiImputationQuery { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationQueryCollectionEditor<MultiImputationVMQueryView,MultiImputationVMEntityView>:RPSCollectionEditor<MultiImputationVMQueryView,MultiImputationVMEntityView> where MultiImputationVMQueryView : class, IView where MultiImputationVMEntityView : class, IView
    {
        public  MultiImputationQueryGridView<MultiImputationVMQueryView,MultiImputationVMEntityView> GridView {get;set;}
    }
    public partial class MultiImputationQueryGridView <MultiImputationVMQueryView,MultiImputationVMEntityView> :  RPSGridView<MultiImputationVMQueryView,MultiImputationVMEntityView> where MultiImputationVMQueryView : class, IView where MultiImputationVMEntityView : class, IView
    {
        public MultiImputationQueryGridView(MultiImputationVMQueryView currentView,MultiImputationVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class MultiImputationVMEntityView : View
    {
        public MultiImputationVMEntityView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MultiImputationVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationVMEntityView,MultiImputationVMQueryView>( this,Screen.MultiImputationVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationVMEntityView,MultiImputationVMQueryView>( this,Screen.MultiImputationVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MultiImputationVMEntityView>("a4545c4b-8a15-4408-bf65-4f98d2319d0d","","",true, this);
 
            CodWork = RPSControlFactory.CreateRPSTextBox<MultiImputationVMEntityView>("d216632e-7979-4c96-821c-73157203dd89","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MultiImputationVMEntityView>("ff846e9f-8d03-4ea3-a52a-16cbda62359b","","",false, this);
 
            WorkDate = RPSControlFactory.CreateRPSTextBox<MultiImputationVMEntityView>("cefbd843-9fdb-4254-87f6-a90ce5eb8636","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MultiImputationVMEntityView>("757c3f03-c73c-4141-838f-63193ae14c28","","",false, this);
 
            SituationType = RPSControlFactory.CreateRPSCheckBox<MultiImputationVMEntityView>("0c1616ce-cd81-4b6a-93db-7e2e5cc6d729","","",false, this);
 
            GenerateMultiImputationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MultiImputationVMEntityView,GenerateMultiImputationDialogView>("77aa4cdf-7b17-44dc-aaf6-3baffc10223d","","", this,Screen.GenerateMultiImputationDialogView);
 
            CollectionInit params_MultiImputationTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="609d247d-9cb4-428f-ad52-bd246e88fee2",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationTasksCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView>,MultiImputationVMEntityView,MultiImputationResourceView>( params_MultiImputationTasks,this,Screen.MultiImputationResourceView);
 
            CollectionInit params_MultiImputationResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="524eba1f-3618-4cc1-9939-4bea72f55ee5",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationResources = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationResourcesCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView>,MultiImputationVMEntityView,MultiImputationResourceView>( params_MultiImputationResources,this,Screen.MultiImputationResourceView);
 

        }
        public IRPSSaveButton<MultiImputationVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MultiImputationVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationVMEntityView,MultiImputationVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationVMEntityView,MultiImputationVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<MultiImputationVMEntityView> IDSite { get; set; } 
        public IRPSTextBox<MultiImputationVMEntityView> CodWork { get; set; } 
        public IRPSTextBox<MultiImputationVMEntityView> Description { get; set; } 
        public IRPSTextBox<MultiImputationVMEntityView> WorkDate { get; set; } 
        public IRPSComboBox<MultiImputationVMEntityView> IDMachine { get; set; } 
        public IRPSCheckbox<MultiImputationVMEntityView> SituationType { get; set; } 
        public IRPSButton<MultiImputationVMEntityView,GenerateMultiImputationDialogView> GenerateMultiImputationNavigationCommandButton { get; set; } 
        public MultiImputationTasksCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView> MultiImputationTasks { get; set; } 
        public MultiImputationResourcesCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView> MultiImputationResources { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationTasksCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView>:RPSCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView> where MultiImputationVMEntityView : class, IView where MultiImputationResourceView : class, IView
    {
        public  MultiImputationTasksGridView<MultiImputationVMEntityView,MultiImputationResourceView> GridView {get;set;}
    }
    public partial class MultiImputationTasksGridView <MultiImputationVMEntityView,MultiImputationResourceView> :  RPSGridView<MultiImputationVMEntityView,MultiImputationResourceView> where MultiImputationVMEntityView : class, IView where MultiImputationResourceView : class, IView
    {
        public MultiImputationTasksGridView(MultiImputationVMEntityView currentView,MultiImputationResourceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cIDManufacturingOrder']","",true, this.CurrentView);
 
            IDMOTask = RPSControlFactory.CreateRPSGridComboBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cIDMOTask']","",true, this.CurrentView);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSGridTextBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cWorkSheetNumber']","",false, this.CurrentView);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cManufacturedQuantity']","",true, this.CurrentView);
 
            RejectedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQuantity']","",true, this.CurrentView);
 
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<MultiImputationVMEntityView>("","#609d247d-9cb4-428f-ad52-bd246e88fee2 .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MultiImputationVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSGridComboBox<MultiImputationVMEntityView> IDMOTask { get; set; } 
        public IRPSGridTextBox<MultiImputationVMEntityView> WorkSheetNumber { get; set; } 
        public IRPSGridTextBox<MultiImputationVMEntityView> ManufacturedQuantity { get; set; } 
        public IRPSGridTextBox<MultiImputationVMEntityView> RejectedQuantity { get; set; } 
        public IRPSGridComboBox<MultiImputationVMEntityView> IDRejectionCause { get; set; } 
                     
    }
 
        public partial class MultiImputationResourcesCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView>:RPSCollectionEditor<MultiImputationVMEntityView,MultiImputationResourceView> where MultiImputationVMEntityView : class, IView where MultiImputationResourceView : class, IView
    {
        public  MultiImputationResourcesGridView<MultiImputationVMEntityView,MultiImputationResourceView> GridView {get;set;}
    }
    public partial class MultiImputationResourcesGridView <MultiImputationVMEntityView,MultiImputationResourceView> :  RPSGridView<MultiImputationVMEntityView,MultiImputationResourceView> where MultiImputationVMEntityView : class, IView where MultiImputationResourceView : class, IView
    {
        public MultiImputationResourcesGridView(MultiImputationVMEntityView currentView,MultiImputationResourceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ResourceType = RPSControlFactory.CreateRPSGridEnumComboBox<MultiImputationVMEntityView>("","#524eba1f-3618-4cc1-9939-4bea72f55ee5 .ag-row[role='row']@ROWINDEX [col-id='cResourceType']","",true, this.CurrentView);
 
            IDResourceSelector = RPSControlFactory.CreateRPSGridComboBox<MultiImputationVMEntityView>("","#524eba1f-3618-4cc1-9939-4bea72f55ee5 .ag-row[role='row']@ROWINDEX [col-id='cIDResourceSelector']","",false, this.CurrentView);
 
            StartHour = RPSControlFactory.CreateRPSGridTextBox<MultiImputationVMEntityView>("","#524eba1f-3618-4cc1-9939-4bea72f55ee5 .ag-row[role='row']@ROWINDEX [col-id='cStartHour']","",true, this.CurrentView);
 
            EndHour = RPSControlFactory.CreateRPSGridTextBox<MultiImputationVMEntityView>("","#524eba1f-3618-4cc1-9939-4bea72f55ee5 .ag-row[role='row']@ROWINDEX [col-id='cEndHour']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MultiImputationVMEntityView> ResourceType { get; set; } 
        public IRPSGridComboBox<MultiImputationVMEntityView> IDResourceSelector { get; set; } 
        public IRPSGridTextBox<MultiImputationVMEntityView> StartHour { get; set; } 
        public IRPSGridTextBox<MultiImputationVMEntityView> EndHour { get; set; } 
                     
    }
 
    }
  
            
    public partial class MultiImputationResourceView : View
    {
        public MultiImputationResourceView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationResourceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationResourceView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationResourceView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MultiImputationResourceView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<MultiImputationResourceView>("81f24909-9907-486a-853d-5f54c4fbdddf","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MultiImputationResourceView>("3398dc18-ec5c-410d-a68a-c3f5e98d68eb","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MultiImputationResourceView>("fd694a2a-43a9-437a-a440-a7621a417811","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<MultiImputationResourceView>("1164e774-65cf-4eb6-95fe-67268672f9e5","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<MultiImputationResourceView>("37209d7e-e59f-4c3a-a202-4e3cf5f7d8d4","","",true, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<MultiImputationResourceView>("e3c1a373-5f2e-4449-9d60-4d4e063f9a02","","",true, this);
 

        }
        public IRPSButton<MultiImputationResourceView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationResourceView,MultiImputationVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationResourceView,MultiImputationVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MultiImputationResourceView,MultiImputationVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MultiImputationResourceView> ResourceType { get; set; } 
        public IRPSComboBox<MultiImputationResourceView> IDEmployee { get; set; } 
        public IRPSComboBox<MultiImputationResourceView> IDMachine { get; set; } 
        public IRPSComboBox<MultiImputationResourceView> IDTool { get; set; } 
        public IRPSTextBox<MultiImputationResourceView> StartHour { get; set; } 
        public IRPSTextBox<MultiImputationResourceView> EndHour { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationResourceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MultiImputationTaskView : View
    {
        public MultiImputationTaskView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationTaskView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationTaskView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MultiImputationTaskView,MultiImputationVMEntityView>( this,Screen.MultiImputationVMEntityView);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<MultiImputationTaskView>("3dc2d5b4-c3b3-40b9-b36d-c771d481eee7","","",true, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<MultiImputationTaskView>("27d5c903-8d66-4411-a314-5ebdb249bc65","","",true, this);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSTextBox<MultiImputationTaskView>("cd493b95-7153-4e54-9d43-f6a65e03d59b","","",false, this);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MultiImputationTaskView>("c062d088-bee2-4a31-a861-79c22079310c","","",true, this);
 
            RejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MultiImputationTaskView>("4ab7317f-bcaf-4aa8-8e9d-9dcaa9353236","","",true, this);
 
            IDRejectionCause = RPSControlFactory.CreateRPSComboBox<MultiImputationTaskView>("65ceaef0-b7c7-4175-b808-b8efff26900b","","",false, this);
 
            CollectionInit params_MultiImputationTaskRejects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5f8a10c-0655-425e-87d2-16cc5607d170",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationTaskRejects = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationTaskRejectsCollectionEditor<MultiImputationTaskView>,MultiImputationTaskView>( params_MultiImputationTaskRejects,this);
 

        }
        public IRPSButton<MultiImputationTaskView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationTaskView,MultiImputationVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationTaskView,MultiImputationVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MultiImputationTaskView,MultiImputationVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MultiImputationTaskView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<MultiImputationTaskView> IDMOTask { get; set; } 
        public IRPSTextBox<MultiImputationTaskView> WorkSheetNumber { get; set; } 
        public IRPSTextBox<MultiImputationTaskView> ManufacturedQuantity { get; set; } 
        public IRPSTextBox<MultiImputationTaskView> RejectedQuantity { get; set; } 
        public IRPSComboBox<MultiImputationTaskView> IDRejectionCause { get; set; } 
        public MultiImputationTaskRejectsCollectionEditor<MultiImputationTaskView> MultiImputationTaskRejects { get; set; } 
        public MultiImputation Screen { get; set; }
        public MultiImputationTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationTaskRejectsCollectionEditor<MultiImputationTaskView>:RPSCollectionEditor<MultiImputationTaskView> where MultiImputationTaskView : class, IView
    {
        public  MultiImputationTaskRejectsGridView<MultiImputationTaskView> GridView {get;set;}
    }
    public partial class MultiImputationTaskRejectsGridView <MultiImputationTaskView> :  RPSGridView<MultiImputationTaskView> where MultiImputationTaskView : class, IView
    {
        public MultiImputationTaskRejectsGridView(MultiImputationTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RejectedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationTaskView>("","#d5f8a10c-0655-425e-87d2-16cc5607d170 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQuantity']","",true, this.CurrentView);
 
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<MultiImputationTaskView>("","#d5f8a10c-0655-425e-87d2-16cc5607d170 .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MultiImputationTaskView> RejectedQuantity { get; set; } 
        public IRPSGridComboBox<MultiImputationTaskView> IDRejectionCause { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateMultiImputationDialogView : View
    {
        public GenerateMultiImputationDialogView(MultiImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OnlyPendingQuantity = RPSControlFactory.CreateRPSOption<GenerateMultiImputationDialogView>( "625a1bd4-a887-411c-9a26-8ebca672f361","","",this);
 
            IntroducedQuantity = RPSControlFactory.CreateRPSOption<GenerateMultiImputationDialogView>( "435ba73e-2fdc-4919-ae49-7e1dedbe3ecf","","",this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<GenerateMultiImputationDialogView>( "83fbcb12-9df4-4db8-9e9d-e37295c599fb","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<GenerateMultiImputationDialogView>( "67fe6907-8df8-4430-923b-bdea24eb10c2","","",this);
 

        }
        public IRPSOption<GenerateMultiImputationDialogView> OnlyPendingQuantity { get; set; } 
        public IRPSOption<GenerateMultiImputationDialogView> IntroducedQuantity { get; set; } 
        public IRPSButton<GenerateMultiImputationDialogView> OKCommand { get; set; } 
        public IRPSButton<GenerateMultiImputationDialogView> LinkNavigationCommand { get; set; } 
        public MultiImputation Screen { get; set; }
        public GenerateMultiImputationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}