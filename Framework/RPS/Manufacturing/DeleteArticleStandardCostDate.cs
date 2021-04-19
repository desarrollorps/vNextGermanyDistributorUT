    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.DeleteArticleStandardCostDate
{
    //RPS VERSION 1.0.0.0
    public partial class DeleteArticleStandardCostDate:Screen
    {
        public DeleteArticleStandardCostDate():base()
        {
            this.URL = "manufacturing.deletearticlestandardcostdate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeleteArticleStandardCostDateView  = new DeleteArticleStandardCostDateView(this); 
            DeleteArticleStandardCostDateView.InitializeControls(); 
           
        }
      
            public DeleteArticleStandardCostDateView DeleteArticleStandardCostDateView {get; set; } 
    }
            
    public partial class DeleteArticleStandardCostDateView : View
    {
        public DeleteArticleStandardCostDateView(DeleteArticleStandardCostDate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<DeleteArticleStandardCostDateView>("7d140173-7ffc-41cd-aecb-446b18ee83cf","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<DeleteArticleStandardCostDateView>("74b11f3d-6140-4113-bb01-2934c731eb97","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DeleteArticleStandardCostDateView>("37bb8b0f-e40b-4b17-a02b-2a90b110c687","","",false, this);
 
            ExecuteDelete = RPSControlFactory.CreateRPSButton<DeleteArticleStandardCostDateView>( "9aff16c3-1a9a-4cd6-a010-c026a8012b7d","","",this);
 

        }
        public IRPSComboBox<DeleteArticleStandardCostDateView> Site { get; set; } 
        public IRPSCollectionComboBox<DeleteArticleStandardCostDateView> Article { get; set; } 
        public IRPSTextBox<DeleteArticleStandardCostDateView> DateTo { get; set; } 
        public IRPSButton<DeleteArticleStandardCostDateView> ExecuteDelete { get; set; } 
        public DeleteArticleStandardCostDate Screen { get; set; }
        public DeleteArticleStandardCostDateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}