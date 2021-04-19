    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CompareStructures
{
    //RPS VERSION 1.0.0.0
    public partial class CompareStructures:Screen
    {
        public CompareStructures():base()
        {
            this.URL = "manufacturing.comparestructures";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CompareStructuresView  = new CompareStructuresView(this); 
            CompareStructuresView.InitializeControls(); 
           
        }
      
            public CompareStructuresView CompareStructuresView {get; set; } 
    }
            
    public partial class CompareStructuresView : View
    {
        public CompareStructuresView(CompareStructures screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SiteLeft = RPSControlFactory.CreateRPSComboBox<CompareStructuresView>("b36b44fe-daa3-4998-85c9-d816cab8ce37","","",true, this);
 
            ArticleLeft = RPSControlFactory.CreateRPSComboBox<CompareStructuresView>("322746e8-67e6-441c-a46d-b1bfe0648994","","",true, this);
 
            VersionLeft = RPSControlFactory.CreateRPSEnumComboBox<CompareStructuresView>("418e722f-45b0-4a02-8c5c-c0bbe64551b4","","",true, this);
 
            SiteRight = RPSControlFactory.CreateRPSComboBox<CompareStructuresView>("cf270d53-6794-47ef-82cd-b25175060d81","","",true, this);
 
            ArticleRight = RPSControlFactory.CreateRPSComboBox<CompareStructuresView>("01eb04d3-d852-462e-932a-d95222214d6d","","",true, this);
 
            VersionRight = RPSControlFactory.CreateRPSEnumComboBox<CompareStructuresView>("cd991b61-1c55-44c4-aa10-b829455bbe18","","",true, this);
 
            ExecuteCompareStructuresPrecalc = RPSControlFactory.CreateRPSButton<CompareStructuresView>( "dd090b42-aaf8-4a55-b142-ab62fb97135e","","",this);
 
            CollectionInit params_GetDifferencesBetweenStructures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ecc8c0d7-f784-4adc-88db-fd8cbe3b601b",CSSSelectorGrid="",XPathGrid=""};
            GetDifferencesBetweenStructures = RPSControlFactory.RPSCreateCollectionWithGrid<GetDifferencesBetweenStructuresCollectionEditor<CompareStructuresView>,CompareStructuresView>( params_GetDifferencesBetweenStructures,this);
 
            CollectionInit params_GetDifferencesBetweenStructures1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bedcb409-f6de-4217-b598-9f3b6bbe893f",CSSSelectorGrid="",XPathGrid=""};
            GetDifferencesBetweenStructures1 = RPSControlFactory.RPSCreateCollectionWithGrid<GetDifferencesBetweenStructuresCollectionEditor<CompareStructuresView>,CompareStructuresView>( params_GetDifferencesBetweenStructures1,this);
 

        }
        public IRPSComboBox<CompareStructuresView> SiteLeft { get; set; } 
        public IRPSComboBox<CompareStructuresView> ArticleLeft { get; set; } 
        public IRPSComboBox<CompareStructuresView> VersionLeft { get; set; } 
        public IRPSComboBox<CompareStructuresView> SiteRight { get; set; } 
        public IRPSComboBox<CompareStructuresView> ArticleRight { get; set; } 
        public IRPSComboBox<CompareStructuresView> VersionRight { get; set; } 
        public IRPSButton<CompareStructuresView> ExecuteCompareStructuresPrecalc { get; set; } 
        public GetDifferencesBetweenStructuresCollectionEditor<CompareStructuresView> GetDifferencesBetweenStructures { get; set; } 
        public GetDifferencesBetweenStructuresCollectionEditor<CompareStructuresView> GetDifferencesBetweenStructures1 { get; set; } 
        public CompareStructures Screen { get; set; }
        public CompareStructuresView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDifferencesBetweenStructuresCollectionEditor<CompareStructuresView>:RPSCollectionEditor<CompareStructuresView> where CompareStructuresView : class, IView
    {
        public  GetDifferencesBetweenStructuresGridView<CompareStructuresView> GridView {get;set;}
    }
    public partial class GetDifferencesBetweenStructuresGridView <CompareStructuresView> :  RPSGridView<CompareStructuresView> where CompareStructuresView : class, IView
    {
        public GetDifferencesBetweenStructuresGridView(CompareStructuresView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Property = RPSControlFactory.CreateRPSGridTextBox<CompareStructuresView>("","#ecc8c0d7-f784-4adc-88db-fd8cbe3b601b .ag-row[role='row']@ROWINDEX [col-id='cProperty']","",false, this.CurrentView);
 
            ValueLeft = RPSControlFactory.CreateRPSGridTextBox<CompareStructuresView>("","#ecc8c0d7-f784-4adc-88db-fd8cbe3b601b .ag-row[role='row']@ROWINDEX [col-id='cValueLeft']","",false, this.CurrentView);
 
            ValueRight = RPSControlFactory.CreateRPSGridTextBox<CompareStructuresView>("","#ecc8c0d7-f784-4adc-88db-fd8cbe3b601b .ag-row[role='row']@ROWINDEX [col-id='cValueRight']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CompareStructuresView> Property { get; set; } 
        public IRPSGridTextBox<CompareStructuresView> ValueLeft { get; set; } 
        public IRPSGridTextBox<CompareStructuresView> ValueRight { get; set; } 
                     
    }
 
    }
  
    

}