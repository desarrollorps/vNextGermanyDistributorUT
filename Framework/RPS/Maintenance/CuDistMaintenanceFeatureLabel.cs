    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.CuDistMaintenanceFeatureLabel
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistMaintenanceFeatureLabel:Screen
    {
        public CuDistMaintenanceFeatureLabel():base()
        {
            this.URL = "maintenance.cudistmaintenancefeaturelabel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistManFeatureLabelCollectionView  = new CuDistManFeatureLabelCollectionView(this); 
            CuDistManFeatureLabelEntityView  = new CuDistManFeatureLabelEntityView(this); 
            CuDistManFeatureLabelCollectionView.InitializeControls(); 
            CuDistManFeatureLabelEntityView.InitializeControls(); 
           
        }
      
            public CuDistManFeatureLabelCollectionView CuDistManFeatureLabelCollectionView {get; set; } 
            public CuDistManFeatureLabelEntityView CuDistManFeatureLabelEntityView {get; set; } 
    }
            
    public partial class CuDistManFeatureLabelCollectionView : View
    {
        public CuDistManFeatureLabelCollectionView(CuDistMaintenanceFeatureLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistManFeatureLabelCollectionView,CuDistManFeatureLabelEntityView>( this,Screen.CuDistManFeatureLabelEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3f518578-3338-4bd6-b6ba-51bdcf8ce23a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CuDistManFeatureLabelCollectionView,CuDistManFeatureLabelEntityView>( params_MainConsult,this,Screen.CuDistManFeatureLabelEntityView);
 

        }
        public IRPSButton<CuDistManFeatureLabelCollectionView,CuDistManFeatureLabelEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CuDistManFeatureLabelCollectionView,CuDistManFeatureLabelEntityView> MainConsult { get; set; } 
        public CuDistMaintenanceFeatureLabel Screen { get; set; }
        public CuDistManFeatureLabelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistManFeatureLabelEntityView : View
    {
        public CuDistManFeatureLabelEntityView(CuDistMaintenanceFeatureLabel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistManFeatureLabelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistManFeatureLabelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistManFeatureLabelEntityView,CuDistManFeatureLabelCollectionView>( this,Screen.CuDistManFeatureLabelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistManFeatureLabelEntityView,CuDistManFeatureLabelCollectionView>( this,Screen.CuDistManFeatureLabelCollectionView);
 
            CodFeatureLabel = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("3dac4564-6d62-4ca7-b059-158bf3d1a877","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("320dc2e9-07c2-46b4-9ca8-da8bc8e003c0","","",false, this);
 
            IDManFeatureVariableTable = RPSControlFactory.CreateRPSComboBox<CuDistManFeatureLabelEntityView>("134fd525-93b7-4963-9d89-fc3860870ab4","","",false, this);
 
            DataType = RPSControlFactory.CreateRPSEnumComboBox<CuDistManFeatureLabelEntityView>("cabb12f6-1335-4bc3-81d5-3ab1f35efff2","","",true, this);
 
            DateMin = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("d05d63a2-a7b4-4b06-8ffa-c890dce40004","","",false, this);
 
            DateMax = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("6e6edf96-cc4c-4d79-9523-e77df503017d","","",false, this);
 
            DateDefaultValue = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("f733bfd4-5efd-4214-bce4-dad42e2471f4","","",false, this);
 
            DeciMin = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("d6860adc-1471-4a5b-b597-abd2a6b00f3e","","",false, this);
 
            DeciMax = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("18bf37a2-3875-4dc0-a064-8eefb805ce06","","",false, this);
 
            DeciDefaultValue = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("e59ecd73-7f2a-40b0-8691-2bbe59d088ec","","",false, this);
 
            IntMin = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("d43fb55f-8e06-4c2e-9f14-1305bec20691","","",false, this);
 
            IntMax = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("49ccf3a1-5f54-4391-98fc-0e732918d955","","",false, this);
 
            IntDefaultValue = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureLabelEntityView>("c7170a5e-76b0-433f-bbbd-f070829d4900","","",false, this);
 
            StringMin = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("5060d751-c724-4367-8b61-d7c975fb2571","","",false, this);
 
            StringMax = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("93175e19-b7c6-4f3f-a3d9-4d410730b14b","","",false, this);
 
            StringDefaultValue = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureLabelEntityView>("419c66a1-bfa3-4d06-b63d-43fa1e71c188","","",false, this);
 

        }
        public IRPSSaveButton<CuDistManFeatureLabelEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistManFeatureLabelEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureLabelEntityView,CuDistManFeatureLabelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureLabelEntityView,CuDistManFeatureLabelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> CodFeatureLabel { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> Description { get; set; } 
        public IRPSComboBox<CuDistManFeatureLabelEntityView> IDManFeatureVariableTable { get; set; } 
        public IRPSComboBox<CuDistManFeatureLabelEntityView> DataType { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DateMin { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DateMax { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DateDefaultValue { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DeciMin { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DeciMax { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> DeciDefaultValue { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> IntMin { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> IntMax { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> IntDefaultValue { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> StringMin { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> StringMax { get; set; } 
        public IRPSTextBox<CuDistManFeatureLabelEntityView> StringDefaultValue { get; set; } 
        public CuDistMaintenanceFeatureLabel Screen { get; set; }
        public CuDistManFeatureLabelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}