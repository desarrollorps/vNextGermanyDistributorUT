    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Attribute
{
    //RPS VERSION 1.0.0.0
    public partial class Attribute:Screen
    {
        public Attribute():base()
        {
            this.URL = "warehouse.attribute";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AttributeCollectionView  = new AttributeCollectionView(this); 
            AttributeEntityView  = new AttributeEntityView(this); 
            AttributeValueView  = new AttributeValueView(this); 
            AttributeByLangView  = new AttributeByLangView(this); 
            AttributeCollectionView.InitializeControls(); 
            AttributeEntityView.InitializeControls(); 
            AttributeValueView.InitializeControls(); 
            AttributeByLangView.InitializeControls(); 
           
        }
      
            public AttributeCollectionView AttributeCollectionView {get; set; } 
            public AttributeEntityView AttributeEntityView {get; set; } 
            public AttributeValueView AttributeValueView {get; set; } 
            public AttributeByLangView AttributeByLangView {get; set; } 
    }
            
    public partial class AttributeCollectionView : View
    {
        public AttributeCollectionView(Attribute screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AttributeCollectionView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "01f08dd0-c69c-498a-8523-9c63344b9ad0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AttributeCollectionView,AttributeEntityView>( params_MainConsult,this,Screen.AttributeEntityView);
 

        }
        public IRPSButton<AttributeCollectionView,AttributeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<AttributeCollectionView,AttributeEntityView> MainConsult { get; set; } 
        public Attribute Screen { get; set; }
        public AttributeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AttributeEntityView : View
    {
        public AttributeEntityView(Attribute screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AttributeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AttributeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AttributeEntityView,AttributeCollectionView>( this,Screen.AttributeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AttributeEntityView,AttributeCollectionView>( this,Screen.AttributeCollectionView);
 
            CodAttribute = RPSControlFactory.CreateRPSTextBox<AttributeEntityView>("c429e802-eea7-4b1b-b18a-859af709020d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AttributeEntityView>("9741196c-9662-4401-a018-48e44f623c33","","",false, this);
 
            Abreviature = RPSControlFactory.CreateRPSTextBox<AttributeEntityView>("3de1855a-37aa-44d0-a981-d076f95add68","","",false, this);
 
            CollectionInit params_AttributeValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1eb425bf-a17c-4b5a-b6ec-23656475e7f4",CSSSelectorGrid="",XPathGrid=""};
            AttributeValues = RPSControlFactory.RPSCreateCollectionWithGrid<AttributeValuesCollectionEditor<AttributeEntityView,AttributeValueView>,AttributeEntityView,AttributeValueView>( params_AttributeValues,this,Screen.AttributeValueView);
 
            CollectionInit params_AttributeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cf936948-e387-4302-b83e-a5071c9a191b",CSSSelectorGrid="",XPathGrid=""};
            AttributeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<AttributeByLangsCollectionEditor<AttributeEntityView,AttributeValueView>,AttributeEntityView,AttributeValueView>( params_AttributeByLangs,this,Screen.AttributeValueView);
 

        }
        public IRPSSaveButton<AttributeEntityView> SaveButton { get; set; } 
        public IRPSButton<AttributeEntityView> DeleteButton { get; set; } 
        public IRPSButton<AttributeEntityView,AttributeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AttributeEntityView,AttributeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AttributeEntityView> CodAttribute { get; set; } 
        public IRPSTextBox<AttributeEntityView> Description { get; set; } 
        public IRPSTextBox<AttributeEntityView> Abreviature { get; set; } 
        public AttributeValuesCollectionEditor<AttributeEntityView,AttributeValueView> AttributeValues { get; set; } 
        public AttributeByLangsCollectionEditor<AttributeEntityView,AttributeValueView> AttributeByLangs { get; set; } 
        public Attribute Screen { get; set; }
        public AttributeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AttributeValuesCollectionEditor<AttributeEntityView,AttributeValueView>:RPSCollectionEditor<AttributeEntityView,AttributeValueView> where AttributeEntityView : class, IView where AttributeValueView : class, IView
    {
        public  AttributeValuesGridView<AttributeEntityView,AttributeValueView> GridView {get;set;}
    }
    public partial class AttributeValuesGridView <AttributeEntityView,AttributeValueView> :  RPSGridView<AttributeEntityView,AttributeValueView> where AttributeEntityView : class, IView where AttributeValueView : class, IView
    {
        public AttributeValuesGridView(AttributeEntityView currentView,AttributeValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAttributeValue = RPSControlFactory.CreateRPSGridTextBox<AttributeEntityView>("","#1eb425bf-a17c-4b5a-b6ec-23656475e7f4 .ag-row[role='row']@ROWINDEX [col-id='cCodAttributeValue']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<AttributeEntityView>("","#1eb425bf-a17c-4b5a-b6ec-23656475e7f4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Enabled = RPSControlFactory.CreateRPSGridCheckBox<AttributeEntityView>("","#1eb425bf-a17c-4b5a-b6ec-23656475e7f4 .ag-row[role='row']@ROWINDEX [col-id='cEnabled']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<AttributeEntityView> CodAttributeValue { get; set; } 
        public IRPSGridTextBox<AttributeEntityView> Description { get; set; } 
        public IRPSGridCheckbox<AttributeEntityView> Enabled { get; set; } 
                     
    }
 
        public partial class AttributeByLangsCollectionEditor<AttributeEntityView,AttributeValueView>:RPSCollectionEditor<AttributeEntityView,AttributeValueView> where AttributeEntityView : class, IView where AttributeValueView : class, IView
    {
        public  AttributeByLangsGridView<AttributeEntityView,AttributeValueView> GridView {get;set;}
    }
    public partial class AttributeByLangsGridView <AttributeEntityView,AttributeValueView> :  RPSGridView<AttributeEntityView,AttributeValueView> where AttributeEntityView : class, IView where AttributeValueView : class, IView
    {
        public AttributeByLangsGridView(AttributeEntityView currentView,AttributeValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<AttributeEntityView>("","#cf936948-e387-4302-b83e-a5071c9a191b .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<AttributeEntityView>("","#cf936948-e387-4302-b83e-a5071c9a191b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AttributeEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<AttributeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AttributeValueView : View
    {
        public AttributeValueView(Attribute screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AttributeValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AttributeValueView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AttributeValueView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AttributeValueView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            CodAttributeValue = RPSControlFactory.CreateRPSTextBox<AttributeValueView>("5bd66747-a725-439f-abf0-5b3bf935368d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AttributeValueView>("e168b2c6-f05f-4a68-8482-c990c467c61c","","",false, this);
 
            Enabled = RPSControlFactory.CreateRPSCheckBox<AttributeValueView>("d00dfed0-d253-45ed-8731-2cd9c4bb6771","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<AttributeValueView>("a4931f25-2f28-488d-9aa5-882ee37b19c4","","",false, this);
 

        }
        public IRPSButton<AttributeValueView> DeleteButton { get; set; } 
        public IRPSButton<AttributeValueView,AttributeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AttributeValueView,AttributeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AttributeValueView,AttributeEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<AttributeValueView> CodAttributeValue { get; set; } 
        public IRPSTextBox<AttributeValueView> Description { get; set; } 
        public IRPSCheckbox<AttributeValueView> Enabled { get; set; } 
        public IRPSTextBox<AttributeValueView> Comment { get; set; } 
        public Attribute Screen { get; set; }
        public AttributeValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AttributeByLangView : View
    {
        public AttributeByLangView(Attribute screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AttributeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AttributeByLangView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AttributeByLangView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AttributeByLangView,AttributeEntityView>( this,Screen.AttributeEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<AttributeByLangView>("d86cf148-366f-43e8-9c0e-92f4ff086b97","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AttributeByLangView>("38304c95-030b-4200-89c3-deb97e5fa1ea","","",false, this);
 

        }
        public IRPSButton<AttributeByLangView> DeleteButton { get; set; } 
        public IRPSButton<AttributeByLangView,AttributeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AttributeByLangView,AttributeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AttributeByLangView,AttributeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AttributeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<AttributeByLangView> Description { get; set; } 
        public Attribute Screen { get; set; }
        public AttributeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}