    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ProductLineUser
{
    //RPS VERSION 1.0.0.0
    public partial class ProductLineUser:Screen
    {
        public ProductLineUser():base()
        {
            this.URL = "general.productlineuser";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductLineCollectionView  = new ProductLineCollectionView(this); 
            ProductLineEntityView  = new ProductLineEntityView(this); 
            ProductLineUserView  = new ProductLineUserView(this); 
            ProductLineCollectionView.InitializeControls(); 
            ProductLineEntityView.InitializeControls(); 
            ProductLineUserView.InitializeControls(); 
           
        }
      
            public ProductLineCollectionView ProductLineCollectionView {get; set; } 
            public ProductLineEntityView ProductLineEntityView {get; set; } 
            public ProductLineUserView ProductLineUserView {get; set; } 
    }
            
    public partial class ProductLineCollectionView : View
    {
        public ProductLineCollectionView(ProductLineUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProductLineCollectionView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3483f873-7d95-41fe-a709-4a3adf306b65",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProductLineCollectionView,ProductLineEntityView>( params_MainConsult,this,Screen.ProductLineEntityView);
 

        }
        public IRPSButton<ProductLineCollectionView,ProductLineEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ProductLineCollectionView,ProductLineEntityView> MainConsult { get; set; } 
        public ProductLineUser Screen { get; set; }
        public ProductLineCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductLineEntityView : View
    {
        public ProductLineEntityView(ProductLineUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProductLineEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductLineEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductLineEntityView,ProductLineCollectionView>( this,Screen.ProductLineCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductLineEntityView,ProductLineCollectionView>( this,Screen.ProductLineCollectionView);
 
            ProductLineUserNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProductLineEntityView,ProductLineUserView>("e8c5035a-a8e8-455a-89c8-46ba32c74641","","", this,Screen.ProductLineUserView);
 
            CollectionInit params_ProductLineUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b52ec9d9-b4dd-487c-b2fe-cfe38169c4ef",CSSSelectorGrid="",XPathGrid=""};
            ProductLineUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ProductLineUsersCollectionEditor<ProductLineEntityView>,ProductLineEntityView>( params_ProductLineUsers,this);
 

        }
        public IRPSSaveButton<ProductLineEntityView> SaveButton { get; set; } 
        public IRPSButton<ProductLineEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProductLineEntityView,ProductLineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductLineEntityView,ProductLineCollectionView> BackButton { get; set; } 
        public IRPSButton<ProductLineEntityView,ProductLineUserView> ProductLineUserNavigationCommandButton { get; set; } 
        public ProductLineUsersCollectionEditor<ProductLineEntityView> ProductLineUsers { get; set; } 
        public ProductLineUser Screen { get; set; }
        public ProductLineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductLineUsersCollectionEditor<ProductLineEntityView>:RPSCollectionEditor<ProductLineEntityView> where ProductLineEntityView : class, IView
    {
        public  ProductLineUsersGridView<ProductLineEntityView> GridView {get;set;}
    }
    public partial class ProductLineUsersGridView <ProductLineEntityView> :  RPSGridView<ProductLineEntityView> where ProductLineEntityView : class, IView
    {
        public ProductLineUsersGridView(ProductLineEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecuteDeleteProductLineUser = RPSControlFactory.CreateRPSGridButton<ProductLineEntityView>( "","#b52ec9d9-b4dd-487c-b2fe-cfe38169c4ef .ag-row[role='row']@ROWINDEX [col-id='cExecuteDeleteProductLineUser']","",this.CurrentView);
 

        }
        public IRPSGridButton<ProductLineEntityView> ExecuteDeleteProductLineUser { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProductLineUserView : View
    {
        public ProductLineUserView(ProductLineUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProductLineUserView>( this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ProductLineUserView>("49f9c99d-1ea6-461f-8f98-e2271a2abc6e","","",true, this);
 
            Structure = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("108de839-bbeb-44f5-8c63-ef6b9a41704b","","",true, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("c1cdfd36-80c1-41c3-954b-9dc14ba0a970","","",true, this);
 
            ImputationMO = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("149ce8bb-302c-4767-9984-8731893eb528","","",true, this);
 
            Feasibility = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("2687c817-6981-4ca1-86b0-7a11d4fc69a8","","",true, this);
 
            FMEA = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("7340980d-9883-4892-a5fd-1158685f71e6","","",true, this);
 
            APPCC = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("1399d744-fe4f-4d49-b595-0628689e897f","","",true, this);
 
            ControlPattern = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("b8d7a685-4e10-4eb4-b896-78e0fc352af5","","",true, this);
 
            MachinePattern = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("54a90304-e040-48a9-a514-f33383cd24e8","","",true, this);
 
            ReceptionPattern = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("b278cf49-ce95-4821-9c0d-908a4238f1db","","",true, this);
 
            ControlPlan = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("4c86e4fc-3d3c-44b0-851c-3b9798f409b1","","",true, this);
 
            SheetProduction = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("4ef03823-ea50-4564-ae63-7f1bd55c1782","","",true, this);
 
            SheetReception = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("99cba354-bb84-4d5c-919e-9a22e9f98364","","",true, this);
 
            FinalPattern = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("7ba76e58-ca65-4153-8b49-db2efda6499e","","",true, this);
 
            SheetFinal = RPSControlFactory.CreateRPSEnumComboBox<ProductLineUserView>("12909ba6-1cbb-4c5b-a219-83b282caf535","","",true, this);
 

        }
        public IRPSSaveButton<ProductLineUserView> SaveButton { get; set; } 
        public IRPSComboBox<ProductLineUserView> CodUser { get; set; } 
        public IRPSComboBox<ProductLineUserView> Structure { get; set; } 
        public IRPSComboBox<ProductLineUserView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<ProductLineUserView> ImputationMO { get; set; } 
        public IRPSComboBox<ProductLineUserView> Feasibility { get; set; } 
        public IRPSComboBox<ProductLineUserView> FMEA { get; set; } 
        public IRPSComboBox<ProductLineUserView> APPCC { get; set; } 
        public IRPSComboBox<ProductLineUserView> ControlPattern { get; set; } 
        public IRPSComboBox<ProductLineUserView> MachinePattern { get; set; } 
        public IRPSComboBox<ProductLineUserView> ReceptionPattern { get; set; } 
        public IRPSComboBox<ProductLineUserView> ControlPlan { get; set; } 
        public IRPSComboBox<ProductLineUserView> SheetProduction { get; set; } 
        public IRPSComboBox<ProductLineUserView> SheetReception { get; set; } 
        public IRPSComboBox<ProductLineUserView> FinalPattern { get; set; } 
        public IRPSComboBox<ProductLineUserView> SheetFinal { get; set; } 
        public ProductLineUser Screen { get; set; }
        public ProductLineUserView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}