    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierPromotion
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierPromotion:Screen
    {
        public SupplierPromotion():base()
        {
            this.URL = "purchase.supplierpromotion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierPromotionVMQueryView  = new SupplierPromotionVMQueryView(this); 
            SupplierPromotionVMEntityView  = new SupplierPromotionVMEntityView(this); 
            PromotionDetailView  = new PromotionDetailView(this); 
            PromotionDetailArticleView  = new PromotionDetailArticleView(this); 
            PromotionDetailGiftView  = new PromotionDetailGiftView(this); 
            SupplierPromotionVMQueryView.InitializeControls(); 
            SupplierPromotionVMEntityView.InitializeControls(); 
            PromotionDetailView.InitializeControls(); 
            PromotionDetailArticleView.InitializeControls(); 
            PromotionDetailGiftView.InitializeControls(); 
           
        }
      
            public SupplierPromotionVMQueryView SupplierPromotionVMQueryView {get; set; } 
            public SupplierPromotionVMEntityView SupplierPromotionVMEntityView {get; set; } 
            public PromotionDetailView PromotionDetailView {get; set; } 
            public PromotionDetailArticleView PromotionDetailArticleView {get; set; } 
            public PromotionDetailGiftView PromotionDetailGiftView {get; set; } 
    }
            
    public partial class SupplierPromotionVMQueryView : View
    {
        public SupplierPromotionVMQueryView(SupplierPromotion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView>( this,Screen.SupplierPromotionVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SupplierPromotionVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<SupplierPromotionVMQueryView>("538cd9d1-f0fb-44aa-849f-4c85dc872d22","","",false, this);
 
            lsIDSupplierFilter = RPSControlFactory.CreateRPSCollectionComboBox<SupplierPromotionVMQueryView>("6b113bdf-17c6-4d2a-b743-534882663968","","",false, this);
 
            CollectionInit params_SupplierPromotion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="56168ac8-0366-440b-94a3-91f1ca170fc7",CSSSelectorGrid="",XPathGrid=""};
            SupplierPromotion = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierPromotionCollectionEditor<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView>,SupplierPromotionVMQueryView,SupplierPromotionVMEntityView>( params_SupplierPromotion,this,Screen.SupplierPromotionVMEntityView);
 

        }
        public IRPSButton<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> NewButton { get; set; } 
        public IRPSButton<SupplierPromotionVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<SupplierPromotionVMQueryView> UIEffectiveDate { get; set; } 
        public IRPSCollectionComboBox<SupplierPromotionVMQueryView> lsIDSupplierFilter { get; set; } 
        public SupplierPromotionCollectionEditor<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> SupplierPromotion { get; set; } 
        public SupplierPromotion Screen { get; set; }
        public SupplierPromotionVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierPromotionCollectionEditor<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView>:RPSCollectionEditor<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> where SupplierPromotionVMQueryView : class, IView where SupplierPromotionVMEntityView : class, IView
    {
        public  SupplierPromotionGridView<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> GridView {get;set;}
    }
    public partial class SupplierPromotionGridView <SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> :  RPSGridView<SupplierPromotionVMQueryView,SupplierPromotionVMEntityView> where SupplierPromotionVMQueryView : class, IView where SupplierPromotionVMEntityView : class, IView
    {
        public SupplierPromotionGridView(SupplierPromotionVMQueryView currentView,SupplierPromotionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierPromotion_Description = RPSControlFactory.CreateRPSGridTextBox<SupplierPromotionVMQueryView>("","#56168ac8-0366-440b-94a3-91f1ca170fc7 .ag-row[role='row']@ROWINDEX [col-id='cSupplierPromotion_Description']","",false, this.CurrentView);
 
            SupplierPromotion_DateFrom = RPSControlFactory.CreateRPSGridTextBox<SupplierPromotionVMQueryView>("","#56168ac8-0366-440b-94a3-91f1ca170fc7 .ag-row[role='row']@ROWINDEX [col-id='cSupplierPromotion_DateFrom']","",false, this.CurrentView);
 
            SupplierPromotion_DateTo = RPSControlFactory.CreateRPSGridTextBox<SupplierPromotionVMQueryView>("","#56168ac8-0366-440b-94a3-91f1ca170fc7 .ag-row[role='row']@ROWINDEX [col-id='cSupplierPromotion_DateTo']","",false, this.CurrentView);
 
            SupplierPromotion_Order = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierPromotionVMQueryView>("","#56168ac8-0366-440b-94a3-91f1ca170fc7 .ag-row[role='row']@ROWINDEX [col-id='cSupplierPromotion_Order']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierPromotionVMQueryView> SupplierPromotion_Description { get; set; } 
        public IRPSGridTextBox<SupplierPromotionVMQueryView> SupplierPromotion_DateFrom { get; set; } 
        public IRPSGridTextBox<SupplierPromotionVMQueryView> SupplierPromotion_DateTo { get; set; } 
        public IRPSGridTextBox<SupplierPromotionVMQueryView> SupplierPromotion_Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierPromotionVMEntityView : View
    {
        public SupplierPromotionVMEntityView(SupplierPromotion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierPromotionVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierPromotionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierPromotionVMEntityView,SupplierPromotionVMQueryView>( this,Screen.SupplierPromotionVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierPromotionVMEntityView,SupplierPromotionVMQueryView>( this,Screen.SupplierPromotionVMQueryView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierPromotionVMEntityView>("d40dd5ee-19b9-4bac-9095-f4901a2360f0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierPromotionVMEntityView>("cc83b271-118a-43de-b4a4-36f84e49fd25","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<SupplierPromotionVMEntityView>("75b17782-03e5-4754-8eff-1f17c4992bab","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SupplierPromotionVMEntityView>("20db267f-d073-4d41-8f5f-417d9c04c7cf","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SupplierPromotionVMEntityView>("07cc7756-26ba-46f2-843b-77f98b120f68","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierPromotionVMEntityView>("44e016f0-1fac-4996-85de-0967088faf7d","","",false, this);
 
            CollectionInit params_PromotionDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7995ad5d-da59-406e-a577-7b6740180a38",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetails = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailsCollectionEditor<SupplierPromotionVMEntityView,PromotionDetailView>,SupplierPromotionVMEntityView,PromotionDetailView>( params_PromotionDetails,this,Screen.PromotionDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierPromotionVMEntityView>( "","ul li[rpsid='a6769f7c-bce4-45e1-bec5-0169356be75e']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierPromotionVMEntityView>( "","ul li[rpsid='9854068c-6d98-4609-a7b4-1415a165904d']","",this);
 

        }
        public IRPSSaveButton<SupplierPromotionVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierPromotionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierPromotionVMEntityView,SupplierPromotionVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierPromotionVMEntityView,SupplierPromotionVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SupplierPromotionVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<SupplierPromotionVMEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierPromotionVMEntityView> Order { get; set; } 
        public IRPSTextBox<SupplierPromotionVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<SupplierPromotionVMEntityView> DateTo { get; set; } 
        public IRPSTextBox<SupplierPromotionVMEntityView> Comment { get; set; } 
        public PromotionDetailsCollectionEditor<SupplierPromotionVMEntityView,PromotionDetailView> PromotionDetails { get; set; } 
        public IRPSSection<SupplierPromotionVMEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierPromotionVMEntityView> Comments { get; set; } 
        public SupplierPromotion Screen { get; set; }
        public SupplierPromotionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PromotionDetailsCollectionEditor<SupplierPromotionVMEntityView,PromotionDetailView>:RPSCollectionEditor<SupplierPromotionVMEntityView,PromotionDetailView> where SupplierPromotionVMEntityView : class, IView where PromotionDetailView : class, IView
    {
        public  PromotionDetailsGridView<SupplierPromotionVMEntityView,PromotionDetailView> GridView {get;set;}
    }
    public partial class PromotionDetailsGridView <SupplierPromotionVMEntityView,PromotionDetailView> :  RPSGridView<SupplierPromotionVMEntityView,PromotionDetailView> where SupplierPromotionVMEntityView : class, IView where PromotionDetailView : class, IView
    {
        public PromotionDetailsGridView(SupplierPromotionVMEntityView currentView,PromotionDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            GiftType = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cGiftType']","",true, this.CurrentView);
 
            AllArticle = RPSControlFactory.CreateRPSGridCheckBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cAllArticle']","",true, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridCheckBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousPurchaseUnit = RPSControlFactory.CreateRPSGridCheckBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousPurchaseUnit']","",true, this.CurrentView);
 
            Proportional = RPSControlFactory.CreateRPSGridCheckBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cProportional']","",true, this.CurrentView);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSGridComboBox<SupplierPromotionVMEntityView>("","#7995ad5d-da59-406e-a577-7b6740180a38 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteType']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierPromotionVMEntityView> GiftType { get; set; } 
        public IRPSGridCheckbox<SupplierPromotionVMEntityView> AllArticle { get; set; } 
        public IRPSGridCheckbox<SupplierPromotionVMEntityView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<SupplierPromotionVMEntityView> Quantity { get; set; } 
        public IRPSGridComboBox<SupplierPromotionVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<SupplierPromotionVMEntityView> HomogeneousPurchaseUnit { get; set; } 
        public IRPSGridCheckbox<SupplierPromotionVMEntityView> Proportional { get; set; } 
        public IRPSGridComboBox<SupplierPromotionVMEntityView> IDDeliveryNoteType { get; set; } 
                     
    }
 
    }
  
            
    public partial class PromotionDetailView : View
    {
        public PromotionDetailView(SupplierPromotion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailView,SupplierPromotionVMEntityView>( this,Screen.SupplierPromotionVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailView,SupplierPromotionVMEntityView>( this,Screen.SupplierPromotionVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailView,SupplierPromotionVMEntityView>( this,Screen.SupplierPromotionVMEntityView);
 
            GiftType = RPSControlFactory.CreateRPSEnumComboBox<PromotionDetailView>("d148e9d5-d70f-4b4e-87eb-2150ace8889a","","",true, this);
 
            AllArticle = RPSControlFactory.CreateRPSCheckBox<PromotionDetailView>("df286c1d-1681-4697-a331-0917eff1e666","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<PromotionDetailView>("745388c6-a61f-4931-8fb8-2a8b2cd10381","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PromotionDetailView>("7e10262e-d92c-4105-a315-88131e3c619c","","",false, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSCheckBox<PromotionDetailView>("cb097909-c199-4b8a-a59c-2b132f023749","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailView>("1dac138c-7eaf-4c5b-94b3-591e7aacd383","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailView>("cfcc2f5d-3d20-4d77-a9d8-15371d5383be","","",false, this);
 
            HomogeneousPurchaseUnit = RPSControlFactory.CreateRPSCheckBox<PromotionDetailView>("48e61728-79e6-4e69-aef8-7a117d684ed6","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PromotionDetailView>("c7f47178-1fd8-4ab2-a2a7-0dc741cb7cce","","",false, this);
 
            CollectionInit params_PromotionDetailArticles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3c74d4d2-201c-454d-8e2b-95d6085982ec",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetailArticles = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailArticlesCollectionEditor<PromotionDetailView,PromotionDetailArticleView>,PromotionDetailView,PromotionDetailArticleView>( params_PromotionDetailArticles,this,Screen.PromotionDetailArticleView);
 
            CollectionInit params_PromotionDetailGifts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6f5ce821-a18d-4da6-b5f1-3b3839e49f99",CSSSelectorGrid="",XPathGrid=""};
            PromotionDetailGifts = RPSControlFactory.RPSCreateCollectionWithGrid<PromotionDetailGiftsCollectionEditor<PromotionDetailView,PromotionDetailArticleView>,PromotionDetailView,PromotionDetailArticleView>( params_PromotionDetailGifts,this,Screen.PromotionDetailArticleView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PromotionDetailView>( "","ul li[rpsid='2abd93a1-8225-4597-b780-85a0979b84ff']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<PromotionDetailView>( "","ul li[rpsid='0fac62f9-2c40-46a3-8f4b-799d348aeed0']","",this);
 

        }
        public IRPSButton<PromotionDetailView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailView,SupplierPromotionVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailView,SupplierPromotionVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailView,SupplierPromotionVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailView> GiftType { get; set; } 
        public IRPSCheckbox<PromotionDetailView> AllArticle { get; set; } 
        public IRPSCheckbox<PromotionDetailView> Proportional { get; set; } 
        public IRPSComboBox<PromotionDetailView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<PromotionDetailView> TotalQuantity { get; set; } 
        public IRPSTextBox<PromotionDetailView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<PromotionDetailView> HomogeneousPurchaseUnit { get; set; } 
        public IRPSTextBox<PromotionDetailView> Comment { get; set; } 
        public PromotionDetailArticlesCollectionEditor<PromotionDetailView,PromotionDetailArticleView> PromotionDetailArticles { get; set; } 
        public PromotionDetailGiftsCollectionEditor<PromotionDetailView,PromotionDetailArticleView> PromotionDetailGifts { get; set; } 
        public IRPSSection<PromotionDetailView> GeneralData { get; set; } 
        public IRPSSection<PromotionDetailView> Comments { get; set; } 
        public SupplierPromotion Screen { get; set; }
        public PromotionDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PromotionDetailArticlesCollectionEditor<PromotionDetailView,PromotionDetailArticleView>:RPSCollectionEditor<PromotionDetailView,PromotionDetailArticleView> where PromotionDetailView : class, IView where PromotionDetailArticleView : class, IView
    {
        public  PromotionDetailArticlesGridView<PromotionDetailView,PromotionDetailArticleView> GridView {get;set;}
    }
    public partial class PromotionDetailArticlesGridView <PromotionDetailView,PromotionDetailArticleView> :  RPSGridView<PromotionDetailView,PromotionDetailArticleView> where PromotionDetailView : class, IView where PromotionDetailArticleView : class, IView
    {
        public PromotionDetailArticlesGridView(PromotionDetailView currentView,PromotionDetailArticleView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailView>("","#3c74d4d2-201c-454d-8e2b-95d6085982ec .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailView>("","#3c74d4d2-201c-454d-8e2b-95d6085982ec .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailView>("","#3c74d4d2-201c-454d-8e2b-95d6085982ec .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",false, this.CurrentView);
 
            HomogeneousPurchaseUnit = RPSControlFactory.CreateRPSGridCheckBox<PromotionDetailView>("","#3c74d4d2-201c-454d-8e2b-95d6085982ec .ag-row[role='row']@ROWINDEX [col-id='cHomogeneousPurchaseUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PromotionDetailView> IDArticle { get; set; } 
        public IRPSGridTextBox<PromotionDetailView> Quantity { get; set; } 
        public IRPSGridComboBox<PromotionDetailView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<PromotionDetailView> HomogeneousPurchaseUnit { get; set; } 
                     
    }
 
        public partial class PromotionDetailGiftsCollectionEditor<PromotionDetailView,PromotionDetailArticleView>:RPSCollectionEditor<PromotionDetailView,PromotionDetailArticleView> where PromotionDetailView : class, IView where PromotionDetailArticleView : class, IView
    {
        public  PromotionDetailGiftsGridView<PromotionDetailView,PromotionDetailArticleView> GridView {get;set;}
    }
    public partial class PromotionDetailGiftsGridView <PromotionDetailView,PromotionDetailArticleView> :  RPSGridView<PromotionDetailView,PromotionDetailArticleView> where PromotionDetailView : class, IView where PromotionDetailArticleView : class, IView
    {
        public PromotionDetailGiftsGridView(PromotionDetailView currentView,PromotionDetailArticleView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSGridCheckBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cGiftPriceFixed']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDUnitPrice = RPSControlFactory.CreateRPSGridComboBox<PromotionDetailView>("","#6f5ce821-a18d-4da6-b5f1-3b3839e49f99 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PromotionDetailView> IDArticle { get; set; } 
        public IRPSGridTextBox<PromotionDetailView> Quantity { get; set; } 
        public IRPSGridComboBox<PromotionDetailView> IDUnitQuantity { get; set; } 
        public IRPSGridCheckbox<PromotionDetailView> GiftPriceFixed { get; set; } 
        public IRPSGridTextBox<PromotionDetailView> Price { get; set; } 
        public IRPSGridComboBox<PromotionDetailView> IDUnitPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class PromotionDetailArticleView : View
    {
        public PromotionDetailArticleView(SupplierPromotion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailArticleView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailArticleView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailArticleView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailArticleView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PromotionDetailArticleView>("f9d6acb6-e948-4e83-ad93-06ac8e2ff609","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailArticleView>("315c8e38-7871-4b88-a2b0-9bc1b379b1d4","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailArticleView>("67c0d1f7-cd7c-4855-9d77-dd9e25e141f5","","",false, this);
 
            HomogeneousPurchaseUnit = RPSControlFactory.CreateRPSCheckBox<PromotionDetailArticleView>("9fbbe427-530e-45a5-863d-90c526753c56","","",true, this);
 

        }
        public IRPSButton<PromotionDetailArticleView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailArticleView,PromotionDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailArticleView,PromotionDetailView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailArticleView,PromotionDetailView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailArticleView> IDArticle { get; set; } 
        public IRPSTextBox<PromotionDetailArticleView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailArticleView> IDUnitQuantity { get; set; } 
        public IRPSCheckbox<PromotionDetailArticleView> HomogeneousPurchaseUnit { get; set; } 
        public SupplierPromotion Screen { get; set; }
        public PromotionDetailArticleView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PromotionDetailGiftView : View
    {
        public PromotionDetailGiftView(SupplierPromotion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PromotionDetailGiftView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PromotionDetailGiftView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<PromotionDetailGiftView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PromotionDetailGiftView,PromotionDetailView>( this,Screen.PromotionDetailView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftView>("70821252-30e2-4258-8cac-ed2dd1373239","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailGiftView>("3075ef62-3f64-4e85-a91c-0f51e2a5bb19","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftView>("d3cc821c-c5cd-40a7-ad11-6e913d682081","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftView>("2545eff8-5de5-4998-808c-48f80a8214ad","","",false, this);
 
            GiftPriceFixed = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftView>("77451687-669a-4fd9-8b80-bbc482e259f4","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<PromotionDetailGiftView>("ec5665f7-6d74-4115-aeac-fa4ce85f9928","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<PromotionDetailGiftView>("3c60eddf-3d9f-4ed3-8e59-d814786c26e5","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftView>("8a0421e6-6299-45fb-841b-a09203035a9d","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftView>("10d67ca6-ccc1-486b-87e8-5fc0f3699bd2","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<PromotionDetailGiftView>("192d221c-11ff-4e66-9112-337850c33d53","","",true, this);
 

        }
        public IRPSButton<PromotionDetailGiftView> DeleteButton { get; set; } 
        public IRPSButton<PromotionDetailGiftView,PromotionDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PromotionDetailGiftView,PromotionDetailView> BackButton { get; set; } 
        public IRPSAcceptButton<PromotionDetailGiftView,PromotionDetailView> AcceptButton { get; set; } 
        public IRPSComboBox<PromotionDetailGiftView> IDArticle { get; set; } 
        public IRPSTextBox<PromotionDetailGiftView> Quantity { get; set; } 
        public IRPSComboBox<PromotionDetailGiftView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<PromotionDetailGiftView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftView> GiftPriceFixed { get; set; } 
        public IRPSTextBox<PromotionDetailGiftView> Price { get; set; } 
        public IRPSComboBox<PromotionDetailGiftView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftView> Rappel { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<PromotionDetailGiftView> ApplyConditionsNotAffectDocument { get; set; } 
        public SupplierPromotion Screen { get; set; }
        public PromotionDetailGiftView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}