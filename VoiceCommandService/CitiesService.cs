//==========================================================================
//
// Author:  Nick Landry
// Title:   Senior Technical Evangelist - Microsoft US DX - NY Metro
// Twitter: @ActiveNick
// Blog:    www.AgeofMobility.com
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Disclaimer: Portions of this code may been simplified to demonstrate
// useful application development techniques and enhance readability.
// As such they may not necessarily reflect best practices in enterprise 
// development, and/or may not include all required safeguards.
// 
// This code and information are provided "as is" without warranty of any
// kind, either expressed or implied, including but not limited to the
// implied warranties of merchantability and/or fitness for a particular
// purpose.
//==========================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveOclock.VoiceCommands
{
    // A service that analyzes time zones and returns a list of sample cities
    // where it's after 5:00PM
    public sealed class CitiesService
    {
        public IList<City> GetCities()
        {
            // Fetch the time zone where it's currently 5:00PM
            int DesiredTimeZone = GetDesiredTimezone();

            List<City> resultCities = new List<City>();

            switch (DesiredTimeZone)
            {
                case 14:
                    // There's not a lot smack in the middle of the Pacific :)
                    resultCities.Add(new City("Line Islands", "Kiribati"));
                    break;
                case 13:
                    resultCities.Add(new City("Phoenix Islands", "Kiribati"));
                    resultCities.Add(new City("Nuku'alofa", "Tonga"));
                    resultCities.Add(new City("Fakaofo", "Tokelau"));
                    break;
                case 12:
                    resultCities.Add(new City("Suva", "Fiji"));
                    resultCities.Add(new City("Kamchatka Krai", "Russia"));
                    resultCities.Add(new City("Gilbert Islands", "Kiribati"));
                    break;
                case 11:
                    resultCities.Add(new City("Nouméa", "New Caledonia"));
                    resultCities.Add(new City("Primorsky Krai", "Russia"));
                    resultCities.Add(new City("Honiara", "Solomon Islands"));
                    break;
                case 10:
                    resultCities.Add(new City("Brisbane", "Australia"));
                    resultCities.Add(new City("Hagåtña", "Guam"));
                    resultCities.Add(new City("Port Moresby", "Papua New Guinea"));
                    break;
                case 9:
                    resultCities.Add(new City("Tokyo", "Japan"));
                    resultCities.Add(new City("Seoul", "South Korea"));
                    resultCities.Add(new City("Jakarta", "Indonesia"));
                    break;
                case 8:
                    resultCities.Add(new City("Hong Kong", "China"));
                    resultCities.Add(new City("Kuala Lumpur", "Malaysia"));
                    resultCities.Add(new City("Manila", "Philippines"));
                    break;
                case 7:
                    resultCities.Add(new City("Bangkok", "Thailand"));
                    resultCities.Add(new City("Hanoi", "Vietnam"));
                    resultCities.Add(new City("Phnom Penh", "Cambodia"));
                    break;
                case 6:
                    resultCities.Add(new City("Dhaka", "Bangladesh"));
                    resultCities.Add(new City("Astana", "Kazakhstan"));
                    resultCities.Add(new City("Thimphu", "Bhutan"));
                    break;
                case 5:
                    resultCities.Add(new City("New Delhi", "India"));
                    resultCities.Add(new City("Colombo", "Sri Lanka"));
                    resultCities.Add(new City("Islamabad", "Pakistan"));
                    break;
                case 4:
                    resultCities.Add(new City("Dubai", "United Arab Emirates"));
                    resultCities.Add(new City("Tbilisi", "Georgia"));
                    resultCities.Add(new City("Yerevan", "Armenia"));
                    break;
                case 3:
                    resultCities.Add(new City("Moscow", "Russia"));
                    resultCities.Add(new City("Minsk", "Belarus"));
                    resultCities.Add(new City("Kampala", "Uganda"));
                    break;
                case 2:
                    resultCities.Add(new City("Athens", "Greece"));
                    resultCities.Add(new City("Cairo", "Egypt"));
                    resultCities.Add(new City("Tunis, Tunisia", ""));
                    resultCities.Add(new City("Helsinki", "Finland"));
                    break;
                case 1:
                    resultCities.Add(new City("Paris", "France"));
                    resultCities.Add(new City("Brussels", "Belgium"));
                    resultCities.Add(new City("Berlin", "Germany"));
                    resultCities.Add(new City("Rome", "Italy"));
                    resultCities.Add(new City("Prague", "Czech Republic"));
                    resultCities.Add(new City("Madrid", "Spain"));
                    resultCities.Add(new City("Amsterdam", "Netherlands"));
                    break;
                case 0:
                    resultCities.Add(new City("London", "United Kingdom"));
                    resultCities.Add(new City("Dublin", "Ireland"));
                    resultCities.Add(new City("Reykjavík", "Iceland"));
                    break;
                case -1:
                    resultCities.Add(new City("Praia", "Cape Verde"));
                    resultCities.Add(new City("Ponta Delgada", "Azores"));
                    break;
                case -2:
                    resultCities.Add(new City("Fernando de Noronha", "Brazil"));
                    resultCities.Add(new City("King Edward Point", "South Georgia and the South Sandwich Islands"));
                    break;
                case -3:
                    resultCities.Add(new City("Rio de Janeiro", "Brazil"));
                    resultCities.Add(new City("Montevideo", "Uruguay"));
                    resultCities.Add(new City("Buenos Aires", "Argentina"));
                    break;
                case -4:
                    resultCities.Add(new City("Halifax", "Canada"));
                    resultCities.Add(new City("San Juan", "Puerto Rico"));
                    resultCities.Add(new City("Bridgetown", "Barbados"));
                    break;
                case -5:
                    // Home time zone of the developer :)
                    resultCities.Add(new City("New York City", "United States"));
                    resultCities.Add(new City("Montreal", "Canada"));
                    resultCities.Add(new City("Kingston", "Jamaica"));
                    resultCities.Add(new City("Nassau", "Bahamas"));
                    resultCities.Add(new City("Bogotá", "Columbia"));
                    resultCities.Add(new City("Lima", "Peru"));
                    break;
                case -6:
                    resultCities.Add(new City("Chicago", "United States"));
                    resultCities.Add(new City("Winnipeg", "Canada"));
                    resultCities.Add(new City("Mexico City", "Mexico"));
                    resultCities.Add(new City("San Salvador", "El Salvador"));
                    resultCities.Add(new City("Guatemala City", "Guatemala"));
                    resultCities.Add(new City("Tegucigalpa", "Honduras"));
                    break;
                case -7:
                    resultCities.Add(new City("Calgary", "Canada"));
                    resultCities.Add(new City("Denver", "United States"));
                    resultCities.Add(new City("Chihuahua", "Mexico"));
                    break;
                case -8:
                    resultCities.Add(new City("Vancouver", "Canada"));
                    resultCities.Add(new City("Seattle", "United States"));
                    resultCities.Add(new City("San Francisco", "United States"));
                    resultCities.Add(new City("Tijuana", "Mexico"));
                    break;
                case -9:
                    resultCities.Add(new City("Anchorage", "United States"));
                    resultCities.Add(new City("Gambier Islands", "French Polynesia"));
                    break;
                case -10:
                    resultCities.Add(new City("Honolulu", "United States"));
                    resultCities.Add(new City("Pape'ete", "French Polynesia"));
                    break;
                case -11:
                    resultCities.Add(new City("Pago Pago", "American Samoa"));
                    resultCities.Add(new City("Alofi", "Niue"));
                    break;
                default:
                    break;
            }

            return resultCities;
        }

        // Calculates the desired time zone where it's currently 5:00PM
        private static int GetDesiredTimezone()
        {
            // Capturing the current time and Utc time to avoid rare cases
            // where the hour might change mid-routine
            DateTime currenttime = DateTime.Now;
            DateTime currentUtctime = DateTime.UtcNow;

            // We don't care about minutes so we just work with hours rounded down
            int currenthour = currenttime.Hour;
            int currentUtcHour = currentUtctime.Hour;
            // If the day isn't the same for the locale vs Utc, we have to 
            // compensate by adding 24 hours to the Utc time
            if (currenttime.Day != currentUtctime.Day) { currentUtcHour += 24; }

            int UtcDelta = (currenthour - currentUtcHour);
            // We need to artificially compensate for daylight savings
            if (currenttime.IsDaylightSavingTime()) { UtcDelta -= 1; }
            int DeltaToFive = (17 - currenthour);
            int DesiredTimeZone = (UtcDelta + DeltaToFive);
            // If we go over UTC+14, we need to go back a day by 25h
            if (DesiredTimeZone > 14) { DesiredTimeZone -= 25; }
            return DesiredTimeZone;
        }
    }

    // Simple data class to hold city/country info for the list
    public sealed class City
    {
        public City(string n, string c)
        {
            _name = n;
            _country = c;
        }

        private string _name;
        private string _country;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
