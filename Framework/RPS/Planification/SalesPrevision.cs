    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.SalesPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class SalesPrevision:Screen
    {
        public SalesPrevision():base()
        {
            this.URL = "planification.salesprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesPrevisionVMCollectionView  = new SalesPrevisionVMCollectionView(this); 
            SalesPrevisionVMEntityView  = new SalesPrevisionVMEntityView(this); 
            MassiveDeleteDialogView  = new MassiveDeleteDialogView(this); 
            GenerateForecastChildDialogView  = new GenerateForecastChildDialogView(this); 
            ModifyQuantityDialogView  = new ModifyQuantityDialogView(this); 
            GenerateChildDialogView  = new GenerateChildDialogView(this); 
            SalesPrevisionVMCollectionView.InitializeControls(); 
            SalesPrevisionVMEntityView.InitializeControls(); 
            MassiveDeleteDialogView.InitializeControls(); 
            GenerateForecastChildDialogView.InitializeControls(); 
            ModifyQuantityDialogView.InitializeControls(); 
            GenerateChildDialogView.InitializeControls(); 
           
        }
      
            public SalesPrevisionVMCollectionView SalesPrevisionVMCollectionView {get; set; } 
            public SalesPrevisionVMEntityView SalesPrevisionVMEntityView {get; set; } 
            public MassiveDeleteDialogView MassiveDeleteDialogView {get; set; } 
            public GenerateForecastChildDialogView GenerateForecastChildDialogView {get; set; } 
            public ModifyQuantityDialogView ModifyQuantityDialogView {get; set; } 
            public GenerateChildDialogView GenerateChildDialogView {get; set; } 
    }
            
    public partial class SalesPrevisionVMCollectionView : View
    {
        public SalesPrevisionVMCollectionView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<SalesPrevisionVMCollectionView>("e88236e5-acd3-4077-a6f8-f85795c6ccec","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SalesPrevisionVMCollectionView>("bceb6265-2491-4eb4-940b-97e055fbf1d8","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<SalesPrevisionVMCollectionView>("fd0d98fa-58a5-4e53-ad85-f76576b018be","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SalesPrevisionVMCollectionView>("a470e230-3db3-4dad-b9ae-1d432393537a","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SalesPrevisionVMCollectionView>("fe4084f4-772a-482a-be0d-50bd3f68a642","","",false, this);
 
            CommandChangeStateButton = RPSControlFactory.CreateRPSButton<SalesPrevisionVMCollectionView>( "263e270d-ae33-4ec6-9009-ed8580c03e82","","",this);
 
            CommandDeleteButton = RPSControlFactory.CreateRPSButton<SalesPrevisionVMCollectionView>( "a8fde7b4-394e-41ee-b8d8-95fe73d2d8ca","","",this);
 
            MassiveDeleteNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesPrevisionVMCollectionView,MassiveDeleteDialogView>("59094727-c2dd-4d28-82a0-8cce9c086ac0","","", this,Screen.MassiveDeleteDialogView);
 
            GenerateForecastChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesPrevisionVMCollectionView,GenerateForecastChildDialogView>("398360fd-5b00-4744-9449-5f1621d5709b","","", this,Screen.GenerateForecastChildDialogView);
 
            CollectionInit params_SalesPrevisionQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b1ce3b67-e07a-4acf-a9fa-052656d9f89e",CSSSelectorGrid="",XPathGrid=""};
            SalesPrevisionQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SalesPrevisionQueryCollectionEditor<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView>,SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView>( params_SalesPrevisionQuery,this,Screen.SalesPrevisionVMEntityView);
 

        }
        public IRPSComboBox<SalesPrevisionVMCollectionView> Site { get; set; } 
        public IRPSCollectionComboBox<SalesPrevisionVMCollectionView> Article { get; set; } 
        public IRPSComboBox<SalesPrevisionVMCollectionView> eState { get; set; } 
        public IRPSTextBox<SalesPrevisionVMCollectionView> DateFrom { get; set; } 
        public IRPSTextBox<SalesPrevisionVMCollectionView> DateTo { get; set; } 
        public IRPSButton<SalesPrevisionVMCollectionView> CommandChangeStateButton { get; set; } 
        public IRPSButton<SalesPrevisionVMCollectionView> CommandDeleteButton { get; set; } 
        public IRPSButton<SalesPrevisionVMCollectionView,MassiveDeleteDialogView> MassiveDeleteNavigationCommandButton { get; set; } 
        public IRPSButton<SalesPrevisionVMCollectionView,GenerateForecastChildDialogView> GenerateForecastChildNavigationCommandButton { get; set; } 
        public SalesPrevisionQueryCollectionEditor<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView> SalesPrevisionQuery { get; set; } 
        public SalesPrevision Screen { get; set; }
        public SalesPrevisionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesPrevisionQueryCollectionEditor<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView>:RPSCollectionEditor<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView> where SalesPrevisionVMCollectionView : class, IView where SalesPrevisionVMEntityView : class, IView
    {
        public  SalesPrevisionQueryGridView<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView> GridView {get;set;}
    }
    public partial class SalesPrevisionQueryGridView <SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView> :  RPSGridView<SalesPrevisionVMCollectionView,SalesPrevisionVMEntityView> where SalesPrevisionVMCollectionView : class, IView where SalesPrevisionVMEntityView : class, IView
    {
        public SalesPrevisionQueryGridView(SalesPrevisionVMCollectionView currentView,SalesPrevisionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SalesPrevisionVMCollectionView>("","#b1ce3b67-e07a-4acf-a9fa-052656d9f89e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            PrevisionDate = RPSControlFactory.CreateRPSGridTextBox<SalesPrevisionVMCollectionView>("","#b1ce3b67-e07a-4acf-a9fa-052656d9f89e .ag-row[role='row']@ROWINDEX [col-id='cPrevisionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesPrevisionVMCollectionView>("","#b1ce3b67-e07a-4acf-a9fa-052656d9f89e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridEnumComboBox<SalesPrevisionVMCollectionView>("","#b1ce3b67-e07a-4acf-a9fa-052656d9f89e .ag-row[role='row']@ROWINDEX [col-id='cState']","",true, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<SalesPrevisionVMCollectionView>("","#b1ce3b67-e07a-4acf-a9fa-052656d9f89e .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesPrevisionVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<SalesPrevisionVMCollectionView> PrevisionDate { get; set; } 
        public IRPSGridTextBox<SalesPrevisionVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<SalesPrevisionVMCollectionView> State { get; set; } 
        public IRPSGridTextBox<SalesPrevisionVMCollectionView> InternalCode { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesPrevisionVMEntityView : View
    {
        public SalesPrevisionVMEntityView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesPrevisionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView>( this,Screen.SalesPrevisionVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView>( this,Screen.SalesPrevisionVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView>( this,Screen.SalesPrevisionVMCollectionView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SalesPrevisionVMEntityView>("1eb10d02-0d41-477c-89db-fa4551908f46","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SalesPrevisionVMEntityView>("4736b68e-1521-43f0-b353-7915594b5e78","","",true, this);
 
            PrevisionDate = RPSControlFactory.CreateRPSTextBox<SalesPrevisionVMEntityView>("eaa65f87-97f6-4f4a-9943-5475cd474de7","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SalesPrevisionVMEntityView>("fa0142bb-4bef-43b6-9ffc-2671eaf0224e","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SalesPrevisionVMEntityView>("fe0ddf5c-47a1-42fc-bc7e-26feaa8ddea0","","",false, this);
 
            State = RPSControlFactory.CreateRPSEnumComboBox<SalesPrevisionVMEntityView>("1f3e469d-4be8-4a1e-9158-2b1d8d724bcb","","",true, this);
 

        }
        public IRPSButton<SalesPrevisionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesPrevisionVMEntityView,SalesPrevisionVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesPrevisionVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<SalesPrevisionVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<SalesPrevisionVMEntityView> PrevisionDate { get; set; } 
        public IRPSTextBox<SalesPrevisionVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<SalesPrevisionVMEntityView> InternalCode { get; set; } 
        public IRPSComboBox<SalesPrevisionVMEntityView> State { get; set; } 
        public SalesPrevision Screen { get; set; }
        public SalesPrevisionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MassiveDeleteDialogView : View
    {
        public MassiveDeleteDialogView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MassiveDeleteDialogView>("cc58c66e-e4d5-422d-95f3-726dbe6c14b3","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MassiveDeleteDialogView>("374160c7-0920-42f7-92d7-47485dee31ec","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<MassiveDeleteDialogView>("73938254-d738-4370-be82-03352bb7156c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MassiveDeleteDialogView>("ae01cad8-40f2-4fba-bc86-952aaaa6257f","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MassiveDeleteDialogView>("a76ac27f-f3ac-47c0-8c25-73935d717bfa","","",false, this);
 
            CommandMassiveDelete = RPSControlFactory.CreateRPSButton<MassiveDeleteDialogView>( "4f97d885-67b6-42f9-8d00-8ee1b6d4f781","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<MassiveDeleteDialogView>( "78ace3a5-b4b3-439a-b6a3-5f0979d6c0ea","","",this);
 

        }
        public IRPSComboBox<MassiveDeleteDialogView> Site { get; set; } 
        public IRPSCollectionComboBox<MassiveDeleteDialogView> Article { get; set; } 
        public IRPSComboBox<MassiveDeleteDialogView> eState { get; set; } 
        public IRPSTextBox<MassiveDeleteDialogView> DateFrom { get; set; } 
        public IRPSTextBox<MassiveDeleteDialogView> DateTo { get; set; } 
        public IRPSButton<MassiveDeleteDialogView> CommandMassiveDelete { get; set; } 
        public IRPSButton<MassiveDeleteDialogView> LinkNavigationCommand { get; set; } 
        public SalesPrevision Screen { get; set; }
        public MassiveDeleteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateForecastChildDialogView : View
    {
        public GenerateForecastChildDialogView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionPeriodAdjustment = RPSControlFactory.CreateRPSEnumComboBox<GenerateForecastChildDialogView>("f9b1a41a-75b1-4981-8531-51a9b4266a05","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<GenerateForecastChildDialogView>("b74ca000-43fb-4149-9d5e-3ff8c9f7cf81","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<GenerateForecastChildDialogView>("74d1e3ee-5c6f-4424-9247-da4c367baab0","","",false, this);
 
            OptionPeriods = RPSControlFactory.CreateRPSEnumComboBox<GenerateForecastChildDialogView>("7387d1b7-11ba-4ac8-b918-959bdb8e63eb","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<GenerateForecastChildDialogView>("2d19df80-6699-4cf4-b687-046c1994c43a","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<GenerateForecastChildDialogView>("3d4cffa5-208f-4a4d-8174-4448ec1c0adc","","",false, this);
 
            OptionCalculationType = RPSControlFactory.CreateRPSEnumComboBox<GenerateForecastChildDialogView>("dc42150a-4991-42db-a435-d17cf86c2a5d","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<GenerateForecastChildDialogView>("ff70ed0d-5aa7-4109-a587-76cbaae6a82b","","",false, this);
 
            Increment = RPSControlFactory.CreateRPSFormattedTextBox<GenerateForecastChildDialogView>("a4b8404c-ebec-4e30-9a27-83729c72ff65","","",false, this);
 
            ConsumptionForecastGenerate = RPSControlFactory.CreateRPSCheckBox<GenerateForecastChildDialogView>("0d42f8f2-a26e-4ec4-a7b2-debee99389a4","","",false, this);
 
            DateFromGenerate = RPSControlFactory.CreateRPSTextBox<GenerateForecastChildDialogView>("334e36d4-46f7-4a54-96e2-0059559f5bff","","",false, this);
 
            DateToGenerate = RPSControlFactory.CreateRPSTextBox<GenerateForecastChildDialogView>("b348a0f5-959e-4e86-89cf-ae6d04751281","","",false, this);
 
            GenerateComm = RPSControlFactory.CreateRPSButton<GenerateForecastChildDialogView>( "ced06281-b8c1-45b2-a2f9-cb9f25b5792f","","",this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<GenerateForecastChildDialogView>( "1babd3ce-8a64-4227-b5a1-563494f04c3d","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<GenerateForecastChildDialogView>( "9165c9a6-37f3-446d-a0d0-b15619cbff92","","",this);
 
            ModifyQuantityNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<GenerateForecastChildDialogView,ModifyQuantityDialogView>("44591358-5350-47c7-8822-c0b310b114d7","","", this,Screen.ModifyQuantityDialogView);
 

        }
        public IRPSComboBox<GenerateForecastChildDialogView> OptionPeriodAdjustment { get; set; } 
        public IRPSCollectionComboBox<GenerateForecastChildDialogView> Article { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> InternalCode { get; set; } 
        public IRPSComboBox<GenerateForecastChildDialogView> OptionPeriods { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> DateTo { get; set; } 
        public IRPSComboBox<GenerateForecastChildDialogView> OptionCalculationType { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> Quantity { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> Increment { get; set; } 
        public IRPSCheckbox<GenerateForecastChildDialogView> ConsumptionForecastGenerate { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> DateFromGenerate { get; set; } 
        public IRPSTextBox<GenerateForecastChildDialogView> DateToGenerate { get; set; } 
        public IRPSButton<GenerateForecastChildDialogView> GenerateComm { get; set; } 
        public IRPSButton<GenerateForecastChildDialogView> ConsultCommand { get; set; } 
        public IRPSButton<GenerateForecastChildDialogView> SaveCommandButton { get; set; } 
        public IRPSButton<GenerateForecastChildDialogView,ModifyQuantityDialogView> ModifyQuantityNavigationCommandButton { get; set; } 
        public SalesPrevision Screen { get; set; }
        public GenerateForecastChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ModifyQuantityDialogView : View
    {
        public ModifyQuantityDialogView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionModifyQuantity = RPSControlFactory.CreateRPSEnumComboBox<ModifyQuantityDialogView>("d31cf87a-290e-49a1-814f-7b4dc3985c05","","",false, this);
 
            ModifyQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ModifyQuantityDialogView>("8b662f35-252b-4961-a6ef-de21c6c7ad11","","",false, this);
 

        }
        public IRPSComboBox<ModifyQuantityDialogView> OptionModifyQuantity { get; set; } 
        public IRPSTextBox<ModifyQuantityDialogView> ModifyQuantity { get; set; } 
        public SalesPrevision Screen { get; set; }
        public ModifyQuantityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateChildDialogView : View
    {
        public GenerateChildDialogView(SalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionCalculationType = RPSControlFactory.CreateRPSEnumComboBox<GenerateChildDialogView>("cd168d0e-2a46-4c18-a0ae-85c5719cc65a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<GenerateChildDialogView>("47d68f08-a96f-45fc-994d-bb9c2427a631","","",false, this);
 
            Increment = RPSControlFactory.CreateRPSFormattedTextBox<GenerateChildDialogView>("fc9878fa-629d-4fa3-9de6-8e8ebbdfa9aa","","",false, this);
 
            ConsumptionForecast = RPSControlFactory.CreateRPSCheckBox<GenerateChildDialogView>("b29d054c-a0af-44a6-b1c5-e59366425b6a","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<GenerateChildDialogView>("40eb653f-56c5-4e4f-8267-7db6939afb84","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<GenerateChildDialogView>("ec640403-52c0-49f6-a60e-2cbab869e9bb","","",false, this);
 

        }
        public IRPSComboBox<GenerateChildDialogView> OptionCalculationType { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> Quantity { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> Increment { get; set; } 
        public IRPSCheckbox<GenerateChildDialogView> ConsumptionForecast { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> DateTo { get; set; } 
        public SalesPrevision Screen { get; set; }
        public GenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}