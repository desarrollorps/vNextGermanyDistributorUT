    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialConditionTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConditionTypeSL:Screen
    {
        public CommercialConditionTypeSL():base()
        {
            this.URL = "sales.commercialconditiontypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConditionTypeSLCollectionView  = new CommercialConditionTypeSLCollectionView(this); 
            CommercialConditionTypeSLEntityView  = new CommercialConditionTypeSLEntityView(this); 
            CommercialConditionTypeSLCollectionView.InitializeControls(); 
            CommercialConditionTypeSLEntityView.InitializeControls(); 
           
        }
      
            public CommercialConditionTypeSLCollectionView CommercialConditionTypeSLCollectionView {get; set; } 
            public CommercialConditionTypeSLEntityView CommercialConditionTypeSLEntityView {get; set; } 
    }
            
    public partial class CommercialConditionTypeSLCollectionView : View
    {
        public CommercialConditionTypeSLCollectionView(CommercialConditionTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConditionTypeSLCollectionView,CommercialConditionTypeSLEntityView>( this,Screen.CommercialConditionTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2890a268-71c0-41ea-ad16-02c165b2e9c4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialConditionTypeSLCollectionView,CommercialConditionTypeSLEntityView>( params_MainConsult,this,Screen.CommercialConditionTypeSLEntityView);
 

        }
        public IRPSButton<CommercialConditionTypeSLCollectionView,CommercialConditionTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialConditionTypeSLCollectionView,CommercialConditionTypeSLEntityView> MainConsult { get; set; } 
        public CommercialConditionTypeSL Screen { get; set; }
        public CommercialConditionTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialConditionTypeSLEntityView : View
    {
        public CommercialConditionTypeSLEntityView(CommercialConditionTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConditionTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConditionTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConditionTypeSLEntityView,CommercialConditionTypeSLCollectionView>( this,Screen.CommercialConditionTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConditionTypeSLEntityView,CommercialConditionTypeSLCollectionView>( this,Screen.CommercialConditionTypeSLCollectionView);
 
            CodCommercialConditionType = RPSControlFactory.CreateRPSTextBox<CommercialConditionTypeSLEntityView>("a1321329-0b14-417f-a726-c784d9c8b7d6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConditionTypeSLEntityView>("b85d532b-83d6-42a6-97e7-f50141b228a5","","",false, this);
 
            AffectsPrice = RPSControlFactory.CreateRPSCheckBox<CommercialConditionTypeSLEntityView>("21fa43d5-a01e-4f3a-a3ff-df3129001bf8","","",true, this);
 
            ApplyOrder = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionTypeSLEntityView>("4b2b0f24-02cb-4af0-9b1d-0e7aa16c8027","","",true, this);
 
            ConditionType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeSLEntityView>("8e66c312-f47b-4873-ae9c-d30722a9e413","","",true, this);
 
            BaseApply = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeSLEntityView>("63b1288a-2a39-4d52-8c83-61b386079dc9","","",true, this);
 
            Cassation = RPSControlFactory.CreateRPSCheckBox<CommercialConditionTypeSLEntityView>("7307786d-b195-47b1-9c91-ea398b0c1ec9","","",true, this);
 
            CassationType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionTypeSLEntityView>("c2863249-4e12-4564-b9ad-d728ec6c1501","","",true, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<CommercialConditionTypeSLEntityView>("edc1913f-3ad5-468d-ba64-723e8b6e42cb","","",false, this);
 

        }
        public IRPSSaveButton<CommercialConditionTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConditionTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConditionTypeSLEntityView,CommercialConditionTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConditionTypeSLEntityView,CommercialConditionTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialConditionTypeSLEntityView> CodCommercialConditionType { get; set; } 
        public IRPSTextBox<CommercialConditionTypeSLEntityView> Description { get; set; } 
        public IRPSCheckbox<CommercialConditionTypeSLEntityView> AffectsPrice { get; set; } 
        public IRPSTextBox<CommercialConditionTypeSLEntityView> ApplyOrder { get; set; } 
        public IRPSComboBox<CommercialConditionTypeSLEntityView> ConditionType { get; set; } 
        public IRPSComboBox<CommercialConditionTypeSLEntityView> BaseApply { get; set; } 
        public IRPSCheckbox<CommercialConditionTypeSLEntityView> Cassation { get; set; } 
        public IRPSComboBox<CommercialConditionTypeSLEntityView> CassationType { get; set; } 
        public IRPSComboBox<CommercialConditionTypeSLEntityView> IDCommercialConcept { get; set; } 
        public CommercialConditionTypeSL Screen { get; set; }
        public CommercialConditionTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}