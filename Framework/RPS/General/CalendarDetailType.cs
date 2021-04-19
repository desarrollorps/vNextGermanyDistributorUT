    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CalendarDetailType
{
    //RPS VERSION 1.0.0.0
    public partial class CalendarDetailType:Screen
    {
        public CalendarDetailType():base()
        {
            this.URL = "general.calendardetailtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CalendarDetailTypeCollectionView  = new CalendarDetailTypeCollectionView(this); 
            CalendarDetailTypeEntityView  = new CalendarDetailTypeEntityView(this); 
            NewHourIntervalDialogView  = new NewHourIntervalDialogView(this); 
            CalendarDetailTypeCollectionView.InitializeControls(); 
            CalendarDetailTypeEntityView.InitializeControls(); 
            NewHourIntervalDialogView.InitializeControls(); 
           
        }
      
            public CalendarDetailTypeCollectionView CalendarDetailTypeCollectionView {get; set; } 
            public CalendarDetailTypeEntityView CalendarDetailTypeEntityView {get; set; } 
            public NewHourIntervalDialogView NewHourIntervalDialogView {get; set; } 
    }
            
    public partial class CalendarDetailTypeCollectionView : View
    {
        public CalendarDetailTypeCollectionView(CalendarDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CalendarDetailTypeCollectionView,CalendarDetailTypeEntityView>( this,Screen.CalendarDetailTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "02b019d2-540f-4e29-9def-0775b13cb5cc",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CalendarDetailTypeCollectionView,CalendarDetailTypeEntityView>( params_MainConsult,this,Screen.CalendarDetailTypeEntityView);
 

        }
        public IRPSButton<CalendarDetailTypeCollectionView,CalendarDetailTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CalendarDetailTypeCollectionView,CalendarDetailTypeEntityView> MainConsult { get; set; } 
        public CalendarDetailType Screen { get; set; }
        public CalendarDetailTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CalendarDetailTypeEntityView : View
    {
        public CalendarDetailTypeEntityView(CalendarDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CalendarDetailTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CalendarDetailTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CalendarDetailTypeEntityView,CalendarDetailTypeCollectionView>( this,Screen.CalendarDetailTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CalendarDetailTypeEntityView,CalendarDetailTypeCollectionView>( this,Screen.CalendarDetailTypeCollectionView);
 
            CodCalendarDetailType = RPSControlFactory.CreateRPSTextBox<CalendarDetailTypeEntityView>("0993c0c8-e58f-4c71-a932-7822411b4cdb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CalendarDetailTypeEntityView>("de5ab161-f547-4e78-bcf5-3f2c176332b6","","",false, this);
 
            NewHourIntervalNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CalendarDetailTypeEntityView,NewHourIntervalDialogView>("c9a8d35c-abda-43f2-8498-27a42a95bc33","","", this,Screen.NewHourIntervalDialogView);
 
            UIFreeDay = RPSControlFactory.CreateRPSCheckBox<CalendarDetailTypeEntityView>("1f653868-4548-4141-a054-7face4859467","","",false, this);
 
            CollectionInit params_GetHourIntervalsFromTimeExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ceb1f2d6-0c56-47dd-982e-31e073f13dec",CSSSelectorGrid="",XPathGrid=""};
            GetHourIntervalsFromTimeExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailTypeEntityView,NewHourIntervalDialogView>,CalendarDetailTypeEntityView,NewHourIntervalDialogView>( params_GetHourIntervalsFromTimeExpresion,this,Screen.NewHourIntervalDialogView);
 

        }
        public IRPSSaveButton<CalendarDetailTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<CalendarDetailTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<CalendarDetailTypeEntityView,CalendarDetailTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CalendarDetailTypeEntityView,CalendarDetailTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CalendarDetailTypeEntityView> CodCalendarDetailType { get; set; } 
        public IRPSTextBox<CalendarDetailTypeEntityView> Description { get; set; } 
        public IRPSButton<CalendarDetailTypeEntityView,NewHourIntervalDialogView> NewHourIntervalNavigationCommand { get; set; } 
        public IRPSCheckbox<CalendarDetailTypeEntityView> UIFreeDay { get; set; } 
        public GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailTypeEntityView,NewHourIntervalDialogView> GetHourIntervalsFromTimeExpresion { get; set; } 
        public CalendarDetailType Screen { get; set; }
        public CalendarDetailTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailTypeEntityView,NewHourIntervalDialogView>:RPSCollectionEditor<CalendarDetailTypeEntityView,NewHourIntervalDialogView> where CalendarDetailTypeEntityView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public  GetHourIntervalsFromTimeExpresionGridView<CalendarDetailTypeEntityView,NewHourIntervalDialogView> GridView {get;set;}
    }
    public partial class GetHourIntervalsFromTimeExpresionGridView <CalendarDetailTypeEntityView,NewHourIntervalDialogView> :  RPSGridView<CalendarDetailTypeEntityView,NewHourIntervalDialogView> where CalendarDetailTypeEntityView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public GetHourIntervalsFromTimeExpresionGridView(CalendarDetailTypeEntityView currentView,NewHourIntervalDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteHourIntervalCommand = RPSControlFactory.CreateRPSGridButton<CalendarDetailTypeEntityView>( "","#ceb1f2d6-0c56-47dd-982e-31e073f13dec .ag-row[role='row']@ROWINDEX [col-id='cDeleteHourIntervalCommand']","",this.CurrentView);
 
            HourFrom = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailTypeEntityView>("","#ceb1f2d6-0c56-47dd-982e-31e073f13dec .ag-row[role='row']@ROWINDEX [col-id='cHourFrom']","",false, this.CurrentView);
 
            HourTo = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailTypeEntityView>("","#ceb1f2d6-0c56-47dd-982e-31e073f13dec .ag-row[role='row']@ROWINDEX [col-id='cHourTo']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<CalendarDetailTypeEntityView> DeleteHourIntervalCommand { get; set; } 
        public IRPSGridTextBox<CalendarDetailTypeEntityView> HourFrom { get; set; } 
        public IRPSGridTextBox<CalendarDetailTypeEntityView> HourTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewHourIntervalDialogView : View
    {
        public NewHourIntervalDialogView(CalendarDetailType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("1cf87dd1-34bd-4b2c-898e-e59c930b6df6","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("6dcf2bf2-8d03-4ab1-be3e-6730383056df","","",false, this);
 

        }
        public IRPSTextBox<NewHourIntervalDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<NewHourIntervalDialogView> UIDateTo { get; set; } 
        public CalendarDetailType Screen { get; set; }
        public NewHourIntervalDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}