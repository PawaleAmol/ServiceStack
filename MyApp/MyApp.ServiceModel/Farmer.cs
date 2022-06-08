using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ServiceStack;

namespace MyApp.ServiceModel
{
    [Route("/Farmer/{id}")]
    public class DataRequestID 
        {
            public int id { get; set; }
        }


    [Route("/Farmer/groupid/{groupId}")]
    public class DataRequestGroupId
    {
        public int groupId { get; set; }
    }

    //get all groups farmers belongs to 
    [Route("/Farmer/getgroup/{farmerid}")]
    public class DataRequestFarmerId
    {
        public int farmerid { get; set; }
    }
}
