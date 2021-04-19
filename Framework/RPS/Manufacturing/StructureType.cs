    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.StructureType
{
    //RPS VERSION 1.0.0.0
    public partial class StructureType:Screen
    {
        public StructureType():base()
        {
            this.URL = "manufacturing.structuretype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StructureTypeCollectionView  = new StructureTypeCollectionView(this); 
            StructureTypeEntityView  = new StructureTypeEntityView(this); 
            StructureTypeCollectionView.InitializeControls(); 
            StructureTypeEntityView.InitializeControls(); 
           
        }
      
            public StructureTypeCollectionView StructureTypeCollectionView {get; set; } 
            public StructureTypeEntityView StructureTypeEntityView {get; set; } 
    }
            
    public partial class StructureTypeCollectionView : View
    {
        public StructureTypeCollectionView(StructureType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StructureTypeCollectionView,StructureTypeEntityView>( this,Screen.StructureTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3f0cae0a-866b-4b91-b176-e0875a722e5a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StructureTypeCollectionView,StructureTypeEntityView>( params_MainConsult,this,Screen.StructureTypeEntityView);
 

        }
        public IRPSButton<StructureTypeCollectionView,StructureTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StructureTypeCollectionView,StructureTypeEntityView> MainConsult { get; set; } 
        public StructureType Screen { get; set; }
        public StructureTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureTypeEntityView : View
    {
        public StructureTypeEntityView(StructureType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StructureTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StructureTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StructureTypeEntityView,StructureTypeCollectionView>( this,Screen.StructureTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StructureTypeEntityView,StructureTypeCollectionView>( this,Screen.StructureTypeCollectionView);
 
            CodStructureType = RPSControlFactory.CreateRPSTextBox<StructureTypeEntityView>("94e7bdc6-3379-48bf-8edb-15b329dcc3cb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StructureTypeEntityView>("de04ff97-2fce-4c35-9179-11aeaa4f0c21","","",false, this);
 

        }
        public IRPSSaveButton<StructureTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<StructureTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<StructureTypeEntityView,StructureTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StructureTypeEntityView,StructureTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StructureTypeEntityView> CodStructureType { get; set; } 
        public IRPSTextBox<StructureTypeEntityView> Description { get; set; } 
        public StructureType Screen { get; set; }
        public StructureTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}