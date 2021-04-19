    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.OportunitySL
{
    //RPS VERSION 1.0.0.0
    public partial class OportunitySL:Screen
    {
        public OportunitySL():base()
        {
            this.URL = "salescrm.oportunitysl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OportunitySLQueryView  = new OportunitySLQueryView(this); 
            OportunitySLEntityView  = new OportunitySLEntityView(this); 
            OportunityEmployExpensesSLView  = new OportunityEmployExpensesSLView(this); 
            OportunityCompetencySLView  = new OportunityCompetencySLView(this); 
            OportunityExpensesSLView  = new OportunityExpensesSLView(this); 
            ChangeCustomerChildDialogView  = new ChangeCustomerChildDialogView(this); 
            OportunityGenericChildDialogView  = new OportunityGenericChildDialogView(this); 
            OportunitySLQueryView.InitializeControls(); 
            OportunitySLEntityView.InitializeControls(); 
            OportunityEmployExpensesSLView.InitializeControls(); 
            OportunityCompetencySLView.InitializeControls(); 
            OportunityExpensesSLView.InitializeControls(); 
            ChangeCustomerChildDialogView.InitializeControls(); 
            OportunityGenericChildDialogView.InitializeControls(); 
           
        }
      
            public OportunitySLQueryView OportunitySLQueryView {get; set; } 
            public OportunitySLEntityView OportunitySLEntityView {get; set; } 
            public OportunityEmployExpensesSLView OportunityEmployExpensesSLView {get; set; } 
            public OportunityCompetencySLView OportunityCompetencySLView {get; set; } 
            public OportunityExpensesSLView OportunityExpensesSLView {get; set; } 
            public ChangeCustomerChildDialogView ChangeCustomerChildDialogView {get; set; } 
            public OportunityGenericChildDialogView OportunityGenericChildDialogView {get; set; } 
    }
            
    public partial class OportunitySLQueryView : View
    {
        public OportunitySLQueryView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OportunitySLQueryView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "02502553-ed75-4645-a0f5-e48d9dd0ca40",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OportunitySLQueryView,OportunitySLEntityView>( params_MainConsult,this,Screen.OportunitySLEntityView);
 

        }
        public IRPSButton<OportunitySLQueryView,OportunitySLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OportunitySLQueryView,OportunitySLEntityView> MainConsult { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunitySLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OportunitySLEntityView : View
    {
        public OportunitySLEntityView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OportunitySLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OportunitySLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OportunitySLEntityView,OportunitySLQueryView>( this,Screen.OportunitySLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<OportunitySLEntityView,OportunitySLQueryView>( this,Screen.OportunitySLQueryView);
 
            CodOportunity = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("a5e8aecd-dd26-42ac-a37a-86780685d343","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("6a9ae7d9-63ae-4ac5-bff0-1b659da920b3","","",false, this);
 
            OportunityDate = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("844c15af-b1c5-4ce9-b0cd-a9f3879a5dd8","","",true, this);
 
            Customer = RPSControlFactory.CreateRPSOption<OportunitySLEntityView>( "890543ea-699c-4fc9-8bea-d4819ef5ffc9","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<OportunitySLEntityView>( "d6acee66-da8f-456a-93b4-6354d6e28076","","",this);
 
            Generic = RPSControlFactory.CreateRPSCheckBox<OportunitySLEntityView>("9aec46e7-a30c-43d5-9ed1-a6f23c5a49b6","","",true, this);
 
            IDOportunityGeneric = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("a9d9459c-ed70-41c8-89bf-18394e022fb3","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("1c4aff1a-64d2-4f6a-9b43-d4451d278125","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("b1a51a08-3cb9-4cfa-97dd-cfe74d97571f","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("46759258-c552-4f04-a9e1-edfcc39dec14","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("5eb1cad7-84dd-4167-b579-0224e2e0d264","","",false, this);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("8ea32805-3595-4a07-bf3c-0f922135e93b","","",false, this);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("d3f3c8b5-df21-4b7c-b003-a1107dec7791","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("a2f19f39-b10e-4e38-a5f6-ca3484532853","","",false, this);
 
            IDLeadSource = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("0080fda0-0a96-420a-a1b4-4739456179f8","","",true, this);
 
            IDSalesMethod = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("40299144-6af8-4ddd-8bff-c1799812b7fb","","",true, this);
 
            IDCuDistProductType = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("dda14163-7403-4b10-8ceb-14bba1b89998","","",false, this);
 
            Probability = RPSControlFactory.CreateRPSFormattedTextBox<OportunitySLEntityView>("d59ba4df-aee4-4b12-91fe-39dd6927edb7","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OportunitySLEntityView>("c7d73562-c453-4635-bd95-e06bf708d831","","",true, this);
 
            EstimatedCloseDate = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("b6d74438-ced1-4a7c-9be1-85d13cb7fc74","","",true, this);
 
            IDSalesMethodPhase = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("66c1ede5-62e7-4ba3-9830-5fc33c4e60b4","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<OportunitySLEntityView>("3350ae22-0c5e-4b25-93d8-b3baa7be7e18","","",true, this);
 
            IDCloseReason = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("dc3c0d3d-e67d-4d8b-87ea-e2d27da6e58f","","",false, this);
 
            CloseDate = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("3187f05d-100f-4b35-a011-2a143b63e80c","","",false, this);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("fa151803-7efb-4f8d-ae19-6b0c864dd6a4","","",false, this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("13fb418a-789b-4d60-8c0d-08f60d8fa7fd","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OportunitySLEntityView>("6195fc3b-0a32-4727-93fb-2f5827743d5e","","",false, this);
 
            IDCPQModel = RPSControlFactory.CreateRPSComboBox<OportunitySLEntityView>("256ce78b-650c-4380-869d-067a482474b4","","",false, this);
 
            NewCPQProduct = RPSControlFactory.CreateRPSButton<OportunitySLEntityView>( "1bcf744f-91fa-41be-ab41-65f2b62ff31a","","",this);
 
            NewSalesQuoteFromOpportunityButton = RPSControlFactory.CreateRPSButton<OportunitySLEntityView>( "3423f76c-be9f-451e-9c96-6475bcc5a448","","",this);
 
            NewQuotationFromOpportunityButton = RPSControlFactory.CreateRPSButton<OportunitySLEntityView>( "5416d7b5-ff31-4a8d-baa0-1b17e420c62c","","",this);
 
            OportunityGenericChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OportunitySLEntityView,OportunityGenericChildDialogView>("96ab6fbd-8dc4-4443-a335-75e208f0443a","","", this,Screen.OportunityGenericChildDialogView);
 
            ChangeCustomerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OportunitySLEntityView,ChangeCustomerChildDialogView>("7d89208f-facd-4cff-9262-20a3f0becef7","","", this,Screen.ChangeCustomerChildDialogView);
 
            NewActivityButton = RPSControlFactory.CreateRPSButton<OportunitySLEntityView>( "bb9b1f0a-cd56-4834-abab-6a394885feb7","","",this);
 
            CollectionInit params_OportunityCompetencySLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fc799dec-ed39-49e9-98e8-b658490365f4",CSSSelectorGrid="",XPathGrid=""};
            OportunityCompetencySLs = RPSControlFactory.RPSCreateCollectionWithGrid<OportunityCompetencySLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunityCompetencySLs,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunityExpensesSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49f32ca1-47a8-4c4a-8171-f250d67d6c03",CSSSelectorGrid="",XPathGrid=""};
            OportunityExpensesSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OportunityExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunityExpensesSLs,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunityEmployeeExpensesSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="893d5c37-9590-499a-9866-a4e9317191fe",CSSSelectorGrid="",XPathGrid=""};
            OportunityEmployeeExpensesSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OportunityEmployeeExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunityEmployeeExpensesSLs,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunitySLActivitiesPending = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4585af40-10d3-4268-9e4b-166162879224",CSSSelectorGrid="",XPathGrid=""};
            OportunitySLActivitiesPending = RPSControlFactory.RPSCreateCollectionWithGrid<OportunitySLActivitiesPendingCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunitySLActivitiesPending,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunitySLActivitiesCompleted = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="92793923-6f42-4a10-9ceb-dae14cc615aa",CSSSelectorGrid="",XPathGrid=""};
            OportunitySLActivitiesCompleted = RPSControlFactory.RPSCreateCollectionWithGrid<OportunitySLActivitiesCompletedCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunitySLActivitiesCompleted,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunitySLActivitiesCanceled = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ceb58b7-eb29-4a5b-8b97-f603e399e8c6",CSSSelectorGrid="",XPathGrid=""};
            OportunitySLActivitiesCanceled = RPSControlFactory.RPSCreateCollectionWithGrid<OportunitySLActivitiesCanceledCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunitySLActivitiesCanceled,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_SalesQuoteAssociatedOportunity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e9517a95-57bf-44ba-869c-77ee3405cdde",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteAssociatedOportunity = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteAssociatedOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_SalesQuoteAssociatedOportunity,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_OportunityAssociatedGeneric = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="539dc124-d4bb-49ff-aa9e-8ded7a4b6001",CSSSelectorGrid="",XPathGrid=""};
            OportunityAssociatedGeneric = RPSControlFactory.RPSCreateCollectionWithGrid<OportunityAssociatedGenericCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_OportunityAssociatedGeneric,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_QuotationsAssociatedWithOportunity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="989e0fc6-54b0-4652-a96a-e69aa0ee23c2",CSSSelectorGrid="",XPathGrid=""};
            QuotationsAssociatedWithOportunity = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationsAssociatedWithOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_QuotationsAssociatedWithOportunity,this,Screen.OportunityCompetencySLView);
 
            CollectionInit params_CPQProduct = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf298aa5-ca82-4f2a-b68c-92830a8ab423",CSSSelectorGrid="",XPathGrid=""};
            CPQProduct = RPSControlFactory.RPSCreateCollectionWithGrid<CPQProductCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>,OportunitySLEntityView,OportunityCompetencySLView>( params_CPQProduct,this,Screen.OportunityCompetencySLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='0d55f94c-4150-48f9-be1a-f29f979d8bc9']","",this);
 
            Competitors = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='feccf534-229f-40de-b2dc-19f9fc207508']","",this);
 
            GeneralExpenses = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='737d5814-8966-4137-a383-dac2740d684a']","",this);
 
            EmployeeExpenses = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='b181e9f0-c68e-4aec-a9c5-ce732ba01c76']","",this);
 
            PendingActivities = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='66403012-3401-494b-a50b-04b7baecd956']","",this);
 
            CompletedActivities = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='4ba43db8-9008-49ae-8b50-fbee8ac264df']","",this);
 
            CanceledActivities = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='0e434fe7-efdd-47bb-bf26-976831e2671b']","",this);
 
            SalesQuotesAssociated = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='c44b51b2-b9d1-4c96-b7dc-72c5cbf369cd']","",this);
 
            OportunityAssociated = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='121d03a1-9d69-4936-a379-cfb474757d59']","",this);
 
            QuotationAssociated = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='01c4ed5e-06fe-4d16-b1b9-869af48b7f92']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='b5e1ac90-d41f-4d66-9e0d-b4a47c5b5f37']","",this);
 
            Configurator = RPSControlFactory.CreateRPSSection<OportunitySLEntityView>( "","ul li[rpsid='381307cb-b86f-468a-a7fe-801441824ecc']","",this);
 

        }
        public IRPSSaveButton<OportunitySLEntityView> SaveButton { get; set; } 
        public IRPSButton<OportunitySLEntityView> DeleteButton { get; set; } 
        public IRPSButton<OportunitySLEntityView,OportunitySLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OportunitySLEntityView,OportunitySLQueryView> BackButton { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> CodOportunity { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> Description { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> OportunityDate { get; set; } 
        public IRPSOption<OportunitySLEntityView> Customer { get; set; } 
        public IRPSOption<OportunitySLEntityView> PotentialCustomer { get; set; } 
        public IRPSCheckbox<OportunitySLEntityView> Generic { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDOportunityGeneric { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDPotentialCustomerContact { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDLeadSource { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDSalesMethod { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCuDistProductType { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> Probability { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> Amount { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> EstimatedCloseDate { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDSalesMethodPhase { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> Status { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCloseReason { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> CloseDate { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDOrder { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDFrameworkContract { get; set; } 
        public IRPSTextBox<OportunitySLEntityView> Comment { get; set; } 
        public IRPSComboBox<OportunitySLEntityView> IDCPQModel { get; set; } 
        public IRPSButton<OportunitySLEntityView> NewCPQProduct { get; set; } 
        public IRPSButton<OportunitySLEntityView> NewSalesQuoteFromOpportunityButton { get; set; } 
        public IRPSButton<OportunitySLEntityView> NewQuotationFromOpportunityButton { get; set; } 
        public IRPSButton<OportunitySLEntityView,OportunityGenericChildDialogView> OportunityGenericChildNavigationCommandButton { get; set; } 
        public IRPSButton<OportunitySLEntityView,ChangeCustomerChildDialogView> ChangeCustomerChildNavigationCommandButton { get; set; } 
        public IRPSButton<OportunitySLEntityView> NewActivityButton { get; set; } 
        public OportunityCompetencySLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunityCompetencySLs { get; set; } 
        public OportunityExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunityExpensesSLs { get; set; } 
        public OportunityEmployeeExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunityEmployeeExpensesSLs { get; set; } 
        public OportunitySLActivitiesPendingCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunitySLActivitiesPending { get; set; } 
        public OportunitySLActivitiesCompletedCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunitySLActivitiesCompleted { get; set; } 
        public OportunitySLActivitiesCanceledCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunitySLActivitiesCanceled { get; set; } 
        public SalesQuoteAssociatedOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> SalesQuoteAssociatedOportunity { get; set; } 
        public OportunityAssociatedGenericCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> OportunityAssociatedGeneric { get; set; } 
        public QuotationsAssociatedWithOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> QuotationsAssociatedWithOportunity { get; set; } 
        public CPQProductCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> CPQProduct { get; set; } 
        public IRPSSection<OportunitySLEntityView> GeneralData { get; set; } 
        public IRPSSection<OportunitySLEntityView> Competitors { get; set; } 
        public IRPSSection<OportunitySLEntityView> GeneralExpenses { get; set; } 
        public IRPSSection<OportunitySLEntityView> EmployeeExpenses { get; set; } 
        public IRPSSection<OportunitySLEntityView> PendingActivities { get; set; } 
        public IRPSSection<OportunitySLEntityView> CompletedActivities { get; set; } 
        public IRPSSection<OportunitySLEntityView> CanceledActivities { get; set; } 
        public IRPSSection<OportunitySLEntityView> SalesQuotesAssociated { get; set; } 
        public IRPSSection<OportunitySLEntityView> OportunityAssociated { get; set; } 
        public IRPSSection<OportunitySLEntityView> QuotationAssociated { get; set; } 
        public IRPSSection<OportunitySLEntityView> Comment1 { get; set; } 
        public IRPSSection<OportunitySLEntityView> Configurator { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunitySLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OportunityCompetencySLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunityCompetencySLsGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunityCompetencySLsGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunityCompetencySLsGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCompetency = RPSControlFactory.CreateRPSGridComboBox<OportunitySLEntityView>("","#fc799dec-ed39-49e9-98e8-b658490365f4 .ag-row[role='row']@ROWINDEX [col-id='cIDCompetency']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#fc799dec-ed39-49e9-98e8-b658490365f4 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Probability = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#fc799dec-ed39-49e9-98e8-b658490365f4 .ag-row[role='row']@ROWINDEX [col-id='cProbability']","",true, this.CurrentView);
 
            Win = RPSControlFactory.CreateRPSGridCheckBox<OportunitySLEntityView>("","#fc799dec-ed39-49e9-98e8-b658490365f4 .ag-row[role='row']@ROWINDEX [col-id='cWin']","",true, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<OportunitySLEntityView>("","#fc799dec-ed39-49e9-98e8-b658490365f4 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OportunitySLEntityView> IDCompetency { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Probability { get; set; } 
        public IRPSGridCheckbox<OportunitySLEntityView> Win { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Comment { get; set; } 
                     
    }
 
        public partial class OportunityExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunityExpensesSLsGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunityExpensesSLsGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunityExpensesSLsGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDActivity = RPSControlFactory.CreateRPSGridComboBox<OportunitySLEntityView>("","#49f32ca1-47a8-4c4a-8171-f250d67d6c03 .ag-row[role='row']@ROWINDEX [col-id='cIDActivity']","",false, this.CurrentView);
 
            Concept = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#49f32ca1-47a8-4c4a-8171-f250d67d6c03 .ag-row[role='row']@ROWINDEX [col-id='cConcept']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#49f32ca1-47a8-4c4a-8171-f250d67d6c03 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#49f32ca1-47a8-4c4a-8171-f250d67d6c03 .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<OportunitySLEntityView>("","#49f32ca1-47a8-4c4a-8171-f250d67d6c03 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OportunitySLEntityView> IDActivity { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Concept { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Date { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Cost { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Comment { get; set; } 
                     
    }
 
        public partial class OportunityEmployeeExpensesSLsCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunityEmployeeExpensesSLsGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunityEmployeeExpensesSLsGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunityEmployeeExpensesSLsGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            IDActivity = RPSControlFactory.CreateRPSGridComboBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cIDActivity']","",false, this.CurrentView);
 
            Destination = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cDestination']","",true, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",true, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",true, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#893d5c37-9590-499a-9866-a4e9317191fe .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OportunitySLEntityView> IDEmployee { get; set; } 
        public IRPSGridComboBox<OportunitySLEntityView> IDActivity { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Destination { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> StartDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> EndDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Total { get; set; } 
                     
    }
 
        public partial class OportunitySLActivitiesPendingCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunitySLActivitiesPendingGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunitySLActivitiesPendingGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunitySLActivitiesPendingGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Assigned = RPSControlFactory.CreateRPSGridCheckBox<OportunitySLEntityView>("","#4585af40-10d3-4268-9e4b-166162879224 .ag-row[role='row']@ROWINDEX [col-id='cAssigned']","",false, this.CurrentView);
 
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#4585af40-10d3-4268-9e4b-166162879224 .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#4585af40-10d3-4268-9e4b-166162879224 .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#4585af40-10d3-4268-9e4b-166162879224 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<OportunitySLEntityView> Assigned { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> CreationDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> DueDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Priority { get; set; } 
                     
    }
 
        public partial class OportunitySLActivitiesCompletedCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunitySLActivitiesCompletedGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunitySLActivitiesCompletedGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunitySLActivitiesCompletedGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#92793923-6f42-4a10-9ceb-dae14cc615aa .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#92793923-6f42-4a10-9ceb-dae14cc615aa .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#92793923-6f42-4a10-9ceb-dae14cc615aa .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> CreationDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> DueDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Priority { get; set; } 
                     
    }
 
        public partial class OportunitySLActivitiesCanceledCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunitySLActivitiesCanceledGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunitySLActivitiesCanceledGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunitySLActivitiesCanceledGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#3ceb58b7-eb29-4a5b-8b97-f603e399e8c6 .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#3ceb58b7-eb29-4a5b-8b97-f603e399e8c6 .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#3ceb58b7-eb29-4a5b-8b97-f603e399e8c6 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> CreationDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> DueDate { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> Priority { get; set; } 
                     
    }
 
        public partial class SalesQuoteAssociatedOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  SalesQuoteAssociatedOportunityGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class SalesQuoteAssociatedOportunityGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public SalesQuoteAssociatedOportunityGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderStatus = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#e9517a95-57bf-44ba-869c-77ee3405cdde .ag-row[role='row']@ROWINDEX [col-id='cOrderStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> OrderStatus { get; set; } 
                     
    }
 
        public partial class OportunityAssociatedGenericCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  OportunityAssociatedGenericGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class OportunityAssociatedGenericGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public OportunityAssociatedGenericGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OportunitySL_Status = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#539dc124-d4bb-49ff-aa9e-8ded7a4b6001 .ag-row[role='row']@ROWINDEX [col-id='cOportunitySL_Status']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> OportunitySL_Status { get; set; } 
                     
    }
 
        public partial class QuotationsAssociatedWithOportunityCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  QuotationsAssociatedWithOportunityGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class QuotationsAssociatedWithOportunityGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public QuotationsAssociatedWithOportunityGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CostQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#989e0fc6-54b0-4652-a96a-e69aa0ee23c2 .ag-row[role='row']@ROWINDEX [col-id='cCostQuantity']","",false, this.CurrentView);
 
            SalesPriceQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OportunitySLEntityView>("","#989e0fc6-54b0-4652-a96a-e69aa0ee23c2 .ag-row[role='row']@ROWINDEX [col-id='cSalesPriceQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> CostQuantity { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> SalesPriceQuantity { get; set; } 
                     
    }
 
        public partial class CPQProductCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView>:RPSCollectionEditor<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public  CPQProductGridView<OportunitySLEntityView,OportunityCompetencySLView> GridView {get;set;}
    }
    public partial class CPQProductGridView <OportunitySLEntityView,OportunityCompetencySLView> :  RPSGridView<OportunitySLEntityView,OportunityCompetencySLView> where OportunitySLEntityView : class, IView where OportunityCompetencySLView : class, IView
    {
        public CPQProductGridView(OportunitySLEntityView currentView,OportunityCompetencySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<OportunitySLEntityView>("","#bf298aa5-ca82-4f2a-b68c-92830a8ab423 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            CPQProduct_DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<OportunitySLEntityView>("","#bf298aa5-ca82-4f2a-b68c-92830a8ab423 .ag-row[role='row']@ROWINDEX [col-id='cCPQProduct_DescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OportunitySLEntityView> Date { get; set; } 
        public IRPSGridTextBox<OportunitySLEntityView> CPQProduct_DescriptionExtended { get; set; } 
                     
    }
 
    }
  
            
    public partial class OportunityEmployExpensesSLView : View
    {
        public OportunityEmployExpensesSLView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OportunityEmployExpensesSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OportunityEmployExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OportunityEmployExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OportunityEmployExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OportunityEmployExpensesSLView>("d17ea131-1af7-48bd-b238-2915d8625145","","",true, this);
 
            Destination = RPSControlFactory.CreateRPSTextBox<OportunityEmployExpensesSLView>("d91a4877-8039-4b0d-8274-a16afc2c5214","","",true, this);
 
            IDActivity = RPSControlFactory.CreateRPSComboBox<OportunityEmployExpensesSLView>("628934d7-a7ab-425f-9021-df1cea8fd47c","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<OportunityEmployExpensesSLView>("686d176b-8507-464a-8f3d-10dfe28a0264","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<OportunityEmployExpensesSLView>("a4578e4d-85ec-449a-9c0d-b1db16ff98d3","","",true, this);
 
            DietAmount = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("07048c6f-2a5c-4738-be14-923387eab8e5","","",true, this);
 
            Hotels = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("359f5d44-9b23-4cca-9743-122c088e3ba5","","",true, this);
 
            Meals = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("d7ef0d51-e5ad-4289-9abf-4e9688233097","","",true, this);
 
            Kilometers = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("5d104526-f1d9-4aca-85c5-ea04f4f40aee","","",true, this);
 
            KmPrice = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("424702ce-45e7-4743-bee4-7cec5b1d34dc","","",true, this);
 
            KmAmount = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("b1b8595c-a778-430c-9744-02cab23475f0","","",true, this);
 
            Tolls = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("98e8c1b3-7feb-48d0-9ff9-d743019352a2","","",true, this);
 
            Transports = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("e17ed14e-1c3a-410d-a387-79f7e32fc504","","",true, this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<OportunityEmployExpensesSLView>("b4a3c208-f842-485d-8ca7-6a96fc60d302","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OportunityEmployExpensesSLView>("d75facd7-ae93-417a-8a85-ffba97d4c498","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OportunityEmployExpensesSLView>( "","ul li[rpsid='09196eca-9782-429f-908d-679a155195ca']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<OportunityEmployExpensesSLView>( "","ul li[rpsid='da93a76c-1243-4047-aa00-f6ef76dfbe54']","",this);
 

        }
        public IRPSButton<OportunityEmployExpensesSLView> DeleteButton { get; set; } 
        public IRPSButton<OportunityEmployExpensesSLView,OportunitySLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OportunityEmployExpensesSLView,OportunitySLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OportunityEmployExpensesSLView,OportunitySLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<OportunityEmployExpensesSLView> IDEmployee { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Destination { get; set; } 
        public IRPSComboBox<OportunityEmployExpensesSLView> IDActivity { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> StartDate { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> EndDate { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> DietAmount { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Hotels { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Meals { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Kilometers { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> KmPrice { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> KmAmount { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Tolls { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Transports { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Total { get; set; } 
        public IRPSTextBox<OportunityEmployExpensesSLView> Comment { get; set; } 
        public IRPSSection<OportunityEmployExpensesSLView> GeneralDataSection { get; set; } 
        public IRPSSection<OportunityEmployExpensesSLView> CommentSection { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunityEmployExpensesSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OportunityCompetencySLView : View
    {
        public OportunityCompetencySLView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OportunityCompetencySLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OportunityCompetencySLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OportunityCompetencySLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OportunityCompetencySLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            IDCompetency = RPSControlFactory.CreateRPSComboBox<OportunityCompetencySLView>("e7ff01fb-515a-439f-ae53-703a9ef67627","","",true, this);
 
            Probability = RPSControlFactory.CreateRPSFormattedTextBox<OportunityCompetencySLView>("6e02b1c4-4476-4da0-8029-fbdad4ef9008","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OportunityCompetencySLView>("b4dfabc0-6933-462e-81f1-3a8459063a3d","","",true, this);
 
            Win = RPSControlFactory.CreateRPSCheckBox<OportunityCompetencySLView>("3af06992-fb6d-47a8-99db-f2e04233c25c","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OportunityCompetencySLView>("51054a35-80df-4907-9a79-5026c6df1fca","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OportunityCompetencySLView>( "","ul li[rpsid='e0911b16-fe1f-4179-aa96-d6f5fccc3b3d']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<OportunityCompetencySLView>( "","ul li[rpsid='8d9d9754-5f80-4f9a-9b99-567732bf758e']","",this);
 

        }
        public IRPSButton<OportunityCompetencySLView> DeleteButton { get; set; } 
        public IRPSButton<OportunityCompetencySLView,OportunitySLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OportunityCompetencySLView,OportunitySLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OportunityCompetencySLView,OportunitySLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<OportunityCompetencySLView> IDCompetency { get; set; } 
        public IRPSTextBox<OportunityCompetencySLView> Probability { get; set; } 
        public IRPSTextBox<OportunityCompetencySLView> Amount { get; set; } 
        public IRPSCheckbox<OportunityCompetencySLView> Win { get; set; } 
        public IRPSTextBox<OportunityCompetencySLView> Comment { get; set; } 
        public IRPSSection<OportunityCompetencySLView> GeneralDataSection { get; set; } 
        public IRPSSection<OportunityCompetencySLView> CommentSection { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunityCompetencySLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OportunityExpensesSLView : View
    {
        public OportunityExpensesSLView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OportunityExpensesSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OportunityExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OportunityExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OportunityExpensesSLView,OportunitySLEntityView>( this,Screen.OportunitySLEntityView);
 
            Concept = RPSControlFactory.CreateRPSTextBox<OportunityExpensesSLView>("5aa8f5e6-98e8-4730-ba84-49c1206fb923","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OportunityExpensesSLView>("f5dc6103-ef9f-4c88-afa8-4e04ee149c76","","",true, this);
 
            IDActivity = RPSControlFactory.CreateRPSComboBox<OportunityExpensesSLView>("71a52221-c276-4002-9e71-64478f237b90","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<OportunityExpensesSLView>("9c2e3458-9837-4c6c-a56e-32420bb40556","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OportunityExpensesSLView>("406c5d20-371f-4356-8666-f81b759c5bc7","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OportunityExpensesSLView>( "","ul li[rpsid='335ca09f-a48f-4dc1-b5cd-b2b8729d5b89']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<OportunityExpensesSLView>( "","ul li[rpsid='1c73201b-3e8f-4b08-931a-e614cf15ea64']","",this);
 

        }
        public IRPSButton<OportunityExpensesSLView> DeleteButton { get; set; } 
        public IRPSButton<OportunityExpensesSLView,OportunitySLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OportunityExpensesSLView,OportunitySLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OportunityExpensesSLView,OportunitySLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<OportunityExpensesSLView> Concept { get; set; } 
        public IRPSTextBox<OportunityExpensesSLView> Date { get; set; } 
        public IRPSComboBox<OportunityExpensesSLView> IDActivity { get; set; } 
        public IRPSTextBox<OportunityExpensesSLView> Cost { get; set; } 
        public IRPSTextBox<OportunityExpensesSLView> Comment { get; set; } 
        public IRPSSection<OportunityExpensesSLView> GeneralDataSection { get; set; } 
        public IRPSSection<OportunityExpensesSLView> CommentSection { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunityExpensesSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeCustomerChildDialogView : View
    {
        public ChangeCustomerChildDialogView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("58911801-4592-40b9-b0b5-d24ae360b3f8","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("2798c44b-a4f2-4b43-8b21-668f58d44da8","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("d6b699de-900d-4d64-b660-30fd8708e57f","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("55321314-33e6-4cc5-8ff9-8af3fba8fc8e","","",false, this);
 
            NewCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("7632ac52-285d-45e8-8150-1d0bd0dc506c","","",false, this);
 
            NewPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("4a8025f9-a2a4-45d0-a040-3abe3ecd8183","","",false, this);
 
            IDNewCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("6f4d13a9-02ae-40ac-90c9-7a1ab7e5e0b7","","",false, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("806992e2-d9de-489e-b299-981e5d279f2e","","",false, this);
 
            NewPotentialVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("9644b112-8b0e-4f94-8965-bf3205f03fec","","",false, this);
 

        }
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDPotentialCustomer { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewPotentialCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDNewCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewVATNumber { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewPotentialVATNumber { get; set; } 
        public OportunitySL Screen { get; set; }
        public ChangeCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OportunityGenericChildDialogView : View
    {
        public OportunityGenericChildDialogView(OportunitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCode = RPSControlFactory.CreateRPSTextBox<OportunityGenericChildDialogView>("2563f741-b03a-4d3a-b23b-725cbeeada37","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<OportunityGenericChildDialogView>( "ff5576ae-633a-463e-a2e1-28e5fdbbb94f","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<OportunityGenericChildDialogView>( "d7282a0a-1076-463b-a1db-6e742a4ed301","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OportunityGenericChildDialogView>("a023ea2a-07c2-4b09-9922-1036ae0d0a3f","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<OportunityGenericChildDialogView>("de9a784c-de65-40c3-8137-5d87a93d9461","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<OportunityGenericChildDialogView>("15663700-c911-4259-80ef-366f13372d60","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OportunityGenericChildDialogView>("e7d3f070-b68a-42b1-ae17-c65c62be5a32","","",false, this);
 
            Documents = RPSControlFactory.CreateRPSCheckBox<OportunityGenericChildDialogView>("c6dd0e32-709d-452b-923d-64e3e7c19bf7","","",false, this);
 
            Competitors = RPSControlFactory.CreateRPSCheckBox<OportunityGenericChildDialogView>("10da0050-ed1d-4f55-91bc-f9c279c8fec7","","",false, this);
 

        }
        public IRPSTextBox<OportunityGenericChildDialogView> NewCode { get; set; } 
        public IRPSOption<OportunityGenericChildDialogView> Customer { get; set; } 
        public IRPSOption<OportunityGenericChildDialogView> PotentialCustomer { get; set; } 
        public IRPSComboBox<OportunityGenericChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<OportunityGenericChildDialogView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<OportunityGenericChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<OportunityGenericChildDialogView> Date { get; set; } 
        public IRPSCheckbox<OportunityGenericChildDialogView> Documents { get; set; } 
        public IRPSCheckbox<OportunityGenericChildDialogView> Competitors { get; set; } 
        public OportunitySL Screen { get; set; }
        public OportunityGenericChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}