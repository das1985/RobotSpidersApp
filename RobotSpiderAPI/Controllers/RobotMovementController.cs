using Microsoft.AspNetCore.Mvc;
using RobotSpidersApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RobotSpiderAPI.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class RobotMovementController : ControllerBase
    {
        private readonly IRobotServices _robotServices;
        public RobotMovementController(IRobotServices robotServices)
        {
            _robotServices = robotServices;
        }

        //Gets the robot final coordinate and orientation.
        [HttpGet]
        [Route("api/GetRobotFinalPosition")]
        public Tuple<int, int, char> GetRobotFinalCoordinateAndOrientation(Tuple<int, int> robotMaxCoordinates,
            Tuple<int, int, char> robotInitialCoordinatesAndOrientation, string robotInstruction)
        {
            return _robotServices.GetRobotFinalCoordinateAndOrientation(robotMaxCoordinates, robotInitialCoordinatesAndOrientation, robotInstruction);
        }

    }
}
