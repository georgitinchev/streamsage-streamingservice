using DesktopApp;
using DTOs;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreamSageWAD
{

    [TestClass]
    public class WebControllerTests
    {
        [TestMethod]
        public void LoginUser_ValidCredentials_SetsLoggedInUser()
        {
           // To be implemented after switching the webcontroller's dependency on IBackendService properly and getting rid of the direct instantiation of BackendService
        }
    }

}
