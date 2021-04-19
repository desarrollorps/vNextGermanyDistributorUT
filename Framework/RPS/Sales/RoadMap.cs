    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.RoadMap
{
    //RPS VERSION 1.0.0.0
    public partial class RoadMap:Screen
    {
        public RoadMap():base()
        {
            this.URL = "sales.roadmap";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RoadMapSLCollectionView  = new RoadMapSLCollectionView(this); 
            RoadMapSLEntityView  = new RoadMapSLEntityView(this); 
            RoadMapDetailSLView  = new RoadMapDetailSLView(this); 
            RoadMapNewDetailsDialogView  = new RoadMapNewDetailsDialogView(this); 
            RoadMapAutomaticDialogView  = new RoadMapAutomaticDialogView(this); 
            OrderGenerationDialogView  = new OrderGenerationDialogView(this); 
            RoadMapSLCollectionView.InitializeControls(); 
            RoadMapSLEntityView.InitializeControls(); 
            RoadMapDetailSLView.InitializeControls(); 
            RoadMapNewDetailsDialogView.InitializeControls(); 
            RoadMapAutomaticDialogView.InitializeControls(); 
            OrderGenerationDialogView.InitializeControls(); 
           
        }
      
            public RoadMapSLCollectionView RoadMapSLCollectionView {get; set; } 
            public RoadMapSLEntityView RoadMapSLEntityView {get; set; } 
            public RoadMapDetailSLView RoadMapDetailSLView {get; set; } 
            public RoadMapNewDetailsDialogView RoadMapNewDetailsDialogView {get; set; } 
            public RoadMapAutomaticDialogView RoadMapAutomaticDialogView {get; set; } 
            public OrderGenerationDialogView OrderGenerationDialogView {get; set; } 
    }
            
    public partial class RoadMapSLCollectionView : View
    {
        public RoadMapSLCollectionView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RoadMapSLCollectionView,RoadMapSLEntityView>( this,Screen.RoadMapSLEntityView);
 
            OrderGenerationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RoadMapSLCollectionView,OrderGenerationDialogView>("f5485c93-8ce3-47c3-83ae-2f15cda3913b","","", this,Screen.OrderGenerationDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "630540dc-94f2-4b97-9194-3aaa3e707850",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RoadMapSLCollectionView,RoadMapSLEntityView>( params_MainConsult,this,Screen.RoadMapSLEntityView);
 

        }
        public IRPSButton<RoadMapSLCollectionView,RoadMapSLEntityView> NewButton { get; set; } 
        public IRPSButton<RoadMapSLCollectionView,OrderGenerationDialogView> OrderGenerationNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<RoadMapSLCollectionView,RoadMapSLEntityView> MainConsult { get; set; } 
        public RoadMap Screen { get; set; }
        public RoadMapSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RoadMapSLEntityView : View
    {
        public RoadMapSLEntityView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RoadMapSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RoadMapSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RoadMapSLEntityView,RoadMapSLCollectionView>( this,Screen.RoadMapSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RoadMapSLEntityView,RoadMapSLCollectionView>( this,Screen.RoadMapSLCollectionView);
 
            CodRoadMap = RPSControlFactory.CreateRPSTextBox<RoadMapSLEntityView>("b5e83db5-45ec-49ab-9eb1-5b3ae1692e2c","","",true, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<RoadMapSLEntityView>("899b1eea-5615-42bb-aea3-485a41405ea3","","",true, this);
 
            ExpeditionDate = RPSControlFactory.CreateRPSTextBox<RoadMapSLEntityView>("c6f16efd-5b11-43a4-838a-5b80f7bf4e4b","","",true, this);
 
            Finished = RPSControlFactory.CreateRPSCheckBox<RoadMapSLEntityView>("be3b0b36-7345-4b22-8da0-6c81f6f3bfc1","","",true, this);
 
            IDShippingVehicle = RPSControlFactory.CreateRPSComboBox<RoadMapSLEntityView>("87ee8e1b-a8d4-49ee-981b-3eb021013d87","","",false, this);
 
            UIVehicleNumber = RPSControlFactory.CreateRPSTextBox<RoadMapSLEntityView>("ee771b54-980d-4022-96e0-91eb4088569a","","",false, this);
 
            UITowNumber = RPSControlFactory.CreateRPSTextBox<RoadMapSLEntityView>("ad323b3d-44ac-4663-ba60-d17311a896fe","","",false, this);
 
            UIBoxes = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("b53243d1-26d9-4d33-9c52-8dface18ad02","","",false, this);
 
            NumBoxes = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("f7e9f16c-c02e-41ec-927c-21e9c9dbbc3b","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("00bc14d3-73cf-4ee9-92ac-bf1b70aa61cd","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("39700cd9-9c71-4978-a22e-f7dce82b8420","","",true, this);
 
            Volume = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("42af2b49-ee66-46bc-bcd3-29313ecfb17d","","",true, this);
 
            CodPurchaseOrder = RPSControlFactory.CreateRPSEnumComboBox<RoadMapSLEntityView>("6f75c9a3-4e86-4e30-9dc3-f673365de1f4","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapSLEntityView>("b41305fc-9224-4281-9511-8309c4df73dc","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<RoadMapSLEntityView>("4ed96b58-a732-4a2f-9877-2a5c18d8d181","","",false, this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<RoadMapSLEntityView>( "146af709-be7a-4b63-a917-7e9bf85fb3ce","","",this);
 
            ReopenCommandButton = RPSControlFactory.CreateRPSButton<RoadMapSLEntityView>( "f75b1300-f23f-434e-a94e-04c4062ac63f","","",this);
 
            RoadMapNewDetailsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RoadMapSLEntityView,RoadMapNewDetailsDialogView>("cb60f569-430c-496b-afb6-6b6b140b63cf","","", this,Screen.RoadMapNewDetailsDialogView);
 
            CalculateWeightCommandButton = RPSControlFactory.CreateRPSButton<RoadMapSLEntityView>( "2c39963d-4db4-4446-bd65-96d888ae84f7","","",this);
 
            RoadMapAutomaticNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RoadMapSLEntityView,RoadMapAutomaticDialogView>("947ed5c5-56e2-46f2-9458-905491e0c55e","","", this,Screen.RoadMapAutomaticDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<RoadMapSLEntityView>( "671fece4-0393-4fbc-8b2e-cfc20ccb997e","","",this);
 
            CollectionInit params_RoadMapDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6b1192d-be78-4175-8585-601595a7d99d",CSSSelectorGrid="",XPathGrid=""};
            RoadMapDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<RoadMapDetailSLsCollectionEditor<RoadMapSLEntityView,RoadMapDetailSLView>,RoadMapSLEntityView,RoadMapDetailSLView>( params_RoadMapDetailSLs,this,Screen.RoadMapDetailSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<RoadMapSLEntityView>( "","ul li[rpsid='ede4d3a4-e5dc-49d4-8321-698200e89d16']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<RoadMapSLEntityView>( "","ul li[rpsid='79741a25-af0a-4095-87b7-92c57eb2ee0b']","",this);
 

        }
        public IRPSSaveButton<RoadMapSLEntityView> SaveButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView,RoadMapSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView,RoadMapSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> CodRoadMap { get; set; } 
        public IRPSComboBox<RoadMapSLEntityView> IDShippingAgent { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> ExpeditionDate { get; set; } 
        public IRPSCheckbox<RoadMapSLEntityView> Finished { get; set; } 
        public IRPSComboBox<RoadMapSLEntityView> IDShippingVehicle { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> UIVehicleNumber { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> UITowNumber { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> UIBoxes { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> NumBoxes { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> GrossWeight { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> NetWeight { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> Volume { get; set; } 
        public IRPSComboBox<RoadMapSLEntityView> CodPurchaseOrder { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> Amount { get; set; } 
        public IRPSTextBox<RoadMapSLEntityView> Comment { get; set; } 
        public IRPSButton<RoadMapSLEntityView> FinishCommandButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView> ReopenCommandButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView,RoadMapNewDetailsDialogView> RoadMapNewDetailsNavigationCommandButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView> CalculateWeightCommandButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView,RoadMapAutomaticDialogView> RoadMapAutomaticNavigationCommandButton { get; set; } 
        public IRPSButton<RoadMapSLEntityView> ReportCommandButton { get; set; } 
        public RoadMapDetailSLsCollectionEditor<RoadMapSLEntityView,RoadMapDetailSLView> RoadMapDetailSLs { get; set; } 
        public IRPSSection<RoadMapSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<RoadMapSLEntityView> CommentSection { get; set; } 
        public RoadMap Screen { get; set; }
        public RoadMapSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RoadMapDetailSLsCollectionEditor<RoadMapSLEntityView,RoadMapDetailSLView>:RPSCollectionEditor<RoadMapSLEntityView,RoadMapDetailSLView> where RoadMapSLEntityView : class, IView where RoadMapDetailSLView : class, IView
    {
        public  RoadMapDetailSLsGridView<RoadMapSLEntityView,RoadMapDetailSLView> GridView {get;set;}
    }
    public partial class RoadMapDetailSLsGridView <RoadMapSLEntityView,RoadMapDetailSLView> :  RPSGridView<RoadMapSLEntityView,RoadMapDetailSLView> where RoadMapSLEntityView : class, IView where RoadMapDetailSLView : class, IView
    {
        public RoadMapDetailSLsGridView(RoadMapSLEntityView currentView,RoadMapDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDOrder = RPSControlFactory.CreateRPSGridComboBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cIDOrder']","",false, this.CurrentView);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSGridComboBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNote']","",false, this.CurrentView);
 
            Customer = RPSControlFactory.CreateRPSGridComboBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cCustomer']","",false, this.CurrentView);
 
            NumBoxes = RPSControlFactory.CreateRPSGridFormattedTextBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cNumBoxes']","",true, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",true, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",true, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",true, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<RoadMapSLEntityView>("","#c6b1192d-be78-4175-8585-601595a7d99d .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<RoadMapSLEntityView> IDOrder { get; set; } 
        public IRPSGridComboBox<RoadMapSLEntityView> IDDeliveryNote { get; set; } 
        public IRPSGridComboBox<RoadMapSLEntityView> Customer { get; set; } 
        public IRPSGridTextBox<RoadMapSLEntityView> NumBoxes { get; set; } 
        public IRPSGridTextBox<RoadMapSLEntityView> GrossWeight { get; set; } 
        public IRPSGridTextBox<RoadMapSLEntityView> NetWeight { get; set; } 
        public IRPSGridTextBox<RoadMapSLEntityView> Volume { get; set; } 
        public IRPSGridTextBox<RoadMapSLEntityView> Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class RoadMapDetailSLView : View
    {
        public RoadMapDetailSLView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RoadMapDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RoadMapDetailSLView,RoadMapSLEntityView>( this,Screen.RoadMapSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RoadMapDetailSLView,RoadMapSLEntityView>( this,Screen.RoadMapSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RoadMapDetailSLView,RoadMapSLEntityView>( this,Screen.RoadMapSLEntityView);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<RoadMapDetailSLView>("3d4ecfaf-8c90-4eaa-b225-28fcae3d0f85","","",false, this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<RoadMapDetailSLView>("69e5960d-0733-4d25-959b-081b97521def","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<RoadMapDetailSLView>("f5994bdc-e4f5-44c2-bb1d-2ff4bca91b93","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapDetailSLView>("faf25cd6-915e-49f2-934e-340552e94939","","",true, this);
 
            NumBoxes = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapDetailSLView>("f4587545-2816-4519-8826-03023f6f3dbc","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapDetailSLView>("7035e2ae-c289-4bff-b5b1-f4ab4f760cea","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapDetailSLView>("057009c4-0918-4fcf-a0c1-6511cd78d71b","","",true, this);
 
            Volume = RPSControlFactory.CreateRPSFormattedTextBox<RoadMapDetailSLView>("2339e6e9-2c78-47db-9751-8d85287fc3bc","","",true, this);
 

        }
        public IRPSButton<RoadMapDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<RoadMapDetailSLView,RoadMapSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RoadMapDetailSLView,RoadMapSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RoadMapDetailSLView,RoadMapSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<RoadMapDetailSLView> IDOrder { get; set; } 
        public IRPSComboBox<RoadMapDetailSLView> IDDeliveryNote { get; set; } 
        public IRPSComboBox<RoadMapDetailSLView> Customer { get; set; } 
        public IRPSTextBox<RoadMapDetailSLView> Order { get; set; } 
        public IRPSTextBox<RoadMapDetailSLView> NumBoxes { get; set; } 
        public IRPSTextBox<RoadMapDetailSLView> GrossWeight { get; set; } 
        public IRPSTextBox<RoadMapDetailSLView> NetWeight { get; set; } 
        public IRPSTextBox<RoadMapDetailSLView> Volume { get; set; } 
        public RoadMap Screen { get; set; }
        public RoadMapDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RoadMapNewDetailsDialogView : View
    {
        public RoadMapNewDetailsDialogView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptWithout = RPSControlFactory.CreateRPSOption<RoadMapNewDetailsDialogView>( "690bee8c-4fec-43ed-9da3-03954aa6d955","","",this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<RoadMapNewDetailsDialogView>( "d8a3b793-e019-4eff-8322-c27f756b3e76","","",this);
 
            UIOptOrder = RPSControlFactory.CreateRPSOption<RoadMapNewDetailsDialogView>( "162e4e49-3a49-4200-8dec-69704737facd","","",this);
 
            UIOptDeliveryNote = RPSControlFactory.CreateRPSOption<RoadMapNewDetailsDialogView>( "49740313-e28b-446c-ad5b-84536d44dc58","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<RoadMapNewDetailsDialogView>("7f78b7df-60cd-40e0-ae77-7ac5f89d92e2","","",false, this);
 
            UISameShippingAgent = RPSControlFactory.CreateRPSCheckBox<RoadMapNewDetailsDialogView>("8819585b-6f7f-4e6f-8f4a-4720f9dae764","","",false, this);
 
            CollectionInit params_OrdersForRoadMap = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf93ccec-5070-4031-b36e-cad9629bc336",CSSSelectorGrid="",XPathGrid=""};
            OrdersForRoadMap = RPSControlFactory.RPSCreateCollectionWithGrid<OrdersForRoadMapCollectionEditor<RoadMapNewDetailsDialogView>,RoadMapNewDetailsDialogView>( params_OrdersForRoadMap,this);
 
            CollectionInit params_DeliveryNotesForRoadMap = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2649c03c-647e-4295-b756-398b4c45b31b",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNotesForRoadMap = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNotesForRoadMapCollectionEditor<RoadMapNewDetailsDialogView>,RoadMapNewDetailsDialogView>( params_DeliveryNotesForRoadMap,this);
 

        }
        public IRPSOption<RoadMapNewDetailsDialogView> UIOptWithout { get; set; } 
        public IRPSOption<RoadMapNewDetailsDialogView> UIOptAll { get; set; } 
        public IRPSOption<RoadMapNewDetailsDialogView> UIOptOrder { get; set; } 
        public IRPSOption<RoadMapNewDetailsDialogView> UIOptDeliveryNote { get; set; } 
        public IRPSTextBox<RoadMapNewDetailsDialogView> UIDateFrom { get; set; } 
        public IRPSCheckbox<RoadMapNewDetailsDialogView> UISameShippingAgent { get; set; } 
        public OrdersForRoadMapCollectionEditor<RoadMapNewDetailsDialogView> OrdersForRoadMap { get; set; } 
        public DeliveryNotesForRoadMapCollectionEditor<RoadMapNewDetailsDialogView> DeliveryNotesForRoadMap { get; set; } 
        public RoadMap Screen { get; set; }
        public RoadMapNewDetailsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrdersForRoadMapCollectionEditor<RoadMapNewDetailsDialogView>:RPSCollectionEditor<RoadMapNewDetailsDialogView> where RoadMapNewDetailsDialogView : class, IView
    {
        public  OrdersForRoadMapGridView<RoadMapNewDetailsDialogView> GridView {get;set;}
    }
    public partial class OrdersForRoadMapGridView <RoadMapNewDetailsDialogView> :  RPSGridView<RoadMapNewDetailsDialogView> where RoadMapNewDetailsDialogView : class, IView
    {
        public OrdersForRoadMapGridView(RoadMapNewDetailsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Address = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#bf93ccec-5070-4031-b36e-cad9629bc336 .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#bf93ccec-5070-4031-b36e-cad9629bc336 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            City = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#bf93ccec-5070-4031-b36e-cad9629bc336 .ag-row[role='row']@ROWINDEX [col-id='cCity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> Address { get; set; } 
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> Date { get; set; } 
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> City { get; set; } 
                     
    }
 
        public partial class DeliveryNotesForRoadMapCollectionEditor<RoadMapNewDetailsDialogView>:RPSCollectionEditor<RoadMapNewDetailsDialogView> where RoadMapNewDetailsDialogView : class, IView
    {
        public  DeliveryNotesForRoadMapGridView<RoadMapNewDetailsDialogView> GridView {get;set;}
    }
    public partial class DeliveryNotesForRoadMapGridView <RoadMapNewDetailsDialogView> :  RPSGridView<RoadMapNewDetailsDialogView> where RoadMapNewDetailsDialogView : class, IView
    {
        public DeliveryNotesForRoadMapGridView(RoadMapNewDetailsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#2649c03c-647e-4295-b756-398b4c45b31b .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Address = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#2649c03c-647e-4295-b756-398b4c45b31b .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            City = RPSControlFactory.CreateRPSGridTextBox<RoadMapNewDetailsDialogView>("","#2649c03c-647e-4295-b756-398b4c45b31b .ag-row[role='row']@ROWINDEX [col-id='cCity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> Date { get; set; } 
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> Address { get; set; } 
        public IRPSGridTextBox<RoadMapNewDetailsDialogView> City { get; set; } 
                     
    }
 
    }
  
            
    public partial class RoadMapAutomaticDialogView : View
    {
        public RoadMapAutomaticDialogView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<RoadMapAutomaticDialogView>("360967d0-2c45-49a6-95dd-3a7ec2deeac9","","",false, this);
 
            UIOptOrder = RPSControlFactory.CreateRPSOption<RoadMapAutomaticDialogView>( "1006eeb8-7638-468b-bc9b-952401dc1aa6","","",this);
 
            UIOptDeliveryNote = RPSControlFactory.CreateRPSOption<RoadMapAutomaticDialogView>( "03abd2c6-0b34-4878-b6a5-4fc4f53364b5","","",this);
 
            CollectionInit params_TransportRouteForRoadMap = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8b116ef2-d6e7-4edb-99fc-097c22c54730",CSSSelectorGrid="",XPathGrid=""};
            TransportRouteForRoadMap = RPSControlFactory.RPSCreateCollectionWithGrid<TransportRouteForRoadMapCollectionEditor<RoadMapAutomaticDialogView>,RoadMapAutomaticDialogView>( params_TransportRouteForRoadMap,this);
 

        }
        public IRPSTextBox<RoadMapAutomaticDialogView> UIDateFrom { get; set; } 
        public IRPSOption<RoadMapAutomaticDialogView> UIOptOrder { get; set; } 
        public IRPSOption<RoadMapAutomaticDialogView> UIOptDeliveryNote { get; set; } 
        public TransportRouteForRoadMapCollectionEditor<RoadMapAutomaticDialogView> TransportRouteForRoadMap { get; set; } 
        public RoadMap Screen { get; set; }
        public RoadMapAutomaticDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TransportRouteForRoadMapCollectionEditor<RoadMapAutomaticDialogView>:RPSCollectionEditor<RoadMapAutomaticDialogView> where RoadMapAutomaticDialogView : class, IView
    {
        public  TransportRouteForRoadMapGridView<RoadMapAutomaticDialogView> GridView {get;set;}
    }
    public partial class TransportRouteForRoadMapGridView <RoadMapAutomaticDialogView> :  RPSGridView<RoadMapAutomaticDialogView> where RoadMapAutomaticDialogView : class, IView
    {
        public TransportRouteForRoadMapGridView(RoadMapAutomaticDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TransportRouteSL_CodTransportRoute = RPSControlFactory.CreateRPSGridTextBox<RoadMapAutomaticDialogView>("","#8b116ef2-d6e7-4edb-99fc-097c22c54730 .ag-row[role='row']@ROWINDEX [col-id='cTransportRouteSL_CodTransportRoute']","",false, this.CurrentView);
 
            TransportRouteSL_Description = RPSControlFactory.CreateRPSGridTextBox<RoadMapAutomaticDialogView>("","#8b116ef2-d6e7-4edb-99fc-097c22c54730 .ag-row[role='row']@ROWINDEX [col-id='cTransportRouteSL_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RoadMapAutomaticDialogView> TransportRouteSL_CodTransportRoute { get; set; } 
        public IRPSGridTextBox<RoadMapAutomaticDialogView> TransportRouteSL_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderGenerationDialogView : View
    {
        public OrderGenerationDialogView(RoadMap screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OneOrderByRoadMap = RPSControlFactory.CreateRPSCheckBox<OrderGenerationDialogView>("f6d17efb-6e54-49a4-b9a0-4e2ba5296b6b","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<OrderGenerationDialogView>("70d4b51a-2df2-45bc-9de9-18808984b1c5","","",false, this);
 

        }
        public IRPSCheckbox<OrderGenerationDialogView> OneOrderByRoadMap { get; set; } 
        public IRPSTextBox<OrderGenerationDialogView> OrderDate { get; set; } 
        public RoadMap Screen { get; set; }
        public OrderGenerationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}