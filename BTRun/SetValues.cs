using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTRun
{
    public class SetValues
    {
        public void SetThreeToDatabase()
        {
            string config = ConfigurationManager
                .ConnectionStrings["BTRun.Properties.Settings.BTDatabaseConnectionString"].ConnectionString;
            using (DemoDataClassesDataContext db = new DemoDataClassesDataContext(config))
            {
                ThreesAllTheWayDown t3 = new ThreesAllTheWayDown { ThemWillBeThree = 3 };
                db.ThreesAllTheWayDowns.InsertOnSubmit(t3);
                db.SubmitChanges();
            }
        }
    }
}
