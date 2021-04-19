    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PromotionSL
{
    //RPS VERSION 1.0.0.0
    public partial class PromotionSL:Screen
    {
        public PromotionSL():base()
        {
            this.URL = "sales.promotionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PromotionSLVMQueryView  = new PromotionSLVMQueryView(this); 
            PromotionSLVMEntityView  = new PromotionSLVMEntityView(this); 
            PromotionDetailSLView  = new PromotionDetailSLView(this); 
            PromotionDetailArticleSLView  = new PromotionDetailArticleSLView(this); 
            PromotionDetailGiftSLView  = new PromotionDetailGiftSLView(this); 
            PromotionSLVMQueryView.InitializeControls(); 
            PromotionSLVMEntityView.InitializeControls(); 
            PromotionDetailSLView.InitializeControls(); 
            PromotionDetailArticleSLView.InitializeControls(); 
            PromotionDetailGiftSLView.InitializeControls(); 
           
        }
      
            public PromotionSLVMQueryView PromotionSLVMQueryView {get; set; } 
            public PromotionSLVMEntityView PromotionSLVMEntityView {get; set; } 
            public PromotionDetailSLView PromotionDetailSLView {get; set; } 
            public PromotionDetailArticleSLView PromotionDetailArticleSLView {get; set; } 
            public PromotionDetailGiftSLView PromotionDetailGiftSLView {get; set; } 
    }
            
    public partial class PromotionSLVMQueryView : View
    {
        public PromotionSLVMQueryView(PromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PromotionSLVMQueryView,PromotionSLVMEntityView>( this,Screen.PromotionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<PromotionSLVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<PromotionSLVMQueryView>("afb3a084-e1ba-487c-ae73-2699fd2f51ae","","",false, this);
 
            CollectionInit params_Promotion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a93c7496-b300-49fa-a3e4-39657d044315",CSSSelectorGrid="",XPathGrid=""};
            Promotion = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionCollectionEditor<PromotionSLVMQueryView,PromotionSLVMEntityView>,PromotionSLVMQueryView,PromotionSLVMEntityView>( params_Promotion,this,Screen.PromotionSLVMEntityView);
 

        }
        public IRPSButton<PromotionSLVMQueryView,PromotionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<PromotionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<PromotionSLVMQueryView> UIEffectiveDate { get; set; } 
        public PromotionCollectionEditor<PromotionSLVMQueryView,PromotionSLVMEntityView> Promotion { get; set; } 
        public PromotionSL Screen { get; set; }
        public PromotionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PromotionCollectionEditor<PromotionSLVMQueryView,PromotionSLVMEntityView>:RPSCollectionEditor<PromotionSLVMQueryView,PromotionSLVMEntityView> where PromotionSLVMQueryView : class, IView where PromotionSLVMEntityView : class, IView
    {
        public  PromotionGridView<PromotionSLVMQueryView,PromotionSLVMEntityView> GridView {get;set;}
    }
    public partial class PromotionGridView <PromotionSLVMQueryView,PromotionSLVMEntityView> :  RPSGridView<PromotionSLVMQueryView,PromotionSLVMEntityView> where PromotionSLVMQueryView : class, IView where PromotionSLVMEntityView : class, IView
    {
        public PromotionGridView(PromotionSLVMQueryView currentView,PromotionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PromotionSL_Description = RPSControlFactory.CreateRPSGridTextBox<PromotionSLVMQueryView>("","#a93c7496-b300-49fa-a3e4-39657d044315 .ag-row[role='row']@ROWINDEX [col-id='cPromotionSL_Description']","",false, this.CurrentView);
 
            PromotionSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<PromotionSLVMQueryView>("","#a93c7496-b300-49fa-a3e4-39657d044315 .ag-row[role='row']@ROWINDEX [col-id='cPromotionSL_DateFrom']","",false, this.CurrentView);
 
            PromotionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<PromotionSLVMQueryView>("","#a93c7496-b300-49fa-a3e4-39657d044315 .ag-row[role='row']@ROWINDEX [col-id='cPromotionSL_DateTo']","",false, this.CurrentView);
 
            PromotionSL_Order = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionSLVMQueryView>("","#a93c7496-b300-49fa-a3e4-39657d044315 .ag-row[role='row']@ROWINDEX [col-id='cPromotionSL_Order']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PromotionSLVMQueryView> PromotionSL_Description { get; set; } 
        public IRPSGridTextBox<PromotionSLVMQueryView> PromotionSL_DateFrom { get; set; } 
        public IRPSGridTextBox<PromotionSLVMQueryView> PromotionSL_DateTo { get; set; } 
        public IRPSGridTextBox<PromotionSLVMQueryView> PromotionSL_Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class PromotionSLVMEntityView : View
    {
        public PromotionSLVMEntityView(PromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PromotionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionSLVMEntityView,PromotionSLVMQueryView>( this,Screen.PromotionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionSLVMEntityView,PromotionSLVMQueryView>( this,Screen.PromotionSLVMQueryView);
 
            Description = RPSControlFactory.CreateRPSTextBox<PromotionSLVMEntityView>("159c4611-92f1-45f0-9c52-f030d1013530","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<PromotionSLVMEntityView>("dbed041f-228c-43d6-aba5-e5f39a19c771","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<PromotionSLVMEntityView>("e512c9c5-c340-49a6-8119-d73fe30d1e6f","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<PromotionSLVMEntityView>("2ed13ee3-6778-4cd2-8adf-d31a47655378","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PromotionSLVMEntityView>("bd70e8df-9a83-46f5-8fa1-633796aa593c","","",false, this);
 
            CollectionInit params_PromotionDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8da022d1-268d-41b6-af8a-d21dc65514de",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailSLsCollectionEditor<PromotionSLVMEntityView,PromotionDetailSLView>,PromotionSLVMEntityView,PromotionDetailSLView>( params_PromotionDetailSLs,this,Screen.PromotionDetailSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PromotionSLVMEntityView>( "","ul li[rpsid='2f976b2c-196f-40e4-9627-a44e89903740']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<PromotionSLVMEntityView>( "","ul li[rpsid='b0b7d082-983b-4354-a6c2-01edebd5c167']","",this);
 

        }
        public IRPSSaveButton<PromotionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<PromotionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<PromotionSLVMEntityView,PromotionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionSLVMEntityView,PromotionSLVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<PromotionSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<PromotionSLVMEntityView> Order { get; set; } 
        public IRPSTextBox<PromotionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<PromotionSLVMEntityView> DateTo { get; set; } 
        public IRPSTextBox<PromotionSLVMEntityView> Comment { get; set; } 
        public PromotionDetailSLsCollectionEditor<PromotionSLVMEntityView,PromotionDetailSLView> PromotionDetailSLs { get; set; } 
        public IRPSSection<PromotionSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<PromotionSLVMEntityView> Comments { get; set; } 
        public PromotionSL Screen { get; set; }
        public PromotionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PromotionDetailSLsCollectionEditor<PromotionSLVMEntityView,PromotionDetailSLView>:RPSCollectionEditor<PromotionSLVMEntityView,PromotionDetailSLView> where PromotionSLVMEntityView : class, IView where PromotionDetailSLView : class, IView
    {
        public  PromotionDetailSLsGridView<PromotionSLVMEntityView,PromotionDetailSLView> GridView {get;set;}
    }
    public partial class PromotionDetailSLsGridView <PromotionSLVMEntityView,PromotionDetailSLView> :  RPSGridView<PromotionSLVMEntityView,PromotionDetailSLView> where PromotionSLVMEntityView : class, IView where PromotionDetailSLView : class, IView
    {
        public PromotionDetailSLsGridView(PromotionSLVMEntityView currentView,PromotionDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            GiftType = RPSControlFactory.CreateRPSGridEnumComboBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cGiftType']","",true, this.CurrentView);
 
            AllArticle = RPSControlFactory.CreateRPSGridCheckBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cAllArticle']","",true, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridCheckBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 
            Proportional = RPSControlFactory.CreateRPSGridCheckBox<PromotionSLVMEntityView>("","#8da022d1-268d-41b6-af8a-d21dc65514de .ag-row[role='row']@ROWINDEX [col-id='cProportional']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PromotionSLVMEntityView> GiftType { get; set; } 
        public IRPSGridCheckbox<PromotionSLVMEntityView> AllArticle { get; set; } 
        public IRPSGridCheckbox<PromotionSLVMEntityView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<PromotionSLVMEntityView> Quantity { get; set; } 
        public IRPSGridCheckbox<PromotionSLVMEntityView> HomogeneousSalesUnit { get; set; } 
        public IRPSGridCheckbox<PromotionSLVMEntityView> Proportional { get; set; } 
                     
    }
 
    }
  
            
    public partial class PromotionDetailSLView : View
    {
        public PromotionDetailSLView(PromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailSLView,PromotionSLVMEntityView>( this,Screen.PromotionSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailSLView,PromotionSLVMEntityView>( this,Screen.PromotionSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailSLView,PromotionSLVMEntityView>( this,Screen.PromotionSLVMEntityView);
 
            GiftType = RPSControlFactory.CreateRPSEnumComboBox<PromotionDetailSLView>("e95a1a9d-3849-4353-930b-ad1b50318b65","","",true, this);
 
            AllArticle = RPSControlFactory.CreateRPSCheckBox<PromotionDetailSLView>("eae7f66a-e68f-49a8-86b0-6ee512651955","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<PromotionDetailSLView>("e7572ec0-013f-4251-9124-b752e7cc19ab","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PromotionDetailSLView>("b224b41b-ca90-4bc1-9c68-046bba34b292","","",false, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSCheckBox<PromotionDetailSLView>("584476b9-fb13-4420-81b4-e626bbb785a7","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailSLView>("92c63d5d-e37f-45de-8f2a-04f6ae5b15e5","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailSLView>("ba8c6b71-113c-47e1-92e8-a9a1fa0cb221","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<PromotionDetailSLView>("9a5c8ee8-527b-4c80-874c-c31df6920498","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PromotionDetailSLView>("bf1f7f38-36da-4938-8276-852864a1aba7","","",false, this);
 
            CollectionInit params_PromotionDetailArticleSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f4af6107-f843-4be8-bf4b-3e01f637d9e2",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetailArticleSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailArticleSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView>,PromotionDetailSLView,PromotionDetailArticleSLView>( params_PromotionDetailArticleSLs,this,Screen.PromotionDetailArticleSLView);
 
            CollectionInit params_PromotionDetailGiftSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e6da7723-1283-474f-ad2e-c5f3969afcd9",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetailGiftSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailGiftSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView>,PromotionDetailSLView,PromotionDetailArticleSLView>( params_PromotionDetailGiftSLs,this,Screen.PromotionDetailArticleSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PromotionDetailSLView>( "","ul li[rpsid='501afe6c-fb2f-4fbd-8df4-00eed0866931']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<PromotionDetailSLView>( "","ul li[rpsid='a005bbf6-5e7d-4737-8c2d-da943570e892']","",this);
 

        }
        public IRPSButton<PromotionDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailSLView,PromotionSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailSLView,PromotionSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailSLView,PromotionSLVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailSLView> GiftType { get; set; } 
        public IRPSCheckbox<PromotionDetailSLView> AllArticle { get; set; } 
        public IRPSCheckbox<PromotionDetailSLView> Proportional { get; set; } 
        public IRPSComboBox<PromotionDetailSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<PromotionDetailSLView> TotalQuantity { get; set; } 
        public IRPSTextBox<PromotionDetailSLView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<PromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
        public IRPSTextBox<PromotionDetailSLView> Comment { get; set; } 
        public PromotionDetailArticleSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView> PromotionDetailArticleSLs { get; set; } 
        public PromotionDetailGiftSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView> PromotionDetailGiftSLs { get; set; } 
        public IRPSSection<PromotionDetailSLView> GeneralData { get; set; } 
        public IRPSSection<PromotionDetailSLView> Comments { get; set; } 
        public PromotionSL Screen { get; set; }
        public PromotionDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PromotionDetailArticleSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView>:RPSCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView> where PromotionDetailSLView : class, IView where PromotionDetailArticleSLView : class, IView
    {
        public  PromotionDetailArticleSLsGridView<PromotionDetailSLView,PromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class PromotionDetailArticleSLsGridView <PromotionDetailSLView,PromotionDetailArticleSLView> :  RPSGridView<PromotionDetailSLView,PromotionDetailArticleSLView> where PromotionDetailSLView : class, IView where PromotionDetailArticleSLView : class, IView
    {
        public PromotionDetailArticleSLsGridView(PromotionDetailSLView currentView,PromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailSLView>("","#f4af6107-f843-4be8-bf4b-3e01f637d9e2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailSLView>("","#f4af6107-f843-4be8-bf4b-3e01f637d9e2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailSLView>("","#f4af6107-f843-4be8-bf4b-3e01f637d9e2 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSGridCheckBox<PromotionDetailSLView>("","#f4af6107-f843-4be8-bf4b-3e01f637d9e2 .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousSalesUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<PromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridComboBox<PromotionDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<PromotionDetailSLView> HomogeneousSalesUnit { get; set; } 
                     
    }
 
        public partial class PromotionDetailGiftSLsCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView>:RPSCollectionEditor<PromotionDetailSLView,PromotionDetailArticleSLView> where PromotionDetailSLView : class, IView where PromotionDetailArticleSLView : class, IView
    {
        public  PromotionDetailGiftSLsGridView<PromotionDetailSLView,PromotionDetailArticleSLView> GridView {get;set;}
    }
    public partial class PromotionDetailGiftSLsGridView <PromotionDetailSLView,PromotionDetailArticleSLView> :  RPSGridView<PromotionDetailSLView,PromotionDetailArticleSLView> where PromotionDetailSLView : class, IView where PromotionDetailArticleSLView : class, IView
    {
        public PromotionDetailGiftSLsGridView(PromotionDetailSLView currentView,PromotionDetailArticleSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailSLView>("","#e6da7723-1283-474f-ad2e-c5f3969afcd9 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailSLView>("","#e6da7723-1283-474f-ad2e-c5f3969afcd9 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSGridCheckBox<PromotionDetailSLView>("","#e6da7723-1283-474f-ad2e-c5f3969afcd9 .ag-row[role='row']@ROWINDEX [col-id='cGiftPriceFixed']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailSLView>("","#e6da7723-1283-474f-ad2e-c5f3969afcd9 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PromotionDetailSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<PromotionDetailSLView> Quantity { get; set; } 
        public IRPSGridCheckbox<PromotionDetailSLView> GiftPriceFixed { get; set; } 
        public IRPSGridTextBox<PromotionDetailSLView> Price { get; set; } 
                     
    }
 
    }
  
            
    public partial class PromotionDetailArticleSLView : View
    {
        public PromotionDetailArticleSLView(PromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailArticleSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailArticleSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailArticleSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailArticleSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PromotionDetailArticleSLView>("e64794e8-d72b-485a-968a-597bdec29c75","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailArticleSLView>("694a0daa-c6d9-4a46-a3bf-76579b2312dd","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailArticleSLView>("b44e0725-0ff9-41f8-9d87-f4b12d8edc09","","",false, this);
 
            HomogeneousSalesUnit = RPSControlFactory.CreateRPSCheckBox<PromotionDetailArticleSLView>("b70a2832-5bb6-4f7e-b8e4-203573b228d4","","",true, this);
 

        }
        public IRPSButton<PromotionDetailArticleSLView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailArticleSLView,PromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailArticleSLView,PromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailArticleSLView,PromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailArticleSLView> IDArticle { get; set; } 
        public IRPSTextBox<PromotionDetailArticleSLView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailArticleSLView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<PromotionDetailArticleSLView> HomogeneousSalesUnit { get; set; } 
        public PromotionSL Screen { get; set; }
        public PromotionDetailArticleSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PromotionDetailGiftSLView : View
    {
        public PromotionDetailGiftSLView(PromotionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailGiftSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailGiftSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailGiftSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailGiftSLView,PromotionDetailSLView>( this,Screen.PromotionDetailSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftSLView>("749a6dfa-3153-4809-b1b4-02c923976f4e","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailGiftSLView>("47c4ccca-d4df-4362-ab40-3d43be68bea0","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftSLView>("72b038ea-1b51-4cdb-81ca-7cf71856ccdc","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftSLView>("0ad8daa1-b9a1-4dc5-b5b7-2327f2d2902e","","",false, this);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftSLView>("dd0015da-0351-4428-90ca-fe83df40d77b","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailGiftSLView>("85ebaeb0-34a2-4795-8b16-155c27afed4c","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftSLView>("9c7bbb85-527c-441c-be97-3f41a75f3673","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftSLView>("34fc8d5e-ae29-483f-aea6-b2ae4da9bf40","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftSLView>("2a783c74-2a1c-4088-86d3-20acf2afb79a","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftSLView>("5a84a4fe-1c29-43ee-8afd-e90410a38600","","",true, this);
 

        }
        public IRPSButton<PromotionDetailGiftSLView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailGiftSLView,PromotionDetailSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailGiftSLView,PromotionDetailSLView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailGiftSLView,PromotionDetailSLView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailGiftSLView> IDArticle { get; set; } 
        public IRPSTextBox<PromotionDetailGiftSLView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailGiftSLView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<PromotionDetailGiftSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftSLView> GiftPriceFixed { get; set; } 
        public IRPSTextBox<PromotionDetailGiftSLView> Price { get; set; } 
        public IRPSComboBox<PromotionDetailGiftSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftSLView> Rappel { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public PromotionSL Screen { get; set; }
        public PromotionDetailGiftSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}