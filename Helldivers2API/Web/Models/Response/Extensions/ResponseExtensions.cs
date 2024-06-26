﻿using Helldivers2API.Data.Models;
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

        // assignments
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

        // news feed
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

            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            dataNewsfeed.PublishedAsDate = DateTime.Now.AddSeconds(dataNewsfeed.Published - warStatus.Time);

            return dataNewsfeed;
        }

        // war info
        internal static Helldivers2API.Data.Models.WarInfo GetDataModel(this WarInfo warinfo)
        {
            var dataWarinfo = new Helldivers2API.Data.Models.WarInfo()
            {
                WarId = warinfo.WarId,
                EndDate = warinfo.EndDate,
                StartDate = warinfo.StartDate
            };

            // planet infos
            var planetInfos = new List<Helldivers2API.Data.Models.PlanetInfo>();
            foreach (var item in warinfo.PlanetInfos)
            {
                planetInfos.Add(new Helldivers2API.Data.Models.PlanetInfo()
                {
                    Id = item.Index,
                    Disabled = item.Disabled,
                    InitialOwner = item.InitialOwner,
                    MaxHealth = item.MaxHealth,
                    Waypoints = item.Waypoints.ToArray(),
                    Position = new Helldivers2API.Data.Models.Position() { X = item.Position.X, Y = item.Position.Y }
                });
            }
            dataWarinfo.PlanetInfos = planetInfos.ToArray();

            // home worlds
            var homes = new List<Helldivers2API.Data.Models.HomeWorld>();
            foreach (var item in warinfo.HomeWorlds)
            {
                homes.Add(new Helldivers2API.Data.Models.HomeWorld()
                {
                    PlanetIndices = item.PlanetIndices.ToArray(),
                    Faction = item.Race
                });
            }
            dataWarinfo.HomeWorlds = homes.ToArray();

            return dataWarinfo;
        }


        // war status
        internal static Helldivers2API.Data.Models.WarStatus GetDataModel(this WarStatus warstatus, long ticks)
        {
            var dataWarStatus = new Helldivers2API.Data.Models.WarStatus()
            {
                WarId = warstatus.WarId,
                Time = warstatus.Time,       
                TimeAsDateTime = new DateTime(ticks),
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
                    OwnerId = item.Owner,                    
                    Health = item.Health,
                    RegenPerSecond = item.RegenPerSecond,
                    PlayerCount = item.Players                    
                });
            }
            dataWarStatus.PlanetStatuses = planetStatuses.ToArray();

            // planet attacks
            var planetAttacks = new List<Helldivers2API.Data.Models.PlanetAttack>();
            foreach (var item in warstatus.PlanetAttacks) 
            {
                planetAttacks.Add(new Helldivers2API.Data.Models.PlanetAttack()
                {
                     SourceId = item.source,
                     TargetId = item.target
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
            dataWarStatus.JointOperations = jointOps.ToArray();

            // planet events
            var planetEvents = new List<Helldivers2API.Data.Models.PlanetEvent>();
            foreach (var item in warstatus.PlanetEvents) 
            {
                planetEvents.Add(new Helldivers2API.Data.Models.PlanetEvent()
                {
                    Id = item.Id,
                    PlanetId = item.PlanetIndex,
                    EventType = item.EventType,
                    FactionId = item.Race,
                    Health = item.Health,
                    MaxHealth = item.MaxHealth,
                    StartTime = item.StartTime,
                    ExpireTime = item.ExpireTime,
                    CampaignId = item.CampaignId,
                    Started = DateTime.Now.AddSeconds(item.StartTime - dataWarStatus.Time),
                    TotalTime = new TimeSpan(0, 0, item.ExpireTime - item.StartTime),
                    Ending = DateTime.Now.AddSeconds(item.ExpireTime - dataWarStatus.Time),
                    JointOperationIds = item.JointOperationIds.ToArray()                    
                });
                
            }
            dataWarStatus.PlanetEvents = planetEvents.ToArray();

            // global events
            var globalEvents = new List<Helldivers2API.Data.Models.GlobalEvent>();
            foreach (var item in warstatus.GlobalEvents)
            {
                globalEvents.Add(new Helldivers2API.Data.Models.GlobalEvent()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Message = item.Message,
                    FactionId = item.Race,
                    EffectIds = item.EffectIds.ToArray(),
                    PlanetIds = item.PlanetIndices.ToArray()
                });
            }
            dataWarStatus.GlobalEvents = globalEvents.ToArray();

            return dataWarStatus;
        }

        // war stats
        internal static Helldivers2API.Data.Models.WarStats GetDataModel(this WarStats warstats)
        {
            var dataWarstats = new Helldivers2API.Data.Models.WarStats()
            {
                GalaxyStats = new Helldivers2API.Data.Models.GalaxyStats()
                {
                    Accurracy = warstats.GalaxyStats.Accurracy,
                    AutomatonKills = warstats.GalaxyStats.AutomatonKills,
                    BugKills = warstats.GalaxyStats.BugKills,
                    BulletsFired = warstats.GalaxyStats.BulletsFired,
                    BulletsHit = warstats.GalaxyStats.BulletsHit,
                    Deaths = warstats.GalaxyStats.Deaths,
                    Friendlies = warstats.GalaxyStats.Friendlies,
                    IlluminateKills = warstats.GalaxyStats.IlluminateKills,
                    MissionsLost = warstats.GalaxyStats.MissionsLost,
                    MissionSuccessRate = warstats.GalaxyStats.MissionSuccessRate,
                    MissionsWon = warstats.GalaxyStats.MissionsWon,
                    MissionTime = warstats.GalaxyStats.MissionTime,
                    Revives = warstats.GalaxyStats.Revives,
                    TimePlayed = warstats.GalaxyStats.TimePlayed
                }
            };

            // planet stats
            var planetStats = new List<Helldivers2API.Data.Models.PlanetStats>();
            foreach (var item in warstats.PlanetStats)
            {
                planetStats.Add(new Helldivers2API.Data.Models.PlanetStats()
                {
                    Id = item.PlanetIndex,
                    Accurracy = item.Accurracy,
                    AutomatonKills = item.AutomatonKills,
                    BugKills = item.BugKills,
                    BulletsFired = item.BulletsFired,
                    BulletsHit = item.BulletsHit,
                    Deaths = item.Deaths,
                    Friendlies = item.Friendlies,
                    IlluminateKills = item.IlluminateKills,
                    MissionsLost = item.MissionsLost,
                    MissionSuccessRate = item.MissionSuccessRate,
                    MissionsWon = item.MissionsWon,
                    MissionTime = item.MissionTime,
                    Revives = item.Revives,
                    TimePlayed = item.TimePlayed
                });
            }
            dataWarstats.PlanetStats = planetStats.ToArray();

            return dataWarstats;
        }
    }    
}
