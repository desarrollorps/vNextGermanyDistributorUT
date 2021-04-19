    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.NonConformity
{
    //RPS VERSION 1.0.0.0
    public partial class NonConformity:Screen
    {
        public NonConformity():base()
        {
            this.URL = "quality.nonconformity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            NonConformityCollectionView  = new NonConformityCollectionView(this); 
            NonConformityEntityView  = new NonConformityEntityView(this); 
            NCDefectView  = new NCDefectView(this); 
            NCCauseView  = new NCCauseView(this); 
            NCCauseActionView  = new NCCauseActionView(this); 
            NCActionView  = new NCActionView(this); 
            NCLaborCostView  = new NCLaborCostView(this); 
            NCExternalCostView  = new NCExternalCostView(this); 
            NCCoreTeamView  = new NCCoreTeamView(this); 
            NCQuantityAffectedView  = new NCQuantityAffectedView(this); 
            NCCauseByLangView  = new NCCauseByLangView(this); 
            NCDefectByLangView  = new NCDefectByLangView(this); 
            NonConformityByLangView  = new NonConformityByLangView(this); 
            NCActionByLangView  = new NCActionByLangView(this); 
            NCFromControlSheetDialogView  = new NCFromControlSheetDialogView(this); 
            PrintWindowDialogView  = new PrintWindowDialogView(this); 
            NCCauseActionByLangView  = new NCCauseActionByLangView(this); 
            NonConformityCollectionView.InitializeControls(); 
            NonConformityEntityView.InitializeControls(); 
            NCDefectView.InitializeControls(); 
            NCCauseView.InitializeControls(); 
            NCCauseActionView.InitializeControls(); 
            NCActionView.InitializeControls(); 
            NCLaborCostView.InitializeControls(); 
            NCExternalCostView.InitializeControls(); 
            NCCoreTeamView.InitializeControls(); 
            NCQuantityAffectedView.InitializeControls(); 
            NCCauseByLangView.InitializeControls(); 
            NCDefectByLangView.InitializeControls(); 
            NonConformityByLangView.InitializeControls(); 
            NCActionByLangView.InitializeControls(); 
            NCFromControlSheetDialogView.InitializeControls(); 
            PrintWindowDialogView.InitializeControls(); 
            NCCauseActionByLangView.InitializeControls(); 
           
        }
      
            public NonConformityCollectionView NonConformityCollectionView {get; set; } 
            public NonConformityEntityView NonConformityEntityView {get; set; } 
            public NCDefectView NCDefectView {get; set; } 
            public NCCauseView NCCauseView {get; set; } 
            public NCCauseActionView NCCauseActionView {get; set; } 
            public NCActionView NCActionView {get; set; } 
            public NCLaborCostView NCLaborCostView {get; set; } 
            public NCExternalCostView NCExternalCostView {get; set; } 
            public NCCoreTeamView NCCoreTeamView {get; set; } 
            public NCQuantityAffectedView NCQuantityAffectedView {get; set; } 
            public NCCauseByLangView NCCauseByLangView {get; set; } 
            public NCDefectByLangView NCDefectByLangView {get; set; } 
            public NonConformityByLangView NonConformityByLangView {get; set; } 
            public NCActionByLangView NCActionByLangView {get; set; } 
            public NCFromControlSheetDialogView NCFromControlSheetDialogView {get; set; } 
            public PrintWindowDialogView PrintWindowDialogView {get; set; } 
            public NCCauseActionByLangView NCCauseActionByLangView {get; set; } 
    }
            
    public partial class NonConformityCollectionView : View
    {
        public NonConformityCollectionView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<NonConformityCollectionView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            NCFromControlSheetNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<NonConformityCollectionView,NCFromControlSheetDialogView>("969f5506-9048-45be-be69-83e298e99117","","", this,Screen.NCFromControlSheetDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4f48e5cd-cdea-446f-be19-1db5918bf9b4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<NonConformityCollectionView,NonConformityEntityView>( params_MainConsult,this,Screen.NonConformityEntityView);
 

        }
        public IRPSButton<NonConformityCollectionView,NonConformityEntityView> NewButton { get; set; } 
        public IRPSButton<NonConformityCollectionView,NCFromControlSheetDialogView> NCFromControlSheetNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<NonConformityCollectionView,NonConformityEntityView> MainConsult { get; set; } 
        public NonConformity Screen { get; set; }
        public NonConformityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NonConformityEntityView : View
    {
        public NonConformityEntityView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<NonConformityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<NonConformityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NonConformityEntityView,NonConformityCollectionView>( this,Screen.NonConformityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NonConformityEntityView,NonConformityCollectionView>( this,Screen.NonConformityCollectionView);
 
            CodNonConformity = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("801046d1-b4a7-4026-b81e-3637ecfc8dca","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<NonConformityEntityView>("44880514-c2a4-461a-8677-d12d06bc0d50","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("867e96a4-d192-4317-8b27-d2da09430348","","",true, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("79687e35-55d0-479f-83bd-a220746f7ffa","","",true, this);
 
            IDNCStatus = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("6adbdfba-fa28-4645-b4d3-217d3ac93f10","","",true, this);
 
            IDNCSource = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("0cab0228-e5a1-4afd-b431-61a45a121dac","","",true, this);
 
            CodUserClosedBy = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("8918e04c-67e0-4086-aac3-e8e4357853c7","","",false, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("db5bcd72-147b-4398-a277-f62dce21a79b","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("02c4c3a6-6634-46ba-ad10-ab534db408c2","","",false, this);
 
            IDNCReason = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("2518951f-f6ae-48fc-b83d-c9db29343fa4","","",false, this);
 
            CodUserAssignedTo = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("29d1a64f-1ff2-4d76-b4aa-0da0ed96de18","","",false, this);
 
            AssignmentDate = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("31e86400-b704-42fc-a06a-ba6ea7e79a8a","","",false, this);
 
            Severity = RPSControlFactory.CreateRPSEnumComboBox<NonConformityEntityView>("e252985c-b1cb-48b8-ad7e-8ed4fdcbd6b8","","",false, this);
 
            Repetitive = RPSControlFactory.CreateRPSCheckBox<NonConformityEntityView>("06d2e880-a90b-4df6-b6b2-f19ab87acc25","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("6a270098-7cd1-4b37-9844-e77a0866467b","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("03c2bccc-d207-4545-b5ea-be848ed3714d","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("31ead29b-0f0f-41c0-a9e2-77d47b1c8aba","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("7a25cb03-2b3c-482d-8315-e70db34ad08e","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("fb9a9d1f-5bad-49e3-9e61-da2ab8bd3cbf","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("701112cf-ed5b-4218-a15a-27ebcd73a2bc","","",false, this);
 
            IDMaintenanceWarning = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("ce19749a-d4d2-4293-9813-16b84f8f9d9b","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("0e7c88d4-a7c1-4200-a6cd-7bfacff5aa4f","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("03ef2160-142d-4508-aa7f-b1f3d987dd09","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("4844e7e4-9435-4966-a41b-6f069b785b54","","",false, this);
 
            IDNonConformityOrigin = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("465df719-b0c5-479e-87e4-977ad1b97239","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("f59b59d3-3326-4753-9344-9868c376e220","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("4abe1730-3b13-4f90-808b-6b8087df9295","","",false, this);
 
            Order = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("52cb95fb-c631-47e4-abfa-8e5f6726c4cb","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("a85727e3-4f63-4d3b-9c7a-6f821e1cf00f","","",false, this);
 
            IDArticle1 = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("4d4c0d8a-0fa9-460b-b15f-4275452a9b40","","",false, this);
 
            IDNonConformityOrigin1 = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("4786e242-d5a8-4aae-b138-c91a8119729c","","",false, this);
 
            DeliveryNoteLine1 = RPSControlFactory.CreateRPSOption<NonConformityEntityView>( "dbc6544d-83eb-4480-b74f-acecda902158","","",this);
 
            DeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("40f61155-333b-4deb-ac17-92a309892cb3","","",false, this);
 
            OrderLine1 = RPSControlFactory.CreateRPSOption<NonConformityEntityView>( "2cb59ab2-c074-4bfa-b37c-1c725e6e0533","","",this);
 
            OrderLine = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("9478df90-ef39-49d6-8887-c33848ee9df8","","",false, this);
 
            SupplierContact = RPSControlFactory.CreateRPSEnumComboBox<NonConformityEntityView>("52edca03-9757-4627-af95-a4dd6611141f","","",false, this);
 
            NCDemerit = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("a5a882db-a469-4e40-935e-0d2a55159669","","",false, this);
 
            DemeritDelivery = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("a2120d33-f82a-45bc-a3bb-172e5c99e721","","",false, this);
 
            DaysForReply = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("953e288b-a82d-4c6f-9d82-560e58791c8a","","",false, this);
 
            SupplierReplyDate = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("71bb211b-5ad1-4115-8880-569e8759b7b8","","",false, this);
 
            InvoiceClaim = RPSControlFactory.CreateRPSCheckBox<NonConformityEntityView>("3de04312-7f01-4017-b038-5c0822ec5bff","","",false, this);
 
            InvoiceNumber = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("0a3eae06-fa32-4da3-8e87-f478d61d5d72","","",false, this);
 
            InvoiceAmount = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("9065756d-d6d6-4629-ab59-073dc28bfa68","","",false, this);
 
            SupplierReply = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("312f3824-c660-406e-8871-9fca7aede03e","","",false, this);
 
            DeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("2850470d-3989-4afa-bb36-7419aad1def9","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("88d27db8-5201-45c1-881c-3b441caf326f","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("43e7a152-1c0f-4c12-b659-8d44e9574985","","",false, this);
 
            IDArticle2 = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("9ab66d81-3d37-4494-811d-d728453fa053","","",false, this);
 
            IDNonConformityOrigin2 = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("35197a89-969e-4cd6-9b2d-51e935d13b96","","",false, this);
 
            DeliveryNoteLine2 = RPSControlFactory.CreateRPSOption<NonConformityEntityView>( "cc9f11ae-98ae-4094-b8d9-0e10d95bd998","","",this);
 
            DeliveryNoteLineSL = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("b41f5a09-e6c6-4174-b37a-5a2a07f1bdac","","",false, this);
 
            OrderLine2 = RPSControlFactory.CreateRPSOption<NonConformityEntityView>( "bab0e55f-1a8a-4ae8-8f6c-81f034d98734","","",this);
 
            OrderLineSL = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("725e91b3-6fbe-44be-9d7d-2ac25efb1ba1","","",false, this);
 
            CustomerContact = RPSControlFactory.CreateRPSEnumComboBox<NonConformityEntityView>("fb0ed489-803d-491c-9e33-c6a88fac6346","","",false, this);
 
            IDArticleVersion1 = RPSControlFactory.CreateRPSComboBox<NonConformityEntityView>("6e0ded88-98e2-4971-be0c-8ebd5fca5571","","",false, this);
 
            CustApprovedBy = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("1cff9e78-d39d-454c-a7b2-a712d2202acb","","",false, this);
 
            CustApprovedDate = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("ac60b6a1-ed6d-46a9-a595-36c2e4626e4f","","",false, this);
 
            CustomerResponse = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("86f01be0-01ce-4af9-a847-3a91c2b190bc","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("6a35955f-35a3-47d2-b269-7217e44ddd6b","","",false, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("25116dd1-a817-41c4-aa11-fee053484a2b","","",false, this);
 
            TotalQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("fcd16bc7-ff68-4032-8710-033e2bccea6d","","",false, this);
 
            RejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("87c0d892-3702-4715-b7a5-03f7e65a1d06","","",false, this);
 
            RejectedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("a4d58db4-a218-47d2-828e-18bceba5f190","","",false, this);
 
            TotalQuantityAmount = RPSControlFactory.CreateRPSFormattedTextBox<NonConformityEntityView>("37d45642-3316-48ea-9371-2cc9da7d2d1a","","",false, this);
 
            GreetingEquipment = RPSControlFactory.CreateRPSTextBox<NonConformityEntityView>("acdd0afb-7e2e-41f0-af13-baf368b5b046","","",false, this);
 
            PrintWindowNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<NonConformityEntityView,PrintWindowDialogView>("cd55c7a3-ce2a-4453-8f41-66c8a230becb","","", this,Screen.PrintWindowDialogView);
 
            ExecuteNewAssociatedNoConformityButton = RPSControlFactory.CreateRPSButton<NonConformityEntityView>( "e153a4f7-e14b-47b3-a18a-fc5312940c5e","","",this);
 
            CollectionInit params_NCDefects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="65d44e1e-27b0-428c-b394-d110b3b6ff09",CSSSelectorGrid="",XPathGrid=""};
            NCDefects = RPSControlFactory.RPSCreateCollectionWithGrid<NCDefectsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NCDefects,this,Screen.NCDefectView);
 
            CollectionInit params_NCQuantityAffecteds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae6cea7e-51c3-4bb8-a347-4986bdf56076",CSSSelectorGrid="",XPathGrid=""};
            NCQuantityAffecteds = RPSControlFactory.RPSCreateCollectionWithGrid<NCQuantityAffectedsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NCQuantityAffecteds,this,Screen.NCDefectView);
 
            CollectionInit params_NCLaborCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e0093a1f-70a8-4b03-a21d-9bdf432b2f10",CSSSelectorGrid="",XPathGrid=""};
            NCLaborCosts = RPSControlFactory.RPSCreateCollectionWithGrid<NCLaborCostsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NCLaborCosts,this,Screen.NCDefectView);
 
            CollectionInit params_NCExternalCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f",CSSSelectorGrid="",XPathGrid=""};
            NCExternalCosts = RPSControlFactory.RPSCreateCollectionWithGrid<NCExternalCostsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NCExternalCosts,this,Screen.NCDefectView);
 
            CollectionInit params_NCCoreTeams = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3d30ccb-e7f1-450a-92d9-a9099f81a0f2",CSSSelectorGrid="",XPathGrid=""};
            NCCoreTeams = RPSControlFactory.RPSCreateCollectionWithGrid<NCCoreTeamsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NCCoreTeams,this,Screen.NCDefectView);
 
            CollectionInit params_NonConformityByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="66ba31a4-1ed2-4779-8876-2032e4f1063a",CSSSelectorGrid="",XPathGrid=""};
            NonConformityByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NonConformityByLangsCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NonConformityByLangs,this,Screen.NCDefectView);
 
            CollectionInit params_NonConformityQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6556a19-66e2-4012-908f-f05d1954a495",CSSSelectorGrid="",XPathGrid=""};
            NonConformityQuery = RPSControlFactory.RPSCreateCollectionWithGrid<NonConformityQueryCollectionEditor<NonConformityEntityView,NCDefectView>,NonConformityEntityView,NCDefectView>( params_NonConformityQuery,this,Screen.NCDefectView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='3eb7eb16-2398-41ac-8ddd-2b28aa9a7b97']","",this);
 
            NCInformation = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='8a77a048-5d3b-446e-a45a-58dc107be4a8']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='4d7c0324-76d1-468f-bd0b-017db47273c1']","",this);
 
            IdentificationOfDefects = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='2ef00586-308d-4e93-9394-86956f7be626']","",this);
 
            QuantitiesAndCosts = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='74c7337e-1987-4000-bcb5-aa8c9cbdeec1']","",this);
 
            MonitoringTeam = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='eee98e8b-eee4-4c52-995a-be1ae9fd11bf']","",this);
 
            AssociatedNC = RPSControlFactory.CreateRPSSection<NonConformityEntityView>( "","ul li[rpsid='7344cf4c-8c25-4b19-8a6f-11d71f5dbfbf']","",this);
 

        }
        public IRPSSaveButton<NonConformityEntityView> SaveButton { get; set; } 
        public IRPSButton<NonConformityEntityView> DeleteButton { get; set; } 
        public IRPSButton<NonConformityEntityView,NonConformityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NonConformityEntityView,NonConformityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<NonConformityEntityView> CodNonConformity { get; set; } 
        public IRPSComboBox<NonConformityEntityView> Type { get; set; } 
        public IRPSComboBox<NonConformityEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<NonConformityEntityView> DoneDate { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNCStatus { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNCSource { get; set; } 
        public IRPSComboBox<NonConformityEntityView> CodUserClosedBy { get; set; } 
        public IRPSTextBox<NonConformityEntityView> ClosedDate { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDSite { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNCReason { get; set; } 
        public IRPSComboBox<NonConformityEntityView> CodUserAssignedTo { get; set; } 
        public IRPSTextBox<NonConformityEntityView> AssignmentDate { get; set; } 
        public IRPSComboBox<NonConformityEntityView> Severity { get; set; } 
        public IRPSCheckbox<NonConformityEntityView> Repetitive { get; set; } 
        public IRPSTextBox<NonConformityEntityView> Description { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<NonConformityEntityView> InternalCode { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDMOTask { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDProject { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDProTask { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDMaintenanceWarning { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDMaintenanceComponent { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDArticle { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNonConformityOrigin { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<NonConformityEntityView> DeliveryNote { get; set; } 
        public IRPSComboBox<NonConformityEntityView> Order { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDArticle1 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNonConformityOrigin1 { get; set; } 
        public IRPSOption<NonConformityEntityView> DeliveryNoteLine1 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> DeliveryNoteLine { get; set; } 
        public IRPSOption<NonConformityEntityView> OrderLine1 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> OrderLine { get; set; } 
        public IRPSComboBox<NonConformityEntityView> SupplierContact { get; set; } 
        public IRPSComboBox<NonConformityEntityView> NCDemerit { get; set; } 
        public IRPSComboBox<NonConformityEntityView> DemeritDelivery { get; set; } 
        public IRPSTextBox<NonConformityEntityView> DaysForReply { get; set; } 
        public IRPSTextBox<NonConformityEntityView> SupplierReplyDate { get; set; } 
        public IRPSCheckbox<NonConformityEntityView> InvoiceClaim { get; set; } 
        public IRPSTextBox<NonConformityEntityView> InvoiceNumber { get; set; } 
        public IRPSTextBox<NonConformityEntityView> InvoiceAmount { get; set; } 
        public IRPSTextBox<NonConformityEntityView> SupplierReply { get; set; } 
        public IRPSComboBox<NonConformityEntityView> DeliveryNoteSL { get; set; } 
        public IRPSComboBox<NonConformityEntityView> OrderSL { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDArticle2 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDNonConformityOrigin2 { get; set; } 
        public IRPSOption<NonConformityEntityView> DeliveryNoteLine2 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> DeliveryNoteLineSL { get; set; } 
        public IRPSOption<NonConformityEntityView> OrderLine2 { get; set; } 
        public IRPSComboBox<NonConformityEntityView> OrderLineSL { get; set; } 
        public IRPSComboBox<NonConformityEntityView> CustomerContact { get; set; } 
        public IRPSComboBox<NonConformityEntityView> IDArticleVersion1 { get; set; } 
        public IRPSTextBox<NonConformityEntityView> CustApprovedBy { get; set; } 
        public IRPSTextBox<NonConformityEntityView> CustApprovedDate { get; set; } 
        public IRPSTextBox<NonConformityEntityView> CustomerResponse { get; set; } 
        public IRPSTextBox<NonConformityEntityView> Comments { get; set; } 
        public IRPSTextBox<NonConformityEntityView> TotalQuantity { get; set; } 
        public IRPSTextBox<NonConformityEntityView> TotalQuantitySecondUnit { get; set; } 
        public IRPSTextBox<NonConformityEntityView> RejectedQuantity { get; set; } 
        public IRPSTextBox<NonConformityEntityView> RejectedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<NonConformityEntityView> TotalQuantityAmount { get; set; } 
        public IRPSTextBox<NonConformityEntityView> GreetingEquipment { get; set; } 
        public IRPSButton<NonConformityEntityView,PrintWindowDialogView> PrintWindowNavigationCommandButton { get; set; } 
        public IRPSButton<NonConformityEntityView> ExecuteNewAssociatedNoConformityButton { get; set; } 
        public NCDefectsCollectionEditor<NonConformityEntityView,NCDefectView> NCDefects { get; set; } 
        public NCQuantityAffectedsCollectionEditor<NonConformityEntityView,NCDefectView> NCQuantityAffecteds { get; set; } 
        public NCLaborCostsCollectionEditor<NonConformityEntityView,NCDefectView> NCLaborCosts { get; set; } 
        public NCExternalCostsCollectionEditor<NonConformityEntityView,NCDefectView> NCExternalCosts { get; set; } 
        public NCCoreTeamsCollectionEditor<NonConformityEntityView,NCDefectView> NCCoreTeams { get; set; } 
        public NonConformityByLangsCollectionEditor<NonConformityEntityView,NCDefectView> NonConformityByLangs { get; set; } 
        public NonConformityQueryCollectionEditor<NonConformityEntityView,NCDefectView> NonConformityQuery { get; set; } 
        public IRPSSection<NonConformityEntityView> GeneralData { get; set; } 
        public IRPSSection<NonConformityEntityView> NCInformation { get; set; } 
        public IRPSSection<NonConformityEntityView> Comments1 { get; set; } 
        public IRPSSection<NonConformityEntityView> IdentificationOfDefects { get; set; } 
        public IRPSSection<NonConformityEntityView> QuantitiesAndCosts { get; set; } 
        public IRPSSection<NonConformityEntityView> MonitoringTeam { get; set; } 
        public IRPSSection<NonConformityEntityView> AssociatedNC { get; set; } 
        public NonConformity Screen { get; set; }
        public NonConformityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCDefectsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NCDefectsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NCDefectsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NCDefectsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DefectNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#65d44e1e-27b0-428c-b394-d110b3b6ff09 .ag-row[role='row']@ROWINDEX [col-id='cDefectNumber']","",true, this.CurrentView);
 
            IDNCGenericDefect = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#65d44e1e-27b0-428c-b394-d110b3b6ff09 .ag-row[role='row']@ROWINDEX [col-id='cIDNCGenericDefect']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NonConformityEntityView>("","#65d44e1e-27b0-428c-b394-d110b3b6ff09 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> DefectNumber { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDNCGenericDefect { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Description { get; set; } 
                     
    }
 
        public partial class NCQuantityAffectedsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NCQuantityAffectedsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NCQuantityAffectedsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NCQuantityAffectedsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Serie = RPSControlFactory.CreateRPSGridEnumComboBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 
            IDCostConcept = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cIDCostConcept']","",false, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            Decision = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#ae6cea7e-51c3-4bb8-a347-4986bdf56076 .ag-row[role='row']@ROWINDEX [col-id='cDecision']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> Date { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> Serie { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDCostConcept { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Cost { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> Decision { get; set; } 
                     
    }
 
        public partial class NCLaborCostsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NCLaborCostsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NCLaborCostsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NCLaborCostsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            IDCostConcept = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cIDCostConcept']","",false, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDHourType = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cIDHourType']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            UnitCost = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cUnitCost']","",true, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            ExtraExpenses = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#e0093a1f-70a8-4b03-a21d-9bdf432b2f10 .ag-row[role='row']@ROWINDEX [col-id='cExtraExpenses']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> Date { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDCostConcept { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDEmployee { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDHourType { get; set; } 
        public IRPSGridDurationTextBox<NonConformityEntityView> Duration { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> UnitCost { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Cost { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> ExtraExpenses { get; set; } 
                     
    }
 
        public partial class NCExternalCostsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NCExternalCostsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NCExternalCostsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NCExternalCostsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            IDCostConcept = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f .ag-row[role='row']@ROWINDEX [col-id='cIDCostConcept']","",false, this.CurrentView);
 
            InvoiceNumber = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f .ag-row[role='row']@ROWINDEX [col-id='cInvoiceNumber']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#a99df7ed-a4ad-49ce-acc2-9fe4b0fdb94f .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> Date { get; set; } 
        public IRPSGridComboBox<NonConformityEntityView> IDCostConcept { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> InvoiceNumber { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Cost { get; set; } 
                     
    }
 
        public partial class NCCoreTeamsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NCCoreTeamsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NCCoreTeamsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NCCoreTeamsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumParticipant = RPSControlFactory.CreateRPSGridFormattedTextBox<NonConformityEntityView>("","#b3d30ccb-e7f1-450a-92d9-a9099f81a0f2 .ag-row[role='row']@ROWINDEX [col-id='cNumParticipant']","",true, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#b3d30ccb-e7f1-450a-92d9-a9099f81a0f2 .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 
            Phone = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#b3d30ccb-e7f1-450a-92d9-a9099f81a0f2 .ag-row[role='row']@ROWINDEX [col-id='cPhone']","",false, this.CurrentView);
 
            Departament = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#b3d30ccb-e7f1-450a-92d9-a9099f81a0f2 .ag-row[role='row']@ROWINDEX [col-id='cDepartament']","",false, this.CurrentView);
 
            Leader = RPSControlFactory.CreateRPSGridCheckBox<NonConformityEntityView>("","#b3d30ccb-e7f1-450a-92d9-a9099f81a0f2 .ag-row[role='row']@ROWINDEX [col-id='cLeader']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> NumParticipant { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Name { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Phone { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> Departament { get; set; } 
        public IRPSGridCheckbox<NonConformityEntityView> Leader { get; set; } 
                     
    }
 
        public partial class NonConformityByLangsCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NonConformityByLangsGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NonConformityByLangsGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NonConformityByLangsGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NonConformityEntityView>("","#66ba31a4-1ed2-4779-8876-2032e4f1063a .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            GreetingEquipment = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#66ba31a4-1ed2-4779-8876-2032e4f1063a .ag-row[role='row']@ROWINDEX [col-id='cGreetingEquipment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NonConformityEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> GreetingEquipment { get; set; } 
                     
    }
 
        public partial class NonConformityQueryCollectionEditor<NonConformityEntityView,NCDefectView>:RPSCollectionEditor<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public  NonConformityQueryGridView<NonConformityEntityView,NCDefectView> GridView {get;set;}
    }
    public partial class NonConformityQueryGridView <NonConformityEntityView,NCDefectView> :  RPSGridView<NonConformityEntityView,NCDefectView> where NonConformityEntityView : class, IView where NCDefectView : class, IView
    {
        public NonConformityQueryGridView(NonConformityEntityView currentView,NCDefectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NonConformity_DoneDate = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#c6556a19-66e2-4012-908f-f05d1954a495 .ag-row[role='row']@ROWINDEX [col-id='cNonConformity_DoneDate']","",false, this.CurrentView);
 
            NonConformity_ClosedDate = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#c6556a19-66e2-4012-908f-f05d1954a495 .ag-row[role='row']@ROWINDEX [col-id='cNonConformity_ClosedDate']","",false, this.CurrentView);
 
            NonConformity_AssignmentDate = RPSControlFactory.CreateRPSGridTextBox<NonConformityEntityView>("","#c6556a19-66e2-4012-908f-f05d1954a495 .ag-row[role='row']@ROWINDEX [col-id='cNonConformity_AssignmentDate']","",false, this.CurrentView);
 
            NonConformity_Repetitive = RPSControlFactory.CreateRPSGridCheckBox<NonConformityEntityView>("","#c6556a19-66e2-4012-908f-f05d1954a495 .ag-row[role='row']@ROWINDEX [col-id='cNonConformity_Repetitive']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NonConformityEntityView> NonConformity_DoneDate { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> NonConformity_ClosedDate { get; set; } 
        public IRPSGridTextBox<NonConformityEntityView> NonConformity_AssignmentDate { get; set; } 
        public IRPSGridCheckbox<NonConformityEntityView> NonConformity_Repetitive { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCDefectView : View
    {
        public NCDefectView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCDefectView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCDefectView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCDefectView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCDefectView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            DefectNumber = RPSControlFactory.CreateRPSFormattedTextBox<NCDefectView>("a6133551-afe0-4145-b63f-ebd97ea2ae3a","","",true, this);
 
            IDNCGenericDefect = RPSControlFactory.CreateRPSComboBox<NCDefectView>("fb7e5b94-039d-44c3-8ed4-6d3de8167d4f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCDefectView>("ea51e970-1b58-4104-a6d1-bfd62ad3be97","","",false, this);
 
            CollectionInit params_NCActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="59b4c9b4-3d15-417b-9f35-380d30117d47",CSSSelectorGrid="",XPathGrid=""};
            NCActions = RPSControlFactory.RPSCreateCollectionWithGrid<NCActionsCollectionEditor<NCDefectView,NCCauseView>,NCDefectView,NCCauseView>( params_NCActions,this,Screen.NCCauseView);
 
            CollectionInit params_NCCauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5d6b5033-ed03-46ae-ab1d-49d57c9e0a16",CSSSelectorGrid="",XPathGrid=""};
            NCCauses = RPSControlFactory.RPSCreateCollectionWithGrid<NCCausesCollectionEditor<NCDefectView,NCCauseView>,NCDefectView,NCCauseView>( params_NCCauses,this,Screen.NCCauseView);
 
            CollectionInit params_NCDefectByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="171e062f-b07e-4d70-a053-ed8e1e237b9a",CSSSelectorGrid="",XPathGrid=""};
            NCDefectByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCDefectByLangsCollectionEditor<NCDefectView,NCCauseView>,NCDefectView,NCCauseView>( params_NCDefectByLangs,this,Screen.NCCauseView);
 
            General = RPSControlFactory.CreateRPSSection<NCDefectView>( "","ul li[rpsid='da7b731f-40fa-4286-9e27-e47eb29a2e0a']","",this);
 
            Causas = RPSControlFactory.CreateRPSSection<NCDefectView>( "","ul li[rpsid='16ba8c03-1b9a-4a54-8fe2-c50db760c599']","",this);
 
            DefectsByLang = RPSControlFactory.CreateRPSSection<NCDefectView>( "","ul li[rpsid='3ff665fc-6485-49a2-b885-35f60c0dd3d3']","",this);
 

        }
        public IRPSButton<NCDefectView> DeleteButton { get; set; } 
        public IRPSButton<NCDefectView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCDefectView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCDefectView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<NCDefectView> DefectNumber { get; set; } 
        public IRPSComboBox<NCDefectView> IDNCGenericDefect { get; set; } 
        public IRPSTextBox<NCDefectView> Description { get; set; } 
        public NCActionsCollectionEditor<NCDefectView,NCCauseView> NCActions { get; set; } 
        public NCCausesCollectionEditor<NCDefectView,NCCauseView> NCCauses { get; set; } 
        public NCDefectByLangsCollectionEditor<NCDefectView,NCCauseView> NCDefectByLangs { get; set; } 
        public IRPSSection<NCDefectView> General { get; set; } 
        public IRPSSection<NCDefectView> Causas { get; set; } 
        public IRPSSection<NCDefectView> DefectsByLang { get; set; } 
        public NonConformity Screen { get; set; }
        public NCDefectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCActionsCollectionEditor<NCDefectView,NCCauseView>:RPSCollectionEditor<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public  NCActionsGridView<NCDefectView,NCCauseView> GridView {get;set;}
    }
    public partial class NCActionsGridView <NCDefectView,NCCauseView> :  RPSGridView<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public NCActionsGridView(NCDefectView currentView,NCCauseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NCDefectView>("","#59b4c9b4-3d15-417b-9f35-380d30117d47 .ag-row[role='row']@ROWINDEX [col-id='cActionNumber']","",true, this.CurrentView);
 
            IDNCGenericAction = RPSControlFactory.CreateRPSGridComboBox<NCDefectView>("","#59b4c9b4-3d15-417b-9f35-380d30117d47 .ag-row[role='row']@ROWINDEX [col-id='cIDNCGenericAction']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCDefectView>("","#59b4c9b4-3d15-417b-9f35-380d30117d47 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDResponsible = RPSControlFactory.CreateRPSGridComboBox<NCDefectView>("","#59b4c9b4-3d15-417b-9f35-380d30117d47 .ag-row[role='row']@ROWINDEX [col-id='cIDResponsible']","",false, this.CurrentView);
 
            PlanedDate = RPSControlFactory.CreateRPSGridTextBox<NCDefectView>("","#59b4c9b4-3d15-417b-9f35-380d30117d47 .ag-row[role='row']@ROWINDEX [col-id='cPlanedDate']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<NCDefectView> ActionNumber { get; set; } 
        public IRPSGridComboBox<NCDefectView> IDNCGenericAction { get; set; } 
        public IRPSGridTextBox<NCDefectView> Description { get; set; } 
        public IRPSGridComboBox<NCDefectView> IDResponsible { get; set; } 
        public IRPSGridTextBox<NCDefectView> PlanedDate { get; set; } 
                     
    }
 
        public partial class NCCausesCollectionEditor<NCDefectView,NCCauseView>:RPSCollectionEditor<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public  NCCausesGridView<NCDefectView,NCCauseView> GridView {get;set;}
    }
    public partial class NCCausesGridView <NCDefectView,NCCauseView> :  RPSGridView<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public NCCausesGridView(NCDefectView currentView,NCCauseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CauseNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NCDefectView>("","#5d6b5033-ed03-46ae-ab1d-49d57c9e0a16 .ag-row[role='row']@ROWINDEX [col-id='cCauseNumber']","",true, this.CurrentView);
 
            IDNCGenericCause = RPSControlFactory.CreateRPSGridComboBox<NCDefectView>("","#5d6b5033-ed03-46ae-ab1d-49d57c9e0a16 .ag-row[role='row']@ROWINDEX [col-id='cIDNCGenericCause']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCDefectView>("","#5d6b5033-ed03-46ae-ab1d-49d57c9e0a16 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Contribution = RPSControlFactory.CreateRPSGridFormattedTextBox<NCDefectView>("","#5d6b5033-ed03-46ae-ab1d-49d57c9e0a16 .ag-row[role='row']@ROWINDEX [col-id='cContribution']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NCDefectView> CauseNumber { get; set; } 
        public IRPSGridComboBox<NCDefectView> IDNCGenericCause { get; set; } 
        public IRPSGridTextBox<NCDefectView> Description { get; set; } 
        public IRPSGridTextBox<NCDefectView> Contribution { get; set; } 
                     
    }
 
        public partial class NCDefectByLangsCollectionEditor<NCDefectView,NCCauseView>:RPSCollectionEditor<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public  NCDefectByLangsGridView<NCDefectView,NCCauseView> GridView {get;set;}
    }
    public partial class NCDefectByLangsGridView <NCDefectView,NCCauseView> :  RPSGridView<NCDefectView,NCCauseView> where NCDefectView : class, IView where NCCauseView : class, IView
    {
        public NCDefectByLangsGridView(NCDefectView currentView,NCCauseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCDefectView>("","#171e062f-b07e-4d70-a053-ed8e1e237b9a .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCDefectView>("","#171e062f-b07e-4d70-a053-ed8e1e237b9a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCDefectView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCDefectView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCCauseView : View
    {
        public NCCauseView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCCauseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCCauseView,NCDefectView>( this,Screen.NCDefectView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCCauseView,NCDefectView>( this,Screen.NCDefectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCCauseView,NCDefectView>( this,Screen.NCDefectView);
 
            CauseNumber = RPSControlFactory.CreateRPSFormattedTextBox<NCCauseView>("ebff3ae1-32d2-493e-9ce7-5a84bcc3bec7","","",true, this);
 
            IDNCGenericCause = RPSControlFactory.CreateRPSComboBox<NCCauseView>("50d09e26-1d9a-465a-8807-a9a5a49e35cb","","",false, this);
 
            Contribution = RPSControlFactory.CreateRPSFormattedTextBox<NCCauseView>("cc5de848-9da7-493f-b290-8e9ec3e92f8b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCCauseView>("5804037d-dcce-4449-abf2-f5a14ca7d17d","","",false, this);
 
            CollectionInit params_NCActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7a588905-c609-4183-9124-e60e725430bc",CSSSelectorGrid="",XPathGrid=""};
            NCActions = RPSControlFactory.RPSCreateCollectionWithGrid<NCActionsCollectionEditor<NCCauseView,NCCauseActionView>,NCCauseView,NCCauseActionView>( params_NCActions,this,Screen.NCCauseActionView);
 
            CollectionInit params_NCCauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e67097ee-6fad-4694-8de1-b4b103bc9ae3",CSSSelectorGrid="",XPathGrid=""};
            NCCauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCCauseByLangsCollectionEditor<NCCauseView,NCCauseActionView>,NCCauseView,NCCauseActionView>( params_NCCauseByLangs,this,Screen.NCCauseActionView);
 
            NCCause = RPSControlFactory.CreateRPSSection<NCCauseView>( "","ul li[rpsid='2093fbf5-7d1d-4870-a98c-5502f419a7a4']","",this);
 
            NCCauseByLang = RPSControlFactory.CreateRPSSection<NCCauseView>( "","ul li[rpsid='ab493987-de92-4d41-9c47-61cf91e2d63f']","",this);
 

        }
        public IRPSButton<NCCauseView> DeleteButton { get; set; } 
        public IRPSButton<NCCauseView,NCDefectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCCauseView,NCDefectView> BackButton { get; set; } 
        public IRPSAcceptButton<NCCauseView,NCDefectView> AcceptButton { get; set; } 
        public IRPSTextBox<NCCauseView> CauseNumber { get; set; } 
        public IRPSComboBox<NCCauseView> IDNCGenericCause { get; set; } 
        public IRPSTextBox<NCCauseView> Contribution { get; set; } 
        public IRPSTextBox<NCCauseView> Description { get; set; } 
        public NCActionsCollectionEditor<NCCauseView,NCCauseActionView> NCActions { get; set; } 
        public NCCauseByLangsCollectionEditor<NCCauseView,NCCauseActionView> NCCauseByLangs { get; set; } 
        public IRPSSection<NCCauseView> NCCause { get; set; } 
        public IRPSSection<NCCauseView> NCCauseByLang { get; set; } 
        public NonConformity Screen { get; set; }
        public NCCauseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCActionsCollectionEditor<NCCauseView,NCCauseActionView>:RPSCollectionEditor<NCCauseView,NCCauseActionView> where NCCauseView : class, IView where NCCauseActionView : class, IView
    {
        public  NCActionsGridView<NCCauseView,NCCauseActionView> GridView {get;set;}
    }
    public partial class NCActionsGridView <NCCauseView,NCCauseActionView> :  RPSGridView<NCCauseView,NCCauseActionView> where NCCauseView : class, IView where NCCauseActionView : class, IView
    {
        public NCActionsGridView(NCCauseView currentView,NCCauseActionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cActionNumber']","",true, this.CurrentView);
 
            Type8D = RPSControlFactory.CreateRPSGridEnumComboBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cType8D']","",false, this.CurrentView);
 
            IDNCGenericAction = RPSControlFactory.CreateRPSGridComboBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cIDNCGenericAction']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDResponsible = RPSControlFactory.CreateRPSGridComboBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cIDResponsible']","",false, this.CurrentView);
 
            PlanedDate = RPSControlFactory.CreateRPSGridTextBox<NCCauseView>("","#7a588905-c609-4183-9124-e60e725430bc .ag-row[role='row']@ROWINDEX [col-id='cPlanedDate']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<NCCauseView> ActionNumber { get; set; } 
        public IRPSGridComboBox<NCCauseView> Type8D { get; set; } 
        public IRPSGridComboBox<NCCauseView> IDNCGenericAction { get; set; } 
        public IRPSGridTextBox<NCCauseView> Description { get; set; } 
        public IRPSGridComboBox<NCCauseView> IDResponsible { get; set; } 
        public IRPSGridTextBox<NCCauseView> PlanedDate { get; set; } 
                     
    }
 
        public partial class NCCauseByLangsCollectionEditor<NCCauseView,NCCauseActionView>:RPSCollectionEditor<NCCauseView,NCCauseActionView> where NCCauseView : class, IView where NCCauseActionView : class, IView
    {
        public  NCCauseByLangsGridView<NCCauseView,NCCauseActionView> GridView {get;set;}
    }
    public partial class NCCauseByLangsGridView <NCCauseView,NCCauseActionView> :  RPSGridView<NCCauseView,NCCauseActionView> where NCCauseView : class, IView where NCCauseActionView : class, IView
    {
        public NCCauseByLangsGridView(NCCauseView currentView,NCCauseActionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCCauseView>("","#e67097ee-6fad-4694-8de1-b4b103bc9ae3 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCCauseView>("","#e67097ee-6fad-4694-8de1-b4b103bc9ae3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCCauseView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCCauseView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCCauseActionView : View
    {
        public NCCauseActionView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCCauseActionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCCauseActionView,NCCauseView>( this,Screen.NCCauseView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCCauseActionView,NCCauseView>( this,Screen.NCCauseView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCCauseActionView,NCCauseView>( this,Screen.NCCauseView);
 
            ActionNumber = RPSControlFactory.CreateRPSFormattedTextBox<NCCauseActionView>("c102f89f-01ec-437e-ba1e-846a112d8845","","",true, this);
 
            Type8D = RPSControlFactory.CreateRPSEnumComboBox<NCCauseActionView>("739ee23f-a65d-4ae8-9ec0-e8d8971d6efd","","",false, this);
 
            IDNCGenericAction = RPSControlFactory.CreateRPSComboBox<NCCauseActionView>("77f67838-a29e-45f9-9631-226e74466120","","",false, this);
 
            IDResponsible = RPSControlFactory.CreateRPSComboBox<NCCauseActionView>("1a39a5e1-9041-412f-ad6d-cb8ab3427ce3","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("6fdf9daa-37ec-4212-a1b9-a8deb6a15f0a","","",false, this);
 
            PlanedDate = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("50495578-3496-4766-ae31-3e3534eedfc9","","",true, this);
 
            RealDate = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("159baeda-d23f-440f-a62e-868822f28fff","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("49ed5e09-c052-40bc-9061-7994033173ab","","",false, this);
 
            Efficacy = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("d0726fec-cc52-4b93-bb60-a51f45dbe4e4","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<NCCauseActionView>("e83dc05c-2027-4744-896e-22736da16f96","","",false, this);
 
            Verification = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("2e567936-8e6a-49eb-ac1e-ff1ba7a285c1","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCCauseActionView>("2639f814-9997-4cbb-9684-710cd0296b41","","",false, this);
 
            CollectionInit params_NCActionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d9165be8-7c0f-4726-bac8-beda24bcf325",CSSSelectorGrid="",XPathGrid=""};
            NCActionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCActionByLangsCollectionEditor<NCCauseActionView,NCCauseActionByLangView>,NCCauseActionView,NCCauseActionByLangView>( params_NCActionByLangs,this,Screen.NCCauseActionByLangView);
 
            Section = RPSControlFactory.CreateRPSSection<NCCauseActionView>( "","ul li[rpsid='5522a075-f53c-47ae-8f48-d6e57ff0c335']","",this);
 
            ActionByLangs = RPSControlFactory.CreateRPSSection<NCCauseActionView>( "","ul li[rpsid='62a8bb97-aad8-4463-b18d-8af09bbcb0ce']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCCauseActionView>( "","ul li[rpsid='a344f49f-272d-4242-9a8f-b16e270f9c4c']","",this);
 

        }
        public IRPSButton<NCCauseActionView> DeleteButton { get; set; } 
        public IRPSButton<NCCauseActionView,NCCauseView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCCauseActionView,NCCauseView> BackButton { get; set; } 
        public IRPSAcceptButton<NCCauseActionView,NCCauseView> AcceptButton { get; set; } 
        public IRPSTextBox<NCCauseActionView> ActionNumber { get; set; } 
        public IRPSComboBox<NCCauseActionView> Type8D { get; set; } 
        public IRPSComboBox<NCCauseActionView> IDNCGenericAction { get; set; } 
        public IRPSComboBox<NCCauseActionView> IDResponsible { get; set; } 
        public IRPSTextBox<NCCauseActionView> Description { get; set; } 
        public IRPSTextBox<NCCauseActionView> PlanedDate { get; set; } 
        public IRPSTextBox<NCCauseActionView> RealDate { get; set; } 
        public IRPSTextBox<NCCauseActionView> EndDate { get; set; } 
        public IRPSTextBox<NCCauseActionView> Efficacy { get; set; } 
        public IRPSTextBox<NCCauseActionView> Progress { get; set; } 
        public IRPSTextBox<NCCauseActionView> Verification { get; set; } 
        public IRPSTextBox<NCCauseActionView> Comments { get; set; } 
        public NCActionByLangsCollectionEditor<NCCauseActionView,NCCauseActionByLangView> NCActionByLangs { get; set; } 
        public IRPSSection<NCCauseActionView> Section { get; set; } 
        public IRPSSection<NCCauseActionView> ActionByLangs { get; set; } 
        public IRPSSection<NCCauseActionView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCCauseActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCActionByLangsCollectionEditor<NCCauseActionView,NCCauseActionByLangView>:RPSCollectionEditor<NCCauseActionView,NCCauseActionByLangView> where NCCauseActionView : class, IView where NCCauseActionByLangView : class, IView
    {
        public  NCActionByLangsGridView<NCCauseActionView,NCCauseActionByLangView> GridView {get;set;}
    }
    public partial class NCActionByLangsGridView <NCCauseActionView,NCCauseActionByLangView> :  RPSGridView<NCCauseActionView,NCCauseActionByLangView> where NCCauseActionView : class, IView where NCCauseActionByLangView : class, IView
    {
        public NCActionByLangsGridView(NCCauseActionView currentView,NCCauseActionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCCauseActionView>("","#d9165be8-7c0f-4726-bac8-beda24bcf325 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCCauseActionView>("","#d9165be8-7c0f-4726-bac8-beda24bcf325 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<NCCauseActionView>("","#d9165be8-7c0f-4726-bac8-beda24bcf325 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 
            Efficacy = RPSControlFactory.CreateRPSGridTextBox<NCCauseActionView>("","#d9165be8-7c0f-4726-bac8-beda24bcf325 .ag-row[role='row']@ROWINDEX [col-id='cEfficacy']","",false, this.CurrentView);
 
            Verification = RPSControlFactory.CreateRPSGridTextBox<NCCauseActionView>("","#d9165be8-7c0f-4726-bac8-beda24bcf325 .ag-row[role='row']@ROWINDEX [col-id='cVerification']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCCauseActionView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCCauseActionView> Description { get; set; } 
        public IRPSGridTextBox<NCCauseActionView> Comments { get; set; } 
        public IRPSGridTextBox<NCCauseActionView> Efficacy { get; set; } 
        public IRPSGridTextBox<NCCauseActionView> Verification { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCActionView : View
    {
        public NCActionView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCActionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCActionView,NCDefectView>( this,Screen.NCDefectView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCActionView,NCDefectView>( this,Screen.NCDefectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCActionView,NCDefectView>( this,Screen.NCDefectView);
 
            ActionNumber = RPSControlFactory.CreateRPSFormattedTextBox<NCActionView>("114fa231-6fe6-4890-95ac-887fea19e1f3","","",true, this);
 
            Type8D = RPSControlFactory.CreateRPSEnumComboBox<NCActionView>("ae607af1-8152-43b1-9ed8-706784e82b67","","",false, this);
 
            IDNCGenericAction = RPSControlFactory.CreateRPSComboBox<NCActionView>("b49ff2e7-6ecd-48e0-a361-a1b34de23a8c","","",false, this);
 
            IDResponsible = RPSControlFactory.CreateRPSComboBox<NCActionView>("2fcab888-bf18-4d9d-8f8c-d590731e1d48","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCActionView>("d1572f3b-a85c-4ef0-9f1d-3b372efc9d11","","",false, this);
 
            PlanedDate = RPSControlFactory.CreateRPSTextBox<NCActionView>("0b339ee9-8008-433f-94ee-e6ddad8e1509","","",true, this);
 
            RealDate = RPSControlFactory.CreateRPSTextBox<NCActionView>("bec46620-6720-4ea2-afff-9762daf7660a","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<NCActionView>("26c8f58e-6819-4a42-9421-0a2f945310e2","","",false, this);
 
            Efficacy = RPSControlFactory.CreateRPSTextBox<NCActionView>("38f6648f-4f92-4eba-be00-dc667f142968","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<NCActionView>("2a065f35-c8e8-42a4-ad64-b54375605dc8","","",false, this);
 
            Verification = RPSControlFactory.CreateRPSTextBox<NCActionView>("eeb41f92-4040-43a2-a694-766943b138d3","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCActionView>("e7fa6107-463d-4d0c-ac25-eb924dc10335","","",false, this);
 
            CollectionInit params_NCActionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="854b8bd5-4fea-4c48-8e9b-9ffbf6c601de",CSSSelectorGrid="",XPathGrid=""};
            NCActionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<NCActionByLangsCollectionEditor<NCActionView,NCActionByLangView>,NCActionView,NCActionByLangView>( params_NCActionByLangs,this,Screen.NCActionByLangView);
 
            Section = RPSControlFactory.CreateRPSSection<NCActionView>( "","ul li[rpsid='cd77dab0-1a09-466e-90a1-8a13fc12dedf']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<NCActionView>( "","ul li[rpsid='2c2bf069-05f0-4bc0-8243-ed2388164780']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCActionView>( "","ul li[rpsid='3020f069-3f3a-42e8-9e9e-ab8fdff8bb37']","",this);
 

        }
        public IRPSButton<NCActionView> DeleteButton { get; set; } 
        public IRPSButton<NCActionView,NCDefectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCActionView,NCDefectView> BackButton { get; set; } 
        public IRPSAcceptButton<NCActionView,NCDefectView> AcceptButton { get; set; } 
        public IRPSTextBox<NCActionView> ActionNumber { get; set; } 
        public IRPSComboBox<NCActionView> Type8D { get; set; } 
        public IRPSComboBox<NCActionView> IDNCGenericAction { get; set; } 
        public IRPSComboBox<NCActionView> IDResponsible { get; set; } 
        public IRPSTextBox<NCActionView> Description { get; set; } 
        public IRPSTextBox<NCActionView> PlanedDate { get; set; } 
        public IRPSTextBox<NCActionView> RealDate { get; set; } 
        public IRPSTextBox<NCActionView> EndDate { get; set; } 
        public IRPSTextBox<NCActionView> Efficacy { get; set; } 
        public IRPSTextBox<NCActionView> Progress { get; set; } 
        public IRPSTextBox<NCActionView> Verification { get; set; } 
        public IRPSTextBox<NCActionView> Comments { get; set; } 
        public NCActionByLangsCollectionEditor<NCActionView,NCActionByLangView> NCActionByLangs { get; set; } 
        public IRPSSection<NCActionView> Section { get; set; } 
        public IRPSSection<NCActionView> Section2 { get; set; } 
        public IRPSSection<NCActionView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NCActionByLangsCollectionEditor<NCActionView,NCActionByLangView>:RPSCollectionEditor<NCActionView,NCActionByLangView> where NCActionView : class, IView where NCActionByLangView : class, IView
    {
        public  NCActionByLangsGridView<NCActionView,NCActionByLangView> GridView {get;set;}
    }
    public partial class NCActionByLangsGridView <NCActionView,NCActionByLangView> :  RPSGridView<NCActionView,NCActionByLangView> where NCActionView : class, IView where NCActionByLangView : class, IView
    {
        public NCActionByLangsGridView(NCActionView currentView,NCActionByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<NCActionView>("","#854b8bd5-4fea-4c48-8e9b-9ffbf6c601de .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<NCActionView>("","#854b8bd5-4fea-4c48-8e9b-9ffbf6c601de .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<NCActionView>("","#854b8bd5-4fea-4c48-8e9b-9ffbf6c601de .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 
            Efficacy = RPSControlFactory.CreateRPSGridTextBox<NCActionView>("","#854b8bd5-4fea-4c48-8e9b-9ffbf6c601de .ag-row[role='row']@ROWINDEX [col-id='cEfficacy']","",false, this.CurrentView);
 
            Verification = RPSControlFactory.CreateRPSGridTextBox<NCActionView>("","#854b8bd5-4fea-4c48-8e9b-9ffbf6c601de .ag-row[role='row']@ROWINDEX [col-id='cVerification']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<NCActionView> CodLanguage { get; set; } 
        public IRPSGridTextBox<NCActionView> Description { get; set; } 
        public IRPSGridTextBox<NCActionView> Comments { get; set; } 
        public IRPSGridTextBox<NCActionView> Efficacy { get; set; } 
        public IRPSGridTextBox<NCActionView> Verification { get; set; } 
                     
    }
 
    }
  
            
    public partial class NCLaborCostView : View
    {
        public NCLaborCostView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCLaborCostView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCLaborCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCLaborCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCLaborCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            Date = RPSControlFactory.CreateRPSTextBox<NCLaborCostView>("1b2697ac-387e-4ee8-bafd-73589cad2795","","",true, this);
 
            IDCostConcept = RPSControlFactory.CreateRPSComboBox<NCLaborCostView>("88c295c2-8d38-4b60-8d20-f2c993590b19","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCLaborCostView>("aa8ae000-a3ee-4086-a893-5b01770684bc","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<NCLaborCostView>("ae424d53-0b94-4daa-aeb7-e9ade8fa545c","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<NCLaborCostView>("c1e0bb39-6f86-4e6d-bab4-bfffc71ce71d","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<NCLaborCostView>("280382b7-2bd4-49d9-9fd1-1c89392b9498","","",true, this);
 
            UnitCost = RPSControlFactory.CreateRPSFormattedTextBox<NCLaborCostView>("ee840177-0ef7-4327-9f2e-4122581f4f3e","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<NCLaborCostView>("23861742-db99-4c20-8790-dcf779d60f24","","",true, this);
 
            ExtraExpenses = RPSControlFactory.CreateRPSFormattedTextBox<NCLaborCostView>("9460f316-965b-4bb6-b509-ecf8f2928d60","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCLaborCostView>("6371765b-69e6-4907-8ee5-62c5d21ab866","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<NCLaborCostView>( "","ul li[rpsid='f6f32b53-74e3-4530-b724-264ddbf6642e']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCLaborCostView>( "","ul li[rpsid='2427e36e-b32f-483d-b2dd-8b2c07809277']","",this);
 

        }
        public IRPSButton<NCLaborCostView> DeleteButton { get; set; } 
        public IRPSButton<NCLaborCostView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCLaborCostView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCLaborCostView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<NCLaborCostView> Date { get; set; } 
        public IRPSComboBox<NCLaborCostView> IDCostConcept { get; set; } 
        public IRPSTextBox<NCLaborCostView> Description { get; set; } 
        public IRPSComboBox<NCLaborCostView> IDEmployee { get; set; } 
        public IRPSComboBox<NCLaborCostView> IDHourType { get; set; } 
        public IRPSDurationTextBox<NCLaborCostView> Duration { get; set; } 
        public IRPSTextBox<NCLaborCostView> UnitCost { get; set; } 
        public IRPSTextBox<NCLaborCostView> Cost { get; set; } 
        public IRPSTextBox<NCLaborCostView> ExtraExpenses { get; set; } 
        public IRPSTextBox<NCLaborCostView> Comments { get; set; } 
        public IRPSSection<NCLaborCostView> Section { get; set; } 
        public IRPSSection<NCLaborCostView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCLaborCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCExternalCostView : View
    {
        public NCExternalCostView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCExternalCostView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCExternalCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCExternalCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCExternalCostView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            Date = RPSControlFactory.CreateRPSTextBox<NCExternalCostView>("0c332882-0704-475c-bb01-b062b2bccccd","","",true, this);
 
            IDCostConcept = RPSControlFactory.CreateRPSComboBox<NCExternalCostView>("3774f24a-a461-4f08-8ec1-2ba2df46779d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCExternalCostView>("c8efa598-ea6a-4be1-9018-fdb3c884f6a0","","",false, this);
 
            InvoiceNumber = RPSControlFactory.CreateRPSTextBox<NCExternalCostView>("46af6453-d674-405d-ba22-2545e1d10191","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<NCExternalCostView>("466161ee-6709-4ab2-a5e1-6f8e31e1f30a","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<NCExternalCostView>("50885866-91b5-4c36-91fc-b87f60e35df6","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCExternalCostView>("43c66a7f-5a73-43a4-a367-2bb0c876e247","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<NCExternalCostView>( "","ul li[rpsid='a7d2d768-6aa5-4cda-8125-ca3f4dcefe79']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCExternalCostView>( "","ul li[rpsid='fd7541ed-bce5-4555-a2be-4786e910d84e']","",this);
 

        }
        public IRPSButton<NCExternalCostView> DeleteButton { get; set; } 
        public IRPSButton<NCExternalCostView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCExternalCostView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCExternalCostView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<NCExternalCostView> Date { get; set; } 
        public IRPSComboBox<NCExternalCostView> IDCostConcept { get; set; } 
        public IRPSTextBox<NCExternalCostView> Description { get; set; } 
        public IRPSTextBox<NCExternalCostView> InvoiceNumber { get; set; } 
        public IRPSTextBox<NCExternalCostView> InvoiceDate { get; set; } 
        public IRPSTextBox<NCExternalCostView> Cost { get; set; } 
        public IRPSTextBox<NCExternalCostView> Comments { get; set; } 
        public IRPSSection<NCExternalCostView> Section { get; set; } 
        public IRPSSection<NCExternalCostView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCExternalCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCCoreTeamView : View
    {
        public NCCoreTeamView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCCoreTeamView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCCoreTeamView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCCoreTeamView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCCoreTeamView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            NumParticipant = RPSControlFactory.CreateRPSFormattedTextBox<NCCoreTeamView>("d6c0d89d-51db-4bc0-bfda-f909fc497dc9","","",true, this);
 
            Name = RPSControlFactory.CreateRPSTextBox<NCCoreTeamView>("7b48dd96-39b0-4ce3-9b6d-2f2003d8ebd2","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<NCCoreTeamView>("84414bef-d4a5-400c-b1fa-5cdb679295b9","","",false, this);
 
            Departament = RPSControlFactory.CreateRPSTextBox<NCCoreTeamView>("5818c820-f506-4a61-af4a-ae9dc843cb8e","","",false, this);
 
            Leader = RPSControlFactory.CreateRPSCheckBox<NCCoreTeamView>("89ad7c16-6fa8-4bf0-a58c-a12d43c5867f","","",false, this);
 

        }
        public IRPSButton<NCCoreTeamView> DeleteButton { get; set; } 
        public IRPSButton<NCCoreTeamView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCCoreTeamView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCCoreTeamView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<NCCoreTeamView> NumParticipant { get; set; } 
        public IRPSTextBox<NCCoreTeamView> Name { get; set; } 
        public IRPSTextBox<NCCoreTeamView> Phone { get; set; } 
        public IRPSTextBox<NCCoreTeamView> Departament { get; set; } 
        public IRPSCheckbox<NCCoreTeamView> Leader { get; set; } 
        public NonConformity Screen { get; set; }
        public NCCoreTeamView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCQuantityAffectedView : View
    {
        public NCQuantityAffectedView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCQuantityAffectedView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCQuantityAffectedView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCQuantityAffectedView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCQuantityAffectedView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            Date = RPSControlFactory.CreateRPSTextBox<NCQuantityAffectedView>("517d1902-b8f5-4d13-ab70-8a0b2a5340d2","","",true, this);
 
            IDCostConcept = RPSControlFactory.CreateRPSComboBox<NCQuantityAffectedView>("59b68790-e8fd-4e66-96b0-4aa311853ab2","","",false, this);
 
            CostDescription = RPSControlFactory.CreateRPSTextBox<NCQuantityAffectedView>("5d96369c-02ba-400f-82d2-2d8876feac25","","",false, this);
 
            Serie = RPSControlFactory.CreateRPSEnumComboBox<NCQuantityAffectedView>("d41fefca-c820-48a2-88e5-9067a06d3342","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<NCQuantityAffectedView>("4ac0957b-2499-4f16-9d32-2f95dbac90ae","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<NCQuantityAffectedView>("97b6cb14-b358-4677-9585-2cf47615b24b","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<NCQuantityAffectedView>("80cf0d46-599e-4a25-ba51-45d956201b3d","","",true, this);
 
            Decision = RPSControlFactory.CreateRPSComboBox<NCQuantityAffectedView>("04ae2640-25fe-4bdc-a8a5-42f92832fdfd","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCQuantityAffectedView>("13ea7ab1-7970-4422-9876-c2505029deb3","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<NCQuantityAffectedView>( "","ul li[rpsid='16e2c05a-aa17-44b6-b0ea-4869aa7b2b1c']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCQuantityAffectedView>( "","ul li[rpsid='4e36fdfe-7576-4ca9-9234-db4f31307a38']","",this);
 

        }
        public IRPSButton<NCQuantityAffectedView> DeleteButton { get; set; } 
        public IRPSButton<NCQuantityAffectedView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCQuantityAffectedView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NCQuantityAffectedView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> Date { get; set; } 
        public IRPSComboBox<NCQuantityAffectedView> IDCostConcept { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> CostDescription { get; set; } 
        public IRPSComboBox<NCQuantityAffectedView> Serie { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> Quantity { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> Cost { get; set; } 
        public IRPSComboBox<NCQuantityAffectedView> Decision { get; set; } 
        public IRPSTextBox<NCQuantityAffectedView> Comments { get; set; } 
        public IRPSSection<NCQuantityAffectedView> Section { get; set; } 
        public IRPSSection<NCQuantityAffectedView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCQuantityAffectedView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCCauseByLangView : View
    {
        public NCCauseByLangView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCCauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCCauseByLangView,NCCauseView>( this,Screen.NCCauseView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCCauseByLangView,NCCauseView>( this,Screen.NCCauseView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCCauseByLangView,NCCauseView>( this,Screen.NCCauseView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCCauseByLangView>("5305af0f-8847-42dd-90cc-da556a80e7cc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCCauseByLangView>("56b625a1-7118-4174-8c49-4d77616a9e97","","",false, this);
 

        }
        public IRPSButton<NCCauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCCauseByLangView,NCCauseView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCCauseByLangView,NCCauseView> BackButton { get; set; } 
        public IRPSAcceptButton<NCCauseByLangView,NCCauseView> AcceptButton { get; set; } 
        public IRPSComboBox<NCCauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCCauseByLangView> Description { get; set; } 
        public NonConformity Screen { get; set; }
        public NCCauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCDefectByLangView : View
    {
        public NCDefectByLangView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCDefectByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCDefectByLangView,NCDefectView>( this,Screen.NCDefectView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCDefectByLangView,NCDefectView>( this,Screen.NCDefectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCDefectByLangView,NCDefectView>( this,Screen.NCDefectView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCDefectByLangView>("9dfb3ea8-bf43-42ed-b439-99a1d91e04ab","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCDefectByLangView>("1d76266a-7081-455f-85d7-7e0ce6c31aad","","",false, this);
 

        }
        public IRPSButton<NCDefectByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCDefectByLangView,NCDefectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCDefectByLangView,NCDefectView> BackButton { get; set; } 
        public IRPSAcceptButton<NCDefectByLangView,NCDefectView> AcceptButton { get; set; } 
        public IRPSComboBox<NCDefectByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCDefectByLangView> Description { get; set; } 
        public NonConformity Screen { get; set; }
        public NCDefectByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NonConformityByLangView : View
    {
        public NonConformityByLangView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NonConformityByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NonConformityByLangView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<NonConformityByLangView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NonConformityByLangView,NonConformityEntityView>( this,Screen.NonConformityEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NonConformityByLangView>("46484999-97ff-4b50-889d-407f39587b02","","",true, this);
 
            GreetingEquipment = RPSControlFactory.CreateRPSTextBox<NonConformityByLangView>("d4c006d8-9533-489c-8fcc-0fe743102081","","",false, this);
 

        }
        public IRPSButton<NonConformityByLangView> DeleteButton { get; set; } 
        public IRPSButton<NonConformityByLangView,NonConformityEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NonConformityByLangView,NonConformityEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<NonConformityByLangView,NonConformityEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<NonConformityByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NonConformityByLangView> GreetingEquipment { get; set; } 
        public NonConformity Screen { get; set; }
        public NonConformityByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCActionByLangView : View
    {
        public NCActionByLangView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCActionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCActionByLangView,NCActionView>( this,Screen.NCActionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCActionByLangView,NCActionView>( this,Screen.NCActionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCActionByLangView,NCActionView>( this,Screen.NCActionView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCActionByLangView>("fe8e6ad8-b708-490b-9a56-538b78585ed8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCActionByLangView>("9fc10383-574e-486d-bc0d-0fd406d297e8","","",false, this);
 
            Efficacy = RPSControlFactory.CreateRPSTextBox<NCActionByLangView>("2553bd07-8f56-498b-b4cc-cbaa131b4dbb","","",false, this);
 
            Verification = RPSControlFactory.CreateRPSTextBox<NCActionByLangView>("672a3078-eaca-4c65-922a-2ef607283fbb","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCActionByLangView>("f87e491b-e0b1-4b9d-a574-7a042eeb09fe","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<NCActionByLangView>( "","ul li[rpsid='d43a13ad-7e47-438a-b06f-338cc857940b']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<NCActionByLangView>( "","ul li[rpsid='a10abbf0-5d1b-4560-bd7a-5f6cbe890bcd']","",this);
 

        }
        public IRPSButton<NCActionByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCActionByLangView,NCActionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCActionByLangView,NCActionView> BackButton { get; set; } 
        public IRPSAcceptButton<NCActionByLangView,NCActionView> AcceptButton { get; set; } 
        public IRPSComboBox<NCActionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCActionByLangView> Description { get; set; } 
        public IRPSTextBox<NCActionByLangView> Efficacy { get; set; } 
        public IRPSTextBox<NCActionByLangView> Verification { get; set; } 
        public IRPSTextBox<NCActionByLangView> Comments { get; set; } 
        public IRPSSection<NCActionByLangView> Section { get; set; } 
        public IRPSSection<NCActionByLangView> Section1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCActionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCFromControlSheetDialogView : View
    {
        public NCFromControlSheetDialogView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eType = RPSControlFactory.CreateRPSEnumComboBox<NCFromControlSheetDialogView>("5e940446-9017-41e9-a4b2-50ffbd2730d9","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<NCFromControlSheetDialogView>( "1ce03536-3048-4f4e-aeab-1f9a01fc5968","","",this);
 
            Project = RPSControlFactory.CreateRPSOption<NCFromControlSheetDialogView>( "a828c3dd-a06e-464f-8ed8-60a78d514932","","",this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("627a31a1-c504-43ce-b98d-4e0b8e96cfa4","","",false, this);
 
            ManufacturingOrder1 = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("ccdce006-8519-43b7-98e5-7fe3349c3999","","",false, this);
 
            Project1 = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("f4d78db1-44e0-49d5-b4be-919cc9982757","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("f716e484-5b33-4c38-a741-386de0866391","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("0422b69a-e23c-4d12-b320-b5067f4c85a0","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("fedffbce-b8e4-45e8-bdb8-80c0cca64c4e","","",false, this);
 
            DeliveryNoteLineOption = RPSControlFactory.CreateRPSOption<NCFromControlSheetDialogView>( "67799cdd-58d9-4adc-a664-1ff14691b235","","",this);
 
            DeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("16494105-c288-4e08-98d5-1f6d8ec95fba","","",false, this);
 
            OrderLineOption = RPSControlFactory.CreateRPSOption<NCFromControlSheetDialogView>( "7892a609-b834-449a-b126-9d101c986321","","",this);
 
            OrderLine = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("a666e16c-4f99-4af0-9436-1edffecae298","","",false, this);
 
            ControlSheetVersionInternal = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("95340384-dfb6-4f60-b864-001ab0b47a50","","",false, this);
 
            ControlSheetVersionSupplier = RPSControlFactory.CreateRPSComboBox<NCFromControlSheetDialogView>("ad0fb807-1e63-4be5-9837-876c3dfd903c","","",false, this);
 

        }
        public IRPSComboBox<NCFromControlSheetDialogView> eType { get; set; } 
        public IRPSOption<NCFromControlSheetDialogView> ManufacturingOrder { get; set; } 
        public IRPSOption<NCFromControlSheetDialogView> Project { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> IDSite { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> ManufacturingOrder1 { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> Project1 { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> MOTask { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> ProjectTask { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> DeliveryNote { get; set; } 
        public IRPSOption<NCFromControlSheetDialogView> DeliveryNoteLineOption { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> DeliveryNoteLine { get; set; } 
        public IRPSOption<NCFromControlSheetDialogView> OrderLineOption { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> OrderLine { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> ControlSheetVersionInternal { get; set; } 
        public IRPSComboBox<NCFromControlSheetDialogView> ControlSheetVersionSupplier { get; set; } 
        public NonConformity Screen { get; set; }
        public NCFromControlSheetDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintWindowDialogView : View
    {
        public PrintWindowDialogView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Language = RPSControlFactory.CreateRPSComboBox<PrintWindowDialogView>("f47f5860-4d6d-4ebd-86ab-b553921eef1a","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<PrintWindowDialogView>("cfe2166a-9e8a-418d-93ee-66429273b688","","",false, this);
 
            AddAttachments = RPSControlFactory.CreateRPSCheckBox<PrintWindowDialogView>("96f7b2a2-f26b-48b8-bfca-04aee3f939c5","","",false, this);
 
            PrintNonConformityReportCommandButton = RPSControlFactory.CreateRPSButton<PrintWindowDialogView>( "45a24dc3-48ed-4cf3-9389-e9cff52bb00a","","",this);
 
            NonConfirmityReportByEMailCommandButton = RPSControlFactory.CreateRPSButton<PrintWindowDialogView>( "c1441753-c11b-41af-b3d5-5c7d20e51ecd","","",this);
 
            NonConformityByClientEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintWindowDialogView>( "80bfdf89-9e01-4e24-8f94-c095751214b5","","",this);
 

        }
        public IRPSComboBox<PrintWindowDialogView> Language { get; set; } 
        public IRPSComboBox<PrintWindowDialogView> CustomReport { get; set; } 
        public IRPSCheckbox<PrintWindowDialogView> AddAttachments { get; set; } 
        public IRPSButton<PrintWindowDialogView> PrintNonConformityReportCommandButton { get; set; } 
        public IRPSButton<PrintWindowDialogView> NonConfirmityReportByEMailCommandButton { get; set; } 
        public IRPSButton<PrintWindowDialogView> NonConformityByClientEmailCommandButton { get; set; } 
        public NonConformity Screen { get; set; }
        public PrintWindowDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCCauseActionByLangView : View
    {
        public NCCauseActionByLangView(NonConformity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<NCCauseActionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<NCCauseActionByLangView,NCCauseActionView>( this,Screen.NCCauseActionView);
 
            BackButton = RPSControlFactory.RPSBackButton<NCCauseActionByLangView,NCCauseActionView>( this,Screen.NCCauseActionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<NCCauseActionByLangView,NCCauseActionView>( this,Screen.NCCauseActionView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<NCCauseActionByLangView>("5a1ae551-ab6c-4bcd-9573-14283d1c14e7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCCauseActionByLangView>("181cce42-8db1-413d-8741-64c9aa0ae951","","",false, this);
 
            Efficacy = RPSControlFactory.CreateRPSTextBox<NCCauseActionByLangView>("2a2316e4-dc3b-4629-8499-15510d742de9","","",false, this);
 
            Verification = RPSControlFactory.CreateRPSTextBox<NCCauseActionByLangView>("5a25fb8b-ea28-473d-aee8-f6622b362599","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCCauseActionByLangView>("e824777b-8efb-4146-9af0-af3486b92453","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<NCCauseActionByLangView>( "","ul li[rpsid='c36f674c-d3b2-4c98-8c5a-145b7a74a6a2']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<NCCauseActionByLangView>( "","ul li[rpsid='795e5ab0-5c1c-49c7-990a-e2e670fda4ec']","",this);
 

        }
        public IRPSButton<NCCauseActionByLangView> DeleteButton { get; set; } 
        public IRPSButton<NCCauseActionByLangView,NCCauseActionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<NCCauseActionByLangView,NCCauseActionView> BackButton { get; set; } 
        public IRPSAcceptButton<NCCauseActionByLangView,NCCauseActionView> AcceptButton { get; set; } 
        public IRPSComboBox<NCCauseActionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<NCCauseActionByLangView> Description { get; set; } 
        public IRPSTextBox<NCCauseActionByLangView> Efficacy { get; set; } 
        public IRPSTextBox<NCCauseActionByLangView> Verification { get; set; } 
        public IRPSTextBox<NCCauseActionByLangView> Comments { get; set; } 
        public IRPSSection<NCCauseActionByLangView> GeneralData { get; set; } 
        public IRPSSection<NCCauseActionByLangView> Comments1 { get; set; } 
        public NonConformity Screen { get; set; }
        public NCCauseActionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}