    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.ForecastTree
{
    //RPS VERSION 1.0.0.0
    public partial class ForecastTree:Screen
    {
        public ForecastTree():base()
        {
            this.URL = "receivablepayable.forecasttree";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ForecastTreeQueryView  = new ForecastTreeQueryView(this); 
            ForecastTreeDetailsChildDialogView  = new ForecastTreeDetailsChildDialogView(this); 
            ForecastTreeQueryView.InitializeControls(); 
            ForecastTreeDetailsChildDialogView.InitializeControls(); 
           
        }
      
            public ForecastTreeQueryView ForecastTreeQueryView {get; set; } 
            public ForecastTreeDetailsChildDialogView ForecastTreeDetailsChildDialogView {get; set; } 
    }
            
    public partial class ForecastTreeQueryView : View
    {
        public ForecastTreeQueryView(ForecastTree screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            dtStartDate = RPSControlFactory.CreateRPSTextBox<ForecastTreeQueryView>("5a97b1df-5e11-48e7-af1e-a99a7f06a3e9","","",true, this);
 
            nPeriodDays = RPSControlFactory.CreateRPSFormattedTextBox<ForecastTreeQueryView>("19ae5bac-f3f9-4bd3-93a7-217606dfc1fa","","",false, this);
 
            bCommercialMonths = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("2ecc3ed6-55c0-418e-a0c7-d256eac96b20","","",false, this);
 
            bUseCheckDueDate = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("c8d783a3-0cbb-4f7a-a4af-78eb3286e689","","",false, this);
 
            bRoundAmounts = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("17da5814-aafc-4a13-9170-c05da31a78ff","","",false, this);
 
            bIncludeEmptyBank = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("feb9c14d-4517-4cbd-aa38-60c79cf7e956","","",false, this);
 
            bFilterByBank = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("fa59136f-42a1-49bf-92bb-8f535fb6f97f","","",false, this);
 
            BankAccountCompanys = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("d58fdd68-76f5-4e30-9af4-8e9a64b9829e","","",false, this);
 
            bUseAccountBalance = RPSControlFactory.CreateRPSCheckBox<ForecastTreeQueryView>("d56873ab-c874-41a1-98f8-1a612f689771","","",false, this);
 
            PaymentTypes = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("c2820290-7c76-49c1-8dda-8cfd8801ed01","","",false, this);
 
            PaymentStatuses = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("cc5cdafb-2a3d-43ac-9c63-9187009906e7","","",false, this);
 
            ForecastTypes = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("da3789ce-d72a-4a67-aca9-00952ec285de","","",false, this);
 
            Customers = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("3c1f250b-aabe-4349-8b88-0d7490da5db1","","",false, this);
 
            Suppliers = RPSControlFactory.CreateRPSCollectionComboBox<ForecastTreeQueryView>("2fdcf475-4610-4164-b9ea-d8c08801a964","","",false, this);
 
            DetailsCommandButton = RPSControlFactory.CreateRPSButton<ForecastTreeQueryView>( "259f03c6-da0e-4c6f-a822-c8fd7d1c7ce0","","",this);
 

        }
        public IRPSTextBox<ForecastTreeQueryView> dtStartDate { get; set; } 
        public IRPSTextBox<ForecastTreeQueryView> nPeriodDays { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bCommercialMonths { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bUseCheckDueDate { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bRoundAmounts { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bIncludeEmptyBank { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bFilterByBank { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> BankAccountCompanys { get; set; } 
        public IRPSCheckbox<ForecastTreeQueryView> bUseAccountBalance { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> PaymentTypes { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> PaymentStatuses { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> ForecastTypes { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> Customers { get; set; } 
        public IRPSCollectionComboBox<ForecastTreeQueryView> Suppliers { get; set; } 
        public IRPSButton<ForecastTreeQueryView> DetailsCommandButton { get; set; } 
        public ForecastTree Screen { get; set; }
        public ForecastTreeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ForecastTreeDetailsChildDialogView : View
    {
        public ForecastTreeDetailsChildDialogView(ForecastTree screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<ForecastTreeDetailsChildDialogView>("5107eb7c-1bda-4217-b4e5-d7da065b8fd7","","",false, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<ForecastTreeDetailsChildDialogView>("92a61b85-3727-42f9-b72a-1f21458fee67","","",false, this);
 
            DetailDateFrom = RPSControlFactory.CreateRPSTextBox<ForecastTreeDetailsChildDialogView>("f90b48a2-1cae-4aca-ae4a-7ebba401d2c6","","",false, this);
 
            DetailDateTo = RPSControlFactory.CreateRPSTextBox<ForecastTreeDetailsChildDialogView>("4621492b-e882-4065-94a5-ed030c256ed6","","",false, this);
 
            IDForecastType = RPSControlFactory.CreateRPSComboBox<ForecastTreeDetailsChildDialogView>("c928a0f3-d491-45f3-b157-fab91e76d694","","",false, this);
 
            DetailDateFrom1 = RPSControlFactory.CreateRPSTextBox<ForecastTreeDetailsChildDialogView>("b69ab1da-99c0-4f93-a3d1-fe6336f64d39","","",false, this);
 
            DetailDateTo1 = RPSControlFactory.CreateRPSTextBox<ForecastTreeDetailsChildDialogView>("29738fb5-e608-4320-83d3-08fcb9dda7b6","","",false, this);
 
            CollectionInit params_ForecastTreeDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="63edb851-a011-4a13-b1b2-c114e3ed351d",CSSSelectorGrid="",XPathGrid=""};
            ForecastTreeDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ForecastTreeDetailsCollectionEditor<ForecastTreeDetailsChildDialogView>,ForecastTreeDetailsChildDialogView>( params_ForecastTreeDetails,this);
 

        }
        public IRPSComboBox<ForecastTreeDetailsChildDialogView> IDPaymentType { get; set; } 
        public IRPSComboBox<ForecastTreeDetailsChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSTextBox<ForecastTreeDetailsChildDialogView> DetailDateFrom { get; set; } 
        public IRPSTextBox<ForecastTreeDetailsChildDialogView> DetailDateTo { get; set; } 
        public IRPSComboBox<ForecastTreeDetailsChildDialogView> IDForecastType { get; set; } 
        public IRPSTextBox<ForecastTreeDetailsChildDialogView> DetailDateFrom1 { get; set; } 
        public IRPSTextBox<ForecastTreeDetailsChildDialogView> DetailDateTo1 { get; set; } 
        public ForecastTreeDetailsCollectionEditor<ForecastTreeDetailsChildDialogView> ForecastTreeDetails { get; set; } 
        public ForecastTree Screen { get; set; }
        public ForecastTreeDetailsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ForecastTreeDetailsCollectionEditor<ForecastTreeDetailsChildDialogView>:RPSCollectionEditor<ForecastTreeDetailsChildDialogView> where ForecastTreeDetailsChildDialogView : class, IView
    {
        public  ForecastTreeDetailsGridView<ForecastTreeDetailsChildDialogView> GridView {get;set;}
    }
    public partial class ForecastTreeDetailsGridView <ForecastTreeDetailsChildDialogView> :  RPSGridView<ForecastTreeDetailsChildDialogView> where ForecastTreeDetailsChildDialogView : class, IView
    {
        public ForecastTreeDetailsGridView(ForecastTreeDetailsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ForecastDate = RPSControlFactory.CreateRPSGridTextBox<ForecastTreeDetailsChildDialogView>("","#63edb851-a011-4a13-b1b2-c114e3ed351d .ag-row[role='row']@ROWINDEX [col-id='cForecastDate']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<ForecastTreeDetailsChildDialogView>("","#63edb851-a011-4a13-b1b2-c114e3ed351d .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CheckDate = RPSControlFactory.CreateRPSGridTextBox<ForecastTreeDetailsChildDialogView>("","#63edb851-a011-4a13-b1b2-c114e3ed351d .ag-row[role='row']@ROWINDEX [col-id='cCheckDate']","",false, this.CurrentView);
 
            CheckDueDate = RPSControlFactory.CreateRPSGridTextBox<ForecastTreeDetailsChildDialogView>("","#63edb851-a011-4a13-b1b2-c114e3ed351d .ag-row[role='row']@ROWINDEX [col-id='cCheckDueDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ForecastTreeDetailsChildDialogView> ForecastDate { get; set; } 
        public IRPSGridTextBox<ForecastTreeDetailsChildDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<ForecastTreeDetailsChildDialogView> CheckDate { get; set; } 
        public IRPSGridTextBox<ForecastTreeDetailsChildDialogView> CheckDueDate { get; set; } 
                     
    }
 
    }
  
    

}