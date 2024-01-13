using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" planet as it is almost as large " +
                "and has a similar composition. As an interior planet to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

                        new()
            {
                Name = " Mars",
                Subtitle = "  The iron planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic planet with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other planets in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

                        new()
            {
                Name = " Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest planetary radius and fourth-largest " +
                "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                "the farthest known planet in the Solar System. It is the " +
                "fourth-largest planet in the Solar System by diameter, the " +
                "third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "The god of the underworld",
                HeroImage = "pluto.png",
                Description = "Pluto, discovered in 1930 by Clyde Tombaugh,"+
                "is a dwarf planet in the outer solar system."+
                "Originally considered the ninth planet, it was reclassified in 2006."+
                "With a diameter of about 1,473 miles,"+
                "Pluto has a thin atmosphere and a complex system of moons, including Charon."+
                "NASA's New Horizons mission in 2015 provided detailed images,"+
                "revealing diverse and geologically active features like icy mountains and plains."+
                "The exploration of Pluto offers insights into the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21863_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA11709_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21026_modest.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The goddess of agriculture, fertility, and motherly relationships",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between"+
                "Mars and Jupiter and is classified as a dwarf planet."+
                "Discovered by Italian astronomer Giuseppe Piazzi in 1801,"+
                "Ceres has a diameter of about 590 miles (940 kilometers)."+
                "It was the first dwarf planet to be visited by a spacecraft"+
                "when NASA's Dawn mission orbited and studied it from 2015 to 2018."+
                "Ceres is unique for hosting a large, bright area known as Occator Crater,"+
                "which contains bright deposits believed to be composed of sodium carbonate,"+
                "possibly originating from subsurface water."+
                "The dwarf planet is of particular interest to scientists as it provides"+
                "insights into the early solar system and the potential presence of water ice on its surface.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA23017_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21918_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21906_modest.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The Hawaiian goddess of fertility and childbirth",
                HeroImage = "haumea.png",
                Description = "Haumea is another dwarf planet in the Kuiper Belt,"+
                "discovered in 2004 by a team of astronomers led by Mike Brown."+
                "It is named after the Hawaiian goddess of fertility."+
                "Haumea is distinctive due to its elongated shape, resembling a flattened ellipsoid,"+
                "possibly the result of a rapid rotation. It has two known moons, Hi'iaka and Namaka,"+
                "named after Hawaiian goddesses and discovered in 2005."+
                "Haumea's surface is thought to be composed of crystalline water ice,"+
                "and it displays a relatively high albedo, making it one of the brighter objects in the Kuiper Belt."+
                "The discovery of Haumea and its unique characteristics has contributed to"+
                "our understanding of the diversity of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/expanse/images/1/1f/Haumea_in_Celestia.jpg/revision/latest?cb=20200206143331"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The deity of creation and fertility",
                HeroImage = "makemake.png",
                Description = "Makemake is another dwarf planet located in the Kuiper Belt,"+
                "a region of the outer solar system beyond Neptune."+
                "It was discovered in 2005 by astronomers using the Palomar Observatory."+
                "Similar to Pluto and Eris, Makemake is part of the group of trans-Neptunian objects known as dwarf planets."+
                "It is notable for its lack of a significant atmosphere and its relatively high albedo,"+
                "indicating a bright and reflective surface, likely composed of a mixture of frozen methane"+
                "ethane, and nitrogen. Makemake is the second-brightest dwarf planet after Pluto and"+
                "is recognized as one of the largest objects in the Kuiper Belt."+
                "Its discovery contributed to the ongoing understanding and classification of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
    AccentColorEnd = Color.FromArgb("#26abe0"),
    Images = new()
    {
        "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
    }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "The goddess of strife, discord, and chaos",
                HeroImage = "eris.png",
                Description = "Eris, a dwarf planet situated in the scattered disk of the outer solar system,"+
                "was identified in 2005 by astronomers at the Palomar Observatory."+
                "Smaller than Pluto but more massive, Eris ranks among the largest dwarf planets."+
                "Its orbit, more elliptical than Pluto's, places it at a greater average distance from the Sun."+
                "Eris boasts a highly reflective surface, likely comprising a mix of water ice and frozen methane."+
                "The discovery of Eris played a crucial role in the reclassification of Pluto and similar objects,"+
                "leading to the establishment of the \"dwarf planet\" category by the International Astronomical Union (IAU).",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA17307_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA03034_modest.jpg"
                }
            },

    };
public static List<Planet> GetFeaturedPlanets()
{
    var random = new Random();
    var randomizedPlanets = planets.OrderBy(item => random.Next());
    return randomizedPlanets.Take(2).ToList();
}
public static List<Planet> GetAllPlanets()
            => planets;
    }
}
