    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.TestMethod
{
    //RPS VERSION 1.0.0.0
    public partial class TestMethod:Screen
    {
        public TestMethod():base()
        {
            this.URL = "maintenance.testmethod";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TestMethodCollectionView  = new TestMethodCollectionView(this); 
            TestMethodEntityView  = new TestMethodEntityView(this); 
            TestMethodCollectionView.InitializeControls(); 
            TestMethodEntityView.InitializeControls(); 
           
        }
      
            public TestMethodCollectionView TestMethodCollectionView {get; set; } 
            public TestMethodEntityView TestMethodEntityView {get; set; } 
    }
            
    public partial class TestMethodCollectionView : View
    {
        public TestMethodCollectionView(TestMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TestMethodCollectionView,TestMethodEntityView>( this,Screen.TestMethodEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d46e47cd-d98a-4879-81cf-b34b823e1161",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TestMethodCollectionView,TestMethodEntityView>( params_MainConsult,this,Screen.TestMethodEntityView);
 

        }
        public IRPSButton<TestMethodCollectionView,TestMethodEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TestMethodCollectionView,TestMethodEntityView> MainConsult { get; set; } 
        public TestMethod Screen { get; set; }
        public TestMethodCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TestMethodEntityView : View
    {
        public TestMethodEntityView(TestMethod screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TestMethodEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TestMethodEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TestMethodEntityView,TestMethodCollectionView>( this,Screen.TestMethodCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TestMethodEntityView,TestMethodCollectionView>( this,Screen.TestMethodCollectionView);
 
            CodTestMethod = RPSControlFactory.CreateRPSTextBox<TestMethodEntityView>("1240f4f1-cf0b-4ed2-a57f-4998cd768384","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TestMethodEntityView>("7d5af149-4385-4445-8639-92a3aed8686d","","",false, this);
 

        }
        public IRPSSaveButton<TestMethodEntityView> SaveButton { get; set; } 
        public IRPSButton<TestMethodEntityView> DeleteButton { get; set; } 
        public IRPSButton<TestMethodEntityView,TestMethodCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TestMethodEntityView,TestMethodCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TestMethodEntityView> CodTestMethod { get; set; } 
        public IRPSTextBox<TestMethodEntityView> Description { get; set; } 
        public TestMethod Screen { get; set; }
        public TestMethodEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}