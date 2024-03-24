using Helldivers2API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Web.Models.Response.Extensions
{
    internal static class ResponseExtensions
    {
        internal static Helldivers2API.Data.Models.Assignment GetDataModel(this Assignment assignment)
        {
            var dataAssignment = new Helldivers2API.Data.Models.Assignment()
            {
                Id = assignment.Id32,
                ExpiresIn = assignment.ExpiresIn,
                Progress = assignment.Progress.ToArray(),
                Type = assignment.Setting.Type,
                Title = assignment.Setting.OverrideTitle,
                Brief = assignment.Setting.OverrideBrief,
                Description = assignment.Setting.TaskDescription,
                Flags = assignment.Setting.Flags,
                RewardType = assignment.Setting.Reward.Type,
                RewardAmount = assignment.Setting.Reward.Amount
            };

            var dataTasks = new List<Helldivers2API.Data.Models.AssignmentTask>();
            foreach(var task in assignment.Setting.Tasks)
            {
                var dataTask = new Helldivers2API.Data.Models.AssignmentTask()
                {
                    Type = task.Type,
                    Values = task.Values.ToArray(),
                    ValueTypes = task.ValueTypes.ToArray()
                };
                dataTasks.Add(dataTask);
            }

            dataAssignment.Tasks = dataTasks.ToArray();
            return dataAssignment;
        }
    }
}
