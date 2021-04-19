    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.FollowUpProjectMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class FollowUpProjectMaterial:Screen
    {
        public FollowUpProjectMaterial():base()
        {
            this.URL = "project.followupprojectmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FollowUpProjectMaterialQueryView  = new FollowUpProjectMaterialQueryView(this); 
            FollowUpProjectMaterialTreeView  = new FollowUpProjectMaterialTreeView(this); 
            ProjectMaterialChangeStatusDialogView  = new ProjectMaterialChangeStatusDialogView(this); 
            FollowUpProjectMaterialDetailView  = new FollowUpProjectMaterialDetailView(this); 
            FollowUpProjectMaterialQueryView.InitializeControls(); 
            FollowUpProjectMaterialTreeView.InitializeControls(); 
            ProjectMaterialChangeStatusDialogView.InitializeControls(); 
            FollowUpProjectMaterialDetailView.InitializeControls(); 
           
        }
      
            public FollowUpProjectMaterialQueryView FollowUpProjectMaterialQueryView {get; set; } 
            public FollowUpProjectMaterialTreeView FollowUpProjectMaterialTreeView {get; set; } 
            public ProjectMaterialChangeStatusDialogView ProjectMaterialChangeStatusDialogView {get; set; } 
            public FollowUpProjectMaterialDetailView FollowUpProjectMaterialDetailView {get; set; } 
    }
            
    public partial class FollowUpProjectMaterialQueryView : View
    {
        public FollowUpProjectMaterialQueryView(FollowUpProjectMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<FollowUpProjectMaterialQueryView>("15cb57ab-35ff-4e27-962d-e5ed0a500c25","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<FollowUpProjectMaterialQueryView>("6c0d9755-4e9a-4c1b-8dd4-a8a2cbe1436e","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<FollowUpProjectMaterialQueryView>("1c2c5cd5-ad1c-406b-8cc2-480f381cadc6","","",false, this);
 
            UILstProductLine = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpProjectMaterialQueryView>("47310c62-fbe5-4eec-a76d-8448ac7e71e2","","",false, this);
 
            UILstProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpProjectMaterialQueryView>("f8b862f0-a934-4ebf-95cc-0d2df9d89ff8","","",false, this);
 
            UILstProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpProjectMaterialQueryView>("9f0ce530-0119-426c-ba83-18a08aa32204","","",false, this);
 
            UIOptFirstLevel = RPSControlFactory.CreateRPSOption<FollowUpProjectMaterialQueryView>( "e508ac71-198e-4271-ada5-c168d472f87f","","",this);
 
            UIOptAllLevels = RPSControlFactory.CreateRPSOption<FollowUpProjectMaterialQueryView>( "b2352cff-5662-423f-bf08-7dce7a553f54","","",this);
 

        }
        public IRPSComboBox<FollowUpProjectMaterialQueryView> Project { get; set; } 
        public IRPSComboBox<FollowUpProjectMaterialQueryView> ProjectTask { get; set; } 
        public IRPSComboBox<FollowUpProjectMaterialQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<FollowUpProjectMaterialQueryView> UILstProductLine { get; set; } 
        public IRPSCollectionComboBox<FollowUpProjectMaterialQueryView> UILstProductFamily { get; set; } 
        public IRPSCollectionComboBox<FollowUpProjectMaterialQueryView> UILstProductSubFamily { get; set; } 
        public IRPSOption<FollowUpProjectMaterialQueryView> UIOptFirstLevel { get; set; } 
        public IRPSOption<FollowUpProjectMaterialQueryView> UIOptAllLevels { get; set; } 
        public FollowUpProjectMaterial Screen { get; set; }
        public FollowUpProjectMaterialQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FollowUpProjectMaterialTreeView : View
    {
        public FollowUpProjectMaterialTreeView(FollowUpProjectMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public FollowUpProjectMaterial Screen { get; set; }
        public FollowUpProjectMaterialTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectMaterialChangeStatusDialogView : View
    {
        public ProjectMaterialChangeStatusDialogView(FollowUpProjectMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStatus = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialChangeStatusDialogView>("a38d3592-832b-4d3b-85e2-54b42eb156a6","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<ProjectMaterialChangeStatusDialogView>("020e572f-43a4-4ab8-86b6-4b4dd89e3870","","",false, this);
 

        }
        public IRPSComboBox<ProjectMaterialChangeStatusDialogView> UIStatus { get; set; } 
        public IRPSTextBox<ProjectMaterialChangeStatusDialogView> UIComment { get; set; } 
        public FollowUpProjectMaterial Screen { get; set; }
        public ProjectMaterialChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FollowUpProjectMaterialDetailView : View
    {
        public FollowUpProjectMaterialDetailView(FollowUpProjectMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DescMaterial = RPSControlFactory.CreateRPSTextBox<FollowUpProjectMaterialDetailView>("78d8bfdc-2c01-4f94-ac2d-2154da8f01bf","","",false, this);
 
            SupplySituation = RPSControlFactory.CreateRPSEnumComboBox<FollowUpProjectMaterialDetailView>("b3a6cced-2062-41b6-976b-697dae49ca58","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<FollowUpProjectMaterialDetailView>("97192200-f02d-4dda-8c4d-423d0d84c365","","",false, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<FollowUpProjectMaterialDetailView>("f5b1740d-61fa-4048-88bf-cf87f5ec51d8","","",false, this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<FollowUpProjectMaterialDetailView>("0ffc140d-626a-4345-b400-27223901bfbc","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<FollowUpProjectMaterialDetailView>("67a1300f-5073-4350-ae1b-c8b3383b4107","","",false, this);
 
            UI_ShowRejected = RPSControlFactory.CreateRPSCheckBox<FollowUpProjectMaterialDetailView>("4a09affa-bfbd-4b97-81d1-2ba69aebdf7f","","",false, this);
 
            ReceivedStatus = RPSControlFactory.CreateRPSTextBox<FollowUpProjectMaterialDetailView>("f8285411-d82b-4074-9695-86f7f005a4d5","","",false, this);
 
            ProjectMaterialChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>("75cb1e1e-a392-4c9c-b252-23f903dd89bb","","", this,Screen.ProjectMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpProjectMaterialsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ff500cb8-99f5-462a-868e-9fd547603afd",CSSSelectorGrid="",XPathGrid=""};
            FollowUpProjectMaterialsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpProjectMaterialsConsultCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>,FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>( params_FollowUpProjectMaterialsConsult,this,Screen.ProjectMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpPurchaseOrderDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="614883cc-2fac-44e0-aac9-ef62927a4273",CSSSelectorGrid="",XPathGrid=""};
            FollowUpPurchaseOrderDetails = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>,FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>( params_FollowUpPurchaseOrderDetails,this,Screen.ProjectMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpProjectMaterialsRequestQuotation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3032a25d-e362-4720-b7eb-f0980ddebb8e",CSSSelectorGrid="",XPathGrid=""};
            FollowUpProjectMaterialsRequestQuotation = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpProjectMaterialsRequestQuotationCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>,FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>( params_FollowUpProjectMaterialsRequestQuotation,this,Screen.ProjectMaterialChangeStatusDialogView);
 
            SectionProjectMaterials = RPSControlFactory.CreateRPSSection<FollowUpProjectMaterialDetailView>( "","ul li[rpsid='aa7dc337-2532-471c-86e3-e3c51547e81f']","",this);
 
            SectionRequestQuotation = RPSControlFactory.CreateRPSSection<FollowUpProjectMaterialDetailView>( "","ul li[rpsid='58a6b569-9283-427c-8524-72222fa5bef9']","",this);
 

        }
        public IRPSTextBox<FollowUpProjectMaterialDetailView> DescMaterial { get; set; } 
        public IRPSComboBox<FollowUpProjectMaterialDetailView> SupplySituation { get; set; } 
        public IRPSComboBox<FollowUpProjectMaterialDetailView> Status { get; set; } 
        public IRPSCheckbox<FollowUpProjectMaterialDetailView> Critical { get; set; } 
        public IRPSTextBox<FollowUpProjectMaterialDetailView> PlannedDate { get; set; } 
        public IRPSTextBox<FollowUpProjectMaterialDetailView> Date { get; set; } 
        public IRPSCheckbox<FollowUpProjectMaterialDetailView> UI_ShowRejected { get; set; } 
        public IRPSTextBox<FollowUpProjectMaterialDetailView> ReceivedStatus { get; set; } 
        public IRPSButton<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> ProjectMaterialChangeStatusNavigationCommandButton { get; set; } 
        public FollowUpProjectMaterialsConsultCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> FollowUpProjectMaterialsConsult { get; set; } 
        public FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> FollowUpPurchaseOrderDetails { get; set; } 
        public FollowUpProjectMaterialsRequestQuotationCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> FollowUpProjectMaterialsRequestQuotation { get; set; } 
        public IRPSSection<FollowUpProjectMaterialDetailView> SectionProjectMaterials { get; set; } 
        public IRPSSection<FollowUpProjectMaterialDetailView> SectionRequestQuotation { get; set; } 
        public FollowUpProjectMaterial Screen { get; set; }
        public FollowUpProjectMaterialDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FollowUpProjectMaterialsConsultCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpProjectMaterialsConsultGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpProjectMaterialsConsultGridView <FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> :  RPSGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpProjectMaterialsConsultGridView(FollowUpProjectMaterialDetailView currentView,ProjectMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PlannedDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#ff500cb8-99f5-462a-868e-9fd547603afd .ag-row[role='row']@ROWINDEX [col-id='cPlannedDate']","",false, this.CurrentView);
 
            SupplySituation = RPSControlFactory.CreateRPSGridEnumComboBox<FollowUpProjectMaterialDetailView>("","#ff500cb8-99f5-462a-868e-9fd547603afd .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#ff500cb8-99f5-462a-868e-9fd547603afd .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<FollowUpProjectMaterialDetailView>("","#ff500cb8-99f5-462a-868e-9fd547603afd .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<FollowUpProjectMaterialDetailView>("","#ff500cb8-99f5-462a-868e-9fd547603afd .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> PlannedDate { get; set; } 
        public IRPSGridComboBox<FollowUpProjectMaterialDetailView> SupplySituation { get; set; } 
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> Date { get; set; } 
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> Level { get; set; } 
        public IRPSGridComboBox<FollowUpProjectMaterialDetailView> Status { get; set; } 
                     
    }
 
        public partial class FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpPurchaseOrderDetailsGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpPurchaseOrderDetailsGridView <FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> :  RPSGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpPurchaseOrderDetailsGridView(FollowUpProjectMaterialDetailView currentView,ProjectMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#614883cc-2fac-44e0-aac9-ef62927a4273 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            OrderLineDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#614883cc-2fac-44e0-aac9-ef62927a4273 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineDate']","",false, this.CurrentView);
 
            DeliveryNoteLineDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#614883cc-2fac-44e0-aac9-ef62927a4273 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineDate']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#614883cc-2fac-44e0-aac9-ef62927a4273 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> Date { get; set; } 
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> OrderLineDate { get; set; } 
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> DeliveryNoteLineDate { get; set; } 
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> InvoiceDate { get; set; } 
                     
    }
 
        public partial class FollowUpProjectMaterialsRequestQuotationCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpProjectMaterialsRequestQuotationGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpProjectMaterialsRequestQuotationGridView <FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> :  RPSGridView<FollowUpProjectMaterialDetailView,ProjectMaterialChangeStatusDialogView> where FollowUpProjectMaterialDetailView : class, IView where ProjectMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpProjectMaterialsRequestQuotationGridView(FollowUpProjectMaterialDetailView currentView,ProjectMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ReceivedStatus = RPSControlFactory.CreateRPSGridTextBox<FollowUpProjectMaterialDetailView>("","#3032a25d-e362-4720-b7eb-f0980ddebb8e .ag-row[role='row']@ROWINDEX [col-id='cReceivedStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpProjectMaterialDetailView> ReceivedStatus { get; set; } 
                     
    }
 
    }
  
    

}