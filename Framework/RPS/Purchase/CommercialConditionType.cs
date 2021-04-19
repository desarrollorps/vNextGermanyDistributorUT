    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.CommercialConditionType
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConditionType:Screen
    {
        public CommercialConditionType():base()
        {
            this.URL = "purchase.commercialconditiontype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConditionTypeCollectionView  = new CommercialConditionTypeCollectionView(this); 
            CommercialConditionTypeEntityView  = new CommercialConditionTypeEntityView(this); 
            CommercialConditionTypeCollectionView.InitializeControls(); 
            CommercialConditionTypeEntityView.InitializeControls(); 
           
        }
      
            public CommercialConditionTypeCollectionView CommercialConditionTypeCollectionView {get; set; } 
            public CommercialConditionTypeEntityView CommercialConditionTypeEntityView {get; set; } 
    }
            
    public partial class CommercialConditionTypeCollectionView : View
    {
        public CommercialConditionTypeCollectionView(CommercialConditionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConditionTypeCollectionView,CommercialConditionTypeEntityView>( this,Screen.CommercialConditionTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c95c7e6d-6ff9-4a10-8ba8-4c480c49d2c1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialConditionTypeCollectionView,CommercialConditionTypeEntityView>( params_MainConsult,this,Screen.CommercialConditionTypeEntityView);
 

        }
        public IRPSButton<CommercialConditionTypeCollectionView,CommercialConditionTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialConditionTypeCollectionView,CommercialConditionTypeEntityView> MainConsult { get; set; } 
        public CommercialConditionType Screen { get; set; }
        public CommercialConditionTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialConditionTypeEntityView : View
    {
        public CommercialConditionTypeEntityView(CommercialConditionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConditionTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConditionTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConditionTypeEntityView,CommercialConditionTypeCollectionView>( this,Screen.CommercialConditionTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConditionTypeEntityView,CommercialConditionTypeCollectionView>( this,Screen.CommercialConditionTypeCollectionView);
 
            CodCommercialConditionType = RPSControlFactory.CreateRPSTextBox<CommercialConditionTypeEntityView>("cacd3ed4-62b6-40c3-859e-d0cde214bea0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConditionTypeEntityView>("8e221e6f-d020-465b-a609-6e78fb05194a","","",false, this);
 
            AffectsPrice = RPSControlFactory.CreateRPSCheckBox<CommercialConditionTypeEntityView>("b4af6fce-345e-43d1-83b5-de27d0e9c850","","",true, this);
 
            ApplyOrder = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionTypeEntityView>("ec6e401d-24b1-40ff-9299-89cd48acdc3c","","",true, this);
 
            ConditionType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeEntityView>("50b7f239-bb77-4525-a952-97b57245a5d9","","",true, this);
 
            BaseApply = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeEntityView>("378de3a7-8f22-433c-8c05-b6a52b80a01b","","",true, this);
 
            Cassation = RPSControlFactory.CreateRPSCheckBox<CommercialConditionTypeEntityView>("3d6e14fe-ac48-4538-8e6a-07417b66d6d0","","",true, this);
 
            CassationType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeEntityView>("8fb3e910-f20f-4a52-a3db-4d7d8b7aa991","","",true, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<CommercialConditionTypeEntityView>("12b29d97-23ca-4c36-957a-b9d1f39740d4","","",false, this);
 

        }
        public IRPSSaveButton<CommercialConditionTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConditionTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConditionTypeEntityView,CommercialConditionTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConditionTypeEntityView,CommercialConditionTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialConditionTypeEntityView> CodCommercialConditionType { get; set; } 
        public IRPSTextBox<CommercialConditionTypeEntityView> Description { get; set; } 
        public IRPSCheckbox<CommercialConditionTypeEntityView> AffectsPrice { get; set; } 
        public IRPSTextBox<CommercialConditionTypeEntityView> ApplyOrder { get; set; } 
        public IRPSComboBox<CommercialConditionTypeEntityView> ConditionType { get; set; } 
        public IRPSComboBox<CommercialConditionTypeEntityView> BaseApply { get; set; } 
        public IRPSCheckbox<CommercialConditionTypeEntityView> Cassation { get; set; } 
        public IRPSComboBox<CommercialConditionTypeEntityView> CassationType { get; set; } 
        public IRPSComboBox<CommercialConditionTypeEntityView> IDCommercialConcept { get; set; } 
        public CommercialConditionType Screen { get; set; }
        public CommercialConditionTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}