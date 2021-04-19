    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.EntityTracking
{
    //RPS VERSION 1.0.0.0
    public partial class EntityTracking:Screen
    {
        public EntityTracking():base()
        {
            this.URL = "general.entitytracking";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EntityTrackingView  = new EntityTrackingView(this); 
            CleanTrackingDataDV  = new CleanTrackingDataDV(this); 
            EntityTrackingView.InitializeControls(); 
            CleanTrackingDataDV.InitializeControls(); 
           
        }
      
            public EntityTrackingView EntityTrackingView {get; set; } 
            public CleanTrackingDataDV CleanTrackingDataDV {get; set; } 
    }
            
    public partial class EntityTrackingView : View
    {
        public EntityTrackingView(EntityTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entities = RPSControlFactory.CreateRPSEnumComboBox<EntityTrackingView>("35111d8a-4013-4c59-ab9c-d41d4550cfaa","","",false, this);
 
            CodEntity = RPSControlFactory.CreateRPSTextBox<EntityTrackingView>("741eaf1f-530e-4de5-9277-77637208c30e","","",false, this);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<EntityTrackingView>("ca4f5755-fe8c-4115-a6d2-bd88af430c9b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<EntityTrackingView>("1d866599-8c52-4168-96ac-e99aa5534eaf","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<EntityTrackingView>("dec02559-5d1b-47d1-9326-a3e9cc71d4f0","","",false, this);
 
            User = RPSControlFactory.CreateRPSComboBox<EntityTrackingView>("61ae0be3-cf8a-4c20-bc09-b53607df2204","","",false, this);
 
            ConsultComm = RPSControlFactory.CreateRPSButton<EntityTrackingView>( "665133b4-778f-4b1f-90e7-beaa6483c599","","",this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EntityTrackingView>("0048c6f2-59a2-43df-a64a-9790d853cda3","","",false, this);
 
            SaveCommButton = RPSControlFactory.CreateRPSButton<EntityTrackingView>( "acde2b9f-0432-4a86-9ed3-e819abf9de35","","",this);
 
            CleanTrackingDataNavCommButton = RPSControlFactory.CreateRPSButtonToView<EntityTrackingView,CleanTrackingDataDV>("c0a51153-a37e-41a2-ab8f-fe9e0226bb5d","","", this,Screen.CleanTrackingDataDV);
 
            CollectionInit params_GetTrackableEntities = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3cd6d9a-4c2f-4451-bc2c-a3b401ac4dcf",CSSSelectorGrid="",XPathGrid=""};
            GetTrackableEntities = RPSControlFactory.RPSCreateCollectionWithGrid<GetTrackableEntitiesCollectionEditor<EntityTrackingView,CleanTrackingDataDV>,EntityTrackingView,CleanTrackingDataDV>( params_GetTrackableEntities,this,Screen.CleanTrackingDataDV);
 
            CollectionInit params_GetEntityTrackings = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="13602bae-7315-4a10-8fbf-6c1b362182c3",CSSSelectorGrid="",XPathGrid=""};
            GetEntityTrackings = RPSControlFactory.RPSCreateCollectionWithGrid<GetEntityTrackingsCollectionEditor<EntityTrackingView,CleanTrackingDataDV>,EntityTrackingView,CleanTrackingDataDV>( params_GetEntityTrackings,this,Screen.CleanTrackingDataDV);
 
            CollectionInit params_GetEntityTrackingDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7fecab55-2d28-4ca5-b4db-727d86dcb1f5",CSSSelectorGrid="",XPathGrid=""};
            GetEntityTrackingDetails = RPSControlFactory.RPSCreateCollectionWithGrid<GetEntityTrackingDetailsCollectionEditor<EntityTrackingView,CleanTrackingDataDV>,EntityTrackingView,CleanTrackingDataDV>( params_GetEntityTrackingDetails,this,Screen.CleanTrackingDataDV);
 

        }
        public IRPSComboBox<EntityTrackingView> Entities { get; set; } 
        public IRPSTextBox<EntityTrackingView> CodEntity { get; set; } 
        public IRPSComboBox<EntityTrackingView> CodCompany { get; set; } 
        public IRPSTextBox<EntityTrackingView> DateFrom { get; set; } 
        public IRPSTextBox<EntityTrackingView> DateTo { get; set; } 
        public IRPSComboBox<EntityTrackingView> User { get; set; } 
        public IRPSButton<EntityTrackingView> ConsultComm { get; set; } 
        public IRPSTextBox<EntityTrackingView> Description { get; set; } 
        public IRPSButton<EntityTrackingView> SaveCommButton { get; set; } 
        public IRPSButton<EntityTrackingView,CleanTrackingDataDV> CleanTrackingDataNavCommButton { get; set; } 
        public GetTrackableEntitiesCollectionEditor<EntityTrackingView,CleanTrackingDataDV> GetTrackableEntities { get; set; } 
        public GetEntityTrackingsCollectionEditor<EntityTrackingView,CleanTrackingDataDV> GetEntityTrackings { get; set; } 
        public GetEntityTrackingDetailsCollectionEditor<EntityTrackingView,CleanTrackingDataDV> GetEntityTrackingDetails { get; set; } 
        public EntityTracking Screen { get; set; }
        public EntityTrackingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTrackableEntitiesCollectionEditor<EntityTrackingView,CleanTrackingDataDV>:RPSCollectionEditor<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public  GetTrackableEntitiesGridView<EntityTrackingView,CleanTrackingDataDV> GridView {get;set;}
    }
    public partial class GetTrackableEntitiesGridView <EntityTrackingView,CleanTrackingDataDV> :  RPSGridView<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public GetTrackableEntitiesGridView(EntityTrackingView currentView,CleanTrackingDataDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TrackingActive = RPSControlFactory.CreateRPSGridCheckBox<EntityTrackingView>("","#b3cd6d9a-4c2f-4451-bc2c-a3b401ac4dcf .ag-row[role='row']@ROWINDEX [col-id='cTrackingActive']","",false, this.CurrentView);
 
            Entity = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#b3cd6d9a-4c2f-4451-bc2c-a3b401ac4dcf .ag-row[role='row']@ROWINDEX [col-id='cEntity']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<EntityTrackingView> TrackingActive { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> Entity { get; set; } 
                     
    }
 
        public partial class GetEntityTrackingsCollectionEditor<EntityTrackingView,CleanTrackingDataDV>:RPSCollectionEditor<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public  GetEntityTrackingsGridView<EntityTrackingView,CleanTrackingDataDV> GridView {get;set;}
    }
    public partial class GetEntityTrackingsGridView <EntityTrackingView,CleanTrackingDataDV> :  RPSGridView<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public GetEntityTrackingsGridView(EntityTrackingView currentView,CleanTrackingDataDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EventType = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cEventType']","",false, this.CurrentView);
 
            EntityType = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",false, this.CurrentView);
 
            EntityCode = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cEntityCode']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            LastModifiedBy = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cLastModifiedBy']","",false, this.CurrentView);
 
            ModifiedDate = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cModifiedDate']","",false, this.CurrentView);
 
            ModifiedTime = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#13602bae-7315-4a10-8fbf-6c1b362182c3 .ag-row[role='row']@ROWINDEX [col-id='cModifiedTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EntityTrackingView> EventType { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> EntityType { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> EntityCode { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> Description { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> LastModifiedBy { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> ModifiedDate { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> ModifiedTime { get; set; } 
                     
    }
 
        public partial class GetEntityTrackingDetailsCollectionEditor<EntityTrackingView,CleanTrackingDataDV>:RPSCollectionEditor<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public  GetEntityTrackingDetailsGridView<EntityTrackingView,CleanTrackingDataDV> GridView {get;set;}
    }
    public partial class GetEntityTrackingDetailsGridView <EntityTrackingView,CleanTrackingDataDV> :  RPSGridView<EntityTrackingView,CleanTrackingDataDV> where EntityTrackingView : class, IView where CleanTrackingDataDV : class, IView
    {
        public GetEntityTrackingDetailsGridView(EntityTrackingView currentView,CleanTrackingDataDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PropertyName = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#7fecab55-2d28-4ca5-b4db-727d86dcb1f5 .ag-row[role='row']@ROWINDEX [col-id='cPropertyName']","",false, this.CurrentView);
 
            PropertyValue = RPSControlFactory.CreateRPSGridTextBox<EntityTrackingView>("","#7fecab55-2d28-4ca5-b4db-727d86dcb1f5 .ag-row[role='row']@ROWINDEX [col-id='cPropertyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EntityTrackingView> PropertyName { get; set; } 
        public IRPSGridTextBox<EntityTrackingView> PropertyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class CleanTrackingDataDV : View
    {
        public CleanTrackingDataDV(EntityTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteEntityFilter = RPSControlFactory.CreateRPSEnumComboBox<CleanTrackingDataDV>("4ba8814e-74fd-46fe-abea-7d8ca835a46d","","",false, this);
 
            Entities = RPSControlFactory.CreateRPSEnumComboBox<CleanTrackingDataDV>("426f5760-699a-4c5b-abd7-3f2b5138aadb","","",false, this);
 
            DeleteFromDatesFilter = RPSControlFactory.CreateRPSEnumComboBox<CleanTrackingDataDV>("1a1aabad-04b6-4c26-a616-85b9d40bc835","","",false, this);
 
            OlderThan = RPSControlFactory.CreateRPSTextBox<CleanTrackingDataDV>("41e96573-8dc1-4ae4-96aa-adc816f7402e","","",false, this);
 

        }
        public IRPSComboBox<CleanTrackingDataDV> DeleteEntityFilter { get; set; } 
        public IRPSComboBox<CleanTrackingDataDV> Entities { get; set; } 
        public IRPSComboBox<CleanTrackingDataDV> DeleteFromDatesFilter { get; set; } 
        public IRPSTextBox<CleanTrackingDataDV> OlderThan { get; set; } 
        public EntityTracking Screen { get; set; }
        public CleanTrackingDataDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}