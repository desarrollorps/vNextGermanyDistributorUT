    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BasoaAPIDocumentation
{
    //RPS VERSION 1.0.0.0
    public partial class BasoaAPIDocumentation:Screen
    {
        public BasoaAPIDocumentation():base()
        {
            this.URL = "general.basoaapidocumentation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BasoaAPIDocumentationQueryView  = new BasoaAPIDocumentationQueryView(this); 
            BlankPageView  = new BlankPageView(this); 
            TreeFilterChildDialogView  = new TreeFilterChildDialogView(this); 
            BasoaAPIDocumentationChildView  = new BasoaAPIDocumentationChildView(this); 
            BasoaAPIDocumentationQueryView.InitializeControls(); 
            BlankPageView.InitializeControls(); 
            TreeFilterChildDialogView.InitializeControls(); 
            BasoaAPIDocumentationChildView.InitializeControls(); 
           
        }
      
            public BasoaAPIDocumentationQueryView BasoaAPIDocumentationQueryView {get; set; } 
            public BlankPageView BlankPageView {get; set; } 
            public TreeFilterChildDialogView TreeFilterChildDialogView {get; set; } 
            public BasoaAPIDocumentationChildView BasoaAPIDocumentationChildView {get; set; } 
    }
            
    public partial class BasoaAPIDocumentationQueryView : View
    {
        public BasoaAPIDocumentationQueryView(BasoaAPIDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TreeFilterChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BasoaAPIDocumentationQueryView,TreeFilterChildDialogView>("cbe138e1-c557-4807-b0bb-e0037995db58","","", this,Screen.TreeFilterChildDialogView);
 
            TreeFilterChildNavigationCommandButton1 = RPSControlFactory.CreateRPSButtonToView<BasoaAPIDocumentationQueryView,TreeFilterChildDialogView>("49015551-d564-40be-88f9-71789a0f345b","","", this,Screen.TreeFilterChildDialogView);
 

        }
        public IRPSButton<BasoaAPIDocumentationQueryView,TreeFilterChildDialogView> TreeFilterChildNavigationCommandButton { get; set; } 
        public IRPSButton<BasoaAPIDocumentationQueryView,TreeFilterChildDialogView> TreeFilterChildNavigationCommandButton1 { get; set; } 
        public BasoaAPIDocumentation Screen { get; set; }
        public BasoaAPIDocumentationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BlankPageView : View
    {
        public BlankPageView(BasoaAPIDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public BasoaAPIDocumentation Screen { get; set; }
        public BlankPageView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TreeFilterChildDialogView : View
    {
        public TreeFilterChildDialogView(BasoaAPIDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SearchProperty = RPSControlFactory.CreateRPSTextBox<TreeFilterChildDialogView>("ce4e35cf-8606-41fa-9175-8ffbd86cf472","","",false, this);
 

        }
        public IRPSTextBox<TreeFilterChildDialogView> SearchProperty { get; set; } 
        public BasoaAPIDocumentation Screen { get; set; }
        public TreeFilterChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BasoaAPIDocumentationChildView : View
    {
        public BasoaAPIDocumentationChildView(BasoaAPIDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetBasoaAPIContractMethods = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            GetBasoaAPIContractMethods = RPSControlFactory.RPSCreateCollection<BasoaAPIDocumentationChildView>( params_GetBasoaAPIContractMethods,this);
 
            OverviewSection = RPSControlFactory.CreateRPSSection<BasoaAPIDocumentationChildView>( "","ul li[rpsid='d961238a-ff5f-412a-b866-a67eb61d4a06']","",this);
 
            CompleteViewSection = RPSControlFactory.CreateRPSSection<BasoaAPIDocumentationChildView>( "","ul li[rpsid='3f11ca6b-f855-4da7-b5fd-189a9770b9f4']","",this);
 

        }
        public IRPSCollectionEditor<BasoaAPIDocumentationChildView> GetBasoaAPIContractMethods { get; set; } 
        public IRPSSection<BasoaAPIDocumentationChildView> OverviewSection { get; set; } 
        public IRPSSection<BasoaAPIDocumentationChildView> CompleteViewSection { get; set; } 
        public BasoaAPIDocumentation Screen { get; set; }
        public BasoaAPIDocumentationChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}