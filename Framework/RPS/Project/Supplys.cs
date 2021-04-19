    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Supplys
{
    //RPS VERSION 1.0.0.0
    public partial class Supplys:Screen
    {
        public Supplys():base()
        {
            this.URL = "project.supplys";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplysQueryView  = new SupplysQueryView(this); 
            SupplysUpdateOptionsScreenDialogView  = new SupplysUpdateOptionsScreenDialogView(this); 
            SupplysMOConsultViewModelView  = new SupplysMOConsultViewModelView(this); 
            SupplysMOUpdateOptionsScreenDialogView  = new SupplysMOUpdateOptionsScreenDialogView(this); 
            ProjectMaterialChangeStatusDialogView  = new ProjectMaterialChangeStatusDialogView(this); 
            IncludePackingDialogView  = new IncludePackingDialogView(this); 
            GenerateOrderPackingDialogView  = new GenerateOrderPackingDialogView(this); 
            SupplysQueryView.InitializeControls(); 
            SupplysUpdateOptionsScreenDialogView.InitializeControls(); 
            SupplysMOConsultViewModelView.InitializeControls(); 
            SupplysMOUpdateOptionsScreenDialogView.InitializeControls(); 
            ProjectMaterialChangeStatusDialogView.InitializeControls(); 
            IncludePackingDialogView.InitializeControls(); 
            GenerateOrderPackingDialogView.InitializeControls(); 
           
        }
      
            public SupplysQueryView SupplysQueryView {get; set; } 
            public SupplysUpdateOptionsScreenDialogView SupplysUpdateOptionsScreenDialogView {get; set; } 
            public SupplysMOConsultViewModelView SupplysMOConsultViewModelView {get; set; } 
            public SupplysMOUpdateOptionsScreenDialogView SupplysMOUpdateOptionsScreenDialogView {get; set; } 
            public ProjectMaterialChangeStatusDialogView ProjectMaterialChangeStatusDialogView {get; set; } 
            public IncludePackingDialogView IncludePackingDialogView {get; set; } 
            public GenerateOrderPackingDialogView GenerateOrderPackingDialogView {get; set; } 
    }
            
    public partial class SupplysQueryView : View
    {
        public SupplysQueryView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<SupplysQueryView>("92f3dc81-e6f7-4ec8-a00c-297fac15a342","","",false, this);
 
            eSituationType = RPSControlFactory.CreateRPSEnumComboBox<SupplysQueryView>("bc67d724-6f75-4be8-b35e-2d3716929d31","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<SupplysQueryView>("44e22ae2-4b53-4924-b0c9-181bb9f21532","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<SupplysQueryView>("dbea0990-28fe-48be-9a57-40f526b15742","","",false, this);
 
            UILstProductLine = RPSControlFactory.CreateRPSCollectionComboBox<SupplysQueryView>("eb5fb8cb-b97f-4512-921d-5c6331549d74","","",false, this);
 
            UILstProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplysQueryView>("d350c213-5dcb-4a30-b470-b57fa952f49b","","",false, this);
 
            UILstProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplysQueryView>("06168e02-702b-45a6-88c3-b25005f4daa9","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "478f66d1-3210-4df4-9751-07d33ff811da","","",this);
 
            PendingImputate = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "17e7e561-7e76-4dd2-b39c-f981e8db155c","","",this);
 
            PendingProvisioning = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "c2b76327-c9b9-445c-9eba-d2c7cb2dde74","","",this);
 
            PendingPacking = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "86597e49-76a8-4af8-be53-67ba610e1ec9","","",this);
 
            Purchase = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "afcdbe80-704f-4169-96ee-83b3bbb84907","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<SupplysQueryView>( "3126a59e-a014-4e20-985d-d8b4b56c58c3","","",this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("976fd14c-a90c-4974-8909-aac68b715764","","",false, this);
 
            ArticleType = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("a1401fb6-631f-4b32-bc64-37081940570a","","",false, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("86dce025-0ca1-4df2-924c-03bcaed4817e","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<SupplysQueryView>("8903af46-f4c2-4b1f-9c21-b07d0ca8a37e","","",false, this);
 
            SupplySituation = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("7ffab1e2-9ca9-4bd0-b34a-c0caae192739","","",false, this);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSFormattedTextBox<SupplysQueryView>("d17edf1b-cf3b-4e61-baee-466416ac5ab9","","",false, this);
 
            Suffix = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("66c57a16-b244-4cf4-bd85-28dc85a3888d","","",false, this);
 
            OpenMOCommand = RPSControlFactory.CreateRPSButton<SupplysQueryView>( "2e151d85-5035-4c57-9eec-ec678d93b64d","","",this);
 
            QuantityNewPacking = RPSControlFactory.CreateRPSFormattedTextBox<SupplysQueryView>("bccd34d0-986d-435f-9132-3ce3f52a73b9","","",false, this);
 
            IncludePacking = RPSControlFactory.CreateRPSTextBox<SupplysQueryView>("9f392744-33e4-4883-81ec-7aed563ed18e","","",false, this);
 
            GenerateSupplysCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplysQueryView,SupplysUpdateOptionsScreenDialogView>("0c269f83-dfa7-4d35-97fa-4b336d72c550","","", this,Screen.SupplysUpdateOptionsScreenDialogView);
 
            ProjectMaterialChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplysQueryView,ProjectMaterialChangeStatusDialogView>("f5d56346-5931-4889-9562-73f2ea550891","","", this,Screen.ProjectMaterialChangeStatusDialogView);
 
            ProjectTaskMaterialStockReserveAutomaticCommandButton = RPSControlFactory.CreateRPSButton<SupplysQueryView>( "917e33da-17d9-4d85-bf55-cf50e60cbf30","","",this);
 
            IncludePackingNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplysQueryView,IncludePackingDialogView>("9381ff3c-8a36-4b6c-ad45-392955798a0c","","", this,Screen.IncludePackingDialogView);
 
            GenerateOrderPackingNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplysQueryView,GenerateOrderPackingDialogView>("024bf6cc-a6ed-4025-b889-12b4b8983394","","", this,Screen.GenerateOrderPackingDialogView);
 
            CollectionInit params_SupplysProjectConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0d4ca945-e6d1-409a-93e5-794b5e4543b1",CSSSelectorGrid="",XPathGrid=""};
            SupplysProjectConsult = RPSControlFactory.RPSCreateCollectionWithGrid<SupplysProjectConsultCollectionEditor<SupplysQueryView,SupplysUpdateOptionsScreenDialogView>,SupplysQueryView,SupplysUpdateOptionsScreenDialogView>( params_SupplysProjectConsult,this,Screen.SupplysUpdateOptionsScreenDialogView);
 

        }
        public IRPSComboBox<SupplysQueryView> Project { get; set; } 
        public IRPSComboBox<SupplysQueryView> eSituationType { get; set; } 
        public IRPSCollectionComboBox<SupplysQueryView> ProjectTask { get; set; } 
        public IRPSComboBox<SupplysQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<SupplysQueryView> UILstProductLine { get; set; } 
        public IRPSCollectionComboBox<SupplysQueryView> UILstProductFamily { get; set; } 
        public IRPSCollectionComboBox<SupplysQueryView> UILstProductSubFamily { get; set; } 
        public IRPSOption<SupplysQueryView> All { get; set; } 
        public IRPSOption<SupplysQueryView> PendingImputate { get; set; } 
        public IRPSOption<SupplysQueryView> PendingProvisioning { get; set; } 
        public IRPSOption<SupplysQueryView> PendingPacking { get; set; } 
        public IRPSOption<SupplysQueryView> Purchase { get; set; } 
        public IRPSOption<SupplysQueryView> Manufacturing { get; set; } 
        public IRPSTextBox<SupplysQueryView> StartDate { get; set; } 
        public IRPSTextBox<SupplysQueryView> ArticleType { get; set; } 
        public IRPSTextBox<SupplysQueryView> ProjectProvisionType { get; set; } 
        public IRPSComboBox<SupplysQueryView> Status { get; set; } 
        public IRPSTextBox<SupplysQueryView> SupplySituation { get; set; } 
        public IRPSTextBox<SupplysQueryView> QuantityToSupplyment { get; set; } 
        public IRPSTextBox<SupplysQueryView> Suffix { get; set; } 
        public IRPSButton<SupplysQueryView> OpenMOCommand { get; set; } 
        public IRPSTextBox<SupplysQueryView> QuantityNewPacking { get; set; } 
        public IRPSTextBox<SupplysQueryView> IncludePacking { get; set; } 
        public IRPSButton<SupplysQueryView,SupplysUpdateOptionsScreenDialogView> GenerateSupplysCommandButton { get; set; } 
        public IRPSButton<SupplysQueryView,ProjectMaterialChangeStatusDialogView> ProjectMaterialChangeStatusNavigationCommandButton { get; set; } 
        public IRPSButton<SupplysQueryView> ProjectTaskMaterialStockReserveAutomaticCommandButton { get; set; } 
        public IRPSButton<SupplysQueryView,IncludePackingDialogView> IncludePackingNavigationCommandButton { get; set; } 
        public IRPSButton<SupplysQueryView,GenerateOrderPackingDialogView> GenerateOrderPackingNavigationCommandButton { get; set; } 
        public SupplysProjectConsultCollectionEditor<SupplysQueryView,SupplysUpdateOptionsScreenDialogView> SupplysProjectConsult { get; set; } 
        public Supplys Screen { get; set; }
        public SupplysQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplysProjectConsultCollectionEditor<SupplysQueryView,SupplysUpdateOptionsScreenDialogView>:RPSCollectionEditor<SupplysQueryView,SupplysUpdateOptionsScreenDialogView> where SupplysQueryView : class, IView where SupplysUpdateOptionsScreenDialogView : class, IView
    {
        public  SupplysProjectConsultGridView<SupplysQueryView,SupplysUpdateOptionsScreenDialogView> GridView {get;set;}
    }
    public partial class SupplysProjectConsultGridView <SupplysQueryView,SupplysUpdateOptionsScreenDialogView> :  RPSGridView<SupplysQueryView,SupplysUpdateOptionsScreenDialogView> where SupplysQueryView : class, IView where SupplysUpdateOptionsScreenDialogView : class, IView
    {
        public SupplysProjectConsultGridView(SupplysQueryView currentView,SupplysUpdateOptionsScreenDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<SupplysQueryView>("","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 
            SupplySituation = RPSControlFactory.CreateRPSGridTextBox<SupplysQueryView>("","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplysQueryView>("","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToSupplyment']","",false, this.CurrentView);
 
            IncludePacking = RPSControlFactory.CreateRPSGridTextBox<SupplysQueryView>("","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cIncludePacking']","",false, this.CurrentView);
 
            QuantityNewPacking = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplysQueryView>("","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cQuantityNewPacking']","",false, this.CurrentView);
 
            OpenMOCommand = RPSControlFactory.CreateRPSGridButton<SupplysQueryView>( "","#0d4ca945-e6d1-409a-93e5-794b5e4543b1 .ag-row[role='row']@ROWINDEX [col-id='cOpenMOCommand']","",this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplysQueryView> Status { get; set; } 
        public IRPSGridTextBox<SupplysQueryView> SupplySituation { get; set; } 
        public IRPSGridTextBox<SupplysQueryView> QuantityToSupplyment { get; set; } 
        public IRPSGridTextBox<SupplysQueryView> IncludePacking { get; set; } 
        public IRPSGridTextBox<SupplysQueryView> QuantityNewPacking { get; set; } 
        public IRPSGridButton<SupplysQueryView> OpenMOCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplysUpdateOptionsScreenDialogView : View
    {
        public SupplysUpdateOptionsScreenDialogView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSOption<SupplysUpdateOptionsScreenDialogView>( "43e0aad4-07ac-4d6a-9c14-dfe87c515c54","","",this);
 
            Proposal = RPSControlFactory.CreateRPSOption<SupplysUpdateOptionsScreenDialogView>( "8f675840-f8c2-4113-9a47-e32e34c0f683","","",this);
 
            LaunchOF = RPSControlFactory.CreateRPSCheckBox<SupplysUpdateOptionsScreenDialogView>("b722df70-3d97-40ad-9d80-39826304235f","","",false, this);
 

        }
        public IRPSOption<SupplysUpdateOptionsScreenDialogView> Order { get; set; } 
        public IRPSOption<SupplysUpdateOptionsScreenDialogView> Proposal { get; set; } 
        public IRPSCheckbox<SupplysUpdateOptionsScreenDialogView> LaunchOF { get; set; } 
        public Supplys Screen { get; set; }
        public SupplysUpdateOptionsScreenDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplysMOConsultViewModelView : View
    {
        public SupplysMOConsultViewModelView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<SupplysMOConsultViewModelView>("41836ef9-7f22-4cbe-81e6-0665d9058503","","",false, this);
 
            TypeArticle = RPSControlFactory.CreateRPSTextBox<SupplysMOConsultViewModelView>("5056276d-4458-4b4b-be56-c2901bf4fad2","","",false, this);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSFormattedTextBox<SupplysMOConsultViewModelView>("15a67cff-2d07-49d7-9f0b-f5d1b84b72e8","","",false, this);
 
            Suffix = RPSControlFactory.CreateRPSTextBox<SupplysMOConsultViewModelView>("4193c8ee-2b27-463f-9851-be801bc0a3b7","","",false, this);
 
            IDProposal = RPSControlFactory.CreateRPSComboBox<SupplysMOConsultViewModelView>("8782bcaf-5303-42d0-8f70-3a9ef5c30123","","",false, this);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<SupplysMOConsultViewModelView>("6423b91a-026e-4da3-8de3-690994efd76c","","",false, this);
 
            IDMO = RPSControlFactory.CreateRPSComboBox<SupplysMOConsultViewModelView>("64bdc95d-8222-4e9a-84b8-6f9a32a30464","","",false, this);
 
            SupplysMOUpdateOptionsScreenNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView>("d67dc8dd-b5fc-4640-99db-41ec86d624ba","","", this,Screen.SupplysMOUpdateOptionsScreenDialogView);
 
            CollectionInit params_SupplysMODataConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="326b4191-e5d4-4745-8259-2c92367e9f32",CSSSelectorGrid="",XPathGrid=""};
            SupplysMODataConsult = RPSControlFactory.RPSCreateCollectionWithGrid<SupplysMODataConsultCollectionEditor<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView>,SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView>( params_SupplysMODataConsult,this,Screen.SupplysMOUpdateOptionsScreenDialogView);
 

        }
        public IRPSComboBox<SupplysMOConsultViewModelView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<SupplysMOConsultViewModelView> TypeArticle { get; set; } 
        public IRPSTextBox<SupplysMOConsultViewModelView> QuantityToSupplyment { get; set; } 
        public IRPSTextBox<SupplysMOConsultViewModelView> Suffix { get; set; } 
        public IRPSComboBox<SupplysMOConsultViewModelView> IDProposal { get; set; } 
        public IRPSComboBox<SupplysMOConsultViewModelView> IDOrder { get; set; } 
        public IRPSComboBox<SupplysMOConsultViewModelView> IDMO { get; set; } 
        public IRPSButton<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> SupplysMOUpdateOptionsScreenNavigationCommandButton { get; set; } 
        public SupplysMODataConsultCollectionEditor<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> SupplysMODataConsult { get; set; } 
        public Supplys Screen { get; set; }
        public SupplysMOConsultViewModelView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplysMODataConsultCollectionEditor<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView>:RPSCollectionEditor<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> where SupplysMOConsultViewModelView : class, IView where SupplysMOUpdateOptionsScreenDialogView : class, IView
    {
        public  SupplysMODataConsultGridView<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> GridView {get;set;}
    }
    public partial class SupplysMODataConsultGridView <SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> :  RPSGridView<SupplysMOConsultViewModelView,SupplysMOUpdateOptionsScreenDialogView> where SupplysMOConsultViewModelView : class, IView where SupplysMOUpdateOptionsScreenDialogView : class, IView
    {
        public SupplysMODataConsultGridView(SupplysMOConsultViewModelView currentView,SupplysMOUpdateOptionsScreenDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            QuantityToSupplyment = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplysMOConsultViewModelView>("","#326b4191-e5d4-4745-8259-2c92367e9f32 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToSupplyment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplysMOConsultViewModelView> QuantityToSupplyment { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplysMOUpdateOptionsScreenDialogView : View
    {
        public SupplysMOUpdateOptionsScreenDialogView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSOption<SupplysMOUpdateOptionsScreenDialogView>( "41194355-6e07-408e-b7d0-366e3281d7b1","","",this);
 
            Proposal = RPSControlFactory.CreateRPSOption<SupplysMOUpdateOptionsScreenDialogView>( "7f048708-e9aa-481c-86c0-55138f80d196","","",this);
 
            LaunchOF = RPSControlFactory.CreateRPSCheckBox<SupplysMOUpdateOptionsScreenDialogView>("d322f409-4e50-4327-9e83-f511d0bd5dc1","","",false, this);
 

        }
        public IRPSOption<SupplysMOUpdateOptionsScreenDialogView> Order { get; set; } 
        public IRPSOption<SupplysMOUpdateOptionsScreenDialogView> Proposal { get; set; } 
        public IRPSCheckbox<SupplysMOUpdateOptionsScreenDialogView> LaunchOF { get; set; } 
        public Supplys Screen { get; set; }
        public SupplysMOUpdateOptionsScreenDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectMaterialChangeStatusDialogView : View
    {
        public ProjectMaterialChangeStatusDialogView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStatus = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialChangeStatusDialogView>("a7335170-b868-4b89-b900-51750f0822d7","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<ProjectMaterialChangeStatusDialogView>("d9de4dce-3957-4574-8aec-94e85d6cc1cb","","",false, this);
 

        }
        public IRPSComboBox<ProjectMaterialChangeStatusDialogView> UIStatus { get; set; } 
        public IRPSTextBox<ProjectMaterialChangeStatusDialogView> UIComment { get; set; } 
        public Supplys Screen { get; set; }
        public ProjectMaterialChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncludePackingDialogView : View
    {
        public IncludePackingDialogView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIPacking = RPSControlFactory.CreateRPSEnumComboBox<IncludePackingDialogView>("7bfb2743-216d-47ed-a925-502490c4d139","","",true, this);
 

        }
        public IRPSComboBox<IncludePackingDialogView> UIPacking { get; set; } 
        public Supplys Screen { get; set; }
        public IncludePackingDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateOrderPackingDialogView : View
    {
        public GenerateOrderPackingDialogView(Supplys screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<GenerateOrderPackingDialogView>("7100ba59-5fff-42ea-80ea-b5178502c8df","","",true, this);
 
            UICustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<GenerateOrderPackingDialogView>("81ec6de0-7374-4ae7-a3fe-323d97ad7586","","",false, this);
 

        }
        public IRPSComboBox<GenerateOrderPackingDialogView> UIDeliveryNoteTypeSL { get; set; } 
        public IRPSComboBox<GenerateOrderPackingDialogView> UICustomerDeliveryAddress { get; set; } 
        public Supplys Screen { get; set; }
        public GenerateOrderPackingDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}