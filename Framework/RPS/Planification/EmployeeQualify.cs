    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.EmployeeQualify
{
    //RPS VERSION 1.0.0.0
    public partial class EmployeeQualify:Screen
    {
        public EmployeeQualify():base()
        {
            this.URL = "planification.employeequalify";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeQualifyVMCollectionView  = new EmployeeQualifyVMCollectionView(this); 
            EmployeeQualifyVMEntityView  = new EmployeeQualifyVMEntityView(this); 
            EmployeeQualifyVMCollectionView.InitializeControls(); 
            EmployeeQualifyVMEntityView.InitializeControls(); 
           
        }
      
            public EmployeeQualifyVMCollectionView EmployeeQualifyVMCollectionView {get; set; } 
            public EmployeeQualifyVMEntityView EmployeeQualifyVMEntityView {get; set; } 
    }
            
    public partial class EmployeeQualifyVMCollectionView : View
    {
        public EmployeeQualifyVMCollectionView(EmployeeQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<EmployeeQualifyVMCollectionView>("93e7d845-1886-42b1-8086-102076e013b2","","",false, this);
 
            Qualify = RPSControlFactory.CreateRPSComboBox<EmployeeQualifyVMCollectionView>("7794ade5-f291-4b5b-96a7-f7443b53f12f","","",false, this);
 
            PriorityUpCommandButton = RPSControlFactory.CreateRPSButton<EmployeeQualifyVMCollectionView>( "aa844234-41f8-4e38-9e82-9ff57bcbc8f0","","",this);
 
            PriorityDownCommandButton = RPSControlFactory.CreateRPSButton<EmployeeQualifyVMCollectionView>( "b58d98a8-0626-4dd0-9de8-d5c95b716365","","",this);
 
            CollectionInit params_EmployeeQualifyBySite = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b40ed8e9-fb86-49c4-b91c-81b5f71fd6dc",CSSSelectorGrid="",XPathGrid=""};
            EmployeeQualifyBySite = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeQualifyBySiteCollectionEditor<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView>,EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView>( params_EmployeeQualifyBySite,this,Screen.EmployeeQualifyVMEntityView);
 

        }
        public IRPSComboBox<EmployeeQualifyVMCollectionView> Site { get; set; } 
        public IRPSComboBox<EmployeeQualifyVMCollectionView> Qualify { get; set; } 
        public IRPSButton<EmployeeQualifyVMCollectionView> PriorityUpCommandButton { get; set; } 
        public IRPSButton<EmployeeQualifyVMCollectionView> PriorityDownCommandButton { get; set; } 
        public EmployeeQualifyBySiteCollectionEditor<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView> EmployeeQualifyBySite { get; set; } 
        public EmployeeQualify Screen { get; set; }
        public EmployeeQualifyVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeeQualifyBySiteCollectionEditor<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView>:RPSCollectionEditor<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView> where EmployeeQualifyVMCollectionView : class, IView where EmployeeQualifyVMEntityView : class, IView
    {
        public  EmployeeQualifyBySiteGridView<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView> GridView {get;set;}
    }
    public partial class EmployeeQualifyBySiteGridView <EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView> :  RPSGridView<EmployeeQualifyVMCollectionView,EmployeeQualifyVMEntityView> where EmployeeQualifyVMCollectionView : class, IView where EmployeeQualifyVMEntityView : class, IView
    {
        public EmployeeQualifyBySiteGridView(EmployeeQualifyVMCollectionView currentView,EmployeeQualifyVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<EmployeeQualifyVMCollectionView>("","#b40ed8e9-fb86-49c4-b91c-81b5f71fd6dc .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            Alternative = RPSControlFactory.CreateRPSGridCheckBox<EmployeeQualifyVMCollectionView>("","#b40ed8e9-fb86-49c4-b91c-81b5f71fd6dc .ag-row[role='row']@ROWINDEX [col-id='cAlternative']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<EmployeeQualifyVMCollectionView>("","#b40ed8e9-fb86-49c4-b91c-81b5f71fd6dc .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EmployeeQualifyVMCollectionView> IDEmployee { get; set; } 
        public IRPSGridCheckbox<EmployeeQualifyVMCollectionView> Alternative { get; set; } 
        public IRPSGridTextBox<EmployeeQualifyVMCollectionView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmployeeQualifyVMEntityView : View
    {
        public EmployeeQualifyVMEntityView(EmployeeQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeQualifyVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView>( this,Screen.EmployeeQualifyVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView>( this,Screen.EmployeeQualifyVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView>( this,Screen.EmployeeQualifyVMCollectionView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<EmployeeQualifyVMEntityView>("6bb12f65-8aae-4614-8fc6-72be3523aab3","","",true, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<EmployeeQualifyVMEntityView>("bff20a37-cc7d-4427-aa68-752dae8cdce3","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeQualifyVMEntityView>("31006f9e-5cc3-48a5-a484-020122495b88","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<EmployeeQualifyVMEntityView>("d10ce5a4-3c69-400f-bfc7-47fb186444a7","","",true, this);
 
            DefaultQualify = RPSControlFactory.CreateRPSCheckBox<EmployeeQualifyVMEntityView>("f0ff4508-6f35-4600-a98d-554a2baf60ed","","",true, this);
 

        }
        public IRPSButton<EmployeeQualifyVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<EmployeeQualifyVMEntityView,EmployeeQualifyVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<EmployeeQualifyVMEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<EmployeeQualifyVMEntityView> IDQualify { get; set; } 
        public IRPSTextBox<EmployeeQualifyVMEntityView> Priority { get; set; } 
        public IRPSCheckbox<EmployeeQualifyVMEntityView> Alternative { get; set; } 
        public IRPSCheckbox<EmployeeQualifyVMEntityView> DefaultQualify { get; set; } 
        public EmployeeQualify Screen { get; set; }
        public EmployeeQualifyVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}