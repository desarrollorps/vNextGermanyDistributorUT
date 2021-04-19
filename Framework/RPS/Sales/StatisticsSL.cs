    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.StatisticsSL
{
    //RPS VERSION 1.0.0.0
    public partial class StatisticsSL:Screen
    {
        public StatisticsSL():base()
        {
            this.URL = "sales.statisticssl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatisticsSLQueryView  = new StatisticsSLQueryView(this); 
            StatisticsSLQueryView.InitializeControls(); 
           
        }
      
            public StatisticsSLQueryView StatisticsSLQueryView {get; set; } 
    }
            
    public partial class StatisticsSLQueryView : View
    {
        public StatisticsSLQueryView(StatisticsSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateStart = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("9eb88a2a-0c99-4035-b171-26404bf75024","","",false, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("4bf290b5-7511-47cc-a892-bc493bf51716","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("5a1723b2-4f8e-40d4-bce7-e39dd8c85f7e","","",false, this);
 
            InvoicingTypeSL = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("ca218e5d-cb2f-4bdf-8f63-8811019c5bf1","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("bb9d82e6-0fc3-42f2-b82f-ca6bae13ca74","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("01ec4b82-7259-44cf-b41d-dc19674546af","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("ec14ce10-5771-420e-8fd3-f2737417a5c7","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsSLQueryView>("d55c0368-e264-4acd-bc45-0455dbb7e0c7","","",false, this);
 
            AllKits = RPSControlFactory.CreateRPSOption<StatisticsSLQueryView>( "49ef972f-3e26-45d9-8877-c57b7c799dfc","","",this);
 
            KitsComponent = RPSControlFactory.CreateRPSOption<StatisticsSLQueryView>( "92b068cc-a181-47de-bfc4-0911ebdf18f7","","",this);
 
            KitsFather = RPSControlFactory.CreateRPSOption<StatisticsSLQueryView>( "6d0e055f-5a67-47d1-b55f-94e621374e0e","","",this);
 
            StatisticsSL_Date = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("c10e6413-ad06-4128-8ce1-2e0b0242cc6f","","",false, this);
 
            BusinessUnit1 = RPSControlFactory.CreateRPSComboBox<StatisticsSLQueryView>("fa487313-0535-47f5-8a66-77a68daa6208","","",false, this);
 
            StatisticsSL_SerialNumber = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("ea799f6a-4d96-4468-b0db-2ddcc28f4950","","",false, this);
 
            StatisticsSL_Series = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("61925ba2-891e-431f-b17a-49bae36eed07","","",false, this);
 
            StatisticsSL_InternalCode = RPSControlFactory.CreateRPSTextBox<StatisticsSLQueryView>("4e446047-768e-4f05-ab87-75b87ccdc5cd","","",false, this);
 
            StatisticsSL_PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<StatisticsSLQueryView>("2b125ba7-52e4-4379-8220-2c7d7176efda","","",false, this);
 
            CollectionInit params_StatisticsSL = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14460c37-68b4-4450-b239-f2fc3d6a4d8d",CSSSelectorGrid="",XPathGrid=""};
            StatisticsSL = RPSControlFactory.RPSCreateCollectionWithGrid<StatisticsSLCollectionEditor<StatisticsSLQueryView>,StatisticsSLQueryView>( params_StatisticsSL,this);
 

        }
        public IRPSTextBox<StatisticsSLQueryView> DateStart { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> InvoicingTypeSL { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<StatisticsSLQueryView> Article { get; set; } 
        public IRPSOption<StatisticsSLQueryView> AllKits { get; set; } 
        public IRPSOption<StatisticsSLQueryView> KitsComponent { get; set; } 
        public IRPSOption<StatisticsSLQueryView> KitsFather { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> StatisticsSL_Date { get; set; } 
        public IRPSComboBox<StatisticsSLQueryView> BusinessUnit1 { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> StatisticsSL_SerialNumber { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> StatisticsSL_Series { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> StatisticsSL_InternalCode { get; set; } 
        public IRPSTextBox<StatisticsSLQueryView> StatisticsSL_PercentVAT { get; set; } 
        public StatisticsSLCollectionEditor<StatisticsSLQueryView> StatisticsSL { get; set; } 
        public StatisticsSL Screen { get; set; }
        public StatisticsSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatisticsSLCollectionEditor<StatisticsSLQueryView>:RPSCollectionEditor<StatisticsSLQueryView> where StatisticsSLQueryView : class, IView
    {
        public  StatisticsSLGridView<StatisticsSLQueryView> GridView {get;set;}
    }
    public partial class StatisticsSLGridView <StatisticsSLQueryView> :  RPSGridView<StatisticsSLQueryView> where StatisticsSLQueryView : class, IView
    {
        public StatisticsSLGridView(StatisticsSLQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BusinessUnit1 = RPSControlFactory.CreateRPSGridComboBox<StatisticsSLQueryView>("","#14460c37-68b4-4450-b239-f2fc3d6a4d8d .ag-row[role='row']@ROWINDEX [col-id='cBusinessUnit1']","",false, this.CurrentView);
 
            StatisticsSL_Date = RPSControlFactory.CreateRPSGridTextBox<StatisticsSLQueryView>("","#14460c37-68b4-4450-b239-f2fc3d6a4d8d .ag-row[role='row']@ROWINDEX [col-id='cStatisticsSL_Date']","",false, this.CurrentView);
 
            StatisticsSL_PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<StatisticsSLQueryView>("","#14460c37-68b4-4450-b239-f2fc3d6a4d8d .ag-row[role='row']@ROWINDEX [col-id='cStatisticsSL_PercentVAT']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<StatisticsSLQueryView> BusinessUnit1 { get; set; } 
        public IRPSGridTextBox<StatisticsSLQueryView> StatisticsSL_Date { get; set; } 
        public IRPSGridTextBox<StatisticsSLQueryView> StatisticsSL_PercentVAT { get; set; } 
                     
    }
 
    }
  
    

}