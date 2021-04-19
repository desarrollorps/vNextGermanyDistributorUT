    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionSL:Screen
    {
        public CommissionSL():base()
        {
            this.URL = "sales.commissionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionSLVMQueryView  = new CommissionSLVMQueryView(this); 
            CommissionSLVMEntityView  = new CommissionSLVMEntityView(this); 
            CommissionSLVMQueryView.InitializeControls(); 
            CommissionSLVMEntityView.InitializeControls(); 
           
        }
      
            public CommissionSLVMQueryView CommissionSLVMQueryView {get; set; } 
            public CommissionSLVMEntityView CommissionSLVMEntityView {get; set; } 
    }
            
    public partial class CommissionSLVMQueryView : View
    {
        public CommissionSLVMQueryView(CommissionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommissionSLVMQueryView,CommissionSLVMEntityView>( this,Screen.CommissionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommissionSLVMQueryView>( this);
 
            CommercialAgentSL2 = RPSControlFactory.CreateRPSCollectionComboBox<CommissionSLVMQueryView>("7f9c00c3-edf6-453c-97ed-a0e45ace8225","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionSLVMQueryView>("89454e59-19cf-4fac-a112-a3f93ca811d2","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommissionSLVMQueryView>("2b631304-eff0-443f-bdf1-600aa9d17a59","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<CommissionSLVMQueryView>("50819afe-0f68-4e94-98f9-dccc206d0104","","",false, this);
 
            InvoiceSL = RPSControlFactory.CreateRPSCollectionComboBox<CommissionSLVMQueryView>("e6e90448-fcb0-4657-b125-09301754a4bd","","",false, this);
 
            Pending = RPSControlFactory.CreateRPSOption<CommissionSLVMQueryView>( "ac8f000f-e049-4022-8d8e-c0b052a8e798","","",this);
 
            Calculated = RPSControlFactory.CreateRPSOption<CommissionSLVMQueryView>( "7a08b97d-1ce6-4373-b1bb-071dc789383a","","",this);
 
            Liquidated = RPSControlFactory.CreateRPSOption<CommissionSLVMQueryView>( "7c1b1147-0dbe-4c21-bb36-3d01a4a999ac","","",this);
 
            CollectionInit params_CommissionSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="87c221f5-e0d9-4ad4-8fc4-987848d57bbd",CSSSelectorGrid="",XPathGrid=""};
            CommissionSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionSLConsultCollectionEditor<CommissionSLVMQueryView,CommissionSLVMEntityView>,CommissionSLVMQueryView,CommissionSLVMEntityView>( params_CommissionSLConsult,this,Screen.CommissionSLVMEntityView);
 

        }
        public IRPSButton<CommissionSLVMQueryView,CommissionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommissionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<CommissionSLVMQueryView> CommercialAgentSL2 { get; set; } 
        public IRPSTextBox<CommissionSLVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionSLVMQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<CommissionSLVMQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<CommissionSLVMQueryView> InvoiceSL { get; set; } 
        public IRPSOption<CommissionSLVMQueryView> Pending { get; set; } 
        public IRPSOption<CommissionSLVMQueryView> Calculated { get; set; } 
        public IRPSOption<CommissionSLVMQueryView> Liquidated { get; set; } 
        public CommissionSLConsultCollectionEditor<CommissionSLVMQueryView,CommissionSLVMEntityView> CommissionSLConsult { get; set; } 
        public CommissionSL Screen { get; set; }
        public CommissionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionSLConsultCollectionEditor<CommissionSLVMQueryView,CommissionSLVMEntityView>:RPSCollectionEditor<CommissionSLVMQueryView,CommissionSLVMEntityView> where CommissionSLVMQueryView : class, IView where CommissionSLVMEntityView : class, IView
    {
        public  CommissionSLConsultGridView<CommissionSLVMQueryView,CommissionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommissionSLConsultGridView <CommissionSLVMQueryView,CommissionSLVMEntityView> :  RPSGridView<CommissionSLVMQueryView,CommissionSLVMEntityView> where CommissionSLVMQueryView : class, IView where CommissionSLVMEntityView : class, IView
    {
        public CommissionSLConsultGridView(CommissionSLVMQueryView currentView,CommissionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommissionSL_Date = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_Date']","",false, this.CurrentView);
 
            CommissionSL_Status = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_Status']","",false, this.CurrentView);
 
            CommissionSL_TotalInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_TotalInvoice']","",false, this.CurrentView);
 
            CommissionSL_AmountBase = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_AmountBase']","",false, this.CurrentView);
 
            CommissionSL_CommissionPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_CommissionPercentage']","",false, this.CurrentView);
 
            CommissionSL_Type = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_Type']","",false, this.CurrentView);
 
            CommissionSL_AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_AmountCommission']","",false, this.CurrentView);
 
            CommissionSL_DescObjective = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMQueryView>("","#87c221f5-e0d9-4ad4-8fc4-987848d57bbd .ag-row[role='row']@ROWINDEX [col-id='cCommissionSL_DescObjective']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_Date { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_Status { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_TotalInvoice { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_AmountBase { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_CommissionPercentage { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_Type { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_AmountCommission { get; set; } 
        public IRPSGridTextBox<CommissionSLVMQueryView> CommissionSL_DescObjective { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionSLVMEntityView : View
    {
        public CommissionSLVMEntityView(CommissionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommissionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionSLVMEntityView,CommissionSLVMQueryView>( this,Screen.CommissionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionSLVMEntityView,CommissionSLVMQueryView>( this,Screen.CommissionSLVMQueryView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CommissionSLVMEntityView>("0bb917a9-ff14-40db-9b4c-e25094fb8681","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CommissionSLVMEntityView>("a9a86da6-a366-42d6-95b4-337ff679ca1d","","",false, this);
 
            IDInvoice = RPSControlFactory.CreateRPSComboBox<CommissionSLVMEntityView>("c3b26e78-d5b5-461c-9378-7c6d9f08af24","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<CommissionSLVMEntityView>("241e7dfe-1ac9-4fa1-8363-b5eafaaba7ce","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<CommissionSLVMEntityView>("8906914d-746f-471a-b481-2d4bae2e65b4","","",true, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("13dbaf90-e359-4305-a1f2-a7d78c877d0f","","",true, this);
 
            AmountBase = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("4161cf04-3940-47f9-b763-2fa3df175932","","",true, this);
 
            CommissionPercentage = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("a25182ca-d947-4349-b30d-a41a4ae7c6bc","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("9691a208-4f8f-4124-980a-6c5b392e7e9e","","",true, this);
 
            AmountCommission = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("ffc98320-4bf5-4051-b04a-93cdfa1c0edb","","",true, this);
 
            AmountCollection = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("64fc39f0-1782-4773-9378-aa26b5545ea7","","",true, this);
 
            AmountUnpaid = RPSControlFactory.CreateRPSFormattedTextBox<CommissionSLVMEntityView>("6b992a1d-eda5-4e1a-9f88-40dcd35f9f1f","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CommissionSLVMEntityView>("987368bd-c069-4e00-8423-2bcf9b6f75ca","","",true, this);
 
            Withheld = RPSControlFactory.CreateRPSCheckBox<CommissionSLVMEntityView>("b24e3a95-d60a-4ca7-9a99-169c1a5aa915","","",true, this);
 
            IDCommissionDefinitionByObjectivePeriod = RPSControlFactory.CreateRPSComboBox<CommissionSLVMEntityView>("d609a64d-b7f4-47ed-a83a-d7704fe2ede3","","",false, this);
 
            DescObjective = RPSControlFactory.CreateRPSTextBox<CommissionSLVMEntityView>("81f1aba3-3aae-4c78-b50c-44474a744f80","","",false, this);
 
            CollectionInit params_GetInvoiceLinesCommercialAgentFromCommissionSL = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1029ee4d-e27d-4268-af0f-38176cf9720a",CSSSelectorGrid="",XPathGrid=""};
            GetInvoiceLinesCommercialAgentFromCommissionSL = RPSControlFactory.RPSCreateCollectionWithGrid<GetInvoiceLinesCommercialAgentFromCommissionSLCollectionEditor<CommissionSLVMEntityView>,CommissionSLVMEntityView>( params_GetInvoiceLinesCommercialAgentFromCommissionSL,this);
 
            CollectionInit params_CommissionLiquidatedSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ed3e8609-9bfc-4485-8928-23565e6c1a44",CSSSelectorGrid="",XPathGrid=""};
            CommissionLiquidatedSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionLiquidatedSLsCollectionEditor<CommissionSLVMEntityView>,CommissionSLVMEntityView>( params_CommissionLiquidatedSLs,this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CommissionSLVMEntityView>( "","ul li[rpsid='cb00f7b4-4ba7-4818-b90a-920d1a2ebb74']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<CommissionSLVMEntityView>( "","ul li[rpsid='0b34ac16-ebab-4144-85a7-0dcdbf206b54']","",this);
 

        }
        public IRPSSaveButton<CommissionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommissionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommissionSLVMEntityView,CommissionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionSLVMEntityView,CommissionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> IDInvoice { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> Date { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> Status { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> TotalInvoice { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> AmountBase { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> CommissionPercentage { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> CommissionAmount { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> AmountCommission { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> AmountCollection { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> AmountUnpaid { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> Type { get; set; } 
        public IRPSCheckbox<CommissionSLVMEntityView> Withheld { get; set; } 
        public IRPSComboBox<CommissionSLVMEntityView> IDCommissionDefinitionByObjectivePeriod { get; set; } 
        public IRPSTextBox<CommissionSLVMEntityView> DescObjective { get; set; } 
        public GetInvoiceLinesCommercialAgentFromCommissionSLCollectionEditor<CommissionSLVMEntityView> GetInvoiceLinesCommercialAgentFromCommissionSL { get; set; } 
        public CommissionLiquidatedSLsCollectionEditor<CommissionSLVMEntityView> CommissionLiquidatedSLs { get; set; } 
        public IRPSSection<CommissionSLVMEntityView> Section1 { get; set; } 
        public IRPSSection<CommissionSLVMEntityView> Section2 { get; set; } 
        public CommissionSL Screen { get; set; }
        public CommissionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetInvoiceLinesCommercialAgentFromCommissionSLCollectionEditor<CommissionSLVMEntityView>:RPSCollectionEditor<CommissionSLVMEntityView> where CommissionSLVMEntityView : class, IView
    {
        public  GetInvoiceLinesCommercialAgentFromCommissionSLGridView<CommissionSLVMEntityView> GridView {get;set;}
    }
    public partial class GetInvoiceLinesCommercialAgentFromCommissionSLGridView <CommissionSLVMEntityView> :  RPSGridView<CommissionSLVMEntityView> where CommissionSLVMEntityView : class, IView
    {
        public GetInvoiceLinesCommercialAgentFromCommissionSLGridView(CommissionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommercialAgentClassificationSL1 = RPSControlFactory.CreateRPSGridComboBox<CommissionSLVMEntityView>("","#1029ee4d-e27d-4268-af0f-38176cf9720a .ag-row[role='row']@ROWINDEX [col-id='cCommercialAgentClassificationSL1']","",false, this.CurrentView);
 
            InvoiceLineCommercialAgentSL_Base = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMEntityView>("","#1029ee4d-e27d-4268-af0f-38176cf9720a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineCommercialAgentSL_Base']","",false, this.CurrentView);
 
            InvoiceLineCommercialAgentSL_Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMEntityView>("","#1029ee4d-e27d-4268-af0f-38176cf9720a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineCommercialAgentSL_Commission']","",false, this.CurrentView);
 
            InvoiceLineCommercialAgentSL_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMEntityView>("","#1029ee4d-e27d-4268-af0f-38176cf9720a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineCommercialAgentSL_Amount']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommissionSLVMEntityView> CommercialAgentClassificationSL1 { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> InvoiceLineCommercialAgentSL_Base { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> InvoiceLineCommercialAgentSL_Commission { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> InvoiceLineCommercialAgentSL_Amount { get; set; } 
                     
    }
 
        public partial class CommissionLiquidatedSLsCollectionEditor<CommissionSLVMEntityView>:RPSCollectionEditor<CommissionSLVMEntityView> where CommissionSLVMEntityView : class, IView
    {
        public  CommissionLiquidatedSLsGridView<CommissionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommissionLiquidatedSLsGridView <CommissionSLVMEntityView> :  RPSGridView<CommissionSLVMEntityView> where CommissionSLVMEntityView : class, IView
    {
        public CommissionLiquidatedSLsGridView(CommissionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LiquidatedDate = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMEntityView>("","#ed3e8609-9bfc-4485-8928-23565e6c1a44 .ag-row[role='row']@ROWINDEX [col-id='cLiquidatedDate']","",true, this.CurrentView);
 
            AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMEntityView>("","#ed3e8609-9bfc-4485-8928-23565e6c1a44 .ag-row[role='row']@ROWINDEX [col-id='cAmountCommission']","",true, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<CommissionSLVMEntityView>("","#ed3e8609-9bfc-4485-8928-23565e6c1a44 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            AmountCollection = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionSLVMEntityView>("","#ed3e8609-9bfc-4485-8928-23565e6c1a44 .ag-row[role='row']@ROWINDEX [col-id='cAmountCollection']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionSLVMEntityView> LiquidatedDate { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> AmountCommission { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> CodOrder { get; set; } 
        public IRPSGridTextBox<CommissionSLVMEntityView> AmountCollection { get; set; } 
                     
    }
 
    }
  
    

}