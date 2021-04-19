    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Characteristic
{
    //RPS VERSION 1.0.0.0
    public partial class Characteristic:Screen
    {
        public Characteristic():base()
        {
            this.URL = "quality.characteristic";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CharacteristicCollectionView  = new CharacteristicCollectionView(this); 
            CharacteristicEntityView  = new CharacteristicEntityView(this); 
            CharacteristicByLangView  = new CharacteristicByLangView(this); 
            CharacteristicCollectionView.InitializeControls(); 
            CharacteristicEntityView.InitializeControls(); 
            CharacteristicByLangView.InitializeControls(); 
           
        }
      
            public CharacteristicCollectionView CharacteristicCollectionView {get; set; } 
            public CharacteristicEntityView CharacteristicEntityView {get; set; } 
            public CharacteristicByLangView CharacteristicByLangView {get; set; } 
    }
            
    public partial class CharacteristicCollectionView : View
    {
        public CharacteristicCollectionView(Characteristic screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CharacteristicCollectionView,CharacteristicEntityView>( this,Screen.CharacteristicEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8059c55a-6a43-446e-91a9-658a10390a79",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CharacteristicCollectionView,CharacteristicEntityView>( params_MainConsult,this,Screen.CharacteristicEntityView);
 

        }
        public IRPSButton<CharacteristicCollectionView,CharacteristicEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CharacteristicCollectionView,CharacteristicEntityView> MainConsult { get; set; } 
        public Characteristic Screen { get; set; }
        public CharacteristicCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CharacteristicEntityView : View
    {
        public CharacteristicEntityView(Characteristic screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CharacteristicEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicEntityView,CharacteristicCollectionView>( this,Screen.CharacteristicCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicEntityView,CharacteristicCollectionView>( this,Screen.CharacteristicCollectionView);
 
            CodCharacteristic = RPSControlFactory.CreateRPSTextBox<CharacteristicEntityView>("7b141549-2428-45a5-892c-b82e04131e5a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicEntityView>("655d1e1f-47f5-4783-985a-f7beea40e349","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicEntityView>("7337866b-6187-4627-b45d-59901a9faab0","","",false, this);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSComboBox<CharacteristicEntityView>("68aa1b47-1dbb-4064-ba71-ef7869647084","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicEntityView>("eaf1f167-8b14-4d59-95ae-cad053059e3f","","",false, this);
 
            PotencyControl = RPSControlFactory.CreateRPSCheckBox<CharacteristicEntityView>("60d538d4-ab7d-4081-8895-f36d1f416185","","",true, this);
 
            CollectionInit params_CharacteristicByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ca7aa9a-8e14-40d7-91b8-63d9bb3326b4",CSSSelectorGrid="",XPathGrid=""};
            CharacteristicByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CharacteristicByLangsCollectionEditor<CharacteristicEntityView,CharacteristicByLangView>,CharacteristicEntityView,CharacteristicByLangView>( params_CharacteristicByLangs,this,Screen.CharacteristicByLangView);
 

        }
        public IRPSSaveButton<CharacteristicEntityView> SaveButton { get; set; } 
        public IRPSButton<CharacteristicEntityView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicEntityView,CharacteristicCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicEntityView,CharacteristicCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CharacteristicEntityView> CodCharacteristic { get; set; } 
        public IRPSTextBox<CharacteristicEntityView> Description { get; set; } 
        public IRPSComboBox<CharacteristicEntityView> Type { get; set; } 
        public IRPSComboBox<CharacteristicEntityView> IDCharacteristicType { get; set; } 
        public IRPSComboBox<CharacteristicEntityView> ControlType { get; set; } 
        public IRPSCheckbox<CharacteristicEntityView> PotencyControl { get; set; } 
        public CharacteristicByLangsCollectionEditor<CharacteristicEntityView,CharacteristicByLangView> CharacteristicByLangs { get; set; } 
        public Characteristic Screen { get; set; }
        public CharacteristicEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CharacteristicByLangsCollectionEditor<CharacteristicEntityView,CharacteristicByLangView>:RPSCollectionEditor<CharacteristicEntityView,CharacteristicByLangView> where CharacteristicEntityView : class, IView where CharacteristicByLangView : class, IView
    {
        public  CharacteristicByLangsGridView<CharacteristicEntityView,CharacteristicByLangView> GridView {get;set;}
    }
    public partial class CharacteristicByLangsGridView <CharacteristicEntityView,CharacteristicByLangView> :  RPSGridView<CharacteristicEntityView,CharacteristicByLangView> where CharacteristicEntityView : class, IView where CharacteristicByLangView : class, IView
    {
        public CharacteristicByLangsGridView(CharacteristicEntityView currentView,CharacteristicByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CharacteristicEntityView>("","#2ca7aa9a-8e14-40d7-91b8-63d9bb3326b4 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CharacteristicEntityView>("","#2ca7aa9a-8e14-40d7-91b8-63d9bb3326b4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CharacteristicEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CharacteristicEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CharacteristicByLangView : View
    {
        public CharacteristicByLangView(Characteristic screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicByLangView,CharacteristicEntityView>( this,Screen.CharacteristicEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicByLangView,CharacteristicEntityView>( this,Screen.CharacteristicEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CharacteristicByLangView,CharacteristicEntityView>( this,Screen.CharacteristicEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CharacteristicByLangView>("44ce1a31-68a6-4f0f-a676-4f162f2385af","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicByLangView>("b0f196ac-a596-4fdd-9939-72741cce4039","","",false, this);
 

        }
        public IRPSButton<CharacteristicByLangView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicByLangView,CharacteristicEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicByLangView,CharacteristicEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CharacteristicByLangView,CharacteristicEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CharacteristicByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CharacteristicByLangView> Description { get; set; } 
        public Characteristic Screen { get; set; }
        public CharacteristicByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}