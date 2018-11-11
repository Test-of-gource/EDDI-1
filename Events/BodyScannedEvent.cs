﻿using EddiDataDefinitions;
using System;
using System.Collections.Generic;

namespace EddiEvents
{
    public class BodyScannedEvent : Event
    {
        public const string NAME = "Body scanned";
        public const string DESCRIPTION = "Triggered when you complete a scan of a planetary body";
        public const string SAMPLE = @"{ ""timestamp"":""2016-10-05T10:28:04Z"", ""event"":""Scan"", ""BodyName"":""Dagutii ABC 1 b"", ""DistanceFromArrivalLS"":644.074463, ""TidalLock"":true, ""TerraformState"":"""", ""PlanetClass"":""Icy body"", ""Atmosphere"":"""", ""Volcanism"":""carbon dioxide geysers volcanism"", ""MassEM"":0.001305, ""Radius"":964000.375000, ""SurfaceGravity"":0.559799, ""SurfaceTemperature"":89.839241, ""SurfacePressure"":0.000000, ""Landable"":true, ""Materials"":{ ""sulphur"":26.8, ""carbon"":22.5, ""phosphorus"":14.4, ""iron"":12.1, ""nickel"":9.2, ""chromium"":5.4, ""selenium"":4.2, ""vanadium"":3.0, ""niobium"":0.8, ""molybdenum"":0.8, ""ruthenium"":0.7 }, ""SemiMajorAxis"":739982912.000000, ""Eccentricity"":0.000102, ""OrbitalInclination"":-0.614765, ""Periapsis"":233.420425, ""OrbitalPeriod"":242733.156250, ""RotationPeriod"":242735.265625, ""Rings"":[ { ""Name"":""Maia B 3 A Ring"", ""RingClass"":""eRingClass_Rocky"", ""MassMT"":4.9509e+12, ""InnerRad"":1.3006e+08, ""OuterRad"":5.0982e+08 } ], ""ReserveLevel"":""PristineResources"" }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        // Scan value calculation constants
        public const double dssDivider = 2.4;
        public const double scanDivider = 5.3;
        public const double scanMultiplier = 3;
        public const double scanPower = 0.199977;

        static BodyScannedEvent()
        {
            VARIABLES.Add("name", "The name of the body that has been scanned");
            VARIABLES.Add("bodyclass", "The class of the body that has been scanned (High metal content body etc)");
            VARIABLES.Add("gravity", "The surface gravity of the body that has been scanned, relative to Earth's gravity");
            VARIABLES.Add("earthmass", "The mass of the body that has been scanned, relative to Earth's mass");
            VARIABLES.Add("radius", "The radius of the body that has been scanned, in kilometres");
            VARIABLES.Add("temperature", "The surface temperature of the body that has been scanned, in Kelvin (only available if DSS equipped)");
            VARIABLES.Add("pressure", "The surface pressure of the body that has been scanned, in Earth atmospheres (only available if DSS equipped)");
            VARIABLES.Add("tidallylocked", "True if the body is tidally locked (only available if DSS equipped)");
            VARIABLES.Add("landable", "True if the body is landable (only available if DSS equipped)");
            VARIABLES.Add("atmosphere", "The atmosphere of the body that has been scanned (only available if DSS equipped)");
            VARIABLES.Add("atmospherecomposition", "The composition of the atmosphere of the body that has been scanned (only available if DSS equipped)");
            VARIABLES.Add("solidcomposition", "The composition of the body's solids that has been scanned (only available if DSS equipped)");
            VARIABLES.Add("volcanism", "The volcanism of the body that has been scanned (only available if DSS equipped)");
            VARIABLES.Add("distancefromarrival", "The distance in LS from the main star");
            VARIABLES.Add("orbitalperiod", "The number of days taken for a full orbit of the main star");
            VARIABLES.Add("rotationperiod", "The number of days taken for a full rotation");
            VARIABLES.Add("semimajoraxis", "The semi major axis of the body's orbit, in light seconds");
            VARIABLES.Add("eccentricity", "The orbital eccentricity of the body");
            VARIABLES.Add("orbitalinclination", "The orbital inclination of the body, in degrees");
            VARIABLES.Add("periapsis", "The argument of periapsis of the body, in degrees");
            VARIABLES.Add("rings", "A list of the body's rings (as ring objects)");
            VARIABLES.Add("reserves", "The level of reserves in the rings if applicable (Pristine/Major/Common/Low/Depleted)");
            VARIABLES.Add("materials", "A list of materials present on the body that has been scanned");
            VARIABLES.Add("terraformstate", "Whether the body can be, is in the process of, or has been terraformed (only available if DSS equipped)");
            VARIABLES.Add("axialtilt", "Axial tilt for the body, in degrees (only available if DSS equipped)");
            VARIABLES.Add("estimatedvalue", "The estimated value of the current scan");
        }

        public string name { get; private set; }

        public string planettype => planetClass.localizedName;  // This is the object property reported from the BodyDetails() function

        public string bodyclass => planetClass.localizedName;

        public decimal? earthmass { get; private set; }

        public decimal? radius { get; private set; }

        public decimal gravity { get; private set; }

        public decimal? temperature { get; private set; }

        public decimal? pressure { get; private set; }

        public bool? tidallylocked { get; private set; }

        public bool? landable { get; private set; }

        public string atmosphere => atmosphereclass?.localizedName;

        public AtmosphereClass atmosphereclass { get; private set; }

        public List<AtmosphereComposition> atmospherecomposition { get; private set; }

        public List<SolidComposition> solidcomposition { get; private set; }

        public Volcanism volcanism { get; private set; }

        public decimal distance => distancefromarrival;  // This is the object property reported from the BodyDetails() function

        public decimal distancefromarrival { get; private set; }

