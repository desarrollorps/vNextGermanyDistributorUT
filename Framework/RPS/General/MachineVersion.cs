    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.MachineVersion
{
    //RPS VERSION 1.0.0.0
    public partial class MachineVersion:Screen
    {
        public MachineVersion():base()
        {
            this.URL = "general.machineversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineVersionVMQueryView  = new MachineVersionVMQueryView(this); 
            MachineVersionVMEntityView  = new MachineVersionVMEntityView(this); 
            MachineVersionVMQueryView.InitializeControls(); 
            MachineVersionVMEntityView.InitializeControls(); 
           
        }
      
            public MachineVersionVMQueryView MachineVersionVMQueryView {get; set; } 
            public MachineVersionVMEntityView MachineVersionVMEntityView {get; set; } 
    }
            
    public partial class MachineVersionVMQueryView : View
    {
        public MachineVersionVMQueryView(MachineVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineVersionVMQueryView,MachineVersionVMEntityView>( this,Screen.MachineVersionVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MachineVersionVMQueryView>( this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MachineVersionVMQueryView>("be73fc9a-6ef3-4ecf-abd2-9e41c6ac8451","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<MachineVersionVMQueryView>( "e50b9304-3b1d-4f46-9bd0-91b67aa30d46","","",this);
 
            CollectionInit params_MachineVersionsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b738d704-1aca-4dbc-8b62-0fb48ba8a4cc",CSSSelectorGrid="",XPathGrid=""};
            MachineVersionsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MachineVersionsConsultCollectionEditor<MachineVersionVMQueryView,MachineVersionVMEntityView>,MachineVersionVMQueryView,MachineVersionVMEntityView>( params_MachineVersionsConsult,this,Screen.MachineVersionVMEntityView);
 

        }
        public IRPSButton<MachineVersionVMQueryView,MachineVersionVMEntityView> NewButton { get; set; } 
        public IRPSButton<MachineVersionVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<MachineVersionVMQueryView> DateTo { get; set; } 
        public IRPSButton<MachineVersionVMQueryView> DeleteCommandButton { get; set; } 
        public MachineVersionsConsultCollectionEditor<MachineVersionVMQueryView,MachineVersionVMEntityView> MachineVersionsConsult { get; set; } 
        public MachineVersion Screen { get; set; }
        public MachineVersionVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineVersionsConsultCollectionEditor<MachineVersionVMQueryView,MachineVersionVMEntityView>:RPSCollectionEditor<MachineVersionVMQueryView,MachineVersionVMEntityView> where MachineVersionVMQueryView : class, IView where MachineVersionVMEntityView : class, IView
    {
        public  MachineVersionsConsultGridView<MachineVersionVMQueryView,MachineVersionVMEntityView> GridView {get;set;}
    }
    public partial class MachineVersionsConsultGridView <MachineVersionVMQueryView,MachineVersionVMEntityView> :  RPSGridView<MachineVersionVMQueryView,MachineVersionVMEntityView> where MachineVersionVMQueryView : class, IView where MachineVersionVMEntityView : class, IView
    {
        public MachineVersionsConsultGridView(MachineVersionVMQueryView currentView,MachineVersionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MachineVersion_Machine = RPSControlFactory.CreateRPSGridTextBox<MachineVersionVMQueryView>("","#b738d704-1aca-4dbc-8b62-0fb48ba8a4cc .ag-row[role='row']@ROWINDEX [col-id='cMachineVersion_Machine']","",false, this.CurrentView);
 
            MachineVersion_Version = RPSControlFactory.CreateRPSGridTextBox<MachineVersionVMQueryView>("","#b738d704-1aca-4dbc-8b62-0fb48ba8a4cc .ag-row[role='row']@ROWINDEX [col-id='cMachineVersion_Version']","",false, this.CurrentView);
 
            MachineVersion_GeneralRowTimestamp = RPSControlFactory.CreateRPSGridTextBox<MachineVersionVMQueryView>("","#b738d704-1aca-4dbc-8b62-0fb48ba8a4cc .ag-row[role='row']@ROWINDEX [col-id='cMachineVersion_GeneralRowTimestamp']","",false, this.CurrentView);
 
            MachineVersion_GeneralLastModifiedBy = RPSControlFactory.CreateRPSGridTextBox<MachineVersionVMQueryView>("","#b738d704-1aca-4dbc-8b62-0fb48ba8a4cc .ag-row[role='row']@ROWINDEX [col-id='cMachineVersion_GeneralLastModifiedBy']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MachineVersionVMQueryView> MachineVersion_Machine { get; set; } 
        public IRPSGridTextBox<MachineVersionVMQueryView> MachineVersion_Version { get; set; } 
        public IRPSGridTextBox<MachineVersionVMQueryView> MachineVersion_GeneralRowTimestamp { get; set; } 
        public IRPSGridTextBox<MachineVersionVMQueryView> MachineVersion_GeneralLastModifiedBy { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineVersionVMEntityView : View
    {
        public MachineVersionVMEntityView(MachineVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineVersionVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineVersionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineVersionVMEntityView,MachineVersionVMQueryView>( this,Screen.MachineVersionVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineVersionVMEntityView,MachineVersionVMQueryView>( this,Screen.MachineVersionVMQueryView);
 
            Machine = RPSControlFactory.CreateRPSTextBox<MachineVersionVMEntityView>("1e569eb3-c8c8-4053-a01d-c0844e79c843","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<MachineVersionVMEntityView>("35ac3a42-6f40-469e-9491-0baf70d07a1e","","",true, this);
 

        }
        public IRPSSaveButton<MachineVersionVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineVersionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineVersionVMEntityView,MachineVersionVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineVersionVMEntityView,MachineVersionVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<MachineVersionVMEntityView> Machine { get; set; } 
        public IRPSTextBox<MachineVersionVMEntityView> Version { get; set; } 
        public MachineVersion Screen { get; set; }
        public MachineVersionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}