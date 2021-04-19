    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.StatusLotGroup
{
    //RPS VERSION 1.0.0.0
    public partial class StatusLotGroup:Screen
    {
        public StatusLotGroup():base()
        {
            this.URL = "warehouse.statuslotgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatusLotGroupCollectionView  = new StatusLotGroupCollectionView(this); 
            StatusLotGroupEntityView  = new StatusLotGroupEntityView(this); 
            StatusLotView  = new StatusLotView(this); 
            StatusLotGroupByLangView  = new StatusLotGroupByLangView(this); 
            StatusLotByLangView  = new StatusLotByLangView(this); 
            StatusLotGroupCollectionView.InitializeControls(); 
            StatusLotGroupEntityView.InitializeControls(); 
            StatusLotView.InitializeControls(); 
            StatusLotGroupByLangView.InitializeControls(); 
            StatusLotByLangView.InitializeControls(); 
           
        }
      
            public StatusLotGroupCollectionView StatusLotGroupCollectionView {get; set; } 
            public StatusLotGroupEntityView StatusLotGroupEntityView {get; set; } 
            public StatusLotView StatusLotView {get; set; } 
            public StatusLotGroupByLangView StatusLotGroupByLangView {get; set; } 
            public StatusLotByLangView StatusLotByLangView {get; set; } 
    }
            
    public partial class StatusLotGroupCollectionView : View
    {
        public StatusLotGroupCollectionView(StatusLotGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StatusLotGroupCollectionView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e04f8e6c-c991-4e25-87fb-9c3603678d38",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StatusLotGroupCollectionView,StatusLotGroupEntityView>( params_MainConsult,this,Screen.StatusLotGroupEntityView);
 

        }
        public IRPSButton<StatusLotGroupCollectionView,StatusLotGroupEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StatusLotGroupCollectionView,StatusLotGroupEntityView> MainConsult { get; set; } 
        public StatusLotGroup Screen { get; set; }
        public StatusLotGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StatusLotGroupEntityView : View
    {
        public StatusLotGroupEntityView(StatusLotGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StatusLotGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusLotGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusLotGroupEntityView,StatusLotGroupCollectionView>( this,Screen.StatusLotGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusLotGroupEntityView,StatusLotGroupCollectionView>( this,Screen.StatusLotGroupCollectionView);
 
            CodStatusLotGroup = RPSControlFactory.CreateRPSTextBox<StatusLotGroupEntityView>("660366d7-0bbe-4c79-bc87-dc14996e40f4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StatusLotGroupEntityView>("9b18624b-5b9d-4416-bd84-556f0c5078db","","",false, this);
 
            CollectionInit params_StatusLots = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7e29b812-a7fd-4923-afa6-d2b93c3663e8",CSSSelectorGrid="",XPathGrid=""};
            StatusLots = RPSControlFactory.RPSCreateCollectionWithGrid<StatusLotsCollectionEditor<StatusLotGroupEntityView,StatusLotView>,StatusLotGroupEntityView,StatusLotView>( params_StatusLots,this,Screen.StatusLotView);
 
            CollectionInit params_StatusLotGroupByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="975b850c-9194-433e-88f1-6f3605ca138f",CSSSelectorGrid="",XPathGrid=""};
            StatusLotGroupByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<StatusLotGroupByLangsCollectionEditor<StatusLotGroupEntityView,StatusLotView>,StatusLotGroupEntityView,StatusLotView>( params_StatusLotGroupByLangs,this,Screen.StatusLotView);
 
            Section = RPSControlFactory.CreateRPSSection<StatusLotGroupEntityView>( "","ul li[rpsid='73c6b513-d188-4501-958a-93d4db9d4630']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<StatusLotGroupEntityView>( "","ul li[rpsid='900eba28-8b86-4bfc-85b9-aafcaa960f4a']","",this);
 

        }
        public IRPSSaveButton<StatusLotGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<StatusLotGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<StatusLotGroupEntityView,StatusLotGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusLotGroupEntityView,StatusLotGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StatusLotGroupEntityView> CodStatusLotGroup { get; set; } 
        public IRPSTextBox<StatusLotGroupEntityView> Description { get; set; } 
        public StatusLotsCollectionEditor<StatusLotGroupEntityView,StatusLotView> StatusLots { get; set; } 
        public StatusLotGroupByLangsCollectionEditor<StatusLotGroupEntityView,StatusLotView> StatusLotGroupByLangs { get; set; } 
        public IRPSSection<StatusLotGroupEntityView> Section { get; set; } 
        public IRPSSection<StatusLotGroupEntityView> Section1 { get; set; } 
        public StatusLotGroup Screen { get; set; }
        public StatusLotGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatusLotsCollectionEditor<StatusLotGroupEntityView,StatusLotView>:RPSCollectionEditor<StatusLotGroupEntityView,StatusLotView> where StatusLotGroupEntityView : class, IView where StatusLotView : class, IView
    {
        public  StatusLotsGridView<StatusLotGroupEntityView,StatusLotView> GridView {get;set;}
    }
    public partial class StatusLotsGridView <StatusLotGroupEntityView,StatusLotView> :  RPSGridView<StatusLotGroupEntityView,StatusLotView> where StatusLotGroupEntityView : class, IView where StatusLotView : class, IView
    {
        public StatusLotsGridView(StatusLotGroupEntityView currentView,StatusLotView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodStatusLot = RPSControlFactory.CreateRPSGridTextBox<StatusLotGroupEntityView>("","#7e29b812-a7fd-4923-afa6-d2b93c3663e8 .ag-row[role='row']@ROWINDEX [col-id='cCodStatusLot']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StatusLotGroupEntityView>("","#7e29b812-a7fd-4923-afa6-d2b93c3663e8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Alert = RPSControlFactory.CreateRPSGridCheckBox<StatusLotGroupEntityView>("","#7e29b812-a7fd-4923-afa6-d2b93c3663e8 .ag-row[role='row']@ROWINDEX [col-id='cAlert']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<StatusLotGroupEntityView>("","#7e29b812-a7fd-4923-afa6-d2b93c3663e8 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            DefaultStatus = RPSControlFactory.CreateRPSGridCheckBox<StatusLotGroupEntityView>("","#7e29b812-a7fd-4923-afa6-d2b93c3663e8 .ag-row[role='row']@ROWINDEX [col-id='cDefaultStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusLotGroupEntityView> CodStatusLot { get; set; } 
        public IRPSGridTextBox<StatusLotGroupEntityView> Description { get; set; } 
        public IRPSGridCheckbox<StatusLotGroupEntityView> Alert { get; set; } 
        public IRPSGridTextBox<StatusLotGroupEntityView> Priority { get; set; } 
        public IRPSGridCheckbox<StatusLotGroupEntityView> DefaultStatus { get; set; } 
                     
    }
 
        public partial class StatusLotGroupByLangsCollectionEditor<StatusLotGroupEntityView,StatusLotView>:RPSCollectionEditor<StatusLotGroupEntityView,StatusLotView> where StatusLotGroupEntityView : class, IView where StatusLotView : class, IView
    {
        public  StatusLotGroupByLangsGridView<StatusLotGroupEntityView,StatusLotView> GridView {get;set;}
    }
    public partial class StatusLotGroupByLangsGridView <StatusLotGroupEntityView,StatusLotView> :  RPSGridView<StatusLotGroupEntityView,StatusLotView> where StatusLotGroupEntityView : class, IView where StatusLotView : class, IView
    {
        public StatusLotGroupByLangsGridView(StatusLotGroupEntityView currentView,StatusLotView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<StatusLotGroupEntityView>("","#975b850c-9194-433e-88f1-6f3605ca138f .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StatusLotGroupEntityView>("","#975b850c-9194-433e-88f1-6f3605ca138f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<StatusLotGroupEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<StatusLotGroupEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusLotView : View
    {
        public StatusLotView(StatusLotGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusLotView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusLotView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusLotView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StatusLotView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            CodStatusLot = RPSControlFactory.CreateRPSTextBox<StatusLotView>("af915f4c-a388-49b4-8206-5e1358b93a7c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StatusLotView>("4e06d8e7-edb6-4cd2-8fb2-39b3dfd693ca","","",false, this);
 
            DefaultStatus = RPSControlFactory.CreateRPSCheckBox<StatusLotView>("163318a1-4608-4425-9eb9-b4d1bab157f9","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<StatusLotView>("d96d73db-c8ae-40d0-a036-027f912bc206","","",true, this);
 
            Alert = RPSControlFactory.CreateRPSCheckBox<StatusLotView>("b27f026a-3735-4e12-a90e-d509c853dbeb","","",true, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<StatusLotView>( "6b8c11a0-6e11-451d-96a6-4432eb1fe15d","","",this);
 
            CollectionInit params_StatusLotByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11690cf6-b2d1-4d07-bbf8-512061f9856a",CSSSelectorGrid="",XPathGrid=""};
            StatusLotByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<StatusLotByLangsCollectionEditor<StatusLotView,StatusLotByLangView>,StatusLotView,StatusLotByLangView>( params_StatusLotByLangs,this,Screen.StatusLotByLangView);
 

        }
        public IRPSButton<StatusLotView> DeleteButton { get; set; } 
        public IRPSButton<StatusLotView,StatusLotGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusLotView,StatusLotGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StatusLotView,StatusLotGroupEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<StatusLotView> CodStatusLot { get; set; } 
        public IRPSTextBox<StatusLotView> Description { get; set; } 
        public IRPSCheckbox<StatusLotView> DefaultStatus { get; set; } 
        public IRPSTextBox<StatusLotView> Priority { get; set; } 
        public IRPSCheckbox<StatusLotView> Alert { get; set; } 
        public IRPSColorEditor<StatusLotView> Color { get; set; } 
        public StatusLotByLangsCollectionEditor<StatusLotView,StatusLotByLangView> StatusLotByLangs { get; set; } 
        public StatusLotGroup Screen { get; set; }
        public StatusLotView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatusLotByLangsCollectionEditor<StatusLotView,StatusLotByLangView>:RPSCollectionEditor<StatusLotView,StatusLotByLangView> where StatusLotView : class, IView where StatusLotByLangView : class, IView
    {
        public  StatusLotByLangsGridView<StatusLotView,StatusLotByLangView> GridView {get;set;}
    }
    public partial class StatusLotByLangsGridView <StatusLotView,StatusLotByLangView> :  RPSGridView<StatusLotView,StatusLotByLangView> where StatusLotView : class, IView where StatusLotByLangView : class, IView
    {
        public StatusLotByLangsGridView(StatusLotView currentView,StatusLotByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<StatusLotView>("","#11690cf6-b2d1-4d07-bbf8-512061f9856a .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StatusLotView>("","#11690cf6-b2d1-4d07-bbf8-512061f9856a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<StatusLotView> CodLanguage { get; set; } 
        public IRPSGridTextBox<StatusLotView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusLotGroupByLangView : View
    {
        public StatusLotGroupByLangView(StatusLotGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusLotGroupByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusLotGroupByLangView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusLotGroupByLangView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StatusLotGroupByLangView,StatusLotGroupEntityView>( this,Screen.StatusLotGroupEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<StatusLotGroupByLangView>("fce45068-2b8f-4780-a524-80cfcc142376","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StatusLotGroupByLangView>("cca046fd-8d77-474b-b3cc-60a4e5b510ac","","",false, this);
 

        }
        public IRPSButton<StatusLotGroupByLangView> DeleteButton { get; set; } 
        public IRPSButton<StatusLotGroupByLangView,StatusLotGroupEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusLotGroupByLangView,StatusLotGroupEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StatusLotGroupByLangView,StatusLotGroupEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<StatusLotGroupByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<StatusLotGroupByLangView> Description { get; set; } 
        public StatusLotGroup Screen { get; set; }
        public StatusLotGroupByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StatusLotByLangView : View
    {
        public StatusLotByLangView(StatusLotGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusLotByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusLotByLangView,StatusLotView>( this,Screen.StatusLotView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusLotByLangView,StatusLotView>( this,Screen.StatusLotView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StatusLotByLangView,StatusLotView>( this,Screen.StatusLotView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<StatusLotByLangView>("7c6cb38d-b9a9-4566-9fe4-f01d5c86dab6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StatusLotByLangView>("ddfe70be-e428-4ec3-b5b6-d69199308250","","",false, this);
 

        }
        public IRPSButton<StatusLotByLangView> DeleteButton { get; set; } 
        public IRPSButton<StatusLotByLangView,StatusLotView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusLotByLangView,StatusLotView> BackButton { get; set; } 
        public IRPSAcceptButton<StatusLotByLangView,StatusLotView> AcceptButton { get; set; } 
        public IRPSComboBox<StatusLotByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<StatusLotByLangView> Description { get; set; } 
        public StatusLotGroup Screen { get; set; }
        public StatusLotByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}