using Microsoft.AspNetCore.Mvc;
using Mission10.Data;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {

            var joinedData = from Bowlers in _bowlerRepository.Bowlers
                             join Teams in _bowlerRepository.Teams on Bowlers.teamID equals Teams.teamID
                             select new JoinedBowler
                             {
                                 bowlerID = Bowlers.bowlerID,
                                 bowlerLastName = Bowlers.bowlerLastName,
                                 bowlerFirstName = Bowlers.bowlerFirstName,
                                 bowlerMiddleInit = Bowlers.bowlerMiddleInit,
                                 bowlerAddress = Bowlers.bowlerAddress,
                                 bowlerCity = Bowlers.bowlerCity,
                                 bowlerState = Bowlers.bowlerState,
                                 bowlerZip = Bowlers.bowlerZip,
                                 bowlerPhoneNumber = Bowlers.bowlerPhoneNumber,
                                 teamID = Bowlers.teamID,
                                 teamName = Teams.teamName
                             };
            return joinedData.Where(data => data.teamName == "Marlins" || data.teamName == "Sharks").ToList();
        }
    }
}
