    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ProductFormula
{
    //RPS VERSION 1.0.0.0
    public partial class ProductFormula:Screen
    {
        public ProductFormula():base()
        {
            this.URL = "manufacturing.productformula";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductFormulaCollectionView  = new ProductFormulaCollectionView(this); 
            ProductFormulaEntityView  = new ProductFormulaEntityView(this); 
            ProductFormulaMaterialView  = new ProductFormulaMaterialView(this); 
            NewProductFormulaVersionDialogDialogView  = new NewProductFormulaVersionDialogDialogView(this); 
            CopyFromProductFormulaSourceChildDialogView  = new CopyFromProductFormulaSourceChildDialogView(this); 
            SearchFormulaInStructureDialogDialogView  = new SearchFormulaInStructureDialogDialogView(this); 
            ProductFormulaCollectionView.InitializeControls(); 
            ProductFormulaEntityView.InitializeControls(); 
            ProductFormulaMaterialView.InitializeControls(); 
            NewProductFormulaVersionDialogDialogView.InitializeControls(); 
            CopyFromProductFormulaSourceChildDialogView.InitializeControls(); 
            SearchFormulaInStructureDialogDialogView.InitializeControls(); 
           
        }
      
            public ProductFormulaCollectionView ProductFormulaCollectionView {get; set; } 
            public ProductFormulaEntityView ProductFormulaEntityView {get; set; } 
            public ProductFormulaMaterialView ProductFormulaMaterialView {get; set; } 
            public NewProductFormulaVersionDialogDialogView NewProductFormulaVersionDialogDialogView {get; set; } 
            public CopyFromProductFormulaSourceChildDialogView CopyFromProductFormulaSourceChildDialogView {get; set; } 
            public SearchFormulaInStructureDialogDialogView SearchFormulaInStructureDialogDialogView {get; set; } 
    }
            
    public partial class ProductFormulaCollectionView : View
    {
        public ProductFormulaCollectionView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProductFormulaCollectionView,ProductFormulaEntityView>( this,Screen.ProductFormulaEntityView);
 
            CopyFromProductFormulaSourceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProductFormulaCollectionView,CopyFromProductFormulaSourceChildDialogView>("5e25af63-0f9c-4396-9f13-a815ca29dabb","","", this,Screen.CopyFromProductFormulaSourceChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8e2699dd-1ce9-4871-a335-17885d57f44e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProductFormulaCollectionView,ProductFormulaEntityView>( params_MainConsult,this,Screen.ProductFormulaEntityView);
 

        }
        public IRPSButton<ProductFormulaCollectionView,ProductFormulaEntityView> NewButton { get; set; } 
        public IRPSButton<ProductFormulaCollectionView,CopyFromProductFormulaSourceChildDialogView> CopyFromProductFormulaSourceChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ProductFormulaCollectionView,ProductFormulaEntityView> MainConsult { get; set; } 
        public ProductFormula Screen { get; set; }
        public ProductFormulaCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductFormulaEntityView : View
    {
        public ProductFormulaEntityView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProductFormulaEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductFormulaEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductFormulaEntityView,ProductFormulaCollectionView>( this,Screen.ProductFormulaCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductFormulaEntityView,ProductFormulaCollectionView>( this,Screen.ProductFormulaCollectionView);
 
            CodFormula = RPSControlFactory.CreateRPSTextBox<ProductFormulaEntityView>("a6542567-79c2-4c62-afb3-5e1978f682c9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductFormulaEntityView>("b12719a3-9e98-4e6b-9749-bfee639a10b2","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ProductFormulaEntityView>("eb9fb605-8e42-4648-bcca-f5ea50638dfa","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ProductFormulaEntityView>("d23708b9-5878-4bc8-905a-779d7de051ee","","",true, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<ProductFormulaEntityView>("ca9926a8-585d-4035-b35f-5a2b9a612ce1","","",false, this);
 
            NewProductFormulaVersionDialogNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProductFormulaEntityView,NewProductFormulaVersionDialogDialogView>("63240c70-27b2-4d73-a0f0-3e57f14b1857","","", this,Screen.NewProductFormulaVersionDialogDialogView);
 
            SearchFormulaInStructureDialogNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProductFormulaEntityView,SearchFormulaInStructureDialogDialogView>("ca2acc27-ff23-454d-b0ed-32a92b958690","","", this,Screen.SearchFormulaInStructureDialogDialogView);
 
            CollectionInit params_ProductFormulaMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7dc0fcfd-90e2-478d-902c-660e4239b204",CSSSelectorGrid="",XPathGrid=""};
            ProductFormulaMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<ProductFormulaMaterialsCollectionEditor<ProductFormulaEntityView,ProductFormulaMaterialView>,ProductFormulaEntityView,ProductFormulaMaterialView>( params_ProductFormulaMaterials,this,Screen.ProductFormulaMaterialView);
 

        }
        public IRPSSaveButton<ProductFormulaEntityView> SaveButton { get; set; } 
        public IRPSButton<ProductFormulaEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProductFormulaEntityView,ProductFormulaCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductFormulaEntityView,ProductFormulaCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProductFormulaEntityView> CodFormula { get; set; } 
        public IRPSTextBox<ProductFormulaEntityView> Description { get; set; } 
        public IRPSTextBox<ProductFormulaEntityView> Version { get; set; } 
        public IRPSTextBox<ProductFormulaEntityView> Date { get; set; } 
        public IRPSTextBox<ProductFormulaEntityView> InactivateDate { get; set; } 
        public IRPSButton<ProductFormulaEntityView,NewProductFormulaVersionDialogDialogView> NewProductFormulaVersionDialogNavigationCommandButton { get; set; } 
        public IRPSButton<ProductFormulaEntityView,SearchFormulaInStructureDialogDialogView> SearchFormulaInStructureDialogNavigationCommandButton { get; set; } 
        public ProductFormulaMaterialsCollectionEditor<ProductFormulaEntityView,ProductFormulaMaterialView> ProductFormulaMaterials { get; set; } 
        public ProductFormula Screen { get; set; }
        public ProductFormulaEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductFormulaMaterialsCollectionEditor<ProductFormulaEntityView,ProductFormulaMaterialView>:RPSCollectionEditor<ProductFormulaEntityView,ProductFormulaMaterialView> where ProductFormulaEntityView : class, IView where ProductFormulaMaterialView : class, IView
    {
        public  ProductFormulaMaterialsGridView<ProductFormulaEntityView,ProductFormulaMaterialView> GridView {get;set;}
    }
    public partial class ProductFormulaMaterialsGridView <ProductFormulaEntityView,ProductFormulaMaterialView> :  RPSGridView<ProductFormulaEntityView,ProductFormulaMaterialView> where ProductFormulaEntityView : class, IView where ProductFormulaMaterialView : class, IView
    {
        public ProductFormulaMaterialsGridView(ProductFormulaEntityView currentView,ProductFormulaMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            MaterialType = RPSControlFactory.CreateRPSGridEnumComboBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cMaterialType']","",true, this.CurrentView);
 
            QuantityType = RPSControlFactory.CreateRPSGridEnumComboBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cQuantityType']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            ContentLot = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductFormulaEntityView>("","#7dc0fcfd-90e2-478d-902c-660e4239b204 .ag-row[role='row']@ROWINDEX [col-id='cContentLot']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProductFormulaEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<ProductFormulaEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProductFormulaEntityView> MaterialType { get; set; } 
        public IRPSGridComboBox<ProductFormulaEntityView> QuantityType { get; set; } 
        public IRPSGridTextBox<ProductFormulaEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<ProductFormulaEntityView> ContentLot { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProductFormulaMaterialView : View
    {
        public ProductFormulaMaterialView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductFormulaMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductFormulaMaterialView,ProductFormulaEntityView>( this,Screen.ProductFormulaEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductFormulaMaterialView,ProductFormulaEntityView>( this,Screen.ProductFormulaEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductFormulaMaterialView,ProductFormulaEntityView>( this,Screen.ProductFormulaEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ProductFormulaMaterialView>("fe0060b2-f37f-4d8e-b938-9b62061908c4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductFormulaMaterialView>("689e08f7-2d7b-4101-82e3-3bcb1f2c20f3","","",false, this);
 
            MaterialType = RPSControlFactory.CreateRPSEnumComboBox<ProductFormulaMaterialView>("fc6114c8-e2e4-4256-85e1-251aa36d466e","","",true, this);
 
            QuantityType = RPSControlFactory.CreateRPSEnumComboBox<ProductFormulaMaterialView>("0af3c079-b572-44c7-991c-7b0169434d9e","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("da516320-76f7-4b2e-9345-ee2278fa13b0","","",true, this);
 
            ContentLot = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("9a3f1c14-780d-40fb-a2a3-1d1825e53cf2","","",false, this);
 
            QuantityPercent = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("ac2afb19-ef88-4745-8abc-126d62b338fb","","",true, this);
 
            QuantitySource = RPSControlFactory.CreateRPSEnumComboBox<ProductFormulaMaterialView>("0bac13f4-b0fa-4d0c-9e2a-40e810324816","","",true, this);
 
            QuantityFormula = RPSControlFactory.CreateRPSTextBox<ProductFormulaMaterialView>("403fac96-165a-40ab-a095-e802dd483517","","",false, this);
 
            IDCompensatedMaterial = RPSControlFactory.CreateRPSComboBox<ProductFormulaMaterialView>("d83b26dd-2f16-43c7-be37-ecdf5028082b","","",false, this);
 
            CompensatingFactor = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("a0106e89-c34b-42dc-be6d-8c0677d2fdcf","","",true, this);
 
            Quantity1 = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("563081b7-758e-453f-a919-d6c39abb3c97","","",true, this);
 
            ContentLot1 = RPSControlFactory.CreateRPSFormattedTextBox<ProductFormulaMaterialView>("6ff92b7a-b583-4229-8b36-ddbcfab326cc","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProductFormulaMaterialView>("de5062a1-b1c7-4acc-9d64-40f176e024eb","","",false, this);
 

        }
        public IRPSButton<ProductFormulaMaterialView> DeleteButton { get; set; } 
        public IRPSButton<ProductFormulaMaterialView,ProductFormulaEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductFormulaMaterialView,ProductFormulaEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductFormulaMaterialView,ProductFormulaEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ProductFormulaMaterialView> IDArticle { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> Description { get; set; } 
        public IRPSComboBox<ProductFormulaMaterialView> MaterialType { get; set; } 
        public IRPSComboBox<ProductFormulaMaterialView> QuantityType { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> Quantity { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> ContentLot { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> QuantityPercent { get; set; } 
        public IRPSComboBox<ProductFormulaMaterialView> QuantitySource { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> QuantityFormula { get; set; } 
        public IRPSComboBox<ProductFormulaMaterialView> IDCompensatedMaterial { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> CompensatingFactor { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> Quantity1 { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> ContentLot1 { get; set; } 
        public IRPSTextBox<ProductFormulaMaterialView> Notes { get; set; } 
        public ProductFormula Screen { get; set; }
        public ProductFormulaMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewProductFormulaVersionDialogDialogView : View
    {
        public NewProductFormulaVersionDialogDialogView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TargetVersion = RPSControlFactory.CreateRPSTextBox<NewProductFormulaVersionDialogDialogView>("ecdd8237-68bc-48d2-a130-654f26da68a2","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<NewProductFormulaVersionDialogDialogView>("c5277fe2-cd67-4fa1-ba3d-a13a5631a3a3","","",false, this);
 

        }
        public IRPSTextBox<NewProductFormulaVersionDialogDialogView> TargetVersion { get; set; } 
        public IRPSTextBox<NewProductFormulaVersionDialogDialogView> Date { get; set; } 
        public ProductFormula Screen { get; set; }
        public NewProductFormulaVersionDialogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyFromProductFormulaSourceChildDialogView : View
    {
        public CopyFromProductFormulaSourceChildDialogView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductFormula = RPSControlFactory.CreateRPSComboBox<CopyFromProductFormulaSourceChildDialogView>("1a8c8ab7-661d-4578-ba7b-b4d2497decf2","","",false, this);
 
            CodFormula = RPSControlFactory.CreateRPSTextBox<CopyFromProductFormulaSourceChildDialogView>("669bd6c5-663e-43e4-bcd2-f30e0535e39a","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CopyFromProductFormulaSourceChildDialogView>("4dcebbea-d51e-4932-8b07-e1dac43b5d72","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CopyFromProductFormulaSourceChildDialogView>("aa417474-2077-4668-9727-ad34ebfe8bdc","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<CopyFromProductFormulaSourceChildDialogView>("27a7d8c7-0b60-45c3-950a-2fe00fc2e3c6","","",false, this);
 

        }
        public IRPSComboBox<CopyFromProductFormulaSourceChildDialogView> ProductFormula { get; set; } 
        public IRPSTextBox<CopyFromProductFormulaSourceChildDialogView> CodFormula { get; set; } 
        public IRPSTextBox<CopyFromProductFormulaSourceChildDialogView> Version { get; set; } 
        public IRPSTextBox<CopyFromProductFormulaSourceChildDialogView> Description { get; set; } 
        public IRPSTextBox<CopyFromProductFormulaSourceChildDialogView> Date { get; set; } 
        public ProductFormula Screen { get; set; }
        public CopyFromProductFormulaSourceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SearchFormulaInStructureDialogDialogView : View
    {
        public SearchFormulaInStructureDialogDialogView(ProductFormula screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProductFormula = RPSControlFactory.CreateRPSComboBox<SearchFormulaInStructureDialogDialogView>("af89d7e7-53fd-41ff-b881-72e34bd951a5","","",false, this);
 
            AllVersions = RPSControlFactory.CreateRPSCheckBox<SearchFormulaInStructureDialogDialogView>("5901e21d-03c2-47d0-b3ea-62e4aaf42985","","",false, this);
 
            ExecuteGetStructureTaskWithFormula = RPSControlFactory.CreateRPSButton<SearchFormulaInStructureDialogDialogView>( "9f604357-fb18-4a18-8f07-f08821b3b369","","",this);
 
            ExecuteReplaceFormulaInTaskButton = RPSControlFactory.CreateRPSButton<SearchFormulaInStructureDialogDialogView>( "874998bc-10d3-4e63-b35f-0a03913c53ca","","",this);
 
            CollectionInit params_GetStructureTaskWithFormula = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3b52e6fd-bf4f-45ba-a220-5468cf0773a0",CSSSelectorGrid="",XPathGrid=""};
            GetStructureTaskWithFormula = RPSControlFactory.RPSCreateCollectionWithGrid<GetStructureTaskWithFormulaCollectionEditor<SearchFormulaInStructureDialogDialogView>,SearchFormulaInStructureDialogDialogView>( params_GetStructureTaskWithFormula,this);
 

        }
        public IRPSComboBox<SearchFormulaInStructureDialogDialogView> IDProductFormula { get; set; } 
        public IRPSCheckbox<SearchFormulaInStructureDialogDialogView> AllVersions { get; set; } 
        public IRPSButton<SearchFormulaInStructureDialogDialogView> ExecuteGetStructureTaskWithFormula { get; set; } 
        public IRPSButton<SearchFormulaInStructureDialogDialogView> ExecuteReplaceFormulaInTaskButton { get; set; } 
        public GetStructureTaskWithFormulaCollectionEditor<SearchFormulaInStructureDialogDialogView> GetStructureTaskWithFormula { get; set; } 
        public ProductFormula Screen { get; set; }
        public SearchFormulaInStructureDialogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetStructureTaskWithFormulaCollectionEditor<SearchFormulaInStructureDialogDialogView>:RPSCollectionEditor<SearchFormulaInStructureDialogDialogView> where SearchFormulaInStructureDialogDialogView : class, IView
    {
        public  GetStructureTaskWithFormulaGridView<SearchFormulaInStructureDialogDialogView> GridView {get;set;}
    }
    public partial class GetStructureTaskWithFormulaGridView <SearchFormulaInStructureDialogDialogView> :  RPSGridView<SearchFormulaInStructureDialogDialogView> where SearchFormulaInStructureDialogDialogView : class, IView
    {
        public GetStructureTaskWithFormulaGridView(SearchFormulaInStructureDialogDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSGridTextBox<SearchFormulaInStructureDialogDialogView>("","#3b52e6fd-bf4f-45ba-a220-5468cf0773a0 .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",false, this.CurrentView);
 
            Active = RPSControlFactory.CreateRPSGridCheckBox<SearchFormulaInStructureDialogDialogView>("","#3b52e6fd-bf4f-45ba-a220-5468cf0773a0 .ag-row[role='row']@ROWINDEX [col-id='cActive']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<SearchFormulaInStructureDialogDialogView>("","#3b52e6fd-bf4f-45ba-a220-5468cf0773a0 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            VersionFormula = RPSControlFactory.CreateRPSGridTextBox<SearchFormulaInStructureDialogDialogView>("","#3b52e6fd-bf4f-45ba-a220-5468cf0773a0 .ag-row[role='row']@ROWINDEX [col-id='cVersionFormula']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SearchFormulaInStructureDialogDialogView> Version { get; set; } 
        public IRPSGridCheckbox<SearchFormulaInStructureDialogDialogView> Active { get; set; } 
        public IRPSGridTextBox<SearchFormulaInStructureDialogDialogView> DateFrom { get; set; } 
        public IRPSGridTextBox<SearchFormulaInStructureDialogDialogView> VersionFormula { get; set; } 
                     
    }
 
    }
  
    

}