        public decimal orbitalperiod { get; private set; }

        public decimal rotationalperiod => rotationperiod;  // This is the object property reported from the BodyDetails() function

        public decimal rotationperiod { get; private set; }

        public decimal? semimajoraxis { get; private set; }

        public decimal? eccentricity { get; private set; }

        public decimal? inclination => orbitalinclination;  // This is the object property reported from the BodyDetails() function

        public decimal? orbitalinclination { get; private set; }

        public decimal? periapsis { get; private set; }

        public List<Ring> rings { get; private set; }

        public string reserves { get; private set; }

        public List<MaterialPresence> materials { get; private set; }

        public string terraformstate => terraformState.localizedName;

        public TerraformState terraformState { get; private set; }

        public decimal? tilt => axialtilt;  // This is the object property reported from the BodyDetails() function

        public decimal? axialtilt { get; private set; }

        public long? estimatedvalue { get; private set; }

        public PlanetClass planetClass { get; private set; }

        public string scantype { get; private set; } // One of Basic, Detailed, NavBeacon, NavBeaconDetail

        public BodyScannedEvent(DateTime timestamp, string scantype, string name, PlanetClass planetClass, decimal? earthmass, decimal? radiusKm, decimal gravity, decimal? temperatureKelvin, decimal? pressureAtm, bool? tidallylocked, bool? landable, AtmosphereClass atmosphereClass, List<AtmosphereComposition> atmosphereComposition, List<SolidComposition> solidCompositions, Volcanism volcanism, decimal distancefromarrival_Ls, decimal orbitalperiodDays, decimal rotationperiodDays, decimal? semimajoraxisAU, decimal? eccentricity, decimal? orbitalinclinationDegrees, decimal? periapsisDegrees, List<Ring> rings, string reserves, List<MaterialPresence> materials, TerraformState terraformstate, decimal? axialtiltDegrees) : base(timestamp, NAME)
        {
            this.scantype = scantype;
            this.name = name;
            this.distancefromarrival = distancefromarrival_Ls;
            this.planetClass = planetClass;
            this.earthmass = earthmass;
            this.radius = radiusKm;
            this.gravity = gravity;
            this.temperature = temperatureKelvin;
            this.pressure = pressureAtm;
            this.tidallylocked = tidallylocked;
            this.landable = landable;
            this.atmosphereclass = atmosphereClass;
            this.atmospherecomposition = atmosphereComposition;
            this.solidcomposition = solidCompositions;
            this.volcanism = volcanism;
            this.orbitalperiod = orbitalperiodDays;
            this.rotationperiod = rotationperiodDays;
            this.semimajoraxis = semimajoraxisAU;
            this.eccentricity = eccentricity;
            this.orbitalinclination = orbitalinclinationDegrees;
            this.periapsis = periapsisDegrees;
            this.rings = rings;
            this.reserves = reserves;
            this.materials = materials;
            this.terraformState = terraformstate;
            this.axialtilt = axialtiltDegrees;
            this.estimatedvalue = estimateValue(scantype == "Detailed" || scantype == "NavBeaconDetail");
        }

        private decimal sanitiseCP(decimal cp)
        {
            // Trim decimal places appropriately
            if (cp < .00001M || cp > .9999M)
            {
                return Math.Round(cp * 100, 4);
            }
            else if (cp < .0001M || cp > .999M)
            {
                return Math.Round(cp * 100, 3);
            }
            else if (cp < .001M || cp > .99M)
            {
                return Math.Round(cp * 100, 2);
            }
            else
            {
                return Math.Round(cp * 100);
            }
        }

        private long? estimateValue(bool detailedScan)
        {
            // Credit to MattG's thread at https://forums.frontier.co.uk/showthread.php/232000-Exploration-value-formulae for scan value formulas
            int baseTypeValue = 720;
            int terraValue = 0;
            bool terraformable = false;

            // Override constants for specific types of bodies
            if (terraformState.edname == "Terraformable")
            {
                terraformable = true;
            }
            if ( planetClass.edname == "AmmoniaWorld")
            {
                // Ammonia worlds
                baseTypeValue = 232619;
            }
            else if ( planetClass.edname == "EarthLikeBody" )
            {
                // Earth-like worlds
                baseTypeValue = 155581;
                terraValue = 279088;
            }
            else if (planetClass.edname == "WaterWorld" )
            {
                // Water worlds
                baseTypeValue = 155581;
                if (terraformable)
                {
                    terraValue = 279088;
                }
            }
            else if (planetClass.edname == "MetalRichBody")
            {
                // Metal rich worlds
                baseTypeValue = 52292;
            }
            else if (planetClass.edname == "HighMetalContentBody")
            {
                // High metal content worlds
                baseTypeValue = 23168;
                if (terraformable)
                {
                    terraValue = 241607;
                }
            }
            else if (planetClass.edname == "RockyBody")
            {
                // Rocky worlds
                if (terraformable)
                {
                    terraValue = 223971;
                }
            }
            else if (planetClass.edname == "ClassIGasGiant")
            {
                // Class I gas giants
                baseTypeValue = 3974;
            }
            else if (planetClass.edname == "ClassIIGasGiant")
            {
                // Class II gas giants
                baseTypeValue = 23168;
            }

            // Calculate exploration scan values
            double baseValue = baseTypeValue + (scanMultiplier * baseTypeValue * Math.Pow((double)earthmass, scanPower) / scanDivider);
            double terraBonusValue = terraValue + (scanMultiplier * terraValue * Math.Pow((double)earthmass, scanPower) / scanDivider);
            double value = baseValue + terraBonusValue;

            if (detailedScan == false)
            {
                value = value / dssDivider;
            }
            return (long?)Math.Round(value, 0);
        }
    }
}
