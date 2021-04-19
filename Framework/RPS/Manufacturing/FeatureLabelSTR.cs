    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.FeatureLabelSTR
{
    //RPS VERSION 1.0.0.0
    public partial class FeatureLabelSTR:Screen
    {
        public FeatureLabelSTR():base()
        {
            this.URL = "manufacturing.featurelabelstr";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeatureLabelSTRCollectionView  = new FeatureLabelSTRCollectionView(this); 
            FeatureLabelSTREntityView  = new FeatureLabelSTREntityView(this); 
            FeatureLabelSTRCollectionView.InitializeControls(); 
            FeatureLabelSTREntityView.InitializeControls(); 
           
        }
      
            public FeatureLabelSTRCollectionView FeatureLabelSTRCollectionView {get; set; } 
            public FeatureLabelSTREntityView FeatureLabelSTREntityView {get; set; } 
    }
            
    public partial class FeatureLabelSTRCollectionView : View
    {
        public FeatureLabelSTRCollectionView(FeatureLabelSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeatureLabelSTRCollectionView,FeatureLabelSTREntityView>( this,Screen.FeatureLabelSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f9fb34d2-279c-4567-bc39-5017ffedaf83",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeatureLabelSTRCollectionView,FeatureLabelSTREntityView>( params_MainConsult,this,Screen.FeatureLabelSTREntityView);
 

        }
        public IRPSButton<FeatureLabelSTRCollectionView,FeatureLabelSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeatureLabelSTRCollectionView,FeatureLabelSTREntityView> MainConsult { get; set; } 
        public FeatureLabelSTR Screen { get; set; }
        public FeatureLabelSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeatureLabelSTREntityView : View
    {
        public FeatureLabelSTREntityView(FeatureLabelSTR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeatureLabelSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureLabelSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureLabelSTREntityView,FeatureLabelSTRCollectionView>( this,Screen.FeatureLabelSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureLabelSTREntityView,FeatureLabelSTRCollectionView>( this,Screen.FeatureLabelSTRCollectionView);
 
            CodFeatureLabel = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("eb222d41-e6f2-49ba-8cce-5bf1cef269b5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("c2bf411d-e45f-46f4-a9e3-034eadcf1137","","",false, this);
 
            IDFeatureVariableTable = RPSControlFactory.CreateRPSComboBox<FeatureLabelSTREntityView>("3e73e9c8-3d2c-4031-a237-d278a96eb40d","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<FeatureLabelSTREntityView>("974affab-48e7-4e66-a1ca-bf0bcae3258f","","",true, this);
 
            MinString = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("5c6e2d82-f22a-45dc-8a27-bc6f74754f34","","",false, this);
 
            MaxString = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("d6b64bda-1fad-4d89-8a6e-ef15e521cecf","","",false, this);
 
            DefaultString = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("4258673f-c277-4e08-b41b-63e26d7efde4","","",false, this);
 
            MinInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("16ee86e5-639d-45cd-af17-1307ced3d207","","",false, this);
 
            MaxInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("19396463-7db2-48f9-929a-5dda60aff5be","","",false, this);
 
            DefaultInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("700f2df9-1bf5-462d-82a4-6aff10c649bc","","",false, this);
 
            MinDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("2aa10eac-28ff-4f9c-b874-a2a4fbf77d51","","",false, this);
 
            MaxDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("696a6b22-67eb-4fef-8b3d-610ae0482e4e","","",false, this);
 
            DefaultDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelSTREntityView>("126de3be-1cdc-4b45-b5b7-6112941ee362","","",false, this);
 
            MinDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("e3199e8c-069c-45e8-8bcb-8decb5376174","","",false, this);
 
            MaxDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("e38d3427-7e34-424e-bda8-e9fa12ae9601","","",false, this);
 
            DefaultDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelSTREntityView>("25179d98-54c8-468f-86ad-adb4acd7782c","","",false, this);
 

        }
        public IRPSSaveButton<FeatureLabelSTREntityView> SaveButton { get; set; } 
        public IRPSButton<FeatureLabelSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<FeatureLabelSTREntityView,FeatureLabelSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureLabelSTREntityView,FeatureLabelSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> CodFeatureLabel { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> Description { get; set; } 
        public IRPSComboBox<FeatureLabelSTREntityView> IDFeatureVariableTable { get; set; } 
        public IRPSComboBox<FeatureLabelSTREntityView> DataType { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MinString { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MaxString { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> DefaultString { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MinInteger { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MaxInteger { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> DefaultInteger { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MinDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MaxDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> DefaultDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MinDate { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> MaxDate { get; set; } 
        public IRPSTextBox<FeatureLabelSTREntityView> DefaultDate { get; set; } 
        public FeatureLabelSTR Screen { get; set; }
        public FeatureLabelSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}