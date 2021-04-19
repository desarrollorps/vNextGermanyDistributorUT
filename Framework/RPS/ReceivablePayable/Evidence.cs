    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.Evidence
{
    //RPS VERSION 1.0.0.0
    public partial class Evidence:Screen
    {
        public Evidence():base()
        {
            this.URL = "receivablepayable.evidence";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EvidenceVMQueryView  = new EvidenceVMQueryView(this); 
            EvidenceVMEntityView  = new EvidenceVMEntityView(this); 
            EvidenceDetailView  = new EvidenceDetailView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            EvidenceVMQueryView.InitializeControls(); 
            EvidenceVMEntityView.InitializeControls(); 
            EvidenceDetailView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public EvidenceVMQueryView EvidenceVMQueryView {get; set; } 
            public EvidenceVMEntityView EvidenceVMEntityView {get; set; } 
            public EvidenceDetailView EvidenceDetailView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class EvidenceVMQueryView : View
    {
        public EvidenceVMQueryView(Evidence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EvidenceVMQueryView,EvidenceVMEntityView>( this,Screen.EvidenceVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<EvidenceVMQueryView>( this);
 
            CodEvidenceFrom = RPSControlFactory.CreateRPSEnumComboBox<EvidenceVMQueryView>("9794d9af-9343-4e6b-b43f-b48952e5dafd","","",false, this);
 
            CodEvidenceTo = RPSControlFactory.CreateRPSEnumComboBox<EvidenceVMQueryView>("99266f60-5650-4e7d-a66e-71489aae8686","","",false, this);
 
            OnlyNews = RPSControlFactory.CreateRPSCheckBox<EvidenceVMQueryView>("db2610e2-32d8-470c-9a47-c1a306bd1a0f","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<EvidenceVMQueryView>("a8a35998-7850-4635-904d-a0b2afcf5c1a","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<EvidenceVMQueryView>("2b53a6b8-39f2-4818-adea-feafb20332fb","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<EvidenceVMQueryView>("20b3adc6-f035-4780-a3d1-17b6e052d948","","",false, this);
 
            IDPaymentStatusLIst = RPSControlFactory.CreateRPSCollectionComboBox<EvidenceVMQueryView>("096c79f8-6860-424e-8e84-40315fe450f7","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<EvidenceVMQueryView>( "e826ba3e-8c4e-436c-b6a4-60d154db8c60","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<EvidenceVMQueryView>("be2f41bd-1887-4c8e-90ce-62098e2ea271","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSOption<EvidenceVMQueryView>( "a4541ef8-19f5-4d27-b29a-c200978e8d38","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<EvidenceVMQueryView>("7a58888d-1ae6-4664-9dac-300acf6c89b8","","",false, this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<EvidenceVMQueryView,PrintChildDialogView>("e6dacf3b-909b-45d4-bba7-b029ab047cb5","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_EvidenceConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db9ba4a6-23f3-4c0f-accc-00f27b747b69",CSSSelectorGrid="",XPathGrid=""};
            EvidenceConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EvidenceConsultCollectionEditor<EvidenceVMQueryView,EvidenceVMEntityView>,EvidenceVMQueryView,EvidenceVMEntityView>( params_EvidenceConsult,this,Screen.EvidenceVMEntityView);
 

        }
        public IRPSButton<EvidenceVMQueryView,EvidenceVMEntityView> NewButton { get; set; } 
        public IRPSButton<EvidenceVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<EvidenceVMQueryView> CodEvidenceFrom { get; set; } 
        public IRPSComboBox<EvidenceVMQueryView> CodEvidenceTo { get; set; } 
        public IRPSCheckbox<EvidenceVMQueryView> OnlyNews { get; set; } 
        public IRPSTextBox<EvidenceVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<EvidenceVMQueryView> DateTo { get; set; } 
        public IRPSComboBox<EvidenceVMQueryView> CodUser { get; set; } 
        public IRPSCollectionComboBox<EvidenceVMQueryView> IDPaymentStatusLIst { get; set; } 
        public IRPSOption<EvidenceVMQueryView> Customer { get; set; } 
        public IRPSComboBox<EvidenceVMQueryView> IDCustomer { get; set; } 
        public IRPSOption<EvidenceVMQueryView> Supplier { get; set; } 
        public IRPSComboBox<EvidenceVMQueryView> IDSupplier { get; set; } 
        public IRPSButton<EvidenceVMQueryView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public EvidenceConsultCollectionEditor<EvidenceVMQueryView,EvidenceVMEntityView> EvidenceConsult { get; set; } 
        public Evidence Screen { get; set; }
        public EvidenceVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EvidenceConsultCollectionEditor<EvidenceVMQueryView,EvidenceVMEntityView>:RPSCollectionEditor<EvidenceVMQueryView,EvidenceVMEntityView> where EvidenceVMQueryView : class, IView where EvidenceVMEntityView : class, IView
    {
        public  EvidenceConsultGridView<EvidenceVMQueryView,EvidenceVMEntityView> GridView {get;set;}
    }
    public partial class EvidenceConsultGridView <EvidenceVMQueryView,EvidenceVMEntityView> :  RPSGridView<EvidenceVMQueryView,EvidenceVMEntityView> where EvidenceVMQueryView : class, IView where EvidenceVMEntityView : class, IView
    {
        public EvidenceConsultGridView(EvidenceVMQueryView currentView,EvidenceVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Evidence_CodEvidence = RPSControlFactory.CreateRPSGridTextBox<EvidenceVMQueryView>("","#db9ba4a6-23f3-4c0f-accc-00f27b747b69 .ag-row[role='row']@ROWINDEX [col-id='cEvidence_CodEvidence']","",false, this.CurrentView);
 
            Evidence_ChangeDate = RPSControlFactory.CreateRPSGridTextBox<EvidenceVMQueryView>("","#db9ba4a6-23f3-4c0f-accc-00f27b747b69 .ag-row[role='row']@ROWINDEX [col-id='cEvidence_ChangeDate']","",false, this.CurrentView);
 
            Evidence_Situation = RPSControlFactory.CreateRPSGridTextBox<EvidenceVMQueryView>("","#db9ba4a6-23f3-4c0f-accc-00f27b747b69 .ag-row[role='row']@ROWINDEX [col-id='cEvidence_Situation']","",false, this.CurrentView);
 
            Evidence_CustomerSupplier = RPSControlFactory.CreateRPSGridTextBox<EvidenceVMQueryView>("","#db9ba4a6-23f3-4c0f-accc-00f27b747b69 .ag-row[role='row']@ROWINDEX [col-id='cEvidence_CustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EvidenceVMQueryView> Evidence_CodEvidence { get; set; } 
        public IRPSGridTextBox<EvidenceVMQueryView> Evidence_ChangeDate { get; set; } 
        public IRPSGridTextBox<EvidenceVMQueryView> Evidence_Situation { get; set; } 
        public IRPSGridTextBox<EvidenceVMQueryView> Evidence_CustomerSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class EvidenceVMEntityView : View
    {
        public EvidenceVMEntityView(Evidence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EvidenceVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EvidenceVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EvidenceVMEntityView,EvidenceVMQueryView>( this,Screen.EvidenceVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<EvidenceVMEntityView,EvidenceVMQueryView>( this,Screen.EvidenceVMQueryView);
 
            CodEvidence = RPSControlFactory.CreateRPSTextBox<EvidenceVMEntityView>("1dd4a7fd-711b-445c-a38e-b2b521ec4c6a","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("db8bdcf5-7b06-46f1-b901-9fa65d333cda","","",true, this);
 
            ChangeDate = RPSControlFactory.CreateRPSTextBox<EvidenceVMEntityView>("6483ea05-eeff-4a84-bd5f-f4cb7edbe9ab","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("3ec2c483-6be9-4367-abd6-b87fd2109db0","","",true, this);
 
            Situation = RPSControlFactory.CreateRPSEnumComboBox<EvidenceVMEntityView>("db53b1b5-7e26-4849-84be-ccdd2be9fa97","","",true, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<EvidenceVMEntityView>("3fa1e44f-0738-4e55-bbee-5a1c8e23b14c","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("3fcec577-97c0-4efe-a7c0-b745a2aa16a1","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("2134b6c8-32b0-4f38-ad70-515c013473b5","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("f473f35a-f903-4efd-b92c-81ac44c0ede9","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<EvidenceVMEntityView>("a49721ba-5afc-4fe0-a6d8-a8289785a042","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<EvidenceVMEntityView>("9e811a8a-46f1-43c6-b378-8ffb1c7c8958","","",false, this);
 
            CollectionInit params_EvidenceDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="85025632-80aa-40d1-9f09-2484b0403c3c",CSSSelectorGrid="",XPathGrid=""};
            EvidenceDetails = RPSControlFactory.RPSCreateCollectionWithGrid<EvidenceDetailsCollectionEditor<EvidenceVMEntityView,EvidenceDetailView>,EvidenceVMEntityView,EvidenceDetailView>( params_EvidenceDetails,this,Screen.EvidenceDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<EvidenceVMEntityView>( "","ul li[rpsid='f00a9b20-6454-43f9-b747-dabad07057d0']","",this);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<EvidenceVMEntityView>( "","ul li[rpsid='278a1d0f-ed08-49b9-a5fd-dc07bb30b315']","",this);
 
            SectionComments = RPSControlFactory.CreateRPSSection<EvidenceVMEntityView>( "","ul li[rpsid='bf52a59b-4c2e-4e36-bcdb-2a283b4d1d84']","",this);
 

        }
        public IRPSSaveButton<EvidenceVMEntityView> SaveButton { get; set; } 
        public IRPSButton<EvidenceVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<EvidenceVMEntityView,EvidenceVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EvidenceVMEntityView,EvidenceVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<EvidenceVMEntityView> CodEvidence { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> IDPaymentStatusTo { get; set; } 
        public IRPSTextBox<EvidenceVMEntityView> ChangeDate { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> CodUser { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> Situation { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> CustomerSupplier { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<EvidenceVMEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<EvidenceVMEntityView> Comment { get; set; } 
        public EvidenceDetailsCollectionEditor<EvidenceVMEntityView,EvidenceDetailView> EvidenceDetails { get; set; } 
        public IRPSSection<EvidenceVMEntityView> SectionGeneral { get; set; } 
        public IRPSSection<EvidenceVMEntityView> SectionDetails { get; set; } 
        public IRPSSection<EvidenceVMEntityView> SectionComments { get; set; } 
        public Evidence Screen { get; set; }
        public EvidenceVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EvidenceDetailsCollectionEditor<EvidenceVMEntityView,EvidenceDetailView>:RPSCollectionEditor<EvidenceVMEntityView,EvidenceDetailView> where EvidenceVMEntityView : class, IView where EvidenceDetailView : class, IView
    {
        public  EvidenceDetailsGridView<EvidenceVMEntityView,EvidenceDetailView> GridView {get;set;}
    }
    public partial class EvidenceDetailsGridView <EvidenceVMEntityView,EvidenceDetailView> :  RPSGridView<EvidenceVMEntityView,EvidenceDetailView> where EvidenceVMEntityView : class, IView where EvidenceDetailView : class, IView
    {
        public EvidenceDetailsGridView(EvidenceVMEntityView currentView,EvidenceDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRPTransactions = RPSControlFactory.CreateRPSGridComboBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cIDRPTransactions']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cAmountNominalCurrency']","",true, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            IDPaymentTypeFrom = RPSControlFactory.CreateRPSGridComboBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentTypeFrom']","",true, this.CurrentView);
 
            IDPaymentStatusFrom = RPSControlFactory.CreateRPSGridComboBox<EvidenceVMEntityView>("","#85025632-80aa-40d1-9f09-2484b0403c3c .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentStatusFrom']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EvidenceVMEntityView> IDRPTransactions { get; set; } 
        public IRPSGridComboBox<EvidenceVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<EvidenceVMEntityView> AmountNominalCurrency { get; set; } 
        public IRPSGridTextBox<EvidenceVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<EvidenceVMEntityView> IDPaymentTypeFrom { get; set; } 
        public IRPSGridComboBox<EvidenceVMEntityView> IDPaymentStatusFrom { get; set; } 
                     
    }
 
    }
  
            
    public partial class EvidenceDetailView : View
    {
        public EvidenceDetailView(Evidence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EvidenceDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EvidenceDetailView,EvidenceVMEntityView>( this,Screen.EvidenceVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EvidenceDetailView,EvidenceVMEntityView>( this,Screen.EvidenceVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EvidenceDetailView,EvidenceVMEntityView>( this,Screen.EvidenceVMEntityView);
 
            IDPaymentTypeFrom = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("066b08fc-797b-42d1-933f-a32c784e715e","","",true, this);
 
            IDPaymentTypeTo = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("c29aba78-c848-4284-97a9-e210a120c7b8","","",true, this);
 
            IDPaymentStatusFrom = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("3b73d11a-45ea-47b8-976c-00165a69e90f","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("bf5ac15a-f486-4727-aef2-d1ddd3491678","","",true, this);
 
            IDRPTransactions = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("9123309f-eaf1-4b3d-9e77-5f5fb326e899","","",true, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<EvidenceDetailView>("0c7585b4-15c1-4f37-9812-d90cbb59265e","","",true, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<EvidenceDetailView>("3e319b29-1cbd-44bb-abba-13d3aa628e87","","",true, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("e3ee5e15-b5c0-4b9a-9bcf-2ac68269b65b","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<EvidenceDetailView>("a2feea4c-7884-4483-af0d-3a55f38a7f0c","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<EvidenceDetailView>("fcb14134-14fa-46ff-85ea-c5325835a12d","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("e2319156-fc56-4017-945e-5d5e98cdf92b","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("8af39dcb-a5e6-4c38-a9d6-436252b33685","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("7eef0911-9af8-465b-a7ba-293e27bd729e","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("b331e9a0-be7c-47b8-b071-ba758c1bd437","","",false, this);
 
            AmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("d75e6916-523c-4760-88fe-d107c35ba57a","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<EvidenceDetailView>("3ac05a63-38c2-4098-92cb-50bc7a5ed916","","",true, this);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("1a1feb4f-4b91-4c53-8245-7617f056d5e8","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("102e2289-dc02-4006-9fcf-95ed3caf10ec","","",true, this);
 
            FixedChanged = RPSControlFactory.CreateRPSCheckBox<EvidenceDetailView>("c9b32694-8fdb-40cd-9d28-e783fe77b535","","",true, this);
 
            CDDueDate = RPSControlFactory.CreateRPSTextBox<EvidenceDetailView>("2dc7da4e-b416-4dd1-afe8-165cf5fb5944","","",false, this);
 
            CDAmount = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("a580e808-68f5-4f1c-b8d4-6e0b8348bd59","","",true, this);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<EvidenceDetailView>("cb3741a3-dbcb-49c6-9ab2-9802f67c07a9","","",false, this);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("79914180-5e98-4b40-bd7b-b7ce42478af9","","",true, this);
 
            CDUsed = RPSControlFactory.CreateRPSFormattedTextBox<EvidenceDetailView>("2ba29677-9fc2-40aa-a595-f1f3d945f87a","","",true, this);
 

        }
        public IRPSButton<EvidenceDetailView> DeleteButton { get; set; } 
        public IRPSButton<EvidenceDetailView,EvidenceVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EvidenceDetailView,EvidenceVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EvidenceDetailView,EvidenceVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDPaymentTypeFrom { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDPaymentTypeTo { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDPaymentStatusFrom { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDPaymentStatusTo { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDRPTransactions { get; set; } 
        public IRPSComboBox<EvidenceDetailView> CustomerSupplier { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CodInvoice { get; set; } 
        public IRPSTextBox<EvidenceDetailView> DraftNumber { get; set; } 
        public IRPSTextBox<EvidenceDetailView> InvoiceDate { get; set; } 
        public IRPSTextBox<EvidenceDetailView> DueDate { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDSupplier { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDCustomer { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<EvidenceDetailView> AmountNominal { get; set; } 
        public IRPSComboBox<EvidenceDetailView> IDCurrency { get; set; } 
        public IRPSTextBox<EvidenceDetailView> AmountNominalCurrency { get; set; } 
        public IRPSTextBox<EvidenceDetailView> Change { get; set; } 
        public IRPSCheckbox<EvidenceDetailView> FixedChanged { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CDDueDate { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CDAmount { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CDToleranceDueDate { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CDToleranceAmount { get; set; } 
        public IRPSTextBox<EvidenceDetailView> CDUsed { get; set; } 
        public Evidence Screen { get; set; }
        public EvidenceDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(Evidence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCustomReportCustomer = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("2110b20d-37fa-46ff-bd5c-99a3bc103cf0","","",false, this);
 
            CodCustomReportSupplier = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("5592fcef-9feb-4b20-b82d-036df75f89e3","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "494d19bb-dc1d-4ffb-ba1c-d4026ba5e7ce","","",this);
 
            OneReportperThird = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("76aa79c0-4dfa-4234-9e01-4e169e97cd36","","",false, this);
 
            One = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "12ca3807-9728-4849-b948-93364082ef70","","",this);
 
            IDCustomerPrint = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("1911a537-1e63-469d-9cc0-9fe2a1ed17b3","","",false, this);
 
            IDSupplierPrint = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("a31ac76d-2a3b-4b8a-8a81-322a380883c0","","",false, this);
 
            LanguageThird = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "0d35226c-9213-45f8-98c6-b7c449845cad","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<PrintChildDialogView>( "e11c45bb-3fa7-42d2-83c5-b4a113f5ef81","","",this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintChildDialogView>("de3957d2-5469-485d-974d-2a9c8661ea17","","",false, this);
 
            MyEmail = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("c6d58a9d-27b9-41e2-8acc-893f61ec24fc","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<PrintChildDialogView>( "7be262af-0c6b-449f-823f-18b8e653ed1a","","",this);
 
            MailCommand = RPSControlFactory.CreateRPSButton<PrintChildDialogView>( "791e9e49-0e24-41d0-8935-b61ad4e4c750","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<PrintChildDialogView>( "b020a41f-3042-4562-ab61-2870ca236547","","",this);
 

        }
        public IRPSComboBox<PrintChildDialogView> CodCustomReportCustomer { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CodCustomReportSupplier { get; set; } 
        public IRPSOption<PrintChildDialogView> All { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> OneReportperThird { get; set; } 
        public IRPSOption<PrintChildDialogView> One { get; set; } 
        public IRPSComboBox<PrintChildDialogView> IDCustomerPrint { get; set; } 
        public IRPSComboBox<PrintChildDialogView> IDSupplierPrint { get; set; } 
        public IRPSOption<PrintChildDialogView> LanguageThird { get; set; } 
        public IRPSOption<PrintChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<PrintChildDialogView> CodLanguagePrint { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> MyEmail { get; set; } 
        public IRPSButton<PrintChildDialogView> PrintCommand { get; set; } 
        public IRPSButton<PrintChildDialogView> MailCommand { get; set; } 
        public IRPSButton<PrintChildDialogView> CancelCommand { get; set; } 
        public Evidence Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}