using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SprintWise.Api.Hubs;

namespace SprintWise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanningPokerController : ControllerBase
    {
        [HttpPost("SendVoteTask")]
        public async Task<IActionResult> SendVoteTask(
            [FromBody] UserTaskVote vote,
            IHubContext<PlanningPokerNotificationHub, IPlanningPokerNotificationClient> hubClient)
        {

            string planningGroupId = vote.PlanningId.ToString();
            await hubClient.Clients.Group(planningGroupId).SendPlanningVote(vote);

            return await Task.FromResult<IActionResult>(Ok(new { message = "Vote task sent successfully!" }));
        }
    }
}
