    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.QualityCost
{
    //RPS VERSION 1.0.0.0
    public partial class QualityCost:Screen
    {
        public QualityCost():base()
        {
            this.URL = "quality.qualitycost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualityCostVMCollectionView  = new QualityCostVMCollectionView(this); 
            QualityCostVMEntityView  = new QualityCostVMEntityView(this); 
            QualityCostDetailView  = new QualityCostDetailView(this); 
            QualityCostVMCollectionView.InitializeControls(); 
            QualityCostVMEntityView.InitializeControls(); 
            QualityCostDetailView.InitializeControls(); 
           
        }
      
            public QualityCostVMCollectionView QualityCostVMCollectionView {get; set; } 
            public QualityCostVMEntityView QualityCostVMEntityView {get; set; } 
            public QualityCostDetailView QualityCostDetailView {get; set; } 
    }
            
    public partial class QualityCostVMCollectionView : View
    {
        public QualityCostVMCollectionView(QualityCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eType = RPSControlFactory.CreateRPSEnumComboBox<QualityCostVMCollectionView>("a5118cd5-b7fe-43b9-a86f-99c5347fd4f0","","",false, this);
 
            Year = RPSControlFactory.CreateRPSFormattedTextBox<QualityCostVMCollectionView>("47790072-e130-4528-ac83-ce839749c626","","",false, this);
 
            bAll = RPSControlFactory.CreateRPSCheckBox<QualityCostVMCollectionView>("3bae3553-dbf6-41d1-911f-f9674927f68d","","",false, this);
 
            MonthSelection = RPSControlFactory.CreateRPSEnumComboBox<QualityCostVMCollectionView>("663f0705-2115-429b-a248-28a642b56818","","",false, this);
 
            ExecuteInsertQualityCostButton = RPSControlFactory.CreateRPSButton<QualityCostVMCollectionView>( "99ddedf6-452f-47fe-ba6d-633aced53805","","",this);
 
            CollectionInit params_QualityCostQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7ad70f4f-6161-4daf-9196-a2057b8d2c0b",CSSSelectorGrid="",XPathGrid=""};
            QualityCostQuery = RPSControlFactory.RPSCreateCollectionWithGrid<QualityCostQueryCollectionEditor<QualityCostVMCollectionView,QualityCostVMEntityView>,QualityCostVMCollectionView,QualityCostVMEntityView>( params_QualityCostQuery,this,Screen.QualityCostVMEntityView);
 

        }
        public IRPSComboBox<QualityCostVMCollectionView> eType { get; set; } 
        public IRPSTextBox<QualityCostVMCollectionView> Year { get; set; } 
        public IRPSCheckbox<QualityCostVMCollectionView> bAll { get; set; } 
        public IRPSComboBox<QualityCostVMCollectionView> MonthSelection { get; set; } 
        public IRPSButton<QualityCostVMCollectionView> ExecuteInsertQualityCostButton { get; set; } 
        public QualityCostQueryCollectionEditor<QualityCostVMCollectionView,QualityCostVMEntityView> QualityCostQuery { get; set; } 
        public QualityCost Screen { get; set; }
        public QualityCostVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QualityCostQueryCollectionEditor<QualityCostVMCollectionView,QualityCostVMEntityView>:RPSCollectionEditor<QualityCostVMCollectionView,QualityCostVMEntityView> where QualityCostVMCollectionView : class, IView where QualityCostVMEntityView : class, IView
    {
        public  QualityCostQueryGridView<QualityCostVMCollectionView,QualityCostVMEntityView> GridView {get;set;}
    }
    public partial class QualityCostQueryGridView <QualityCostVMCollectionView,QualityCostVMEntityView> :  RPSGridView<QualityCostVMCollectionView,QualityCostVMEntityView> where QualityCostVMCollectionView : class, IView where QualityCostVMEntityView : class, IView
    {
        public QualityCostQueryGridView(QualityCostVMCollectionView currentView,QualityCostVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostGroup = RPSControlFactory.CreateRPSGridComboBox<QualityCostVMCollectionView>("","#7ad70f4f-6161-4daf-9196-a2057b8d2c0b .ag-row[role='row']@ROWINDEX [col-id='cIDCostGroup']","",false, this.CurrentView);
 
            OtherCostGroup = RPSControlFactory.CreateRPSGridTextBox<QualityCostVMCollectionView>("","#7ad70f4f-6161-4daf-9196-a2057b8d2c0b .ag-row[role='row']@ROWINDEX [col-id='cOtherCostGroup']","",false, this.CurrentView);
 
            Year = RPSControlFactory.CreateRPSGridFormattedTextBox<QualityCostVMCollectionView>("","#7ad70f4f-6161-4daf-9196-a2057b8d2c0b .ag-row[role='row']@ROWINDEX [col-id='cYear']","",true, this.CurrentView);
 
            MonthName = RPSControlFactory.CreateRPSGridTextBox<QualityCostVMCollectionView>("","#7ad70f4f-6161-4daf-9196-a2057b8d2c0b .ag-row[role='row']@ROWINDEX [col-id='cMonthName']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<QualityCostVMCollectionView> IDCostGroup { get; set; } 
        public IRPSGridTextBox<QualityCostVMCollectionView> OtherCostGroup { get; set; } 
        public IRPSGridTextBox<QualityCostVMCollectionView> Year { get; set; } 
        public IRPSGridTextBox<QualityCostVMCollectionView> MonthName { get; set; } 
                     
    }
 
    }
  
            
    public partial class QualityCostVMEntityView : View
    {
        public QualityCostVMEntityView(QualityCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualityCostVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualityCostVMEntityView,QualityCostVMCollectionView>( this,Screen.QualityCostVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualityCostVMEntityView,QualityCostVMCollectionView>( this,Screen.QualityCostVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QualityCostVMEntityView,QualityCostVMCollectionView>( this,Screen.QualityCostVMCollectionView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<QualityCostVMEntityView>("f3d47639-be74-4f41-9016-cef06075cb24","","",true, this);
 
            Year = RPSControlFactory.CreateRPSFormattedTextBox<QualityCostVMEntityView>("61611bfd-ec91-4908-a11f-f8ead44f913e","","",true, this);
 
            MonthName = RPSControlFactory.CreateRPSEnumComboBox<QualityCostVMEntityView>("a60dc4df-f4ab-4d1f-9387-0553f4822b1a","","",false, this);
 
            CostGroupMaster = RPSControlFactory.CreateRPSOption<QualityCostVMEntityView>( "5ff09c05-9773-4dcf-b1b3-8c84ee78c096","","",this);
 
            Other = RPSControlFactory.CreateRPSOption<QualityCostVMEntityView>( "3e71591b-3a74-4335-bd1d-010460e15524","","",this);
 
            IDCostGroup = RPSControlFactory.CreateRPSComboBox<QualityCostVMEntityView>("3f91e37f-1b87-4f05-b4e8-3799c767bb6e","","",false, this);
 
            CodCostGroup = RPSControlFactory.CreateRPSTextBox<QualityCostVMEntityView>("0bd88bcf-1b42-4c37-87a7-1dedbcd16387","","",true, this);
 
            CostGroup = RPSControlFactory.CreateRPSTextBox<QualityCostVMEntityView>("16d5f42b-ce25-44cf-a1d5-bb26d7e17ebb","","",false, this);
 
            CollectionInit params_QualityCostDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b584c993-7964-420f-a2e7-51c678655745",CSSSelectorGrid="",XPathGrid=""};
            QualityCostDetails = RPSControlFactory.RPSCreateCollectionWithGrid<QualityCostDetailsCollectionEditor<QualityCostVMEntityView,QualityCostDetailView>,QualityCostVMEntityView,QualityCostDetailView>( params_QualityCostDetails,this,Screen.QualityCostDetailView);
 

        }
        public IRPSButton<QualityCostVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualityCostVMEntityView,QualityCostVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualityCostVMEntityView,QualityCostVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<QualityCostVMEntityView,QualityCostVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<QualityCostVMEntityView> Type { get; set; } 
        public IRPSTextBox<QualityCostVMEntityView> Year { get; set; } 
        public IRPSComboBox<QualityCostVMEntityView> MonthName { get; set; } 
        public IRPSOption<QualityCostVMEntityView> CostGroupMaster { get; set; } 
        public IRPSOption<QualityCostVMEntityView> Other { get; set; } 
        public IRPSComboBox<QualityCostVMEntityView> IDCostGroup { get; set; } 
        public IRPSTextBox<QualityCostVMEntityView> CodCostGroup { get; set; } 
        public IRPSTextBox<QualityCostVMEntityView> CostGroup { get; set; } 
        public QualityCostDetailsCollectionEditor<QualityCostVMEntityView,QualityCostDetailView> QualityCostDetails { get; set; } 
        public QualityCost Screen { get; set; }
        public QualityCostVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QualityCostDetailsCollectionEditor<QualityCostVMEntityView,QualityCostDetailView>:RPSCollectionEditor<QualityCostVMEntityView,QualityCostDetailView> where QualityCostVMEntityView : class, IView where QualityCostDetailView : class, IView
    {
        public  QualityCostDetailsGridView<QualityCostVMEntityView,QualityCostDetailView> GridView {get;set;}
    }
    public partial class QualityCostDetailsGridView <QualityCostVMEntityView,QualityCostDetailView> :  RPSGridView<QualityCostVMEntityView,QualityCostDetailView> where QualityCostVMEntityView : class, IView where QualityCostDetailView : class, IView
    {
        public QualityCostDetailsGridView(QualityCostVMEntityView currentView,QualityCostDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostConcept = RPSControlFactory.CreateRPSGridComboBox<QualityCostVMEntityView>("","#b584c993-7964-420f-a2e7-51c678655745 .ag-row[role='row']@ROWINDEX [col-id='cIDCostConcept']","",false, this.CurrentView);
 
            CostConcept = RPSControlFactory.CreateRPSGridTextBox<QualityCostVMEntityView>("","#b584c993-7964-420f-a2e7-51c678655745 .ag-row[role='row']@ROWINDEX [col-id='cCostConcept']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<QualityCostVMEntityView>("","#b584c993-7964-420f-a2e7-51c678655745 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QualityCostVMEntityView>("","#b584c993-7964-420f-a2e7-51c678655745 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<QualityCostVMEntityView>("","#b584c993-7964-420f-a2e7-51c678655745 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<QualityCostVMEntityView> IDCostConcept { get; set; } 
        public IRPSGridTextBox<QualityCostVMEntityView> CostConcept { get; set; } 
        public IRPSGridTextBox<QualityCostVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<QualityCostVMEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<QualityCostVMEntityView> Price { get; set; } 
                     
    }
 
    }
  
            
    public partial class QualityCostDetailView : View
    {
        public QualityCostDetailView(QualityCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualityCostDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualityCostDetailView,QualityCostVMEntityView>( this,Screen.QualityCostVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualityCostDetailView,QualityCostVMEntityView>( this,Screen.QualityCostVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QualityCostDetailView,QualityCostVMEntityView>( this,Screen.QualityCostVMEntityView);
 
            IDCostConcept = RPSControlFactory.CreateRPSComboBox<QualityCostDetailView>("f4125f05-dc6a-40eb-81fe-b66806f3323c","","",false, this);
 
            CostConcept = RPSControlFactory.CreateRPSTextBox<QualityCostDetailView>("23ec06d9-74a9-4795-856a-6842469d0d18","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<QualityCostDetailView>("10d76461-0f1c-49dc-822f-57249c8f6d5e","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QualityCostDetailView>("f494ba03-39a1-4e6b-b3f2-c8b29556e332","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<QualityCostDetailView>("563143e6-4336-4a94-8fc5-8882043f04d0","","",true, this);
 

        }
        public IRPSButton<QualityCostDetailView> DeleteButton { get; set; } 
        public IRPSButton<QualityCostDetailView,QualityCostVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualityCostDetailView,QualityCostVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QualityCostDetailView,QualityCostVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<QualityCostDetailView> IDCostConcept { get; set; } 
        public IRPSTextBox<QualityCostDetailView> CostConcept { get; set; } 
        public IRPSTextBox<QualityCostDetailView> Amount { get; set; } 
        public IRPSTextBox<QualityCostDetailView> Quantity { get; set; } 
        public IRPSTextBox<QualityCostDetailView> Price { get; set; } 
        public QualityCost Screen { get; set; }
        public QualityCostDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}