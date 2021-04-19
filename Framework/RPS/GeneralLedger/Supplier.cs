    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "generalledger.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierContactView  = new SupplierContactView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
            SupplierContactView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierDetailView SupplierDetailView {get; set; } 
            public SupplierContactView SupplierContactView {get; set; } 
    }
            
    public partial class SupplierCollectionView : View
    {
        public SupplierCollectionView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierCollectionView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "67d392c0-0c9e-474a-aff4-7b06a0bdf9b6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierCollectionView,SupplierEntityView>( params_MainConsult,this,Screen.SupplierEntityView);
 

        }
        public IRPSButton<SupplierCollectionView,SupplierEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierCollectionView,SupplierEntityView> MainConsult { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEntityView : View
    {
        public SupplierEntityView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("60dd5bde-2614-4c8e-893b-932ee94fd672","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("fcd39f95-636e-45a9-aa3d-113c05740523","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("7c3d0367-f7d6-487c-8a8f-417c3347d92b","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("ccbedfed-9303-49e8-8fd4-8712454a0a06","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("eb4162ce-1832-4b1b-b6e8-21f392465fce","","",true, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("1cdbb2fd-2f82-4120-8768-f64174c0ca4a","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("8474a589-6c80-4275-9397-9bceba14c704","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f453448e-a46c-42b3-aa78-762ce7289874","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("b4561045-3ea5-4d8d-971b-76ea952cc1d3","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("58bb74cd-87c5-4d4c-9503-290debb79aa9","","",false, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("daed9c10-9ec2-475e-add0-a406bf1689fe","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("41eede7c-798a-4d15-a977-bb459e03f730","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d1c34b11-85f8-461e-a149-8fa4dbff57bd","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c8de7cf6-ae1f-49b3-a709-89e0461d9bd7","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("0823a617-fd15-48e6-9693-8482643a85fc","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("420dd2cc-aac7-46a3-b279-5ec318cb4c18","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("e6ac2143-9777-4272-8985-046d0b58be96","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("2827798e-c8c0-4e60-955d-1efba607631d","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("b83b07fd-03f6-4809-84f9-24ae2ca208a1","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("5b4330da-af20-4032-8e19-6b0b31bb6481","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("321f443c-1a21-4c18-b45f-8aa56dd7e58b","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("a424b957-933f-4212-8ae7-1f7c75f63ffb","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("a315ae77-c4b0-4312-bf3c-f6d1c7c18b57","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("7a2b9e0c-2fda-4f11-880b-f9f44e24b36d","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f52c6440-0d92-4882-bcb6-1780b158960c","","",true, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("a2877256-7f2d-4539-8e84-4d033d41a5cf","","",false, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("e6dba3d2-e13d-4edf-8927-858dc4d2c8b8","","",true, this);
 
            RetentionType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("2ba77cd0-2303-47e1-a5ec-ba733dedf2c5","","",true, this);
 
            Key = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("ccef3038-7476-4312-bb9c-47e6ee5bb4e7","","",false, this);
 
            SubKey = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("37b5e879-aab5-405e-8938-aa4b46033c53","","",false, this);
 
            IDVatGL = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("9387f061-d665-4817-a3f0-150eb768698d","","",false, this);
 
            IDAccountGL = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("b5a20169-222a-4560-914f-e93276e1bf9c","","",false, this);
 
            CollectionInit params_SupplierContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7bfb20c7-7eaa-4e25-a969-809f11f6c2ca",CSSSelectorGrid="",XPathGrid=""};
            SupplierContacts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierContacts,this,Screen.SupplierDetailView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9e7513e7-c0a5-4c51-be10-45343dbae952",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierDetails,this,Screen.SupplierDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='44c2fd19-0534-4ffb-97e0-b8693a2d80a9']","",this);
 
            SupplierContacts1 = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='7c2b2387-786a-4a9f-a704-9431bc0e71fb']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='6a63007b-a603-4540-b8bd-4d4239fd974e']","",this);
 

        }
        public IRPSSaveButton<SupplierEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierEntityView> CodSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierEntityView> CompanyName { get; set; } 
        public IRPSTextBox<SupplierEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdType { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Miscellaneous { get; set; } 
        public IRPSTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierEntityView> City { get; set; } 
        public IRPSTextBox<SupplierEntityView> Position { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDEUInvoice { get; set; } 
        public IRPSTextBox<SupplierEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<SupplierEntityView> RetentionType { get; set; } 
        public IRPSTextBox<SupplierEntityView> Key { get; set; } 
        public IRPSTextBox<SupplierEntityView> SubKey { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDVatGL { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDAccountGL { get; set; } 
        public SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierContacts { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierEntityView> SupplierContacts1 { get; set; } 
        public IRPSSection<SupplierEntityView> Subsidiaries { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierContactsGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierContactsGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierContactsGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#7bfb20c7-7eaa-4e25-a969-809f11f6c2ca .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierDetailsGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierDetailsGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierDetailsGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",false, this.CurrentView);
 
            Revaluation = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cRevaluation']","",true, this.CurrentView);
 
            IDThirdAccType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cIDThirdAccType']","",true, this.CurrentView);
 
            IDVoucherType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cIDVoucherType']","",true, this.CurrentView);
 
            IDEUInvoice = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cIDEUInvoice']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#9e7513e7-c0a5-4c51-be10-45343dbae952 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> Revaluation { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDThirdAccType { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDVoucherType { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDEUInvoice { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierDetailView : View
    {
        public SupplierDetailView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("79805f3a-1188-48de-a699-12e8e85cd143","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("4a37c3fb-6c20-4a46-843d-4d691135ecd5","","",false, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierDetailView>("0909a7d0-d4e8-41dc-8fc1-c066a2e72cd4","","",true, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("33721bb8-3c72-4c7a-84f4-34f9613b9f5e","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("ed3171ad-0814-411f-af1a-cabed61f3fca","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("411e2a61-f448-4fff-9e62-1e4e9d8d65c4","","",true, this);
 
            IDVatGL = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("11598bfe-dad8-41ab-bebb-7d75c60fa3bc","","",false, this);
 
            IDAccountGL = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("05a82009-c3a8-42ee-9f50-04110b8e6555","","",false, this);
 

        }
        public IRPSButton<SupplierDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierDetailView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierDetailView> CodCompany { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierDetailView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDVatGL { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDAccountGL { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierContactView : View
    {
        public SupplierContactView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("d1f21f5d-9209-49ed-a941-bf1a513efd0c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("421b649c-9342-485f-af89-11bf6ff16aba","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("1004dbf7-7838-4636-926f-4cde5845bbeb","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("e5681594-28da-43de-b5f6-fb286f1d7660","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("078f2ae0-c099-4bda-b9d9-7ff1cee7e655","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("b651cb75-b310-4133-b95c-17d41979be88","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("9c9474c1-f39b-45aa-a7b3-4f430903151e","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("402b0e48-b246-4a87-8812-b0be22df521a","","",false, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("9b6b5e6b-a8e9-4e4d-8512-47df2bfa6180","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("7464928b-836c-4d49-ba59-f2d428dac5e2","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("706cfb36-a583-40e4-910e-5e1a5b01d931","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("04f3963b-98bb-436a-9f43-d95fdf44b135","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='37ce4aab-f3bb-4106-9cef-89925bdc0603']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='8c0b640e-b78e-40c2-bdc5-525566523bf3']","",this);
 

        }
        public IRPSButton<SupplierContactView> DeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierContactView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierContactView> IDContactType { get; set; } 
        public IRPSTextBox<SupplierContactView> Description { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierContactView> Fax { get; set; } 
        public IRPSTextBox<SupplierContactView> Email { get; set; } 
        public IRPSComboBox<SupplierContactView> CodUser { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultFinancial { get; set; } 
        public IRPSTextBox<SupplierContactView> Comment { get; set; } 
        public IRPSSection<SupplierContactView> Section { get; set; } 
        public IRPSSection<SupplierContactView> Section1 { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}