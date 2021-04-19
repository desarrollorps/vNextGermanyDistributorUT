    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod349SII
{
    //RPS VERSION 1.0.0.0
    public partial class Mod349SII:Screen
    {
        public Mod349SII():base()
        {
            this.URL = "taxmodel.mod349sii";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod349SIIView  = new Mod349SIIView(this); 
            Mod349SIIView.InitializeControls(); 
           
        }
      
            public Mod349SIIView Mod349SIIView {get; set; } 
    }
            
    public partial class Mod349SIIView : View
    {
        public Mod349SIIView(Mod349SII screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod349SIIView>("d2e45eaf-fa06-4cf5-89e9-685ce210c4d3","","",true, this);
 
            OptionPeriodo = RPSControlFactory.CreateRPSEnumComboBox<Mod349SIIView>("8ce36733-2b3a-4de8-901c-c88d8b67dce5","","",true, this);
 
            OptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod349SIIView>("b2a699f3-f4fe-4cc0-b8c2-4e00c3d482b2","","",true, this);
 
            OptionBimensual = RPSControlFactory.CreateRPSEnumComboBox<Mod349SIIView>("090c6137-4d13-4aeb-b788-a9dd7f3ce2f9","","",true, this);
 
            OptionTrimestral = RPSControlFactory.CreateRPSEnumComboBox<Mod349SIIView>("5e4aa0c9-0c3d-4be6-b30a-cfd85ab2e24f","","",true, this);
 
            ExecuteSaveMod349FromSIIData = RPSControlFactory.CreateRPSButton<Mod349SIIView>( "830c06aa-9878-4644-abf0-ffa112b3bd3a","","",this);
 
            Prefix = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("4c415631-8851-499d-9edb-4c839f9f5299","","",false, this);
 
            DeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("f8386ac6-1f44-4b33-85c2-ee9534084cd9","","",true, this);
 
            SelectionTypes = RPSControlFactory.CreateRPSEnumComboBox<Mod349SIIView>("a07b9bd4-dbc2-4657-a71b-d2ec960f7303","","",false, this);
 
            IsNavarraFile = RPSControlFactory.CreateRPSCheckBox<Mod349SIIView>("d98af129-87a9-4fa4-bb83-83e6c6954738","","",false, this);
 
            Prefix1 = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("79450c84-a456-4449-938c-21a54a3b4388","","",false, this);
 
            PrevDeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("93eec989-8e22-464e-8a31-74b3da6a6dcb","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("c6fe908d-6d16-45b3-a277-d062916e18fe","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("c517bf22-41c8-43a8-8244-f35cd4542d1d","","",false, this);
 
            TotalCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349SIIView>("83e7ca43-046f-4893-a897-051d58611e99","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349SIIView>("a0cae099-86f3-4bdf-ba69-f739db72561e","","",false, this);
 
            TotalAmendmentCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349SIIView>("dd23fee1-a890-4095-9be0-fe135c32d86a","","",false, this);
 
            TotalAmendmentAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349SIIView>("c19b352b-fc90-46de-ba61-0dab54ed0d89","","",false, this);
 
            MssError = RPSControlFactory.CreateRPSTextBox<Mod349SIIView>("3c10efe8-3d75-4aed-8944-56c2cd94b1a7","","",false, this);
 
            ExecuteGenerateMod349SIIButton = RPSControlFactory.CreateRPSButton<Mod349SIIView>( "573084de-fdd4-4cb1-9495-587b5174731f","","",this);
 
            CollectionInit params_GetMod349PurchasesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e8aff839-942a-4be7-86d9-0503e2261f90",CSSSelectorGrid="",XPathGrid=""};
            GetMod349PurchasesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349PurchasesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349PurchasesList,this);
 
            CollectionInit params_GetMod349PurchasesInvoicesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d82cff13-5019-4ddb-a943-6ab36fb08872",CSSSelectorGrid="",XPathGrid=""};
            GetMod349PurchasesInvoicesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349PurchasesInvoicesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349PurchasesInvoicesList,this);
 
            CollectionInit params_GetMod349SalesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="70760e51-6fc6-4cc6-94d7-db7861f9e3a1",CSSSelectorGrid="",XPathGrid=""};
            GetMod349SalesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349SalesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349SalesList,this);
 
            CollectionInit params_GetMod349SalesInvoicesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="043c61a9-1332-4e96-a627-9245c68d7b08",CSSSelectorGrid="",XPathGrid=""};
            GetMod349SalesInvoicesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349SalesInvoicesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349SalesInvoicesList,this);
 
            CollectionInit params_GetMod349AmendmentPurchasesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a8da9272-4c31-4914-af30-1acf9c73f7f4",CSSSelectorGrid="",XPathGrid=""};
            GetMod349AmendmentPurchasesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349AmendmentPurchasesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349AmendmentPurchasesList,this);
 
            CollectionInit params_GetMod349DeclaringPurchasesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2",CSSSelectorGrid="",XPathGrid=""};
            GetMod349DeclaringPurchasesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349DeclaringPurchasesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349DeclaringPurchasesList,this);
 
            CollectionInit params_GetMod349DeclaredPurchasesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ae9b229-3bfc-46e7-b6bd-40468a481f7a",CSSSelectorGrid="",XPathGrid=""};
            GetMod349DeclaredPurchasesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349DeclaredPurchasesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349DeclaredPurchasesList,this);
 
            CollectionInit params_GetMod349AmendmentSalesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8a0741b3-91f2-42c3-89b6-5b976e878b45",CSSSelectorGrid="",XPathGrid=""};
            GetMod349AmendmentSalesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349AmendmentSalesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349AmendmentSalesList,this);
 
            CollectionInit params_GetMod349DeclaringSalesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ccd8bcce-095d-4f97-9f9c-7a9d69080e57",CSSSelectorGrid="",XPathGrid=""};
            GetMod349DeclaringSalesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349DeclaringSalesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349DeclaringSalesList,this);
 
            CollectionInit params_GetMod349DeclaredSalesList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0a0b3e92-d324-4433-b50e-f1b968c7201b",CSSSelectorGrid="",XPathGrid=""};
            GetMod349DeclaredSalesList = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349DeclaredSalesListCollectionEditor<Mod349SIIView>,Mod349SIIView>( params_GetMod349DeclaredSalesList,this);
 
            SectionPurchase = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='9cbfafd4-4165-4865-8f6b-6be7d0d0c373']","",this);
 
            SectionSales = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='55242775-306a-4760-90b5-aa6102d51227']","",this);
 
            SectionAmendmentPurchases = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='9dae1a1b-1735-4a0a-b9bd-5ef7558ee3b7']","",this);
 
            SectionDeclarandoAhora = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='cf0b651c-fcfa-40c1-b3d5-4c5248c03206']","",this);
 
            SectionDeclaradasAnterior = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='ab2f63eb-dfd3-47b3-a4af-4809a2876192']","",this);
 
            SectionAmendmentSales = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='f5edb2dd-4c69-4104-8f76-9ea19bb58149']","",this);
 
            SectionDeclarandoAhora1 = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='fcf8dcc9-3481-4b4f-95fb-5d601926153f']","",this);
 
            SectionDeclaradasAnterior1 = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='e24d740b-98da-4423-87ab-fe104cf16dfb']","",this);
 
            SectionErrors = RPSControlFactory.CreateRPSSection<Mod349SIIView>( "","ul li[rpsid='0484357b-74c8-429b-9f9c-39cfbc9788be']","",this);
 

        }
        public IRPSTextBox<Mod349SIIView> Exercise { get; set; } 
        public IRPSComboBox<Mod349SIIView> OptionPeriodo { get; set; } 
        public IRPSComboBox<Mod349SIIView> OptionMes { get; set; } 
        public IRPSComboBox<Mod349SIIView> OptionBimensual { get; set; } 
        public IRPSComboBox<Mod349SIIView> OptionTrimestral { get; set; } 
        public IRPSButton<Mod349SIIView> ExecuteSaveMod349FromSIIData { get; set; } 
        public IRPSTextBox<Mod349SIIView> Prefix { get; set; } 
        public IRPSTextBox<Mod349SIIView> DeclarationNumber { get; set; } 
        public IRPSComboBox<Mod349SIIView> SelectionTypes { get; set; } 
        public IRPSCheckbox<Mod349SIIView> IsNavarraFile { get; set; } 
        public IRPSTextBox<Mod349SIIView> Prefix1 { get; set; } 
        public IRPSTextBox<Mod349SIIView> PrevDeclarationNumber { get; set; } 
        public IRPSTextBox<Mod349SIIView> ContactPerson { get; set; } 
        public IRPSTextBox<Mod349SIIView> Phone { get; set; } 
        public IRPSTextBox<Mod349SIIView> TotalCount { get; set; } 
        public IRPSTextBox<Mod349SIIView> TotalAmount { get; set; } 
        public IRPSTextBox<Mod349SIIView> TotalAmendmentCount { get; set; } 
        public IRPSTextBox<Mod349SIIView> TotalAmendmentAmount { get; set; } 
        public IRPSTextBox<Mod349SIIView> MssError { get; set; } 
        public IRPSButton<Mod349SIIView> ExecuteGenerateMod349SIIButton { get; set; } 
        public GetMod349PurchasesListCollectionEditor<Mod349SIIView> GetMod349PurchasesList { get; set; } 
        public GetMod349PurchasesInvoicesListCollectionEditor<Mod349SIIView> GetMod349PurchasesInvoicesList { get; set; } 
        public GetMod349SalesListCollectionEditor<Mod349SIIView> GetMod349SalesList { get; set; } 
        public GetMod349SalesInvoicesListCollectionEditor<Mod349SIIView> GetMod349SalesInvoicesList { get; set; } 
        public GetMod349AmendmentPurchasesListCollectionEditor<Mod349SIIView> GetMod349AmendmentPurchasesList { get; set; } 
        public GetMod349DeclaringPurchasesListCollectionEditor<Mod349SIIView> GetMod349DeclaringPurchasesList { get; set; } 
        public GetMod349DeclaredPurchasesListCollectionEditor<Mod349SIIView> GetMod349DeclaredPurchasesList { get; set; } 
        public GetMod349AmendmentSalesListCollectionEditor<Mod349SIIView> GetMod349AmendmentSalesList { get; set; } 
        public GetMod349DeclaringSalesListCollectionEditor<Mod349SIIView> GetMod349DeclaringSalesList { get; set; } 
        public GetMod349DeclaredSalesListCollectionEditor<Mod349SIIView> GetMod349DeclaredSalesList { get; set; } 
        public IRPSSection<Mod349SIIView> SectionPurchase { get; set; } 
        public IRPSSection<Mod349SIIView> SectionSales { get; set; } 
        public IRPSSection<Mod349SIIView> SectionAmendmentPurchases { get; set; } 
        public IRPSSection<Mod349SIIView> SectionDeclarandoAhora { get; set; } 
        public IRPSSection<Mod349SIIView> SectionDeclaradasAnterior { get; set; } 
        public IRPSSection<Mod349SIIView> SectionAmendmentSales { get; set; } 
        public IRPSSection<Mod349SIIView> SectionDeclarandoAhora1 { get; set; } 
        public IRPSSection<Mod349SIIView> SectionDeclaradasAnterior1 { get; set; } 
        public IRPSSection<Mod349SIIView> SectionErrors { get; set; } 
        public Mod349SII Screen { get; set; }
        public Mod349SIIView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod349PurchasesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349PurchasesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349PurchasesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349PurchasesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#e8aff839-942a-4be7-86d9-0503e2261f90 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#e8aff839-942a-4be7-86d9-0503e2261f90 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#e8aff839-942a-4be7-86d9-0503e2261f90 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#e8aff839-942a-4be7-86d9-0503e2261f90 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            BaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#e8aff839-942a-4be7-86d9-0503e2261f90 .ag-row[role='row']@ROWINDEX [col-id='cBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> BaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349PurchasesInvoicesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349PurchasesInvoicesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349PurchasesInvoicesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349PurchasesInvoicesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#d82cff13-5019-4ddb-a943-6ab36fb08872 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#d82cff13-5019-4ddb-a943-6ab36fb08872 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#d82cff13-5019-4ddb-a943-6ab36fb08872 .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#d82cff13-5019-4ddb-a943-6ab36fb08872 .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 
            AutoInvoiceType = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#d82cff13-5019-4ddb-a943-6ab36fb08872 .ag-row[role='row']@ROWINDEX [col-id='cAutoInvoiceType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> AutoInvoiceType { get; set; } 
                     
    }
 
        public partial class GetMod349SalesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349SalesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349SalesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349SalesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#70760e51-6fc6-4cc6-94d7-db7861f9e3a1 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#70760e51-6fc6-4cc6-94d7-db7861f9e3a1 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#70760e51-6fc6-4cc6-94d7-db7861f9e3a1 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#70760e51-6fc6-4cc6-94d7-db7861f9e3a1 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            BaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#70760e51-6fc6-4cc6-94d7-db7861f9e3a1 .ag-row[role='row']@ROWINDEX [col-id='cBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> BaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349SalesInvoicesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349SalesInvoicesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349SalesInvoicesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349SalesInvoicesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#043c61a9-1332-4e96-a627-9245c68d7b08 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#043c61a9-1332-4e96-a627-9245c68d7b08 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#043c61a9-1332-4e96-a627-9245c68d7b08 .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#043c61a9-1332-4e96-a627-9245c68d7b08 .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
                     
    }
 
        public partial class GetMod349AmendmentPurchasesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349AmendmentPurchasesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349AmendmentPurchasesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349AmendmentPurchasesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            Exercise = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cExercise']","",false, this.CurrentView);
 
            PeriodName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cPeriodName']","",false, this.CurrentView);
 
            AmendedBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cAmendedBaseAmount']","",false, this.CurrentView);
 
            DeclaredBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#a8da9272-4c31-4914-af30-1acf9c73f7f4 .ag-row[role='row']@ROWINDEX [col-id='cDeclaredBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> Exercise { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> PeriodName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> AmendedBaseAmount { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclaredBaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349DeclaringPurchasesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349DeclaringPurchasesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349DeclaringPurchasesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349DeclaringPurchasesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cDeclarationYear']","",false, this.CurrentView);
 
            DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cDeclarationMonth']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 
            AutoInvoiceType = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#5b5b9751-ed44-4ed6-aca5-1d8d83c80cc2 .ag-row[role='row']@ROWINDEX [col-id='cAutoInvoiceType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> DeclarationYear { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclarationMonth { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> AutoInvoiceType { get; set; } 
                     
    }
 
        public partial class GetMod349DeclaredPurchasesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349DeclaredPurchasesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349DeclaredPurchasesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349DeclaredPurchasesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cDeclarationYear']","",false, this.CurrentView);
 
            DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cDeclarationMonth']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 
            AutoInvoiceType = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0ae9b229-3bfc-46e7-b6bd-40468a481f7a .ag-row[role='row']@ROWINDEX [col-id='cAutoInvoiceType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> DeclarationYear { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclarationMonth { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> AutoInvoiceType { get; set; } 
                     
    }
 
        public partial class GetMod349AmendmentSalesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349AmendmentSalesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349AmendmentSalesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349AmendmentSalesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            Exercise = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cExercise']","",false, this.CurrentView);
 
            PeriodName = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cPeriodName']","",false, this.CurrentView);
 
            AmendedBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cAmendedBaseAmount']","",false, this.CurrentView);
 
            DeclaredBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#8a0741b3-91f2-42c3-89b6-5b976e878b45 .ag-row[role='row']@ROWINDEX [col-id='cDeclaredBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> Exercise { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> PeriodName { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> AmendedBaseAmount { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclaredBaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349DeclaringSalesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349DeclaringSalesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349DeclaringSalesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349DeclaringSalesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cDeclarationYear']","",false, this.CurrentView);
 
            DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cDeclarationMonth']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#ccd8bcce-095d-4f97-9f9c-7a9d69080e57 .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> DeclarationYear { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclarationMonth { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
                     
    }
 
        public partial class GetMod349DeclaredSalesListCollectionEditor<Mod349SIIView>:RPSCollectionEditor<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public  GetMod349DeclaredSalesListGridView<Mod349SIIView> GridView {get;set;}
    }
    public partial class GetMod349DeclaredSalesListGridView <Mod349SIIView> :  RPSGridView<Mod349SIIView> where Mod349SIIView : class, IView
    {
        public GetMod349DeclaredSalesListGridView(Mod349SIIView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cDeclarationYear']","",false, this.CurrentView);
 
            DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cDeclarationMonth']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 
            CountryFrom = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cCountryFrom']","",false, this.CurrentView);
 
            CountryTo = RPSControlFactory.CreateRPSGridTextBox<Mod349SIIView>("","#0a0b3e92-d324-4433-b50e-f1b968c7201b .ag-row[role='row']@ROWINDEX [col-id='cCountryTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349SIIView> DeclarationYear { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> DeclarationMonth { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> VATBase { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryFrom { get; set; } 
        public IRPSGridTextBox<Mod349SIIView> CountryTo { get; set; } 
                     
    }
 
    }
  
    

}