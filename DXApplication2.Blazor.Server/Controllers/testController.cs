using DevExpress.Data.Filtering;
using DevExpress.Data.Utils;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraRichEdit.Layout;
using DXApplication2.Module.BusinessObjects;
using Microsoft.CodeAnalysis.Text;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Text;

namespace DXApplication2.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class testController : ObjectViewController<DetailView, Test>
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public testController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            this.TargetObjectType = typeof(Test);
            TargetViewType = ViewType.DetailView;

            SimpleAction simpleAction = new SimpleAction(this, "TestAction", PredefinedCategory.View);
            simpleAction.Caption = "Test";
            simpleAction.Execute += SimpleAction_Execute;

            SimpleAction simpleAction1 = new SimpleAction(this, "TestAction1", PredefinedCategory.View);
            simpleAction1.Caption = "Test1";
            simpleAction1.Execute += SimpleAction_Execute1;
        }
        Test mytest;
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
           
            mytest = (Test)this.View.CurrentObject;


        }

        private void SimpleAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var myvar = ObjectSpace.ServiceProvider.GetRequiredService<IJSRuntime>();
            mytest.Body += $"{mytest.Body}{Environment.NewLine}{"test"}";
            myvar.InvokeVoidAsync("moveCursorToEndByClass", "dxbl-v-resize");


            //for (int i = 0; i < 101; i++)
            //{
            //   mytest.Body += $"{mytest.Body}{Environment.NewLine}{i}";
            //    myvar.InvokeVoidAsync("moveCursorToEndByClass");
            //}




            this.View.ObjectSpace.CommitChanges();
        }

        private void SimpleAction_Execute1(object sender, SimpleActionExecuteEventArgs e)
        {
            var myvar = ObjectSpace.ServiceProvider.GetRequiredService<IJSRuntime>();
            mytest.Body += $"{mytest.Body}{Environment.NewLine}{"test"}";
            myvar.InvokeVoidAsync("adjustTextareaHeight", "dxbl-v-resize");


            //for (int i = 0; i < 101; i++)
            //{
            //   mytest.Body += $"{mytest.Body}{Environment.NewLine}{i}";
            //    myvar.InvokeVoidAsync("moveCursorToEndByClass");
            //}




            this.View.ObjectSpace.CommitChanges();
        }




        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
