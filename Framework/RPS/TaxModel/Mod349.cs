    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod349
{
    //RPS VERSION 1.0.0.0
    public partial class Mod349:Screen
    {
        public Mod349():base()
        {
            this.URL = "taxmodel.mod349";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod349View  = new Mod349View(this); 
            Mod349View.InitializeControls(); 
           
        }
      
            public Mod349View Mod349View {get; set; } 
    }
            
    public partial class Mod349View : View
    {
        public Mod349View(Mod349 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod349View>("6b3c9e12-14f6-4798-bca3-125379d4331b","","",true, this);
 
            OptionPeriodo = RPSControlFactory.CreateRPSEnumComboBox<Mod349View>("57672a3e-b850-4f0a-881b-1e0485862ad8","","",true, this);
 
            OptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod349View>("307285d2-dbde-4402-9306-8059bca1ee3b","","",true, this);
 
            OptionBimestre = RPSControlFactory.CreateRPSEnumComboBox<Mod349View>("fd9b1949-3f1d-4a2b-a57d-4bce098a3fa8","","",true, this);
 
            OptionTrimestre = RPSControlFactory.CreateRPSEnumComboBox<Mod349View>("5115c0fe-28d6-463d-8031-aaf5c28e9645","","",true, this);
 
            ExecuteSaveMod349Data = RPSControlFactory.CreateRPSButton<Mod349View>( "8ee8f7ad-24eb-4bbe-87bf-e078769e3c17","","",this);
 
            Prefix = RPSControlFactory.CreateRPSTextBox<Mod349View>("986c07e2-9161-4425-947a-5c3e4d5c7d7e","","",false, this);
 
            DeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod349View>("b64afb1c-6f3f-492d-8d5b-32dc8bf4eaad","","",true, this);
 
            SelectionTypes = RPSControlFactory.CreateRPSEnumComboBox<Mod349View>("abcb9473-636c-456f-88bd-c2be9849e41a","","",true, this);
 
            IsNavarraFile = RPSControlFactory.CreateRPSCheckBox<Mod349View>("114ae122-affd-488f-8369-50deb5521b79","","",false, this);
 
            Prefix1 = RPSControlFactory.CreateRPSTextBox<Mod349View>("3fc31511-dfae-4aca-a34b-85de367d8206","","",false, this);
 
            PrevDeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod349View>("13a7ec8a-b93d-45ad-a125-e8304762a8c5","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<Mod349View>("a602a336-8e6f-46b3-94e8-956dc5dcccd9","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<Mod349View>("e53aa995-feb5-403a-a662-a3d3a20e8031","","",false, this);
 
            TotalCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349View>("83e7ca43-046f-4893-a897-051d58611e99","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349View>("a0cae099-86f3-4bdf-ba69-f739db72561e","","",false, this);
 
            TotalAmendmentCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349View>("dd23fee1-a890-4095-9be0-fe135c32d86a","","",false, this);
 
            TotalAmendmentAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod349View>("c19b352b-fc90-46de-ba61-0dab54ed0d89","","",false, this);
 
            MssError = RPSControlFactory.CreateRPSTextBox<Mod349View>("3c10efe8-3d75-4aed-8944-56c2cd94b1a7","","",false, this);
 
            ExecuteGenerateMod349Button = RPSControlFactory.CreateRPSButton<Mod349View>( "eae35f6f-ca7d-4f5b-b1b5-947fc88c76c4","","",this);
 
            CollectionInit params_GetMod349ListPurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6099c9f9-6992-4161-b0e3-39717c0b4080",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListPurchases = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListPurchasesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListPurchases,this);
 
            CollectionInit params_GetMod349ListPurchasesInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f8378131-87b7-4b10-9d53-2aecd270cf2d",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListPurchasesInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListPurchasesInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListPurchasesInvoices,this);
 
            CollectionInit params_GetMod349ListPurchasesAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8591a81b-8f17-4202-b850-f64ec33e8dad",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListPurchasesAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListPurchasesAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListPurchasesAdvances,this);
 
            CollectionInit params_GetMod349ListSales = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a8a83a26-c87c-4be5-a949-87656beeb6df",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListSales = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListSalesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListSales,this);
 
            CollectionInit params_GetMod349ListSalesInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e9575a7-cffe-47d4-90bd-bcf074452bb0",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListSalesInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListSalesInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListSalesInvoices,this);
 
            CollectionInit params_GetMod349ListSalesAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ac4de18a-c355-4138-ba4f-1280a5ff7306",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListSalesAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListSalesAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListSalesAdvances,this);
 
            CollectionInit params_GetMod349ListAmendmentPurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e88f1523-7026-4314-aef0-e255a5d50846",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListAmendmentPurchases = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListAmendmentPurchasesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListAmendmentPurchases,this);
 
            CollectionInit params_GetMod349PurchasesListAmendmentsInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="52a8b94a-3b50-4626-bcfe-d1e0d7237787",CSSSelectorGrid="",XPathGrid=""};
            GetMod349PurchasesListAmendmentsInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349PurchasesListAmendmentsInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349PurchasesListAmendmentsInvoices,this);
 
            CollectionInit params_GetMod349PurchasesListDeclaredInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5853d8a6-8d2b-4a59-a2bb-b8fbbae83e74",CSSSelectorGrid="",XPathGrid=""};
            GetMod349PurchasesListDeclaredInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349PurchasesListDeclaredInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349PurchasesListDeclaredInvoices,this);
 
            CollectionInit params_GetMod349ListPurchasesAmendmentsAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0c257408-e01a-4f40-911f-a916530b48e6",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListPurchasesAmendmentsAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListPurchasesAmendmentsAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListPurchasesAmendmentsAdvances,this);
 
            CollectionInit params_GetMod349ListPurchasesDeclaredAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a781b83c-44f7-469c-8a88-3a5ab8528299",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListPurchasesDeclaredAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListPurchasesDeclaredAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListPurchasesDeclaredAdvances,this);
 
            CollectionInit params_GetMod349ListAmendmentSales = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="983c80e2-3a26-4817-9675-2bd4abc0a07c",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListAmendmentSales = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListAmendmentSalesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListAmendmentSales,this);
 
            CollectionInit params_GetMod349SalesListAmendmentsInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3cd30ac9-309b-4cdc-88c4-137493c9d907",CSSSelectorGrid="",XPathGrid=""};
            GetMod349SalesListAmendmentsInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349SalesListAmendmentsInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349SalesListAmendmentsInvoices,this);
 
            CollectionInit params_GetMod349SalesListDeclaredInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d48a4216-a2af-48f6-b2d0-d556f2224e40",CSSSelectorGrid="",XPathGrid=""};
            GetMod349SalesListDeclaredInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349SalesListDeclaredInvoicesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349SalesListDeclaredInvoices,this);
 
            CollectionInit params_GetMod349ListSalesAmendmentsAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="434cefef-575a-44e6-93c2-9097da28342e",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListSalesAmendmentsAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListSalesAmendmentsAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListSalesAmendmentsAdvances,this);
 
            CollectionInit params_GetMod349ListSalesDeclaredAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="32b5488c-8ddd-4460-a7dd-55be83b981c4",CSSSelectorGrid="",XPathGrid=""};
            GetMod349ListSalesDeclaredAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod349ListSalesDeclaredAdvancesCollectionEditor<Mod349View>,Mod349View>( params_GetMod349ListSalesDeclaredAdvances,this);
 
            SectionPurchase = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='d76016f5-4441-48e9-8701-ac73df67ca91']","",this);
 
            Invoices = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='adb6289e-bb5e-45b4-841c-9863cfef67d6']","",this);
 
            Advances = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='47acf070-c635-404e-be6b-34a1461dbfef']","",this);
 
            SectionSales = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='c5b8762f-4d60-4c08-9aca-5ff2ce6b7a5c']","",this);
 
            Invoices1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='fdf369c1-9097-4508-9e1e-fbcb4be38102']","",this);
 
            Advances1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='70dbaeb9-c827-4c70-b68c-6403eb37c7c5']","",this);
 
            SectionAmendmentPurchase = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='47ba2332-0805-4e4a-8d7f-ab6ff016e368']","",this);
 
            AmendmentsInvoices = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='7a49271a-0fbe-4b16-9816-c451eb77fcf8']","",this);
 
            DeclaredInvoices = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='191eb7d2-4eae-4507-aebd-3bfac36c6f9d']","",this);
 
            AmendmentsAdvances = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='dcff7b28-ea9f-4768-9e69-e8c7c14ccb8d']","",this);
 
            DeclaredAdvances = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='a3365407-c028-418e-a4e1-81c5d237917c']","",this);
 
            SectionAmendmentSales = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='4a942a5d-a5eb-4a31-9f5d-0f08a93a3053']","",this);
 
            AmendmentsInvoices1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='a30a7f86-e397-4330-8f3b-d362e12a8400']","",this);
 
            DeclaredInvoices1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='05f53892-8e69-4f9a-9d0b-7d508f78305c']","",this);
 
            AmendmentsAdvances1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='20106579-e95a-4dfe-b6d2-2963b0967878']","",this);
 
            DeclaredAdvances1 = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='1a9c18dc-ee5e-42cd-9ba7-c1406ce1987f']","",this);
 
            SectionErrors = RPSControlFactory.CreateRPSSection<Mod349View>( "","ul li[rpsid='0484357b-74c8-429b-9f9c-39cfbc9788be']","",this);
 

        }
        public IRPSTextBox<Mod349View> Exercise { get; set; } 
        public IRPSComboBox<Mod349View> OptionPeriodo { get; set; } 
        public IRPSComboBox<Mod349View> OptionMes { get; set; } 
        public IRPSComboBox<Mod349View> OptionBimestre { get; set; } 
        public IRPSComboBox<Mod349View> OptionTrimestre { get; set; } 
        public IRPSButton<Mod349View> ExecuteSaveMod349Data { get; set; } 
        public IRPSTextBox<Mod349View> Prefix { get; set; } 
        public IRPSTextBox<Mod349View> DeclarationNumber { get; set; } 
        public IRPSComboBox<Mod349View> SelectionTypes { get; set; } 
        public IRPSCheckbox<Mod349View> IsNavarraFile { get; set; } 
        public IRPSTextBox<Mod349View> Prefix1 { get; set; } 
        public IRPSTextBox<Mod349View> PrevDeclarationNumber { get; set; } 
        public IRPSTextBox<Mod349View> ContactPerson { get; set; } 
        public IRPSTextBox<Mod349View> Phone { get; set; } 
        public IRPSTextBox<Mod349View> TotalCount { get; set; } 
        public IRPSTextBox<Mod349View> TotalAmount { get; set; } 
        public IRPSTextBox<Mod349View> TotalAmendmentCount { get; set; } 
        public IRPSTextBox<Mod349View> TotalAmendmentAmount { get; set; } 
        public IRPSTextBox<Mod349View> MssError { get; set; } 
        public IRPSButton<Mod349View> ExecuteGenerateMod349Button { get; set; } 
        public GetMod349ListPurchasesCollectionEditor<Mod349View> GetMod349ListPurchases { get; set; } 
        public GetMod349ListPurchasesInvoicesCollectionEditor<Mod349View> GetMod349ListPurchasesInvoices { get; set; } 
        public GetMod349ListPurchasesAdvancesCollectionEditor<Mod349View> GetMod349ListPurchasesAdvances { get; set; } 
        public GetMod349ListSalesCollectionEditor<Mod349View> GetMod349ListSales { get; set; } 
        public GetMod349ListSalesInvoicesCollectionEditor<Mod349View> GetMod349ListSalesInvoices { get; set; } 
        public GetMod349ListSalesAdvancesCollectionEditor<Mod349View> GetMod349ListSalesAdvances { get; set; } 
        public GetMod349ListAmendmentPurchasesCollectionEditor<Mod349View> GetMod349ListAmendmentPurchases { get; set; } 
        public GetMod349PurchasesListAmendmentsInvoicesCollectionEditor<Mod349View> GetMod349PurchasesListAmendmentsInvoices { get; set; } 
        public GetMod349PurchasesListDeclaredInvoicesCollectionEditor<Mod349View> GetMod349PurchasesListDeclaredInvoices { get; set; } 
        public GetMod349ListPurchasesAmendmentsAdvancesCollectionEditor<Mod349View> GetMod349ListPurchasesAmendmentsAdvances { get; set; } 
        public GetMod349ListPurchasesDeclaredAdvancesCollectionEditor<Mod349View> GetMod349ListPurchasesDeclaredAdvances { get; set; } 
        public GetMod349ListAmendmentSalesCollectionEditor<Mod349View> GetMod349ListAmendmentSales { get; set; } 
        public GetMod349SalesListAmendmentsInvoicesCollectionEditor<Mod349View> GetMod349SalesListAmendmentsInvoices { get; set; } 
        public GetMod349SalesListDeclaredInvoicesCollectionEditor<Mod349View> GetMod349SalesListDeclaredInvoices { get; set; } 
        public GetMod349ListSalesAmendmentsAdvancesCollectionEditor<Mod349View> GetMod349ListSalesAmendmentsAdvances { get; set; } 
        public GetMod349ListSalesDeclaredAdvancesCollectionEditor<Mod349View> GetMod349ListSalesDeclaredAdvances { get; set; } 
        public IRPSSection<Mod349View> SectionPurchase { get; set; } 
        public IRPSSection<Mod349View> Invoices { get; set; } 
        public IRPSSection<Mod349View> Advances { get; set; } 
        public IRPSSection<Mod349View> SectionSales { get; set; } 
        public IRPSSection<Mod349View> Invoices1 { get; set; } 
        public IRPSSection<Mod349View> Advances1 { get; set; } 
        public IRPSSection<Mod349View> SectionAmendmentPurchase { get; set; } 
        public IRPSSection<Mod349View> AmendmentsInvoices { get; set; } 
        public IRPSSection<Mod349View> DeclaredInvoices { get; set; } 
        public IRPSSection<Mod349View> AmendmentsAdvances { get; set; } 
        public IRPSSection<Mod349View> DeclaredAdvances { get; set; } 
        public IRPSSection<Mod349View> SectionAmendmentSales { get; set; } 
        public IRPSSection<Mod349View> AmendmentsInvoices1 { get; set; } 
        public IRPSSection<Mod349View> DeclaredInvoices1 { get; set; } 
        public IRPSSection<Mod349View> AmendmentsAdvances1 { get; set; } 
        public IRPSSection<Mod349View> DeclaredAdvances1 { get; set; } 
        public IRPSSection<Mod349View> SectionErrors { get; set; } 
        public Mod349 Screen { get; set; }
        public Mod349View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod349ListPurchasesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListPurchasesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListPurchasesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListPurchasesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#6099c9f9-6992-4161-b0e3-39717c0b4080 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#6099c9f9-6992-4161-b0e3-39717c0b4080 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#6099c9f9-6992-4161-b0e3-39717c0b4080 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#6099c9f9-6992-4161-b0e3-39717c0b4080 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            BaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#6099c9f9-6992-4161-b0e3-39717c0b4080 .ag-row[role='row']@ROWINDEX [col-id='cBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349View> BaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListPurchasesInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListPurchasesInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListPurchasesInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListPurchasesInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#f8378131-87b7-4b10-9d53-2aecd270cf2d .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#f8378131-87b7-4b10-9d53-2aecd270cf2d .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#f8378131-87b7-4b10-9d53-2aecd270cf2d .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349ListPurchasesAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListPurchasesAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListPurchasesAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListPurchasesAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#8591a81b-8f17-4202-b850-f64ec33e8dad .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#8591a81b-8f17-4202-b850-f64ec33e8dad .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#8591a81b-8f17-4202-b850-f64ec33e8dad .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#8591a81b-8f17-4202-b850-f64ec33e8dad .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#8591a81b-8f17-4202-b850-f64ec33e8dad .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListSalesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListSalesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListSalesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListSalesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a8a83a26-c87c-4be5-a949-87656beeb6df .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a8a83a26-c87c-4be5-a949-87656beeb6df .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a8a83a26-c87c-4be5-a949-87656beeb6df .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a8a83a26-c87c-4be5-a949-87656beeb6df .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            BaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#a8a83a26-c87c-4be5-a949-87656beeb6df .ag-row[role='row']@ROWINDEX [col-id='cBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349View> BaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListSalesInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListSalesInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListSalesInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListSalesInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0e9575a7-cffe-47d4-90bd-bcf074452bb0 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0e9575a7-cffe-47d4-90bd-bcf074452bb0 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#0e9575a7-cffe-47d4-90bd-bcf074452bb0 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349ListSalesAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListSalesAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListSalesAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListSalesAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#ac4de18a-c355-4138-ba4f-1280a5ff7306 .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#ac4de18a-c355-4138-ba4f-1280a5ff7306 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#ac4de18a-c355-4138-ba4f-1280a5ff7306 .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#ac4de18a-c355-4138-ba4f-1280a5ff7306 .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#ac4de18a-c355-4138-ba4f-1280a5ff7306 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListAmendmentPurchasesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListAmendmentPurchasesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListAmendmentPurchasesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListAmendmentPurchasesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            Exercise = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cExercise']","",false, this.CurrentView);
 
            PeriodName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cPeriodName']","",false, this.CurrentView);
 
            AmendedBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cAmendedBaseAmount']","",false, this.CurrentView);
 
            DeclaredBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#e88f1523-7026-4314-aef0-e255a5d50846 .ag-row[role='row']@ROWINDEX [col-id='cDeclaredBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349View> Exercise { get; set; } 
        public IRPSGridTextBox<Mod349View> PeriodName { get; set; } 
        public IRPSGridTextBox<Mod349View> AmendedBaseAmount { get; set; } 
        public IRPSGridTextBox<Mod349View> DeclaredBaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349PurchasesListAmendmentsInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349PurchasesListAmendmentsInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349PurchasesListAmendmentsInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349PurchasesListAmendmentsInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#52a8b94a-3b50-4626-bcfe-d1e0d7237787 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#52a8b94a-3b50-4626-bcfe-d1e0d7237787 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#52a8b94a-3b50-4626-bcfe-d1e0d7237787 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349PurchasesListDeclaredInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349PurchasesListDeclaredInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349PurchasesListDeclaredInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349PurchasesListDeclaredInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#5853d8a6-8d2b-4a59-a2bb-b8fbbae83e74 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#5853d8a6-8d2b-4a59-a2bb-b8fbbae83e74 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#5853d8a6-8d2b-4a59-a2bb-b8fbbae83e74 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349ListPurchasesAmendmentsAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListPurchasesAmendmentsAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListPurchasesAmendmentsAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListPurchasesAmendmentsAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0c257408-e01a-4f40-911f-a916530b48e6 .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0c257408-e01a-4f40-911f-a916530b48e6 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0c257408-e01a-4f40-911f-a916530b48e6 .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#0c257408-e01a-4f40-911f-a916530b48e6 .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#0c257408-e01a-4f40-911f-a916530b48e6 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListPurchasesDeclaredAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListPurchasesDeclaredAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListPurchasesDeclaredAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListPurchasesDeclaredAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a781b83c-44f7-469c-8a88-3a5ab8528299 .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a781b83c-44f7-469c-8a88-3a5ab8528299 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a781b83c-44f7-469c-8a88-3a5ab8528299 .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#a781b83c-44f7-469c-8a88-3a5ab8528299 .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#a781b83c-44f7-469c-8a88-3a5ab8528299 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListAmendmentSalesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListAmendmentSalesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListAmendmentSalesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListAmendmentSalesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key349 = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cKey349']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            Exercise = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cExercise']","",false, this.CurrentView);
 
            PeriodName = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cPeriodName']","",false, this.CurrentView);
 
            AmendedBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cAmendedBaseAmount']","",false, this.CurrentView);
 
            DeclaredBaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#983c80e2-3a26-4817-9675-2bd4abc0a07c .ag-row[role='row']@ROWINDEX [col-id='cDeclaredBaseAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> Key349 { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod349View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod349View> Exercise { get; set; } 
        public IRPSGridTextBox<Mod349View> PeriodName { get; set; } 
        public IRPSGridTextBox<Mod349View> AmendedBaseAmount { get; set; } 
        public IRPSGridTextBox<Mod349View> DeclaredBaseAmount { get; set; } 
                     
    }
 
        public partial class GetMod349SalesListAmendmentsInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349SalesListAmendmentsInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349SalesListAmendmentsInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349SalesListAmendmentsInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#3cd30ac9-309b-4cdc-88c4-137493c9d907 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#3cd30ac9-309b-4cdc-88c4-137493c9d907 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#3cd30ac9-309b-4cdc-88c4-137493c9d907 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349SalesListDeclaredInvoicesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349SalesListDeclaredInvoicesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349SalesListDeclaredInvoicesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349SalesListDeclaredInvoicesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#d48a4216-a2af-48f6-b2d0-d556f2224e40 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#d48a4216-a2af-48f6-b2d0-d556f2224e40 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#d48a4216-a2af-48f6-b2d0-d556f2224e40 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> InvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> VATBase { get; set; } 
                     
    }
 
        public partial class GetMod349ListSalesAmendmentsAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListSalesAmendmentsAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListSalesAmendmentsAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListSalesAmendmentsAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#434cefef-575a-44e6-93c2-9097da28342e .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#434cefef-575a-44e6-93c2-9097da28342e .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#434cefef-575a-44e6-93c2-9097da28342e .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#434cefef-575a-44e6-93c2-9097da28342e .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#434cefef-575a-44e6-93c2-9097da28342e .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
        public partial class GetMod349ListSalesDeclaredAdvancesCollectionEditor<Mod349View>:RPSCollectionEditor<Mod349View> where Mod349View : class, IView
    {
        public  GetMod349ListSalesDeclaredAdvancesGridView<Mod349View> GridView {get;set;}
    }
    public partial class GetMod349ListSalesDeclaredAdvancesGridView <Mod349View> :  RPSGridView<Mod349View> where Mod349View : class, IView
    {
        public GetMod349ListSalesDeclaredAdvancesGridView(Mod349View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAdvanceInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#32b5488c-8ddd-4460-a7dd-55be83b981c4 .ag-row[role='row']@ROWINDEX [col-id='cCodAdvanceInvoice']","",false, this.CurrentView);
 
            AdvanceInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#32b5488c-8ddd-4460-a7dd-55be83b981c4 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceInvoiceDate']","",false, this.CurrentView);
 
            CodFinalInvoice = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#32b5488c-8ddd-4460-a7dd-55be83b981c4 .ag-row[role='row']@ROWINDEX [col-id='cCodFinalInvoice']","",false, this.CurrentView);
 
            FinalInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<Mod349View>("","#32b5488c-8ddd-4460-a7dd-55be83b981c4 .ag-row[role='row']@ROWINDEX [col-id='cFinalInvoiceDate']","",false, this.CurrentView);
 
            AdvanceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod349View>("","#32b5488c-8ddd-4460-a7dd-55be83b981c4 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod349View> CodAdvanceInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> CodFinalInvoice { get; set; } 
        public IRPSGridTextBox<Mod349View> FinalInvoiceDate { get; set; } 
        public IRPSGridTextBox<Mod349View> AdvanceAmount { get; set; } 
                     
    }
 
    }
  
    

}