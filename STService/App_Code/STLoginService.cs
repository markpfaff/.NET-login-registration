using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "STLoginService" in code, svc and config file together.
public class STLoginService : ISTLoginService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public int VenueLogin(string password, string username)
    {
        int result = db.usp_venueLogin(username, password);
        if (result != -1)
        {
            var key = from k in db.Venues
                      where k.VenueName.Equals(username)
                      select new { k.VenueKey };

            foreach (var k in key)
            {
                result = (int)k.VenueKey;
            }
        }
        return result;
    }

    public int VenueRegistration(VenueLite v)
    {
        int result = db.usp_RegisterVenue(
            v.VenueName, v.venueAddress, v.venueCity,
             v.venueState, v.venueZipCode, v.venuePhone,
              v.venueEmail, v.venueWebPage, v.venueAgeRestriction,
               v.venueLoginUserName, v.venuLoginPasswordPlain
            );
        return result;
    }
}
