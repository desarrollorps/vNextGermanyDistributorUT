    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIIAudit
{
    //RPS VERSION 1.0.0.0
    public partial class SIIAudit:Screen
    {
        public SIIAudit():base()
        {
            this.URL = "taxmodel.siiaudit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SIIAuditQueryView  = new SIIAuditQueryView(this); 
            ReloadDataChildDialogView  = new ReloadDataChildDialogView(this); 
            SIIAuditDetailView  = new SIIAuditDetailView(this); 
            ReloadLineChildDialogView  = new ReloadLineChildDialogView(this); 
            SIIAuditQueryView.InitializeControls(); 
            ReloadDataChildDialogView.InitializeControls(); 
            SIIAuditDetailView.InitializeControls(); 
            ReloadLineChildDialogView.InitializeControls(); 
           
        }
      
            public SIIAuditQueryView SIIAuditQueryView {get; set; } 
            public ReloadDataChildDialogView ReloadDataChildDialogView {get; set; } 
            public SIIAuditDetailView SIIAuditDetailView {get; set; } 
            public ReloadLineChildDialogView ReloadLineChildDialogView {get; set; } 
    }
            
    public partial class SIIAuditQueryView : View
    {
        public SIIAuditQueryView(SIIAudit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Purchase = RPSControlFactory.CreateRPSCheckBox<SIIAuditQueryView>("4a3bbe85-080c-4210-9aa9-b610c3e71587","","",false, this);
 
            Sales = RPSControlFactory.CreateRPSCheckBox<SIIAuditQueryView>("3b8cdfa1-ea58-4154-b8f5-25cb8b2fa0da","","",false, this);
 
            AlsoEditableFields = RPSControlFactory.CreateRPSCheckBox<SIIAuditQueryView>("44cf9867-1294-40d4-bf5d-f359c46b554b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SIIAuditQueryView>("5fc9af74-c28c-4f55-a0bb-089af53e2054","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SIIAuditQueryView>("798f128a-e844-43de-a55c-a88d93cdfa99","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<SIIAuditQueryView>("f1510c15-7f32-4842-9267-e1fda3f22426","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<SIIAuditQueryView>("c0731c38-fe6b-440a-aba0-bb7633437788","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<SIIAuditQueryView>("57573418-5769-44bc-9cb7-0e6b9734d42f","","",false, this);
 
            VATAPRegisterNumberFrom = RPSControlFactory.CreateRPSFormattedTextBox<SIIAuditQueryView>("8f07b1cc-0c8d-4603-90e3-198fc06e8260","","",false, this);
 
            VATAPRegisterNumberTo = RPSControlFactory.CreateRPSFormattedTextBox<SIIAuditQueryView>("d3a4b516-f995-48df-b09b-94c3719afcad","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<SIIAuditQueryView>("021fb704-427c-4ae2-b137-9de9d4ff82e5","","",false, this);
 
            VATARRegisterNumberFrom = RPSControlFactory.CreateRPSFormattedTextBox<SIIAuditQueryView>("17d83570-af3f-4b41-8077-61b023c3908b","","",false, this);
 
            VATARRegisterNumberTo = RPSControlFactory.CreateRPSFormattedTextBox<SIIAuditQueryView>("8871346b-8aff-4cd0-a61e-13b232220bd3","","",false, this);
 
            ReloadDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SIIAuditQueryView,ReloadDataChildDialogView>("6cb27680-7274-4ccc-8048-73a6bb187ee9","","", this,Screen.ReloadDataChildDialogView);
 
            CollectionInit params_GetSIIAudit = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ad6b3721-c207-49dc-8feb-f6c5eec95f1d",CSSSelectorGrid="",XPathGrid=""};
            GetSIIAudit = RPSControlFactory.RPSCreateCollectionWithGrid<GetSIIAuditCollectionEditor<SIIAuditQueryView>,SIIAuditQueryView>( params_GetSIIAudit,this);
 

        }
        public IRPSCheckbox<SIIAuditQueryView> Purchase { get; set; } 
        public IRPSCheckbox<SIIAuditQueryView> Sales { get; set; } 
        public IRPSCheckbox<SIIAuditQueryView> AlsoEditableFields { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> DateFrom { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> DateTo { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> InvoiceDateTo { get; set; } 
        public IRPSCollectionComboBox<SIIAuditQueryView> IDSupplier { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> VATAPRegisterNumberFrom { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> VATAPRegisterNumberTo { get; set; } 
        public IRPSCollectionComboBox<SIIAuditQueryView> IDCustomer { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> VATARRegisterNumberFrom { get; set; } 
        public IRPSTextBox<SIIAuditQueryView> VATARRegisterNumberTo { get; set; } 
        public IRPSButton<SIIAuditQueryView,ReloadDataChildDialogView> ReloadDataChildNavigationCommandButton { get; set; } 
        public GetSIIAuditCollectionEditor<SIIAuditQueryView> GetSIIAudit { get; set; } 
        public SIIAudit Screen { get; set; }
        public SIIAuditQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSIIAuditCollectionEditor<SIIAuditQueryView>:RPSCollectionEditor<SIIAuditQueryView> where SIIAuditQueryView : class, IView
    {
        public  GetSIIAuditGridView<SIIAuditQueryView> GridView {get;set;}
    }
    public partial class GetSIIAuditGridView <SIIAuditQueryView> :  RPSGridView<SIIAuditQueryView> where SIIAuditQueryView : class, IView
    {
        public GetSIIAuditGridView(SIIAuditQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionStatusBefore = RPSControlFactory.CreateRPSGridTextBox<SIIAuditQueryView>("","#ad6b3721-c207-49dc-8feb-f6c5eec95f1d .ag-row[role='row']@ROWINDEX [col-id='cActionStatusBefore']","",false, this.CurrentView);
 
            ActionStatusAfter = RPSControlFactory.CreateRPSGridTextBox<SIIAuditQueryView>("","#ad6b3721-c207-49dc-8feb-f6c5eec95f1d .ag-row[role='row']@ROWINDEX [col-id='cActionStatusAfter']","",false, this.CurrentView);
 
            Sign = RPSControlFactory.CreateRPSGridTextBox<SIIAuditQueryView>("","#ad6b3721-c207-49dc-8feb-f6c5eec95f1d .ag-row[role='row']@ROWINDEX [col-id='cSign']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIAuditQueryView> ActionStatusBefore { get; set; } 
        public IRPSGridTextBox<SIIAuditQueryView> ActionStatusAfter { get; set; } 
        public IRPSGridTextBox<SIIAuditQueryView> Sign { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReloadDataChildDialogView : View
    {
        public ReloadDataChildDialogView(SIIAudit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedRegisters = RPSControlFactory.CreateRPSTextBox<ReloadDataChildDialogView>("2436592d-a91e-4039-bf65-54595295e0f0","","",false, this);
 
            AlsoEditableFields = RPSControlFactory.CreateRPSCheckBox<ReloadDataChildDialogView>("a9890582-6d26-4aa8-ae29-aa57b26a63d6","","",false, this);
 
            Unfreeze = RPSControlFactory.CreateRPSCheckBox<ReloadDataChildDialogView>("876075cb-e2e9-40d9-bbf8-b78c17eed0e1","","",false, this);
 
            VoucherDate = RPSControlFactory.CreateRPSOption<ReloadDataChildDialogView>( "794d3edb-f49f-47d7-b53b-90a7449aebd5","","",this);
 
            LoadDate = RPSControlFactory.CreateRPSOption<ReloadDataChildDialogView>( "a7d63680-1af3-4119-a1c2-f8fee6f079a4","","",this);
 
            UseFixedPeriod = RPSControlFactory.CreateRPSCheckBox<ReloadDataChildDialogView>("9051a7b3-4c01-4f46-806c-ec53705f5ccb","","",false, this);
 
            nYear = RPSControlFactory.CreateRPSFormattedTextBox<ReloadDataChildDialogView>("88b8110a-c618-455f-9a9d-ea699bce4028","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<ReloadDataChildDialogView>("a4fed3f7-f889-4f31-9c07-b6638fc25cc3","","",false, this);
 

        }
        public IRPSTextBox<ReloadDataChildDialogView> SelectedRegisters { get; set; } 
        public IRPSCheckbox<ReloadDataChildDialogView> AlsoEditableFields { get; set; } 
        public IRPSCheckbox<ReloadDataChildDialogView> Unfreeze { get; set; } 
        public IRPSOption<ReloadDataChildDialogView> VoucherDate { get; set; } 
        public IRPSOption<ReloadDataChildDialogView> LoadDate { get; set; } 
        public IRPSCheckbox<ReloadDataChildDialogView> UseFixedPeriod { get; set; } 
        public IRPSTextBox<ReloadDataChildDialogView> nYear { get; set; } 
        public IRPSComboBox<ReloadDataChildDialogView> eMonth { get; set; } 
        public SIIAudit Screen { get; set; }
        public ReloadDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SIIAuditDetailView : View
    {
        public SIIAuditDetailView(SIIAudit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TextSignType = RPSControlFactory.CreateRPSTextBox<SIIAuditDetailView>("b8423f6b-50ac-4b7c-856c-74cc0d4ca271","","",false, this);
 
            TextChangeType = RPSControlFactory.CreateRPSTextBox<SIIAuditDetailView>("361dda2a-73fc-49fd-9560-6e67cb68939c","","",false, this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<SIIAuditDetailView>("d283f2fc-93f5-41a1-9e3f-c31f47f77036","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<SIIAuditDetailView>("6575577d-9b0d-4df0-8633-248aa7d6ee7b","","",false, this);
 
            TaxPurchaseInvoice = RPSControlFactory.CreateRPSComboBox<SIIAuditDetailView>("08c71351-e6bb-4e09-891e-01f732299b00","","",false, this);
 
            TaxSalesInvoice = RPSControlFactory.CreateRPSComboBox<SIIAuditDetailView>("776b8af2-0fc5-4a9f-a06d-7189461a4693","","",false, this);
 
            ReloadLineChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SIIAuditDetailView,ReloadLineChildDialogView>("e83758ac-d7d7-4516-b6c7-af40ea4c389c","","", this,Screen.ReloadLineChildDialogView);
 
            CollectionInit params_GetSIIAuditDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58d18423-33e0-4916-9a40-9559e709c090",CSSSelectorGrid="",XPathGrid=""};
            GetSIIAuditDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetSIIAuditDetailCollectionEditor<SIIAuditDetailView,ReloadDataChildDialogView>,SIIAuditDetailView,ReloadDataChildDialogView>( params_GetSIIAuditDetail,this,Screen.ReloadDataChildDialogView);
 

        }
        public IRPSTextBox<SIIAuditDetailView> TextSignType { get; set; } 
        public IRPSTextBox<SIIAuditDetailView> TextChangeType { get; set; } 
        public IRPSComboBox<SIIAuditDetailView> IDACCTransactions { get; set; } 
        public IRPSTextBox<SIIAuditDetailView> CodInvoice { get; set; } 
        public IRPSComboBox<SIIAuditDetailView> TaxPurchaseInvoice { get; set; } 
        public IRPSComboBox<SIIAuditDetailView> TaxSalesInvoice { get; set; } 
        public IRPSButton<SIIAuditDetailView,ReloadLineChildDialogView> ReloadLineChildNavigationCommandButton { get; set; } 
        public GetSIIAuditDetailCollectionEditor<SIIAuditDetailView,ReloadDataChildDialogView> GetSIIAuditDetail { get; set; } 
        public SIIAudit Screen { get; set; }
        public SIIAuditDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSIIAuditDetailCollectionEditor<SIIAuditDetailView,ReloadDataChildDialogView>:RPSCollectionEditor<SIIAuditDetailView,ReloadDataChildDialogView> where SIIAuditDetailView : class, IView where ReloadDataChildDialogView : class, IView
    {
        public  GetSIIAuditDetailGridView<SIIAuditDetailView,ReloadDataChildDialogView> GridView {get;set;}
    }
    public partial class GetSIIAuditDetailGridView <SIIAuditDetailView,ReloadDataChildDialogView> :  RPSGridView<SIIAuditDetailView,ReloadDataChildDialogView> where SIIAuditDetailView : class, IView where ReloadDataChildDialogView : class, IView
    {
        public GetSIIAuditDetailGridView(SIIAuditDetailView currentView,ReloadDataChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<SIIAuditDetailView>("","#58d18423-33e0-4916-9a40-9559e709c090 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            OldValue = RPSControlFactory.CreateRPSGridTextBox<SIIAuditDetailView>("","#58d18423-33e0-4916-9a40-9559e709c090 .ag-row[role='row']@ROWINDEX [col-id='cOldValue']","",false, this.CurrentView);
 
            NewValue = RPSControlFactory.CreateRPSGridTextBox<SIIAuditDetailView>("","#58d18423-33e0-4916-9a40-9559e709c090 .ag-row[role='row']@ROWINDEX [col-id='cNewValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIAuditDetailView> Description { get; set; } 
        public IRPSGridTextBox<SIIAuditDetailView> OldValue { get; set; } 
        public IRPSGridTextBox<SIIAuditDetailView> NewValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReloadLineChildDialogView : View
    {
        public ReloadLineChildDialogView(SIIAudit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AlsoEditableFields = RPSControlFactory.CreateRPSCheckBox<ReloadLineChildDialogView>("e8ba2b73-7864-4bcc-b7af-4b50e5e1e661","","",false, this);
 
            Unfreeze = RPSControlFactory.CreateRPSCheckBox<ReloadLineChildDialogView>("bc84aca6-bb0d-41cc-8a45-1e658db16cf7","","",false, this);
 
            VoucherDate = RPSControlFactory.CreateRPSOption<ReloadLineChildDialogView>( "bd4a9a67-e735-4d33-a92c-1f6dc633caf1","","",this);
 
            LoadDate = RPSControlFactory.CreateRPSOption<ReloadLineChildDialogView>( "45a06206-713e-41c6-a4a9-27f556690cca","","",this);
 
            UseFixedPeriod = RPSControlFactory.CreateRPSCheckBox<ReloadLineChildDialogView>("80076141-34f3-46c7-afaa-0410a8f9b204","","",false, this);
 
            nYear = RPSControlFactory.CreateRPSFormattedTextBox<ReloadLineChildDialogView>("2ac9caab-0b68-4cc7-8611-6a894d182684","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<ReloadLineChildDialogView>("99c42390-37ab-4a5a-8f55-1d26e8e5e1b4","","",false, this);
 

        }
        public IRPSCheckbox<ReloadLineChildDialogView> AlsoEditableFields { get; set; } 
        public IRPSCheckbox<ReloadLineChildDialogView> Unfreeze { get; set; } 
        public IRPSOption<ReloadLineChildDialogView> VoucherDate { get; set; } 
        public IRPSOption<ReloadLineChildDialogView> LoadDate { get; set; } 
        public IRPSCheckbox<ReloadLineChildDialogView> UseFixedPeriod { get; set; } 
        public IRPSTextBox<ReloadLineChildDialogView> nYear { get; set; } 
        public IRPSComboBox<ReloadLineChildDialogView> eMonth { get; set; } 
        public SIIAudit Screen { get; set; }
        public ReloadLineChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}