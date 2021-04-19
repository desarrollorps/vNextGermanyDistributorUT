    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerPromotionSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerPromotionSL:Screen
    {
        public CustomerPromotionSL():base()
        {
            this.URL = "sales.customerpromotionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerPromotionSLVMQueryView  = new CustomerPromotionSLVMQueryView(this); 
            CustomerPromotionSLVMEntityView  = new CustomerPromotionSLVMEntityView(this); 
            CustomerPromotionDetailSLView  = new CustomerPromotionDetailSLView(this); 
            CustomerPromotionDetailArticleSLView  = new CustomerPromotionDetailArticleSLView(this); 
            CustomerPromotionDetailGiftSLView  = new CustomerPromotionDetailGiftSLView(this); 
            CustomerPromotionSLVMQueryView.InitializeControls(); 
            CustomerPromotionSLVMEntityView.InitializeControls(); 
            CustomerPromotionDetailSLView.InitializeControls(); 
            CustomerPromotionDetailArticleSLView.InitializeControls(); 
            CustomerPromotionDetailGiftSLView.InitializeControls(); 
           
        }
      
            public CustomerPromotionSLVMQueryView CustomerPromotionSLVMQueryView {get; set; } 
            public CustomerPromotionSLVMEntityView CustomerPromotionSLVMEntityView {get; set; } 
            public CustomerPromotionDetailSLView CustomerPromotionDetailSLView {get; set; } 
            public CustomerPromotionDetailArticleSLView CustomerPromotionDetailArticleSLView {get; set; } 
            public CustomerPromotionDetailGiftSLView CustomerPromotionDetailGiftSLView {get; set; } 
    }
            
    public partial class CustomerPromotionSLVMQueryView : View
    {
        public CustomerPromotionSLVMQueryView(CustomerPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView>( this,Screen.CustomerPromotionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CustomerPromotionSLVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<CustomerPromotionSLVMQueryView>("d71ad18a-a111-4ffe-9e5e-99ebd2b3ed5d","","",false, this);
 
            lsIDCustomers = RPSControlFactory.CreateRPSCollectionComboBox<CustomerPromotionSLVMQueryView>("0d688fe5-d415-4806-84ca-7399efca29ab","","",false, this);
 
            CollectionInit params_CustomerPromotion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5ec52d37-7407-4bcd-ad63-ce1ce8561ecf",CSSSelectorGrid="",XPathGrid=""};
            CustomerPromotion = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerPromotionCollectionEditor<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView>,CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView>( params_CustomerPromotion,this,Screen.CustomerPromotionSLVMEntityView);
 

        }
        public IRPSButton<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CustomerPromotionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMQueryView> UIEffectiveDate { get; set; } 
        public IRPSCollectionComboBox<CustomerPromotionSLVMQueryView> lsIDCustomers { get; set; } 
        public CustomerPromotionCollectionEditor<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> CustomerPromotion { get; set; } 
        public CustomerPromotionSL Screen { get; set; }
        public CustomerPromotionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerPromotionCollectionEditor<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView>:RPSCollectionEditor<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> where CustomerPromotionSLVMQueryView : class, IView where CustomerPromotionSLVMEntityView : class, IView
    {
        public  CustomerPromotionGridView<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerPromotionGridView <CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> :  RPSGridView<CustomerPromotionSLVMQueryView,CustomerPromotionSLVMEntityView> where CustomerPromotionSLVMQueryView : class, IView where CustomerPromotionSLVMEntityView : class, IView
    {
        public CustomerPromotionGridView(CustomerPromotionSLVMQueryView currentView,CustomerPromotionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerPromotionSL_Description = RPSControlFactory.CreateRPSGridTextBox<CustomerPromotionSLVMQueryView>("","#5ec52d37-7407-4bcd-ad63-ce1ce8561ecf .ag-row[role='row']@ROWINDEX [col-id='cCustomerPromotionSL_Description']","",false, this.CurrentView);
 
            CustomerPromotionSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerPromotionSLVMQueryView>("","#5ec52d37-7407-4bcd-ad63-ce1ce8561ecf .ag-row[role='row']@ROWINDEX [col-id='cCustomerPromotionSL_DateFrom']","",false, this.CurrentView);
 
            CustomerPromotionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerPromotionSLVMQueryView>("","#5ec52d37-7407-4bcd-ad63-ce1ce8561ecf .ag-row[role='row']@ROWINDEX [col-id='cCustomerPromotionSL_DateTo']","",false, this.CurrentView);
 
            CustomerPromotionSL_Order = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerPromotionSLVMQueryView>("","#5ec52d37-7407-4bcd-ad63-ce1ce8561ecf .ag-row[role='row']@ROWINDEX [col-id='cCustomerPromotionSL_Order']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerPromotionSLVMQueryView> CustomerPromotionSL_Description { get; set; } 
        public IRPSGridTextBox<CustomerPromotionSLVMQueryView> CustomerPromotionSL_DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerPromotionSLVMQueryView> CustomerPromotionSL_DateTo { get; set; } 
        public IRPSGridTextBox<CustomerPromotionSLVMQueryView> CustomerPromotionSL_Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerPromotionSLVMEntityView : View
    {
        public CustomerPromotionSLVMEntityView(CustomerPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerPromotionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerPromotionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerPromotionSLVMEntityView,CustomerPromotionSLVMQueryView>( this,Screen.CustomerPromotionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerPromotionSLVMEntityView,CustomerPromotionSLVMQueryView>( this,Screen.CustomerPromotionSLVMQueryView);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerPromotionSLVMEntityView>("f758665e-0b38-4118-a37e-d74b66d593c2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerPromotionSLVMEntityView>("32287a06-2f1a-4d65-b8bf-09fe4bb075a9","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<CustomerPromotionSLVMEntityView>("eb3c7f1b-d72e-4c20-aab1-c32c7bfb9439","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CustomerPromotionSLVMEntityView>("1bb350f9-89a5-4373-a6fd-dca28c9e9dfc","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CustomerPromotionSLVMEntityView>("ce18bae6-9eca-40c5-ac27-7f7cf9a2a608","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerPromotionSLVMEntityView>("b8199fce-58d1-4ef7-bea5-5150fd6b5b27","","",false, this);
 
            CollectionInit params_CustomerPromotionDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4bcd0f94-272f-48da-bb7d-39c9727cb584",CSSSelectorGrid="",XPathGrid=""};
            CustomerPromotionDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerPromotionDetailSLsCollectionEditor<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView>,CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView>( params_CustomerPromotionDetailSLs,this,Screen.CustomerPromotionDetailSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerPromotionSLVMEntityView>( "","ul li[rpsid='256ff679-34d2-4b56-8af1-c76352b5ed53']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerPromotionSLVMEntityView>( "","ul li[rpsid='249523ee-ef4a-405a-a064-3c3c4268087f']","",this);
 

        }
        public IRPSSaveButton<CustomerPromotionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerPromotionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionSLVMEntityView,CustomerPromotionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionSLVMEntityView,CustomerPromotionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CustomerPromotionSLVMEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMEntityView> Order { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMEntityView> DateTo { get; set; } 
        public IRPSTextBox<CustomerPromotionSLVMEntityView> Comment { get; set; } 
        public CustomerPromotionDetailSLsCollectionEditor<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView> CustomerPromotionDetailSLs { get; set; } 
        public IRPSSection<CustomerPromotionSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerPromotionSLVMEntityView> Comments { get; set; } 
        public CustomerPromotionSL Screen { get; set; }
        public CustomerPromotionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerPromotionDetailSLsCollectionEditor<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView>:RPSCollectionEditor<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView> where CustomerPromotionSLVMEntityView : class, IView where CustomerPromotionDetailSLView : class, IView
    {
        public  CustomerPromotionDetailSLsGridView<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView> GridView {get;set;}
    }
    public partial class CustomerPromotionDetailSLsGridView <CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView> :  RPSGridView<CustomerPromotionSLVMEntityView,CustomerPromotionDetailSLView> where CustomerPromotionSLVMEntityView : class, IView where CustomerPromotionDetailSLView : class, IView
    {
        public CustomerPromotionDetailSLsGridView(CustomerPromotionSLVMEntityView currentView,CustomerPromotionDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            GiftType = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cGiftType']","",true, this.CurrentView);
 
            AllArticle = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cAllArticle']","",true, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 
            Proportional = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionSLVMEntityView>("","#4bcd0f94-272f-48da-bb7d-39c9727cb584 .ag-row[role='row']@ROWINDEX [col-id='cProportional']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerPromotionSLVMEntityView> GiftType { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionSLVMEntityView> AllArticle { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionSLVMEntityView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<CustomerPromotionSLVMEntityView> Quantity { get; set; } 
        public IRPSGridComboBox<CustomerPromotionSLVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionSLVMEntityView> HomogeneousSalesUnit { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionSLVMEntityView> Proportional { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerPromotionDetailSLView : View
    {
        public CustomerPromotionDetailSLView(CustomerPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerPromotionDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView>( this,Screen.CustomerPromotionSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView>( this,Screen.CustomerPromotionSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView>( this,Screen.CustomerPromotionSLVMEntityView);
 
            GiftType = RPSControlFactory.CreateRPSEnumComboBox<CustomerPromotionDetailSLView>("b5da188c-4f31-47e4-9537-602fbd5c4ad1","","",true, this);
 
            AllArticle = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailSLView>("9f442bc7-99ca-46e9-b2df-3249ff373e04","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailSLView>("ba9e36b5-3ace-4346-b479-7f6e59bd70a2","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailSLView>("105db194-718d-47fb-ac2d-1f94beb9f5ac","","",false, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailSLView>("8ca29ea4-fb96-4981-ab64-9e0d8d63b7eb","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerPromotionDetailSLView>("6f45229e-41d1-4ef2-a3e0-4bde6a85b6a6","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailSLView>("2cb0b6d9-bc7e-4ad4-ab9d-46365748ec7e","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailSLView>("8f9648c2-d557-49c1-b0a2-1a52e974ff7b","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerPromotionDetailSLView>("615adea0-673a-4fac-be8f-d8866a1de126","","",false, this);
 
            CollectionInit params_CustomerPromotionDetailArticleSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c591c44d-5be6-4cd4-9bb8-1052fa007dbd",CSSSelectorGrid="",XPathGrid=""};
            CustomerPromotionDetailArticleSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerPromotionDetailArticleSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>,CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>( params_CustomerPromotionDetailArticleSLs,this,Screen.CustomerPromotionDetailArticleSLView);
 
            CollectionInit params_CustomerPromotionDetailGiftSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d706f08d-8b2f-4fea-ab38-bbac504db833",CSSSelectorGrid="",XPathGrid=""};
            CustomerPromotionDetailGiftSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerPromotionDetailGiftSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>,CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>( params_CustomerPromotionDetailGiftSLs,this,Screen.CustomerPromotionDetailArticleSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerPromotionDetailSLView>( "","ul li[rpsid='c3f33e36-e075-455a-bd6d-ef11ed29485f']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerPromotionDetailSLView>( "","ul li[rpsid='50685222-f1b2-4eaf-98f8-beea78ca2e6a']","",this);
 

        }
        public IRPSButton<CustomerPromotionDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerPromotionDetailSLView,CustomerPromotionSLVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailSLView> GiftType { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailSLView> AllArticle { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailSLView> Proportional { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailSLView> TotalQuantity { get; set; } 
        public IRPSTextBox<CustomerPromotionDetailSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
        public IRPSTextBox<CustomerPromotionDetailSLView> Comment { get; set; } 
        public CustomerPromotionDetailArticleSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> CustomerPromotionDetailArticleSLs { get; set; } 
        public CustomerPromotionDetailGiftSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> CustomerPromotionDetailGiftSLs { get; set; } 
        public IRPSSection<CustomerPromotionDetailSLView> GeneralData { get; set; } 
        public IRPSSection<CustomerPromotionDetailSLView> Comments { get; set; } 
        public CustomerPromotionSL Screen { get; set; }
        public CustomerPromotionDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerPromotionDetailArticleSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>:RPSCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> where CustomerPromotionDetailSLView : class, IView where CustomerPromotionDetailArticleSLView : class, IView
    {
        public  CustomerPromotionDetailArticleSLsGridView<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class CustomerPromotionDetailArticleSLsGridView <CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> :  RPSGridView<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> where CustomerPromotionDetailSLView : class, IView where CustomerPromotionDetailArticleSLView : class, IView
    {
        public CustomerPromotionDetailArticleSLsGridView(CustomerPromotionDetailSLView currentView,CustomerPromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionDetailSLView>("","#c591c44d-5be6-4cd4-9bb8-1052fa007dbd .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerPromotionDetailSLView>("","#c591c44d-5be6-4cd4-9bb8-1052fa007dbd .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionDetailSLView>("","#c591c44d-5be6-4cd4-9bb8-1052fa007dbd .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionDetailSLView>("","#c591c44d-5be6-4cd4-9bb8-1052fa007dbd .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerPromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<CustomerPromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridComboBox<CustomerPromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
                     
    }
 
        public partial class CustomerPromotionDetailGiftSLsCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView>:RPSCollectionEditor<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> where CustomerPromotionDetailSLView : class, IView where CustomerPromotionDetailArticleSLView : class, IView
    {
        public  CustomerPromotionDetailGiftSLsGridView<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class CustomerPromotionDetailGiftSLsGridView <CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> :  RPSGridView<CustomerPromotionDetailSLView,CustomerPromotionDetailArticleSLView> where CustomerPromotionDetailSLView : class, IView where CustomerPromotionDetailArticleSLView : class, IView
    {
        public CustomerPromotionDetailGiftSLsGridView(CustomerPromotionDetailSLView currentView,CustomerPromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSGridCheckBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cGiftPriceFixed']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDUnitPrice = RPSControlFactory.CreateRPSGridComboBox<CustomerPromotionDetailSLView>("","#d706f08d-8b2f-4fea-ab38-bbac504db833 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerPromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<CustomerPromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridComboBox<CustomerPromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<CustomerPromotionDetailSLView> GiftPriceFixed { get; set; } 
        public IRPSGridTextBox<CustomerPromotionDetailSLView> Price { get; set; } 
        public IRPSGridComboBox<CustomerPromotionDetailSLView> IDUnitPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerPromotionDetailArticleSLView : View
    {
        public CustomerPromotionDetailArticleSLView(CustomerPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerPromotionDetailArticleSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailArticleSLView>("54c8d03d-7649-48b6-8dd6-1d4203a18bb5","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerPromotionDetailArticleSLView>("7b19d035-2e75-4ba9-a032-8d7b95027d33","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailArticleSLView>("181bf51f-a7db-4942-84eb-efd3e44aacdf","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailArticleSLView>("4bb239ac-347e-4ae5-8aa2-c3c9ab6e8d74","","",true, this);
 

        }
        public IRPSButton<CustomerPromotionDetailArticleSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerPromotionDetailArticleSLView,CustomerPromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailArticleSLView> IDArticle { get; set; } 
        public IRPSTextBox<CustomerPromotionDetailArticleSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailArticleSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailArticleSLView> HomogeneousSalesUnit { get; set; } 
        public CustomerPromotionSL Screen { get; set; }
        public CustomerPromotionDetailArticleSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerPromotionDetailGiftSLView : View
    {
        public CustomerPromotionDetailGiftSLView(CustomerPromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerPromotionDetailGiftSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView>( this,Screen.CustomerPromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailGiftSLView>("5b675f13-cb72-4e22-8b3e-9fee86b33c3e","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerPromotionDetailGiftSLView>("de17c9e0-f31b-4b95-8976-d71f249cb25c","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailGiftSLView>("f8756295-a9d1-4462-a19c-0ac59dbbd60b","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailGiftSLView>("2df16615-cf20-4c6e-a610-ff0fc8c76d0c","","",false, this);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailGiftSLView>("7ffabb03-6a95-4d1b-98a2-ecd14f557564","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<CustomerPromotionDetailGiftSLView>("54c2bcb6-4445-477e-9078-c2fd031892de","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerPromotionDetailGiftSLView>("f9b7c65f-9272-4374-bf10-bceba4ed14ee","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailGiftSLView>("965ad398-6b95-4f77-9b07-16c542e56d14","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailGiftSLView>("f0109803-f9dc-4b7a-9bb6-3c2256a407d2","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerPromotionDetailGiftSLView>("5891039c-79e3-486d-84de-0d8a8dd7dd8f","","",true, this);
 

        }
        public IRPSButton<CustomerPromotionDetailGiftSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerPromotionDetailGiftSLView,CustomerPromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailGiftSLView> IDArticle { get; set; } 
        public IRPSTextBox<CustomerPromotionDetailGiftSLView> Quantity { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailGiftSLView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailGiftSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailGiftSLView> GiftPriceFixed { get; set; } 
        public IRPSTextBox<CustomerPromotionDetailGiftSLView> Price { get; set; } 
        public IRPSComboBox<CustomerPromotionDetailGiftSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailGiftSLView> Rappel { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailGiftSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<CustomerPromotionDetailGiftSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public CustomerPromotionSL Screen { get; set; }
        public CustomerPromotionDetailGiftSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}