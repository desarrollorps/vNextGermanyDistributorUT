    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Qualify
{
    //RPS VERSION 1.0.0.0
    public partial class Qualify:Screen
    {
        public Qualify():base()
        {
            this.URL = "general.qualify";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualifyCollectionView  = new QualifyCollectionView(this); 
            QualifyEntityView  = new QualifyEntityView(this); 
            QualifyCollectionView.InitializeControls(); 
            QualifyEntityView.InitializeControls(); 
           
        }
      
            public QualifyCollectionView QualifyCollectionView {get; set; } 
            public QualifyEntityView QualifyEntityView {get; set; } 
    }
            
    public partial class QualifyCollectionView : View
    {
        public QualifyCollectionView(Qualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualifyCollectionView,QualifyEntityView>( this,Screen.QualifyEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1af34ad6-f8aa-46ed-8171-74bd94f3ae06",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QualifyCollectionView,QualifyEntityView>( params_MainConsult,this,Screen.QualifyEntityView);
 

        }
        public IRPSButton<QualifyCollectionView,QualifyEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<QualifyCollectionView,QualifyEntityView> MainConsult { get; set; } 
        public Qualify Screen { get; set; }
        public QualifyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualifyEntityView : View
    {
        public QualifyEntityView(Qualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualifyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualifyEntityView,QualifyCollectionView>( this,Screen.QualifyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualifyEntityView,QualifyCollectionView>( this,Screen.QualifyCollectionView);
 
            CodQualify = RPSControlFactory.CreateRPSTextBox<QualifyEntityView>("ff8f7ba6-2150-4289-9800-7eaf824234f4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QualifyEntityView>("170727d5-ded2-4efa-b724-dea2087e8a93","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<QualifyEntityView>("06099691-c834-4ee8-bfdb-ce8dcd1fd5b1","","",true, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<QualifyEntityView>("f93853ce-a6de-41a8-88a7-df6d6c22fe2f","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<QualifyEntityView>("6cf8f6e9-1d16-4383-96a0-4b4e7a350e25","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<QualifyEntityView>("1881ba04-9a27-4883-a030-b2374fb80107","","",true, this);
 
            Infinite = RPSControlFactory.CreateRPSCheckBox<QualifyEntityView>("98b61709-aae4-47ea-be43-538ac6e40aa5","","",true, this);
 
            KeepResource = RPSControlFactory.CreateRPSCheckBox<QualifyEntityView>("779a8d48-6812-4660-92a4-32bac8bea5d5","","",false, this);
 
            IDHeadOfDepartment = RPSControlFactory.CreateRPSComboBox<QualifyEntityView>("2b17aff3-2fea-483e-abd6-dcab312e9c46","","",false, this);
 
            IDReplacement = RPSControlFactory.CreateRPSComboBox<QualifyEntityView>("6ccb3ba5-9e38-4c35-bb44-cd7ec13989df","","",false, this);
 
            CollectionInit params_EmployeebyCualifyConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4353c13b-c04e-46a5-b2e3-e4375d6d5b26",CSSSelectorGrid="",XPathGrid=""};
            EmployeebyCualifyConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeebyCualifyConsultCollectionEditor<QualifyEntityView>,QualifyEntityView>( params_EmployeebyCualifyConsult,this);
 

        }
        public IRPSSaveButton<QualifyEntityView> SaveButton { get; set; } 
        public IRPSButton<QualifyEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualifyEntityView,QualifyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualifyEntityView,QualifyCollectionView> BackButton { get; set; } 
        public IRPSTextBox<QualifyEntityView> CodQualify { get; set; } 
        public IRPSTextBox<QualifyEntityView> Description { get; set; } 
        public IRPSComboBox<QualifyEntityView> Type { get; set; } 
        public IRPSComboBox<QualifyEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<QualifyEntityView> IDSite { get; set; } 
        public IRPSCheckbox<QualifyEntityView> BottleNeck { get; set; } 
        public IRPSCheckbox<QualifyEntityView> Infinite { get; set; } 
        public IRPSCheckbox<QualifyEntityView> KeepResource { get; set; } 
        public IRPSComboBox<QualifyEntityView> IDHeadOfDepartment { get; set; } 
        public IRPSComboBox<QualifyEntityView> IDReplacement { get; set; } 
        public EmployeebyCualifyConsultCollectionEditor<QualifyEntityView> EmployeebyCualifyConsult { get; set; } 
        public Qualify Screen { get; set; }
        public QualifyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeebyCualifyConsultCollectionEditor<QualifyEntityView>:RPSCollectionEditor<QualifyEntityView> where QualifyEntityView : class, IView
    {
        public  EmployeebyCualifyConsultGridView<QualifyEntityView> GridView {get;set;}
    }
    public partial class EmployeebyCualifyConsultGridView <QualifyEntityView> :  RPSGridView<QualifyEntityView> where QualifyEntityView : class, IView
    {
        public EmployeebyCualifyConsultGridView(QualifyEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EmployeeQualify_Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<QualifyEntityView>("","#4353c13b-c04e-46a5-b2e3-e4375d6d5b26 .ag-row[role='row']@ROWINDEX [col-id='cEmployeeQualify_Priority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QualifyEntityView> EmployeeQualify_Priority { get; set; } 
                     
    }
 
    }
  
    

}