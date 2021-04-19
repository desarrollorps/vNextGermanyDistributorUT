    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.VerifyAndControl
{
    //RPS VERSION 1.0.0.0
    public partial class VerifyAndControl:Screen
    {
        public VerifyAndControl():base()
        {
            this.URL = "quality.verifyandcontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VerifyAndControlCollectionView  = new VerifyAndControlCollectionView(this); 
            VerifyAndControlEntityView  = new VerifyAndControlEntityView(this); 
            VerifyAndControlByLangView  = new VerifyAndControlByLangView(this); 
            VerifyAndControlCollectionView.InitializeControls(); 
            VerifyAndControlEntityView.InitializeControls(); 
            VerifyAndControlByLangView.InitializeControls(); 
           
        }
      
            public VerifyAndControlCollectionView VerifyAndControlCollectionView {get; set; } 
            public VerifyAndControlEntityView VerifyAndControlEntityView {get; set; } 
            public VerifyAndControlByLangView VerifyAndControlByLangView {get; set; } 
    }
            
    public partial class VerifyAndControlCollectionView : View
    {
        public VerifyAndControlCollectionView(VerifyAndControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VerifyAndControlCollectionView,VerifyAndControlEntityView>( this,Screen.VerifyAndControlEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f4e079ba-2130-47b8-8677-b4ddd3b45aa5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VerifyAndControlCollectionView,VerifyAndControlEntityView>( params_MainConsult,this,Screen.VerifyAndControlEntityView);
 

        }
        public IRPSButton<VerifyAndControlCollectionView,VerifyAndControlEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VerifyAndControlCollectionView,VerifyAndControlEntityView> MainConsult { get; set; } 
        public VerifyAndControl Screen { get; set; }
        public VerifyAndControlCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VerifyAndControlEntityView : View
    {
        public VerifyAndControlEntityView(VerifyAndControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VerifyAndControlEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VerifyAndControlEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VerifyAndControlEntityView,VerifyAndControlCollectionView>( this,Screen.VerifyAndControlCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VerifyAndControlEntityView,VerifyAndControlCollectionView>( this,Screen.VerifyAndControlCollectionView);
 
            CodVerify = RPSControlFactory.CreateRPSTextBox<VerifyAndControlEntityView>("26675e21-bac6-46f9-9042-c5ddb6f2dc70","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VerifyAndControlEntityView>("58c05eb3-0e19-4acf-bc34-ee9fe0f35b3a","","",false, this);
 
            CollectionInit params_VerifyAndControlByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a8ae10ad-1344-40e9-be80-5a1b9a1abb96",CSSSelectorGrid="",XPathGrid=""};
            VerifyAndControlByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<VerifyAndControlByLangsCollectionEditor<VerifyAndControlEntityView,VerifyAndControlByLangView>,VerifyAndControlEntityView,VerifyAndControlByLangView>( params_VerifyAndControlByLangs,this,Screen.VerifyAndControlByLangView);
 

        }
        public IRPSSaveButton<VerifyAndControlEntityView> SaveButton { get; set; } 
        public IRPSButton<VerifyAndControlEntityView> DeleteButton { get; set; } 
        public IRPSButton<VerifyAndControlEntityView,VerifyAndControlCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VerifyAndControlEntityView,VerifyAndControlCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VerifyAndControlEntityView> CodVerify { get; set; } 
        public IRPSTextBox<VerifyAndControlEntityView> Description { get; set; } 
        public VerifyAndControlByLangsCollectionEditor<VerifyAndControlEntityView,VerifyAndControlByLangView> VerifyAndControlByLangs { get; set; } 
        public VerifyAndControl Screen { get; set; }
        public VerifyAndControlEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VerifyAndControlByLangsCollectionEditor<VerifyAndControlEntityView,VerifyAndControlByLangView>:RPSCollectionEditor<VerifyAndControlEntityView,VerifyAndControlByLangView> where VerifyAndControlEntityView : class, IView where VerifyAndControlByLangView : class, IView
    {
        public  VerifyAndControlByLangsGridView<VerifyAndControlEntityView,VerifyAndControlByLangView> GridView {get;set;}
    }
    public partial class VerifyAndControlByLangsGridView <VerifyAndControlEntityView,VerifyAndControlByLangView> :  RPSGridView<VerifyAndControlEntityView,VerifyAndControlByLangView> where VerifyAndControlEntityView : class, IView where VerifyAndControlByLangView : class, IView
    {
        public VerifyAndControlByLangsGridView(VerifyAndControlEntityView currentView,VerifyAndControlByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<VerifyAndControlEntityView>("","#a8ae10ad-1344-40e9-be80-5a1b9a1abb96 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<VerifyAndControlEntityView>("","#a8ae10ad-1344-40e9-be80-5a1b9a1abb96 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<VerifyAndControlEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<VerifyAndControlEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class VerifyAndControlByLangView : View
    {
        public VerifyAndControlByLangView(VerifyAndControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VerifyAndControlByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VerifyAndControlByLangView,VerifyAndControlEntityView>( this,Screen.VerifyAndControlEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VerifyAndControlByLangView,VerifyAndControlEntityView>( this,Screen.VerifyAndControlEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VerifyAndControlByLangView,VerifyAndControlEntityView>( this,Screen.VerifyAndControlEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<VerifyAndControlByLangView>("b6c2a427-3d2a-41c3-8501-d1883c3c9994","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VerifyAndControlByLangView>("643b4470-bf39-4a06-b7bf-4e7da589318d","","",false, this);
 

        }
        public IRPSButton<VerifyAndControlByLangView> DeleteButton { get; set; } 
        public IRPSButton<VerifyAndControlByLangView,VerifyAndControlEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VerifyAndControlByLangView,VerifyAndControlEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VerifyAndControlByLangView,VerifyAndControlEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<VerifyAndControlByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<VerifyAndControlByLangView> Description { get; set; } 
        public VerifyAndControl Screen { get; set; }
        public VerifyAndControlByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}