    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ProductionUnit
{
    //RPS VERSION 1.0.0.0
    public partial class ProductionUnit:Screen
    {
        public ProductionUnit():base()
        {
            this.URL = "planification.productionunit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductionUnitCollectionView  = new ProductionUnitCollectionView(this); 
            ProductionUnitEntityView  = new ProductionUnitEntityView(this); 
            PUCalendarDetailView  = new PUCalendarDetailView(this); 
            NewDateDialogView  = new NewDateDialogView(this); 
            ProductionUnitCollectionView.InitializeControls(); 
            ProductionUnitEntityView.InitializeControls(); 
            PUCalendarDetailView.InitializeControls(); 
            NewDateDialogView.InitializeControls(); 
           
        }
      
            public ProductionUnitCollectionView ProductionUnitCollectionView {get; set; } 
            public ProductionUnitEntityView ProductionUnitEntityView {get; set; } 
            public PUCalendarDetailView PUCalendarDetailView {get; set; } 
            public NewDateDialogView NewDateDialogView {get; set; } 
    }
            
    public partial class ProductionUnitCollectionView : View
    {
        public ProductionUnitCollectionView(ProductionUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProductionUnitCollectionView,ProductionUnitEntityView>( this,Screen.ProductionUnitEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "00792b8f-5346-4157-823c-baee241b0049",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProductionUnitCollectionView,ProductionUnitEntityView>( params_MainConsult,this,Screen.ProductionUnitEntityView);
 

        }
        public IRPSButton<ProductionUnitCollectionView,ProductionUnitEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ProductionUnitCollectionView,ProductionUnitEntityView> MainConsult { get; set; } 
        public ProductionUnit Screen { get; set; }
        public ProductionUnitCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductionUnitEntityView : View
    {
        public ProductionUnitEntityView(ProductionUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProductionUnitEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductionUnitEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductionUnitEntityView,ProductionUnitCollectionView>( this,Screen.ProductionUnitCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductionUnitEntityView,ProductionUnitCollectionView>( this,Screen.ProductionUnitCollectionView);
 
            CodProductionUnit = RPSControlFactory.CreateRPSTextBox<ProductionUnitEntityView>("b30a1465-6e27-406f-b1a6-542d19994d90","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductionUnitEntityView>("040acf61-53a8-4f69-b185-0b526f6d40ce","","",false, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<ProductionUnitEntityView>("a915ed63-8a75-4b07-aec0-1f7ea18c106f","","",true, this);
 
            IDUnitCapacity = RPSControlFactory.CreateRPSComboBox<ProductionUnitEntityView>("35282785-a57f-4695-9702-871737e36fb5","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProductionUnitEntityView>("2803a80a-88c3-42ab-928b-15f7e1ced354","","",false, this);
 
            CollectionInit params_PUCalendarDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e72bbec1-309c-4b86-80f7-ee5113073c21",CSSSelectorGrid="",XPathGrid=""};
            PUCalendarDetails = RPSControlFactory.RPSCreateCollectionWithGrid<PUCalendarDetailsCollectionEditor<ProductionUnitEntityView,PUCalendarDetailView>,ProductionUnitEntityView,PUCalendarDetailView>( params_PUCalendarDetails,this,Screen.PUCalendarDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProductionUnitEntityView>( "","ul li[rpsid='fbb63dfd-278f-4427-93ca-c34c3441e59d']","",this);
 
            Calendar = RPSControlFactory.CreateRPSSection<ProductionUnitEntityView>( "","ul li[rpsid='b2738b7b-43ae-4164-876a-9498441fe48e']","",this);
 

        }
        public IRPSSaveButton<ProductionUnitEntityView> SaveButton { get; set; } 
        public IRPSButton<ProductionUnitEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProductionUnitEntityView,ProductionUnitCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductionUnitEntityView,ProductionUnitCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProductionUnitEntityView> CodProductionUnit { get; set; } 
        public IRPSTextBox<ProductionUnitEntityView> Description { get; set; } 
        public IRPSComboBox<ProductionUnitEntityView> CalendarType { get; set; } 
        public IRPSComboBox<ProductionUnitEntityView> IDUnitCapacity { get; set; } 
        public IRPSTextBox<ProductionUnitEntityView> Notes { get; set; } 
        public PUCalendarDetailsCollectionEditor<ProductionUnitEntityView,PUCalendarDetailView> PUCalendarDetails { get; set; } 
        public IRPSSection<ProductionUnitEntityView> GeneralData { get; set; } 
        public IRPSSection<ProductionUnitEntityView> Calendar { get; set; } 
        public ProductionUnit Screen { get; set; }
        public ProductionUnitEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PUCalendarDetailsCollectionEditor<ProductionUnitEntityView,PUCalendarDetailView>:RPSCollectionEditor<ProductionUnitEntityView,PUCalendarDetailView> where ProductionUnitEntityView : class, IView where PUCalendarDetailView : class, IView
    {
        public  PUCalendarDetailsGridView<ProductionUnitEntityView,PUCalendarDetailView> GridView {get;set;}
    }
    public partial class PUCalendarDetailsGridView <ProductionUnitEntityView,PUCalendarDetailView> :  RPSGridView<ProductionUnitEntityView,PUCalendarDetailView> where ProductionUnitEntityView : class, IView where PUCalendarDetailView : class, IView
    {
        public PUCalendarDetailsGridView(ProductionUnitEntityView currentView,PUCalendarDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductionUnitEntityView>("","#e72bbec1-309c-4b86-80f7-ee5113073c21 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<ProductionUnitEntityView>("","#e72bbec1-309c-4b86-80f7-ee5113073c21 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<ProductionUnitEntityView>("","#e72bbec1-309c-4b86-80f7-ee5113073c21 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Capacity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductionUnitEntityView>("","#e72bbec1-309c-4b86-80f7-ee5113073c21 .ag-row[role='row']@ROWINDEX [col-id='cCapacity']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductionUnitEntityView>("","#e72bbec1-309c-4b86-80f7-ee5113073c21 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProductionUnitEntityView> Description { get; set; } 
        public IRPSGridTextBox<ProductionUnitEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<ProductionUnitEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<ProductionUnitEntityView> Capacity { get; set; } 
        public IRPSGridTextBox<ProductionUnitEntityView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class PUCalendarDetailView : View
    {
        public PUCalendarDetailView(ProductionUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PUCalendarDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PUCalendarDetailView,ProductionUnitEntityView>( this,Screen.ProductionUnitEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PUCalendarDetailView,ProductionUnitEntityView>( this,Screen.ProductionUnitEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PUCalendarDetailView,ProductionUnitEntityView>( this,Screen.ProductionUnitEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("6fe6fa5d-d8f6-4fa9-b488-b76809a20616","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("7488ef33-5285-4c85-823c-b06ca5ab2d3b","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("e2d839bf-88a2-4908-9d69-03dd26b3938e","","",false, this);
 
            Capacity = RPSControlFactory.CreateRPSFormattedTextBox<PUCalendarDetailView>("11ac6e4f-0ded-49e2-a2e8-6c8f3ab324c7","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<PUCalendarDetailView>("af270b78-8eed-4c18-b039-66c7cda06bee","","",true, this);
 
            AllDays = RPSControlFactory.CreateRPSOption<PUCalendarDetailView>( "dc32a02e-fc07-4290-b552-341138169ffb","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<PUCalendarDetailView>( "838184ae-c54d-45db-b52d-a51f7393e5f7","","",this);
 
            Monday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("591207f8-4b9c-45da-80b1-ee96e88712e9","","",false, this);
 
            Tuesday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("1b5b319b-f9bc-4060-936a-4af66ef8309a","","",false, this);
 
            Wednesday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("8e13bf5c-486d-4028-80c2-52d8785b1a83","","",false, this);
 
            Thursday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("959e791b-59bf-4afb-80e2-cdd61e0ba03b","","",false, this);
 
            Friday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("79d34094-9548-473a-bcce-3fb6ae3334bb","","",false, this);
 
            Saturday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("a9f98e13-30ca-413b-ae30-3efbc8501f07","","",false, this);
 
            Sunday = RPSControlFactory.CreateRPSCheckBox<PUCalendarDetailView>("759d0c58-9997-477b-852f-ebb48877fde3","","",false, this);
 
            DateRange = RPSControlFactory.CreateRPSOption<PUCalendarDetailView>( "c99f850f-93fd-45e3-b20a-ece876c931a5","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("be9cc046-153a-49a0-a2ec-a1c83a53a619","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("879d5e3e-b4a1-431d-8d07-193786c02c7e","","",false, this);
 
            Dates = RPSControlFactory.CreateRPSOption<PUCalendarDetailView>( "0c613be9-552c-4036-9a03-b5711ea1877e","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButtonToView<PUCalendarDetailView,NewDateDialogView>("fc7fe1f7-c3f2-4ace-a933-6b0b08da57a9","","", this,Screen.NewDateDialogView);
 
            DayExpressionDates = RPSControlFactory.CreateRPSTextBox<PUCalendarDetailView>("99193981-31e4-46ee-b673-b4f3f7bf7558","","",false, this);
 

        }
        public IRPSButton<PUCalendarDetailView> DeleteButton { get; set; } 
        public IRPSButton<PUCalendarDetailView,ProductionUnitEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PUCalendarDetailView,ProductionUnitEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PUCalendarDetailView,ProductionUnitEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> Description { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> DateFrom { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> DateTo { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> Capacity { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> Priority { get; set; } 
        public IRPSOption<PUCalendarDetailView> AllDays { get; set; } 
        public IRPSOption<PUCalendarDetailView> Week { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Monday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Tuesday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Wednesday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Thursday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Friday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Saturday { get; set; } 
        public IRPSCheckbox<PUCalendarDetailView> Sunday { get; set; } 
        public IRPSOption<PUCalendarDetailView> DateRange { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> UIDateFrom { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> UIDateTo { get; set; } 
        public IRPSOption<PUCalendarDetailView> Dates { get; set; } 
        public IRPSButton<PUCalendarDetailView,NewDateDialogView> LinkNavigationCommand { get; set; } 
        public IRPSTextBox<PUCalendarDetailView> DayExpressionDates { get; set; } 
        public ProductionUnit Screen { get; set; }
        public PUCalendarDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDateDialogView : View
    {
        public NewDateDialogView(ProductionUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDate = RPSControlFactory.CreateRPSTextBox<NewDateDialogView>("b6e762aa-a962-49dc-b3f5-26ff4f0cc988","","",false, this);
 
            AddNewDate = RPSControlFactory.CreateRPSButton<NewDateDialogView>( "eb93c050-d664-46ba-be1a-f039a315fca1","","",this);
 
            CollectionInit params_GetDatesFromDateExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6d048274-c9db-4a47-93b9-bc35af5f9cdd",CSSSelectorGrid="",XPathGrid=""};
            GetDatesFromDateExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetDatesFromDateExpresionCollectionEditor<NewDateDialogView>,NewDateDialogView>( params_GetDatesFromDateExpresion,this);
 

        }
        public IRPSTextBox<NewDateDialogView> NewDate { get; set; } 
        public IRPSButton<NewDateDialogView> AddNewDate { get; set; } 
        public GetDatesFromDateExpresionCollectionEditor<NewDateDialogView> GetDatesFromDateExpresion { get; set; } 
        public ProductionUnit Screen { get; set; }
        public NewDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDatesFromDateExpresionCollectionEditor<NewDateDialogView>:RPSCollectionEditor<NewDateDialogView> where NewDateDialogView : class, IView
    {
        public  GetDatesFromDateExpresionGridView<NewDateDialogView> GridView {get;set;}
    }
    public partial class GetDatesFromDateExpresionGridView <NewDateDialogView> :  RPSGridView<NewDateDialogView> where NewDateDialogView : class, IView
    {
        public GetDatesFromDateExpresionGridView(NewDateDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteDateCommand = RPSControlFactory.CreateRPSGridButton<NewDateDialogView>( "","#6d048274-c9db-4a47-93b9-bc35af5f9cdd .ag-row[role='row']@ROWINDEX [col-id='cDeleteDateCommand']","",this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<NewDateDialogView>("","#6d048274-c9db-4a47-93b9-bc35af5f9cdd .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<NewDateDialogView> DeleteDateCommand { get; set; } 
        public IRPSGridTextBox<NewDateDialogView> Date { get; set; } 
                     
    }
 
    }
  
    

}