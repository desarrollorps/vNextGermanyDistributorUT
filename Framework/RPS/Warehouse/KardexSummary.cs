    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.KardexSummary
{
    //RPS VERSION 1.0.0.0
    public partial class KardexSummary:Screen
    {
        public KardexSummary():base()
        {
            this.URL = "warehouse.kardexsummary";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            KardexSummaryQueryView  = new KardexSummaryQueryView(this); 
            KardexSummaryQueryView.InitializeControls(); 
           
        }
      
            public KardexSummaryQueryView KardexSummaryQueryView {get; set; } 
    }
            
    public partial class KardexSummaryQueryView : View
    {
        public KardexSummaryQueryView(KardexSummary screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            optArticle = RPSControlFactory.CreateRPSOption<KardexSummaryQueryView>( "44e310e2-faa1-42c7-ae6c-aafb2fc738b2","","",this);
 
            optSite = RPSControlFactory.CreateRPSOption<KardexSummaryQueryView>( "23c4bf6f-2096-4125-bd86-08e766f42e70","","",this);
 
            optWarehouse = RPSControlFactory.CreateRPSOption<KardexSummaryQueryView>( "d29224a3-38eb-41bb-825f-4e3ab8c94080","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<KardexSummaryQueryView>("a6bae8d8-8515-4347-b376-c04bae9f5ea8","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<KardexSummaryQueryView>("006d31d9-7dcf-49a5-9de4-f5dcf51ef648","","",false, this);
 
            ProductLine1 = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("406c0572-bbab-4cdd-9dfd-f8532a5e051a","","",false, this);
 
            ProductFamily1 = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("2cf665a8-52c1-4260-aef1-8afbb4e1245b","","",false, this);
 
            ProductSubFamily1 = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("4e69aaa5-1e9f-46fb-a453-9a9ad3eabb7b","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("5ccfc39d-29b1-4e21-896f-91b859049bbf","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("5829658f-77ce-4dcd-9b38-cd8bdbb143b2","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<KardexSummaryQueryView>("0c4ab0d0-65ea-4694-a5d7-2e56b9888561","","",false, this);
 
            CollectionInit params_KardexSummaryArticle = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="de4dba16-d726-48d3-a7fd-7f8d06bed872",CSSSelectorGrid="",XPathGrid=""};
            KardexSummaryArticle = RPSControlFactory.RPSCreateCollectionWithGrid<KardexSummaryArticleCollectionEditor<KardexSummaryQueryView>,KardexSummaryQueryView>( params_KardexSummaryArticle,this);
 

        }
        public IRPSOption<KardexSummaryQueryView> optArticle { get; set; } 
        public IRPSOption<KardexSummaryQueryView> optSite { get; set; } 
        public IRPSOption<KardexSummaryQueryView> optWarehouse { get; set; } 
        public IRPSTextBox<KardexSummaryQueryView> DateFrom { get; set; } 
        public IRPSTextBox<KardexSummaryQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> ProductLine1 { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> ProductFamily1 { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> ProductSubFamily1 { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> Article1 { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> Site1 { get; set; } 
        public IRPSCollectionComboBox<KardexSummaryQueryView> WareHouse { get; set; } 
        public KardexSummaryArticleCollectionEditor<KardexSummaryQueryView> KardexSummaryArticle { get; set; } 
        public KardexSummary Screen { get; set; }
        public KardexSummaryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KardexSummaryArticleCollectionEditor<KardexSummaryQueryView>:RPSCollectionEditor<KardexSummaryQueryView> where KardexSummaryQueryView : class, IView
    {
        public  KardexSummaryArticleGridView<KardexSummaryQueryView> GridView {get;set;}
    }
    public partial class KardexSummaryArticleGridView <KardexSummaryQueryView> :  RPSGridView<KardexSummaryQueryView> where KardexSummaryQueryView : class, IView
    {
        public KardexSummaryArticleGridView(KardexSummaryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}