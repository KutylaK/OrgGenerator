using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using dc = DevExpress.ExpressApp.DC;

namespace DivisonsProject.Module.BusinessObjects
{
    [dc.XafDisplayName("Jednostka")]
    [NavigationItem("Jednostki")]
    [Exportable]
    public class Org : XPObject
    {
        public Org() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Org(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        string name;
        [dc.XafDisplayName("Nazwa")]
        [Exportable]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Association("Org-Employees")]
        [dc.XafDisplayName("Pracownicy")]
        [Exportable]
        public XPCollection<Employee> Employees => GetCollection<Employee>(nameof(Employees));

        [Association("Org-Workplaces")]
        [dc.XafDisplayName("Siedziby")]
        [Exportable]
        public XPCollection<Workplace> Workplaces => GetCollection<Workplace>(nameof(Workplaces));

    }

}