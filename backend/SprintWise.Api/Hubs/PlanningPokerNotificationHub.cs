using Microsoft.AspNetCore.SignalR;
using MiNET.Utils;
using System.Text.Json.Serialization;

namespace SprintWise.Api.Hubs
{
    public interface IPlanningPokerNotificationClient {
        Task SendPlanningVote(UserTaskVote vote);
    }

    public sealed class PlanningPokerNotificationHub : Hub<IPlanningPokerNotificationClient>
    {
        //public async Task SendPlanningVote(UserTaskVote vote)
        //{
        //    await Clients.All.SendPlanningVote(vote);
        //}

        public async Task JoinPlanningGroup(string planningId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, planningId);
        }

        public async Task LeavePlanningGroup(string planningId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, planningId);
        }
    }




    public class UserTaskVote {
        [JsonConverter(typeof(UUIDJsonConverter))]
        public UUID TaskId { get; set; }

        [JsonConverter(typeof(UUIDJsonConverter))]
        public UUID PlanningId { get; set; }

        public int VoteValue { get; set; }

        [JsonConverter(typeof(UUIDJsonConverter))]
        public UUID UserId { get; set; }
    }

}
