    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ZipCode
{
    //RPS VERSION 1.0.0.0
    public partial class ZipCode:Screen
    {
        public ZipCode():base()
        {
            this.URL = "general.zipcode";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ZipCodeVMQueryView  = new ZipCodeVMQueryView(this); 
            ZipCodeVMEntityView  = new ZipCodeVMEntityView(this); 
            ZipCodeVMQueryView.InitializeControls(); 
            ZipCodeVMEntityView.InitializeControls(); 
           
        }
      
            public ZipCodeVMQueryView ZipCodeVMQueryView {get; set; } 
            public ZipCodeVMEntityView ZipCodeVMEntityView {get; set; } 
    }
            
    public partial class ZipCodeVMQueryView : View
    {
        public ZipCodeVMQueryView(ZipCode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ZipCodeVMQueryView,ZipCodeVMEntityView>( this,Screen.ZipCodeVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ZipCodeVMQueryView>( this);
 
            Country = RPSControlFactory.CreateRPSComboBox<ZipCodeVMQueryView>("38c4ab10-764e-464e-93ff-7f23453a673e","","",false, this);
 
            State = RPSControlFactory.CreateRPSComboBox<ZipCodeVMQueryView>("1a25ae91-c639-463a-b684-72abc3623a61","","",false, this);
 
            County = RPSControlFactory.CreateRPSComboBox<ZipCodeVMQueryView>("3e8e7fed-95ba-4714-aab5-200e11ccaa20","","",false, this);
 
            CollectionInit params_CountryZipCodeSelection = new CollectionInit(){IDDescriptor = "191c0ebb-e46d-4121-9d96-9a846d404d4a",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7b979cc2-a9e7-4d34-8847-540b8ad4521d",CSSSelectorGrid="",XPathGrid=""};
            CountryZipCodeSelection = RPSControlFactory.RPSCreateCollectionWithGrid<CountryZipCodeSelectionCollectionEditor<ZipCodeVMQueryView,ZipCodeVMEntityView>,ZipCodeVMQueryView,ZipCodeVMEntityView>( params_CountryZipCodeSelection,this,Screen.ZipCodeVMEntityView);
 

        }
        public IRPSButton<ZipCodeVMQueryView,ZipCodeVMEntityView> NewButton { get; set; } 
        public IRPSButton<ZipCodeVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ZipCodeVMQueryView> Country { get; set; } 
        public IRPSComboBox<ZipCodeVMQueryView> State { get; set; } 
        public IRPSComboBox<ZipCodeVMQueryView> County { get; set; } 
        public CountryZipCodeSelectionCollectionEditor<ZipCodeVMQueryView,ZipCodeVMEntityView> CountryZipCodeSelection { get; set; } 
        public ZipCode Screen { get; set; }
        public ZipCodeVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CountryZipCodeSelectionCollectionEditor<ZipCodeVMQueryView,ZipCodeVMEntityView>:RPSCollectionEditor<ZipCodeVMQueryView,ZipCodeVMEntityView> where ZipCodeVMQueryView : class, IView where ZipCodeVMEntityView : class, IView
    {
        public  CountryZipCodeSelectionGridView<ZipCodeVMQueryView,ZipCodeVMEntityView> GridView {get;set;}
    }
    public partial class CountryZipCodeSelectionGridView <ZipCodeVMQueryView,ZipCodeVMEntityView> :  RPSGridView<ZipCodeVMQueryView,ZipCodeVMEntityView> where ZipCodeVMQueryView : class, IView where ZipCodeVMEntityView : class, IView
    {
        public CountryZipCodeSelectionGridView(ZipCodeVMQueryView currentView,ZipCodeVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ZipCode_CodZipCode = RPSControlFactory.CreateRPSGridTextBox<ZipCodeVMQueryView>("","#7b979cc2-a9e7-4d34-8847-540b8ad4521d .ag-row[role='row']@ROWINDEX [col-id='cZipCode_CodZipCode']","",false, this.CurrentView);
 
            ZipCode_City = RPSControlFactory.CreateRPSGridTextBox<ZipCodeVMQueryView>("","#7b979cc2-a9e7-4d34-8847-540b8ad4521d .ag-row[role='row']@ROWINDEX [col-id='cZipCode_City']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ZipCodeVMQueryView> ZipCode_CodZipCode { get; set; } 
        public IRPSGridTextBox<ZipCodeVMQueryView> ZipCode_City { get; set; } 
                     
    }
 
    }
  
            
    public partial class ZipCodeVMEntityView : View
    {
        public ZipCodeVMEntityView(ZipCode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ZipCodeVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ZipCodeVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ZipCodeVMEntityView,ZipCodeVMQueryView>( this,Screen.ZipCodeVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ZipCodeVMEntityView,ZipCodeVMQueryView>( this,Screen.ZipCodeVMQueryView);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<ZipCodeVMEntityView>("e7b8ec26-1396-451e-9e6d-b65417b5ec6f","","",true, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<ZipCodeVMEntityView>("3955d36c-1cbd-4b61-9050-50c9bfa03f83","","",true, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<ZipCodeVMEntityView>("e0cba381-46a2-4dc7-b7b1-a4e0e283eace","","",true, this);
 
            CodZipCode = RPSControlFactory.CreateRPSTextBox<ZipCodeVMEntityView>("65e67531-c8ea-486a-9337-6046e5bba1f1","","",true, this);
 
            City = RPSControlFactory.CreateRPSTextBox<ZipCodeVMEntityView>("283dda7f-cbcf-467e-9160-d4b2c4d7cfd3","","",false, this);
 

        }
        public IRPSSaveButton<ZipCodeVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ZipCodeVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ZipCodeVMEntityView,ZipCodeVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ZipCodeVMEntityView,ZipCodeVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ZipCodeVMEntityView> CodCountry { get; set; } 
        public IRPSComboBox<ZipCodeVMEntityView> IDState { get; set; } 
        public IRPSComboBox<ZipCodeVMEntityView> IDCounty { get; set; } 
        public IRPSTextBox<ZipCodeVMEntityView> CodZipCode { get; set; } 
        public IRPSTextBox<ZipCodeVMEntityView> City { get; set; } 
        public ZipCode Screen { get; set; }
        public ZipCodeVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}