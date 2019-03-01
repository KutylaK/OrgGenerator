using System;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using dc = DevExpress.ExpressApp.DC;

namespace DivisonsProject.Module.BusinessObjects
{
    [dc.XafDisplayName("Siedziba")]
    [NavigationItem("Siedziby")]
    [Exportable]
    public class Workplace : XPObject
    {
        public Workplace() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Workplace(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Adress = new Adress(Session);
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


        Adress adress;
        [dc.XafDisplayName("Adres"),Aggregated]
        [Exportable]
        public Adress Adress
        {
            get => adress;
            set => SetPropertyValue(nameof(Adress), ref adress, value);
        }

        Org org;
        [dc.XafDisplayName("Jednostka")]
        [Association("Org-Workplaces")]
        [Exportable]
        public Org Org
        {
            get => org;
            set => SetPropertyValue(nameof(Org), ref org, value);
        }
    }

}