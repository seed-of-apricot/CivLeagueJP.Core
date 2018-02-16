using System.Collections.Generic;

namespace CivLeagueJP.Core.Civ6
{
    public class City
    {
        private int locationX;
        private int locationY;

        public PlotLocation Location { get { return new PlotLocation(locationX, locationY); } set { this.locationX = value.LocationX; this.locationY = value.LocationY; } }
        public Civilization Governer { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Production { get; set; }
        public IProductionable Productioning { get; set; }
    }

    public class Building : IProductionable, IPurchasable
    {
        private int locationX;
        private int locationY;

        public PlotLocation Location { get { return new PlotLocation(locationX, locationY); } set { this.locationX = value.LocationX; this.locationY = value.LocationY; } }
        public City City { get; set; }
        public BuildingType BuildingType { get; set; }
    }

    public class District : IProductionable, IPurchasable
    {
        private int locationX;
        private int locationY;

        public PlotLocation Location { get { return new PlotLocation(locationX, locationY); } set { this.locationX = value.LocationX; this.locationY = value.LocationY; } }
        public City City { get; set; }
        public DistrictType DistrictType { get; set; }
        public virtual List<Building> Buildings { get; set; }
    }

    public enum BuildingType
    {
        airport,
        alhambra,
        amphitheater,
        amundsen_scott_research_station,
        angkor_wat,
        apadana,
        aquarium,
        aquatics_center,
        arena,
        armory,
        bank,
        barracks,
        basilkoi_paides,
        big_ben,
        bolshoi_theatre,
        broadcast_center,
        broadway,
        casa_de_contratacion,
        castle,
        cathedral,
        chichen_itza,
        colosseum,
        colossus,
        cristro_redentor,
        dar_e_mehr,
        eiffel_tower,
        electronics_factory,
        estadio_do_maracana,
        factory,
        ferris_wheel,
        film_studio,
        food_market,
        forbidden_city,
        gov_citystates,
        gov_conquest,
        gov_culture,
        gov_faith,
        gov_military,
        gov_science,
        gov_spies,
        gov_tall,
        gov_wide,
        granary,
        great_library,
        great_lighthouse,
        great_zimbabwe,
        gurdwara,
        hagia_sophia,
        halicarnassus_mausoleum,
        hangar,
        hanging_gardens,
        hermitage,
        huey_teocalli,
        jebel_berkal,
        kilwa_kisiwani_,
        kotoku_in,
        large_rocket,
        library,
        lighthouse,
        madrasa,
        mahabodhi_temple,
        market,
        medium_rocket,
        meeting_house,
        military_academy,
        mont_st_michel,
        monument,
        mosque,
        museum_art,
        museum_artifact,
        oracle,
        ordu,
        oxford_university,
        pagoda,
        palace,
        petra,
        potala_palace,
        power_plant,
        prasat,
        pyramids,
        research_lab,
        ruhr_valley,
        seaport,
        sewer,
        shipyard,
        shopiing_mall,
        shrine,
        small_rocket,
        st_basils_cathedral,
        stable,
        stadium,
        star_fort,
        statue_liberty,
        stave_shurch,
        stock_exchange,
        stonehenge,
        stupa,
        sukiennice,
        sydney_opera_house,
        synagogue,
        taj_mahal,
        terracotta_army,
        tlachtli,
        tsikhe,
        university,
        venetian_arsenal,
        walls,
        wat,
        water_mill,
        workshop,
        zoo
    }

    public enum DistrictType
    {
        acropolis,
        aerodrome,
        aqueduct,
        bath,
        campus,
        city_center,
        commercial_hub,
        encampment,
        entertainment_complex,
        government,
        hansa,
        harbor,
        holy_site,
        ikanda,
        industrial_zone,
        lavra,
        mbanza,
        neighborhood,
        royal_navy_dockyard,
        seowon,
        spaceport,
        street_carnival,
        theater,
        water_entertainment_complex,
        water_street_carnival,
        wonder
    }
}
