    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PriceListDetail
{
    //RPS VERSION 1.0.0.0
    public partial class PriceListDetail:Screen
    {
        public PriceListDetail():base()
        {
            this.URL = "sales.pricelistdetail";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PriceListDetailSLVMQueryView  = new PriceListDetailSLVMQueryView(this); 
            PriceListDetailSLVMEntityView  = new PriceListDetailSLVMEntityView(this); 
            AmplifyDateDialogView  = new AmplifyDateDialogView(this); 
            PriceListDetailSLVMQueryView.InitializeControls(); 
            PriceListDetailSLVMEntityView.InitializeControls(); 
            AmplifyDateDialogView.InitializeControls(); 
           
        }
      
            public PriceListDetailSLVMQueryView PriceListDetailSLVMQueryView {get; set; } 
            public PriceListDetailSLVMEntityView PriceListDetailSLVMEntityView {get; set; } 
            public AmplifyDateDialogView AmplifyDateDialogView {get; set; } 
    }
            
    public partial class PriceListDetailSLVMQueryView : View
    {
        public PriceListDetailSLVMQueryView(PriceListDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView>( this,Screen.PriceListDetailSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<PriceListDetailSLVMQueryView>( this);
 
            PriceListSL = RPSControlFactory.CreateRPSCollectionComboBox<PriceListDetailSLVMQueryView>("286a5fbd-833d-470b-a483-e39a81fc7c25","","",false, this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<PriceListDetailSLVMQueryView>("98b61aa2-2a0c-472e-b733-22dffe3e4fa8","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<PriceListDetailSLVMQueryView>("5ca9952e-034d-4222-9fe4-f1808116a33d","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<PriceListDetailSLVMQueryView>("3fb2c01f-3fe4-4daf-9934-c92ed5991ac5","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<PriceListDetailSLVMQueryView>("55c202f3-226c-4454-b77d-6c6cbcb6b3bd","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<PriceListDetailSLVMQueryView>("24d89dcf-7890-4776-937f-45f2fb7400d9","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<PriceListDetailSLVMQueryView>("8e9145e8-11b8-4be0-b961-b212f77f9e48","","",false, this);
 
            AmplifyDateNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PriceListDetailSLVMQueryView,AmplifyDateDialogView>("b5b081c6-78b2-4957-9ffc-742316b485a3","","", this,Screen.AmplifyDateDialogView);
 
            CollectionInit params_PriceListDetailQuery = new CollectionInit(){IDDescriptor = "685c4424-c0c3-4f24-93f7-7bd4d8ef5fbe",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3e569e6-c81b-47e6-a3a9-95471f1a304c",CSSSelectorGrid="",XPathGrid=""};
            PriceListDetailQuery = RPSControlFactory.RPSCreateCollectionWithGrid<PriceListDetailQueryCollectionEditor<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView>,PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView>( params_PriceListDetailQuery,this,Screen.PriceListDetailSLVMEntityView);
 

        }
        public IRPSButton<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<PriceListDetailSLVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<PriceListDetailSLVMQueryView> PriceListSL { get; set; } 
        public IRPSTextBox<PriceListDetailSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSComboBox<PriceListDetailSLVMQueryView> IDCurrency { get; set; } 
        public IRPSCollectionComboBox<PriceListDetailSLVMQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<PriceListDetailSLVMQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<PriceListDetailSLVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<PriceListDetailSLVMQueryView> Article { get; set; } 
        public IRPSButton<PriceListDetailSLVMQueryView,AmplifyDateDialogView> AmplifyDateNavigationCommandButton { get; set; } 
        public PriceListDetailQueryCollectionEditor<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> PriceListDetailQuery { get; set; } 
        public PriceListDetail Screen { get; set; }
        public PriceListDetailSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PriceListDetailQueryCollectionEditor<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView>:RPSCollectionEditor<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> where PriceListDetailSLVMQueryView : class, IView where PriceListDetailSLVMEntityView : class, IView
    {
        public  PriceListDetailQueryGridView<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> GridView {get;set;}
    }
    public partial class PriceListDetailQueryGridView <PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> :  RPSGridView<PriceListDetailSLVMQueryView,PriceListDetailSLVMEntityView> where PriceListDetailSLVMQueryView : class, IView where PriceListDetailSLVMEntityView : class, IView
    {
        public PriceListDetailQueryGridView(PriceListDetailSLVMQueryView currentView,PriceListDetailSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PriceListDetailSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<PriceListDetailSLVMQueryView>("","#b3e569e6-c81b-47e6-a3a9-95471f1a304c .ag-row[role='row']@ROWINDEX [col-id='cPriceListDetailSL_DateFrom']","",false, this.CurrentView);
 
            PriceListDetailSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<PriceListDetailSLVMQueryView>("","#b3e569e6-c81b-47e6-a3a9-95471f1a304c .ag-row[role='row']@ROWINDEX [col-id='cPriceListDetailSL_DateTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PriceListDetailSLVMQueryView> PriceListDetailSL_DateFrom { get; set; } 
        public IRPSGridTextBox<PriceListDetailSLVMQueryView> PriceListDetailSL_DateTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class PriceListDetailSLVMEntityView : View
    {
        public PriceListDetailSLVMEntityView(PriceListDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PriceListDetailSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PriceListDetailSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PriceListDetailSLVMEntityView,PriceListDetailSLVMQueryView>( this,Screen.PriceListDetailSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<PriceListDetailSLVMEntityView,PriceListDetailSLVMQueryView>( this,Screen.PriceListDetailSLVMQueryView);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<PriceListDetailSLVMEntityView>("107e3c18-abc9-4b4d-8861-7f0967c6fd15","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PriceListDetailSLVMEntityView>("5de683ad-9a8a-43ea-924c-835394d4bef6","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<PriceListDetailSLVMEntityView>("529ea4c9-b55a-4d37-8419-f59ca4ca4379","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<PriceListDetailSLVMEntityView>("6943d7fb-e160-4066-b2bd-0080f7873014","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<PriceListDetailSLVMEntityView>("ff89403f-368a-43f9-a32d-026c2b707141","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PriceListDetailSLVMEntityView>("ae0250fd-c1fd-4453-898c-72fd8f7a9cf1","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<PriceListDetailSLVMEntityView>("cde919b2-d664-4d69-a532-a2f4a00136a9","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<PriceListDetailSLVMEntityView>("41bf0749-0cf2-4d19-ac59-eea4f2a287a3","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<PriceListDetailSLVMEntityView>("70943981-be66-4a41-b4fb-dc04e74a34ba","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<PriceListDetailSLVMEntityView>("2ee88e8b-88f5-428a-8021-f326e9c72a2f","","",true, this);
 
            Offer = RPSControlFactory.CreateRPSCheckBox<PriceListDetailSLVMEntityView>("ae244d59-d665-4a3c-a52c-789d7f4f47ff","","",true, this);
 
            DuplicateCommandButton = RPSControlFactory.CreateRPSButton<PriceListDetailSLVMEntityView>( "7b325cff-ff5c-49a3-8646-73f108a57eb4","","",this);
 

        }
        public IRPSSaveButton<PriceListDetailSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<PriceListDetailSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<PriceListDetailSLVMEntityView,PriceListDetailSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PriceListDetailSLVMEntityView,PriceListDetailSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<PriceListDetailSLVMEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<PriceListDetailSLVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<PriceListDetailSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<PriceListDetailSLVMEntityView> DateTo { get; set; } 
        public IRPSTextBox<PriceListDetailSLVMEntityView> QuantityFrom { get; set; } 
        public IRPSComboBox<PriceListDetailSLVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<PriceListDetailSLVMEntityView> Price { get; set; } 
        public IRPSComboBox<PriceListDetailSLVMEntityView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<PriceListDetailSLVMEntityView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<PriceListDetailSLVMEntityView> ApplyConditionsNotAffectDocument { get; set; } 
        public IRPSCheckbox<PriceListDetailSLVMEntityView> Offer { get; set; } 
        public IRPSButton<PriceListDetailSLVMEntityView> DuplicateCommandButton { get; set; } 
        public PriceListDetail Screen { get; set; }
        public PriceListDetailSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AmplifyDateDialogView : View
    {
        public AmplifyDateDialogView(PriceListDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateTo = RPSControlFactory.CreateRPSTextBox<AmplifyDateDialogView>("33839235-93a4-4f22-966e-59af62a28868","","",false, this);
 

        }
        public IRPSTextBox<AmplifyDateDialogView> UIDateTo { get; set; } 
        public PriceListDetail Screen { get; set; }
        public AmplifyDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}