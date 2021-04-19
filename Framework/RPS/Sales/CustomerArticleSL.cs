    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerArticleSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerArticleSL:Screen
    {
        public CustomerArticleSL():base()
        {
            this.URL = "sales.customerarticlesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerArticleSLQueryView  = new CustomerArticleSLQueryView(this); 
            CustomerArticleSLEntityView  = new CustomerArticleSLEntityView(this); 
            CustomerArticlePriceSLView  = new CustomerArticlePriceSLView(this); 
            CustomerArticlePriceCommissionSLView  = new CustomerArticlePriceCommissionSLView(this); 
            CustomerArticleSLQueryView.InitializeControls(); 
            CustomerArticleSLEntityView.InitializeControls(); 
            CustomerArticlePriceSLView.InitializeControls(); 
            CustomerArticlePriceCommissionSLView.InitializeControls(); 
           
        }
      
            public CustomerArticleSLQueryView CustomerArticleSLQueryView {get; set; } 
            public CustomerArticleSLEntityView CustomerArticleSLEntityView {get; set; } 
            public CustomerArticlePriceSLView CustomerArticlePriceSLView {get; set; } 
            public CustomerArticlePriceCommissionSLView CustomerArticlePriceCommissionSLView {get; set; } 
    }
            
    public partial class CustomerArticleSLQueryView : View
    {
        public CustomerArticleSLQueryView(CustomerArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerArticleSLQueryView,CustomerArticleSLEntityView>( this,Screen.CustomerArticleSLEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CustomerArticleSLQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<CustomerArticleSLQueryView>("486af78a-fd94-463a-93bb-04469e8343c8","","",false, this);
 
            Article = RPSControlFactory.CreateRPSOption<CustomerArticleSLQueryView>( "7bdbe5e0-1265-4f0f-bffb-fd0f5874cab8","","",this);
 
            UIIDArticle = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLQueryView>("f4f77e39-6402-48eb-b8d3-300a787637af","","",false, this);
 
            UIlsIDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<CustomerArticleSLQueryView>("ceabe37b-f7e8-4d76-ab3f-cb9b09479519","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<CustomerArticleSLQueryView>( "39f986d2-f84f-461f-9e81-3b2477062781","","",this);
 
            UIIDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLQueryView>("229688a7-9059-44f6-be8f-32d310ff87be","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<CustomerArticleSLQueryView>("df43253b-b639-44c3-b9a9-2a052dbaec6e","","",false, this);
 
            CollectionInit params_CustomerArticleSLConsult = new CollectionInit(){IDDescriptor = "8d8dcd2a-2e4a-4e2e-9c56-e147cb211e91",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e3b236e1-b966-45e1-836c-a477dca6344f",CSSSelectorGrid="",XPathGrid=""};
            CustomerArticleSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerArticleSLConsultCollectionEditor<CustomerArticleSLQueryView,CustomerArticleSLEntityView>,CustomerArticleSLQueryView,CustomerArticleSLEntityView>( params_CustomerArticleSLConsult,this,Screen.CustomerArticleSLEntityView);
 

        }
        public IRPSButton<CustomerArticleSLQueryView,CustomerArticleSLEntityView> NewButton { get; set; } 
        public IRPSButton<CustomerArticleSLQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CustomerArticleSLQueryView> UIActiveDate { get; set; } 
        public IRPSOption<CustomerArticleSLQueryView> Article { get; set; } 
        public IRPSComboBox<CustomerArticleSLQueryView> UIIDArticle { get; set; } 
        public IRPSCollectionComboBox<CustomerArticleSLQueryView> UIlsIDCustomer { get; set; } 
        public IRPSOption<CustomerArticleSLQueryView> Customer { get; set; } 
        public IRPSComboBox<CustomerArticleSLQueryView> UIIDCustomer { get; set; } 
        public IRPSCollectionComboBox<CustomerArticleSLQueryView> UIlsIDArticle { get; set; } 
        public CustomerArticleSLConsultCollectionEditor<CustomerArticleSLQueryView,CustomerArticleSLEntityView> CustomerArticleSLConsult { get; set; } 
        public CustomerArticleSL Screen { get; set; }
        public CustomerArticleSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerArticleSLConsultCollectionEditor<CustomerArticleSLQueryView,CustomerArticleSLEntityView>:RPSCollectionEditor<CustomerArticleSLQueryView,CustomerArticleSLEntityView> where CustomerArticleSLQueryView : class, IView where CustomerArticleSLEntityView : class, IView
    {
        public  CustomerArticleSLConsultGridView<CustomerArticleSLQueryView,CustomerArticleSLEntityView> GridView {get;set;}
    }
    public partial class CustomerArticleSLConsultGridView <CustomerArticleSLQueryView,CustomerArticleSLEntityView> :  RPSGridView<CustomerArticleSLQueryView,CustomerArticleSLEntityView> where CustomerArticleSLQueryView : class, IView where CustomerArticleSLEntityView : class, IView
    {
        public CustomerArticleSLConsultGridView(CustomerArticleSLQueryView currentView,CustomerArticleSLEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerArticleSL_DescriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_DescriptionCustomer']","",false, this.CurrentView);
 
            CustomerArticleSL_ReferenceCustomer = RPSControlFactory.CreateRPSGridTextBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_ReferenceCustomer']","",false, this.CurrentView);
 
            CustomerArticleSL_Blocked = RPSControlFactory.CreateRPSGridCheckBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_Blocked']","",false, this.CurrentView);
 
            CustomerArticleSL_SalesKit = RPSControlFactory.CreateRPSGridCheckBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_SalesKit']","",false, this.CurrentView);
 
            CustomerArticleSL_VAT = RPSControlFactory.CreateRPSGridCheckBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_VAT']","",false, this.CurrentView);
 
            CustomerArticleSL_Default = RPSControlFactory.CreateRPSGridCheckBox<CustomerArticleSLQueryView>("","#e3b236e1-b966-45e1-836c-a477dca6344f .ag-row[role='row']@ROWINDEX [col-id='cCustomerArticleSL_Default']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerArticleSLQueryView> CustomerArticleSL_DescriptionCustomer { get; set; } 
        public IRPSGridTextBox<CustomerArticleSLQueryView> CustomerArticleSL_ReferenceCustomer { get; set; } 
        public IRPSGridCheckbox<CustomerArticleSLQueryView> CustomerArticleSL_Blocked { get; set; } 
        public IRPSGridCheckbox<CustomerArticleSLQueryView> CustomerArticleSL_SalesKit { get; set; } 
        public IRPSGridCheckbox<CustomerArticleSLQueryView> CustomerArticleSL_VAT { get; set; } 
        public IRPSGridCheckbox<CustomerArticleSLQueryView> CustomerArticleSL_Default { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerArticleSLEntityView : View
    {
        public CustomerArticleSLEntityView(CustomerArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerArticleSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerArticleSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerArticleSLEntityView,CustomerArticleSLQueryView>( this,Screen.CustomerArticleSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerArticleSLEntityView,CustomerArticleSLQueryView>( this,Screen.CustomerArticleSLQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLEntityView>("719a748f-848e-492b-83eb-281de1983407","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLEntityView>("aecada05-1346-415b-b572-0b39f373996d","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLEntityView>("1e883b01-f321-4efc-b05d-ea635b8de60f","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<CustomerArticleSLEntityView>("a0636cd9-5006-4b3d-953a-d13e62db98a0","","",true, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSTextBox<CustomerArticleSLEntityView>("a919cec1-220a-4d56-b0a2-ccf1c6dec404","","",false, this);
 
            DescriptionCustomer = RPSControlFactory.CreateRPSTextBox<CustomerArticleSLEntityView>("5854f6ac-1952-4c53-acd1-d584cee66a2e","","",false, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<CustomerArticleSLEntityView>("68de6db9-b060-410d-bddb-85f03d4fbb39","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<CustomerArticleSLEntityView>("cb604327-84f0-4cb7-8dd2-525f6c9e75fb","","",true, this);
 
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLEntityView>("64c217ad-fb1c-4ba0-a300-6f2d8ba7cdfb","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerArticleSLEntityView>("6a804fb8-660e-4c73-aef9-ba6d58da0ed1","","",true, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<CustomerArticleSLEntityView>("00db897f-51a9-45d0-9e11-5eea522880b3","","",true, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<CustomerArticleSLEntityView>("ad623482-26b1-43e7-8549-1b32c66f086d","","",false, this);
 
            DuplicateCommandButton = RPSControlFactory.CreateRPSButton<CustomerArticleSLEntityView>( "5f0c0c80-f157-40eb-99db-ef4612e7ecd7","","",this);
 
            CollectionInit params_CustomerArticlePriceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8",CSSSelectorGrid="",XPathGrid=""};
            CustomerArticlePriceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerArticlePriceSLsCollectionEditor<CustomerArticleSLEntityView,CustomerArticlePriceSLView>,CustomerArticleSLEntityView,CustomerArticlePriceSLView>( params_CustomerArticlePriceSLs,this,Screen.CustomerArticlePriceSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerArticleSLEntityView>( "","ul li[rpsid='36a9dcb6-0e20-4f2b-a997-a2f1e5c5ee37']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<CustomerArticleSLEntityView>( "","ul li[rpsid='bbe5d128-9df0-4e0f-aeab-6d31578282c0']","",this);
 

        }
        public IRPSSaveButton<CustomerArticleSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerArticleSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerArticleSLEntityView,CustomerArticleSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerArticleSLEntityView,CustomerArticleSLQueryView> BackButton { get; set; } 
        public IRPSComboBox<CustomerArticleSLEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CustomerArticleSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CustomerArticleSLEntityView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<CustomerArticleSLEntityView> Blocked { get; set; } 
        public IRPSTextBox<CustomerArticleSLEntityView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<CustomerArticleSLEntityView> DescriptionCustomer { get; set; } 
        public IRPSCheckbox<CustomerArticleSLEntityView> SalesKit { get; set; } 
        public IRPSCheckbox<CustomerArticleSLEntityView> VAT { get; set; } 
        public IRPSComboBox<CustomerArticleSLEntityView> IDArticleContainer { get; set; } 
        public IRPSComboBox<CustomerArticleSLEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<CustomerArticleSLEntityView> Default { get; set; } 
        public IRPSTextBox<CustomerArticleSLEntityView> TechnicalDescription { get; set; } 
        public IRPSButton<CustomerArticleSLEntityView> DuplicateCommandButton { get; set; } 
        public CustomerArticlePriceSLsCollectionEditor<CustomerArticleSLEntityView,CustomerArticlePriceSLView> CustomerArticlePriceSLs { get; set; } 
        public IRPSSection<CustomerArticleSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerArticleSLEntityView> TechnicalDescription1 { get; set; } 
        public CustomerArticleSL Screen { get; set; }
        public CustomerArticleSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerArticlePriceSLsCollectionEditor<CustomerArticleSLEntityView,CustomerArticlePriceSLView>:RPSCollectionEditor<CustomerArticleSLEntityView,CustomerArticlePriceSLView> where CustomerArticleSLEntityView : class, IView where CustomerArticlePriceSLView : class, IView
    {
        public  CustomerArticlePriceSLsGridView<CustomerArticleSLEntityView,CustomerArticlePriceSLView> GridView {get;set;}
    }
    public partial class CustomerArticlePriceSLsGridView <CustomerArticleSLEntityView,CustomerArticlePriceSLView> :  RPSGridView<CustomerArticleSLEntityView,CustomerArticlePriceSLView> where CustomerArticleSLEntityView : class, IView where CustomerArticlePriceSLView : class, IView
    {
        public CustomerArticlePriceSLsGridView(CustomerArticleSLEntityView currentView,CustomerArticlePriceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerArticleSLEntityView>("","#fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerArticleSLEntityView>("","#fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerArticleSLEntityView>("","#fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerArticleSLEntityView>("","#fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            NetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerArticleSLEntityView>("","#fea8dd0f-9728-43cb-ac7b-f9c0654ef3d8 .ag-row[role='row']@ROWINDEX [col-id='cNetPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerArticleSLEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerArticleSLEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerArticleSLEntityView> QuantityFrom { get; set; } 
        public IRPSGridTextBox<CustomerArticleSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<CustomerArticleSLEntityView> NetPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerArticlePriceSLView : View
    {
        public CustomerArticlePriceSLView(CustomerArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerArticlePriceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView>( this,Screen.CustomerArticleSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView>( this,Screen.CustomerArticleSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView>( this,Screen.CustomerArticleSLEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CustomerArticlePriceSLView>("577b1f86-0584-4d5b-8eec-23c772f44d68","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CustomerArticlePriceSLView>("3c19bdfd-3737-4760-87fa-3d956ad93f4d","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("b7aa122f-ef58-45ba-8325-3ffc535b01da","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerArticlePriceSLView>("ed490653-6bfd-4125-90f6-62dc01bbdfbc","","",true, this);
 
            CodSalesQuote = RPSControlFactory.CreateRPSTextBox<CustomerArticlePriceSLView>("90b0c474-a9e3-48dc-aa79-779e2eaccccd","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("f6042990-a9f3-46ab-9662-b4d55bcd1584","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerArticlePriceSLView>("73b60adb-3ef3-4bc0-97da-d527d94faebc","","",true, this);
 
            ValidPrice = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("453d4728-7493-484b-a2c7-0dbadccc4e33","","",true, this);
 
            ValidDiscount = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("6cf3d4ba-8a43-4c96-9ebd-cecda1692ede","","",true, this);
 
            NetPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("8a9359de-f487-4e49-9fab-76d840c1087f","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("222d42c4-c7bd-47c7-a112-f564301183e6","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("61011dcf-e1dc-401d-ad38-19f48c7be773","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("db33e35e-5487-440b-a232-1d5586a26f56","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("c9bfd160-9e3f-41e4-a901-eaf27f1ea9d6","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("3c876370-2fa3-4b7c-b239-a4ef5773a3f1","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("9fb3f8da-e2b9-4f44-809e-01fac4d2efb5","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("47930822-e24d-4596-8de1-a7026fe1754f","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("5a90fdd0-57e2-4046-ab4c-8b1ff3cfea30","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("1c6e8853-801f-43ea-b580-1107f58a8621","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("72645b80-6172-4b16-b7af-15442a1cd0ec","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("31ee9760-7cdc-436b-8e1d-f61e1ef033dd","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceSLView>("b5cb5787-dd45-4c5a-b745-d7eb5d2df85b","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<CustomerArticlePriceSLView>("e06fbf42-bedb-49ed-b2a1-5df2a3c5ddb4","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerArticlePriceSLView>("d9df4a69-0c0a-4164-84bb-1bd3e6c336c8","","",true, this);
 
            CollectionInit params_CustomerArticlePriceCommissionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2e21d21f-ee20-4b91-b55b-d2db41881b7b",CSSSelectorGrid="",XPathGrid=""};
            CustomerArticlePriceCommissionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerArticlePriceCommissionSLsCollectionEditor<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView>,CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView>( params_CustomerArticlePriceCommissionSLs,this,Screen.CustomerArticlePriceCommissionSLView);
 

        }
        public IRPSButton<CustomerArticlePriceSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerArticlePriceSLView,CustomerArticleSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> DateFrom { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> DateTo { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> QuantityFrom { get; set; } 
        public IRPSComboBox<CustomerArticlePriceSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> CodSalesQuote { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Price { get; set; } 
        public IRPSComboBox<CustomerArticlePriceSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> ValidPrice { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> ValidDiscount { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> NetPrice { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Discount1 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Discount2 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Discount3 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> CascadeDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Discount4 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> Discount5 { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<CustomerArticlePriceSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<CustomerArticlePriceSLView> PositionAmountDiscount { get; set; } 
        public IRPSCheckbox<CustomerArticlePriceSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public CustomerArticlePriceCommissionSLsCollectionEditor<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView> CustomerArticlePriceCommissionSLs { get; set; } 
        public CustomerArticleSL Screen { get; set; }
        public CustomerArticlePriceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerArticlePriceCommissionSLsCollectionEditor<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView>:RPSCollectionEditor<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView> where CustomerArticlePriceSLView : class, IView where CustomerArticlePriceCommissionSLView : class, IView
    {
        public  CustomerArticlePriceCommissionSLsGridView<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView> GridView {get;set;}
    }
    public partial class CustomerArticlePriceCommissionSLsGridView <CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView> :  RPSGridView<CustomerArticlePriceSLView,CustomerArticlePriceCommissionSLView> where CustomerArticlePriceSLView : class, IView where CustomerArticlePriceCommissionSLView : class, IView
    {
        public CustomerArticlePriceCommissionSLsGridView(CustomerArticlePriceSLView currentView,CustomerArticlePriceCommissionSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<CustomerArticlePriceSLView>("","#2e21d21f-ee20-4b91-b55b-d2db41881b7b .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerArticlePriceSLView>("","#2e21d21f-ee20-4b91-b55b-d2db41881b7b .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerArticlePriceSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<CustomerArticlePriceSLView> Commission { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerArticlePriceCommissionSLView : View
    {
        public CustomerArticlePriceCommissionSLView(CustomerArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerArticlePriceCommissionSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView>( this,Screen.CustomerArticlePriceSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView>( this,Screen.CustomerArticlePriceSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView>( this,Screen.CustomerArticlePriceSLView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CustomerArticlePriceCommissionSLView>("367e99fb-5c6b-4359-b82e-659f31bec092","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<CustomerArticlePriceCommissionSLView>("975bb19e-3868-4f1b-b7f9-3e4939231f56","","",true, this);
 

        }
        public IRPSButton<CustomerArticlePriceCommissionSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerArticlePriceCommissionSLView,CustomerArticlePriceSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerArticlePriceCommissionSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<CustomerArticlePriceCommissionSLView> Commission { get; set; } 
        public CustomerArticleSL Screen { get; set; }
        public CustomerArticlePriceCommissionSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}