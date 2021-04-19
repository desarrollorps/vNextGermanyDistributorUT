    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "quality.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
            public ArticleDetailView ArticleDetailView {get; set; } 
    }
            
    public partial class ArticleCollectionView : View
    {
        public ArticleCollectionView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleCollectionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ae6867e1-db0b-497d-a79b-452592ea9d20",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleCollectionView,ArticleEntityView>( params_MainConsult,this,Screen.ArticleEntityView);
 

        }
        public IRPSButton<ArticleCollectionView,ArticleEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleCollectionView,ArticleEntityView> MainConsult { get; set; } 
        public Article Screen { get; set; }
        public ArticleCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleEntityView : View
    {
        public ArticleEntityView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("06d12bf0-216b-4d6f-bf68-4a24ed7551d0","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("00d39cd8-9ae4-4cad-b781-43cd5deafc2c","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("226ad104-9334-4387-8a9a-3bd85272aff1","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("b3373076-d203-4902-9d52-545f71b447f3","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("86ecb109-aff5-48f9-8f0b-52b300348a57","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("052622cc-d1fc-4ab8-82de-48ed95576b6c","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("26d656d3-7fbe-48f4-97af-96cbd6896fe2","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("faac67af-1ecc-4984-be86-2a80f21ca10a","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleEntityView>( "f22f80de-e188-434d-96b0-84af19088196","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleEntityView>( "844fbd05-a631-4df2-8ff0-20b603056a0e","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("44bce7f3-78dd-45e9-b858-4acb07a704b2","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("0418a8a6-397e-4dc6-8277-6d767791c520","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("49c097d5-77be-4eb2-8617-66d030a706ed","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("1b7ea4ed-4d08-4f4a-a443-90f5ddf28e62","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="823b963d-b1d7-4e85-afb5-8dc0c9af90b6",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleByLangs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="faf35585-917e-4f69-91c0-45db906722b8",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleDetails,this,Screen.ArticleByLangView);
 
            General = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='03074520-8f57-4147-9a88-18ee99ad1223']","",this);
 
            Language = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='d344af67-0197-4a74-80a5-190a7e5ce20c']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='622b7520-f455-4bf1-a3a2-389ce338d9fb']","",this);
 
            Notes1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='3d17e873-7a5b-4f4a-bcc0-83de1e1c8d71']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticle { get; set; } 
        public IRPSTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleEntityView> Quality { get; set; } 
        public IRPSOption<ArticleEntityView> Main { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDQualityPartType { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> General { get; set; } 
        public IRPSSection<ArticleEntityView> Language { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiaries { get; set; } 
        public IRPSSection<ArticleEntityView> Notes1 { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleByLangsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleByLangsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#823b963d-b1d7-4e85-afb5-8dc0c9af90b6 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#823b963d-b1d7-4e85-afb5-8dc0c9af90b6 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#823b963d-b1d7-4e85-afb5-8dc0c9af90b6 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleDetailsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleDetailsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            IDQualityPartType = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cIDQualityPartType']","",false, this.CurrentView);
 
            QualityOnReception = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cQualityOnReception']","",true, this.CurrentView);
 
            QualityMainWarehouse = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cQualityMainWarehouse']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#faf35585-917e-4f69-91c0-45db906722b8 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDQualityPartType { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> QualityOnReception { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> QualityMainWarehouse { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> PlanNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleByLangView : View
    {
        public ArticleByLangView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("49275b9a-86a3-4891-8844-c974df59224b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("42e277cc-9c9a-4ded-9b1a-abfefa8926ab","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("9ead682f-49dd-4db3-bb77-ee396a810cec","","",false, this);
 

        }
        public IRPSButton<ArticleByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleByLangView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleByLangView> Description { get; set; } 
        public IRPSTextBox<ArticleByLangView> TechnicalDescription { get; set; } 
        public Article Screen { get; set; }
        public ArticleByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleDetailView : View
    {
        public ArticleDetailView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("7f138c13-c3a2-4acb-b004-4d34511be1b4","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("91c7c2b1-5223-46b1-8594-f9dd23bf9813","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("93812689-b70d-4cb2-a77c-c76a943a817a","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("842c294b-a8bb-4657-8bf4-01d4fc8a0110","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "d3f4ce62-63d1-4477-8eb0-c92bbb9250ee","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "df806df2-ec31-43d8-8700-080983d12fd7","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("dc89dbc7-2e8e-431a-a2cf-fc8effa55678","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("1aec5797-0ef1-4970-8f21-7dea06533201","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleDetailView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleDetailView> Quality { get; set; } 
        public IRPSOption<ArticleDetailView> Main { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDQualityPartType { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}