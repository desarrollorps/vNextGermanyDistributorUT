    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DiscountGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class DiscountGroupSL:Screen
    {
        public DiscountGroupSL():base()
        {
            this.URL = "sales.discountgroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DiscountGroupSLVMQueryView  = new DiscountGroupSLVMQueryView(this); 
            DiscountGroupSLVMEntityView  = new DiscountGroupSLVMEntityView(this); 
            DiscountGroupDetailSLView  = new DiscountGroupDetailSLView(this); 
            DiscountGroupSLVMQueryView.InitializeControls(); 
            DiscountGroupSLVMEntityView.InitializeControls(); 
            DiscountGroupDetailSLView.InitializeControls(); 
           
        }
      
            public DiscountGroupSLVMQueryView DiscountGroupSLVMQueryView {get; set; } 
            public DiscountGroupSLVMEntityView DiscountGroupSLVMEntityView {get; set; } 
            public DiscountGroupDetailSLView DiscountGroupDetailSLView {get; set; } 
    }
            
    public partial class DiscountGroupSLVMQueryView : View
    {
        public DiscountGroupSLVMQueryView(DiscountGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView>( this,Screen.DiscountGroupSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<DiscountGroupSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<DiscountGroupSLVMQueryView>("9203c69a-76fd-4f73-ac39-ca9b1a4596c9","","",false, this);
 
            UIAllArticle = RPSControlFactory.CreateRPSCheckBox<DiscountGroupSLVMQueryView>("af1e81f2-9365-49bd-80b6-a14e3f10757d","","",false, this);
 
            UIProducLine = RPSControlFactory.CreateRPSCheckBox<DiscountGroupSLVMQueryView>("57581502-4e9e-4b85-ba90-27f8517a01be","","",false, this);
 
            UIlsProductLine = RPSControlFactory.CreateRPSCollectionComboBox<DiscountGroupSLVMQueryView>("0d8db621-04fb-428e-a475-7477ed41fc1f","","",false, this);
 
            UIFamily = RPSControlFactory.CreateRPSCheckBox<DiscountGroupSLVMQueryView>("c2fc4b36-b8a7-4e89-a7c0-c872d07c3306","","",false, this);
 
            UIlsProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<DiscountGroupSLVMQueryView>("6590d0f1-bbff-4130-93c2-f8f6eefd510a","","",false, this);
 
            UISubFamily = RPSControlFactory.CreateRPSCheckBox<DiscountGroupSLVMQueryView>("f2133f54-1eee-4bbd-a028-aaa15df4c58b","","",false, this);
 
            UIlsProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<DiscountGroupSLVMQueryView>("b84c3198-22aa-4ead-a56f-206fc96f425e","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCheckBox<DiscountGroupSLVMQueryView>("b05675e3-de96-4773-b41c-3329ecd31891","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<DiscountGroupSLVMQueryView>("9c2a4389-1bfc-4c47-8e57-c8d8af34612e","","",false, this);
 
            CollectionInit params_DiscountGroupSLConsult = new CollectionInit(){IDDescriptor = "4d5b0525-a971-4ee3-92ae-03dea32e41bf",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bbe2f0fe-a1d9-40bc-864a-ebaf424302ff",CSSSelectorGrid="",XPathGrid=""};
            DiscountGroupSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DiscountGroupSLConsultCollectionEditor<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView>,DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView>( params_DiscountGroupSLConsult,this,Screen.DiscountGroupSLVMEntityView);
 

        }
        public IRPSButton<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<DiscountGroupSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<DiscountGroupSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSCheckbox<DiscountGroupSLVMQueryView> UIAllArticle { get; set; } 
        public IRPSCheckbox<DiscountGroupSLVMQueryView> UIProducLine { get; set; } 
        public IRPSCollectionComboBox<DiscountGroupSLVMQueryView> UIlsProductLine { get; set; } 
        public IRPSCheckbox<DiscountGroupSLVMQueryView> UIFamily { get; set; } 
        public IRPSCollectionComboBox<DiscountGroupSLVMQueryView> UIlsProductFamily { get; set; } 
        public IRPSCheckbox<DiscountGroupSLVMQueryView> UISubFamily { get; set; } 
        public IRPSCollectionComboBox<DiscountGroupSLVMQueryView> UIlsProductSubFamily { get; set; } 
        public IRPSCheckbox<DiscountGroupSLVMQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<DiscountGroupSLVMQueryView> UIlsIDArticle { get; set; } 
        public DiscountGroupSLConsultCollectionEditor<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> DiscountGroupSLConsult { get; set; } 
        public DiscountGroupSL Screen { get; set; }
        public DiscountGroupSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DiscountGroupSLConsultCollectionEditor<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView>:RPSCollectionEditor<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> where DiscountGroupSLVMQueryView : class, IView where DiscountGroupSLVMEntityView : class, IView
    {
        public  DiscountGroupSLConsultGridView<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> GridView {get;set;}
    }
    public partial class DiscountGroupSLConsultGridView <DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> :  RPSGridView<DiscountGroupSLVMQueryView,DiscountGroupSLVMEntityView> where DiscountGroupSLVMQueryView : class, IView where DiscountGroupSLVMEntityView : class, IView
    {
        public DiscountGroupSLConsultGridView(DiscountGroupSLVMQueryView currentView,DiscountGroupSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DiscountGroupSL_CodDiscountGroup = RPSControlFactory.CreateRPSGridTextBox<DiscountGroupSLVMQueryView>("","#bbe2f0fe-a1d9-40bc-864a-ebaf424302ff .ag-row[role='row']@ROWINDEX [col-id='cDiscountGroupSL_CodDiscountGroup']","",false, this.CurrentView);
 
            DiscountGroupSL_Description = RPSControlFactory.CreateRPSGridTextBox<DiscountGroupSLVMQueryView>("","#bbe2f0fe-a1d9-40bc-864a-ebaf424302ff .ag-row[role='row']@ROWINDEX [col-id='cDiscountGroupSL_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DiscountGroupSLVMQueryView> DiscountGroupSL_CodDiscountGroup { get; set; } 
        public IRPSGridTextBox<DiscountGroupSLVMQueryView> DiscountGroupSL_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class DiscountGroupSLVMEntityView : View
    {
        public DiscountGroupSLVMEntityView(DiscountGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DiscountGroupSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DiscountGroupSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DiscountGroupSLVMEntityView,DiscountGroupSLVMQueryView>( this,Screen.DiscountGroupSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<DiscountGroupSLVMEntityView,DiscountGroupSLVMQueryView>( this,Screen.DiscountGroupSLVMQueryView);
 
            CodDiscountGroup = RPSControlFactory.CreateRPSTextBox<DiscountGroupSLVMEntityView>("b2c8f59a-59b3-47a3-8d86-24d11541cc9b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DiscountGroupSLVMEntityView>("d4a1d908-78e3-4863-9e29-f8e627408e05","","",false, this);
 
            CollectionInit params_DiscountGroupDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3cf97df6-6fb8-44ae-a7d1-6a58917286ac",CSSSelectorGrid="",XPathGrid=""};
            DiscountGroupDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DiscountGroupDetailSLsCollectionEditor<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView>,DiscountGroupSLVMEntityView,DiscountGroupDetailSLView>( params_DiscountGroupDetailSLs,this,Screen.DiscountGroupDetailSLView);
 

        }
        public IRPSSaveButton<DiscountGroupSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<DiscountGroupSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<DiscountGroupSLVMEntityView,DiscountGroupSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DiscountGroupSLVMEntityView,DiscountGroupSLVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<DiscountGroupSLVMEntityView> CodDiscountGroup { get; set; } 
        public IRPSTextBox<DiscountGroupSLVMEntityView> Description { get; set; } 
        public DiscountGroupDetailSLsCollectionEditor<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView> DiscountGroupDetailSLs { get; set; } 
        public DiscountGroupSL Screen { get; set; }
        public DiscountGroupSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DiscountGroupDetailSLsCollectionEditor<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView>:RPSCollectionEditor<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView> where DiscountGroupSLVMEntityView : class, IView where DiscountGroupDetailSLView : class, IView
    {
        public  DiscountGroupDetailSLsGridView<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView> GridView {get;set;}
    }
    public partial class DiscountGroupDetailSLsGridView <DiscountGroupSLVMEntityView,DiscountGroupDetailSLView> :  RPSGridView<DiscountGroupSLVMEntityView,DiscountGroupDetailSLView> where DiscountGroupSLVMEntityView : class, IView where DiscountGroupDetailSLView : class, IView
    {
        public DiscountGroupDetailSLsGridView(DiscountGroupSLVMEntityView currentView,DiscountGroupDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ItemType = RPSControlFactory.CreateRPSGridEnumComboBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            Discount1 = RPSControlFactory.CreateRPSGridFormattedTextBox<DiscountGroupSLVMEntityView>("","#3cf97df6-6fb8-44ae-a7d1-6a58917286ac .ag-row[role='row']@ROWINDEX [col-id='cDiscount1']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DiscountGroupSLVMEntityView> ItemType { get; set; } 
        public IRPSGridComboBox<DiscountGroupSLVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<DiscountGroupSLVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<DiscountGroupSLVMEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<DiscountGroupSLVMEntityView> QuantityFrom { get; set; } 
        public IRPSGridComboBox<DiscountGroupSLVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<DiscountGroupSLVMEntityView> Discount1 { get; set; } 
                     
    }
 
    }
  
            
    public partial class DiscountGroupDetailSLView : View
    {
        public DiscountGroupDetailSLView(DiscountGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DiscountGroupDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView>( this,Screen.DiscountGroupSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView>( this,Screen.DiscountGroupSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView>( this,Screen.DiscountGroupSLVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<DiscountGroupDetailSLView>("57a8b852-94c7-4752-9aa0-ea388a832789","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DiscountGroupDetailSLView>("c3e95f90-7a1a-4c8e-b27e-8aa7bb425713","","",true, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<DiscountGroupDetailSLView>("57ea49eb-8c4a-4e81-b1ff-e707784906e0","","",true, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<DiscountGroupDetailSLView>("ccc71e6e-0b53-41f5-927c-9df2d36d5975","","",false, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<DiscountGroupDetailSLView>("a727fefd-3fe4-427d-98ad-8226e203d40b","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<DiscountGroupDetailSLView>("d6dcb31a-c72e-42d4-a7ab-c41333c2fbd4","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<DiscountGroupDetailSLView>("ff9618d3-f9ee-4585-a076-63fc7a92e1aa","","",false, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("6554783c-151d-4c92-8b96-f604441b9fef","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<DiscountGroupDetailSLView>("eb6682c4-2598-4feb-a7b5-1ed28909f9f4","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("17ee99c8-603e-4ef0-b9a5-e69a03e7f591","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<DiscountGroupDetailSLView>("a5661b74-82a9-4b03-9664-4adad6bf61cb","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("cd18d84f-bc91-43a7-9fac-5e8f371696e7","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<DiscountGroupDetailSLView>("dfdaa048-763a-455b-92a7-e2663a81a2e2","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("ca86347a-c8b4-44d2-897b-6590bc6642a5","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<DiscountGroupDetailSLView>("2c9147f0-b772-44c2-add1-d1c073674fc9","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("d9211cc3-86fe-4341-bf1e-1749112ebe2e","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<DiscountGroupDetailSLView>("a5cf2780-fd37-4721-bf61-0c3fb4496efc","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("74cd5314-5f1d-4748-989a-7006152e1109","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<DiscountGroupDetailSLView>("3123f738-afa1-4acf-bd72-080e7a9b8266","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<DiscountGroupDetailSLView>("63d45acd-4247-46ef-8a17-c119e33d6f3c","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<DiscountGroupDetailSLView>("6526faa8-b22d-4128-82f0-1a71ea76ff05","","",true, this);
 

        }
        public IRPSButton<DiscountGroupDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DiscountGroupDetailSLView,DiscountGroupSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> DateFrom { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> DateTo { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> ItemType { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> IDItemProductLine { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> IDItemArticle { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> IDItemProductSubFamily { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> QuantityFrom { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> Discount1 { get; set; } 
        public IRPSCheckbox<DiscountGroupDetailSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> Discount2 { get; set; } 
        public IRPSCheckbox<DiscountGroupDetailSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> Discount3 { get; set; } 
        public IRPSCheckbox<DiscountGroupDetailSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> Discount4 { get; set; } 
        public IRPSCheckbox<DiscountGroupDetailSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> Discount5 { get; set; } 
        public IRPSCheckbox<DiscountGroupDetailSLView> CascadeDiscount5 { get; set; } 
        public IRPSComboBox<DiscountGroupDetailSLView> PositionAmountDiscount { get; set; } 
        public IRPSTextBox<DiscountGroupDetailSLView> AmountDiscount { get; set; } 
        public DiscountGroupSL Screen { get; set; }
        public DiscountGroupDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}