using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using dc = DevExpress.ExpressApp.DC;

namespace DivisonsProject.Module.BusinessObjects
{
    [dc.XafDisplayName("Adres")]
    [Exportable]
    public class Adress : XPObject
    {
        
        public Adress() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Adress(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        string city;
        [dc.XafDisplayName("Miasto")]
        [Exportable]
        public string City
        {
            get { return city; }
            set { SetPropertyValue(nameof(City), ref city, value); }
        }

        string street;
        [dc.XafDisplayName("Ulica")]
        [Exportable]
        public string Street
        {
            get { return street; }
            set { SetPropertyValue(nameof(Street), ref street, value); }
        }

        string number;
        [dc.XafDisplayName("Numer")]
        [Exportable]
        public string Number
        {
            get { return number; }
            set { SetPropertyValue(nameof(Number), ref number, value); }
        }
    }

}