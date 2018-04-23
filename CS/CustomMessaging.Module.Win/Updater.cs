using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Data.Filtering;

namespace CustomMessaging.Module.Win {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Person person1 = ObjectSpace.FindObject<Person>(
            CriteriaOperator.Parse("FirstName == 'Robert' && LastName == 'King'"));
            Person person2 = ObjectSpace.FindObject<Person>(
            CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if (person1 == null) {
                person1 = ObjectSpace.CreateObject<Person>();
                person1.FirstName = "Robert";
                person1.LastName = "King";
                person1.Save();
            }
            if (person2 == null) {
                person2 = ObjectSpace.CreateObject<Person>();
                person2.FirstName = "Mary";
                person2.LastName = "Tellitson";
                person2.Save();
            }
        }
    }
}
