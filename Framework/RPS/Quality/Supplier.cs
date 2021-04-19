    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "quality.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierContactView  = new SupplierContactView(this); 
            SupplierCertificateView  = new SupplierCertificateView(this); 
            SupplierAuditView  = new SupplierAuditView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierContactView.InitializeControls(); 
            SupplierCertificateView.InitializeControls(); 
            SupplierAuditView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierContactView SupplierContactView {get; set; } 
            public SupplierCertificateView SupplierCertificateView {get; set; } 
            public SupplierAuditView SupplierAuditView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ea90c3a2-2674-42d7-9f8a-5b55cc509955",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("4bec3143-9b1d-4c76-b5af-f831f4aef936","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("0cdbc396-b6ff-47b1-9a7f-0052bcdb35a7","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("67c813ab-cd1d-459f-b1a6-7ec942988b1b","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("1a3b88b6-3f2a-4d8c-a928-923e18d8ec5f","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d6eae227-7a7b-4bb9-b895-89e55c4f0d43","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("97548e00-a103-4f38-a830-8824733a77a7","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("94924a3c-4820-4c2b-9c31-8859fab422fe","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("851e6200-b23d-4b88-9e11-f43db5584337","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("6fc841c7-35a5-4fa2-9736-0f40d5f72225","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("da62e35a-0eb3-4e4b-b5f1-52bf61b25e47","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("20d83c47-176e-40b4-8bba-679501bb947d","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("df93c408-8135-4754-96d9-eec9b975d8b5","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("51b6d3a4-ee07-4dd5-9c36-48abe8e2e91f","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("5ad6f15d-8835-4419-ab94-ab9227cfc39a","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("606ff748-c950-417a-b47d-073b31b9e3c9","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("9f8825b3-02ff-4da1-8952-aa4ed508d939","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("6bae5126-cf97-4fd3-afc7-0be40b455a44","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("48a7d640-f7e2-40bb-9459-a35691db9955","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("802679ac-550a-487b-a5c3-a6b9d81781d4","","",false, this);
 
            IDSupplierRankingTable = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("9d378b1d-181e-4c0d-a954-1259c3730844","","",false, this);
 
            RGSA = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("04e3c05d-9184-4758-95d3-b1107cfa9117","","",false, this);
 
            ROESP = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("be0358cf-4f73-497e-a4db-5a77e1acea63","","",false, this);
 
            QualityOfDeliveryReturned = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f16b4104-91c6-472a-9654-53b9a7459a8b","","",false, this);
 
            QualityOfServiceReturned = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("43fafff2-fef3-4b4c-88ca-5f42dbaf61b3","","",false, this);
 
            CollectionInit params_SupplierContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2721763e-7eb1-406e-b3bb-245695d6594b",CSSSelectorGrid="",XPathGrid=""};
            SupplierContacts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierContacts,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierCertificates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ff7eac2-53a4-4f1e-a14d-891e45348c39",CSSSelectorGrid="",XPathGrid=""};
            SupplierCertificates = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierCertificates,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierAudits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="12364bba-9b95-4540-9786-f6e44f59b02d",CSSSelectorGrid="",XPathGrid=""};
            SupplierAudits = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierAudits,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a55d78ba-1e14-4c66-b3de-25ecf68bc1ac",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierDetails,this,Screen.SupplierContactView);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='d3b09a28-d605-49e0-a248-1496dc17b09f']","",this);
 
            SupplierContactSection = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='5350f208-3e66-4c87-8850-93761ac9483f']","",this);
 
            CertificatesSection = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='04ade261-50ae-4432-a9ac-00f22b162fee']","",this);
 
            AuditsSection = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='68f66b93-61e0-41b0-a8f2-6860ce6f1ed8']","",this);
 
            SubsidiariesSection = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='6de49d9a-a130-477b-ae12-96c898f9703a']","",this);
 

        }
        public IRPSSaveButton<SupplierEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierEntityView> CodSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<SupplierEntityView> CompanyName { get; set; } 
        public IRPSTextBox<SupplierEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdType { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
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
        public IRPSComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public IRPSTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSupplierRankingTable { get; set; } 
        public IRPSTextBox<SupplierEntityView> RGSA { get; set; } 
        public IRPSTextBox<SupplierEntityView> ROESP { get; set; } 
        public IRPSTextBox<SupplierEntityView> QualityOfDeliveryReturned { get; set; } 
        public IRPSTextBox<SupplierEntityView> QualityOfServiceReturned { get; set; } 
        public SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierContacts { get; set; } 
        public SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView> SupplierCertificates { get; set; } 
        public SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierAudits { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralSection { get; set; } 
        public IRPSSection<SupplierEntityView> SupplierContactSection { get; set; } 
        public IRPSSection<SupplierEntityView> CertificatesSection { get; set; } 
        public IRPSSection<SupplierEntityView> AuditsSection { get; set; } 
        public IRPSSection<SupplierEntityView> SubsidiariesSection { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierContactsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierContactsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierContactsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Phone2 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cPhone2']","",false, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#2721763e-7eb1-406e-b3bb-245695d6594b .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierCertificatesGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierCertificatesGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierCertificatesGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCertificate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cCodCertificate']","",true, this.CurrentView);
 
            Certificate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cCertificate']","",false, this.CurrentView);
 
            DeliveredBy = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cDeliveredBy']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            Note = RPSControlFactory.CreateRPSGridMemoTextBox<SupplierEntityView>("","#3ff7eac2-53a4-4f1e-a14d-891e45348c39 .ag-row[role='row']@ROWINDEX [col-id='cNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> CodCertificate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Certificate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> DeliveredBy { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Date { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> ExpiryDate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Note { get; set; } 
                     
    }
 
        public partial class SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierAuditsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierAuditsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierAuditsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#12364bba-9b95-4540-9786-f6e44f59b02d .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            CodAudit = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#12364bba-9b95-4540-9786-f6e44f59b02d .ag-row[role='row']@ROWINDEX [col-id='cCodAudit']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#12364bba-9b95-4540-9786-f6e44f59b02d .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Punctuation = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#12364bba-9b95-4540-9786-f6e44f59b02d .ag-row[role='row']@ROWINDEX [col-id='cPunctuation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> Type { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> CodAudit { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Date { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Punctuation { get; set; } 
                     
    }
 
        public partial class SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierDetailsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierDetailsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierDetailsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#a55d78ba-1e14-4c66-b3de-25ecf68bc1ac .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDSupplierRankingTable = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#a55d78ba-1e14-4c66-b3de-25ecf68bc1ac .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRankingTable']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDSupplierRankingTable { get; set; } 
                     
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
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("0979bae9-20d8-4d4c-a538-1266f406cbaf","","",false, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("772728f7-4f7e-4e9d-83af-a94ff0a9dd82","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("c5b3f071-e108-4e4b-8c72-f6a2cdc04b6e","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("5f4c641d-9865-4a89-bc84-15a944c25a3c","","",true, this);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("efd22df9-a78a-4077-83db-414e8cf8707c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("c73beb51-b968-4e74-b1ab-1d712f344738","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("6050c2ee-812f-4a09-b4f2-278b31a2ff51","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("a98e5661-fa22-4949-83d8-a6fe93a9ddee","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("0f981a79-7ef8-4380-8908-7d8ae75db523","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierContactView>("1f6f8b2c-eda9-4fe9-a8de-d5029af9b25f","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("34e25ced-13f5-4242-9753-2997f7c888f3","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("4bff661b-873d-4a58-80f3-a309ee475c94","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='834fe27a-83c0-4694-bee9-cad00e9d9884']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='f104433b-137e-42db-bcb8-99e9b9509c8c']","",this);
 

        }
        public IRPSButton<SupplierContactView> DeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierContactView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultFinancial { get; set; } 
        public IRPSComboBox<SupplierContactView> IDContactType { get; set; } 
        public IRPSTextBox<SupplierContactView> Description { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierContactView> Fax { get; set; } 
        public IRPSTextBox<SupplierContactView> Email { get; set; } 
        public IRPSComboBox<SupplierContactView> CodUser { get; set; } 
        public IRPSTextBox<SupplierContactView> Comment { get; set; } 
        public IRPSSection<SupplierContactView> GeneralData { get; set; } 
        public IRPSSection<SupplierContactView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierCertificateView : View
    {
        public SupplierCertificateView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierCertificateView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCertificate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("b106afe0-7b74-4755-b53e-19f9a5167d48","","",true, this);
 
            Certificate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("6992d8f0-d7c2-419f-bf6e-963cd8065fdc","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("06f3b373-2770-49b3-ba9f-b5dfb3437250","","",false, this);
 
            DeliveredBy = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("8a6066c3-a646-40e4-9df0-ee7d3f949301","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("ef2bb6fd-5351-4ea1-a19d-402c778c3fbf","","",false, this);
 
            Note = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("3fedbb1d-93c2-4d54-9a73-d803a5d9e2a8","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierCertificateView>( "","ul li[rpsid='cdb14bdb-c882-4d55-aefa-aa0b551a225e']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierCertificateView>( "","ul li[rpsid='facaf58b-2931-48ee-9272-061f9c2bc14c']","",this);
 

        }
        public IRPSButton<SupplierCertificateView> DeleteButton { get; set; } 
        public IRPSButton<SupplierCertificateView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierCertificateView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierCertificateView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierCertificateView> CodCertificate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Certificate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Date { get; set; } 
        public IRPSTextBox<SupplierCertificateView> DeliveredBy { get; set; } 
        public IRPSTextBox<SupplierCertificateView> ExpiryDate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Note { get; set; } 
        public IRPSSection<SupplierCertificateView> GeneralData { get; set; } 
        public IRPSSection<SupplierCertificateView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCertificateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierAuditView : View
    {
        public SupplierAuditView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierAuditView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            Type = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("bcf4ee1e-a330-467e-a193-f8c41d6c5dbd","","",false, this);
 
            CodAudit = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("e896de9f-0cf0-4abb-b520-c0f5fec7a92c","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("f394bbc9-f08d-4a56-864b-e6718a5d34d0","","",false, this);
 
            Punctuation = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("dd79cae1-a7eb-483e-bcea-3ab6ca687abd","","",false, this);
 
            Valoration = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("d23d667b-8390-4c5d-b6e3-eb87cd1e99e5","","",false, this);
 
            Report = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("0def3685-663b-4e76-91e7-14f0284312bc","","",false, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("1cff2fae-3068-4bda-aceb-4477e4f58a69","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierAuditView>( "","ul li[rpsid='0dc8f80f-b188-4d73-a747-6340a0b0b9fe']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierAuditView>( "","ul li[rpsid='41f0c1a3-f635-44e4-b1e0-af6d6fa6e585']","",this);
 

        }
        public IRPSButton<SupplierAuditView> DeleteButton { get; set; } 
        public IRPSButton<SupplierAuditView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierAuditView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierAuditView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierAuditView> Type { get; set; } 
        public IRPSTextBox<SupplierAuditView> CodAudit { get; set; } 
        public IRPSTextBox<SupplierAuditView> Date { get; set; } 
        public IRPSTextBox<SupplierAuditView> Punctuation { get; set; } 
        public IRPSTextBox<SupplierAuditView> Valoration { get; set; } 
        public IRPSTextBox<SupplierAuditView> Report { get; set; } 
        public IRPSTextBox<SupplierAuditView> Observation { get; set; } 
        public IRPSSection<SupplierAuditView> GeneralData { get; set; } 
        public IRPSSection<SupplierAuditView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierAuditView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}