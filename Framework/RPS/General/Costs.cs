    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Costs
{
    //RPS VERSION 1.0.0.0
    public partial class Costs:Screen
    {
        public Costs():base()
        {
            this.URL = "general.costs";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostsView  = new CostsView(this); 
            EmployeeCostView  = new EmployeeCostView(this); 
            QualifyCostView  = new QualifyCostView(this); 
            CostsView.InitializeControls(); 
            EmployeeCostView.InitializeControls(); 
            QualifyCostView.InitializeControls(); 
           
        }
      
            public CostsView CostsView {get; set; } 
            public EmployeeCostView EmployeeCostView {get; set; } 
            public QualifyCostView QualifyCostView {get; set; } 
    }
            
    public partial class CostsView : View
    {
        public CostsView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<CostsView>("f36624de-991b-425f-9cab-e941dbdffe16","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<CostsView>("9e9e0f41-53d5-4237-87c7-96150cc1bc4b","","",false, this);
 
            UIlsIDHourType = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("589d9648-505d-41d2-b8a7-e099527b673c","","",false, this);
 
            FilterByEmployee = RPSControlFactory.CreateRPSCheckBox<CostsView>("e925d462-87d1-4dd1-8b12-2d7576e234e1","","",false, this);
 
            UIlsIDEmployee = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("0454e79c-2bf5-41e5-b620-c27df7edba62","","",false, this);
 
            FilterByQualify = RPSControlFactory.CreateRPSCheckBox<CostsView>("ea947dfc-e791-4dc7-9c1f-8d57faac8de1","","",false, this);
 
            UIlsIDQualify = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("1474c171-bdce-45a4-a849-28ce7caef3e6","","",false, this);
 
            ExecuteQuery = RPSControlFactory.CreateRPSButton<CostsView>( "4c1e105e-b1e0-44bd-93de-503f4f505443","","",this);
 
            LinkNavigationNewEmployeeCost = RPSControlFactory.CreateRPSButton<CostsView>( "420c1990-cb22-43fc-8907-d9fc9745ba7f","","",this);
 
            LinkNavigationNewQualifyCost = RPSControlFactory.CreateRPSButton<CostsView>( "c17bf95f-cb66-4ab0-acfc-8c6efdeadc1b","","",this);
 
            CollectionInit params_EmployeeCostConsult = new CollectionInit(){IDDescriptor = "b97a8f28-5756-43cf-8965-383b3d0c17da",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c8b5a5de-b0a5-403b-bc1e-4f8d16e1d94f",CSSSelectorGrid="",XPathGrid=""};
            EmployeeCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeCostConsultCollectionEditor<CostsView>,CostsView>( params_EmployeeCostConsult,this);
 
            CollectionInit params_QualifyCostConsult = new CollectionInit(){IDDescriptor = "6304dafa-19fd-431b-ad39-f6fef6d5dbc5",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a6d9acd3-e55d-4cb1-a90b-4efea6918bcc",CSSSelectorGrid="",XPathGrid=""};
            QualifyCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<QualifyCostConsultCollectionEditor<CostsView>,CostsView>( params_QualifyCostConsult,this);
 
            EmployeeCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='b90e1db0-18a8-4815-b8e0-c10dc6c885eb']","",this);
 
            QualifyCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='83018af5-f869-4959-83d6-e1433dfad649']","",this);
 

        }
        public IRPSTextBox<CostsView> UIDateFrom { get; set; } 
        public IRPSTextBox<CostsView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDHourType { get; set; } 
        public IRPSCheckbox<CostsView> FilterByEmployee { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDEmployee { get; set; } 
        public IRPSCheckbox<CostsView> FilterByQualify { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDQualify { get; set; } 
        public IRPSButton<CostsView> ExecuteQuery { get; set; } 
        public IRPSButton<CostsView> LinkNavigationNewEmployeeCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationNewQualifyCost { get; set; } 
        public EmployeeCostConsultCollectionEditor<CostsView> EmployeeCostConsult { get; set; } 
        public QualifyCostConsultCollectionEditor<CostsView> QualifyCostConsult { get; set; } 
        public IRPSSection<CostsView> EmployeeCost { get; set; } 
        public IRPSSection<CostsView> QualifyCost { get; set; } 
        public Costs Screen { get; set; }
        public CostsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeeCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  EmployeeCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class EmployeeCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public EmployeeCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EmployeeCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#c8b5a5de-b0a5-403b-bc1e-4f8d16e1d94f .ag-row[role='row']@ROWINDEX [col-id='cEmployeeCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> EmployeeCost_DateFrom { get; set; } 
                     
    }
 
        public partial class QualifyCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  QualifyCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class QualifyCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public QualifyCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            QualifyCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#a6d9acd3-e55d-4cb1-a90b-4efea6918bcc .ag-row[role='row']@ROWINDEX [col-id='cQualifyCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> QualifyCost_DateFrom { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmployeeCostView : View
    {
        public EmployeeCostView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeCostView>( this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<EmployeeCostView>("152f59d5-e5e3-4ff7-abf6-5896e43a1431","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<EmployeeCostView>("11b08270-8a04-4fef-9fdf-0a491e35bcbd","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<EmployeeCostView>("416b64c8-8c1e-4a17-8950-e2dbfcbcee8d","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeCostView>("ed5bf9a7-ce29-4191-9e32-81a45fc7039b","","",true, this);
 

        }
        public IRPSSaveButton<EmployeeCostView> SaveButton { get; set; } 
        public IRPSComboBox<EmployeeCostView> IDEmployee { get; set; } 
        public IRPSComboBox<EmployeeCostView> IDHourType { get; set; } 
        public IRPSTextBox<EmployeeCostView> DateFrom { get; set; } 
        public IRPSTextBox<EmployeeCostView> CostPrice { get; set; } 
        public Costs Screen { get; set; }
        public EmployeeCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualifyCostView : View
    {
        public QualifyCostView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyCostView>( this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<QualifyCostView>("f469c429-8eb5-444c-aec9-24cafb1401f1","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<QualifyCostView>("f23b0fc7-f421-4a37-bf22-dfed51ce5004","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<QualifyCostView>("204686a5-a61f-409a-adf4-040158adc625","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QualifyCostView>("c67a9d1e-9f3e-4316-b691-a5c5cae12d6f","","",true, this);
 

        }
        public IRPSSaveButton<QualifyCostView> SaveButton { get; set; } 
        public IRPSComboBox<QualifyCostView> IDQualify { get; set; } 
        public IRPSComboBox<QualifyCostView> IDHourType { get; set; } 
        public IRPSTextBox<QualifyCostView> DateFrom { get; set; } 
        public IRPSTextBox<QualifyCostView> CostPrice { get; set; } 
        public Costs Screen { get; set; }
        public QualifyCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}