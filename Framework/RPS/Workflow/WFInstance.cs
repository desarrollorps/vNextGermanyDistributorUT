    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Workflow.WFInstance
{
    //RPS VERSION 1.0.0.0
    public partial class WFInstance:Screen
    {
        public WFInstance():base()
        {
            this.URL = "workflow.wfinstance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WFInstanceView  = new WFInstanceView(this); 
            UserMessageTaskDialogView  = new UserMessageTaskDialogView(this); 
            UserQuestionTaskDialogView  = new UserQuestionTaskDialogView(this); 
            EmailTaskDialogView  = new EmailTaskDialogView(this); 
            DataFormTaskDialogView  = new DataFormTaskDialogView(this); 
            SelectEntityTaskDialogView  = new SelectEntityTaskDialogView(this); 
            ScreenTaskDialogView  = new ScreenTaskDialogView(this); 
            ShowReportTaskDialogView  = new ShowReportTaskDialogView(this); 
            NavigationScreenTaskDialogView  = new NavigationScreenTaskDialogView(this); 
            WFInstanceView.InitializeControls(); 
            UserMessageTaskDialogView.InitializeControls(); 
            UserQuestionTaskDialogView.InitializeControls(); 
            EmailTaskDialogView.InitializeControls(); 
            DataFormTaskDialogView.InitializeControls(); 
            SelectEntityTaskDialogView.InitializeControls(); 
            ScreenTaskDialogView.InitializeControls(); 
            ShowReportTaskDialogView.InitializeControls(); 
            NavigationScreenTaskDialogView.InitializeControls(); 
           
        }
      
            public WFInstanceView WFInstanceView {get; set; } 
            public UserMessageTaskDialogView UserMessageTaskDialogView {get; set; } 
            public UserQuestionTaskDialogView UserQuestionTaskDialogView {get; set; } 
            public EmailTaskDialogView EmailTaskDialogView {get; set; } 
            public DataFormTaskDialogView DataFormTaskDialogView {get; set; } 
            public SelectEntityTaskDialogView SelectEntityTaskDialogView {get; set; } 
            public ScreenTaskDialogView ScreenTaskDialogView {get; set; } 
            public ShowReportTaskDialogView ShowReportTaskDialogView {get; set; } 
            public NavigationScreenTaskDialogView NavigationScreenTaskDialogView {get; set; } 
    }
            
    public partial class WFInstanceView : View
    {
        public WFInstanceView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RefreshWorkflowInstanceTasksButton = RPSControlFactory.CreateRPSButton<WFInstanceView>( "d8bef569-c069-4ea3-b768-a33dad4c674c","","",this);
 
            CollectionInit params_WorkflowInstanceTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7b909a3c-8dbd-4896-8da6-37dc4de33170",CSSSelectorGrid="",XPathGrid=""};
            WorkflowInstanceTasks = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowInstanceTasksCollectionEditor<WFInstanceView>,WFInstanceView>( params_WorkflowInstanceTasks,this);
 

        }
        public IRPSButton<WFInstanceView> RefreshWorkflowInstanceTasksButton { get; set; } 
        public WorkflowInstanceTasksCollectionEditor<WFInstanceView> WorkflowInstanceTasks { get; set; } 
        public WFInstance Screen { get; set; }
        public WFInstanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowInstanceTasksCollectionEditor<WFInstanceView>:RPSCollectionEditor<WFInstanceView> where WFInstanceView : class, IView
    {
        public  WorkflowInstanceTasksGridView<WFInstanceView> GridView {get;set;}
    }
    public partial class WorkflowInstanceTasksGridView <WFInstanceView> :  RPSGridView<WFInstanceView> where WFInstanceView : class, IView
    {
        public WorkflowInstanceTasksGridView(WFInstanceView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            creationDateTime = RPSControlFactory.CreateRPSGridTextBox<WFInstanceView>("","#7b909a3c-8dbd-4896-8da6-37dc4de33170 .ag-row[role='row']@ROWINDEX [col-id='ccreationDateTime']","",false, this.CurrentView);
 
            dueDateTime = RPSControlFactory.CreateRPSGridTextBox<WFInstanceView>("","#7b909a3c-8dbd-4896-8da6-37dc4de33170 .ag-row[role='row']@ROWINDEX [col-id='cdueDateTime']","",false, this.CurrentView);
 
            endDateTime = RPSControlFactory.CreateRPSGridTextBox<WFInstanceView>("","#7b909a3c-8dbd-4896-8da6-37dc4de33170 .ag-row[role='row']@ROWINDEX [col-id='cendDateTime']","",false, this.CurrentView);
 
            RunTaskCommand = RPSControlFactory.CreateRPSGridButton<WFInstanceView>( "","#7b909a3c-8dbd-4896-8da6-37dc4de33170 .ag-row[role='row']@ROWINDEX [col-id='cRunTaskCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<WFInstanceView> creationDateTime { get; set; } 
        public IRPSGridTextBox<WFInstanceView> dueDateTime { get; set; } 
        public IRPSGridTextBox<WFInstanceView> endDateTime { get; set; } 
        public IRPSGridButton<WFInstanceView> RunTaskCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class UserMessageTaskDialogView : View
    {
        public UserMessageTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FinishCommandButton = RPSControlFactory.CreateRPSButton<UserMessageTaskDialogView>( "c70d4782-8796-4358-bb8a-4db3f95b26f5","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<UserMessageTaskDialogView>( "93f62fdc-1d22-4f58-b596-b6a2e6c8ac3e","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<UserMessageTaskDialogView>( "0a45e6f9-4059-4f78-b277-929dc6ebfe3d","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<UserMessageTaskDialogView>( "9906b597-3f8a-429d-9203-7f4911b791a1","","",this);
 

        }
        public IRPSButton<UserMessageTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<UserMessageTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<UserMessageTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<UserMessageTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public WFInstance Screen { get; set; }
        public UserMessageTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UserQuestionTaskDialogView : View
    {
        public UserQuestionTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Yes = RPSControlFactory.CreateRPSOption<UserQuestionTaskDialogView>( "97bc5dfa-d060-4901-96a2-66a4211126b0","","",this);
 
            No = RPSControlFactory.CreateRPSOption<UserQuestionTaskDialogView>( "c0b0ede2-abdd-4672-847a-8b234afba533","","",this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<UserQuestionTaskDialogView>( "9c9fba9f-7ccd-49f5-ac8c-78c0ddd74016","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<UserQuestionTaskDialogView>( "e308d295-7d2f-475b-8aaf-c44dcad77179","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<UserQuestionTaskDialogView>( "7d30684d-438c-4590-ba0e-1c49613f2be3","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<UserQuestionTaskDialogView>( "cf875de2-a3bf-4960-8bc8-cde02f996c5e","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<UserQuestionTaskDialogView>("07bb9a03-dfce-4577-927e-ad4570b3d27b","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<UserQuestionTaskDialogView>("b2cde1eb-bc02-4abc-9731-667061a0cef4","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<UserQuestionTaskDialogView>("7021bd3b-cba0-4327-ac8c-83c5f0ca6517","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<UserQuestionTaskDialogView>("35ec53cc-d357-47e5-994c-a80134ed1775","","",false, this);
 

        }
        public IRPSOption<UserQuestionTaskDialogView> Yes { get; set; } 
        public IRPSOption<UserQuestionTaskDialogView> No { get; set; } 
        public IRPSButton<UserQuestionTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<UserQuestionTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<UserQuestionTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<UserQuestionTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<UserQuestionTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<UserQuestionTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<UserQuestionTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<UserQuestionTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public UserQuestionTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmailTaskDialogView : View
    {
        public EmailTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ToAddress = RPSControlFactory.CreateRPSEmailTextBox<EmailTaskDialogView>("981b43d7-bf20-4f47-bb42-3b9fd905760a","","",true, this);
 
            CCAddress = RPSControlFactory.CreateRPSEmailTextBox<EmailTaskDialogView>("76da4941-64c2-4eeb-89dd-34be1153c667","","",false, this);
 
            BCCAddress = RPSControlFactory.CreateRPSEmailTextBox<EmailTaskDialogView>("af2b2ce1-5f89-4276-94ef-845da74d4e7b","","",false, this);
 
            Subject = RPSControlFactory.CreateRPSTextBox<EmailTaskDialogView>("1ca99392-592c-4ca0-b2ba-4461a74a40b2","","",false, this);
 
            Body = RPSControlFactory.CreateRPSTextBox<EmailTaskDialogView>("324ec3ae-75d3-432f-9d16-c0d817a77bed","","",false, this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<EmailTaskDialogView>( "bccc5c03-f00b-41f1-9e7c-be2731c674bb","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<EmailTaskDialogView>( "d6f149b0-7edb-4819-9347-2b8238944a64","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<EmailTaskDialogView>( "13b6f4a2-e627-4fd0-ab4f-ffd82324196a","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<EmailTaskDialogView>( "4cfc4ab0-ce1c-428e-a86d-83470d60d39b","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<EmailTaskDialogView>("fe79475c-39cf-4373-baa2-ccf83743346b","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<EmailTaskDialogView>("80b91199-d121-45a9-bcc0-e50bfddfd5d6","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<EmailTaskDialogView>("c3870682-f1f2-4dcf-ab92-bd611599a25d","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<EmailTaskDialogView>("b4a210ce-8d77-4f1e-89cb-87ce339ce96d","","",false, this);
 

        }
        public IRPSTextBox<EmailTaskDialogView> ToAddress { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> CCAddress { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> BCCAddress { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> Subject { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> Body { get; set; } 
        public IRPSButton<EmailTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<EmailTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<EmailTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<EmailTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<EmailTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<EmailTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<EmailTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public EmailTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DataFormTaskDialogView : View
    {
        public DataFormTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FinishCommandButton = RPSControlFactory.CreateRPSButton<DataFormTaskDialogView>( "34a35fee-621f-4cd0-bcfd-851600bc607e","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<DataFormTaskDialogView>( "16971206-0337-40dc-aa65-ca5e768a6796","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<DataFormTaskDialogView>( "73068472-15bf-4473-85a4-0c96b86bbc65","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<DataFormTaskDialogView>( "4f0bf34d-2b31-4042-8f86-e9a37a3c12a1","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<DataFormTaskDialogView>("ec4bc14d-68ea-4254-8d51-e919d1af8645","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<DataFormTaskDialogView>("88e5c1a1-c8e7-41de-8879-32777782b01e","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<DataFormTaskDialogView>("96bc3b0b-b39a-41a8-9e99-e2815d267814","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<DataFormTaskDialogView>("4643c17c-c354-429f-be7a-8c97e34968c4","","",false, this);
 

        }
        public IRPSButton<DataFormTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<DataFormTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<DataFormTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<DataFormTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<DataFormTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<DataFormTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<DataFormTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<DataFormTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public DataFormTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SelectEntityTaskDialogView : View
    {
        public SelectEntityTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FinishCommandButton = RPSControlFactory.CreateRPSButton<SelectEntityTaskDialogView>( "2e37f6e7-7565-48df-9439-71805707c8be","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<SelectEntityTaskDialogView>( "8cefdc2a-5445-4825-ae33-f32988168f44","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<SelectEntityTaskDialogView>( "f44ce9c6-8ed7-4ebf-b12c-d07ce112a97b","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<SelectEntityTaskDialogView>( "8c4be6ed-917f-4278-8849-1ba343f54487","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<SelectEntityTaskDialogView>("e4728a4a-6cbd-446a-9450-a481b222f1eb","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<SelectEntityTaskDialogView>("bc563478-5623-41e9-887c-b1e6edcf4fcf","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<SelectEntityTaskDialogView>("cf82ce5a-79b2-48c7-960c-458016f24c25","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<SelectEntityTaskDialogView>("aa3f7d92-9f62-4a0b-b8fa-0042e44302be","","",false, this);
 

        }
        public IRPSButton<SelectEntityTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<SelectEntityTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<SelectEntityTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<SelectEntityTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<SelectEntityTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<SelectEntityTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<SelectEntityTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<SelectEntityTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public SelectEntityTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ScreenTaskDialogView : View
    {
        public ScreenTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LaunchScreenCommand = RPSControlFactory.CreateRPSButton<ScreenTaskDialogView>( "29c34e61-122b-4537-b13a-13b1aaf06bb3","","",this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<ScreenTaskDialogView>( "ef431245-3a2a-47b5-8914-4c86f3feb78b","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<ScreenTaskDialogView>( "8ac57877-f6b8-4610-97da-29a04e40f480","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<ScreenTaskDialogView>( "117d40b3-9283-4e08-b549-849b9d4456ed","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<ScreenTaskDialogView>( "74bd77fd-cba8-4bd9-bbf9-d8e30fc57a77","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<ScreenTaskDialogView>("b790c180-a266-46cc-801e-09c60de7d9da","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<ScreenTaskDialogView>("978d27e9-6ee7-4452-8f77-f81de27d9e42","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<ScreenTaskDialogView>("829807a5-1432-45e3-bcda-4d77f0efa089","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<ScreenTaskDialogView>("418e9869-f106-49db-89cb-9a2bcef9183e","","",false, this);
 

        }
        public IRPSButton<ScreenTaskDialogView> LaunchScreenCommand { get; set; } 
        public IRPSButton<ScreenTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<ScreenTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<ScreenTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<ScreenTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<ScreenTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<ScreenTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<ScreenTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<ScreenTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public ScreenTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ShowReportTaskDialogView : View
    {
        public ShowReportTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReportCommand = RPSControlFactory.CreateRPSButton<ShowReportTaskDialogView>( "d05cfafd-c1a6-4589-8686-766dabaa433a","","",this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<ShowReportTaskDialogView>( "72b06f2f-babc-487d-833f-b5cce8baa654","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<ShowReportTaskDialogView>( "f0d7fe59-c56a-412e-8776-7a6fd8363091","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<ShowReportTaskDialogView>( "09beaf07-afa1-4ed7-bece-cd504fb7be5c","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<ShowReportTaskDialogView>( "17eb36e0-6aec-4f18-ba26-0138d128ca39","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<ShowReportTaskDialogView>("a02c6ad5-f115-4b2c-9349-ed6588b987f2","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<ShowReportTaskDialogView>("4738ee3b-662f-4163-8229-6b4a727f29a3","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<ShowReportTaskDialogView>("e6a5d69a-e3ae-4634-9543-b26683b9f30b","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<ShowReportTaskDialogView>("b6df448d-f8a6-4dfb-8dbb-53b9c6d9b657","","",false, this);
 

        }
        public IRPSButton<ShowReportTaskDialogView> ReportCommand { get; set; } 
        public IRPSButton<ShowReportTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<ShowReportTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<ShowReportTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<ShowReportTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<ShowReportTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<ShowReportTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<ShowReportTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<ShowReportTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public ShowReportTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NavigationScreenTaskDialogView : View
    {
        public NavigationScreenTaskDialogView(WFInstance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LaunchScreenCommand = RPSControlFactory.CreateRPSButton<NavigationScreenTaskDialogView>( "376b753a-1bf1-4f7c-a513-878a0af970d4","","",this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<NavigationScreenTaskDialogView>( "0259bb9c-a2b1-4259-90dc-cc0ce0f9a59e","","",this);
 
            PostponeCommandButton = RPSControlFactory.CreateRPSButton<NavigationScreenTaskDialogView>( "2ece74cd-7d83-45aa-b39f-e64388d4f54a","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<NavigationScreenTaskDialogView>( "2f0a1ee0-bd10-4c4c-82ae-e0388ea0a795","","",this);
 
            CreateIncidentCommandButton = RPSControlFactory.CreateRPSButton<NavigationScreenTaskDialogView>( "32ed9406-43ce-48bb-bec4-d89e268bc387","","",this);
 
            IncidentDescription = RPSControlFactory.CreateRPSTextBox<NavigationScreenTaskDialogView>("ff8c11fc-0050-49dd-8ee2-f2b6c4b8c0e8","","",false, this);
 
            IncidentDetail = RPSControlFactory.CreateRPSTextBox<NavigationScreenTaskDialogView>("04fa93de-99ed-4c33-8320-8513427f480f","","",false, this);
 
            IncidentIsBlocking = RPSControlFactory.CreateRPSCheckBox<NavigationScreenTaskDialogView>("1c294b67-2820-44a9-b271-9c2d948b6d04","","",false, this);
 
            IncidentPriority = RPSControlFactory.CreateRPSEnumComboBox<NavigationScreenTaskDialogView>("4cfae761-783b-4b98-9322-741e5015259e","","",false, this);
 

        }
        public IRPSButton<NavigationScreenTaskDialogView> LaunchScreenCommand { get; set; } 
        public IRPSButton<NavigationScreenTaskDialogView> FinishCommandButton { get; set; } 
        public IRPSButton<NavigationScreenTaskDialogView> PostponeCommandButton { get; set; } 
        public IRPSButton<NavigationScreenTaskDialogView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<NavigationScreenTaskDialogView> CreateIncidentCommandButton { get; set; } 
        public IRPSTextBox<NavigationScreenTaskDialogView> IncidentDescription { get; set; } 
        public IRPSTextBox<NavigationScreenTaskDialogView> IncidentDetail { get; set; } 
        public IRPSCheckbox<NavigationScreenTaskDialogView> IncidentIsBlocking { get; set; } 
        public IRPSComboBox<NavigationScreenTaskDialogView> IncidentPriority { get; set; } 
        public WFInstance Screen { get; set; }
        public NavigationScreenTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}