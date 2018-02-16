using System;
using System.Collections.Generic;

namespace CivLeagueJP.Core.Civ6
{
    public abstract class AchievementBase
    {
        public int Id { get; set; }
        public int RefreshCycle { get; set; }
        public Grade MedalGrade { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public enum Grade
        {
            normal,
            bronze,
            silver,
            gold
        }
    }
   
    public class Medal : AchievementBase
    {
        public Medal()
        {
            Players = new HashSet<Player>();
        }
        public virtual ICollection<Player> Players { get; set; }
    }

    public class Flag : AchievementBase
    {
        public Flag()
        {
            FlagPosessions = new List<FlagPosession>();
        }
        public List<FlagPosession> FlagPosessions { get; set; }
    }

    public class FlagPosession
    {
        public FlagPosession()
        {
            Posessionperiod = new List<DateTime>();
        }
        public ActorBase Actor { get; set; }
        public List<DateTime> Posessionperiod { get; set; }
    }
}