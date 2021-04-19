    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.Application
{
    //RPS VERSION 1.0.0.0
    public partial class Application:Screen
    {
        public Application():base()
        {
            this.URL = "bpm.application";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ApplicationCollectionView  = new ApplicationCollectionView(this); 
            ApplicationEntityView  = new ApplicationEntityView(this); 
            ApplicationCollectionView.InitializeControls(); 
            ApplicationEntityView.InitializeControls(); 
           
        }
      
            public ApplicationCollectionView ApplicationCollectionView {get; set; } 
            public ApplicationEntityView ApplicationEntityView {get; set; } 
    }
            
    public partial class ApplicationCollectionView : View
    {
        public ApplicationCollectionView(Application screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ApplicationCollectionView,ApplicationEntityView>( this,Screen.ApplicationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "69eb86cc-423c-4320-b4fd-ca7b56fdcca4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ApplicationCollectionView,ApplicationEntityView>( params_MainConsult,this,Screen.ApplicationEntityView);
 

        }
        public IRPSButton<ApplicationCollectionView,ApplicationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ApplicationCollectionView,ApplicationEntityView> MainConsult { get; set; } 
        public Application Screen { get; set; }
        public ApplicationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ApplicationEntityView : View
    {
        public ApplicationEntityView(Application screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ApplicationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ApplicationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ApplicationEntityView,ApplicationCollectionView>( this,Screen.ApplicationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ApplicationEntityView,ApplicationCollectionView>( this,Screen.ApplicationCollectionView);
 
            CodApplication = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("3b4f1de0-5c31-48a6-9a20-3a5d9df62ae5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("e8c2cdfd-5339-4733-a4f3-a73baa4460f1","","",false, this);
 
            Product = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("c0151d22-5b85-4333-bdcd-8fbdf18bdb7e","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ApplicationEntityView>("32479973-d85b-4eb6-bad9-b1eb83f03e85","","",true, this);
 
            Complexity = RPSControlFactory.CreateRPSEnumComboBox<ApplicationEntityView>("9de17562-21db-409c-9327-e4cf86e7bcb5","","",true, this);
 
            Criticality = RPSControlFactory.CreateRPSEnumComboBox<ApplicationEntityView>("3a29d1ca-57ae-4435-be0b-bd6bb54c796f","","",true, this);
 
            Customization = RPSControlFactory.CreateRPSEnumComboBox<ApplicationEntityView>("92a0d31e-6705-4e1a-a5c2-663e4fb79c12","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("5e9590f2-0938-4ffc-b761-593aa085272c","","",false, this);
 
            Analysis = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("e543c524-a6bd-4e34-8e1e-a6d71b1e099a","","",false, this);
 
            Evolution = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("b4c22dc1-79cb-4605-8f6d-6e417832ed68","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ApplicationEntityView>("556470f4-6ae4-471f-87c7-607943b583da","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<ApplicationEntityView>( "","ul li[rpsid='0c48b579-1475-4f47-a54a-f61191e37ce1']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ApplicationEntityView>( "","ul li[rpsid='d2071fe9-12d3-42ab-b283-4672f18c3651']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<ApplicationEntityView>( "","ul li[rpsid='afa4f571-a016-47ad-a4cd-e898835c3509']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<ApplicationEntityView>( "","ul li[rpsid='2189064e-83de-43c7-90cb-746853f8c7ae']","",this);
 

        }
        public IRPSSaveButton<ApplicationEntityView> SaveButton { get; set; } 
        public IRPSButton<ApplicationEntityView> DeleteButton { get; set; } 
        public IRPSButton<ApplicationEntityView,ApplicationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ApplicationEntityView,ApplicationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ApplicationEntityView> CodApplication { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Description { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Product { get; set; } 
        public IRPSComboBox<ApplicationEntityView> Type { get; set; } 
        public IRPSComboBox<ApplicationEntityView> Complexity { get; set; } 
        public IRPSComboBox<ApplicationEntityView> Criticality { get; set; } 
        public IRPSComboBox<ApplicationEntityView> Customization { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Date { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Analysis { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Evolution { get; set; } 
        public IRPSTextBox<ApplicationEntityView> Comments { get; set; } 
        public IRPSSection<ApplicationEntityView> Section { get; set; } 
        public IRPSSection<ApplicationEntityView> Section1 { get; set; } 
        public IRPSSection<ApplicationEntityView> Section2 { get; set; } 
        public IRPSSection<ApplicationEntityView> Section3 { get; set; } 
        public Application Screen { get; set; }
        public ApplicationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}