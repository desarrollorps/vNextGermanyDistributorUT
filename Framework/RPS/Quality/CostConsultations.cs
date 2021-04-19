    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CostConsultations
{
    //RPS VERSION 1.0.0.0
    public partial class CostConsultations:Screen
    {
        public CostConsultations():base()
        {
            this.URL = "quality.costconsultations";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostConsultationsView  = new CostConsultationsView(this); 
            CostConsultationsView.InitializeControls(); 
           
        }
      
            public CostConsultationsView CostConsultationsView {get; set; } 
    }
            
    public partial class CostConsultationsView : View
    {
        public CostConsultationsView(CostConsultations screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostConsultationsView>("d3e9e4ff-0f52-46e9-a09b-ca98f0cd6a77","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CostConsultationsView>("7dae4cb0-a904-4e3b-93cf-8310c619971d","","",false, this);
 
            NCTypeOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("d25ebf4e-d4df-49c2-b981-6af594fb07d1","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("d62c1c3d-6c46-447d-9bee-f53f3202ab45","","",false, this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("5487e84b-03ad-4598-938f-b70279a4c04d","","",false, this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("073946ad-5900-4c68-9246-9cf2f670a601","","",false, this);
 
            SupplierResponseOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("bb766823-21eb-4650-9661-f11812f78c6e","","",false, this);
 
            CustomerValorationOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("6f22ff97-94ac-45c5-ac3f-2d5a0dae7e0b","","",false, this);
 
            NCCostType = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("88a038a3-768c-416e-8905-c22eb097792a","","",false, this);
 
            NCSituationOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("df58681b-51ee-4f08-8651-756cea8291b6","","",false, this);
 
            ClassificationOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("682de33e-49cd-4c39-af07-2a9f593493eb","","",false, this);
 
            RepetitiveOption = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("d5860572-972c-427f-bfd4-1a35e893bd39","","",false, this);
 
            NCStatus = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("0a4d65ab-4b00-4909-99a1-fcd83e530f49","","",false, this);
 
            NCSource = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("01c1a664-8c6f-4084-bd84-b702dea53c23","","",false, this);
 
            NCReason = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("b7dd467e-da9d-4e05-99ee-5a76bab6d8a9","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("c1c0e7dc-ff1d-42ea-a738-68b5eae23c1d","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("37424d9a-6ae9-4dc3-9e70-8abe07a9d337","","",false, this);
 
            CostConcept = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("e2220321-226c-482f-93f5-1f8278fde208","","",false, this);
 
            CostGroup = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("dc636d2b-b8eb-43fa-8bd5-f6c9cadf7676","","",false, this);
 
            YearFrom = RPSControlFactory.CreateRPSFormattedTextBox<CostConsultationsView>("902b33b7-a9dc-4b9a-a748-f20a24ec0d5d","","",false, this);
 
            YearTo = RPSControlFactory.CreateRPSFormattedTextBox<CostConsultationsView>("7b35f090-e0ad-41ac-ab66-558f45f55ca0","","",false, this);
 
            MonthFrom = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("9621aa82-2b9d-435e-a91c-37919f3fc408","","",false, this);
 
            MonthTo = RPSControlFactory.CreateRPSEnumComboBox<CostConsultationsView>("098b9230-f266-4063-a2b3-942a14019b19","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<CostConsultationsView>( "bd7e4bb4-7936-472b-9294-bac1466642ed","","",this);
 
            Prevention = RPSControlFactory.CreateRPSOption<CostConsultationsView>( "943242f9-e9bf-412a-a06b-217feecdc349","","",this);
 
            Evaluation = RPSControlFactory.CreateRPSOption<CostConsultationsView>( "be8407a3-a200-4276-bb6d-36d00ba71f91","","",this);
 
            Quality_CostGroup = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("2d249658-24d5-4e48-ab52-ba0138fcaecf","","",false, this);
 
            Quality_CostConcept = RPSControlFactory.CreateRPSComboBox<CostConsultationsView>("5668ae41-2c4f-41f1-94e4-535557d5127d","","",false, this);
 
            ExecuteCostConsultationsNonQualityCosts = RPSControlFactory.CreateRPSButton<CostConsultationsView>( "c2fac3bb-cbbd-418d-bc14-46eb55b2aa1c","","",this);
 
            NonQualityTotal = RPSControlFactory.CreateRPSFormattedTextBox<CostConsultationsView>("54bde6c0-93cd-4fef-9e74-2d6cb2513b88","","",false, this);
 
            QualityTotal = RPSControlFactory.CreateRPSFormattedTextBox<CostConsultationsView>("209bfba1-2117-42d1-883d-acb088a51b87","","",false, this);
 
            CollectionInit params_CostConsultationsNonQualityCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7e823cde-d7ec-42b8-9af7-dd0273eaa8bc",CSSSelectorGrid="",XPathGrid=""};
            CostConsultationsNonQualityCosts = RPSControlFactory.RPSCreateCollectionWithGrid<CostConsultationsNonQualityCostsCollectionEditor<CostConsultationsView>,CostConsultationsView>( params_CostConsultationsNonQualityCosts,this);
 
            CollectionInit params_CostConsultationsQualityCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9bd5ed5e-2d89-4dd7-a2df-bf0631499f75",CSSSelectorGrid="",XPathGrid=""};
            CostConsultationsQualityCosts = RPSControlFactory.RPSCreateCollectionWithGrid<CostConsultationsQualityCostsCollectionEditor<CostConsultationsView>,CostConsultationsView>( params_CostConsultationsQualityCosts,this);
 
            Section = RPSControlFactory.CreateRPSSection<CostConsultationsView>( "","ul li[rpsid='0f2d097c-ab4d-4a4a-b4d7-59b6caa22da4']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CostConsultationsView>( "","ul li[rpsid='4520c2b3-10b7-439b-8544-2d21f155e07b']","",this);
 

        }
        public IRPSTextBox<CostConsultationsView> DateFrom { get; set; } 
        public IRPSTextBox<CostConsultationsView> DateTo { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCTypeOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> Employee { get; set; } 
        public IRPSComboBox<CostConsultationsView> Supplier1 { get; set; } 
        public IRPSComboBox<CostConsultationsView> Customer1 { get; set; } 
        public IRPSComboBox<CostConsultationsView> SupplierResponseOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> CustomerValorationOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCCostType { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCSituationOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> ClassificationOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> RepetitiveOption { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCStatus { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCSource { get; set; } 
        public IRPSComboBox<CostConsultationsView> NCReason { get; set; } 
        public IRPSComboBox<CostConsultationsView> Site { get; set; } 
        public IRPSComboBox<CostConsultationsView> Article { get; set; } 
        public IRPSComboBox<CostConsultationsView> CostConcept { get; set; } 
        public IRPSComboBox<CostConsultationsView> CostGroup { get; set; } 
        public IRPSTextBox<CostConsultationsView> YearFrom { get; set; } 
        public IRPSTextBox<CostConsultationsView> YearTo { get; set; } 
        public IRPSComboBox<CostConsultationsView> MonthFrom { get; set; } 
        public IRPSComboBox<CostConsultationsView> MonthTo { get; set; } 
        public IRPSOption<CostConsultationsView> All { get; set; } 
        public IRPSOption<CostConsultationsView> Prevention { get; set; } 
        public IRPSOption<CostConsultationsView> Evaluation { get; set; } 
        public IRPSComboBox<CostConsultationsView> Quality_CostGroup { get; set; } 
        public IRPSComboBox<CostConsultationsView> Quality_CostConcept { get; set; } 
        public IRPSButton<CostConsultationsView> ExecuteCostConsultationsNonQualityCosts { get; set; } 
        public IRPSTextBox<CostConsultationsView> NonQualityTotal { get; set; } 
        public IRPSTextBox<CostConsultationsView> QualityTotal { get; set; } 
        public CostConsultationsNonQualityCostsCollectionEditor<CostConsultationsView> CostConsultationsNonQualityCosts { get; set; } 
        public CostConsultationsQualityCostsCollectionEditor<CostConsultationsView> CostConsultationsQualityCosts { get; set; } 
        public IRPSSection<CostConsultationsView> Section { get; set; } 
        public IRPSSection<CostConsultationsView> Section1 { get; set; } 
        public CostConsultations Screen { get; set; }
        public CostConsultationsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CostConsultationsNonQualityCostsCollectionEditor<CostConsultationsView>:RPSCollectionEditor<CostConsultationsView> where CostConsultationsView : class, IView
    {
        public  CostConsultationsNonQualityCostsGridView<CostConsultationsView> GridView {get;set;}
    }
    public partial class CostConsultationsNonQualityCostsGridView <CostConsultationsView> :  RPSGridView<CostConsultationsView> where CostConsultationsView : class, IView
    {
        public CostConsultationsNonQualityCostsGridView(CostConsultationsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CostDescription = RPSControlFactory.CreateRPSGridTextBox<CostConsultationsView>("","#7e823cde-d7ec-42b8-9af7-dd0273eaa8bc .ag-row[role='row']@ROWINDEX [col-id='cCostDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostConsultationsView> CostDescription { get; set; } 
                     
    }
 
        public partial class CostConsultationsQualityCostsCollectionEditor<CostConsultationsView>:RPSCollectionEditor<CostConsultationsView> where CostConsultationsView : class, IView
    {
        public  CostConsultationsQualityCostsGridView<CostConsultationsView> GridView {get;set;}
    }
    public partial class CostConsultationsQualityCostsGridView <CostConsultationsView> :  RPSGridView<CostConsultationsView> where CostConsultationsView : class, IView
    {
        public CostConsultationsQualityCostsGridView(CostConsultationsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CostDescription = RPSControlFactory.CreateRPSGridTextBox<CostConsultationsView>("","#9bd5ed5e-2d89-4dd7-a2df-bf0631499f75 .ag-row[role='row']@ROWINDEX [col-id='cCostDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostConsultationsView> CostDescription { get; set; } 
                     
    }
 
    }
  
    

}