    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.DepreciationType
{
    //RPS VERSION 1.0.0.0
    public partial class DepreciationType:Screen
    {
        public DepreciationType():base()
        {
            this.URL = "generalledger.depreciationtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FADepreciationTypeCollectionView  = new FADepreciationTypeCollectionView(this); 
            FADepreciationTypeEntityView  = new FADepreciationTypeEntityView(this); 
            FADepreciationTypeCollectionView.InitializeControls(); 
            FADepreciationTypeEntityView.InitializeControls(); 
           
        }
      
            public FADepreciationTypeCollectionView FADepreciationTypeCollectionView {get; set; } 
            public FADepreciationTypeEntityView FADepreciationTypeEntityView {get; set; } 
    }
            
    public partial class FADepreciationTypeCollectionView : View
    {
        public FADepreciationTypeCollectionView(DepreciationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FADepreciationTypeCollectionView,FADepreciationTypeEntityView>( this,Screen.FADepreciationTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fdb15fcb-baba-4443-829d-8c2448b33bc0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FADepreciationTypeCollectionView,FADepreciationTypeEntityView>( params_MainConsult,this,Screen.FADepreciationTypeEntityView);
 

        }
        public IRPSButton<FADepreciationTypeCollectionView,FADepreciationTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FADepreciationTypeCollectionView,FADepreciationTypeEntityView> MainConsult { get; set; } 
        public DepreciationType Screen { get; set; }
        public FADepreciationTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FADepreciationTypeEntityView : View
    {
        public FADepreciationTypeEntityView(DepreciationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FADepreciationTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FADepreciationTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FADepreciationTypeEntityView,FADepreciationTypeCollectionView>( this,Screen.FADepreciationTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FADepreciationTypeEntityView,FADepreciationTypeCollectionView>( this,Screen.FADepreciationTypeCollectionView);
 
            CodFADepreciationType = RPSControlFactory.CreateRPSTextBox<FADepreciationTypeEntityView>("26a08752-cb79-42a0-8e81-f0333e39a35c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FADepreciationTypeEntityView>("3f05a9a2-826f-4464-a9d3-2e0c38fce863","","",false, this);
 
            TransferGL = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("6c26a318-6349-4803-8751-4f343a595446","","",true, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<FADepreciationTypeEntityView>("f5d81747-379e-47a3-a58b-ce776e794521","","",false, this);
 
            PeriodsTotal = RPSControlFactory.CreateRPSEnumComboBox<FADepreciationTypeEntityView>("0ad78929-d761-4892-83c4-1d622b3ddc4a","","",true, this);
 
            January = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("3b1749e1-c2f1-44b6-9d3e-a37ac68e596e","","",true, this);
 
            February = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("1aaba5cc-b9c4-419e-9140-2fbce0eda65a","","",true, this);
 
            March = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("3b4f2da5-58bd-4779-b29a-e69cf6b1a558","","",true, this);
 
            April = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("ac0b649f-5122-4afd-b39d-559339fe2541","","",true, this);
 
            May = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("bdf2a8a5-5d4d-42c1-9ddc-edcd353c279f","","",true, this);
 
            June = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("44dd5201-b147-4752-9d72-e09386d71fb9","","",true, this);
 
            July = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("434ac8dc-8864-40bb-9869-cc82704b8706","","",true, this);
 
            August = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("bd81ca5a-2f9d-4dbc-99ff-6600523240ed","","",true, this);
 
            September = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("75a0e040-ffd1-4c71-b57a-7ec6a1ad7307","","",true, this);
 
            October = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("be958463-7faf-41fd-82d7-61ef2fa26733","","",true, this);
 
            November = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("a36bdd58-99e4-4a1e-a0eb-1b650227588e","","",true, this);
 
            December = RPSControlFactory.CreateRPSCheckBox<FADepreciationTypeEntityView>("b7764ca1-7a92-4dc3-8ad6-4f6dde61d711","","",true, this);
 

        }
        public IRPSSaveButton<FADepreciationTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<FADepreciationTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<FADepreciationTypeEntityView,FADepreciationTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FADepreciationTypeEntityView,FADepreciationTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FADepreciationTypeEntityView> CodFADepreciationType { get; set; } 
        public IRPSTextBox<FADepreciationTypeEntityView> Description { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> TransferGL { get; set; } 
        public IRPSComboBox<FADepreciationTypeEntityView> CodACCType { get; set; } 
        public IRPSComboBox<FADepreciationTypeEntityView> PeriodsTotal { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> January { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> February { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> March { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> April { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> May { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> June { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> July { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> August { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> September { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> October { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> November { get; set; } 
        public IRPSCheckbox<FADepreciationTypeEntityView> December { get; set; } 
        public DepreciationType Screen { get; set; }
        public FADepreciationTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}