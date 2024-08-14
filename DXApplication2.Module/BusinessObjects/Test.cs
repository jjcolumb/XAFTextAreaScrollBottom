using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXApplication2.Module.BusinessObjects
{
    [DefaultClassOptions]
   
    public class Test : BaseObject
    { 
        public Test(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string body;

        [Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.HtmlPropertyEditor)]
        public string Body
        {
            get => body;
            set => SetPropertyValue(nameof(Body), ref body, value);
        }


    }
}