    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CChannelManagement
{
    //RPS VERSION 1.0.0.0
    public partial class CChannelManagement:Screen
    {
        public CChannelManagement():base()
        {
            this.URL = "general.cchannelmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CChannelCollectionView  = new CChannelCollectionView(this); 
            CChannelEntityView  = new CChannelEntityView(this); 
            DeleteCCHMessageDialogView  = new DeleteCCHMessageDialogView(this); 
            DeleteMsgFromAllOpenChannelsDialogView  = new DeleteMsgFromAllOpenChannelsDialogView(this); 
            CChannelCollectionView.InitializeControls(); 
            CChannelEntityView.InitializeControls(); 
            DeleteCCHMessageDialogView.InitializeControls(); 
            DeleteMsgFromAllOpenChannelsDialogView.InitializeControls(); 
           
        }
      
            public CChannelCollectionView CChannelCollectionView {get; set; } 
            public CChannelEntityView CChannelEntityView {get; set; } 
            public DeleteCCHMessageDialogView DeleteCCHMessageDialogView {get; set; } 
            public DeleteMsgFromAllOpenChannelsDialogView DeleteMsgFromAllOpenChannelsDialogView {get; set; } 
    }
            
    public partial class CChannelCollectionView : View
    {
        public CChannelCollectionView(CChannelManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CChannelCollectionView,CChannelEntityView>( this,Screen.CChannelEntityView);
 
            DeleteMsgFromAllOpenChannelsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelCollectionView,DeleteMsgFromAllOpenChannelsDialogView>("dd9c1766-b7e8-40b4-bf55-01a214656452","","", this,Screen.DeleteMsgFromAllOpenChannelsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d2990f47-2bdb-4a62-bc08-92ed9691ecd9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CChannelCollectionView,CChannelEntityView>( params_MainConsult,this,Screen.CChannelEntityView);
 

        }
        public IRPSButton<CChannelCollectionView,CChannelEntityView> NewButton { get; set; } 
        public IRPSButton<CChannelCollectionView,DeleteMsgFromAllOpenChannelsDialogView> DeleteMsgFromAllOpenChannelsNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<CChannelCollectionView,CChannelEntityView> MainConsult { get; set; } 
        public CChannelManagement Screen { get; set; }
        public CChannelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CChannelEntityView : View
    {
        public CChannelEntityView(CChannelManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CChannelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CChannelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CChannelEntityView,CChannelCollectionView>( this,Screen.CChannelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CChannelEntityView,CChannelCollectionView>( this,Screen.CChannelCollectionView);
 
            CodCCHType = RPSControlFactory.CreateRPSComboBox<CChannelEntityView>("d79ae336-583d-4d20-8d70-cc31b8682801","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("2cc13863-3d83-45c1-a35f-c84d69d7d823","","",true, this);
 
            EntityType = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("57dad3ff-29c1-4832-88d7-1bd15882f92a","","",false, this);
 
            Property1 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("2c2913b1-e81a-44a4-a957-854053346004","","",false, this);
 
            Property2 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("3bd28044-2167-4af7-b715-b4d896d742f0","","",false, this);
 
            Property3 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("6b2c6124-c9b2-4d7b-94a1-7cf06538c759","","",false, this);
 
            Property4 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("ae4790e5-df49-48a7-88c0-6a272115d1ab","","",false, this);
 
            Property5 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("fbfb196c-3e7f-44e9-bca7-4a3bbfb301aa","","",false, this);
 
            Property6 = RPSControlFactory.CreateRPSTextBox<CChannelEntityView>("882f088e-aae3-48b5-950b-6b721a5a2cf0","","",false, this);
 
            DeleteCCHMessageNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelEntityView,DeleteCCHMessageDialogView>("39c080e8-3f2e-4bbd-ba76-ea5baa7918a0","","", this,Screen.DeleteCCHMessageDialogView);
 
            CollectionInit params_CCHTeams = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="98e8929c-88ca-4e95-b9ae-a8a5790f84ae",CSSSelectorGrid="",XPathGrid=""};
            CCHTeams = RPSControlFactory.RPSCreateCollectionWithGrid<CCHTeamsCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView>,CChannelEntityView,DeleteCCHMessageDialogView>( params_CCHTeams,this,Screen.DeleteCCHMessageDialogView);
 
            CollectionInit params_GetMessagesForIDChannel = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d4d22d0e-e41c-478f-86bc-dca2bfc11aca",CSSSelectorGrid="",XPathGrid=""};
            GetMessagesForIDChannel = RPSControlFactory.RPSCreateCollectionWithGrid<GetMessagesForIDChannelCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView>,CChannelEntityView,DeleteCCHMessageDialogView>( params_GetMessagesForIDChannel,this,Screen.DeleteCCHMessageDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CChannelEntityView>( "","ul li[rpsid='ed7d79d6-4abb-448e-b492-fd59f4f7a8fb']","",this);
 
            Team = RPSControlFactory.CreateRPSSection<CChannelEntityView>( "","ul li[rpsid='cf831ca2-1601-4867-86a5-37018715d4ce']","",this);
 
            Messages = RPSControlFactory.CreateRPSSection<CChannelEntityView>( "","ul li[rpsid='a3a61d19-1d64-4d0a-a373-629c86a09c64']","",this);
 

        }
        public IRPSSaveButton<CChannelEntityView> SaveButton { get; set; } 
        public IRPSButton<CChannelEntityView> DeleteButton { get; set; } 
        public IRPSButton<CChannelEntityView,CChannelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CChannelEntityView,CChannelCollectionView> BackButton { get; set; } 
        public IRPSComboBox<CChannelEntityView> CodCCHType { get; set; } 
        public IRPSTextBox<CChannelEntityView> Description { get; set; } 
        public IRPSTextBox<CChannelEntityView> EntityType { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property1 { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property2 { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property3 { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property4 { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property5 { get; set; } 
        public IRPSTextBox<CChannelEntityView> Property6 { get; set; } 
        public IRPSButton<CChannelEntityView,DeleteCCHMessageDialogView> DeleteCCHMessageNavigationCommandButton { get; set; } 
        public CCHTeamsCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView> CCHTeams { get; set; } 
        public GetMessagesForIDChannelCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView> GetMessagesForIDChannel { get; set; } 
        public IRPSSection<CChannelEntityView> GeneralData { get; set; } 
        public IRPSSection<CChannelEntityView> Team { get; set; } 
        public IRPSSection<CChannelEntityView> Messages { get; set; } 
        public CChannelManagement Screen { get; set; }
        public CChannelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CCHTeamsCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView>:RPSCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView> where CChannelEntityView : class, IView where DeleteCCHMessageDialogView : class, IView
    {
        public  CCHTeamsGridView<CChannelEntityView,DeleteCCHMessageDialogView> GridView {get;set;}
    }
    public partial class CCHTeamsGridView <CChannelEntityView,DeleteCCHMessageDialogView> :  RPSGridView<CChannelEntityView,DeleteCCHMessageDialogView> where CChannelEntityView : class, IView where DeleteCCHMessageDialogView : class, IView
    {
        public CCHTeamsGridView(CChannelEntityView currentView,DeleteCCHMessageDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<CChannelEntityView>("","#98e8929c-88ca-4e95-b9ae-a8a5790f84ae .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            TypeUser = RPSControlFactory.CreateRPSGridEnumComboBox<CChannelEntityView>("","#98e8929c-88ca-4e95-b9ae-a8a5790f84ae .ag-row[role='row']@ROWINDEX [col-id='cTypeUser']","",true, this.CurrentView);
 
            TypeNotification = RPSControlFactory.CreateRPSGridEnumComboBox<CChannelEntityView>("","#98e8929c-88ca-4e95-b9ae-a8a5790f84ae .ag-row[role='row']@ROWINDEX [col-id='cTypeNotification']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CChannelEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<CChannelEntityView> TypeUser { get; set; } 
        public IRPSGridComboBox<CChannelEntityView> TypeNotification { get; set; } 
                     
    }
 
        public partial class GetMessagesForIDChannelCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView>:RPSCollectionEditor<CChannelEntityView,DeleteCCHMessageDialogView> where CChannelEntityView : class, IView where DeleteCCHMessageDialogView : class, IView
    {
        public  GetMessagesForIDChannelGridView<CChannelEntityView,DeleteCCHMessageDialogView> GridView {get;set;}
    }
    public partial class GetMessagesForIDChannelGridView <CChannelEntityView,DeleteCCHMessageDialogView> :  RPSGridView<CChannelEntityView,DeleteCCHMessageDialogView> where CChannelEntityView : class, IView where DeleteCCHMessageDialogView : class, IView
    {
        public GetMessagesForIDChannelGridView(CChannelEntityView currentView,DeleteCCHMessageDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CCHMessage_MessageDate = RPSControlFactory.CreateRPSGridTextBox<CChannelEntityView>("","#d4d22d0e-e41c-478f-86bc-dca2bfc11aca .ag-row[role='row']@ROWINDEX [col-id='cCCHMessage_MessageDate']","",false, this.CurrentView);
 
            DescriptionWithoutRichText = RPSControlFactory.CreateRPSGridTextBox<CChannelEntityView>("","#d4d22d0e-e41c-478f-86bc-dca2bfc11aca .ag-row[role='row']@ROWINDEX [col-id='cDescriptionWithoutRichText']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CChannelEntityView> CCHMessage_MessageDate { get; set; } 
        public IRPSGridTextBox<CChannelEntityView> DescriptionWithoutRichText { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeleteCCHMessageDialogView : View
    {
        public DeleteCCHMessageDialogView(CChannelManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<DeleteCCHMessageDialogView>("418aef40-5c49-4012-962e-196ee662f041","","",true, this);
 

        }
        public IRPSTextBox<DeleteCCHMessageDialogView> DateTo { get; set; } 
        public CChannelManagement Screen { get; set; }
        public DeleteCCHMessageDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeleteMsgFromAllOpenChannelsDialogView : View
    {
        public DeleteMsgFromAllOpenChannelsDialogView(CChannelManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<DeleteMsgFromAllOpenChannelsDialogView>("e0ea62b0-9aa0-40e7-8776-3d5f9085a64d","","",true, this);
 

        }
        public IRPSTextBox<DeleteMsgFromAllOpenChannelsDialogView> DateTo { get; set; } 
        public CChannelManagement Screen { get; set; }
        public DeleteMsgFromAllOpenChannelsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}