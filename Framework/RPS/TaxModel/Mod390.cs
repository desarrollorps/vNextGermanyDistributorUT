    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod390
{
    //RPS VERSION 1.0.0.0
    public partial class Mod390:Screen
    {
        public Mod390():base()
        {
            this.URL = "taxmodel.mod390";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod390View  = new Mod390View(this); 
            Mod390ManualDialogView  = new Mod390ManualDialogView(this); 
            Mod390View.InitializeControls(); 
            Mod390ManualDialogView.InitializeControls(); 
           
        }
      
            public Mod390View Mod390View {get; set; } 
            public Mod390ManualDialogView Mod390ManualDialogView {get; set; } 
    }
            
    public partial class Mod390View : View
    {
        public Mod390View(Mod390 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod390View>("18233645-e989-471e-84a0-b99f3baf1f9a","","",true, this);
 
            ExecuteGetMod390Data = RPSControlFactory.CreateRPSButton<Mod390View>( "f0de1683-ed95-43fe-9bde-0723154c32ee","","",this);
 
            DeclarationType = RPSControlFactory.CreateRPSEnumComboBox<Mod390View>("94bd109e-0d75-406f-9be2-da148d4643fc","","",true, this);
 
            IsSubstitutiveConcurso = RPSControlFactory.CreateRPSCheckBox<Mod390View>("f96a1993-e91e-4c5c-8f95-ab4797c9e6af","","",false, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod390View>("0416838d-683b-4da8-8c9e-2656e99178ba","","",false, this);
 
            Actividad1 = RPSControlFactory.CreateRPSTextBox<Mod390View>("0cac7d63-2be9-4c6a-929f-2724a2faee8b","","",false, this);
 
            EpigrafeIAE1 = RPSControlFactory.CreateRPSTextBox<Mod390View>("850b0423-aef4-4de5-b1c6-bba666f1f2ed","","",false, this);
 
            Actividad2 = RPSControlFactory.CreateRPSTextBox<Mod390View>("22cadfdc-048d-486b-b525-99c8643c3e31","","",false, this);
 
            EpigrafeIAE2 = RPSControlFactory.CreateRPSTextBox<Mod390View>("f2230d77-5c16-48f1-ba8d-38ab17060f40","","",false, this);
 
            ExecuteGenerateMod390Button = RPSControlFactory.CreateRPSButton<Mod390View>( "1601a9da-dfaf-46ec-8504-fc876bbeed53","","",this);
 
            Mod390ManualNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<Mod390View,Mod390ManualDialogView>("3c8a80dd-6f3a-4355-97b0-15e31b81237f","","", this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage99 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c920475f-97f9-421d-bc2e-c26dae46734e",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage99 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage99CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage99,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPageOther = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e57a8372-452b-462a-97c3-00fdcbfdaf6e",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPageOther = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPageOtherCollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPageOther,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage5 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db5b6495-5dbb-4d45-a320-8f3faefe2425",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage5 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage5CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage5,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage6 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9addf59a-53ac-4653-8798-64f8b31b4078",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage6 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage6CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage6,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage8 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="94996a5d-a806-4086-8436-01b848f7dcf9",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage8 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage8CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage8,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage9 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="02ac5862-2c99-416c-909b-6b8e702487f2",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage9 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage9CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage9,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage10 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6996a0f-486d-4b7c-bed8-afd2e0a84155",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage10 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage10CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage10,this,Screen.Mod390ManualDialogView);
 
            CollectionInit params_GetMod390DataPage11 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6f0e6c95-9b2c-4aee-b38a-20d06dd6d567",CSSSelectorGrid="",XPathGrid=""};
            GetMod390DataPage11 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod390DataPage11CollectionEditor<Mod390View,Mod390ManualDialogView>,Mod390View,Mod390ManualDialogView>( params_GetMod390DataPage11,this,Screen.Mod390ManualDialogView);
 
            Section = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='4e435095-0f2b-4257-b047-fc93fd0e5e6d']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='923ad95d-b009-4511-8b0d-36aa119bf5b3']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='be722ad7-399d-450b-bf93-ffaf8ec58053']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='7aef9ca3-dc5d-4fac-8681-7bef85cf50fe']","",this);
 
            Section4 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='7bcd5ca9-f152-4869-b16d-08f82bacddd3']","",this);
 
            Section5 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='09cddc38-3800-4918-b941-3fa709cba514']","",this);
 
            Section6 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='09b64332-f38a-4338-ad8c-13edc722609e']","",this);
 
            Section7 = RPSControlFactory.CreateRPSSection<Mod390View>( "","ul li[rpsid='4cc577ba-1cdf-4b6e-9b19-795fb35647a9']","",this);
 

        }
        public IRPSTextBox<Mod390View> Exercise { get; set; } 
        public IRPSButton<Mod390View> ExecuteGetMod390Data { get; set; } 
        public IRPSComboBox<Mod390View> DeclarationType { get; set; } 
        public IRPSCheckbox<Mod390View> IsSubstitutiveConcurso { get; set; } 
        public IRPSTextBox<Mod390View> NumJustificanteAnterior { get; set; } 
        public IRPSTextBox<Mod390View> Actividad1 { get; set; } 
        public IRPSTextBox<Mod390View> EpigrafeIAE1 { get; set; } 
        public IRPSTextBox<Mod390View> Actividad2 { get; set; } 
        public IRPSTextBox<Mod390View> EpigrafeIAE2 { get; set; } 
        public IRPSButton<Mod390View> ExecuteGenerateMod390Button { get; set; } 
        public IRPSButton<Mod390View,Mod390ManualDialogView> Mod390ManualNavigationCommandButton { get; set; } 
        public GetMod390DataPage99CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage99 { get; set; } 
        public GetMod390DataPageOtherCollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPageOther { get; set; } 
        public GetMod390DataPage5CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage5 { get; set; } 
        public GetMod390DataPage6CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage6 { get; set; } 
        public GetMod390DataPage8CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage8 { get; set; } 
        public GetMod390DataPage9CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage9 { get; set; } 
        public GetMod390DataPage10CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage10 { get; set; } 
        public GetMod390DataPage11CollectionEditor<Mod390View,Mod390ManualDialogView> GetMod390DataPage11 { get; set; } 
        public IRPSSection<Mod390View> Section { get; set; } 
        public IRPSSection<Mod390View> Section1 { get; set; } 
        public IRPSSection<Mod390View> Section2 { get; set; } 
        public IRPSSection<Mod390View> Section3 { get; set; } 
        public IRPSSection<Mod390View> Section4 { get; set; } 
        public IRPSSection<Mod390View> Section5 { get; set; } 
        public IRPSSection<Mod390View> Section6 { get; set; } 
        public IRPSSection<Mod390View> Section7 { get; set; } 
        public Mod390 Screen { get; set; }
        public Mod390View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod390DataPage99CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage99GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage99GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage99GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#c920475f-97f9-421d-bc2e-c26dae46734e .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#c920475f-97f9-421d-bc2e-c26dae46734e .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#c920475f-97f9-421d-bc2e-c26dae46734e .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#c920475f-97f9-421d-bc2e-c26dae46734e .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPageOtherCollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPageOtherGridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPageOtherGridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPageOtherGridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#e57a8372-452b-462a-97c3-00fdcbfdaf6e .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#e57a8372-452b-462a-97c3-00fdcbfdaf6e .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            Other = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#e57a8372-452b-462a-97c3-00fdcbfdaf6e .ag-row[role='row']@ROWINDEX [col-id='cOther']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> Other { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage5CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage5GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage5GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage5GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#db5b6495-5dbb-4d45-a320-8f3faefe2425 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#db5b6495-5dbb-4d45-a320-8f3faefe2425 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#db5b6495-5dbb-4d45-a320-8f3faefe2425 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#db5b6495-5dbb-4d45-a320-8f3faefe2425 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage6CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage6GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage6GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage6GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#9addf59a-53ac-4653-8798-64f8b31b4078 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#9addf59a-53ac-4653-8798-64f8b31b4078 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#9addf59a-53ac-4653-8798-64f8b31b4078 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#9addf59a-53ac-4653-8798-64f8b31b4078 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage8CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage8GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage8GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage8GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#94996a5d-a806-4086-8436-01b848f7dcf9 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#94996a5d-a806-4086-8436-01b848f7dcf9 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#94996a5d-a806-4086-8436-01b848f7dcf9 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#94996a5d-a806-4086-8436-01b848f7dcf9 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage9CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage9GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage9GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage9GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#02ac5862-2c99-416c-909b-6b8e702487f2 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#02ac5862-2c99-416c-909b-6b8e702487f2 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#02ac5862-2c99-416c-909b-6b8e702487f2 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#02ac5862-2c99-416c-909b-6b8e702487f2 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage10CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage10GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage10GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage10GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#c6996a0f-486d-4b7c-bed8-afd2e0a84155 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390View>("","#c6996a0f-486d-4b7c-bed8-afd2e0a84155 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#c6996a0f-486d-4b7c-bed8-afd2e0a84155 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#c6996a0f-486d-4b7c-bed8-afd2e0a84155 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod390DataPage11CollectionEditor<Mod390View,Mod390ManualDialogView>:RPSCollectionEditor<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public  GetMod390DataPage11GridView<Mod390View,Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod390DataPage11GridView <Mod390View,Mod390ManualDialogView> :  RPSGridView<Mod390View,Mod390ManualDialogView> where Mod390View : class, IView where Mod390ManualDialogView : class, IView
    {
        public GetMod390DataPage11GridView(Mod390View currentView,Mod390ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390View>("","#6f0e6c95-9b2c-4aee-b38a-20d06dd6d567 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#6f0e6c95-9b2c-4aee-b38a-20d06dd6d567 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#6f0e6c95-9b2c-4aee-b38a-20d06dd6d567 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390View>("","#6f0e6c95-9b2c-4aee-b38a-20d06dd6d567 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390View> Order { get; set; } 
        public IRPSGridTextBox<Mod390View> Text { get; set; } 
        public IRPSGridTextBox<Mod390View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390View> AmountCell { get; set; } 
                     
    }
 
    }
  
            
    public partial class Mod390ManualDialogView : View
    {
        public Mod390ManualDialogView(Mod390 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ParentExercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("b9b0cc0e-3dbb-4aa5-8cee-0d0b844cb003","","",false, this);
 
            ExecuteMod390GetLastOtherDetaOrDefault = RPSControlFactory.CreateRPSButton<Mod390ManualDialogView>( "9bef8892-00f4-4c28-b9d8-c845a92362ac","","",this);
 
            ExecuteMod390GetDefaultOtherData = RPSControlFactory.CreateRPSButton<Mod390ManualDialogView>( "36524b72-09a4-45db-b210-f882f3f18bb9","","",this);
 
            IsMensual = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("9bb5f920-8be6-45f9-86c5-fc4cc189714f","","",false, this);
 
            IsConcurso = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("b42470f7-573c-4efb-86cd-9bece4019130","","",false, this);
 
            Is347 = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("6318d9f2-d380-4549-8ebc-dda02c80e65a","","",false, this);
 
            PorcEstatal = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("8a1ea994-7c4f-400e-859c-9bc20268425a","","",false, this);
 
            PorcVI = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("894772bb-1cc6-4b63-911e-68533949ae60","","",false, this);
 
            PorcSS = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("30b59842-5986-47be-8c83-98bf7248f473","","",false, this);
 
            PorcBI = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("ab318795-12cd-48fe-9631-e496c1eb945c","","",false, this);
 
            PorcNAVARRA = RPSControlFactory.CreateRPSFormattedTextBox<Mod390ManualDialogView>("d2aa1913-fb1c-4cb3-8c59-b7a941d03b55","","",false, this);
 
            IsCaja_Ventas = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("0553b949-952f-4786-bdea-b3a846c9c9f5","","",false, this);
 
            IsCaja_Compras = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("a58dc372-6152-42fe-a4c1-f50c027a63d3","","",false, this);
 
            IsREGE = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("54594707-b5a3-40d5-933d-3fbe8df4033e","","",false, this);
 
            StrREGE_Grupo = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("7622242c-03b5-4ef2-85eb-da1507a9d4b0","","",false, this);
 
            IsREGE_Dominante = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("b2af5013-3a83-469b-80e7-ce6dd77f9ea1","","",false, this);
 
            IsREGE_Dependiente = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("72e7845c-1e3f-4fe1-be72-38b0dcde4804","","",false, this);
 
            IsREGE_4T = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("986dac28-a0f6-43c5-9e7f-7b4fc035b04c","","",false, this);
 
            StrREGE_NIF = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("3625d394-af0e-43b0-92f8-2f8932fe6cbb","","",false, this);
 
            IsREGE_163 = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("4c9c870c-3b96-480d-aebc-ac438d7d3778","","",false, this);
 
            IsConjunta = RPSControlFactory.CreateRPSCheckBox<Mod390ManualDialogView>("35014509-ce36-4af2-b714-de33c6579c54","","",false, this);
 
            StrConjunta_NIF = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("747e46b9-8424-406d-b6cc-ce12d7c67824","","",false, this);
 
            StrConjunta_Razon = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("2552e49a-eb43-4e6f-be3b-f8cae20b03ea","","",false, this);
 
            StrLegal_Nombre = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("9baf2ec0-8306-4d85-ad5e-8eea5f8564a9","","",false, this);
 
            StrLegal_NIF = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("f1a9c46a-bd14-4eb0-973f-81d6a7773f94","","",false, this);
 
            DTLegal_Fecha = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("5b1d5cca-1e0b-4634-84f1-aa525c715912","","",false, this);
 
            StrLegal_Notaria = RPSControlFactory.CreateRPSTextBox<Mod390ManualDialogView>("6d627ab6-5f6a-4878-98a6-c70122c0cd92","","",false, this);
 
            CollectionInit params_Mod390GetSavedManualData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11427b55-2464-45cc-87ba-1698b340d424",CSSSelectorGrid="",XPathGrid=""};
            Mod390GetSavedManualData = RPSControlFactory.RPSCreateCollectionWithGrid<Mod390GetSavedManualDataCollectionEditor<Mod390ManualDialogView>,Mod390ManualDialogView>( params_Mod390GetSavedManualData,this);
 
            Section = RPSControlFactory.CreateRPSSection<Mod390ManualDialogView>( "","ul li[rpsid='fbb0d0e6-a9df-4066-9007-9bfd91396222']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<Mod390ManualDialogView>( "","ul li[rpsid='83b3b865-c820-4365-bd63-55908fb3f2c9']","",this);
 

        }
        public IRPSTextBox<Mod390ManualDialogView> ParentExercise { get; set; } 
        public IRPSButton<Mod390ManualDialogView> ExecuteMod390GetLastOtherDetaOrDefault { get; set; } 
        public IRPSButton<Mod390ManualDialogView> ExecuteMod390GetDefaultOtherData { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsMensual { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsConcurso { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> Is347 { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> PorcEstatal { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> PorcVI { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> PorcSS { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> PorcBI { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> PorcNAVARRA { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsCaja_Ventas { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsCaja_Compras { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsREGE { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrREGE_Grupo { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsREGE_Dominante { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsREGE_Dependiente { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsREGE_4T { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrREGE_NIF { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsREGE_163 { get; set; } 
        public IRPSCheckbox<Mod390ManualDialogView> IsConjunta { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrConjunta_NIF { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrConjunta_Razon { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrLegal_Nombre { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrLegal_NIF { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> DTLegal_Fecha { get; set; } 
        public IRPSTextBox<Mod390ManualDialogView> StrLegal_Notaria { get; set; } 
        public Mod390GetSavedManualDataCollectionEditor<Mod390ManualDialogView> Mod390GetSavedManualData { get; set; } 
        public IRPSSection<Mod390ManualDialogView> Section { get; set; } 
        public IRPSSection<Mod390ManualDialogView> Section1 { get; set; } 
        public Mod390 Screen { get; set; }
        public Mod390ManualDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class Mod390GetSavedManualDataCollectionEditor<Mod390ManualDialogView>:RPSCollectionEditor<Mod390ManualDialogView> where Mod390ManualDialogView : class, IView
    {
        public  Mod390GetSavedManualDataGridView<Mod390ManualDialogView> GridView {get;set;}
    }
    public partial class Mod390GetSavedManualDataGridView <Mod390ManualDialogView> :  RPSGridView<Mod390ManualDialogView> where Mod390ManualDialogView : class, IView
    {
        public Mod390GetSavedManualDataGridView(Mod390ManualDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PageName = RPSControlFactory.CreateRPSGridTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cPageName']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            BaseValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cBaseValue']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 
            AmountValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod390ManualDialogView>("","#11427b55-2464-45cc-87ba-1698b340d424 .ag-row[role='row']@ROWINDEX [col-id='cAmountValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod390ManualDialogView> PageName { get; set; } 
        public IRPSGridTextBox<Mod390ManualDialogView> Text { get; set; } 
        public IRPSGridTextBox<Mod390ManualDialogView> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod390ManualDialogView> BaseValue { get; set; } 
        public IRPSGridTextBox<Mod390ManualDialogView> AmountCell { get; set; } 
        public IRPSGridTextBox<Mod390ManualDialogView> AmountValue { get; set; } 
                     
    }
 
    }
  
    

}