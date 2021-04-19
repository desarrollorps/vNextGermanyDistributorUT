    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.ModelVoucherType
{
    //RPS VERSION 1.0.0.0
    public partial class ModelVoucherType:Screen
    {
        public ModelVoucherType():base()
        {
            this.URL = "taxmodel.modelvouchertype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ModelVoucherTypeView  = new ModelVoucherTypeView(this); 
            ModelVoucherTypeView.InitializeControls(); 
           
        }
      
            public ModelVoucherTypeView ModelVoucherTypeView {get; set; } 
    }
            
    public partial class ModelVoucherTypeView : View
    {
        public ModelVoucherTypeView(ModelVoucherType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveCommandButton = RPSControlFactory.CreateRPSButton<ModelVoucherTypeView>( "d2f2b618-edad-462c-bdb3-dda698688b6a","","",this);
 
            CollectionInit params_GetVoucherTypePurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4efb52c4-ef15-437a-837f-5f7c6886fef3",CSSSelectorGrid="",XPathGrid=""};
            GetVoucherTypePurchases = RPSControlFactory.RPSCreateCollectionWithGrid<GetVoucherTypePurchasesCollectionEditor<ModelVoucherTypeView>,ModelVoucherTypeView>( params_GetVoucherTypePurchases,this);
 
            CollectionInit params_GetVoucherTypeSales = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="212faf35-ae62-435b-a6f4-cec6c7c55514",CSSSelectorGrid="",XPathGrid=""};
            GetVoucherTypeSales = RPSControlFactory.RPSCreateCollectionWithGrid<GetVoucherTypeSalesCollectionEditor<ModelVoucherTypeView>,ModelVoucherTypeView>( params_GetVoucherTypeSales,this);
 
            VoucherTypePurchases = RPSControlFactory.CreateRPSSection<ModelVoucherTypeView>( "","ul li[rpsid='6ef29450-c50f-4f5d-9bab-32a81d832254']","",this);
 
            VoucherTypeSales = RPSControlFactory.CreateRPSSection<ModelVoucherTypeView>( "","ul li[rpsid='c7961177-0038-44a7-bad9-357b36c80df3']","",this);
 

        }
        public IRPSButton<ModelVoucherTypeView> SaveCommandButton { get; set; } 
        public GetVoucherTypePurchasesCollectionEditor<ModelVoucherTypeView> GetVoucherTypePurchases { get; set; } 
        public GetVoucherTypeSalesCollectionEditor<ModelVoucherTypeView> GetVoucherTypeSales { get; set; } 
        public IRPSSection<ModelVoucherTypeView> VoucherTypePurchases { get; set; } 
        public IRPSSection<ModelVoucherTypeView> VoucherTypeSales { get; set; } 
        public ModelVoucherType Screen { get; set; }
        public ModelVoucherTypeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVoucherTypePurchasesCollectionEditor<ModelVoucherTypeView>:RPSCollectionEditor<ModelVoucherTypeView> where ModelVoucherTypeView : class, IView
    {
        public  GetVoucherTypePurchasesGridView<ModelVoucherTypeView> GridView {get;set;}
    }
    public partial class GetVoucherTypePurchasesGridView <ModelVoucherTypeView> :  RPSGridView<ModelVoucherTypeView> where ModelVoucherTypeView : class, IView
    {
        public GetVoucherTypePurchasesGridView(ModelVoucherTypeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherType_ACCArea = RPSControlFactory.CreateRPSGridTextBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_ACCArea']","",false, this.CurrentView);
 
            VoucherType_IsImport = RPSControlFactory.CreateRPSGridCheckBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_IsImport']","",false, this.CurrentView);
 
            VoucherType_OperationType = RPSControlFactory.CreateRPSGridTextBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_OperationType']","",false, this.CurrentView);
 
            VoucherType_IsATicket = RPSControlFactory.CreateRPSGridCheckBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_IsATicket']","",false, this.CurrentView);
 
            VoucherType_ExcludeSII = RPSControlFactory.CreateRPSGridCheckBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_ExcludeSII']","",false, this.CurrentView);
 
            OptionUsage347 = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cOptionUsage347']","",false, this.CurrentView);
 
            OptionUsage349 = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVoucherTypeView>("","#4efb52c4-ef15-437a-837f-5f7c6886fef3 .ag-row[role='row']@ROWINDEX [col-id='cOptionUsage349']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ModelVoucherTypeView> VoucherType_ACCArea { get; set; } 
        public IRPSGridCheckbox<ModelVoucherTypeView> VoucherType_IsImport { get; set; } 
        public IRPSGridTextBox<ModelVoucherTypeView> VoucherType_OperationType { get; set; } 
        public IRPSGridCheckbox<ModelVoucherTypeView> VoucherType_IsATicket { get; set; } 
        public IRPSGridCheckbox<ModelVoucherTypeView> VoucherType_ExcludeSII { get; set; } 
        public IRPSGridComboBox<ModelVoucherTypeView> OptionUsage347 { get; set; } 
        public IRPSGridComboBox<ModelVoucherTypeView> OptionUsage349 { get; set; } 
                     
    }
 
        public partial class GetVoucherTypeSalesCollectionEditor<ModelVoucherTypeView>:RPSCollectionEditor<ModelVoucherTypeView> where ModelVoucherTypeView : class, IView
    {
        public  GetVoucherTypeSalesGridView<ModelVoucherTypeView> GridView {get;set;}
    }
    public partial class GetVoucherTypeSalesGridView <ModelVoucherTypeView> :  RPSGridView<ModelVoucherTypeView> where ModelVoucherTypeView : class, IView
    {
        public GetVoucherTypeSalesGridView(ModelVoucherTypeView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherType_OperationType = RPSControlFactory.CreateRPSGridTextBox<ModelVoucherTypeView>("","#212faf35-ae62-435b-a6f4-cec6c7c55514 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_OperationType']","",false, this.CurrentView);
 
            VoucherType_IsATicket = RPSControlFactory.CreateRPSGridCheckBox<ModelVoucherTypeView>("","#212faf35-ae62-435b-a6f4-cec6c7c55514 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_IsATicket']","",false, this.CurrentView);
 
            VoucherType_ExcludeSII = RPSControlFactory.CreateRPSGridCheckBox<ModelVoucherTypeView>("","#212faf35-ae62-435b-a6f4-cec6c7c55514 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType_ExcludeSII']","",false, this.CurrentView);
 
            Usage347 = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVoucherTypeView>("","#212faf35-ae62-435b-a6f4-cec6c7c55514 .ag-row[role='row']@ROWINDEX [col-id='ceUsage347']","",false, this.CurrentView);
 
            Usage349 = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVoucherTypeView>("","#212faf35-ae62-435b-a6f4-cec6c7c55514 .ag-row[role='row']@ROWINDEX [col-id='ceUsage349']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ModelVoucherTypeView> VoucherType_OperationType { get; set; } 
        public IRPSGridCheckbox<ModelVoucherTypeView> VoucherType_IsATicket { get; set; } 
        public IRPSGridCheckbox<ModelVoucherTypeView> VoucherType_ExcludeSII { get; set; } 
        public IRPSGridComboBox<ModelVoucherTypeView> Usage347 { get; set; } 
        public IRPSGridComboBox<ModelVoucherTypeView> Usage349 { get; set; } 
                     
    }
 
    }
  
    

}