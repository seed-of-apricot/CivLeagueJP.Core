using System.Collections.Generic;

namespace CivLeagueJP.Core.Civ6
{
    public class Map
    {
        public int Id { get; }
        public Match Match { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual List<Plot> Plots { get; set; }
        public virtual List<Unit> Units { get; set; }
        public virtual List<City> Cities { get; set; }
    }
    
    public class Plot
    {
        private int locationX;
        private int locationY;

        public PlotLocation Location { get { return new PlotLocation(locationX, locationY); } set { this.locationX = value.LocationX; this.locationY = value.LocationY; } }
        public Civilization Governer { get; set; }
        public TerrainEnum TerrainType { get; set; }
        public FeatureEnum FeatureType { get; set; }
        public ResourceEnum ResourceType { get; set; }
        public ImprovementEnum ImprovementType { get; set; }
        public RouteEnum RouteType { get; set; }
        public bool IfPillaged { get; set; }
        public double[] Yields { get; set; }
    }



    public enum TerrainEnum
    {
        grass,
        grass_hills,
        grass_mountain,
        plains,
        plains_hills,
        plains_mountain,
        desert,
        desert_hills,
        desert_mountain,
        tundra,
        tundra_hills,
        tundra_mountain,
        snow,
        snow_hills,
        snow_mountain,
        coast,
        ocean
    }

    public enum FeatureEnum
    {
        none,
        floodplains,
        ice,
        jungle,
        forest,
        oasis,
        marsh,
        barrier_reef,
        cliffs_dover,
        crater_lake,
        dead_sea,
        everest,
        galapagos,
        kilimanjaro,
        pantanal,
        piopiotahi,
        torres_del_paine,
        tsingy,
        yosemite,
        reef,
        delicate_arch,
        eye_of_the_sahara,
        lake_retba,
        matterhorn,
        roraima,
        ubsunur_hollow,
        zhangye_danxia,
        ha_long_bay,
        eyjafjallajokull,
        lysefjorden,
        giants_causeway,
        uluru
    }

    public enum ResourceEnum
    {
        none,
        aluminum,
        amber,
        antiquity_site,
        bananas,
        cattle,
        cinnamon,
        citrus,
        cloves,
        coal,
        cocoa,
        coffee,
        copper,
        cosmetics,
        cotton,
        crabs,
        deer,
        diamonds,
        dyes,
        fish,
        furs,
        gypsum,
        horses,
        incense,
        iron,
        ivory,
        jade,
        jeans,
        marble,
        mercury,
        niter,
        oil,
        olives,
        pearls,
        perfume,
        rice,
        salt,
        sheep,
        shipwreck,
        silk,
        silver,
        spices,
        stone,
        sugar,
        tea,
        tobacco,
        toys,
        truffles,
        turtles,
        uranium,
        whales,
        wheat,
        wine
    }

    public enum ImprovementEnum
    {
        none,
        airstrip,
        alcazar,
        barbarian_camp,
        beach_resort,
        camp,
        chateau,
        chemamull,
        city_park,
        colossal_head,
        farm,
        fishery,
        fishing_boats,
        fort,
        golf_course,
        goody_hut,
        great_wall,
        kampung,
        kurgan,
        lumber_mill,
        mekewap,
        mine,
        missile_silo,
        mission,
        monastery,
        offshore_oil_rig,
        oil_well,
        outback_station,
        pairidaeza,
        pasture,
        plantation,
        polder,
        pyramid,
        quarry,
        roman_fort,
        sphinx,
        stepwell,
        ziggurat
    }

    public enum RouteEnum
    {
        none,
        ancient_road,
        medieval_road,
        industrial_road,
        modern_road
    }
}

