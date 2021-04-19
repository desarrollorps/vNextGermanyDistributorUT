    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod303
{
    //RPS VERSION 1.0.0.0
    public partial class Mod303:Screen
    {
        public Mod303():base()
        {
            this.URL = "taxmodel.mod303";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod303View  = new Mod303View(this); 
            Mod303ManualDialogView  = new Mod303ManualDialogView(this); 
            Mod303View.InitializeControls(); 
            Mod303ManualDialogView.InitializeControls(); 
           
        }
      
            public Mod303View Mod303View {get; set; } 
            public Mod303ManualDialogView Mod303ManualDialogView {get; set; } 
    }
            
    public partial class Mod303View : View
    {
        public Mod303View(Mod303 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod303View>("4884983a-9239-442e-bbe3-dd5125529e87","","",false, this);
 
            MonthQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod303View>("01509f5a-8dd5-4c66-9ed5-386f3ebaa81b","","",true, this);
 
            OptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod303View>("700d00e7-6410-460d-a093-bd944e8c4030","","",false, this);
 
            OptionQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod303View>("beee03dd-95bd-48a4-8dc6-a4393dd66a11","","",false, this);
 
            ExecuteGetMod303Data = RPSControlFactory.CreateRPSButton<Mod303View>( "28d75f13-6e17-4a8a-8d3e-328ce588eacb","","",this);
 
            DeclarationType = RPSControlFactory.CreateRPSEnumComboBox<Mod303View>("fecafa3e-b91f-458c-a855-8924546bdb7b","","",true, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod303View>("82941275-a73e-4621-9f5c-d1bb47bfa011","","",false, this);
 
            PreviousAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod303View>("000f7671-476c-4038-978d-5c68eeb8de47","","",false, this);
 
            DeclarationResult = RPSControlFactory.CreateRPSFormattedTextBox<Mod303View>("3e5635c2-e5e8-4962-b14a-c46296b16a25","","",false, this);
 
            ResultType = RPSControlFactory.CreateRPSEnumComboBox<Mod303View>("7621a316-53aa-41bb-b47d-c08e0dcda752","","",true, this);
 
            BankAccountCompany = RPSControlFactory.CreateRPSComboBox<Mod303View>("2fc79224-5942-4411-9b94-454c8bab2aa9","","",false, this);
 
            Actividad1 = RPSControlFactory.CreateRPSTextBox<Mod303View>("03628233-99c0-4cc8-bbdb-2a2f23bea32b","","",false, this);
 
            EpigrafeIAE1 = RPSControlFactory.CreateRPSTextBox<Mod303View>("ac39cfec-4b81-49f6-a440-7400c739e14e","","",false, this);
 
            Actividad2 = RPSControlFactory.CreateRPSTextBox<Mod303View>("6f15a7b5-936b-4752-b61a-d44e381d43b5","","",false, this);
 
            EpigrafeIAE2 = RPSControlFactory.CreateRPSTextBox<Mod303View>("bd257ad2-902b-4cbd-be84-f7283bf923fd","","",false, this);
 
            ExecuteGenerateMod303Button = RPSControlFactory.CreateRPSButton<Mod303View>( "fe1c8e22-c0ab-4be0-8b7c-c5b71b208e23","","",this);
 
            Mod303ManualNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<Mod303View,Mod303ManualDialogView>("c14be1d8-e994-4b9c-984c-9a6a0a0730d5","","", this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPage99 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2b5428bc-dc7c-45ef-b32e-9ccc22ffcdca",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPage99 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPage99CollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPage99,this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPageOther = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0b536bed-2ca0-4785-9d3d-cefe606e5899",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPageOther = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPageOtherCollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPageOther,this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPage2 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="faeee400-0b15-4889-bf74-0eff2c25f920",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPage2 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPage2CollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPage2,this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPage3 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6058df64-dd29-40c2-b071-95284bf1d64b",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPage3 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPage3CollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPage3,this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPage4 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f6f37e11-8532-4196-9c61-33069c5b6d0e",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPage4 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPage4CollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPage4,this,Screen.Mod303ManualDialogView);
 
            CollectionInit params_GetMod303DataPage10 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="95e5b5ba-843a-42cf-b16b-8e6b8b58ed1a",CSSSelectorGrid="",XPathGrid=""};
            GetMod303DataPage10 = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod303DataPage10CollectionEditor<Mod303View,Mod303ManualDialogView>,Mod303View,Mod303ManualDialogView>( params_GetMod303DataPage10,this,Screen.Mod303ManualDialogView);
 
            Section = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='3ae8084c-4bbd-4b02-9b33-a374efa2b01e']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='2c7ae5df-f56c-4487-b074-6af49eb6f337']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='a5d214c3-7d8b-42c2-8413-481207563e2b']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='69b735d9-5fa5-4be5-a630-23eaa2796f43']","",this);
 
            Section4 = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='2751a9c2-7a11-46e1-a8fe-c3eb01a079cc']","",this);
 
            Section5 = RPSControlFactory.CreateRPSSection<Mod303View>( "","ul li[rpsid='c38ea41b-d2ea-4b04-b220-87fbc21a4f52']","",this);
 

        }
        public IRPSTextBox<Mod303View> Exercise { get; set; } 
        public IRPSComboBox<Mod303View> MonthQuarter { get; set; } 
        public IRPSComboBox<Mod303View> OptionMes { get; set; } 
        public IRPSComboBox<Mod303View> OptionQuarter { get; set; } 
        public IRPSButton<Mod303View> ExecuteGetMod303Data { get; set; } 
        public IRPSComboBox<Mod303View> DeclarationType { get; set; } 
        public IRPSTextBox<Mod303View> NumJustificanteAnterior { get; set; } 
        public IRPSTextBox<Mod303View> PreviousAmount { get; set; } 
        public IRPSTextBox<Mod303View> DeclarationResult { get; set; } 
        public IRPSComboBox<Mod303View> ResultType { get; set; } 
        public IRPSComboBox<Mod303View> BankAccountCompany { get; set; } 
        public IRPSTextBox<Mod303View> Actividad1 { get; set; } 
        public IRPSTextBox<Mod303View> EpigrafeIAE1 { get; set; } 
        public IRPSTextBox<Mod303View> Actividad2 { get; set; } 
        public IRPSTextBox<Mod303View> EpigrafeIAE2 { get; set; } 
        public IRPSButton<Mod303View> ExecuteGenerateMod303Button { get; set; } 
        public IRPSButton<Mod303View,Mod303ManualDialogView> Mod303ManualNavigationCommandButton { get; set; } 
        public GetMod303DataPage99CollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPage99 { get; set; } 
        public GetMod303DataPageOtherCollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPageOther { get; set; } 
        public GetMod303DataPage2CollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPage2 { get; set; } 
        public GetMod303DataPage3CollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPage3 { get; set; } 
        public GetMod303DataPage4CollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPage4 { get; set; } 
        public GetMod303DataPage10CollectionEditor<Mod303View,Mod303ManualDialogView> GetMod303DataPage10 { get; set; } 
        public IRPSSection<Mod303View> Section { get; set; } 
        public IRPSSection<Mod303View> Section1 { get; set; } 
        public IRPSSection<Mod303View> Section2 { get; set; } 
        public IRPSSection<Mod303View> Section3 { get; set; } 
        public IRPSSection<Mod303View> Section4 { get; set; } 
        public IRPSSection<Mod303View> Section5 { get; set; } 
        public Mod303 Screen { get; set; }
        public Mod303View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod303DataPage99CollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPage99GridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPage99GridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPage99GridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#2b5428bc-dc7c-45ef-b32e-9ccc22ffcdca .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#2b5428bc-dc7c-45ef-b32e-9ccc22ffcdca .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#2b5428bc-dc7c-45ef-b32e-9ccc22ffcdca .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#2b5428bc-dc7c-45ef-b32e-9ccc22ffcdca .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod303DataPageOtherCollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPageOtherGridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPageOtherGridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPageOtherGridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#0b536bed-2ca0-4785-9d3d-cefe606e5899 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#0b536bed-2ca0-4785-9d3d-cefe606e5899 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            Other = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#0b536bed-2ca0-4785-9d3d-cefe606e5899 .ag-row[role='row']@ROWINDEX [col-id='cOther']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> Other { get; set; } 
                     
    }
 
        public partial class GetMod303DataPage2CollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPage2GridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPage2GridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPage2GridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#faeee400-0b15-4889-bf74-0eff2c25f920 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#faeee400-0b15-4889-bf74-0eff2c25f920 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#faeee400-0b15-4889-bf74-0eff2c25f920 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#faeee400-0b15-4889-bf74-0eff2c25f920 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod303DataPage3CollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPage3GridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPage3GridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPage3GridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#6058df64-dd29-40c2-b071-95284bf1d64b .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#6058df64-dd29-40c2-b071-95284bf1d64b .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#6058df64-dd29-40c2-b071-95284bf1d64b .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#6058df64-dd29-40c2-b071-95284bf1d64b .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod303DataPage4CollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPage4GridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPage4GridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPage4GridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#f6f37e11-8532-4196-9c61-33069c5b6d0e .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#f6f37e11-8532-4196-9c61-33069c5b6d0e .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#f6f37e11-8532-4196-9c61-33069c5b6d0e .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#f6f37e11-8532-4196-9c61-33069c5b6d0e .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303View> AmountCell { get; set; } 
                     
    }
 
        public partial class GetMod303DataPage10CollectionEditor<Mod303View,Mod303ManualDialogView>:RPSCollectionEditor<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public  GetMod303DataPage10GridView<Mod303View,Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class GetMod303DataPage10GridView <Mod303View,Mod303ManualDialogView> :  RPSGridView<Mod303View,Mod303ManualDialogView> where Mod303View : class, IView where Mod303ManualDialogView : class, IView
    {
        public GetMod303DataPage10GridView(Mod303View currentView,Mod303ManualDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303View>("","#95e5b5ba-843a-42cf-b16b-8e6b8b58ed1a .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303View>("","#95e5b5ba-843a-42cf-b16b-8e6b8b58ed1a .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#95e5b5ba-843a-42cf-b16b-8e6b8b58ed1a .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303View>("","#95e5b5ba-843a-42cf-b16b-8e6b8b58ed1a .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303View> Order { get; set; } 
        public IRPSGridTextBox<Mod303View> Text { get; set; } 
        public IRPSGridTextBox<Mod303View> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303View> AmountCell { get; set; } 
                     
    }
 
    }
  
            
    public partial class Mod303ManualDialogView : View
    {
        public Mod303ManualDialogView(Mod303 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ParentExercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("b9b0cc0e-3dbb-4aa5-8cee-0d0b844cb003","","",false, this);
 
            ParentOptionQuarter = RPSControlFactory.CreateRPSEnumComboBox<Mod303ManualDialogView>("7b4841a7-8bc0-4042-a368-22b2a5fe3ff8","","",false, this);
 
            ParentOptionMes = RPSControlFactory.CreateRPSEnumComboBox<Mod303ManualDialogView>("287372c4-4501-489a-9751-8f2424336500","","",false, this);
 
            ExecuteMod303GetLastOtherDetaOrDefault = RPSControlFactory.CreateRPSButton<Mod303ManualDialogView>( "bced7a20-1e9b-4992-b661-e7485222a1cb","","",this);
 
            ExecuteMod303GetDefaultOtherData = RPSControlFactory.CreateRPSButton<Mod303ManualDialogView>( "df9dc80a-3fce-426f-ba68-49abb8296c71","","",this);
 
            IsMensual = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("b29909f1-286c-4a36-bd29-042854ce2390","","",false, this);
 
            IsSII = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("eaff6ad3-73a6-4189-9cc7-dc6b522e68a0","","",false, this);
 
            IsConjunta = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("076399a7-dffa-4f45-9f5d-0f663aadfce8","","",false, this);
 
            PorcEstatal = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("dea8b48f-86ad-476c-8986-50f039bcb74d","","",false, this);
 
            IsSolo_IVA_Aduana = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("96fdef0e-7264-4712-85f5-2d7cb8227e42","","",false, this);
 
            IsConcurso = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("4baf3add-c54b-4af9-9629-e125e58de8f4","","",false, this);
 
            DTConcurso_Fecha = RPSControlFactory.CreateRPSTextBox<Mod303ManualDialogView>("666eecb1-5589-447e-bdb3-1af4aa291f09","","",false, this);
 
            IsConcurso_Pre = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("1f991c18-4367-42ba-b7cc-a0e7f3f42497","","",false, this);
 
            IsConcurso_Post = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("d315236a-6d1b-419c-a778-440cd7613a74","","",false, this);
 
            IsCaja_Ventas = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("fbdca0e3-b67b-40d9-b482-5f3789045f47","","",false, this);
 
            IsCaja_Compras = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("939c6309-c05b-401f-b57c-d3e460c4561f","","",false, this);
 
            IsProrrata_Aplica = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("50271fc7-c7fa-4d58-b59e-bd243faa605d","","",false, this);
 
            IsProrrata_Revoca = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("aaa71adb-0e0b-4de0-80d3-ec3b7e2d1eff","","",false, this);
 
            Is390No = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("92d34e9e-6188-4db3-a89e-3bf0d8749c63","","",false, this);
 
            I390Exonerado = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("2d374058-0b56-414a-bddb-8f86da1f9ccf","","",false, this);
 
            B390 = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("e2be85f3-c04d-4b6d-9ff7-669913980577","","",false, this);
 
            BVolumen = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("970f2b34-b9d3-46fa-ad0f-84e26576b0e8","","",false, this);
 
            B347 = RPSControlFactory.CreateRPSCheckBox<Mod303ManualDialogView>("a7be84f4-db3f-4ef3-a59d-59bc168e0b27","","",false, this);
 
            PorcVI = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("c2cf6564-370d-4c28-8825-0f0fb89ce84c","","",false, this);
 
            PorcSS = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("69214828-2877-477b-b4bd-70b5a6c19797","","",false, this);
 
            PorcBI = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("cd3255c4-232c-4dba-929b-ae50887ff210","","",false, this);
 
            PorcNAVARRA = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("5a68a63c-5547-4fe1-a7e1-eaf821d50c3f","","",false, this);
 
            PorcTERRI_COMUN = RPSControlFactory.CreateRPSFormattedTextBox<Mod303ManualDialogView>("4432b686-c7a8-4905-adfb-ec1e74fe1e71","","",false, this);
 
            CollectionInit params_Mod303GetSavedManualData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9df04395-9fcf-4db5-9e1f-4e4a0f100280",CSSSelectorGrid="",XPathGrid=""};
            Mod303GetSavedManualData = RPSControlFactory.RPSCreateCollectionWithGrid<Mod303GetSavedManualDataCollectionEditor<Mod303ManualDialogView>,Mod303ManualDialogView>( params_Mod303GetSavedManualData,this);
 
            CollectionInit params_Mod303GetSavedManualDataYear = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dacb4b56-17d8-489e-81c6-aeedc86561c7",CSSSelectorGrid="",XPathGrid=""};
            Mod303GetSavedManualDataYear = RPSControlFactory.RPSCreateCollectionWithGrid<Mod303GetSavedManualDataYearCollectionEditor<Mod303ManualDialogView>,Mod303ManualDialogView>( params_Mod303GetSavedManualDataYear,this);
 
            Section = RPSControlFactory.CreateRPSSection<Mod303ManualDialogView>( "","ul li[rpsid='7635738f-9cc5-4dca-a944-f30adc7b2823']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<Mod303ManualDialogView>( "","ul li[rpsid='1568e5ba-bfc6-4e15-82a7-22b3a443347f']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<Mod303ManualDialogView>( "","ul li[rpsid='9ff88a52-b400-4ccf-8048-5c333729af38']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<Mod303ManualDialogView>( "","ul li[rpsid='dcd6faee-7d3e-4d21-890d-2f2b5a8852d9']","",this);
 

        }
        public IRPSTextBox<Mod303ManualDialogView> ParentExercise { get; set; } 
        public IRPSComboBox<Mod303ManualDialogView> ParentOptionQuarter { get; set; } 
        public IRPSComboBox<Mod303ManualDialogView> ParentOptionMes { get; set; } 
        public IRPSButton<Mod303ManualDialogView> ExecuteMod303GetLastOtherDetaOrDefault { get; set; } 
        public IRPSButton<Mod303ManualDialogView> ExecuteMod303GetDefaultOtherData { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsMensual { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsSII { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsConjunta { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcEstatal { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsSolo_IVA_Aduana { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsConcurso { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> DTConcurso_Fecha { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsConcurso_Pre { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsConcurso_Post { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsCaja_Ventas { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsCaja_Compras { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsProrrata_Aplica { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> IsProrrata_Revoca { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> Is390No { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> I390Exonerado { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> B390 { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> BVolumen { get; set; } 
        public IRPSCheckbox<Mod303ManualDialogView> B347 { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcVI { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcSS { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcBI { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcNAVARRA { get; set; } 
        public IRPSTextBox<Mod303ManualDialogView> PorcTERRI_COMUN { get; set; } 
        public Mod303GetSavedManualDataCollectionEditor<Mod303ManualDialogView> Mod303GetSavedManualData { get; set; } 
        public Mod303GetSavedManualDataYearCollectionEditor<Mod303ManualDialogView> Mod303GetSavedManualDataYear { get; set; } 
        public IRPSSection<Mod303ManualDialogView> Section { get; set; } 
        public IRPSSection<Mod303ManualDialogView> Section1 { get; set; } 
        public IRPSSection<Mod303ManualDialogView> Section2 { get; set; } 
        public IRPSSection<Mod303ManualDialogView> Section3 { get; set; } 
        public Mod303 Screen { get; set; }
        public Mod303ManualDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class Mod303GetSavedManualDataCollectionEditor<Mod303ManualDialogView>:RPSCollectionEditor<Mod303ManualDialogView> where Mod303ManualDialogView : class, IView
    {
        public  Mod303GetSavedManualDataGridView<Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class Mod303GetSavedManualDataGridView <Mod303ManualDialogView> :  RPSGridView<Mod303ManualDialogView> where Mod303ManualDialogView : class, IView
    {
        public Mod303GetSavedManualDataGridView(Mod303ManualDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PageName = RPSControlFactory.CreateRPSGridTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cPageName']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            BaseValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cBaseValue']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 
            AmountValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303ManualDialogView>("","#9df04395-9fcf-4db5-9e1f-4e4a0f100280 .ag-row[role='row']@ROWINDEX [col-id='cAmountValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303ManualDialogView> PageName { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> Text { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> BaseValue { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> AmountCell { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> AmountValue { get; set; } 
                     
    }
 
        public partial class Mod303GetSavedManualDataYearCollectionEditor<Mod303ManualDialogView>:RPSCollectionEditor<Mod303ManualDialogView> where Mod303ManualDialogView : class, IView
    {
        public  Mod303GetSavedManualDataYearGridView<Mod303ManualDialogView> GridView {get;set;}
    }
    public partial class Mod303GetSavedManualDataYearGridView <Mod303ManualDialogView> :  RPSGridView<Mod303ManualDialogView> where Mod303ManualDialogView : class, IView
    {
        public Mod303GetSavedManualDataYearGridView(Mod303ManualDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Text = RPSControlFactory.CreateRPSGridMemoTextBox<Mod303ManualDialogView>("","#dacb4b56-17d8-489e-81c6-aeedc86561c7 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            BaseCell = RPSControlFactory.CreateRPSGridTextBox<Mod303ManualDialogView>("","#dacb4b56-17d8-489e-81c6-aeedc86561c7 .ag-row[role='row']@ROWINDEX [col-id='cBaseCell']","",false, this.CurrentView);
 
            BaseValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303ManualDialogView>("","#dacb4b56-17d8-489e-81c6-aeedc86561c7 .ag-row[role='row']@ROWINDEX [col-id='cBaseValue']","",false, this.CurrentView);
 
            AmountCell = RPSControlFactory.CreateRPSGridTextBox<Mod303ManualDialogView>("","#dacb4b56-17d8-489e-81c6-aeedc86561c7 .ag-row[role='row']@ROWINDEX [col-id='cAmountCell']","",false, this.CurrentView);
 
            AmountValue = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod303ManualDialogView>("","#dacb4b56-17d8-489e-81c6-aeedc86561c7 .ag-row[role='row']@ROWINDEX [col-id='cAmountValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod303ManualDialogView> Text { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> BaseCell { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> BaseValue { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> AmountCell { get; set; } 
        public IRPSGridTextBox<Mod303ManualDialogView> AmountValue { get; set; } 
                     
    }
 
    }
  
    

}