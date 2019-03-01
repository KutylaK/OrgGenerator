using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DivisonsProject.Module.BusinessObjects;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisonsProject.Module.Controllers
{
    public partial class GenerateClassesController : DevExpress.ExpressApp.ViewController
    {
        public SimpleAction Action;
        public GenerateClassesController()
        {

            Action = new SimpleAction(this, "ExportEmployee", PredefinedCategory.Tools);
            Action.Caption = "Eksportuj klasę pracownika";
            Action.Execute += CompileExecutable;
        }

        public void CompileExecutable(object sender, SimpleActionExecuteEventArgs e)
        {
            var info = typeof(Employee);
            var p = info.GetMembers();
            var model = typeof(Adress).Assembly.GetTypes();
            var eee = model.Where(_ => _.CustomAttributes.Any(x=>x.AttributeType == typeof(ExportableAttribute)));
        }
    }
}
