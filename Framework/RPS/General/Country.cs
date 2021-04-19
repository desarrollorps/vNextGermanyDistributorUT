    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Country
{
    //RPS VERSION 1.0.0.0
    public partial class Country:Screen
    {
        public Country():base()
        {
            this.URL = "general.country";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CountryCollectionView  = new CountryCollectionView(this); 
            CountryEntityView  = new CountryEntityView(this); 
            StateView  = new StateView(this); 
            CountryFormatView  = new CountryFormatView(this); 
            CountyView  = new CountyView(this); 
            CountryByLangView  = new CountryByLangView(this); 
            StateByLangView  = new StateByLangView(this); 
            CountyByLangView  = new CountyByLangView(this); 
            CountryCollectionView.InitializeControls(); 
            CountryEntityView.InitializeControls(); 
            StateView.InitializeControls(); 
            CountryFormatView.InitializeControls(); 
            CountyView.InitializeControls(); 
            CountryByLangView.InitializeControls(); 
            StateByLangView.InitializeControls(); 
            CountyByLangView.InitializeControls(); 
           
        }
      
            public CountryCollectionView CountryCollectionView {get; set; } 
            public CountryEntityView CountryEntityView {get; set; } 
            public StateView StateView {get; set; } 
            public CountryFormatView CountryFormatView {get; set; } 
            public CountyView CountyView {get; set; } 
            public CountryByLangView CountryByLangView {get; set; } 
            public StateByLangView StateByLangView {get; set; } 
            public CountyByLangView CountyByLangView {get; set; } 
    }
            
    public partial class CountryCollectionView : View
    {
        public CountryCollectionView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CountryCollectionView,CountryEntityView>( this,Screen.CountryEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b02a3d80-9565-496f-92aa-46f1aa044857",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CountryCollectionView,CountryEntityView>( params_MainConsult,this,Screen.CountryEntityView);
 

        }
        public IRPSButton<CountryCollectionView,CountryEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CountryCollectionView,CountryEntityView> MainConsult { get; set; } 
        public Country Screen { get; set; }
        public CountryCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CountryEntityView : View
    {
        public CountryEntityView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CountryEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountryEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountryEntityView,CountryCollectionView>( this,Screen.CountryCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountryEntityView,CountryCollectionView>( this,Screen.CountryCollectionView);
 
            CodCountry = RPSControlFactory.CreateRPSTextBox<CountryEntityView>("e905ea64-9959-43dc-bd0d-6d4bce6f8d00","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CountryEntityView>("63d9a11e-aa60-4d05-b3a0-ac1d77ca6a4d","","",false, this);
 
            CodIso = RPSControlFactory.CreateRPSTextBox<CountryEntityView>("2c07962b-8fe2-4ea7-a567-46a1b70d0d50","","",true, this);
 
            CodCountryGroup = RPSControlFactory.CreateRPSComboBox<CountryEntityView>("214638fe-22a8-47b6-ab49-ffbef3cfaa3d","","",false, this);
 
            ValidateLegalEntity = RPSControlFactory.CreateRPSCheckBox<CountryEntityView>("d5c2d775-e14c-4b86-857b-f64515fe3282","","",false, this);
 
            ValidateNaturalPerson = RPSControlFactory.CreateRPSCheckBox<CountryEntityView>("e330bf51-d8da-40b0-854b-8267514b924d","","",false, this);
 
            CollectionInit params_States = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f29669b0-3bef-4cd1-bf5b-a8e2eb58135f",CSSSelectorGrid="",XPathGrid=""};
            States = RPSControlFactory.RPSCreateCollectionWithGrid<StatesCollectionEditor<CountryEntityView,StateView>,CountryEntityView,StateView>( params_States,this,Screen.StateView);
 
            CollectionInit params_CountryFormats = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aa2f28b1-a298-4994-978f-b22f06dd5a35",CSSSelectorGrid="",XPathGrid=""};
            CountryFormats = RPSControlFactory.RPSCreateCollectionWithGrid<CountryFormatsCollectionEditor<CountryEntityView,StateView>,CountryEntityView,StateView>( params_CountryFormats,this,Screen.StateView);
 
            CollectionInit params_CountryByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="098af334-73e6-4451-837f-4b8ad01a05f4",CSSSelectorGrid="",XPathGrid=""};
            CountryByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CountryByLangsCollectionEditor<CountryEntityView,StateView>,CountryEntityView,StateView>( params_CountryByLangs,this,Screen.StateView);
 
            Section = RPSControlFactory.CreateRPSSection<CountryEntityView>( "","ul li[rpsid='63c2dd61-d449-4e9c-a7dd-c00a2d5477df']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<CountryEntityView>( "","ul li[rpsid='50943caf-dcbd-4bcb-81cb-e27172a8e74c']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CountryEntityView>( "","ul li[rpsid='3d3dc4a0-bd23-43c4-bd90-ab3e2fd8900a']","",this);
 

        }
        public IRPSSaveButton<CountryEntityView> SaveButton { get; set; } 
        public IRPSButton<CountryEntityView> DeleteButton { get; set; } 
        public IRPSButton<CountryEntityView,CountryCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountryEntityView,CountryCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CountryEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CountryEntityView> Description { get; set; } 
        public IRPSTextBox<CountryEntityView> CodIso { get; set; } 
        public IRPSComboBox<CountryEntityView> CodCountryGroup { get; set; } 
        public IRPSCheckbox<CountryEntityView> ValidateLegalEntity { get; set; } 
        public IRPSCheckbox<CountryEntityView> ValidateNaturalPerson { get; set; } 
        public StatesCollectionEditor<CountryEntityView,StateView> States { get; set; } 
        public CountryFormatsCollectionEditor<CountryEntityView,StateView> CountryFormats { get; set; } 
        public CountryByLangsCollectionEditor<CountryEntityView,StateView> CountryByLangs { get; set; } 
        public IRPSSection<CountryEntityView> Section { get; set; } 
        public IRPSSection<CountryEntityView> Section2 { get; set; } 
        public IRPSSection<CountryEntityView> Section1 { get; set; } 
        public Country Screen { get; set; }
        public CountryEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatesCollectionEditor<CountryEntityView,StateView>:RPSCollectionEditor<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public  StatesGridView<CountryEntityView,StateView> GridView {get;set;}
    }
    public partial class StatesGridView <CountryEntityView,StateView> :  RPSGridView<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public StatesGridView(CountryEntityView currentView,StateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodState = RPSControlFactory.CreateRPSGridTextBox<CountryEntityView>("","#f29669b0-3bef-4cd1-bf5b-a8e2eb58135f .ag-row[role='row']@ROWINDEX [col-id='cCodState']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CountryEntityView>("","#f29669b0-3bef-4cd1-bf5b-a8e2eb58135f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CountryEntityView> CodState { get; set; } 
        public IRPSGridTextBox<CountryEntityView> Description { get; set; } 
                     
    }
 
        public partial class CountryFormatsCollectionEditor<CountryEntityView,StateView>:RPSCollectionEditor<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public  CountryFormatsGridView<CountryEntityView,StateView> GridView {get;set;}
    }
    public partial class CountryFormatsGridView <CountryEntityView,StateView> :  RPSGridView<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public CountryFormatsGridView(CountryEntityView currentView,StateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TypeIdentification = RPSControlFactory.CreateRPSGridEnumComboBox<CountryEntityView>("","#aa2f28b1-a298-4994-978f-b22f06dd5a35 .ag-row[role='row']@ROWINDEX [col-id='cTypeIdentification']","",true, this.CurrentView);
 
            Format = RPSControlFactory.CreateRPSGridTextBox<CountryEntityView>("","#aa2f28b1-a298-4994-978f-b22f06dd5a35 .ag-row[role='row']@ROWINDEX [col-id='cFormat']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CountryEntityView> TypeIdentification { get; set; } 
        public IRPSGridTextBox<CountryEntityView> Format { get; set; } 
                     
    }
 
        public partial class CountryByLangsCollectionEditor<CountryEntityView,StateView>:RPSCollectionEditor<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public  CountryByLangsGridView<CountryEntityView,StateView> GridView {get;set;}
    }
    public partial class CountryByLangsGridView <CountryEntityView,StateView> :  RPSGridView<CountryEntityView,StateView> where CountryEntityView : class, IView where StateView : class, IView
    {
        public CountryByLangsGridView(CountryEntityView currentView,StateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CountryEntityView>("","#098af334-73e6-4451-837f-4b8ad01a05f4 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CountryEntityView>("","#098af334-73e6-4451-837f-4b8ad01a05f4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CountryEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CountryEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class StateView : View
    {
        public StateView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StateView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StateView,CountryEntityView>( this,Screen.CountryEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StateView,CountryEntityView>( this,Screen.CountryEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StateView,CountryEntityView>( this,Screen.CountryEntityView);
 
            CodState = RPSControlFactory.CreateRPSTextBox<StateView>("c15df896-2dff-429a-8128-a56cc9d689c0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StateView>("03e9e924-f18c-45fc-ad61-28253a712ae4","","",false, this);
 
            CollectionInit params_Countys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="97e23edb-3c75-4147-9bdb-22922eee78bd",CSSSelectorGrid="",XPathGrid=""};
            Countys = RPSControlFactory.RPSCreateCollectionWithGrid<CountysCollectionEditor<StateView,CountyView>,StateView,CountyView>( params_Countys,this,Screen.CountyView);
 
            CollectionInit params_StateByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6b32f7b5-5b9e-46f8-9f97-86a633199701",CSSSelectorGrid="",XPathGrid=""};
            StateByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<StateByLangsCollectionEditor<StateView,CountyView>,StateView,CountyView>( params_StateByLangs,this,Screen.CountyView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<StateView>( "","ul li[rpsid='877b1e29-58fc-4bd2-b039-beab2098e6f2']","",this);
 
            ByLang = RPSControlFactory.CreateRPSSection<StateView>( "","ul li[rpsid='60b8deef-d93b-4974-b08b-0e243b028a1f']","",this);
 

        }
        public IRPSButton<StateView> DeleteButton { get; set; } 
        public IRPSButton<StateView,CountryEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StateView,CountryEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StateView,CountryEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<StateView> CodState { get; set; } 
        public IRPSTextBox<StateView> Description { get; set; } 
        public CountysCollectionEditor<StateView,CountyView> Countys { get; set; } 
        public StateByLangsCollectionEditor<StateView,CountyView> StateByLangs { get; set; } 
        public IRPSSection<StateView> GeneralData { get; set; } 
        public IRPSSection<StateView> ByLang { get; set; } 
        public Country Screen { get; set; }
        public StateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CountysCollectionEditor<StateView,CountyView>:RPSCollectionEditor<StateView,CountyView> where StateView : class, IView where CountyView : class, IView
    {
        public  CountysGridView<StateView,CountyView> GridView {get;set;}
    }
    public partial class CountysGridView <StateView,CountyView> :  RPSGridView<StateView,CountyView> where StateView : class, IView where CountyView : class, IView
    {
        public CountysGridView(StateView currentView,CountyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCounty = RPSControlFactory.CreateRPSGridTextBox<StateView>("","#97e23edb-3c75-4147-9bdb-22922eee78bd .ag-row[role='row']@ROWINDEX [col-id='cCodCounty']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StateView>("","#97e23edb-3c75-4147-9bdb-22922eee78bd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StateView> CodCounty { get; set; } 
        public IRPSGridTextBox<StateView> Description { get; set; } 
                     
    }
 
        public partial class StateByLangsCollectionEditor<StateView,CountyView>:RPSCollectionEditor<StateView,CountyView> where StateView : class, IView where CountyView : class, IView
    {
        public  StateByLangsGridView<StateView,CountyView> GridView {get;set;}
    }
    public partial class StateByLangsGridView <StateView,CountyView> :  RPSGridView<StateView,CountyView> where StateView : class, IView where CountyView : class, IView
    {
        public StateByLangsGridView(StateView currentView,CountyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<StateView>("","#6b32f7b5-5b9e-46f8-9f97-86a633199701 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StateView>("","#6b32f7b5-5b9e-46f8-9f97-86a633199701 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<StateView> CodLanguage { get; set; } 
        public IRPSGridTextBox<StateView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CountryFormatView : View
    {
        public CountryFormatView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountryFormatView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountryFormatView,CountryEntityView>( this,Screen.CountryEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountryFormatView,CountryEntityView>( this,Screen.CountryEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CountryFormatView,CountryEntityView>( this,Screen.CountryEntityView);
 
            TypeIdentification = RPSControlFactory.CreateRPSEnumComboBox<CountryFormatView>("aec5a66d-9fa8-4280-93b6-f7dc57e05582","","",true, this);
 
            Format = RPSControlFactory.CreateRPSTextBox<CountryFormatView>("b4e6caf2-429f-4c3a-9138-d4af6c5a3b0c","","",false, this);
 

        }
        public IRPSButton<CountryFormatView> DeleteButton { get; set; } 
        public IRPSButton<CountryFormatView,CountryEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountryFormatView,CountryEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CountryFormatView,CountryEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CountryFormatView> TypeIdentification { get; set; } 
        public IRPSTextBox<CountryFormatView> Format { get; set; } 
        public Country Screen { get; set; }
        public CountryFormatView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CountyView : View
    {
        public CountyView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountyView,StateView>( this,Screen.StateView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountyView,StateView>( this,Screen.StateView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CountyView,StateView>( this,Screen.StateView);
 
            CodCounty = RPSControlFactory.CreateRPSTextBox<CountyView>("57547e19-cf06-4098-9a6c-f3807e1d01f6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CountyView>("956a38c8-5d19-4bd6-a3ab-9ed1720ddcb0","","",false, this);
 
            CollectionInit params_CountyByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d9fed1b-f647-4f6d-93e0-9e400bbf1625",CSSSelectorGrid="",XPathGrid=""};
            CountyByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CountyByLangsCollectionEditor<CountyView,CountyByLangView>,CountyView,CountyByLangView>( params_CountyByLangs,this,Screen.CountyByLangView);
 

        }
        public IRPSButton<CountyView> DeleteButton { get; set; } 
        public IRPSButton<CountyView,StateView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountyView,StateView> BackButton { get; set; } 
        public IRPSAcceptButton<CountyView,StateView> AcceptButton { get; set; } 
        public IRPSTextBox<CountyView> CodCounty { get; set; } 
        public IRPSTextBox<CountyView> Description { get; set; } 
        public CountyByLangsCollectionEditor<CountyView,CountyByLangView> CountyByLangs { get; set; } 
        public Country Screen { get; set; }
        public CountyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CountyByLangsCollectionEditor<CountyView,CountyByLangView>:RPSCollectionEditor<CountyView,CountyByLangView> where CountyView : class, IView where CountyByLangView : class, IView
    {
        public  CountyByLangsGridView<CountyView,CountyByLangView> GridView {get;set;}
    }
    public partial class CountyByLangsGridView <CountyView,CountyByLangView> :  RPSGridView<CountyView,CountyByLangView> where CountyView : class, IView where CountyByLangView : class, IView
    {
        public CountyByLangsGridView(CountyView currentView,CountyByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CountyView>("","#7d9fed1b-f647-4f6d-93e0-9e400bbf1625 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CountyView>("","#7d9fed1b-f647-4f6d-93e0-9e400bbf1625 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CountyView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CountyView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CountryByLangView : View
    {
        public CountryByLangView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountryByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountryByLangView,CountryEntityView>( this,Screen.CountryEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountryByLangView,CountryEntityView>( this,Screen.CountryEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CountryByLangView,CountryEntityView>( this,Screen.CountryEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CountryByLangView>("91b3c1b3-b292-4a05-97a3-2a08faf2dbbc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CountryByLangView>("f2d4cfb4-4b34-4c74-8442-e3881d27afc8","","",false, this);
 

        }
        public IRPSButton<CountryByLangView> DeleteButton { get; set; } 
        public IRPSButton<CountryByLangView,CountryEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountryByLangView,CountryEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CountryByLangView,CountryEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CountryByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CountryByLangView> Description { get; set; } 
        public Country Screen { get; set; }
        public CountryByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StateByLangView : View
    {
        public StateByLangView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StateByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StateByLangView,StateView>( this,Screen.StateView);
 
            BackButton = RPSControlFactory.RPSBackButton<StateByLangView,StateView>( this,Screen.StateView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StateByLangView,StateView>( this,Screen.StateView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<StateByLangView>("396b6802-a702-4cc3-b028-a24c5709f335","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StateByLangView>("69c0de0a-e8f7-4738-8726-3150a362e8b7","","",false, this);
 

        }
        public IRPSButton<StateByLangView> DeleteButton { get; set; } 
        public IRPSButton<StateByLangView,StateView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StateByLangView,StateView> BackButton { get; set; } 
        public IRPSAcceptButton<StateByLangView,StateView> AcceptButton { get; set; } 
        public IRPSComboBox<StateByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<StateByLangView> Description { get; set; } 
        public Country Screen { get; set; }
        public StateByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CountyByLangView : View
    {
        public CountyByLangView(Country screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CountyByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CountyByLangView,CountyView>( this,Screen.CountyView);
 
            BackButton = RPSControlFactory.RPSBackButton<CountyByLangView,CountyView>( this,Screen.CountyView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CountyByLangView,CountyView>( this,Screen.CountyView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CountyByLangView>("94c2204c-8e9e-435b-bc88-9e9cc7c707f4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CountyByLangView>("86eedf0f-1cf6-4fb7-b1c5-2c376fa8f616","","",false, this);
 

        }
        public IRPSButton<CountyByLangView> DeleteButton { get; set; } 
        public IRPSButton<CountyByLangView,CountyView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CountyByLangView,CountyView> BackButton { get; set; } 
        public IRPSAcceptButton<CountyByLangView,CountyView> AcceptButton { get; set; } 
        public IRPSComboBox<CountyByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CountyByLangView> Description { get; set; } 
        public Country Screen { get; set; }
        public CountyByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}