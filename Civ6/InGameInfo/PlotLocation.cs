namespace CivLeagueJP.Core.Civ6
{
    public class PlotLocation
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        public PlotLocation(int x,int y)
        {
            this.LocationX = x;
            this.LocationY = y;
        }
    }
}