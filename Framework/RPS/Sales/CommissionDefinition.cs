    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionDefinition
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionDefinition:Screen
    {
        public CommissionDefinition():base()
        {
            this.URL = "sales.commissiondefinition";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionDefinitionSLVMQueryView  = new CommissionDefinitionSLVMQueryView(this); 
            CommissionDefinitionSLVMEntityView  = new CommissionDefinitionSLVMEntityView(this); 
            CommissionDefinitionSLVMQueryView.InitializeControls(); 
            CommissionDefinitionSLVMEntityView.InitializeControls(); 
           
        }
      
            public CommissionDefinitionSLVMQueryView CommissionDefinitionSLVMQueryView {get; set; } 
            public CommissionDefinitionSLVMEntityView CommissionDefinitionSLVMEntityView {get; set; } 
    }
            
    public partial class CommissionDefinitionSLVMQueryView : View
    {
        public CommissionDefinitionSLVMQueryView(CommissionDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView>( this,Screen.CommissionDefinitionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommissionDefinitionSLVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionSLVMQueryView>("c3960abe-139b-4796-90ee-2bea6bf26474","","",false, this);
 
            Agent = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "05673858-3f60-4884-8287-06ad63114645","","",this);
 
            CommercialAgentSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMQueryView>("898a5328-be99-48e8-9391-2d4363ceed55","","",false, this);
 
            AgentGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "c2f754a6-7bc4-4c9b-98ae-7ebb3ab9e9ef","","",this);
 
            CommercialAgentCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMQueryView>("d283fcc9-27d6-464d-80b7-831af0818c10","","",false, this);
 
            GenericAgent = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "43bc89b5-eebe-47f4-84f0-7934fcce49f8","","",this);
 
            Customer = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "0b75a05d-8303-4a00-add1-6c9b9c57bdfc","","",this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMQueryView>("5d95a389-0163-4bc8-9d0d-8611d7a7b888","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "fe64fad2-aacd-4db1-b506-67f431cd62a9","","",this);
 
            CustomerCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMQueryView>("a79ffd58-9f10-4416-a449-cfb9321fe5d1","","",false, this);
 
            GenericCustomer = RPSControlFactory.CreateRPSOption<CommissionDefinitionSLVMQueryView>( "a37e910e-f3a8-4b33-a74e-6df4ea41b091","","",this);
 
            bProductLine = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionSLVMQueryView>("27028f19-f7aa-4669-abe8-8d60f930f699","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionSLVMQueryView>("39055cb5-86bb-4dae-b137-61192c92bef1","","",false, this);
 
            bProductFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionSLVMQueryView>("6d138379-fd8a-4150-ace9-a7ecdf22ec79","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionSLVMQueryView>("b6dc7812-0a05-4c5a-a04a-05b50a316d68","","",false, this);
 
            bProductSubFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionSLVMQueryView>("4d67b6af-ccf6-4d2c-bc4c-7d4850bd413c","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionSLVMQueryView>("7c29a07b-8a55-4d10-82fe-baf52dea54d4","","",false, this);
 
            bArticle = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionSLVMQueryView>("3a6a024f-b40c-4d16-9ac9-9e642b8908cd","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionSLVMQueryView>("09019fa1-1b87-44a4-9491-5b6347fd61e6","","",false, this);
 
            bAllArticles = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionSLVMQueryView>("08672799-b6d0-4b9c-918e-26b45163a01e","","",false, this);
 
            CollectionInit params_CommissionDefinitionConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d09bebb6-859f-498d-8389-1ef0cccac303",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionConsultCollectionEditor<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView>,CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView>( params_CommissionDefinitionConsult,this,Screen.CommissionDefinitionSLVMEntityView);
 

        }
        public IRPSButton<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommissionDefinitionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CommissionDefinitionSLVMQueryView> UIEffectiveDate { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> Agent { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMQueryView> CommercialAgentSL { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> AgentGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMQueryView> CommercialAgentCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> GenericAgent { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> Customer { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMQueryView> Customer1 { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> CustomerGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMQueryView> CustomerCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionSLVMQueryView> GenericCustomer { get; set; } 
        public IRPSCheckbox<CommissionDefinitionSLVMQueryView> bProductLine { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionSLVMQueryView> ProductLine { get; set; } 
        public IRPSCheckbox<CommissionDefinitionSLVMQueryView> bProductFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionSLVMQueryView> ProductFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionSLVMQueryView> bProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionSLVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionSLVMQueryView> bArticle { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionSLVMQueryView> Article { get; set; } 
        public IRPSCheckbox<CommissionDefinitionSLVMQueryView> bAllArticles { get; set; } 
        public CommissionDefinitionConsultCollectionEditor<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> CommissionDefinitionConsult { get; set; } 
        public CommissionDefinition Screen { get; set; }
        public CommissionDefinitionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionDefinitionConsultCollectionEditor<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView>:RPSCollectionEditor<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> where CommissionDefinitionSLVMQueryView : class, IView where CommissionDefinitionSLVMEntityView : class, IView
    {
        public  CommissionDefinitionConsultGridView<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommissionDefinitionConsultGridView <CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> :  RPSGridView<CommissionDefinitionSLVMQueryView,CommissionDefinitionSLVMEntityView> where CommissionDefinitionSLVMQueryView : class, IView where CommissionDefinitionSLVMEntityView : class, IView
    {
        public CommissionDefinitionConsultGridView(CommissionDefinitionSLVMQueryView currentView,CommissionDefinitionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommissionDefinitionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionSLVMQueryView>("","#d09bebb6-859f-498d-8389-1ef0cccac303 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionSL_DateTo']","",false, this.CurrentView);
 
            CommissionDefinitionSL_ItemType = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionSLVMQueryView>("","#d09bebb6-859f-498d-8389-1ef0cccac303 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionSL_ItemType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionSLVMQueryView> CommissionDefinitionSL_DateTo { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionSLVMQueryView> CommissionDefinitionSL_ItemType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionDefinitionSLVMEntityView : View
    {
        public CommissionDefinitionSLVMEntityView(CommissionDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommissionDefinitionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionSLVMEntityView,CommissionDefinitionSLVMQueryView>( this,Screen.CommissionDefinitionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionSLVMEntityView,CommissionDefinitionSLVMQueryView>( this,Screen.CommissionDefinitionSLVMQueryView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("96fe0d33-d886-459b-9fbe-34e0271e06e5","","",false, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("6ac149d6-eb3e-433a-b100-0573ce68eb10","","",false, this);
 
            IDCommercialAgentCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("7df7bd3d-c312-46d8-b375-d9a4eac1585a","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("c86ae543-c699-41b4-a515-d3964586b77b","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("a20238c2-62dc-4774-9447-d7087d14df0b","","",false, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionSLVMEntityView>("9135fc9c-ef24-4506-bdc3-c350c299509b","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("0406f996-d0c6-4df9-9536-c9de5e944e62","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("f67e0406-2730-4334-b91f-8d9a2214ebfd","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("13c58f86-5ac5-4e6c-a481-515b5a08b79b","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionSLVMEntityView>("ed200945-7959-45b5-ae91-c2e62d2bfa86","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionSLVMEntityView>("c730febd-65be-4e5b-bc0d-f0c8fe827d95","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionSLVMEntityView>("12331e41-51f0-4bfa-867e-82ed0781cd7b","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionSLVMEntityView>("e4aa5b23-00a6-4c75-8000-36690ba2d95c","","",false, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionSLVMEntityView>("5d04b6c4-9358-442a-b323-ae5e2f8c2544","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionSLVMEntityView>("0466825b-958c-40a1-b04b-6fe891d9042b","","",true, this);
 

        }
        public IRPSSaveButton<CommissionDefinitionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommissionDefinitionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionSLVMEntityView,CommissionDefinitionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionSLVMEntityView,CommissionDefinitionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDCommercialAgentCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<CommissionDefinitionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionDefinitionSLVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<CommissionDefinitionSLVMEntityView> Type { get; set; } 
        public IRPSTextBox<CommissionDefinitionSLVMEntityView> Commission { get; set; } 
        public IRPSTextBox<CommissionDefinitionSLVMEntityView> CommissionAmount { get; set; } 
        public CommissionDefinition Screen { get; set; }
        public CommissionDefinitionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}