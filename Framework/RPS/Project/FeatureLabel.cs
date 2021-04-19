    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.FeatureLabel
{
    //RPS VERSION 1.0.0.0
    public partial class FeatureLabel:Screen
    {
        public FeatureLabel():base()
        {
            this.URL = "project.featurelabel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeatureLabelCollectionView  = new FeatureLabelCollectionView(this); 
            FeatureLabelEntityView  = new FeatureLabelEntityView(this); 
            FeatureLabelCollectionView.InitializeControls(); 
            FeatureLabelEntityView.InitializeControls(); 
           
        }
      
            public FeatureLabelCollectionView FeatureLabelCollectionView {get; set; } 
            public FeatureLabelEntityView FeatureLabelEntityView {get; set; } 
    }
            
    public partial class FeatureLabelCollectionView : View
    {
        public FeatureLabelCollectionView(FeatureLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeatureLabelCollectionView,FeatureLabelEntityView>( this,Screen.FeatureLabelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "234cdb6b-7bec-4315-9531-5838e3cfd364",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeatureLabelCollectionView,FeatureLabelEntityView>( params_MainConsult,this,Screen.FeatureLabelEntityView);
 

        }
        public IRPSButton<FeatureLabelCollectionView,FeatureLabelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeatureLabelCollectionView,FeatureLabelEntityView> MainConsult { get; set; } 
        public FeatureLabel Screen { get; set; }
        public FeatureLabelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeatureLabelEntityView : View
    {
        public FeatureLabelEntityView(FeatureLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeatureLabelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeatureLabelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeatureLabelEntityView,FeatureLabelCollectionView>( this,Screen.FeatureLabelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeatureLabelEntityView,FeatureLabelCollectionView>( this,Screen.FeatureLabelCollectionView);
 
            CodFeatureLabel = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("aad029fc-a91d-45c6-8781-c643f9b02b0e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("ffdcca65-ee67-4eac-bc04-12a246cf8a27","","",false, this);
 
            IDPROFeatureVariableTable = RPSControlFactory.CreateRPSComboBox<FeatureLabelEntityView>("6df0e90d-c957-41b5-9f38-d789aba784aa","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<FeatureLabelEntityView>("e4071c05-35b4-43e5-a2e9-4c419f009d58","","",true, this);
 
            MinDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("bc0ef09a-9901-485b-9868-e1418c0c05bc","","",false, this);
 
            MaxDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("e204b24b-bb2c-4404-9b95-e94c6d6bbddd","","",false, this);
 
            DefaultDate = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("8f9d77de-68b7-435d-91e9-d473cea0052c","","",false, this);
 
            MinDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("9f9a4547-d0d0-4788-a9a9-ae7805386184","","",false, this);
 
            MaxDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("ed72537e-e6b2-4306-ad6f-0630c3bb0b13","","",false, this);
 
            DefaultDecimal = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("60ccd398-9ba0-4854-a7e9-bf1fe67fe6bd","","",false, this);
 
            MinInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("23818c3f-9d28-4056-af3b-179f7dc88dac","","",false, this);
 
            MaxInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("11b67468-917e-4d70-aac5-21b7655bbb01","","",false, this);
 
            DefaultInteger = RPSControlFactory.CreateRPSFormattedTextBox<FeatureLabelEntityView>("61a2423b-1342-4138-af82-7a40b8a6b1fd","","",false, this);
 
            MinString = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("66013546-a59a-40c5-a6b3-badf06420499","","",false, this);
 
            MaxString = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("c89b00a8-1316-4dfa-960e-aa5b80752c7a","","",false, this);
 
            DefaultString = RPSControlFactory.CreateRPSTextBox<FeatureLabelEntityView>("dfc9ce21-ab48-4348-8555-0ba95d136a9f","","",false, this);
 

        }
        public IRPSSaveButton<FeatureLabelEntityView> SaveButton { get; set; } 
        public IRPSButton<FeatureLabelEntityView> DeleteButton { get; set; } 
        public IRPSButton<FeatureLabelEntityView,FeatureLabelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeatureLabelEntityView,FeatureLabelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> CodFeatureLabel { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> Description { get; set; } 
        public IRPSComboBox<FeatureLabelEntityView> IDPROFeatureVariableTable { get; set; } 
        public IRPSComboBox<FeatureLabelEntityView> DataType { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MinDate { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MaxDate { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> DefaultDate { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MinDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MaxDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> DefaultDecimal { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MinInteger { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MaxInteger { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> DefaultInteger { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MinString { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> MaxString { get; set; } 
        public IRPSTextBox<FeatureLabelEntityView> DefaultString { get; set; } 
        public FeatureLabel Screen { get; set; }
        public FeatureLabelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}