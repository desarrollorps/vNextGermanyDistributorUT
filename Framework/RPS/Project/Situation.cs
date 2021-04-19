    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Situation
{
    //RPS VERSION 1.0.0.0
    public partial class Situation:Screen
    {
        public Situation():base()
        {
            this.URL = "project.situation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationCollectionView  = new SituationCollectionView(this); 
            SituationEntityView  = new SituationEntityView(this); 
            SituationCollectionView.InitializeControls(); 
            SituationEntityView.InitializeControls(); 
           
        }
      
            public SituationCollectionView SituationCollectionView {get; set; } 
            public SituationEntityView SituationEntityView {get; set; } 
    }
            
    public partial class SituationCollectionView : View
    {
        public SituationCollectionView(Situation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SituationCollectionView,SituationEntityView>( this,Screen.SituationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "40512181-bff7-41d1-88bd-0ba196e39521",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SituationCollectionView,SituationEntityView>( params_MainConsult,this,Screen.SituationEntityView);
 

        }
        public IRPSButton<SituationCollectionView,SituationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SituationCollectionView,SituationEntityView> MainConsult { get; set; } 
        public Situation Screen { get; set; }
        public SituationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SituationEntityView : View
    {
        public SituationEntityView(Situation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SituationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SituationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SituationEntityView,SituationCollectionView>( this,Screen.SituationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SituationEntityView,SituationCollectionView>( this,Screen.SituationCollectionView);
 
            CodSituation = RPSControlFactory.CreateRPSTextBox<SituationEntityView>("4b551144-433d-42b3-b8e3-61dbdd2ff65c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SituationEntityView>("12f4b981-ba00-4a15-942c-6c7a31539a8d","","",false, this);
 
            SituationType = RPSControlFactory.CreateRPSEnumComboBox<SituationEntityView>("af06d408-4751-4b4f-89c3-716c3ddd9e75","","",true, this);
 
            AllowImputations = RPSControlFactory.CreateRPSCheckBox<SituationEntityView>("8401b474-bd95-48b1-970d-91af0a305c1b","","",true, this);
 
            AllowImputationsCost = RPSControlFactory.CreateRPSCheckBox<SituationEntityView>("eca370d1-2e33-42ff-818e-05fc65894a74","","",true, this);
 
            AllowImputationsMaterial = RPSControlFactory.CreateRPSCheckBox<SituationEntityView>("55c82375-1334-4522-a03d-21633a3506df","","",true, this);
 
            AllowWarning = RPSControlFactory.CreateRPSCheckBox<SituationEntityView>("33cb013b-bc95-4c7b-9301-300105ceeb17","","",true, this);
 
            AllowTest = RPSControlFactory.CreateRPSCheckBox<SituationEntityView>("32aff0f0-08f0-409c-9287-4839d94e48a3","","",true, this);
 

        }
        public IRPSSaveButton<SituationEntityView> SaveButton { get; set; } 
        public IRPSButton<SituationEntityView> DeleteButton { get; set; } 
        public IRPSButton<SituationEntityView,SituationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SituationEntityView,SituationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SituationEntityView> CodSituation { get; set; } 
        public IRPSTextBox<SituationEntityView> Description { get; set; } 
        public IRPSComboBox<SituationEntityView> SituationType { get; set; } 
        public IRPSCheckbox<SituationEntityView> AllowImputations { get; set; } 
        public IRPSCheckbox<SituationEntityView> AllowImputationsCost { get; set; } 
        public IRPSCheckbox<SituationEntityView> AllowImputationsMaterial { get; set; } 
        public IRPSCheckbox<SituationEntityView> AllowWarning { get; set; } 
        public IRPSCheckbox<SituationEntityView> AllowTest { get; set; } 
        public Situation Screen { get; set; }
        public SituationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}