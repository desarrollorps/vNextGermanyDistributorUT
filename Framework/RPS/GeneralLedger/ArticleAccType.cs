    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ArticleAccType
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleAccType:Screen
    {
        public ArticleAccType():base()
        {
            this.URL = "generalledger.articleacctype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleAccTypeCollectionView  = new ArticleAccTypeCollectionView(this); 
            ArticleAccTypeEntityView  = new ArticleAccTypeEntityView(this); 
            ArticleAccTypeDetailView  = new ArticleAccTypeDetailView(this); 
            ArticleAccTypeCollectionView.InitializeControls(); 
            ArticleAccTypeEntityView.InitializeControls(); 
            ArticleAccTypeDetailView.InitializeControls(); 
           
        }
      
            public ArticleAccTypeCollectionView ArticleAccTypeCollectionView {get; set; } 
            public ArticleAccTypeEntityView ArticleAccTypeEntityView {get; set; } 
            public ArticleAccTypeDetailView ArticleAccTypeDetailView {get; set; } 
    }
            
    public partial class ArticleAccTypeCollectionView : View
    {
        public ArticleAccTypeCollectionView(ArticleAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleAccTypeCollectionView,ArticleAccTypeEntityView>( this,Screen.ArticleAccTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bf3296a9-4d5f-4212-b015-7e5148af9f37",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleAccTypeCollectionView,ArticleAccTypeEntityView>( params_MainConsult,this,Screen.ArticleAccTypeEntityView);
 

        }
        public IRPSButton<ArticleAccTypeCollectionView,ArticleAccTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleAccTypeCollectionView,ArticleAccTypeEntityView> MainConsult { get; set; } 
        public ArticleAccType Screen { get; set; }
        public ArticleAccTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAccTypeEntityView : View
    {
        public ArticleAccTypeEntityView(ArticleAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleAccTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAccTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAccTypeEntityView,ArticleAccTypeCollectionView>( this,Screen.ArticleAccTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAccTypeEntityView,ArticleAccTypeCollectionView>( this,Screen.ArticleAccTypeCollectionView);
 
            CodArticleAccType = RPSControlFactory.CreateRPSTextBox<ArticleAccTypeEntityView>("3b7ef88d-63d5-4e2a-9242-6f9106069ce6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleAccTypeEntityView>("cba30978-9f87-4d36-b5e1-ed3ad281cb47","","",false, this);
 
            IDAccountStock = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("1012cfc2-219f-432b-8ed5-461ab9c902a9","","",false, this);
 
            IDAccountVariance = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("f5d6eb9f-9186-4be7-b9d9-1fbb19ea27db","","",false, this);
 
            IDAccountWIP = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("de692d0e-63db-4fb9-8a4f-370e4ea70622","","",false, this);
 
            IDAccCOGS = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("02248de6-b184-4449-89fc-572a7b04e085","","",false, this);
 
            IDAccGRNI = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("ac0632a2-440b-4ef9-8f83-c56f58cce8d1","","",false, this);
 
            IDAccGDNI = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("e98ffd5f-55a3-49c4-a36a-5270b3c69cb6","","",false, this);
 
            IDAccountPurNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("3a8127bc-4327-43ef-aaee-a7b4a60e10e6","","",false, this);
 
            IDAccountPurNoNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("4fc0b354-6195-4f3b-83a8-73297bb94a25","","",false, this);
 
            IDAccountPurchaseGift = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("9a9353f9-4d93-4e04-9e82-376124636309","","",false, this);
 
            IDAccountPurDiscountLineNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("34fff026-6cab-451c-a853-3591e0776764","","",false, this);
 
            IDAccountPurDiscountLineNoNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("d148d9b9-1bd8-4879-8ad0-e9e2c43f49ae","","",false, this);
 
            IDAccountPurInvestmentNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("7c10ab86-cff7-4029-b987-dea925c74146","","",false, this);
 
            IDAccountPurInvestmentNoNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("6232cb37-359b-46be-a1af-1b05df018a96","","",false, this);
 
            IDAccountSalesNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("271659bb-4749-4e29-8f51-156c0c85794d","","",false, this);
 
            IDAccountSalesNoNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("cb8f1e2d-8662-4967-a559-d3a06173b299","","",false, this);
 
            IDAccountSalesGift = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("5a65376e-86d2-4523-89d7-daadfe15d802","","",false, this);
 
            IDAccountSalDiscountLineNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("f9cde3cf-9bd2-404d-ba01-a8e8218ddfd9","","",false, this);
 
            IDAccountSalDiscountLineNoNat = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeEntityView>("08eef20a-be77-4477-82c1-0ffd03cae04f","","",false, this);
 
            CollectionInit params_ArticleAccTypeDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e39004f-023c-408b-a919-a04c6174055e",CSSSelectorGrid="",XPathGrid=""};
            ArticleAccTypeDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAccTypeDetailsCollectionEditor<ArticleAccTypeEntityView,ArticleAccTypeDetailView>,ArticleAccTypeEntityView,ArticleAccTypeDetailView>( params_ArticleAccTypeDetails,this,Screen.ArticleAccTypeDetailView);
 
            General = RPSControlFactory.CreateRPSSection<ArticleAccTypeEntityView>( "","ul li[rpsid='a9092c84-044a-48f0-b4d2-d5df3fe4904b']","",this);
 
            SiteWarehaose = RPSControlFactory.CreateRPSSection<ArticleAccTypeEntityView>( "","ul li[rpsid='76f4caf5-653c-4d84-8879-c20a426746b9']","",this);
 

        }
        public IRPSSaveButton<ArticleAccTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleAccTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAccTypeEntityView,ArticleAccTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAccTypeEntityView,ArticleAccTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleAccTypeEntityView> CodArticleAccType { get; set; } 
        public IRPSTextBox<ArticleAccTypeEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountStock { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountVariance { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountWIP { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccCOGS { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccGRNI { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccGDNI { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurNoNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurchaseGift { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurDiscountLineNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurDiscountLineNoNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurInvestmentNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountPurInvestmentNoNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountSalesNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountSalesNoNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountSalesGift { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountSalDiscountLineNat { get; set; } 
        public IRPSComboBox<ArticleAccTypeEntityView> IDAccountSalDiscountLineNoNat { get; set; } 
        public ArticleAccTypeDetailsCollectionEditor<ArticleAccTypeEntityView,ArticleAccTypeDetailView> ArticleAccTypeDetails { get; set; } 
        public IRPSSection<ArticleAccTypeEntityView> General { get; set; } 
        public IRPSSection<ArticleAccTypeEntityView> SiteWarehaose { get; set; } 
        public ArticleAccType Screen { get; set; }
        public ArticleAccTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleAccTypeDetailsCollectionEditor<ArticleAccTypeEntityView,ArticleAccTypeDetailView>:RPSCollectionEditor<ArticleAccTypeEntityView,ArticleAccTypeDetailView> where ArticleAccTypeEntityView : class, IView where ArticleAccTypeDetailView : class, IView
    {
        public  ArticleAccTypeDetailsGridView<ArticleAccTypeEntityView,ArticleAccTypeDetailView> GridView {get;set;}
    }
    public partial class ArticleAccTypeDetailsGridView <ArticleAccTypeEntityView,ArticleAccTypeDetailView> :  RPSGridView<ArticleAccTypeEntityView,ArticleAccTypeDetailView> where ArticleAccTypeEntityView : class, IView where ArticleAccTypeDetailView : class, IView
    {
        public ArticleAccTypeDetailsGridView(ArticleAccTypeEntityView currentView,ArticleAccTypeDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",true, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            IDAccountStock = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccountStock']","",false, this.CurrentView);
 
            IDAccountVariance = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccountVariance']","",false, this.CurrentView);
 
            IDAccountWIP = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccountWIP']","",false, this.CurrentView);
 
            IDAccCOGS = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccCOGS']","",false, this.CurrentView);
 
            IDAccGRNI = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccGRNI']","",false, this.CurrentView);
 
            IDAccGDNI = RPSControlFactory.CreateRPSGridComboBox<ArticleAccTypeEntityView>("","#1e39004f-023c-408b-a919-a04c6174055e .ag-row[role='row']@ROWINDEX [col-id='cIDAccGDNI']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccountStock { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccountVariance { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccountWIP { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccCOGS { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccGRNI { get; set; } 
        public IRPSGridComboBox<ArticleAccTypeEntityView> IDAccGDNI { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleAccTypeDetailView : View
    {
        public ArticleAccTypeDetailView(ArticleAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAccTypeDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView>( this,Screen.ArticleAccTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView>( this,Screen.ArticleAccTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView>( this,Screen.ArticleAccTypeEntityView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("bee041c7-bdc4-4c03-8ddf-82eecbb118aa","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("4cf5a7eb-7494-404f-a771-d3d2db8266df","","",false, this);
 
            IDAccountStock = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("eb989551-bfe0-433d-b433-665b7d92c75b","","",false, this);
 
            IDAccountVariance = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("74b12ae2-699d-4e0a-a83a-f1d225746ee3","","",false, this);
 
            IDAccountWIP = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("d83498d4-9670-45cb-afde-cf11305962cb","","",false, this);
 
            IDAccCOGS = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("55700d09-dead-45f7-8ba6-de2d9c5b5a02","","",false, this);
 
            IDAccGRNI = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("fabc2e0d-f9c0-4835-b443-a51276ce0830","","",false, this);
 
            IDAccGDNI = RPSControlFactory.CreateRPSComboBox<ArticleAccTypeDetailView>("36f13548-f40e-4ee5-80db-31f947b7ea05","","",false, this);
 

        }
        public IRPSButton<ArticleAccTypeDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAccTypeDetailView,ArticleAccTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDSite { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDWarehouse { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccountStock { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccountVariance { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccountWIP { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccCOGS { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccGRNI { get; set; } 
        public IRPSComboBox<ArticleAccTypeDetailView> IDAccGDNI { get; set; } 
        public ArticleAccType Screen { get; set; }
        public ArticleAccTypeDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}