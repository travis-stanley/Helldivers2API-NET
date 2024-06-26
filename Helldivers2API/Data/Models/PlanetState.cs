﻿using Helldivers2API.Data.Models.Extensions;
using Helldivers2API.Data.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Data.Models
{
    /// <summary>
    /// Planet state consolidates useful information about a planet.
    /// If a planet is defending vs attacking, it changes how we should present information.
    /// </summary>
    public class PlanetState
    {
        /// <summary>
        /// If the planet is being liberated or defended
        /// </summary>
        public PlanetStateCL State { get; internal set; }

        /// <summary>
        /// Get remaining health (0.0 to 1.0)
        /// </summary>
        public float RemainingHealth { get; internal set; }

        /// <summary>
        /// Progress 0.0 - 1.0
        /// Progress is dependent on the state.  
        /// If the planet is being liberated, then progress is at 100% when the health is at 0.
        /// If the planet is being defending, the progress is product of remaining time.
        /// </summary>
        public double Progress { get; internal set; }


        public PlanetState(IPlanet planet) { Build(planet); }
        private void Build(IPlanet planet)
        {
            this.State = GetState(planet);
            this.RemainingHealth = GetRemainingHealth(planet);
            this.Progress = GetProgress(planet);
        }

        private static PlanetStateCL GetState(IPlanet planet)
        {
            var currentOwner = planet.Owner();
            if (currentOwner != null)
            {
                // all other factions are hostile at this time
                var isFriendly = currentOwner.GetType() == typeof(Humans);

                var conflicts = planet.Conflicts();
                if (conflicts.Length > 0)
                {
                    // if the planet is in conflict, and is friendly, we are defending
                    if (isFriendly) return PlanetStateCL.BeingDefended;
                    
                    // hostile is defending, thus we are liberating
                    return PlanetStateCL.BeingLiberated;                    
                }

                if (isFriendly) return PlanetStateCL.IdleFriendly;
                return PlanetStateCL.IdleHostile;
            }           
            return PlanetStateCL.Unknown;
        }

        private static float GetRemainingHealth(IPlanet planet)
        {
            var health = planet.Health();
            var maxHealth = planet.MaxHealth();
            if (!health.HasValue || !maxHealth.HasValue) return 0f;
            return health.Value / (float)maxHealth.Value;
        }

        private double GetProgress(IPlanet planet)
        {
            if (this.State == PlanetStateCL.Unknown) return 1f;
            if (this.State == PlanetStateCL.IdleFriendly) return 1f;
            if (this.State == PlanetStateCL.IdleHostile) return 0f;

            if (this.State == PlanetStateCL.BeingLiberated)
                return 1 - this.RemainingHealth;
            if (this.State == PlanetStateCL.BeingDefended)
            {
                // this is the product of remaining time, found in PlanetEvent
                // some public data has a different calculation for this
                var planetEvent = planet.PlanetEvents().FirstOrDefault();
                if (planetEvent != null)
                {
                    var totalTime = planetEvent.TotalTime!.Value.TotalSeconds;
                    var remainingTime = planetEvent.Ending!.Value.Subtract(DateTime.Now).TotalSeconds;
                    return 1 - (remainingTime / totalTime);
                }
            }                

            return 1f;
        }
    }

    /// <summary>
    /// The combat state of a planet
    /// </summary>
    public enum PlanetStateCL
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown,

        /// <summary>
        /// Under friendly control, not being attacked
        /// </summary>
        IdleFriendly,

        /// <summary>
        /// Under hostile control, not being liberated
        /// </summary>
        IdleHostile,

        /// <summary>
        /// Under hostile control, being liberated
        /// </summary>
        BeingLiberated,

        /// <summary>
        /// Under friendly control, being defended
        /// </summary>
        BeingDefended
    }
}
