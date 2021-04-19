    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Statistics
{
    //RPS VERSION 1.0.0.0
    public partial class Statistics:Screen
    {
        public Statistics():base()
        {
            this.URL = "purchase.statistics";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatisticsQueryView  = new StatisticsQueryView(this); 
            StatisticsQueryView.InitializeControls(); 
           
        }
      
            public StatisticsQueryView StatisticsQueryView {get; set; } 
    }
            
    public partial class StatisticsQueryView : View
    {
        public StatisticsQueryView(Statistics screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateStart = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("9eb88a2a-0c99-4035-b171-26404bf75024","","",false, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("4bf290b5-7511-47cc-a892-bc493bf51716","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("7a0d9bd2-1d13-4f2c-917e-16b542123bfc","","",false, this);
 
            InvoicingType = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("bba3ae04-1ddf-4385-8f89-ac7516ddcdb5","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("97022d33-32dc-4f77-9a2e-33e06562b27a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("7e4af41d-2ad6-47a0-9d55-5037bb6c0c36","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("4675bcd4-e21a-4a2c-b88d-bff559271065","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsQueryView>("0c906d6f-fe23-42ee-88a0-2ed11752f4e8","","",false, this);
 
            AllKits = RPSControlFactory.CreateRPSOption<StatisticsQueryView>( "49ef972f-3e26-45d9-8877-c57b7c799dfc","","",this);
 
            KitsFather = RPSControlFactory.CreateRPSOption<StatisticsQueryView>( "6d0e055f-5a67-47d1-b55f-94e621374e0e","","",this);
 
            KitsComponent = RPSControlFactory.CreateRPSOption<StatisticsQueryView>( "92b068cc-a181-47de-bfc4-0911ebdf18f7","","",this);
 
            BusinessUnit1 = RPSControlFactory.CreateRPSComboBox<StatisticsQueryView>("8d54cd5b-a9ff-46b6-9441-fefe3df84bf9","","",false, this);
 
            Statistics_Date = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("c48ad209-cb69-4c43-a997-cb0ac5823a32","","",false, this);
 
            Statistics_SerialNumber = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("dbdb22c3-f161-4c00-a928-86b1a52d079b","","",false, this);
 
            Statistics_Series = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("c33db12f-f081-4038-9a3c-102ae527234d","","",false, this);
 
            Statistics_InternalCode = RPSControlFactory.CreateRPSTextBox<StatisticsQueryView>("0e378212-3a99-4326-81b4-709669d79443","","",false, this);
 
            Statistics_PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<StatisticsQueryView>("ddf342cd-63ee-4871-a5bf-53bc91baf273","","",false, this);
 
            CollectionInit params_Statistics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="57f8af9a-2b0a-4c46-b594-c73819475725",CSSSelectorGrid="",XPathGrid=""};
            Statistics = RPSControlFactory.RPSCreateCollectionWithGrid<StatisticsCollectionEditor<StatisticsQueryView>,StatisticsQueryView>( params_Statistics,this);
 

        }
        public IRPSTextBox<StatisticsQueryView> DateStart { get; set; } 
        public IRPSTextBox<StatisticsQueryView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> Supplier { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> InvoicingType { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<StatisticsQueryView> Article { get; set; } 
        public IRPSOption<StatisticsQueryView> AllKits { get; set; } 
        public IRPSOption<StatisticsQueryView> KitsFather { get; set; } 
        public IRPSOption<StatisticsQueryView> KitsComponent { get; set; } 
        public IRPSComboBox<StatisticsQueryView> BusinessUnit1 { get; set; } 
        public IRPSTextBox<StatisticsQueryView> Statistics_Date { get; set; } 
        public IRPSTextBox<StatisticsQueryView> Statistics_SerialNumber { get; set; } 
        public IRPSTextBox<StatisticsQueryView> Statistics_Series { get; set; } 
        public IRPSTextBox<StatisticsQueryView> Statistics_InternalCode { get; set; } 
        public IRPSTextBox<StatisticsQueryView> Statistics_PercentVAT { get; set; } 
        public StatisticsCollectionEditor<StatisticsQueryView> Statistics { get; set; } 
        public Statistics Screen { get; set; }
        public StatisticsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatisticsCollectionEditor<StatisticsQueryView>:RPSCollectionEditor<StatisticsQueryView> where StatisticsQueryView : class, IView
    {
        public  StatisticsGridView<StatisticsQueryView> GridView {get;set;}
    }
    public partial class StatisticsGridView <StatisticsQueryView> :  RPSGridView<StatisticsQueryView> where StatisticsQueryView : class, IView
    {
        public StatisticsGridView(StatisticsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<StatisticsQueryView>("","#57f8af9a-2b0a-4c46-b594-c73819475725 .ag-row[role='row']@ROWINDEX [col-id='cStatistics_Date']","",false, this.CurrentView);
 
            Statistics_PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<StatisticsQueryView>("","#57f8af9a-2b0a-4c46-b594-c73819475725 .ag-row[role='row']@ROWINDEX [col-id='cStatistics_PercentVAT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatisticsQueryView> Date { get; set; } 
        public IRPSGridTextBox<StatisticsQueryView> Statistics_PercentVAT { get; set; } 
                     
    }
 
    }
  
    

}