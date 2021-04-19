    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CuDistCheckInCheckOut
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistCheckInCheckOut:Screen
    {
        public CuDistCheckInCheckOut():base()
        {
            this.URL = "general.cudistcheckincheckout";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistCheckInCheckOutVMQueryView  = new CuDistCheckInCheckOutVMQueryView(this); 
            CuDistCheckInCheckOutVMEntityView  = new CuDistCheckInCheckOutVMEntityView(this); 
            CuDistCheckInCheckOutVMQueryView.InitializeControls(); 
            CuDistCheckInCheckOutVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistCheckInCheckOutVMQueryView CuDistCheckInCheckOutVMQueryView {get; set; } 
            public CuDistCheckInCheckOutVMEntityView CuDistCheckInCheckOutVMEntityView {get; set; } 
    }
            
    public partial class CuDistCheckInCheckOutVMQueryView : View
    {
        public CuDistCheckInCheckOutVMQueryView(CuDistCheckInCheckOut screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView>( this,Screen.CuDistCheckInCheckOutVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistCheckInCheckOutVMQueryView>( this);
 
            All = RPSControlFactory.CreateRPSOption<CuDistCheckInCheckOutVMQueryView>( "e6b6982e-4102-4c38-ad6a-1a8ae41049ac","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<CuDistCheckInCheckOutVMQueryView>( "0ba8b5e3-2503-4f38-ae8e-bf6e82808947","","",this);
 
            CodEmployeeFromFilter = RPSControlFactory.CreateRPSEnumComboBox<CuDistCheckInCheckOutVMQueryView>("cf44fca4-8937-472b-a7cb-ad4b9b9f7806","","",false, this);
 
            CopyEmployeeCommand = RPSControlFactory.CreateRPSButton<CuDistCheckInCheckOutVMQueryView>( "ab213412-ae59-45b9-b1de-5a9f268d93b1","","",this);
 
            CodEmployeeToFilter = RPSControlFactory.CreateRPSEnumComboBox<CuDistCheckInCheckOutVMQueryView>("2e47865d-4a3d-4663-b1ea-726cb318d0c7","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<CuDistCheckInCheckOutVMQueryView>( "ec44c95e-8f7a-42c1-bd44-99e3cac27029","","",this);
 
            Selection1 = RPSControlFactory.CreateRPSOption<CuDistCheckInCheckOutVMQueryView>( "8f2d01d0-504a-4ca7-bb5e-fbb28e4dc7a3","","",this);
 
            DateEntryFromFilter = RPSControlFactory.CreateRPSTextBox<CuDistCheckInCheckOutVMQueryView>("4dbe01b8-50d6-410c-9793-30dfb2b04530","","",false, this);
 
            CopyDateEntryCommand = RPSControlFactory.CreateRPSButton<CuDistCheckInCheckOutVMQueryView>( "f019ab5a-6af4-40d8-96df-af0933379d42","","",this);
 
            DateEntryToFilter = RPSControlFactory.CreateRPSTextBox<CuDistCheckInCheckOutVMQueryView>("90f2017d-9dd1-47b5-9e7b-de209c7aa53a","","",false, this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<CuDistCheckInCheckOutVMQueryView>( "d3efec0e-d258-4262-a36c-66bfc11132f9","","",this);
 
            CollectionInit params_CuDistCheckInCheckOut = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="736916c8-dec0-4d4c-8e24-806f642e1a3d",CSSSelectorGrid="",XPathGrid=""};
            CuDistCheckInCheckOut = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistCheckInCheckOutCollectionEditor<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView>,CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView>( params_CuDistCheckInCheckOut,this,Screen.CuDistCheckInCheckOutVMEntityView);
 

        }
        public IRPSButton<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMQueryView> ConsultButton { get; set; } 
        public IRPSOption<CuDistCheckInCheckOutVMQueryView> All { get; set; } 
        public IRPSOption<CuDistCheckInCheckOutVMQueryView> Selection { get; set; } 
        public IRPSComboBox<CuDistCheckInCheckOutVMQueryView> CodEmployeeFromFilter { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMQueryView> CopyEmployeeCommand { get; set; } 
        public IRPSComboBox<CuDistCheckInCheckOutVMQueryView> CodEmployeeToFilter { get; set; } 
        public IRPSOption<CuDistCheckInCheckOutVMQueryView> All1 { get; set; } 
        public IRPSOption<CuDistCheckInCheckOutVMQueryView> Selection1 { get; set; } 
        public IRPSTextBox<CuDistCheckInCheckOutVMQueryView> DateEntryFromFilter { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMQueryView> CopyDateEntryCommand { get; set; } 
        public IRPSTextBox<CuDistCheckInCheckOutVMQueryView> DateEntryToFilter { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMQueryView> PrintCommandButton { get; set; } 
        public CuDistCheckInCheckOutCollectionEditor<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> CuDistCheckInCheckOut { get; set; } 
        public CuDistCheckInCheckOut Screen { get; set; }
        public CuDistCheckInCheckOutVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistCheckInCheckOutCollectionEditor<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView>:RPSCollectionEditor<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> where CuDistCheckInCheckOutVMQueryView : class, IView where CuDistCheckInCheckOutVMEntityView : class, IView
    {
        public  CuDistCheckInCheckOutGridView<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> GridView {get;set;}
    }
    public partial class CuDistCheckInCheckOutGridView <CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> :  RPSGridView<CuDistCheckInCheckOutVMQueryView,CuDistCheckInCheckOutVMEntityView> where CuDistCheckInCheckOutVMQueryView : class, IView where CuDistCheckInCheckOutVMEntityView : class, IView
    {
        public CuDistCheckInCheckOutGridView(CuDistCheckInCheckOutVMQueryView currentView,CuDistCheckInCheckOutVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistCheckInCheckOut_IDEmployee = RPSControlFactory.CreateRPSGridComboBox<CuDistCheckInCheckOutVMQueryView>("","#736916c8-dec0-4d4c-8e24-806f642e1a3d .ag-row[role='row']@ROWINDEX [col-id='cCuDistCheckInCheckOut_IDEmployee']","",false, this.CurrentView);
 
            CuDistCheckInCheckOut_DateEntry = RPSControlFactory.CreateRPSGridTextBox<CuDistCheckInCheckOutVMQueryView>("","#736916c8-dec0-4d4c-8e24-806f642e1a3d .ag-row[role='row']@ROWINDEX [col-id='cCuDistCheckInCheckOut_DateEntry']","",false, this.CurrentView);
 
            CuDistCheckInCheckOut_Type = RPSControlFactory.CreateRPSGridTextBox<CuDistCheckInCheckOutVMQueryView>("","#736916c8-dec0-4d4c-8e24-806f642e1a3d .ag-row[role='row']@ROWINDEX [col-id='cCuDistCheckInCheckOut_Type']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CuDistCheckInCheckOutVMQueryView> CuDistCheckInCheckOut_IDEmployee { get; set; } 
        public IRPSGridTextBox<CuDistCheckInCheckOutVMQueryView> CuDistCheckInCheckOut_DateEntry { get; set; } 
        public IRPSGridTextBox<CuDistCheckInCheckOutVMQueryView> CuDistCheckInCheckOut_Type { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistCheckInCheckOutVMEntityView : View
    {
        public CuDistCheckInCheckOutVMEntityView(CuDistCheckInCheckOut screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistCheckInCheckOutVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistCheckInCheckOutVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistCheckInCheckOutVMEntityView,CuDistCheckInCheckOutVMQueryView>( this,Screen.CuDistCheckInCheckOutVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistCheckInCheckOutVMEntityView,CuDistCheckInCheckOutVMQueryView>( this,Screen.CuDistCheckInCheckOutVMQueryView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<CuDistCheckInCheckOutVMEntityView>("82ba58e8-ebe9-4d5a-9066-4970114e983c","","",true, this);
 
            DateEntry = RPSControlFactory.CreateRPSTextBox<CuDistCheckInCheckOutVMEntityView>("96648ff8-e209-4549-8d51-96a137497647","","",false, this);
 
            Time = RPSControlFactory.CreateRPSTextBox<CuDistCheckInCheckOutVMEntityView>("238d26e1-1829-409c-8842-6f1888300f58","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CuDistCheckInCheckOutVMEntityView>("f8e58202-d184-42e4-bcb8-a67bd0a63bc6","","",true, this);
 

        }
        public IRPSSaveButton<CuDistCheckInCheckOutVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMEntityView,CuDistCheckInCheckOutVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistCheckInCheckOutVMEntityView,CuDistCheckInCheckOutVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CuDistCheckInCheckOutVMEntityView> IDEmployee { get; set; } 
        public IRPSTextBox<CuDistCheckInCheckOutVMEntityView> DateEntry { get; set; } 
        public IRPSTextBox<CuDistCheckInCheckOutVMEntityView> Time { get; set; } 
        public IRPSComboBox<CuDistCheckInCheckOutVMEntityView> Type { get; set; } 
        public CuDistCheckInCheckOut Screen { get; set; }
        public CuDistCheckInCheckOutVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}