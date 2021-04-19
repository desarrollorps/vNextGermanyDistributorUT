    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Severity
{
    //RPS VERSION 1.0.0.0
    public partial class Severity:Screen
    {
        public Severity():base()
        {
            this.URL = "quality.severity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SeverityCollectionView  = new SeverityCollectionView(this); 
            SeverityEntityView  = new SeverityEntityView(this); 
            SeverityCollectionView.InitializeControls(); 
            SeverityEntityView.InitializeControls(); 
           
        }
      
            public SeverityCollectionView SeverityCollectionView {get; set; } 
            public SeverityEntityView SeverityEntityView {get; set; } 
    }
            
    public partial class SeverityCollectionView : View
    {
        public SeverityCollectionView(Severity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SeverityCollectionView,SeverityEntityView>( this,Screen.SeverityEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bd76c7a6-4ef7-47b8-907c-e183629a8f2d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SeverityCollectionView,SeverityEntityView>( params_MainConsult,this,Screen.SeverityEntityView);
 

        }
        public IRPSButton<SeverityCollectionView,SeverityEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SeverityCollectionView,SeverityEntityView> MainConsult { get; set; } 
        public Severity Screen { get; set; }
        public SeverityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SeverityEntityView : View
    {
        public SeverityEntityView(Severity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SeverityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SeverityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SeverityEntityView,SeverityCollectionView>( this,Screen.SeverityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SeverityEntityView,SeverityCollectionView>( this,Screen.SeverityCollectionView);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<SeverityEntityView>("40012383-dd75-4aed-91c4-5f9476ca6ce1","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SeverityEntityView>("0d461096-8bdb-4011-9235-1a8b0168bb15","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SeverityEntityView>("d4b7c158-7fe2-440e-be60-382f33b61613","","",false, this);
 

        }
        public IRPSSaveButton<SeverityEntityView> SaveButton { get; set; } 
        public IRPSButton<SeverityEntityView> DeleteButton { get; set; } 
        public IRPSButton<SeverityEntityView,SeverityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SeverityEntityView,SeverityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SeverityEntityView> Value { get; set; } 
        public IRPSComboBox<SeverityEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<SeverityEntityView> Description { get; set; } 
        public Severity Screen { get; set; }
        public SeverityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}