    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.FollowUpManufacturingOrderMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class FollowUpManufacturingOrderMaterial:Screen
    {
        public FollowUpManufacturingOrderMaterial():base()
        {
            this.URL = "manufacturing.followupmanufacturingordermaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FollowUpManufacturingOrderMaterialQueryView  = new FollowUpManufacturingOrderMaterialQueryView(this); 
            FollowUpManufacturingOrderMaterialTreeView  = new FollowUpManufacturingOrderMaterialTreeView(this); 
            FollowUpManufacturingOrderMaterialDetailView  = new FollowUpManufacturingOrderMaterialDetailView(this); 
            ManufacturingOrderMaterialChangeStatusDialogView  = new ManufacturingOrderMaterialChangeStatusDialogView(this); 
            FollowUpManufacturingOrderMaterialQueryView.InitializeControls(); 
            FollowUpManufacturingOrderMaterialTreeView.InitializeControls(); 
            FollowUpManufacturingOrderMaterialDetailView.InitializeControls(); 
            ManufacturingOrderMaterialChangeStatusDialogView.InitializeControls(); 
           
        }
      
            public FollowUpManufacturingOrderMaterialQueryView FollowUpManufacturingOrderMaterialQueryView {get; set; } 
            public FollowUpManufacturingOrderMaterialTreeView FollowUpManufacturingOrderMaterialTreeView {get; set; } 
            public FollowUpManufacturingOrderMaterialDetailView FollowUpManufacturingOrderMaterialDetailView {get; set; } 
            public ManufacturingOrderMaterialChangeStatusDialogView ManufacturingOrderMaterialChangeStatusDialogView {get; set; } 
    }
            
    public partial class FollowUpManufacturingOrderMaterialQueryView : View
    {
        public FollowUpManufacturingOrderMaterialQueryView(FollowUpManufacturingOrderMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<FollowUpManufacturingOrderMaterialQueryView>("c8a4763b-f053-4d10-8bb9-219679513ba3","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<FollowUpManufacturingOrderMaterialQueryView>("3ab2bea8-ebeb-4ed0-90e7-6f380168a741","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSComboBox<FollowUpManufacturingOrderMaterialQueryView>("63fde44e-033e-4fc1-9585-51744246108a","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<FollowUpManufacturingOrderMaterialQueryView>("efabe1e7-da5e-42c9-9d4c-ea83240cf512","","",false, this);
 
            UILstProductLine = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView>("b6aa6010-930b-4c6f-9620-6f730412096a","","",false, this);
 
            UILstProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView>("f60ea488-84c0-4bcc-bd9d-8b1230360303","","",false, this);
 
            UILstProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView>("87978527-8958-49b3-954a-650ca53f8578","","",false, this);
 
            UIOptFirstLevel = RPSControlFactory.CreateRPSOption<FollowUpManufacturingOrderMaterialQueryView>( "465979ee-5f9b-45b6-bf4b-17f9fae2445e","","",this);
 
            UIOptAllLevels = RPSControlFactory.CreateRPSOption<FollowUpManufacturingOrderMaterialQueryView>( "5553f5aa-ec18-4509-820a-aef7f02d0ff9","","",this);
 

        }
        public IRPSComboBox<FollowUpManufacturingOrderMaterialQueryView> Site { get; set; } 
        public IRPSComboBox<FollowUpManufacturingOrderMaterialQueryView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<FollowUpManufacturingOrderMaterialQueryView> MOTask { get; set; } 
        public IRPSComboBox<FollowUpManufacturingOrderMaterialQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView> UILstProductLine { get; set; } 
        public IRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView> UILstProductFamily { get; set; } 
        public IRPSCollectionComboBox<FollowUpManufacturingOrderMaterialQueryView> UILstProductSubFamily { get; set; } 
        public IRPSOption<FollowUpManufacturingOrderMaterialQueryView> UIOptFirstLevel { get; set; } 
        public IRPSOption<FollowUpManufacturingOrderMaterialQueryView> UIOptAllLevels { get; set; } 
        public FollowUpManufacturingOrderMaterial Screen { get; set; }
        public FollowUpManufacturingOrderMaterialQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FollowUpManufacturingOrderMaterialTreeView : View
    {
        public FollowUpManufacturingOrderMaterialTreeView(FollowUpManufacturingOrderMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public FollowUpManufacturingOrderMaterial Screen { get; set; }
        public FollowUpManufacturingOrderMaterialTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FollowUpManufacturingOrderMaterialDetailView : View
    {
        public FollowUpManufacturingOrderMaterialDetailView(FollowUpManufacturingOrderMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PlannedDate = RPSControlFactory.CreateRPSTextBox<FollowUpManufacturingOrderMaterialDetailView>("27146552-c9f1-4694-a7f0-13ad02eb757a","","",false, this);
 
            SupplySituation = RPSControlFactory.CreateRPSEnumComboBox<FollowUpManufacturingOrderMaterialDetailView>("52e29c86-bcd3-4853-8d93-5e87e544cf24","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<FollowUpManufacturingOrderMaterialDetailView>("e21b13cf-c456-47b4-8bf2-7efa50106e88","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<FollowUpManufacturingOrderMaterialDetailView>("24d973f6-e794-4a7f-9fa4-1517b15a6951","","",false, this);
 
            UI_ShowRejected = RPSControlFactory.CreateRPSCheckBox<FollowUpManufacturingOrderMaterialDetailView>("f40cbdbd-3583-4fb0-bbc8-3ccc367bf0df","","",false, this);
 
            ReceivedStatus = RPSControlFactory.CreateRPSTextBox<FollowUpManufacturingOrderMaterialDetailView>("5c568bbf-c9d6-44cf-9a5b-3928d4dc6b89","","",false, this);
 
            ManufacturingOrderMaterialChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>("a4f7402e-3a7c-42ae-bdcc-cf4e2f173519","","", this,Screen.ManufacturingOrderMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpManufacturingOrderMaterialsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8a39c7ac-e2ac-480a-a634-9421deb19fb2",CSSSelectorGrid="",XPathGrid=""};
            FollowUpManufacturingOrderMaterialsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpManufacturingOrderMaterialsConsultCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>,FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>( params_FollowUpManufacturingOrderMaterialsConsult,this,Screen.ManufacturingOrderMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpPurchaseOrderDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c1b03b9-78ab-4459-a944-19fc646154b0",CSSSelectorGrid="",XPathGrid=""};
            FollowUpPurchaseOrderDetails = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>,FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>( params_FollowUpPurchaseOrderDetails,this,Screen.ManufacturingOrderMaterialChangeStatusDialogView);
 
            CollectionInit params_FollowUpManufacturingOrderMaterialsRequestQuotation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f8ff3763-7280-499b-94a9-208ca3c81a74",CSSSelectorGrid="",XPathGrid=""};
            FollowUpManufacturingOrderMaterialsRequestQuotation = RPSControlFactory.RPSCreateCollectionWithGrid<FollowUpManufacturingOrderMaterialsRequestQuotationCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>,FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>( params_FollowUpManufacturingOrderMaterialsRequestQuotation,this,Screen.ManufacturingOrderMaterialChangeStatusDialogView);
 
            SectionManufacturingOrderMaterials = RPSControlFactory.CreateRPSSection<FollowUpManufacturingOrderMaterialDetailView>( "","ul li[rpsid='e5b789fe-0f9b-48cd-85d5-83be163b37cf']","",this);
 
            SectionRequestQuotation = RPSControlFactory.CreateRPSSection<FollowUpManufacturingOrderMaterialDetailView>( "","ul li[rpsid='42de20e3-9d19-492b-8736-20d5f9125a88']","",this);
 

        }
        public IRPSTextBox<FollowUpManufacturingOrderMaterialDetailView> PlannedDate { get; set; } 
        public IRPSComboBox<FollowUpManufacturingOrderMaterialDetailView> SupplySituation { get; set; } 
        public IRPSComboBox<FollowUpManufacturingOrderMaterialDetailView> Status { get; set; } 
        public IRPSTextBox<FollowUpManufacturingOrderMaterialDetailView> Date { get; set; } 
        public IRPSCheckbox<FollowUpManufacturingOrderMaterialDetailView> UI_ShowRejected { get; set; } 
        public IRPSTextBox<FollowUpManufacturingOrderMaterialDetailView> ReceivedStatus { get; set; } 
        public IRPSButton<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> ManufacturingOrderMaterialChangeStatusNavigationCommandButton { get; set; } 
        public FollowUpManufacturingOrderMaterialsConsultCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> FollowUpManufacturingOrderMaterialsConsult { get; set; } 
        public FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> FollowUpPurchaseOrderDetails { get; set; } 
        public FollowUpManufacturingOrderMaterialsRequestQuotationCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> FollowUpManufacturingOrderMaterialsRequestQuotation { get; set; } 
        public IRPSSection<FollowUpManufacturingOrderMaterialDetailView> SectionManufacturingOrderMaterials { get; set; } 
        public IRPSSection<FollowUpManufacturingOrderMaterialDetailView> SectionRequestQuotation { get; set; } 
        public FollowUpManufacturingOrderMaterial Screen { get; set; }
        public FollowUpManufacturingOrderMaterialDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FollowUpManufacturingOrderMaterialsConsultCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpManufacturingOrderMaterialsConsultGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpManufacturingOrderMaterialsConsultGridView <FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> :  RPSGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpManufacturingOrderMaterialsConsultGridView(FollowUpManufacturingOrderMaterialDetailView currentView,ManufacturingOrderMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PlannedDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#8a39c7ac-e2ac-480a-a634-9421deb19fb2 .ag-row[role='row']@ROWINDEX [col-id='cPlannedDate']","",false, this.CurrentView);
 
            SupplySituation = RPSControlFactory.CreateRPSGridEnumComboBox<FollowUpManufacturingOrderMaterialDetailView>("","#8a39c7ac-e2ac-480a-a634-9421deb19fb2 .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#8a39c7ac-e2ac-480a-a634-9421deb19fb2 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#8a39c7ac-e2ac-480a-a634-9421deb19fb2 .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<FollowUpManufacturingOrderMaterialDetailView>("","#8a39c7ac-e2ac-480a-a634-9421deb19fb2 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> PlannedDate { get; set; } 
        public IRPSGridComboBox<FollowUpManufacturingOrderMaterialDetailView> SupplySituation { get; set; } 
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> Date { get; set; } 
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> Level { get; set; } 
        public IRPSGridComboBox<FollowUpManufacturingOrderMaterialDetailView> Status { get; set; } 
                     
    }
 
        public partial class FollowUpPurchaseOrderDetailsCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpPurchaseOrderDetailsGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpPurchaseOrderDetailsGridView <FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> :  RPSGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpPurchaseOrderDetailsGridView(FollowUpManufacturingOrderMaterialDetailView currentView,ManufacturingOrderMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#6c1b03b9-78ab-4459-a944-19fc646154b0 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            OrderLineDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#6c1b03b9-78ab-4459-a944-19fc646154b0 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineDate']","",false, this.CurrentView);
 
            DeliveryNoteLineDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#6c1b03b9-78ab-4459-a944-19fc646154b0 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineDate']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#6c1b03b9-78ab-4459-a944-19fc646154b0 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> Date { get; set; } 
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> OrderLineDate { get; set; } 
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> DeliveryNoteLineDate { get; set; } 
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> InvoiceDate { get; set; } 
                     
    }
 
        public partial class FollowUpManufacturingOrderMaterialsRequestQuotationCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView>:RPSCollectionEditor<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public  FollowUpManufacturingOrderMaterialsRequestQuotationGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> GridView {get;set;}
    }
    public partial class FollowUpManufacturingOrderMaterialsRequestQuotationGridView <FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> :  RPSGridView<FollowUpManufacturingOrderMaterialDetailView,ManufacturingOrderMaterialChangeStatusDialogView> where FollowUpManufacturingOrderMaterialDetailView : class, IView where ManufacturingOrderMaterialChangeStatusDialogView : class, IView
    {
        public FollowUpManufacturingOrderMaterialsRequestQuotationGridView(FollowUpManufacturingOrderMaterialDetailView currentView,ManufacturingOrderMaterialChangeStatusDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ReceivedStatus = RPSControlFactory.CreateRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView>("","#f8ff3763-7280-499b-94a9-208ca3c81a74 .ag-row[role='row']@ROWINDEX [col-id='cReceivedStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FollowUpManufacturingOrderMaterialDetailView> ReceivedStatus { get; set; } 
                     
    }
 
    }
  
            
    public partial class ManufacturingOrderMaterialChangeStatusDialogView : View
    {
        public ManufacturingOrderMaterialChangeStatusDialogView(FollowUpManufacturingOrderMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStatus = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderMaterialChangeStatusDialogView>("626cdf51-e60a-4550-a84e-58aa42d02042","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderMaterialChangeStatusDialogView>("fa14419f-6600-4520-8b64-d3dc0c54a84e","","",false, this);
 

        }
        public IRPSComboBox<ManufacturingOrderMaterialChangeStatusDialogView> UIStatus { get; set; } 
        public IRPSTextBox<ManufacturingOrderMaterialChangeStatusDialogView> UIComment { get; set; } 
        public FollowUpManufacturingOrderMaterial Screen { get; set; }
        public ManufacturingOrderMaterialChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}