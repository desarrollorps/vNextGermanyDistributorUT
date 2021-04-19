    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.UsualTask
{
    //RPS VERSION 1.0.0.0
    public partial class UsualTask:Screen
    {
        public UsualTask():base()
        {
            this.URL = "quality.usualtask";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TemplateUsualTaskVMCollectionView  = new TemplateUsualTaskVMCollectionView(this); 
            TemplateUsualTaskVMEntityView  = new TemplateUsualTaskVMEntityView(this); 
            UTaskByLangView  = new UTaskByLangView(this); 
            TemplateUsualTaskVMCollectionView.InitializeControls(); 
            TemplateUsualTaskVMEntityView.InitializeControls(); 
            UTaskByLangView.InitializeControls(); 
           
        }
      
            public TemplateUsualTaskVMCollectionView TemplateUsualTaskVMCollectionView {get; set; } 
            public TemplateUsualTaskVMEntityView TemplateUsualTaskVMEntityView {get; set; } 
            public UTaskByLangView UTaskByLangView {get; set; } 
    }
            
    public partial class TemplateUsualTaskVMCollectionView : View
    {
        public TemplateUsualTaskVMCollectionView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodUsualTask = RPSControlFactory.CreateRPSTextBox<TemplateUsualTaskVMCollectionView>("e22aa989-3d51-42ed-b896-e137a3080ea4","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TemplateUsualTaskVMCollectionView>("cff04605-a774-4c00-97a3-0e0bbf5968d5","","",false, this);
 
            eTemplateType = RPSControlFactory.CreateRPSEnumComboBox<TemplateUsualTaskVMCollectionView>("0522c3c5-eb01-4d88-983d-a5caf822450f","","",false, this);
 
            CollectionInit params_UsualTaskQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f2e77015-48cd-4ce7-82e7-20317a99cd42",CSSSelectorGrid="",XPathGrid=""};
            UsualTaskQuery = RPSControlFactory.RPSCreateCollectionWithGrid<UsualTaskQueryCollectionEditor<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView>,TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView>( params_UsualTaskQuery,this,Screen.TemplateUsualTaskVMEntityView);
 

        }
        public IRPSTextBox<TemplateUsualTaskVMCollectionView> CodUsualTask { get; set; } 
        public IRPSTextBox<TemplateUsualTaskVMCollectionView> Description { get; set; } 
        public IRPSComboBox<TemplateUsualTaskVMCollectionView> eTemplateType { get; set; } 
        public UsualTaskQueryCollectionEditor<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView> UsualTaskQuery { get; set; } 
        public UsualTask Screen { get; set; }
        public TemplateUsualTaskVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UsualTaskQueryCollectionEditor<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView>:RPSCollectionEditor<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView> where TemplateUsualTaskVMCollectionView : class, IView where TemplateUsualTaskVMEntityView : class, IView
    {
        public  UsualTaskQueryGridView<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView> GridView {get;set;}
    }
    public partial class UsualTaskQueryGridView <TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView> :  RPSGridView<TemplateUsualTaskVMCollectionView,TemplateUsualTaskVMEntityView> where TemplateUsualTaskVMCollectionView : class, IView where TemplateUsualTaskVMEntityView : class, IView
    {
        public UsualTaskQueryGridView(TemplateUsualTaskVMCollectionView currentView,TemplateUsualTaskVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UsualTaskSTR = RPSControlFactory.CreateRPSGridComboBox<TemplateUsualTaskVMCollectionView>("","#f2e77015-48cd-4ce7-82e7-20317a99cd42 .ag-row[role='row']@ROWINDEX [col-id='cUsualTaskSTR']","",false, this.CurrentView);
 
            UsualTask = RPSControlFactory.CreateRPSGridComboBox<TemplateUsualTaskVMCollectionView>("","#f2e77015-48cd-4ce7-82e7-20317a99cd42 .ag-row[role='row']@ROWINDEX [col-id='cUsualTask']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TemplateUsualTaskVMCollectionView> UsualTaskSTR { get; set; } 
        public IRPSGridComboBox<TemplateUsualTaskVMCollectionView> UsualTask { get; set; } 
                     
    }
 
    }
  
            
    public partial class TemplateUsualTaskVMEntityView : View
    {
        public TemplateUsualTaskVMEntityView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TemplateUsualTaskVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView>( this,Screen.TemplateUsualTaskVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView>( this,Screen.TemplateUsualTaskVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView>( this,Screen.TemplateUsualTaskVMCollectionView);
 
            CodUsualTask = RPSControlFactory.CreateRPSTextBox<TemplateUsualTaskVMEntityView>("a0fc91fb-0619-4fc1-a694-b2f26ef33638","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TemplateUsualTaskVMEntityView>("5aa0c740-59fe-419e-b3cb-9148752a7a9e","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<TemplateUsualTaskVMEntityView>( "84c4b7dd-d3c7-4bba-8423-302ac1345874","","",this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<TemplateUsualTaskVMEntityView>("b20d4464-86b7-4329-aaeb-0728e29ecfb0","","",false, this);
 
            CollectionInit params_UsualTaskByLangQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="00675b82-015f-419c-9fc4-947040ab20ee",CSSSelectorGrid="",XPathGrid=""};
            UsualTaskByLangQuery = RPSControlFactory.RPSCreateCollectionWithGrid<UsualTaskByLangQueryCollectionEditor<TemplateUsualTaskVMEntityView>,TemplateUsualTaskVMEntityView>( params_UsualTaskByLangQuery,this);
 
            Section = RPSControlFactory.CreateRPSSection<TemplateUsualTaskVMEntityView>( "","ul li[rpsid='e98dbb5f-443a-4867-9432-89340b69eb8c']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<TemplateUsualTaskVMEntityView>( "","ul li[rpsid='5dbeb03f-4aed-4817-9467-5dcae1107757']","",this);
 

        }
        public IRPSButton<TemplateUsualTaskVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<TemplateUsualTaskVMEntityView,TemplateUsualTaskVMCollectionView> AcceptButton { get; set; } 
        public IRPSTextBox<TemplateUsualTaskVMEntityView> CodUsualTask { get; set; } 
        public IRPSTextBox<TemplateUsualTaskVMEntityView> Description { get; set; } 
        public IRPSButton<TemplateUsualTaskVMEntityView> LinkNavigationCommandButton { get; set; } 
        public IRPSTextBox<TemplateUsualTaskVMEntityView> Notes { get; set; } 
        public UsualTaskByLangQueryCollectionEditor<TemplateUsualTaskVMEntityView> UsualTaskByLangQuery { get; set; } 
        public IRPSSection<TemplateUsualTaskVMEntityView> Section { get; set; } 
        public IRPSSection<TemplateUsualTaskVMEntityView> Section1 { get; set; } 
        public UsualTask Screen { get; set; }
        public TemplateUsualTaskVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UsualTaskByLangQueryCollectionEditor<TemplateUsualTaskVMEntityView>:RPSCollectionEditor<TemplateUsualTaskVMEntityView> where TemplateUsualTaskVMEntityView : class, IView
    {
        public  UsualTaskByLangQueryGridView<TemplateUsualTaskVMEntityView> GridView {get;set;}
    }
    public partial class UsualTaskByLangQueryGridView <TemplateUsualTaskVMEntityView> :  RPSGridView<TemplateUsualTaskVMEntityView> where TemplateUsualTaskVMEntityView : class, IView
    {
        public UsualTaskByLangQueryGridView(TemplateUsualTaskVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UTaskByLang_CodLanguage = RPSControlFactory.CreateRPSGridComboBox<TemplateUsualTaskVMEntityView>("","#00675b82-015f-419c-9fc4-947040ab20ee .ag-row[role='row']@ROWINDEX [col-id='cUTaskByLang_CodLanguage']","",false, this.CurrentView);
 
            UTaskByLang_Description = RPSControlFactory.CreateRPSGridTextBox<TemplateUsualTaskVMEntityView>("","#00675b82-015f-419c-9fc4-947040ab20ee .ag-row[role='row']@ROWINDEX [col-id='cUTaskByLang_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TemplateUsualTaskVMEntityView> UTaskByLang_CodLanguage { get; set; } 
        public IRPSGridTextBox<TemplateUsualTaskVMEntityView> UTaskByLang_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class UTaskByLangView : View
    {
        public UTaskByLangView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UTaskByLangView>( this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<UTaskByLangView>("cfb497dc-d9d9-4d4d-be15-98cb3d221a0f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UTaskByLangView>("c0a1370b-1026-4f1b-8b1c-96177e496659","","",false, this);
 

        }
        public IRPSSaveButton<UTaskByLangView> SaveButton { get; set; } 
        public IRPSComboBox<UTaskByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<UTaskByLangView> Description { get; set; } 
        public UsualTask Screen { get; set; }
        public UTaskByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}