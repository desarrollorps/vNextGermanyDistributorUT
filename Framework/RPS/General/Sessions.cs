    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Sessions
{
    //RPS VERSION 1.0.0.0
    public partial class Sessions:Screen
    {
        public Sessions():base()
        {
            this.URL = "general.sessions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SessionsView  = new SessionsView(this); 
            SessionsView.InitializeControls(); 
           
        }
      
            public SessionsView SessionsView {get; set; } 
    }
            
    public partial class SessionsView : View
    {
        public SessionsView(Sessions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIUsersWithLicense = RPSControlFactory.CreateRPSFormattedTextBox<SessionsView>("212c7a28-5af5-4eec-8fea-585d99aa8bed","","",false, this);
 
            UIMaxLisensedUsers = RPSControlFactory.CreateRPSFormattedTextBox<SessionsView>("36317690-2253-49fa-94e3-50d4d8986672","","",false, this);
 
            ExecuteGetActiveSessionsButton = RPSControlFactory.CreateRPSButton<SessionsView>( "be1d6bcd-338b-4deb-9786-678981d0630e","","",this);
 
            TerminateSessionCommandButton = RPSControlFactory.CreateRPSButton<SessionsView>( "e9b27b3e-9e83-4a00-9f44-21d9a36883a6","","",this);
 
            CollectionInit params_GetActiveSessions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7edee396-360d-4b22-b437-49de438f3a3c",CSSSelectorGrid="",XPathGrid=""};
            GetActiveSessions = RPSControlFactory.RPSCreateCollectionWithGrid<GetActiveSessionsCollectionEditor<SessionsView>,SessionsView>( params_GetActiveSessions,this);
 

        }
        public IRPSTextBox<SessionsView> UIUsersWithLicense { get; set; } 
        public IRPSTextBox<SessionsView> UIMaxLisensedUsers { get; set; } 
        public IRPSButton<SessionsView> ExecuteGetActiveSessionsButton { get; set; } 
        public IRPSButton<SessionsView> TerminateSessionCommandButton { get; set; } 
        public GetActiveSessionsCollectionEditor<SessionsView> GetActiveSessions { get; set; } 
        public Sessions Screen { get; set; }
        public SessionsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetActiveSessionsCollectionEditor<SessionsView>:RPSCollectionEditor<SessionsView> where SessionsView : class, IView
    {
        public  GetActiveSessionsGridView<SessionsView> GridView {get;set;}
    }
    public partial class GetActiveSessionsGridView <SessionsView> :  RPSGridView<SessionsView> where SessionsView : class, IView
    {
        public GetActiveSessionsGridView(SessionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            LastActivityDate = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cLastActivityDate']","",false, this.CurrentView);
 
            LastActivityTime = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cLastActivityTime']","",false, this.CurrentView);
 
            LogonDate = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cLogonDate']","",false, this.CurrentView);
 
            LogonTime = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cLogonTime']","",false, this.CurrentView);
 
            MachineName = RPSControlFactory.CreateRPSGridTextBox<SessionsView>("","#7edee396-360d-4b22-b437-49de438f3a3c .ag-row[role='row']@ROWINDEX [col-id='cMachineName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SessionsView> CodUser { get; set; } 
        public IRPSGridTextBox<SessionsView> LastActivityDate { get; set; } 
        public IRPSGridTextBox<SessionsView> LastActivityTime { get; set; } 
        public IRPSGridTextBox<SessionsView> LogonDate { get; set; } 
        public IRPSGridTextBox<SessionsView> LogonTime { get; set; } 
        public IRPSGridTextBox<SessionsView> MachineName { get; set; } 
                     
    }
 
    }
  
    

}