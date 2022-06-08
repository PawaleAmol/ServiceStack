using ServiceStack;
using MyApp.ServiceModel;
using System.Linq;
using AutoMapper;
using System.Data.Entity;
using Data;
using MyApp.ServiceInterface.Model;
using System.Collections.Generic;

namespace MyApp.ServiceInterface
{
    public  class FarmerService : Service
    {
        readonly FarmerEntities dbcontext = new FarmerEntities();

        public List<FGroup> Any(DataRequestFarmerId request)
        {
            var Farmer = dbcontext.FGroups.Where(q => q.uid == request.farmerid);

            return Farmer.ToList();
        }


        public object Any(DataRequestGroupId request)
        {
            
            var groups = dbcontext.FGroups.Where(q => q.gid == request.groupId);
           
                var farmer = (from user in dbcontext.FUsers
                              join gro in groups on user.id equals gro.uid

                              select new
                              {
                                  user.id,
                                  user.fname,
                                  user.mobile,
                                  user.usertype,
                                  gro.name
                              }
                              );
            
            return farmer;
        }

        public List<FUser> Any(DataRequestID request)
        {
            var Farmer = dbcontext.FUsers.Where(q => q.id == request.id);
            return Farmer.ToList(); ;
        }
    }
}
