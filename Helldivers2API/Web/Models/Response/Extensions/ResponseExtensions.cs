using Helldivers2API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        internal static Helldivers2API.Data.Models.NewsFeed GetDataModel(this WarFeed warfeed)
        {
            var dataNewsfeed = new NewsFeed()
            {
                Id = warfeed.Id,
                Published = warfeed.Published,
                Type = warfeed.Type,
                Message = warfeed.Message,
                TagIds = warfeed.TagIds.ToArray()
            };

            return dataNewsfeed;
        }

        internal static Helldivers2API.Data.Models.WarStatus GetDataModel(this WarStatus warstatus)
        {
            var dataWarStatus = new Helldivers2API.Data.Models.WarStatus()
            {
                WarId = warstatus.WarId,
                Time = warstatus.Time,
                ImpactMultiplier = warstatus.ImpactMultiplier,
                StoryBeatId32 = warstatus.StoryBeatId32                        
            };

            // planet statuses
            var planetStatuses = new List<Helldivers2API.Data.Models.PlanetStatus>();
            foreach (var item in warstatus.PlanetStatus)
            {
                planetStatuses.Add(new Helldivers2API.Data.Models.PlanetStatus()
                {
                    Id = item.Index,
                    Owner = item.Owner,                    
                    Health = item.Health,
                    RegenPerSecond = item.RegenPerSecond,
                    Players = item.Players                    
                });
            }
            dataWarStatus.PlanetStatuses = planetStatuses.ToArray();

            // planet attacks
            var planetAttacks = new List<Helldivers2API.Data.Models.PlanetAttack>();
            foreach (var item in warstatus.PlanetAttacks) 
            {
                planetAttacks.Add(new Helldivers2API.Data.Models.PlanetAttack()
                {
                     source = item.source,
                     target = item.target
                });
            }
            dataWarStatus.PlanetAttacks = planetAttacks.ToArray();  

            // campaigns
            var campaigns = new List<Helldivers2API.Data.Models.Campaign>(); 
            foreach (var item in warstatus.Campaigns)
            {
                campaigns.Add(new Helldivers2API.Data.Models.Campaign()
                {
                    Id = item.Id,
                    PlanetId = item.PlanetIndex,
                    Count = item.Count,                                       
                    Type = item.Type
                });
            }
            dataWarStatus.Campaigns = campaigns.ToArray();  

            // joint ops
            var jointOps = new List<Helldivers2API.Data.Models.JointOperation>();
            foreach(var item in warstatus.JointOperations)
            {
                jointOps.Add(new Helldivers2API.Data.Models.JointOperation()
                {
                    Id = item.Id,
                    PlanetId = item.PlanetIndex,
                    HqNodeIndex = item.HqNodeIndex
                });
            }

            // planet events
            var planetEvents = new List<Helldivers2API.Data.Models.PlanetEvent>();
            foreach (var item in warstatus.PlanetEvents) 
            {
                planetEvents.Add(new Helldivers2API.Data.Models.PlanetEvent()
                {
                    Id = item.Id,
                    PlanetId = item.PlanetIndex,
                    EventType = item.EventType,
                    Race = item.Race,
                    Health = item.Health,
                    MaxHealth = item.MaxHealth,
                    StartTime = item.StartTime,
                    ExpireTime = item.ExpireTime,
                    CampaignId = item.CampaignId,
                    JointOperationIds = item.JointOperationIds.ToArray()
                });
            }


            return dataWarStatus;
        }
    }    
}
