    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Dimension
{
    //RPS VERSION 1.0.0.0
    public partial class Dimension:Screen
    {
        public Dimension():base()
        {
            this.URL = "generalledger.dimension";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DimensionCollectionView  = new DimensionCollectionView(this); 
            DimensionEntityView  = new DimensionEntityView(this); 
            DetailChildView  = new DetailChildView(this); 
            DimValueView  = new DimValueView(this); 
            DimensionCollectionView.InitializeControls(); 
            DimensionEntityView.InitializeControls(); 
            DetailChildView.InitializeControls(); 
            DimValueView.InitializeControls(); 
           
        }
      
            public DimensionCollectionView DimensionCollectionView {get; set; } 
            public DimensionEntityView DimensionEntityView {get; set; } 
            public DetailChildView DetailChildView {get; set; } 
            public DimValueView DimValueView {get; set; } 
    }
            
    public partial class DimensionCollectionView : View
    {
        public DimensionCollectionView(Dimension screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DimensionCollectionView,DimensionEntityView>( this,Screen.DimensionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "173715e8-c63a-4c07-a5ef-71d569e64f20",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DimensionCollectionView,DimensionEntityView>( params_MainConsult,this,Screen.DimensionEntityView);
 

        }
        public IRPSButton<DimensionCollectionView,DimensionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DimensionCollectionView,DimensionEntityView> MainConsult { get; set; } 
        public Dimension Screen { get; set; }
        public DimensionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DimensionEntityView : View
    {
        public DimensionEntityView(Dimension screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DimensionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DimensionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DimensionEntityView,DimensionCollectionView>( this,Screen.DimensionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DimensionEntityView,DimensionCollectionView>( this,Screen.DimensionCollectionView);
 
            NewCommandButton = RPSControlFactory.CreateRPSButton<DimensionEntityView>( "9fd8a7c4-37a0-424e-9242-c363d1b6c2e3","","",this);
 

        }
        public IRPSSaveButton<DimensionEntityView> SaveButton { get; set; } 
        public IRPSButton<DimensionEntityView> DeleteButton { get; set; } 
        public IRPSButton<DimensionEntityView,DimensionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DimensionEntityView,DimensionCollectionView> BackButton { get; set; } 
        public IRPSButton<DimensionEntityView> NewCommandButton { get; set; } 
        public Dimension Screen { get; set; }
        public DimensionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DetailChildView : View
    {
        public DetailChildView(Dimension screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodDimension = RPSControlFactory.CreateRPSTextBox<DetailChildView>("3f0dc8a2-e78b-4ff4-ad82-01dfe3a6c650","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<DetailChildView>("f14dbe58-0532-45da-a3cb-b411ed4093a0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DetailChildView>("0c429270-88a3-4bf8-8699-983a760f94a6","","",false, this);
 

        }
        public IRPSTextBox<DetailChildView> CodDimension { get; set; } 
        public IRPSCheckbox<DetailChildView> Blocked { get; set; } 
        public IRPSTextBox<DetailChildView> Description { get; set; } 
        public Dimension Screen { get; set; }
        public DetailChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DimValueView : View
    {
        public DimValueView(Dimension screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DimValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DimValueView,DimensionEntityView>( this,Screen.DimensionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DimValueView,DimensionEntityView>( this,Screen.DimensionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DimValueView,DimensionEntityView>( this,Screen.DimensionEntityView);
 
            CodDimValue = RPSControlFactory.CreateRPSTextBox<DimValueView>("9b78a99e-dc02-4a93-a124-b4783f90481e","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<DimValueView>("c7104a55-ac24-41d9-a23b-f805e7d1f57d","","",true, this);
 
            PercentageOwn = RPSControlFactory.CreateRPSFormattedTextBox<DimValueView>("72b80e11-665e-45cb-9fe5-de8242599a30","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DimValueView>("199c2676-802f-47f0-8c92-c84e9f9cf136","","",false, this);
 

        }
        public IRPSButton<DimValueView> DeleteButton { get; set; } 
        public IRPSButton<DimValueView,DimensionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DimValueView,DimensionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DimValueView,DimensionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<DimValueView> CodDimValue { get; set; } 
        public IRPSCheckbox<DimValueView> Blocked { get; set; } 
        public IRPSTextBox<DimValueView> PercentageOwn { get; set; } 
        public IRPSTextBox<DimValueView> Description { get; set; } 
        public Dimension Screen { get; set; }
        public DimValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}