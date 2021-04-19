    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.EmployeeAccType
{
    //RPS VERSION 1.0.0.0
    public partial class EmployeeAccType:Screen
    {
        public EmployeeAccType():base()
        {
            this.URL = "generalledger.employeeacctype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeAccTypeCollectionView  = new EmployeeAccTypeCollectionView(this); 
            EmployeeAccTypeEntityView  = new EmployeeAccTypeEntityView(this); 
            EmployeeAccTypeCollectionView.InitializeControls(); 
            EmployeeAccTypeEntityView.InitializeControls(); 
           
        }
      
            public EmployeeAccTypeCollectionView EmployeeAccTypeCollectionView {get; set; } 
            public EmployeeAccTypeEntityView EmployeeAccTypeEntityView {get; set; } 
    }
            
    public partial class EmployeeAccTypeCollectionView : View
    {
        public EmployeeAccTypeCollectionView(EmployeeAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EmployeeAccTypeCollectionView,EmployeeAccTypeEntityView>( this,Screen.EmployeeAccTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d6058605-558c-4343-a0a8-da2355cd4b0f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EmployeeAccTypeCollectionView,EmployeeAccTypeEntityView>( params_MainConsult,this,Screen.EmployeeAccTypeEntityView);
 

        }
        public IRPSButton<EmployeeAccTypeCollectionView,EmployeeAccTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EmployeeAccTypeCollectionView,EmployeeAccTypeEntityView> MainConsult { get; set; } 
        public EmployeeAccType Screen { get; set; }
        public EmployeeAccTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeAccTypeEntityView : View
    {
        public EmployeeAccTypeEntityView(EmployeeAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeAccTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeAccTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeAccTypeEntityView,EmployeeAccTypeCollectionView>( this,Screen.EmployeeAccTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeAccTypeEntityView,EmployeeAccTypeCollectionView>( this,Screen.EmployeeAccTypeCollectionView);
 
            CodEmployeeAccType = RPSControlFactory.CreateRPSTextBox<EmployeeAccTypeEntityView>("2a6d7751-27ee-41a5-b836-ede101ccdab4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EmployeeAccTypeEntityView>("4bdabcec-95d0-4dd9-8f11-2c5e4bded3d0","","",false, this);
 
            IDAccountTRA = RPSControlFactory.CreateRPSComboBox<EmployeeAccTypeEntityView>("b4ea9841-ac31-4375-b80a-38d0dbf5d9f7","","",false, this);
 
            IDAccountTRAPayroll = RPSControlFactory.CreateRPSComboBox<EmployeeAccTypeEntityView>("fa712eea-1278-4af4-b2e6-1d132c661732","","",false, this);
 

        }
        public IRPSSaveButton<EmployeeAccTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<EmployeeAccTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeAccTypeEntityView,EmployeeAccTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeAccTypeEntityView,EmployeeAccTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<EmployeeAccTypeEntityView> CodEmployeeAccType { get; set; } 
        public IRPSTextBox<EmployeeAccTypeEntityView> Description { get; set; } 
        public IRPSComboBox<EmployeeAccTypeEntityView> IDAccountTRA { get; set; } 
        public IRPSComboBox<EmployeeAccTypeEntityView> IDAccountTRAPayroll { get; set; } 
        public EmployeeAccType Screen { get; set; }
        public EmployeeAccTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}