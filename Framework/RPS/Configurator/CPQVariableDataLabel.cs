    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.CPQVariableDataLabel
{
    //RPS VERSION 1.0.0.0
    public partial class CPQVariableDataLabel:Screen
    {
        public CPQVariableDataLabel():base()
        {
            this.URL = "configurator.cpqvariabledatalabel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CPQVariableDataLabelCollectionView  = new CPQVariableDataLabelCollectionView(this); 
            CPQVariableDataLabelEntityView  = new CPQVariableDataLabelEntityView(this); 
            CPQVariableDataLabelByLangView  = new CPQVariableDataLabelByLangView(this); 
            CPQVariableDataLabelCollectionView.InitializeControls(); 
            CPQVariableDataLabelEntityView.InitializeControls(); 
            CPQVariableDataLabelByLangView.InitializeControls(); 
           
        }
      
            public CPQVariableDataLabelCollectionView CPQVariableDataLabelCollectionView {get; set; } 
            public CPQVariableDataLabelEntityView CPQVariableDataLabelEntityView {get; set; } 
            public CPQVariableDataLabelByLangView CPQVariableDataLabelByLangView {get; set; } 
    }
            
    public partial class CPQVariableDataLabelCollectionView : View
    {
        public CPQVariableDataLabelCollectionView(CPQVariableDataLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CPQVariableDataLabelCollectionView,CPQVariableDataLabelEntityView>( this,Screen.CPQVariableDataLabelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "94f32157-6d4c-4888-87d9-a2e91f450872",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CPQVariableDataLabelCollectionView,CPQVariableDataLabelEntityView>( params_MainConsult,this,Screen.CPQVariableDataLabelEntityView);
 

        }
        public IRPSButton<CPQVariableDataLabelCollectionView,CPQVariableDataLabelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CPQVariableDataLabelCollectionView,CPQVariableDataLabelEntityView> MainConsult { get; set; } 
        public CPQVariableDataLabel Screen { get; set; }
        public CPQVariableDataLabelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQVariableDataLabelEntityView : View
    {
        public CPQVariableDataLabelEntityView(CPQVariableDataLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CPQVariableDataLabelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableDataLabelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableDataLabelEntityView,CPQVariableDataLabelCollectionView>( this,Screen.CPQVariableDataLabelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableDataLabelEntityView,CPQVariableDataLabelCollectionView>( this,Screen.CPQVariableDataLabelCollectionView);
 
            CodLabel = RPSControlFactory.CreateRPSTextBox<CPQVariableDataLabelEntityView>("8160f773-7477-4de2-8fa0-c3add60981ca","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQVariableDataLabelEntityView>("01334d63-2369-44cd-be30-9b2cd12f17af","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<CPQVariableDataLabelEntityView>("02f254bd-9942-4cd4-bba7-70141dd6fd41","","",true, this);
 
            IDCPQVariableTable = RPSControlFactory.CreateRPSComboBox<CPQVariableDataLabelEntityView>("424e381f-47b1-4553-a8fc-0e886a5ef5f2","","",false, this);
 
            EntityType = RPSControlFactory.CreateRPSEnumComboBox<CPQVariableDataLabelEntityView>("9cbbb4f5-1b6b-4ef7-b9b9-88594d80f837","","",false, this);
 
            CollectionInit params_CPQVariableDataLabelByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36e65637-0063-4500-bf1c-3c200ba0da54",CSSSelectorGrid="",XPathGrid=""};
            CPQVariableDataLabelByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CPQVariableDataLabelByLangsCollectionEditor<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView>,CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView>( params_CPQVariableDataLabelByLangs,this,Screen.CPQVariableDataLabelByLangView);
 

        }
        public IRPSSaveButton<CPQVariableDataLabelEntityView> SaveButton { get; set; } 
        public IRPSButton<CPQVariableDataLabelEntityView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataLabelEntityView,CPQVariableDataLabelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataLabelEntityView,CPQVariableDataLabelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CPQVariableDataLabelEntityView> CodLabel { get; set; } 
        public IRPSTextBox<CPQVariableDataLabelEntityView> Description { get; set; } 
        public IRPSComboBox<CPQVariableDataLabelEntityView> DataType { get; set; } 
        public IRPSComboBox<CPQVariableDataLabelEntityView> IDCPQVariableTable { get; set; } 
        public IRPSComboBox<CPQVariableDataLabelEntityView> EntityType { get; set; } 
        public CPQVariableDataLabelByLangsCollectionEditor<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView> CPQVariableDataLabelByLangs { get; set; } 
        public CPQVariableDataLabel Screen { get; set; }
        public CPQVariableDataLabelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPQVariableDataLabelByLangsCollectionEditor<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView>:RPSCollectionEditor<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView> where CPQVariableDataLabelEntityView : class, IView where CPQVariableDataLabelByLangView : class, IView
    {
        public  CPQVariableDataLabelByLangsGridView<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView> GridView {get;set;}
    }
    public partial class CPQVariableDataLabelByLangsGridView <CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView> :  RPSGridView<CPQVariableDataLabelEntityView,CPQVariableDataLabelByLangView> where CPQVariableDataLabelEntityView : class, IView where CPQVariableDataLabelByLangView : class, IView
    {
        public CPQVariableDataLabelByLangsGridView(CPQVariableDataLabelEntityView currentView,CPQVariableDataLabelByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CPQVariableDataLabelEntityView>("","#36e65637-0063-4500-bf1c-3c200ba0da54 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CPQVariableDataLabelEntityView>("","#36e65637-0063-4500-bf1c-3c200ba0da54 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQVariableDataLabelEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CPQVariableDataLabelEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CPQVariableDataLabelByLangView : View
    {
        public CPQVariableDataLabelByLangView(CPQVariableDataLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQVariableDataLabelByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView>( this,Screen.CPQVariableDataLabelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView>( this,Screen.CPQVariableDataLabelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView>( this,Screen.CPQVariableDataLabelEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CPQVariableDataLabelByLangView>("0e946ebc-29a9-4dc6-ad72-60ccd2f4b812","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQVariableDataLabelByLangView>("1e8d62c4-6dc2-4166-b5bd-fc4d6bd11f46","","",false, this);
 

        }
        public IRPSButton<CPQVariableDataLabelByLangView> DeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CPQVariableDataLabelByLangView,CPQVariableDataLabelEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CPQVariableDataLabelByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CPQVariableDataLabelByLangView> Description { get; set; } 
        public CPQVariableDataLabel Screen { get; set; }
        public CPQVariableDataLabelByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}