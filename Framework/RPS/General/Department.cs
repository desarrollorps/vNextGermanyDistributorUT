    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Department
{
    //RPS VERSION 1.0.0.0
    public partial class Department:Screen
    {
        public Department():base()
        {
            this.URL = "general.department";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DepartmentCollectionView  = new DepartmentCollectionView(this); 
            DepartmentEntityView  = new DepartmentEntityView(this); 
            DepartmentCollectionView.InitializeControls(); 
            DepartmentEntityView.InitializeControls(); 
           
        }
      
            public DepartmentCollectionView DepartmentCollectionView {get; set; } 
            public DepartmentEntityView DepartmentEntityView {get; set; } 
    }
            
    public partial class DepartmentCollectionView : View
    {
        public DepartmentCollectionView(Department screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DepartmentCollectionView,DepartmentEntityView>( this,Screen.DepartmentEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "38fcbb3a-4549-4bca-b255-53d7a5bf8e89",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DepartmentCollectionView,DepartmentEntityView>( params_MainConsult,this,Screen.DepartmentEntityView);
 

        }
        public IRPSButton<DepartmentCollectionView,DepartmentEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DepartmentCollectionView,DepartmentEntityView> MainConsult { get; set; } 
        public Department Screen { get; set; }
        public DepartmentCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DepartmentEntityView : View
    {
        public DepartmentEntityView(Department screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DepartmentEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DepartmentEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DepartmentEntityView,DepartmentCollectionView>( this,Screen.DepartmentCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DepartmentEntityView,DepartmentCollectionView>( this,Screen.DepartmentCollectionView);
 
            CodDepartment = RPSControlFactory.CreateRPSTextBox<DepartmentEntityView>("e8d05e14-79cb-4d82-b984-33b95ef0ed77","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DepartmentEntityView>("64e9d205-80f3-4b5d-988b-8ae1a2fe87ea","","",false, this);
 
            IDHeadOfDepartment = RPSControlFactory.CreateRPSComboBox<DepartmentEntityView>("cd605eab-71ec-4fe0-95ef-8524c39db1f3","","",false, this);
 
            IDReplacement = RPSControlFactory.CreateRPSComboBox<DepartmentEntityView>("d94ece77-3047-42b3-a7d7-5b735044896d","","",false, this);
 

        }
        public IRPSSaveButton<DepartmentEntityView> SaveButton { get; set; } 
        public IRPSButton<DepartmentEntityView> DeleteButton { get; set; } 
        public IRPSButton<DepartmentEntityView,DepartmentCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DepartmentEntityView,DepartmentCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DepartmentEntityView> CodDepartment { get; set; } 
        public IRPSTextBox<DepartmentEntityView> Description { get; set; } 
        public IRPSComboBox<DepartmentEntityView> IDHeadOfDepartment { get; set; } 
        public IRPSComboBox<DepartmentEntityView> IDReplacement { get; set; } 
        public Department Screen { get; set; }
        public DepartmentEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}