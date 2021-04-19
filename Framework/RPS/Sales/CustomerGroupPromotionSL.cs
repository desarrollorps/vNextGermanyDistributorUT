    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerGroupPromotionSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerGroupPromotionSL:Screen
    {
        public CustomerGroupPromotionSL():base()
        {
            this.URL = "sales.customergrouppromotionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerGroupPromotionSLVMQueryView  = new CustomerGroupPromotionSLVMQueryView(this); 
            CustomerGroupPromotionSLVMEntityView  = new CustomerGroupPromotionSLVMEntityView(this); 
            CustomerGroupPromotionDetailSLView  = new CustomerGroupPromotionDetailSLView(this); 
            CustomerGroupPromotionDetailArticleSLView  = new CustomerGroupPromotionDetailArticleSLView(this); 
            CustomerGroupPromotionDetailGiftSLView  = new CustomerGroupPromotionDetailGiftSLView(this); 
            CustomerGroupPromotionSLVMQueryView.InitializeControls(); 
            CustomerGroupPromotionSLVMEntityView.InitializeControls(); 
            CustomerGroupPromotionDetailSLView.InitializeControls(); 
            CustomerGroupPromotionDetailArticleSLView.InitializeControls(); 
            CustomerGroupPromotionDetailGiftSLView.InitializeControls(); 
           
        }
      
            public CustomerGroupPromotionSLVMQueryView CustomerGroupPromotionSLVMQueryView {get; set; } 
            public CustomerGroupPromotionSLVMEntityView CustomerGroupPromotionSLVMEntityView {get; set; } 
            public CustomerGroupPromotionDetailSLView CustomerGroupPromotionDetailSLView {get; set; } 
            public CustomerGroupPromotionDetailArticleSLView CustomerGroupPromotionDetailArticleSLView {get; set; } 
            public CustomerGroupPromotionDetailGiftSLView CustomerGroupPromotionDetailGiftSLView {get; set; } 
    }
            
    public partial class CustomerGroupPromotionSLVMQueryView : View
    {
        public CustomerGroupPromotionSLVMQueryView(CustomerGroupPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView>( this,Screen.CustomerGroupPromotionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CustomerGroupPromotionSLVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionSLVMQueryView>("8ea17861-1a49-49ed-af21-b19d027f55db","","",false, this);
 
            CustomerGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<CustomerGroupPromotionSLVMQueryView>("d69063b9-856a-4dde-8a0d-5de917e431bd","","",false, this);
 
            CollectionInit params_CustomerGroupPromotion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6e1ed33a-9388-468c-b6c5-22acc06c5715",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupPromotion = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupPromotionCollectionEditor<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView>,CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView>( params_CustomerGroupPromotion,this,Screen.CustomerGroupPromotionSLVMEntityView);
 

        }
        public IRPSButton<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMQueryView> UIEffectiveDate { get; set; } 
        public IRPSCollectionComboBox<CustomerGroupPromotionSLVMQueryView> CustomerGroupSL { get; set; } 
        public CustomerGroupPromotionCollectionEditor<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> CustomerGroupPromotion { get; set; } 
        public CustomerGroupPromotionSL Screen { get; set; }
        public CustomerGroupPromotionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupPromotionCollectionEditor<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView>:RPSCollectionEditor<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> where CustomerGroupPromotionSLVMQueryView : class, IView where CustomerGroupPromotionSLVMEntityView : class, IView
    {
        public  CustomerGroupPromotionGridView<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerGroupPromotionGridView <CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> :  RPSGridView<CustomerGroupPromotionSLVMQueryView,CustomerGroupPromotionSLVMEntityView> where CustomerGroupPromotionSLVMQueryView : class, IView where CustomerGroupPromotionSLVMEntityView : class, IView
    {
        public CustomerGroupPromotionGridView(CustomerGroupPromotionSLVMQueryView currentView,CustomerGroupPromotionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerGroupPromotionSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupPromotionSLVMQueryView>("","#6e1ed33a-9388-468c-b6c5-22acc06c5715 .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupPromotionSL_DateFrom']","",false, this.CurrentView);
 
            CustomerGroupPromotionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupPromotionSLVMQueryView>("","#6e1ed33a-9388-468c-b6c5-22acc06c5715 .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupPromotionSL_DateTo']","",false, this.CurrentView);
 
            CustomerGroupPromotionSL_Order = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupPromotionSLVMQueryView>("","#6e1ed33a-9388-468c-b6c5-22acc06c5715 .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupPromotionSL_Order']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerGroupPromotionSLVMQueryView> CustomerGroupPromotionSL_DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionSLVMQueryView> CustomerGroupPromotionSL_DateTo { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionSLVMQueryView> CustomerGroupPromotionSL_Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupPromotionSLVMEntityView : View
    {
        public CustomerGroupPromotionSLVMEntityView(CustomerGroupPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerGroupPromotionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupPromotionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionSLVMQueryView>( this,Screen.CustomerGroupPromotionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionSLVMQueryView>( this,Screen.CustomerGroupPromotionSLVMQueryView);
 
            IDCustomerGroupSL = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionSLVMEntityView>("681defbe-6058-4924-90b1-ef3f99934e97","","",true, this);
 
            IDCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionSLVMEntityView>("1696c979-c3af-428c-a50e-63da45f2f1d5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionSLVMEntityView>("e4892bc6-65c2-409e-b65b-0dc724fdfb9c","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupPromotionSLVMEntityView>("d217ac4b-e97e-4137-a79d-8a7584e9208d","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionSLVMEntityView>("fe85b59d-77f8-4b2b-b697-543110f5393f","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionSLVMEntityView>("4e7c6614-b73d-46c1-b6cf-0d85dcdac0e4","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionSLVMEntityView>("a2d56040-2aea-41ce-8662-f6a2680ed953","","",false, this);
 
            CollectionInit params_CustomerGroupPromotionDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2e255898-dd51-4d02-8ba0-961d2ae2790d",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupPromotionDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupPromotionDetailSLsCollectionEditor<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView>,CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView>( params_CustomerGroupPromotionDetailSLs,this,Screen.CustomerGroupPromotionDetailSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerGroupPromotionSLVMEntityView>( "","ul li[rpsid='2d9d6673-2099-44ae-aa53-be14ec7630a4']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerGroupPromotionSLVMEntityView>( "","ul li[rpsid='0dbefd75-4ac8-4e40-ac82-6f59f0e5da4a']","",this);
 

        }
        public IRPSSaveButton<CustomerGroupPromotionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionSLVMEntityView> IDCustomerGroupSL { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionSLVMEntityView> IDCustomerGroupValue { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMEntityView> Order { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMEntityView> DateTo { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionSLVMEntityView> Comment { get; set; } 
        public CustomerGroupPromotionDetailSLsCollectionEditor<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView> CustomerGroupPromotionDetailSLs { get; set; } 
        public IRPSSection<CustomerGroupPromotionSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerGroupPromotionSLVMEntityView> Comments { get; set; } 
        public CustomerGroupPromotionSL Screen { get; set; }
        public CustomerGroupPromotionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupPromotionDetailSLsCollectionEditor<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView>:RPSCollectionEditor<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView> where CustomerGroupPromotionSLVMEntityView : class, IView where CustomerGroupPromotionDetailSLView : class, IView
    {
        public  CustomerGroupPromotionDetailSLsGridView<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView> GridView {get;set;}
    }
    public partial class CustomerGroupPromotionDetailSLsGridView <CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView> :  RPSGridView<CustomerGroupPromotionSLVMEntityView,CustomerGroupPromotionDetailSLView> where CustomerGroupPromotionSLVMEntityView : class, IView where CustomerGroupPromotionDetailSLView : class, IView
    {
        public CustomerGroupPromotionDetailSLsGridView(CustomerGroupPromotionSLVMEntityView currentView,CustomerGroupPromotionDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            GiftType = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cGiftType']","",true, this.CurrentView);
 
            AllArticle = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cAllArticle']","",true, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 
            Proportional = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionSLVMEntityView>("","#2e255898-dd51-4d02-8ba0-961d2ae2790d .ag-row[role='row']@ROWINDEX [col-id='cProportional']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupPromotionSLVMEntityView> GiftType { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionSLVMEntityView> AllArticle { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionSLVMEntityView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionSLVMEntityView> Quantity { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionSLVMEntityView> HomogeneousSalesUnit { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionSLVMEntityView> Proportional { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupPromotionDetailSLView : View
    {
        public CustomerGroupPromotionDetailSLView(CustomerGroupPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupPromotionDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView>( this,Screen.CustomerGroupPromotionSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView>( this,Screen.CustomerGroupPromotionSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView>( this,Screen.CustomerGroupPromotionSLVMEntityView);
 
            GiftType = RPSControlFactory.CreateRPSEnumComboBox<CustomerGroupPromotionDetailSLView>("dbbdabd6-d95b-4448-85c3-0a85a2c635c3","","",true, this);
 
            AllArticle = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailSLView>("e01d0e2d-e9ce-4efc-8783-47380cb6a54e","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailSLView>("d1aa17e9-c6ed-4dbd-88ca-1f357dd0e7f1","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailSLView>("9341b70a-2dcb-4451-8619-93a0621cb2fc","","",false, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailSLView>("1d186a5c-ab29-46d3-a5bf-ed01f1686f16","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupPromotionDetailSLView>("33677768-fdd0-4155-8a76-4489b6fb5067","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailSLView>("875d95ad-aa61-4223-9660-ec61c99a1192","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailSLView>("add08a4e-e854-4b8e-8621-336e00f6fe2b","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerGroupPromotionDetailSLView>("c8a38a49-ca36-41fe-bff4-2f49628c8c8f","","",false, this);
 
            CollectionInit params_CustomerGroupPromotionDetailArticleSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2cc1ca8d-7aa8-45b1-87f8-757f43739ff2",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupPromotionDetailArticleSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupPromotionDetailArticleSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>,CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>( params_CustomerGroupPromotionDetailArticleSLs,this,Screen.CustomerGroupPromotionDetailArticleSLView);
 
            CollectionInit params_CustomerGroupPromotionDetailGiftSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dc5c5861-d577-4ca2-bb72-82a220f7f35f",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupPromotionDetailGiftSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupPromotionDetailGiftSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>,CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>( params_CustomerGroupPromotionDetailGiftSLs,this,Screen.CustomerGroupPromotionDetailArticleSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerGroupPromotionDetailSLView>( "","ul li[rpsid='00721c89-af51-4db0-8955-0720700912e9']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerGroupPromotionDetailSLView>( "","ul li[rpsid='ac55f372-2983-47ab-8239-b0fee7977939']","",this);
 

        }
        public IRPSButton<CustomerGroupPromotionDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionSLVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailSLView> GiftType { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailSLView> AllArticle { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailSLView> Proportional { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailSLView> TotalQuantity { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionDetailSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionDetailSLView> Comment { get; set; } 
        public CustomerGroupPromotionDetailArticleSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> CustomerGroupPromotionDetailArticleSLs { get; set; } 
        public CustomerGroupPromotionDetailGiftSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> CustomerGroupPromotionDetailGiftSLs { get; set; } 
        public IRPSSection<CustomerGroupPromotionDetailSLView> GeneralData { get; set; } 
        public IRPSSection<CustomerGroupPromotionDetailSLView> Comments { get; set; } 
        public CustomerGroupPromotionSL Screen { get; set; }
        public CustomerGroupPromotionDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupPromotionDetailArticleSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>:RPSCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> where CustomerGroupPromotionDetailSLView : class, IView where CustomerGroupPromotionDetailArticleSLView : class, IView
    {
        public  CustomerGroupPromotionDetailArticleSLsGridView<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class CustomerGroupPromotionDetailArticleSLsGridView <CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> :  RPSGridView<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> where CustomerGroupPromotionDetailSLView : class, IView where CustomerGroupPromotionDetailArticleSLView : class, IView
    {
        public CustomerGroupPromotionDetailArticleSLsGridView(CustomerGroupPromotionDetailSLView currentView,CustomerGroupPromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupPromotionDetailSLView>("","#2cc1ca8d-7aa8-45b1-87f8-757f43739ff2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupPromotionDetailSLView>("","#2cc1ca8d-7aa8-45b1-87f8-757f43739ff2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupPromotionDetailSLView>("","#2cc1ca8d-7aa8-45b1-87f8-757f43739ff2 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionDetailSLView>("","#2cc1ca8d-7aa8-45b1-87f8-757f43739ff2 .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupPromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridComboBox<CustomerGroupPromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
                     
    }
 
        public partial class CustomerGroupPromotionDetailGiftSLsCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView>:RPSCollectionEditor<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> where CustomerGroupPromotionDetailSLView : class, IView where CustomerGroupPromotionDetailArticleSLView : class, IView
    {
        public  CustomerGroupPromotionDetailGiftSLsGridView<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class CustomerGroupPromotionDetailGiftSLsGridView <CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> :  RPSGridView<CustomerGroupPromotionDetailSLView,CustomerGroupPromotionDetailArticleSLView> where CustomerGroupPromotionDetailSLView : class, IView where CustomerGroupPromotionDetailArticleSLView : class, IView
    {
        public CustomerGroupPromotionDetailGiftSLsGridView(CustomerGroupPromotionDetailSLView currentView,CustomerGroupPromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupPromotionDetailSLView>("","#dc5c5861-d577-4ca2-bb72-82a220f7f35f .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupPromotionDetailSLView>("","#dc5c5861-d577-4ca2-bb72-82a220f7f35f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupPromotionDetailSLView>("","#dc5c5861-d577-4ca2-bb72-82a220f7f35f .ag-row[role='row']@ROWINDEX [col-id='cGiftPriceFixed']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupPromotionDetailSLView>("","#dc5c5861-d577-4ca2-bb72-82a220f7f35f .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupPromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridCheckbox<CustomerGroupPromotionDetailSLView> GiftPriceFixed { get; set; } 
        public IRPSGridTextBox<CustomerGroupPromotionDetailSLView> Price { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupPromotionDetailArticleSLView : View
    {
        public CustomerGroupPromotionDetailArticleSLView(CustomerGroupPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupPromotionDetailArticleSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailArticleSLView>("cc8bbf60-c12c-4bda-acf6-e376b0434d9a","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupPromotionDetailArticleSLView>("65cee113-fcdf-43e4-a541-4d8971ffc372","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailArticleSLView>("a124d547-b0c7-4c03-b66f-fd43b908066e","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailArticleSLView>("c25bcd5a-3fda-4f04-9986-674ca9e14920","","",true, this);
 

        }
        public IRPSButton<CustomerGroupPromotionDetailArticleSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupPromotionDetailArticleSLView,CustomerGroupPromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailArticleSLView> IDArticle { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionDetailArticleSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailArticleSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailArticleSLView> HomogeneousSalesUnit { get; set; } 
        public CustomerGroupPromotionSL Screen { get; set; }
        public CustomerGroupPromotionDetailArticleSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerGroupPromotionDetailGiftSLView : View
    {
        public CustomerGroupPromotionDetailGiftSLView(CustomerGroupPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupPromotionDetailGiftSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView>( this,Screen.CustomerGroupPromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailGiftSLView>("f354a6b5-a36f-4d5b-9eed-69357f30baed","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupPromotionDetailGiftSLView>("ebb5add6-fb10-44d8-9824-ed3e2fb8b301","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailGiftSLView>("27ba51ba-6715-4c39-8994-77f28dfa3a88","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailGiftSLView>("8edff10d-2c04-4bf3-a54c-db0d62b2a54f","","",false, this);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailGiftSLView>("c447bf2e-395c-42c3-a5f4-f0eeae7bbe4d","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupPromotionDetailGiftSLView>("526925a1-a01b-4d3b-a4d3-fcb54485d8e5","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerGroupPromotionDetailGiftSLView>("e3b71f34-1e2c-4315-93de-15e33fe93245","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailGiftSLView>("bda36666-b93b-4285-bc22-ce7c15bf4223","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailGiftSLView>("88079536-57cc-4846-9acf-0f15b6cae83a","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerGroupPromotionDetailGiftSLView>("8467a7da-3d1d-443f-bb35-f4d2313160fb","","",true, this);
 

        }
        public IRPSButton<CustomerGroupPromotionDetailGiftSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupPromotionDetailGiftSLView,CustomerGroupPromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailGiftSLView> IDArticle { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionDetailGiftSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailGiftSLView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailGiftSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailGiftSLView> GiftPriceFixed { get; set; } 
        public IRPSTextBox<CustomerGroupPromotionDetailGiftSLView> Price { get; set; } 
        public IRPSComboBox<CustomerGroupPromotionDetailGiftSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailGiftSLView> Rappel { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailGiftSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<CustomerGroupPromotionDetailGiftSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public CustomerGroupPromotionSL Screen { get; set; }
        public CustomerGroupPromotionDetailGiftSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}