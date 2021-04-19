    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.CompetencySL
{
    //RPS VERSION 1.0.0.0
    public partial class CompetencySL:Screen
    {
        public CompetencySL():base()
        {
            this.URL = "salescrm.competencysl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CompetencySLQueryView  = new CompetencySLQueryView(this); 
            CompetencySLEntityView  = new CompetencySLEntityView(this); 
            CompetencySLQueryView.InitializeControls(); 
            CompetencySLEntityView.InitializeControls(); 
           
        }
      
            public CompetencySLQueryView CompetencySLQueryView {get; set; } 
            public CompetencySLEntityView CompetencySLEntityView {get; set; } 
    }
            
    public partial class CompetencySLQueryView : View
    {
        public CompetencySLQueryView(CompetencySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CompetencySLQueryView,CompetencySLEntityView>( this,Screen.CompetencySLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1516f735-8c68-48f0-b86f-1b2bb32fefea",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CompetencySLQueryView,CompetencySLEntityView>( params_MainConsult,this,Screen.CompetencySLEntityView);
 

        }
        public IRPSButton<CompetencySLQueryView,CompetencySLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CompetencySLQueryView,CompetencySLEntityView> MainConsult { get; set; } 
        public CompetencySL Screen { get; set; }
        public CompetencySLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CompetencySLEntityView : View
    {
        public CompetencySLEntityView(CompetencySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CompetencySLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CompetencySLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CompetencySLEntityView,CompetencySLQueryView>( this,Screen.CompetencySLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CompetencySLEntityView,CompetencySLQueryView>( this,Screen.CompetencySLQueryView);
 
            CodCompetency = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("949980b6-147e-4204-b609-69c1416aad1d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("ccee7e69-1885-4fac-9671-4d35a7747f28","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CompetencySLEntityView>("e37d843f-6ff4-40e4-acff-d6b0ec44f68e","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("d6d047b3-ae56-433d-aa33-321427964c6f","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CompetencySLEntityView>("426708cf-9c7a-4c2f-bb33-0c08c97ec141","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CompetencySLEntityView>("2c23d3a2-f8b8-40c6-a407-b9848fa449ca","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("6b0c428a-d547-4746-85f0-ec939763b155","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("906a9ea3-3fb2-4960-a3bf-1bd4321d456c","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("926ea661-4eca-47f1-a820-bf0488f19971","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("13409e3f-93d3-4977-9573-74647b40df1a","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("94aa3b25-dc83-46ed-8701-8f553c495697","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CompetencySLEntityView>("0f404575-45c8-4184-8aa2-775a253e7ca6","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CompetencySLEntityView>("06557e47-29c2-45ff-b72f-40880fc891da","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<CompetencySLEntityView>( "","ul li[rpsid='dc2cca14-e66d-4535-af4e-653746cf27bd']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<CompetencySLEntityView>( "","ul li[rpsid='770ebbab-e650-4bbc-9e5c-3f31177985ac']","",this);
 

        }
        public IRPSSaveButton<CompetencySLEntityView> SaveButton { get; set; } 
        public IRPSButton<CompetencySLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CompetencySLEntityView,CompetencySLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CompetencySLEntityView,CompetencySLQueryView> BackButton { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> CodCompetency { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Description { get; set; } 
        public IRPSComboBox<CompetencySLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CompetencySLEntityView> IDState { get; set; } 
        public IRPSComboBox<CompetencySLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Address { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> City { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Fax { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Email { get; set; } 
        public IRPSTextBox<CompetencySLEntityView> Comment { get; set; } 
        public IRPSSection<CompetencySLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<CompetencySLEntityView> CommentSection { get; set; } 
        public CompetencySL Screen { get; set; }
        public CompetencySLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}