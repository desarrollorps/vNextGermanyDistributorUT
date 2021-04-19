    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.EliminationSettings
{
    //RPS VERSION 1.0.0.0
    public partial class EliminationSettings:Screen
    {
        public EliminationSettings():base()
        {
            this.URL = "generalledger.eliminationsettings";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EliminationSettingsCollectionView  = new EliminationSettingsCollectionView(this); 
            EliminationSettingsEntityView  = new EliminationSettingsEntityView(this); 
            EliminationSettingsCollectionView.InitializeControls(); 
            EliminationSettingsEntityView.InitializeControls(); 
           
        }
      
            public EliminationSettingsCollectionView EliminationSettingsCollectionView {get; set; } 
            public EliminationSettingsEntityView EliminationSettingsEntityView {get; set; } 
    }
            
    public partial class EliminationSettingsCollectionView : View
    {
        public EliminationSettingsCollectionView(EliminationSettings screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EliminationSettingsCollectionView,EliminationSettingsEntityView>( this,Screen.EliminationSettingsEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a9991cc1-e7fc-4abf-bef5-ce3b047f7709",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EliminationSettingsCollectionView,EliminationSettingsEntityView>( params_MainConsult,this,Screen.EliminationSettingsEntityView);
 

        }
        public IRPSButton<EliminationSettingsCollectionView,EliminationSettingsEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EliminationSettingsCollectionView,EliminationSettingsEntityView> MainConsult { get; set; } 
        public EliminationSettings Screen { get; set; }
        public EliminationSettingsCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EliminationSettingsEntityView : View
    {
        public EliminationSettingsEntityView(EliminationSettings screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EliminationSettingsEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EliminationSettingsEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EliminationSettingsEntityView,EliminationSettingsCollectionView>( this,Screen.EliminationSettingsCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EliminationSettingsEntityView,EliminationSettingsCollectionView>( this,Screen.EliminationSettingsCollectionView);
 
            CodSettings = RPSControlFactory.CreateRPSTextBox<EliminationSettingsEntityView>("9b09e338-bc10-4ce6-b0b5-d507409c2e52","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EliminationSettingsEntityView>("a16f23ec-b44c-47b5-9276-928d18db6fce","","",false, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("d1aba19f-9488-441a-9e9c-d211f613ce67","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("83da7670-8314-4f5d-a728-ea7f95fb128e","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<EliminationSettingsEntityView>("3ab7ee4c-8c36-4273-808b-690d2da241d1","","",false, this);
 
            EmpBaseDCON = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("b4e32958-66cb-41ff-8cea-646dad137299","","",false, this);
 
            IDCtaBaseD = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("120f3f4b-8767-4ec3-b801-86912450e9ff","","",false, this);
 
            EmpBaseHCON = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("49be5b68-e7d3-4bb7-b56b-c255ee41e84c","","",false, this);
 
            IDCtaBaseH = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("b5b3f888-9de1-4de4-a755-eb76480264c6","","",false, this);
 
            EmpDCON = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("3412f50c-6890-461d-b93d-0cdb5391c5f6","","",false, this);
 
            CtaD = RPSControlFactory.CreateRPSTextBox<EliminationSettingsEntityView>("82e52eaf-561b-4ffc-aa78-3653b3e37c85","","",false, this);
 
            IDACCConceptD = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("ab4d7681-2bdd-4ba4-95cc-7b54670934d7","","",false, this);
 
            EmpHCON = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("477c6419-2bba-4e22-8338-463e37688354","","",false, this);
 
            CtaH = RPSControlFactory.CreateRPSTextBox<EliminationSettingsEntityView>("1cb0ef44-1346-4fd3-bdf3-14772301d7dd","","",false, this);
 
            IDACCConceptH = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("8802b812-30bb-4ba6-ab4d-ba041f2555e4","","",false, this);
 
            EmprGR1 = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("ec18ae6b-aa6e-45e9-8457-17a45414dddb","","",false, this);
 
            IDCtaComp1D = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("9a3d8b45-2aab-43eb-b205-fa2607f15858","","",false, this);
 
            IDCtaComp1H = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("a27b2309-0776-4761-a4cd-213cbf7f96e8","","",false, this);
 
            IDACCConceptComp1 = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("4359308a-a0bb-4953-9151-2cf72980f99b","","",false, this);
 
            ApplyingPartic = RPSControlFactory.CreateRPSCheckBox<EliminationSettingsEntityView>("3524489d-b9d6-4f97-a604-eacec6f558c1","","",true, this);
 
            EmprGR2 = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("f8188e76-30bd-48be-871d-788299608b34","","",false, this);
 
            IDCtaComp2D = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("a9dcbe0d-1594-43d6-a891-f617a2d2d33b","","",false, this);
 
            IDCtaComp2H = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("618adfcb-41dc-41f8-b70d-003eeda32f65","","",false, this);
 
            IDACCConceptComp2 = RPSControlFactory.CreateRPSComboBox<EliminationSettingsEntityView>("5237104e-1856-4b1b-b82d-5f5db3341076","","",false, this);
 

        }
        public IRPSSaveButton<EliminationSettingsEntityView> SaveButton { get; set; } 
        public IRPSButton<EliminationSettingsEntityView> DeleteButton { get; set; } 
        public IRPSButton<EliminationSettingsEntityView,EliminationSettingsCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EliminationSettingsEntityView,EliminationSettingsCollectionView> BackButton { get; set; } 
        public IRPSTextBox<EliminationSettingsEntityView> CodSettings { get; set; } 
        public IRPSTextBox<EliminationSettingsEntityView> Description { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDVoucherType { get; set; } 
        public IRPSTextBox<EliminationSettingsEntityView> Extension { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmpBaseDCON { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaBaseD { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmpBaseHCON { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaBaseH { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmpDCON { get; set; } 
        public IRPSTextBox<EliminationSettingsEntityView> CtaD { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDACCConceptD { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmpHCON { get; set; } 
        public IRPSTextBox<EliminationSettingsEntityView> CtaH { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDACCConceptH { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmprGR1 { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaComp1D { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaComp1H { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDACCConceptComp1 { get; set; } 
        public IRPSCheckbox<EliminationSettingsEntityView> ApplyingPartic { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> EmprGR2 { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaComp2D { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDCtaComp2H { get; set; } 
        public IRPSComboBox<EliminationSettingsEntityView> IDACCConceptComp2 { get; set; } 
        public EliminationSettings Screen { get; set; }
        public EliminationSettingsEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}