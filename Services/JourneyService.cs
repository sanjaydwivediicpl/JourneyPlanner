using JourneyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace JourneyPlanner.Services
{
    public class JourneyService : IJourneyService
    {
        public List<Places> GetPlaces()
        {
            var placeList = new List<Places>()
            {
                new Places {FromStation="Tottenham Court Road", ToStation="Bank",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Bank",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Bank",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Bank",PlaceName="Bank"},
                new Places {FromStation="Bank", ToStation="Chancery Lane",PlaceName="Chancery Lane"},
                new Places {FromStation="Bank", ToStation="Holborn",PlaceName="Chancery Lane"},
                new Places {FromStation="Bank", ToStation="Holborn",PlaceName="Holborn"},
                new Places {FromStation="Bank", ToStation="St.Paul's",PlaceName="Holborn"},
                new Places {FromStation="Bank", ToStation="St.Paul's",PlaceName="t.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Chancery Lane",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road", ToStation="Holborn",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road", ToStation="Holborn",PlaceName="Holborn"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="St.Paul's",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="St.Paul's",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="St.Paul's",PlaceName="St.Paul's"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Monument",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Monument",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Monument",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Monument",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Monument",PlaceName="Bank"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Cannon Street",PlaceName="Cannon Street"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Mansion House",PlaceName="Mansion House"},


                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Blackfriars",PlaceName="Blackfriars"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Blackfriars"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Temple",PlaceName="Temple"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Blackfriars"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Temple"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Embankment"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Blackfriars"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Temple"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Embankment"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Charing Cross",PlaceName="Charing Cross"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Blackfriars"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Temple"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Embankment"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Charing Cross"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Leicester Square",PlaceName="Leicester Square"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Chancery Lane"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Holborn"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="St.Paul's"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Bank"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Monument"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Cannon Street"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Mansion House"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Blackfriars"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Temple"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Embankment"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Charing Cross"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Leicester Square"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Covent Garden",PlaceName="Covent Garden"},

                new Places {FromStation="Monument" ,ToStation="Temple",PlaceName="Cannon Street"},
                new Places {FromStation="Monument" ,ToStation="Temple",PlaceName="Mansion House"},
                new Places {FromStation="Monument" ,ToStation="Temple",PlaceName="Blackfriars"},
                new Places {FromStation="Monument" ,ToStation="Temple",PlaceName="Temple"},

                new Places {FromStation="Holborn" ,ToStation="Leicester Square",PlaceName="Covent Garden"},
                new Places {FromStation="Holborn" ,ToStation="Leicester Square",PlaceName="Leicester Square"},

                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Leicester Square"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Charing Cross"},
                new Places {FromStation="Tottenham Court Road" ,ToStation="Embankment",PlaceName="Embankment"},

            };
            return placeList;
        }
    }
}