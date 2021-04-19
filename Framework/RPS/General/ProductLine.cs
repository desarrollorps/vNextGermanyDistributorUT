    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ProductLine
{
    //RPS VERSION 1.0.0.0
    public partial class ProductLine:Screen
    {
        public ProductLine():base()
        {
            this.URL = "general.productline";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductLineCollectionView  = new ProductLineCollectionView(this); 
            ProductLineEntityView  = new ProductLineEntityView(this); 
            ProductFamilyView  = new ProductFamilyView(this); 
            ProductSubFamilyView  = new ProductSubFamilyView(this); 
            ProductLineByLangView  = new ProductLineByLangView(this); 
            ProductFamilyByLangView  = new ProductFamilyByLangView(this); 
            ProductSubFamilyByLangView  = new ProductSubFamilyByLangView(this); 
            ProductLineCollectionView.InitializeControls(); 
            ProductLineEntityView.InitializeControls(); 
            ProductFamilyView.InitializeControls(); 
            ProductSubFamilyView.InitializeControls(); 
            ProductLineByLangView.InitializeControls(); 
            ProductFamilyByLangView.InitializeControls(); 
            ProductSubFamilyByLangView.InitializeControls(); 
           
        }
      
            public ProductLineCollectionView ProductLineCollectionView {get; set; } 
            public ProductLineEntityView ProductLineEntityView {get; set; } 
            public ProductFamilyView ProductFamilyView {get; set; } 
            public ProductSubFamilyView ProductSubFamilyView {get; set; } 
            public ProductLineByLangView ProductLineByLangView {get; set; } 
            public ProductFamilyByLangView ProductFamilyByLangView {get; set; } 
            public ProductSubFamilyByLangView ProductSubFamilyByLangView {get; set; } 
    }
            
    public partial class ProductLineCollectionView : View
    {
        public ProductLineCollectionView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProductLineCollectionView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "43557ae1-2459-4eb8-b5c4-e565fb8d5fdf",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProductLineCollectionView,ProductLineEntityView>( params_MainConsult,this,Screen.ProductLineEntityView);
 

        }
        public IRPSButton<ProductLineCollectionView,ProductLineEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ProductLineCollectionView,ProductLineEntityView> MainConsult { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductLineCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductLineEntityView : View
    {
        public ProductLineEntityView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProductLineEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductLineEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductLineEntityView,ProductLineCollectionView>( this,Screen.ProductLineCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductLineEntityView,ProductLineCollectionView>( this,Screen.ProductLineCollectionView);
 
            CodProductLine = RPSControlFactory.CreateRPSTextBox<ProductLineEntityView>("d2957eab-7bc3-441c-bb3f-76d7319f4081","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductLineEntityView>("ce51dcc7-7eba-4085-ab17-887912ecf022","","",false, this);
 
            GroupCode = RPSControlFactory.CreateRPSTextBox<ProductLineEntityView>("400156ea-22a1-456c-8102-197a15401d5d","","",false, this);
 
            DescGroup = RPSControlFactory.CreateRPSTextBox<ProductLineEntityView>("475c928c-2d38-4e8e-ae05-02eba552b54d","","",false, this);
 
            CollectionInit params_ProductFamilys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="743cddfc-4b30-463c-bce0-34638fd72591",CSSSelectorGrid="",XPathGrid=""};
            ProductFamilys = RPSControlFactory.RPSCreateCollectionWithGrid<ProductFamilysCollectionEditor<ProductLineEntityView,ProductFamilyView>,ProductLineEntityView,ProductFamilyView>( params_ProductFamilys,this,Screen.ProductFamilyView);
 
            CollectionInit params_ProductLineByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="48f82ab8-51d1-4eab-9118-f935213a239b",CSSSelectorGrid="",XPathGrid=""};
            ProductLineByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ProductLineByLangsCollectionEditor<ProductLineEntityView,ProductFamilyView>,ProductLineEntityView,ProductFamilyView>( params_ProductLineByLangs,this,Screen.ProductFamilyView);
 
            Section = RPSControlFactory.CreateRPSSection<ProductLineEntityView>( "","ul li[rpsid='e4db280f-6710-4b4e-8d23-ddbd48fd745d']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ProductLineEntityView>( "","ul li[rpsid='34674f3f-0e0c-4f1d-b11a-18c2736cfb06']","",this);
 

        }
        public IRPSSaveButton<ProductLineEntityView> SaveButton { get; set; } 
        public IRPSButton<ProductLineEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProductLineEntityView,ProductLineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductLineEntityView,ProductLineCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProductLineEntityView> CodProductLine { get; set; } 
        public IRPSTextBox<ProductLineEntityView> Description { get; set; } 
        public IRPSTextBox<ProductLineEntityView> GroupCode { get; set; } 
        public IRPSTextBox<ProductLineEntityView> DescGroup { get; set; } 
        public ProductFamilysCollectionEditor<ProductLineEntityView,ProductFamilyView> ProductFamilys { get; set; } 
        public ProductLineByLangsCollectionEditor<ProductLineEntityView,ProductFamilyView> ProductLineByLangs { get; set; } 
        public IRPSSection<ProductLineEntityView> Section { get; set; } 
        public IRPSSection<ProductLineEntityView> Section1 { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductLineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductFamilysCollectionEditor<ProductLineEntityView,ProductFamilyView>:RPSCollectionEditor<ProductLineEntityView,ProductFamilyView> where ProductLineEntityView : class, IView where ProductFamilyView : class, IView
    {
        public  ProductFamilysGridView<ProductLineEntityView,ProductFamilyView> GridView {get;set;}
    }
    public partial class ProductFamilysGridView <ProductLineEntityView,ProductFamilyView> :  RPSGridView<ProductLineEntityView,ProductFamilyView> where ProductLineEntityView : class, IView where ProductFamilyView : class, IView
    {
        public ProductFamilysGridView(ProductLineEntityView currentView,ProductFamilyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodProductFamily = RPSControlFactory.CreateRPSGridTextBox<ProductLineEntityView>("","#743cddfc-4b30-463c-bce0-34638fd72591 .ag-row[role='row']@ROWINDEX [col-id='cCodProductFamily']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductLineEntityView>("","#743cddfc-4b30-463c-bce0-34638fd72591 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProductLineEntityView> CodProductFamily { get; set; } 
        public IRPSGridTextBox<ProductLineEntityView> Description { get; set; } 
                     
    }
 
        public partial class ProductLineByLangsCollectionEditor<ProductLineEntityView,ProductFamilyView>:RPSCollectionEditor<ProductLineEntityView,ProductFamilyView> where ProductLineEntityView : class, IView where ProductFamilyView : class, IView
    {
        public  ProductLineByLangsGridView<ProductLineEntityView,ProductFamilyView> GridView {get;set;}
    }
    public partial class ProductLineByLangsGridView <ProductLineEntityView,ProductFamilyView> :  RPSGridView<ProductLineEntityView,ProductFamilyView> where ProductLineEntityView : class, IView where ProductFamilyView : class, IView
    {
        public ProductLineByLangsGridView(ProductLineEntityView currentView,ProductFamilyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ProductLineEntityView>("","#48f82ab8-51d1-4eab-9118-f935213a239b .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductLineEntityView>("","#48f82ab8-51d1-4eab-9118-f935213a239b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProductLineEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ProductLineEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProductFamilyView : View
    {
        public ProductFamilyView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductFamilyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductFamilyView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductFamilyView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductFamilyView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            CodProductFamily = RPSControlFactory.CreateRPSTextBox<ProductFamilyView>("219babfb-6c57-4efa-9c05-1ce11a07c9f7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductFamilyView>("38b70990-d734-4c1b-8815-c63551c9904c","","",false, this);
 
            CollectionInit params_ProductSubFamilys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f0ab5c5-ecc0-4b30-af38-c4949e7e3c5c",CSSSelectorGrid="",XPathGrid=""};
            ProductSubFamilys = RPSControlFactory.RPSCreateCollectionWithGrid<ProductSubFamilysCollectionEditor<ProductFamilyView,ProductSubFamilyView>,ProductFamilyView,ProductSubFamilyView>( params_ProductSubFamilys,this,Screen.ProductSubFamilyView);
 
            CollectionInit params_ProductFamilyByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dfbc1718-d548-4037-9cce-b4f4d7551370",CSSSelectorGrid="",XPathGrid=""};
            ProductFamilyByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ProductFamilyByLangsCollectionEditor<ProductFamilyView,ProductSubFamilyView>,ProductFamilyView,ProductSubFamilyView>( params_ProductFamilyByLangs,this,Screen.ProductSubFamilyView);
 
            Section = RPSControlFactory.CreateRPSSection<ProductFamilyView>( "","ul li[rpsid='2643914c-9dbd-47ab-bc5f-08e076b9b693']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ProductFamilyView>( "","ul li[rpsid='a66605a2-3108-4836-abb7-2c16c2bfe073']","",this);
 

        }
        public IRPSButton<ProductFamilyView> DeleteButton { get; set; } 
        public IRPSButton<ProductFamilyView,ProductLineEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductFamilyView,ProductLineEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductFamilyView,ProductLineEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProductFamilyView> CodProductFamily { get; set; } 
        public IRPSTextBox<ProductFamilyView> Description { get; set; } 
        public ProductSubFamilysCollectionEditor<ProductFamilyView,ProductSubFamilyView> ProductSubFamilys { get; set; } 
        public ProductFamilyByLangsCollectionEditor<ProductFamilyView,ProductSubFamilyView> ProductFamilyByLangs { get; set; } 
        public IRPSSection<ProductFamilyView> Section { get; set; } 
        public IRPSSection<ProductFamilyView> Section1 { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductFamilyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductSubFamilysCollectionEditor<ProductFamilyView,ProductSubFamilyView>:RPSCollectionEditor<ProductFamilyView,ProductSubFamilyView> where ProductFamilyView : class, IView where ProductSubFamilyView : class, IView
    {
        public  ProductSubFamilysGridView<ProductFamilyView,ProductSubFamilyView> GridView {get;set;}
    }
    public partial class ProductSubFamilysGridView <ProductFamilyView,ProductSubFamilyView> :  RPSGridView<ProductFamilyView,ProductSubFamilyView> where ProductFamilyView : class, IView where ProductSubFamilyView : class, IView
    {
        public ProductSubFamilysGridView(ProductFamilyView currentView,ProductSubFamilyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodProductSubFamily = RPSControlFactory.CreateRPSGridTextBox<ProductFamilyView>("","#5f0ab5c5-ecc0-4b30-af38-c4949e7e3c5c .ag-row[role='row']@ROWINDEX [col-id='cCodProductSubFamily']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductFamilyView>("","#5f0ab5c5-ecc0-4b30-af38-c4949e7e3c5c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProductFamilyView> CodProductSubFamily { get; set; } 
        public IRPSGridTextBox<ProductFamilyView> Description { get; set; } 
                     
    }
 
        public partial class ProductFamilyByLangsCollectionEditor<ProductFamilyView,ProductSubFamilyView>:RPSCollectionEditor<ProductFamilyView,ProductSubFamilyView> where ProductFamilyView : class, IView where ProductSubFamilyView : class, IView
    {
        public  ProductFamilyByLangsGridView<ProductFamilyView,ProductSubFamilyView> GridView {get;set;}
    }
    public partial class ProductFamilyByLangsGridView <ProductFamilyView,ProductSubFamilyView> :  RPSGridView<ProductFamilyView,ProductSubFamilyView> where ProductFamilyView : class, IView where ProductSubFamilyView : class, IView
    {
        public ProductFamilyByLangsGridView(ProductFamilyView currentView,ProductSubFamilyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ProductFamilyView>("","#dfbc1718-d548-4037-9cce-b4f4d7551370 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductFamilyView>("","#dfbc1718-d548-4037-9cce-b4f4d7551370 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProductFamilyView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ProductFamilyView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProductSubFamilyView : View
    {
        public ProductSubFamilyView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductSubFamilyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductSubFamilyView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductSubFamilyView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductSubFamilyView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            CodProductSubFamily = RPSControlFactory.CreateRPSTextBox<ProductSubFamilyView>("8fa06b7f-1827-4afd-a01b-f02518ae5d3e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductSubFamilyView>("371fceeb-e8fd-4066-a672-a183e14b1752","","",false, this);
 
            CollectionInit params_ProductSubFamilyByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="27708f2d-e7b2-4076-966e-6cc4d81a25bf",CSSSelectorGrid="",XPathGrid=""};
            ProductSubFamilyByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ProductSubFamilyByLangsCollectionEditor<ProductSubFamilyView,ProductSubFamilyByLangView>,ProductSubFamilyView,ProductSubFamilyByLangView>( params_ProductSubFamilyByLangs,this,Screen.ProductSubFamilyByLangView);
 

        }
        public IRPSButton<ProductSubFamilyView> DeleteButton { get; set; } 
        public IRPSButton<ProductSubFamilyView,ProductFamilyView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductSubFamilyView,ProductFamilyView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductSubFamilyView,ProductFamilyView> AcceptButton { get; set; } 
        public IRPSTextBox<ProductSubFamilyView> CodProductSubFamily { get; set; } 
        public IRPSTextBox<ProductSubFamilyView> Description { get; set; } 
        public ProductSubFamilyByLangsCollectionEditor<ProductSubFamilyView,ProductSubFamilyByLangView> ProductSubFamilyByLangs { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductSubFamilyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductSubFamilyByLangsCollectionEditor<ProductSubFamilyView,ProductSubFamilyByLangView>:RPSCollectionEditor<ProductSubFamilyView,ProductSubFamilyByLangView> where ProductSubFamilyView : class, IView where ProductSubFamilyByLangView : class, IView
    {
        public  ProductSubFamilyByLangsGridView<ProductSubFamilyView,ProductSubFamilyByLangView> GridView {get;set;}
    }
    public partial class ProductSubFamilyByLangsGridView <ProductSubFamilyView,ProductSubFamilyByLangView> :  RPSGridView<ProductSubFamilyView,ProductSubFamilyByLangView> where ProductSubFamilyView : class, IView where ProductSubFamilyByLangView : class, IView
    {
        public ProductSubFamilyByLangsGridView(ProductSubFamilyView currentView,ProductSubFamilyByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ProductSubFamilyView>("","#27708f2d-e7b2-4076-966e-6cc4d81a25bf .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProductSubFamilyView>("","#27708f2d-e7b2-4076-966e-6cc4d81a25bf .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProductSubFamilyView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ProductSubFamilyView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProductLineByLangView : View
    {
        public ProductLineByLangView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductLineByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductLineByLangView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductLineByLangView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductLineByLangView,ProductLineEntityView>( this,Screen.ProductLineEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ProductLineByLangView>("fbd8be97-2e5d-4d9b-8d45-c0ebd92f0004","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductLineByLangView>("888d6914-8b0c-46b1-8326-8c48dd9dee46","","",false, this);
 

        }
        public IRPSButton<ProductLineByLangView> DeleteButton { get; set; } 
        public IRPSButton<ProductLineByLangView,ProductLineEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductLineByLangView,ProductLineEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductLineByLangView,ProductLineEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ProductLineByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ProductLineByLangView> Description { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductLineByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductFamilyByLangView : View
    {
        public ProductFamilyByLangView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductFamilyByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductFamilyByLangView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductFamilyByLangView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductFamilyByLangView,ProductFamilyView>( this,Screen.ProductFamilyView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ProductFamilyByLangView>("3a5c38b4-b71e-4610-b002-41b3e1081ae4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductFamilyByLangView>("a49995ee-f5a9-47b0-8b20-674d8ed8c216","","",false, this);
 

        }
        public IRPSButton<ProductFamilyByLangView> DeleteButton { get; set; } 
        public IRPSButton<ProductFamilyByLangView,ProductFamilyView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductFamilyByLangView,ProductFamilyView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductFamilyByLangView,ProductFamilyView> AcceptButton { get; set; } 
        public IRPSComboBox<ProductFamilyByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ProductFamilyByLangView> Description { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductFamilyByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProductSubFamilyByLangView : View
    {
        public ProductSubFamilyByLangView(ProductLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProductSubFamilyByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProductSubFamilyByLangView,ProductSubFamilyView>( this,Screen.ProductSubFamilyView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProductSubFamilyByLangView,ProductSubFamilyView>( this,Screen.ProductSubFamilyView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProductSubFamilyByLangView,ProductSubFamilyView>( this,Screen.ProductSubFamilyView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ProductSubFamilyByLangView>("b94d9565-c2fb-4118-82b7-f8f3bf275b00","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProductSubFamilyByLangView>("54ed20b9-5312-431f-8d05-5b50820422b5","","",false, this);
 

        }
        public IRPSButton<ProductSubFamilyByLangView> DeleteButton { get; set; } 
        public IRPSButton<ProductSubFamilyByLangView,ProductSubFamilyView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProductSubFamilyByLangView,ProductSubFamilyView> BackButton { get; set; } 
        public IRPSAcceptButton<ProductSubFamilyByLangView,ProductSubFamilyView> AcceptButton { get; set; } 
        public IRPSComboBox<ProductSubFamilyByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ProductSubFamilyByLangView> Description { get; set; } 
        public ProductLine Screen { get; set; }
        public ProductSubFamilyByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}