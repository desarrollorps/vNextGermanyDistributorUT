    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.MeasureUnit
{
    //RPS VERSION 1.0.0.0
    public partial class MeasureUnit:Screen
    {
        public MeasureUnit():base()
        {
            this.URL = "general.measureunit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MeasureUnitCollectionView  = new MeasureUnitCollectionView(this); 
            MeasureUnitEntityView  = new MeasureUnitEntityView(this); 
            ConvertMeasureUnitView  = new ConvertMeasureUnitView(this); 
            MeasureUnitByLangView  = new MeasureUnitByLangView(this); 
            MeasureUnitCollectionView.InitializeControls(); 
            MeasureUnitEntityView.InitializeControls(); 
            ConvertMeasureUnitView.InitializeControls(); 
            MeasureUnitByLangView.InitializeControls(); 
           
        }
      
            public MeasureUnitCollectionView MeasureUnitCollectionView {get; set; } 
            public MeasureUnitEntityView MeasureUnitEntityView {get; set; } 
            public ConvertMeasureUnitView ConvertMeasureUnitView {get; set; } 
            public MeasureUnitByLangView MeasureUnitByLangView {get; set; } 
    }
            
    public partial class MeasureUnitCollectionView : View
    {
        public MeasureUnitCollectionView(MeasureUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MeasureUnitCollectionView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "93a8f074-a2fa-4f54-bddb-c45574f1d67f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MeasureUnitCollectionView,MeasureUnitEntityView>( params_MainConsult,this,Screen.MeasureUnitEntityView);
 

        }
        public IRPSButton<MeasureUnitCollectionView,MeasureUnitEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MeasureUnitCollectionView,MeasureUnitEntityView> MainConsult { get; set; } 
        public MeasureUnit Screen { get; set; }
        public MeasureUnitCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MeasureUnitEntityView : View
    {
        public MeasureUnitEntityView(MeasureUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MeasureUnitEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MeasureUnitEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MeasureUnitEntityView,MeasureUnitCollectionView>( this,Screen.MeasureUnitCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MeasureUnitEntityView,MeasureUnitCollectionView>( this,Screen.MeasureUnitCollectionView);
 
            CodMeasureUnit = RPSControlFactory.CreateRPSTextBox<MeasureUnitEntityView>("1d80f888-eb2c-4b72-8670-b01e6decf766","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MeasureUnitEntityView>("bab40051-6df7-4ebe-a2b3-ca91b08363b0","","",false, this);
 
            Abreviature = RPSControlFactory.CreateRPSTextBox<MeasureUnitEntityView>("9448eca3-cfb2-4e4e-80c2-b4a941b9857b","","",false, this);
 
            RoundType = RPSControlFactory.CreateRPSEnumComboBox<MeasureUnitEntityView>("38525eb1-bd3d-47f4-ade3-af3afc87fe22","","",true, this);
 
            DecimalNumber = RPSControlFactory.CreateRPSFormattedTextBox<MeasureUnitEntityView>("d9beb0b0-4903-459d-9c90-ba5ae619a7fc","","",true, this);
 
            CollectionInit params_ConvertMeasureUnits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="29bac833-4cfb-4aec-8af6-2beb4b2bff3e",CSSSelectorGrid="",XPathGrid=""};
            ConvertMeasureUnits = RPSControlFactory.RPSCreateCollectionWithGrid<ConvertMeasureUnitsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView>,MeasureUnitEntityView,ConvertMeasureUnitView>( params_ConvertMeasureUnits,this,Screen.ConvertMeasureUnitView);
 
            CollectionInit params_MeasureUnitByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dda78626-df93-4cc1-afd2-51b92d19182f",CSSSelectorGrid="",XPathGrid=""};
            MeasureUnitByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<MeasureUnitByLangsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView>,MeasureUnitEntityView,ConvertMeasureUnitView>( params_MeasureUnitByLangs,this,Screen.ConvertMeasureUnitView);
 
            Section = RPSControlFactory.CreateRPSSection<MeasureUnitEntityView>( "","ul li[rpsid='dd5f8737-b513-4044-8777-7ccea6145c6a']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<MeasureUnitEntityView>( "","ul li[rpsid='98a64bf4-5950-44cd-94af-92d2ab5dd588']","",this);
 

        }
        public IRPSSaveButton<MeasureUnitEntityView> SaveButton { get; set; } 
        public IRPSButton<MeasureUnitEntityView> DeleteButton { get; set; } 
        public IRPSButton<MeasureUnitEntityView,MeasureUnitCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MeasureUnitEntityView,MeasureUnitCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MeasureUnitEntityView> CodMeasureUnit { get; set; } 
        public IRPSTextBox<MeasureUnitEntityView> Description { get; set; } 
        public IRPSTextBox<MeasureUnitEntityView> Abreviature { get; set; } 
        public IRPSComboBox<MeasureUnitEntityView> RoundType { get; set; } 
        public IRPSTextBox<MeasureUnitEntityView> DecimalNumber { get; set; } 
        public ConvertMeasureUnitsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView> ConvertMeasureUnits { get; set; } 
        public MeasureUnitByLangsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView> MeasureUnitByLangs { get; set; } 
        public IRPSSection<MeasureUnitEntityView> Section { get; set; } 
        public IRPSSection<MeasureUnitEntityView> Section1 { get; set; } 
        public MeasureUnit Screen { get; set; }
        public MeasureUnitEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ConvertMeasureUnitsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView>:RPSCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView> where MeasureUnitEntityView : class, IView where ConvertMeasureUnitView : class, IView
    {
        public  ConvertMeasureUnitsGridView<MeasureUnitEntityView,ConvertMeasureUnitView> GridView {get;set;}
    }
    public partial class ConvertMeasureUnitsGridView <MeasureUnitEntityView,ConvertMeasureUnitView> :  RPSGridView<MeasureUnitEntityView,ConvertMeasureUnitView> where MeasureUnitEntityView : class, IView where ConvertMeasureUnitView : class, IView
    {
        public ConvertMeasureUnitsGridView(MeasureUnitEntityView currentView,ConvertMeasureUnitView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IsSecondUnitType = RPSControlFactory.CreateRPSGridCheckBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cIsSecondUnitType']","",false, this.CurrentView);
 
            IDUnitDestination = RPSControlFactory.CreateRPSGridComboBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cIDUnitDestination']","",true, this.CurrentView);
 
            MultiplyOperator = RPSControlFactory.CreateRPSGridEnumComboBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cMultiplyOperator']","",true, this.CurrentView);
 
            MultiplyFactor = RPSControlFactory.CreateRPSGridFormattedTextBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cMultiplyFactor']","",true, this.CurrentView);
 
            SumOperator = RPSControlFactory.CreateRPSGridEnumComboBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cSumOperator']","",true, this.CurrentView);
 
            SumFactor = RPSControlFactory.CreateRPSGridTextBox<MeasureUnitEntityView>("","#29bac833-4cfb-4aec-8af6-2beb4b2bff3e .ag-row[role='row']@ROWINDEX [col-id='cSumFactor']","",true, this.CurrentView);
 

        }
        public IRPSGridCheckbox<MeasureUnitEntityView> IsSecondUnitType { get; set; } 
        public IRPSGridComboBox<MeasureUnitEntityView> IDUnitDestination { get; set; } 
        public IRPSGridComboBox<MeasureUnitEntityView> MultiplyOperator { get; set; } 
        public IRPSGridTextBox<MeasureUnitEntityView> MultiplyFactor { get; set; } 
        public IRPSGridComboBox<MeasureUnitEntityView> SumOperator { get; set; } 
        public IRPSGridTextBox<MeasureUnitEntityView> SumFactor { get; set; } 
                     
    }
 
        public partial class MeasureUnitByLangsCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView>:RPSCollectionEditor<MeasureUnitEntityView,ConvertMeasureUnitView> where MeasureUnitEntityView : class, IView where ConvertMeasureUnitView : class, IView
    {
        public  MeasureUnitByLangsGridView<MeasureUnitEntityView,ConvertMeasureUnitView> GridView {get;set;}
    }
    public partial class MeasureUnitByLangsGridView <MeasureUnitEntityView,ConvertMeasureUnitView> :  RPSGridView<MeasureUnitEntityView,ConvertMeasureUnitView> where MeasureUnitEntityView : class, IView where ConvertMeasureUnitView : class, IView
    {
        public MeasureUnitByLangsGridView(MeasureUnitEntityView currentView,ConvertMeasureUnitView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<MeasureUnitEntityView>("","#dda78626-df93-4cc1-afd2-51b92d19182f .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MeasureUnitEntityView>("","#dda78626-df93-4cc1-afd2-51b92d19182f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MeasureUnitEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<MeasureUnitEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ConvertMeasureUnitView : View
    {
        public ConvertMeasureUnitView(MeasureUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ConvertMeasureUnitView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ConvertMeasureUnitView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ConvertMeasureUnitView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ConvertMeasureUnitView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            IsSecondUnitType = RPSControlFactory.CreateRPSCheckBox<ConvertMeasureUnitView>("e8cf05ee-4af2-4c4d-a049-3e17c86e4d9c","","",false, this);
 
            IDUnitDestination = RPSControlFactory.CreateRPSComboBox<ConvertMeasureUnitView>("68e305a8-0d6b-4417-bfd4-660e63fa2994","","",true, this);
 
            MultiplyOperator = RPSControlFactory.CreateRPSEnumComboBox<ConvertMeasureUnitView>("d13c35fa-1635-41b3-943f-f3a74076aae2","","",true, this);
 
            MultiplyFactor = RPSControlFactory.CreateRPSFormattedTextBox<ConvertMeasureUnitView>("696a577a-d635-4bd4-bb99-1bcdc646fa1e","","",true, this);
 
            SumOperator = RPSControlFactory.CreateRPSEnumComboBox<ConvertMeasureUnitView>("f34e0e63-60aa-4ba8-a495-60e74f575678","","",true, this);
 
            SumFactor = RPSControlFactory.CreateRPSTextBox<ConvertMeasureUnitView>("548ab5af-8ac3-465d-a4e2-c294d3b3d365","","",true, this);
 

        }
        public IRPSButton<ConvertMeasureUnitView> DeleteButton { get; set; } 
        public IRPSButton<ConvertMeasureUnitView,MeasureUnitEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ConvertMeasureUnitView,MeasureUnitEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ConvertMeasureUnitView,MeasureUnitEntityView> AcceptButton { get; set; } 
        public IRPSCheckbox<ConvertMeasureUnitView> IsSecondUnitType { get; set; } 
        public IRPSComboBox<ConvertMeasureUnitView> IDUnitDestination { get; set; } 
        public IRPSComboBox<ConvertMeasureUnitView> MultiplyOperator { get; set; } 
        public IRPSTextBox<ConvertMeasureUnitView> MultiplyFactor { get; set; } 
        public IRPSComboBox<ConvertMeasureUnitView> SumOperator { get; set; } 
        public IRPSTextBox<ConvertMeasureUnitView> SumFactor { get; set; } 
        public MeasureUnit Screen { get; set; }
        public ConvertMeasureUnitView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MeasureUnitByLangView : View
    {
        public MeasureUnitByLangView(MeasureUnit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MeasureUnitByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MeasureUnitByLangView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MeasureUnitByLangView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MeasureUnitByLangView,MeasureUnitEntityView>( this,Screen.MeasureUnitEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<MeasureUnitByLangView>("b63c825a-e849-4201-b454-f73824d48b38","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MeasureUnitByLangView>("1c244379-fc39-4173-9a23-9efbe494dcf8","","",false, this);
 

        }
        public IRPSButton<MeasureUnitByLangView> DeleteButton { get; set; } 
        public IRPSButton<MeasureUnitByLangView,MeasureUnitEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MeasureUnitByLangView,MeasureUnitEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MeasureUnitByLangView,MeasureUnitEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MeasureUnitByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<MeasureUnitByLangView> Description { get; set; } 
        public MeasureUnit Screen { get; set; }
        public MeasureUnitByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}