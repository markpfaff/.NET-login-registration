using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISTLoginService" in both code and config file together.
[ServiceContract]
public interface ISTLoginService
{
    [OperationContract]
    int VenueLogin(string password, string username);
    [OperationContract]
    int VenueRegistration(VenueLite v);


}
[DataContract]
public class VenueLite
{
    [DataMember]
    public string VenueName  {set; get;}
    [DataMember]
    public string venueAddress { set; get; }
    [DataMember]
    public string venueCity { set; get; }
    [DataMember]
    public string venueState { set; get; }
    [DataMember]
    public string venueZipCode { set; get; }
    [DataMember]
    public string venuePhone { set; get; }
    [DataMember]
    public string venueEmail { set; get; }
    [DataMember]
    public string venueWebPage { set; get; }
    [DataMember]
    public int venueAgeRestriction { set; get; }
    [DataMember]
    public string venueLoginUserName { set; get; }
    [DataMember]
    public string venuLoginPasswordPlain { set; get; }
}