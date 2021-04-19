    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CCHParameter
{
    //RPS VERSION 1.0.0.0
    public partial class CCHParameter:Screen
    {
        public CCHParameter():base()
        {
            this.URL = "general.cchparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CCHParameterView  = new CCHParameterView(this); 
            CCHParameterViewDetail  = new CCHParameterViewDetail(this); 
            CCHParameterByLangView  = new CCHParameterByLangView(this); 
            CCHParameterView.InitializeControls(); 
            CCHParameterViewDetail.InitializeControls(); 
            CCHParameterByLangView.InitializeControls(); 
           
        }
      
            public CCHParameterView CCHParameterView {get; set; } 
            public CCHParameterViewDetail CCHParameterViewDetail {get; set; } 
            public CCHParameterByLangView CCHParameterByLangView {get; set; } 
    }
            
    public partial class CCHParameterView : View
    {
        public CCHParameterView(CCHParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public CCHParameter Screen { get; set; }
        public CCHParameterView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CCHParameterViewDetail : View
    {
        public CCHParameterViewDetail(CCHParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CCHParameterViewDetail>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CCHParameterViewDetail>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CCHParameterViewDetail,CCHParameterView>( this,Screen.CCHParameterView);
 
            BackButton = RPSControlFactory.RPSBackButton<CCHParameterViewDetail,CCHParameterView>( this,Screen.CCHParameterView);
 
            LabelProperty1 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("c1de122f-000f-4ad4-9d29-8b1e1ddc7742","","",false, this);
 
            LabelProperty2 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("344e8591-59d5-4951-82a0-0574927fb21a","","",false, this);
 
            LabelProperty3 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("392a75b0-5ddc-4237-a1a2-78a80e365588","","",false, this);
 
            LabelProperty4 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("fdde26e3-b7be-4a53-9dd1-4e9f63bb7479","","",false, this);
 
            LabelProperty5 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("f998608a-0e93-4a45-b55e-5324802d9d33","","",false, this);
 
            LabelProperty6 = RPSControlFactory.CreateRPSTextBox<CCHParameterViewDetail>("01bdad0d-042c-4298-a43a-e88ee201b50b","","",false, this);
 
            CollectionInit params_CCHParameterByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9efafc4b-12e2-4282-a4c5-2212d4d2151c",CSSSelectorGrid="",XPathGrid=""};
            CCHParameterByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CCHParameterByLangsCollectionEditor<CCHParameterViewDetail,CCHParameterByLangView>,CCHParameterViewDetail,CCHParameterByLangView>( params_CCHParameterByLangs,this,Screen.CCHParameterByLangView);
 

        }
        public IRPSSaveButton<CCHParameterViewDetail> SaveButton { get; set; } 
        public IRPSButton<CCHParameterViewDetail> DeleteButton { get; set; } 
        public IRPSButton<CCHParameterViewDetail,CCHParameterView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CCHParameterViewDetail,CCHParameterView> BackButton { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty1 { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty2 { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty3 { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty4 { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty5 { get; set; } 
        public IRPSTextBox<CCHParameterViewDetail> LabelProperty6 { get; set; } 
        public CCHParameterByLangsCollectionEditor<CCHParameterViewDetail,CCHParameterByLangView> CCHParameterByLangs { get; set; } 
        public CCHParameter Screen { get; set; }
        public CCHParameterViewDetail Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CCHParameterByLangsCollectionEditor<CCHParameterViewDetail,CCHParameterByLangView>:RPSCollectionEditor<CCHParameterViewDetail,CCHParameterByLangView> where CCHParameterViewDetail : class, IView where CCHParameterByLangView : class, IView
    {
        public  CCHParameterByLangsGridView<CCHParameterViewDetail,CCHParameterByLangView> GridView {get;set;}
    }
    public partial class CCHParameterByLangsGridView <CCHParameterViewDetail,CCHParameterByLangView> :  RPSGridView<CCHParameterViewDetail,CCHParameterByLangView> where CCHParameterViewDetail : class, IView where CCHParameterByLangView : class, IView
    {
        public CCHParameterByLangsGridView(CCHParameterViewDetail currentView,CCHParameterByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            LabelProperty1 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty1']","",false, this.CurrentView);
 
            LabelProperty2 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty2']","",false, this.CurrentView);
 
            LabelProperty3 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty3']","",false, this.CurrentView);
 
            LabelProperty4 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty4']","",false, this.CurrentView);
 
            LabelProperty5 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty5']","",false, this.CurrentView);
 
            LabelProperty6 = RPSControlFactory.CreateRPSGridTextBox<CCHParameterViewDetail>("","#9efafc4b-12e2-4282-a4c5-2212d4d2151c .ag-row[role='row']@ROWINDEX [col-id='cLabelProperty6']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CCHParameterViewDetail> CodLanguage { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty1 { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty2 { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty3 { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty4 { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty5 { get; set; } 
        public IRPSGridTextBox<CCHParameterViewDetail> LabelProperty6 { get; set; } 
                     
    }
 
    }
  
            
    public partial class CCHParameterByLangView : View
    {
        public CCHParameterByLangView(CCHParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CCHParameterByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CCHParameterByLangView,CCHParameterViewDetail>( this,Screen.CCHParameterViewDetail);
 
            BackButton = RPSControlFactory.RPSBackButton<CCHParameterByLangView,CCHParameterViewDetail>( this,Screen.CCHParameterViewDetail);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CCHParameterByLangView,CCHParameterViewDetail>( this,Screen.CCHParameterViewDetail);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CCHParameterByLangView>("33f6d3de-763b-4cca-9794-bff9b4821d40","","",true, this);
 
            LabelProperty1 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("229f22dc-978b-4fba-b70b-dd08a08b8504","","",false, this);
 
            LabelProperty2 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("c41b335b-c2bc-47b8-a55e-5ba799598aca","","",false, this);
 
            LabelProperty3 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("b4bed9cd-5e19-43fb-99d9-1eb69a67d92e","","",false, this);
 
            LabelProperty4 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("43fa6058-95fb-488c-aa43-861a6917fb15","","",false, this);
 
            LabelProperty5 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("850b588f-94c7-4f8e-b3fc-8dcba63e91fa","","",false, this);
 
            LabelProperty6 = RPSControlFactory.CreateRPSTextBox<CCHParameterByLangView>("b954d735-189b-4865-8309-19d57678961f","","",false, this);
 

        }
        public IRPSButton<CCHParameterByLangView> DeleteButton { get; set; } 
        public IRPSButton<CCHParameterByLangView,CCHParameterViewDetail> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CCHParameterByLangView,CCHParameterViewDetail> BackButton { get; set; } 
        public IRPSAcceptButton<CCHParameterByLangView,CCHParameterViewDetail> AcceptButton { get; set; } 
        public IRPSComboBox<CCHParameterByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty1 { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty2 { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty3 { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty4 { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty5 { get; set; } 
        public IRPSTextBox<CCHParameterByLangView> LabelProperty6 { get; set; } 
        public CCHParameter Screen { get; set; }
        public CCHParameterByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}