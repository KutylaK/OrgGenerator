using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using dc = DevExpress.ExpressApp.DC;

namespace DivisonsProject.Module.BusinessObjects
{
    [dc.XafDisplayName("Pracownicy")]
    [NavigationItem("Pracownik")]
    [Exportable]
    public class Employee : XPObject
    {
        public Employee() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Employee(Session session) : base(session)
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

        string firstName;
        [dc.XafDisplayName("Imię")]
        [Exportable]
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }

        string lastName;
        [dc.XafDisplayName("Nazwisko")]
        [Exportable]
        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }

        Adress adress;
        [dc.XafDisplayName("Adress"),Aggregated]
        [Exportable]
        [ExpandObjectMembers(ExpandObjectMembers.Always)]
        public Adress Adress
        {
            get => adress;
            set => SetPropertyValue(nameof(Adress), ref adress, value);
        }

        Org org;
        [dc.XafDisplayName("Jednostka")]
        [Association("Org-Employees")]
        [Exportable]
        public Org Org
        {
            get => org;
            set => SetPropertyValue(nameof(Org), ref org, value);
        }
    }

}