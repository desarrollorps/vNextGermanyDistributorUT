    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BasoaDataModel
{
    //RPS VERSION 1.0.0.0
    public partial class BasoaDataModel:Screen
    {
        public BasoaDataModel():base()
        {
            this.URL = "general.basoadatamodel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BasoaDataModelQueryView  = new BasoaDataModelQueryView(this); 
            TreeFilterChildDialogView  = new TreeFilterChildDialogView(this); 
            BlankPageView  = new BlankPageView(this); 
            BasoaDataModelEntityView  = new BasoaDataModelEntityView(this); 
            BasoaDataModelQueryView.InitializeControls(); 
            TreeFilterChildDialogView.InitializeControls(); 
            BlankPageView.InitializeControls(); 
            BasoaDataModelEntityView.InitializeControls(); 
           
        }
      
            public BasoaDataModelQueryView BasoaDataModelQueryView {get; set; } 
            public TreeFilterChildDialogView TreeFilterChildDialogView {get; set; } 
            public BlankPageView BlankPageView {get; set; } 
            public BasoaDataModelEntityView BasoaDataModelEntityView {get; set; } 
    }
            
    public partial class BasoaDataModelQueryView : View
    {
        public BasoaDataModelQueryView(BasoaDataModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SearchProperty = RPSControlFactory.CreateRPSTextBox<BasoaDataModelQueryView>("4bc6f251-d87f-484c-9fc5-43140176289f","","",false, this);
 
            TreeFilterChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BasoaDataModelQueryView,TreeFilterChildDialogView>("e937bc50-3d31-4bfb-87ae-51c9e8657197","","", this,Screen.TreeFilterChildDialogView);
 
            TreeFilterChildNavigationCommandButton1 = RPSControlFactory.CreateRPSButtonToView<BasoaDataModelQueryView,TreeFilterChildDialogView>("2b009de9-ce8e-4f1d-9b2b-13a200365dd3","","", this,Screen.TreeFilterChildDialogView);
 

        }
        public IRPSTextBox<BasoaDataModelQueryView> SearchProperty { get; set; } 
        public IRPSButton<BasoaDataModelQueryView,TreeFilterChildDialogView> TreeFilterChildNavigationCommandButton { get; set; } 
        public IRPSButton<BasoaDataModelQueryView,TreeFilterChildDialogView> TreeFilterChildNavigationCommandButton1 { get; set; } 
        public BasoaDataModel Screen { get; set; }
        public BasoaDataModelQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TreeFilterChildDialogView : View
    {
        public TreeFilterChildDialogView(BasoaDataModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SearchProperty = RPSControlFactory.CreateRPSTextBox<TreeFilterChildDialogView>("ba4f6554-c14f-498d-9841-14d09a206dff","","",false, this);
 

        }
        public IRPSTextBox<TreeFilterChildDialogView> SearchProperty { get; set; } 
        public BasoaDataModel Screen { get; set; }
        public TreeFilterChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BlankPageView : View
    {
        public BlankPageView(BasoaDataModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public BasoaDataModel Screen { get; set; }
        public BlankPageView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BasoaDataModelEntityView : View
    {
        public BasoaDataModelEntityView(BasoaDataModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IsPrimaryKey = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("121cd033-ea86-4cdd-b1d0-3639a66942b4","","",false, this);
 
            UniqueIndexName = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("73627178-45a5-4e33-b9b5-6fe40b73fffe","","",false, this);
 
            Name = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("fc1ea381-09a6-4146-8b49-2acb46fceab2","","",false, this);
 
            LocalizedDescription = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("5485a7be-e45d-46fb-bd8b-09a4ee9ba979","","",false, this);
 
            LocalizedSummaryDescription = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("969eb843-60ca-4d29-b051-677c8d78bdf9","","",false, this);
 
            IsCustom = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("768a9abe-8fda-4a29-a422-b7040f6a38dc","","",false, this);
 
            MappedColumn = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("c782f5d1-241a-47b9-87aa-5a9c2ec6b27b","","",false, this);
 
            TypeAsStr = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("5d09efad-be86-4b2a-a8a0-618371121b05","","",false, this);
 
            CustomizationName = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("d5bc1d1c-e63d-4539-8362-4c4e310a1b34","","",false, this);
 
            IsEnum = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("ed8aedf2-2e8d-433c-981f-206336c04f29","","",false, this);
 
            EnumDescription = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("f85a8d48-dea9-4e35-b43f-78e0228b765c","","",false, this);
 
            EnumValuesStr = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("940e7851-8ae0-4dc4-b983-9c546831c71f","","",false, this);
 
            ForeignKeyParentRef = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("731e5e82-be6a-4406-95ad-ad84d2302faa","","",false, this);
 
            ForeignKey = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("dff41c17-7bf6-4763-8469-b6674f348d4a","","",false, this);
 
            IsRequired = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("251989ea-1f1b-43b3-817a-c64c850cde1b","","",false, this);
 
            WritableIfNew = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("f7ba7dfb-9d53-4ba8-b40b-a59e09581d2c","","",false, this);
 
            WritableFromBL = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("06d9e2f0-59a7-440d-ad4a-90d83d6da7c6","","",false, this);
 
            DefaultValue = RPSControlFactory.CreateRPSTextBox<BasoaDataModelEntityView>("b1377e23-fa1f-4403-b8f1-331c72103a5e","","",false, this);
 
            LowerLimit = RPSControlFactory.CreateRPSFormattedTextBox<BasoaDataModelEntityView>("aff15d38-4148-40c5-a68a-b0c64a223e7a","","",false, this);
 
            IncludeLowerLimit = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("14895c29-4ee1-4009-85b8-f71b150fe93b","","",false, this);
 
            UpperLimit = RPSControlFactory.CreateRPSFormattedTextBox<BasoaDataModelEntityView>("5bed2ea2-60ed-4d10-b20f-564f8f7a8019","","",false, this);
 
            IncludeUpperLimit = RPSControlFactory.CreateRPSCheckBox<BasoaDataModelEntityView>("bcaaa23e-84e8-4a3c-a3da-c80c951e214c","","",false, this);
 
            CollectionInit params_GetBasoaEntityProperties = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f19c57a8-e734-409a-8e1b-c1ed969c0e2c",CSSSelectorGrid="",XPathGrid=""};
            GetBasoaEntityProperties = RPSControlFactory.RPSCreateCollectionWithGrid<GetBasoaEntityPropertiesCollectionEditor<BasoaDataModelEntityView>,BasoaDataModelEntityView>( params_GetBasoaEntityProperties,this);
 
            PropertiesSection = RPSControlFactory.CreateRPSSection<BasoaDataModelEntityView>( "","ul li[rpsid='06ee92c9-bdce-4b1e-b63a-0b2062656aaf']","",this);
 
            MapSection = RPSControlFactory.CreateRPSSection<BasoaDataModelEntityView>( "","ul li[rpsid='65bee15f-566c-4db7-a3be-e4e051cdbcd1']","",this);
 

        }
        public IRPSCheckbox<BasoaDataModelEntityView> IsPrimaryKey { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> UniqueIndexName { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> Name { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> LocalizedDescription { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> LocalizedSummaryDescription { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> IsCustom { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> MappedColumn { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> TypeAsStr { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> CustomizationName { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> IsEnum { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> EnumDescription { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> EnumValuesStr { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> ForeignKeyParentRef { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> ForeignKey { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> IsRequired { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> WritableIfNew { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> WritableFromBL { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> DefaultValue { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> LowerLimit { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> IncludeLowerLimit { get; set; } 
        public IRPSTextBox<BasoaDataModelEntityView> UpperLimit { get; set; } 
        public IRPSCheckbox<BasoaDataModelEntityView> IncludeUpperLimit { get; set; } 
        public GetBasoaEntityPropertiesCollectionEditor<BasoaDataModelEntityView> GetBasoaEntityProperties { get; set; } 
        public IRPSSection<BasoaDataModelEntityView> PropertiesSection { get; set; } 
        public IRPSSection<BasoaDataModelEntityView> MapSection { get; set; } 
        public BasoaDataModel Screen { get; set; }
        public BasoaDataModelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetBasoaEntityPropertiesCollectionEditor<BasoaDataModelEntityView>:RPSCollectionEditor<BasoaDataModelEntityView> where BasoaDataModelEntityView : class, IView
    {
        public  GetBasoaEntityPropertiesGridView<BasoaDataModelEntityView> GridView {get;set;}
    }
    public partial class GetBasoaEntityPropertiesGridView <BasoaDataModelEntityView> :  RPSGridView<BasoaDataModelEntityView> where BasoaDataModelEntityView : class, IView
    {
        public GetBasoaEntityPropertiesGridView(BasoaDataModelEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IsPrimaryKey = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIsPrimaryKey']","",false, this.CurrentView);
 
            UniqueIndexName = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cUniqueIndexName']","",false, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 
            LocalizedDescription = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cLocalizedDescription']","",false, this.CurrentView);
 
            LocalizedSummaryDescription = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cLocalizedSummaryDescription']","",false, this.CurrentView);
 
            MappedColumn = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cMappedColumn']","",false, this.CurrentView);
 
            TypeAsStr = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cTypeAsStr']","",false, this.CurrentView);
 
            CustomizationName = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cCustomizationName']","",false, this.CurrentView);
 
            IsEnum = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIsEnum']","",false, this.CurrentView);
 
            EnumDescription = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cEnumDescription']","",false, this.CurrentView);
 
            IsParentReference = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIsParentReference']","",false, this.CurrentView);
 
            ForeignKey = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cForeignKey']","",false, this.CurrentView);
 
            IsRequired = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIsRequired']","",false, this.CurrentView);
 
            WritableIfNew = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cWritableIfNew']","",false, this.CurrentView);
 
            WritableFromBL = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cWritableFromBL']","",false, this.CurrentView);
 
            DefaultValue = RPSControlFactory.CreateRPSGridTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cDefaultValue']","",false, this.CurrentView);
 
            LowerLimit = RPSControlFactory.CreateRPSGridFormattedTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cLowerLimit']","",false, this.CurrentView);
 
            IncludeLowerLimit = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIncludeLowerLimit']","",false, this.CurrentView);
 
            UpperLimit = RPSControlFactory.CreateRPSGridFormattedTextBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cUpperLimit']","",false, this.CurrentView);
 
            IncludeUpperLimit = RPSControlFactory.CreateRPSGridCheckBox<BasoaDataModelEntityView>("","#f19c57a8-e734-409a-8e1b-c1ed969c0e2c .ag-row[role='row']@ROWINDEX [col-id='cIncludeUpperLimit']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<BasoaDataModelEntityView> IsPrimaryKey { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> UniqueIndexName { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> Name { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> LocalizedDescription { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> LocalizedSummaryDescription { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> MappedColumn { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> TypeAsStr { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> CustomizationName { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> IsEnum { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> EnumDescription { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> IsParentReference { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> ForeignKey { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> IsRequired { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> WritableIfNew { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> WritableFromBL { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> DefaultValue { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> LowerLimit { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> IncludeLowerLimit { get; set; } 
        public IRPSGridTextBox<BasoaDataModelEntityView> UpperLimit { get; set; } 
        public IRPSGridCheckbox<BasoaDataModelEntityView> IncludeUpperLimit { get; set; } 
                     
    }
 
    }
  
    

}