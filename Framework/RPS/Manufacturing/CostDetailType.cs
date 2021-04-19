    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CostDetailType
{
    //RPS VERSION 1.0.0.0
    public partial class CostDetailType:Screen
    {
        public CostDetailType():base()
        {
            this.URL = "manufacturing.costdetailtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostDetailTypeCollectionView  = new CostDetailTypeCollectionView(this); 
            CostDetailTypeEntityView  = new CostDetailTypeEntityView(this); 
            CostDetailTypeResourceView  = new CostDetailTypeResourceView(this); 
            GetYearAmountChildDialogView  = new GetYearAmountChildDialogView(this); 
            CostDetailTypeAccountView  = new CostDetailTypeAccountView(this); 
            CostDetailTypeYearView  = new CostDetailTypeYearView(this); 
            CostDetailTypeCollectionView.InitializeControls(); 
            CostDetailTypeEntityView.InitializeControls(); 
            CostDetailTypeResourceView.InitializeControls(); 
            GetYearAmountChildDialogView.InitializeControls(); 
            CostDetailTypeAccountView.InitializeControls(); 
            CostDetailTypeYearView.InitializeControls(); 
           
        }
      
            public CostDetailTypeCollectionView CostDetailTypeCollectionView {get; set; } 
            public CostDetailTypeEntityView CostDetailTypeEntityView {get; set; } 
            public CostDetailTypeResourceView CostDetailTypeResourceView {get; set; } 
            public GetYearAmountChildDialogView GetYearAmountChildDialogView {get; set; } 
            public CostDetailTypeAccountView CostDetailTypeAccountView {get; set; } 
            public CostDetailTypeYearView CostDetailTypeYearView {get; set; } 
    }
            
    public partial class CostDetailTypeCollectionView : View
    {
        public CostDetailTypeCollectionView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostDetailTypeCollectionView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            GetYearAmountChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CostDetailTypeCollectionView,GetYearAmountChildDialogView>("f4c69cb6-7d29-47a9-be88-3f54e169d412","","", this,Screen.GetYearAmountChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4285ae9c-3c32-4374-9e4f-40400ad549a7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostDetailTypeCollectionView,CostDetailTypeEntityView>( params_MainConsult,this,Screen.CostDetailTypeEntityView);
 

        }
        public IRPSButton<CostDetailTypeCollectionView,CostDetailTypeEntityView> NewButton { get; set; } 
        public IRPSButton<CostDetailTypeCollectionView,GetYearAmountChildDialogView> GetYearAmountChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<CostDetailTypeCollectionView,CostDetailTypeEntityView> MainConsult { get; set; } 
        public CostDetailType Screen { get; set; }
        public CostDetailTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostDetailTypeEntityView : View
    {
        public CostDetailTypeEntityView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostDetailTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostDetailTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostDetailTypeEntityView,CostDetailTypeCollectionView>( this,Screen.CostDetailTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostDetailTypeEntityView,CostDetailTypeCollectionView>( this,Screen.CostDetailTypeCollectionView);
 
            CodCostDetailType = RPSControlFactory.CreateRPSTextBox<CostDetailTypeEntityView>("7125ed81-51ca-4261-a6b4-48c8279fc009","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostDetailTypeEntityView>("80979054-1b7a-4673-a4a1-a6a76935032b","","",false, this);
 
            IDCostGroup = RPSControlFactory.CreateRPSComboBox<CostDetailTypeEntityView>("da565a29-d4f3-49fb-b6d6-256ee768a688","","",false, this);
 
            IDBaseCost1 = RPSControlFactory.CreateRPSComboBox<CostDetailTypeEntityView>("5ad363e2-43ca-4afc-8765-5b547e552624","","",false, this);
 
            IDBaseCost2 = RPSControlFactory.CreateRPSComboBox<CostDetailTypeEntityView>("633b00fe-ed57-4ed9-ba12-14c61a187a39","","",false, this);
 
            CollectionInit params_CostDetailTypeAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bdeead42-31af-4972-941c-8c5208411b92",CSSSelectorGrid="",XPathGrid=""};
            CostDetailTypeAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<CostDetailTypeAccountsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>,CostDetailTypeEntityView,CostDetailTypeYearView>( params_CostDetailTypeAccounts,this,Screen.CostDetailTypeYearView);
 
            CollectionInit params_CostDetailTypeResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4a6e997f-4343-4543-aeb8-2ca488836eec",CSSSelectorGrid="",XPathGrid=""};
            CostDetailTypeResources = RPSControlFactory.RPSCreateCollectionWithGrid<CostDetailTypeResourcesCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>,CostDetailTypeEntityView,CostDetailTypeYearView>( params_CostDetailTypeResources,this,Screen.CostDetailTypeYearView);
 
            CollectionInit params_CostDetailTypeYears = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a00f0950-7c1c-4043-9557-4143fce8d199",CSSSelectorGrid="",XPathGrid=""};
            CostDetailTypeYears = RPSControlFactory.RPSCreateCollectionWithGrid<CostDetailTypeYearsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>,CostDetailTypeEntityView,CostDetailTypeYearView>( params_CostDetailTypeYears,this,Screen.CostDetailTypeYearView);
 
            SectionDetailAccounts = RPSControlFactory.CreateRPSSection<CostDetailTypeEntityView>( "","ul li[rpsid='3b60aada-954d-452f-a720-ee995ef67290']","",this);
 
            SectionTypeResources = RPSControlFactory.CreateRPSSection<CostDetailTypeEntityView>( "","ul li[rpsid='b8c0feed-5069-42aa-b81a-7f098b6ed3d4']","",this);
 
            SectionTypeYears = RPSControlFactory.CreateRPSSection<CostDetailTypeEntityView>( "","ul li[rpsid='688ec35e-c776-4949-9cdb-9c7a035a42a9']","",this);
 

        }
        public IRPSSaveButton<CostDetailTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<CostDetailTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeEntityView,CostDetailTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeEntityView,CostDetailTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostDetailTypeEntityView> CodCostDetailType { get; set; } 
        public IRPSTextBox<CostDetailTypeEntityView> Description { get; set; } 
        public IRPSComboBox<CostDetailTypeEntityView> IDCostGroup { get; set; } 
        public IRPSComboBox<CostDetailTypeEntityView> IDBaseCost1 { get; set; } 
        public IRPSComboBox<CostDetailTypeEntityView> IDBaseCost2 { get; set; } 
        public CostDetailTypeAccountsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> CostDetailTypeAccounts { get; set; } 
        public CostDetailTypeResourcesCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> CostDetailTypeResources { get; set; } 
        public CostDetailTypeYearsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> CostDetailTypeYears { get; set; } 
        public IRPSSection<CostDetailTypeEntityView> SectionDetailAccounts { get; set; } 
        public IRPSSection<CostDetailTypeEntityView> SectionTypeResources { get; set; } 
        public IRPSSection<CostDetailTypeEntityView> SectionTypeYears { get; set; } 
        public CostDetailType Screen { get; set; }
        public CostDetailTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CostDetailTypeAccountsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>:RPSCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public  CostDetailTypeAccountsGridView<CostDetailTypeEntityView,CostDetailTypeYearView> GridView {get;set;}
    }
    public partial class CostDetailTypeAccountsGridView <CostDetailTypeEntityView,CostDetailTypeYearView> :  RPSGridView<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public CostDetailTypeAccountsGridView(CostDetailTypeEntityView currentView,CostDetailTypeYearView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAccount = RPSControlFactory.CreateRPSGridEnumComboBox<CostDetailTypeEntityView>("","#bdeead42-31af-4972-941c-8c5208411b92 .ag-row[role='row']@ROWINDEX [col-id='cCodAccount']","",false, this.CurrentView);
 
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<CostDetailTypeEntityView>("","#bdeead42-31af-4972-941c-8c5208411b92 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",false, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<CostDetailTypeEntityView>("","#bdeead42-31af-4972-941c-8c5208411b92 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<CostDetailTypeEntityView>("","#bdeead42-31af-4972-941c-8c5208411b92 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CostDetailTypeEntityView> CodAccount { get; set; } 
        public IRPSGridComboBox<CostDetailTypeEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<CostDetailTypeEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<CostDetailTypeEntityView> Percentage { get; set; } 
                     
    }
 
        public partial class CostDetailTypeResourcesCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>:RPSCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public  CostDetailTypeResourcesGridView<CostDetailTypeEntityView,CostDetailTypeYearView> GridView {get;set;}
    }
    public partial class CostDetailTypeResourcesGridView <CostDetailTypeEntityView,CostDetailTypeYearView> :  RPSGridView<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public CostDetailTypeResourcesGridView(CostDetailTypeEntityView currentView,CostDetailTypeYearView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TypeResource = RPSControlFactory.CreateRPSGridEnumComboBox<CostDetailTypeEntityView>("","#4a6e997f-4343-4543-aeb8-2ca488836eec .ag-row[role='row']@ROWINDEX [col-id='cTypeResource']","",true, this.CurrentView);
 
            IDResourceSelector = RPSControlFactory.CreateRPSGridComboBox<CostDetailTypeEntityView>("","#4a6e997f-4343-4543-aeb8-2ca488836eec .ag-row[role='row']@ROWINDEX [col-id='cIDResourceSelector']","",false, this.CurrentView);
 
            IDHourType = RPSControlFactory.CreateRPSGridComboBox<CostDetailTypeEntityView>("","#4a6e997f-4343-4543-aeb8-2ca488836eec .ag-row[role='row']@ROWINDEX [col-id='cIDHourType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CostDetailTypeEntityView> TypeResource { get; set; } 
        public IRPSGridComboBox<CostDetailTypeEntityView> IDResourceSelector { get; set; } 
        public IRPSGridComboBox<CostDetailTypeEntityView> IDHourType { get; set; } 
                     
    }
 
        public partial class CostDetailTypeYearsCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView>:RPSCollectionEditor<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public  CostDetailTypeYearsGridView<CostDetailTypeEntityView,CostDetailTypeYearView> GridView {get;set;}
    }
    public partial class CostDetailTypeYearsGridView <CostDetailTypeEntityView,CostDetailTypeYearView> :  RPSGridView<CostDetailTypeEntityView,CostDetailTypeYearView> where CostDetailTypeEntityView : class, IView where CostDetailTypeYearView : class, IView
    {
        public CostDetailTypeYearsGridView(CostDetailTypeEntityView currentView,CostDetailTypeYearView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCYear = RPSControlFactory.CreateRPSGridComboBox<CostDetailTypeEntityView>("","#a00f0950-7c1c-4043-9557-4143fce8d199 .ag-row[role='row']@ROWINDEX [col-id='cACCYear']","",false, this.CurrentView);
 
            AmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<CostDetailTypeEntityView>("","#a00f0950-7c1c-4043-9557-4143fce8d199 .ag-row[role='row']@ROWINDEX [col-id='cAmountCost']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CostDetailTypeEntityView> ACCYear { get; set; } 
        public IRPSGridTextBox<CostDetailTypeEntityView> AmountCost { get; set; } 
                     
    }
 
    }
  
            
    public partial class CostDetailTypeResourceView : View
    {
        public CostDetailTypeResourceView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostDetailTypeResourceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostDetailTypeResourceView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostDetailTypeResourceView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CostDetailTypeResourceView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            TypeResource = RPSControlFactory.CreateRPSEnumComboBox<CostDetailTypeResourceView>("d547ccb2-ff59-45bb-9786-8596e91329d1","","",true, this);
 
            IDResourceCostComponent = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("3abc935e-5f14-45bf-891b-ed6dd72dc5f4","","",false, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("4fb257ca-8474-4091-9713-ff64c4a3d2d0","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("a2c8d985-9b2c-45ed-a530-317b2a85e8fa","","",false, this);
 
            IDResourceMachineGroup = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("b6dde5f0-ebf5-43ce-bd47-a0c0a4f76820","","",false, this);
 
            IDResourceQualify = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("8459906b-1102-4142-9ba8-128b1f770137","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("673424ea-7ace-409e-bf53-3fd51fdcd5ea","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<CostDetailTypeResourceView>("47b24a33-df24-442d-b10c-a83948a1efdd","","",true, this);
 

        }
        public IRPSButton<CostDetailTypeResourceView> DeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeResourceView,CostDetailTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeResourceView,CostDetailTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CostDetailTypeResourceView,CostDetailTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> TypeResource { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceCostComponent { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceMachine { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceMachineGroup { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceQualify { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDResourceTool { get; set; } 
        public IRPSComboBox<CostDetailTypeResourceView> IDHourType { get; set; } 
        public CostDetailType Screen { get; set; }
        public CostDetailTypeResourceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GetYearAmountChildDialogView : View
    {
        public GetYearAmountChildDialogView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ACCYear = RPSControlFactory.CreateRPSComboBox<GetYearAmountChildDialogView>("88dabcdc-ed87-4f49-9887-3301d4ad1ce1","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<GetYearAmountChildDialogView>("5881139b-380b-4556-b55b-db64b2597257","","",false, this);
 

        }
        public IRPSComboBox<GetYearAmountChildDialogView> ACCYear { get; set; } 
        public IRPSCollectionComboBox<GetYearAmountChildDialogView> CostDetailType { get; set; } 
        public CostDetailType Screen { get; set; }
        public GetYearAmountChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostDetailTypeAccountView : View
    {
        public CostDetailTypeAccountView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostDetailTypeAccountView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostDetailTypeAccountView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostDetailTypeAccountView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CostDetailTypeAccountView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            CodAccount = RPSControlFactory.CreateRPSEnumComboBox<CostDetailTypeAccountView>("890bb830-14e6-4d24-9d5e-b5cc9951ea5f","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<CostDetailTypeAccountView>("f6847f82-4152-4319-9f69-3206e0a37fdd","","",false, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<CostDetailTypeAccountView>("cbe70e4a-d8f6-4d12-a8e3-c01fdc15dc22","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<CostDetailTypeAccountView>("a40a78a7-489e-4165-9d5c-f567489f7fbc","","",true, this);
 

        }
        public IRPSButton<CostDetailTypeAccountView> DeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeAccountView,CostDetailTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeAccountView,CostDetailTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CostDetailTypeAccountView,CostDetailTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CostDetailTypeAccountView> CodAccount { get; set; } 
        public IRPSComboBox<CostDetailTypeAccountView> IDDimension { get; set; } 
        public IRPSComboBox<CostDetailTypeAccountView> IDDimValue { get; set; } 
        public IRPSTextBox<CostDetailTypeAccountView> Percentage { get; set; } 
        public CostDetailType Screen { get; set; }
        public CostDetailTypeAccountView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostDetailTypeYearView : View
    {
        public CostDetailTypeYearView(CostDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostDetailTypeYearView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostDetailTypeYearView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostDetailTypeYearView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CostDetailTypeYearView,CostDetailTypeEntityView>( this,Screen.CostDetailTypeEntityView);
 
            ACCYear = RPSControlFactory.CreateRPSComboBox<CostDetailTypeYearView>("8b828677-ad87-4ada-a872-86a547aea3b0","","",false, this);
 
            AmountCost = RPSControlFactory.CreateRPSFormattedTextBox<CostDetailTypeYearView>("2b4a2604-bf6e-4c77-83e4-9c3c7cfa1da8","","",true, this);
 

        }
        public IRPSButton<CostDetailTypeYearView> DeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeYearView,CostDetailTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostDetailTypeYearView,CostDetailTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CostDetailTypeYearView,CostDetailTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CostDetailTypeYearView> ACCYear { get; set; } 
        public IRPSTextBox<CostDetailTypeYearView> AmountCost { get; set; } 
        public CostDetailType Screen { get; set; }
        public CostDetailTypeYearView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}