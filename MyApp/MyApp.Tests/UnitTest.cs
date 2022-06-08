using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using MyApp.ServiceInterface;
using MyApp.ServiceModel;
using System.Linq;
using Data;
using System.Collections.Generic;

namespace MyApp.Tests
{
    public class UnitTest
    {

        [Test]
        public void GetDetailsByID_UserFound_ReturnDetails()
        {
            FarmerService obj = new FarmerService();
            DataRequestID requestID = new DataRequestID { id = 1 };
            var res = obj.Any(requestID);

            List<FUser> Expectresult =  new List<FUser>();
            Expectresult.Add(new FUser
            {
                id = 1,
                fname = "Amol Pawale",
                mobile = 8806622147,
                usertype = "Fuser"
            });

            Assert.AreEqual(Expectresult[0].id, res[0].id);
            Assert.AreEqual(Expectresult[0].fname, res[0].fname);
            Assert.AreEqual(Expectresult[0].mobile, res[0].mobile);
            Assert.AreEqual(Expectresult[0].usertype, res[0].usertype);

        }

        [Test]
        public void GetDetailsByID_UserNotFound_ReturnDetails()
        {
            FarmerService obj = new FarmerService();
            DataRequestID requestID = new DataRequestID { id = 0 };
            var res = obj.Any(requestID);

            Assert.IsEmpty(res);

        }

        [Test]
        public void 

    }
}
