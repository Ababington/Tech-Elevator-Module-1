﻿using System;
using System.Collections.Generic;
using System.Text;
using WorldGeography.Models;

namespace WorldGeography.DAO
{
    public interface ICityDAO
    {
        /// <summary>
        /// Gets all cities provided a country code.
        /// </summary>
        /// <param name="countryCode">The country code to search for.</param>
        /// <returns></returns>
        IList<City> GetCitiesByCountryCode(string countryCode);

        /// <summary>
        /// Adds a new city.
        /// </summary>
        /// <param name="city">The city to add.</param>
        void AddCity(City city);

        void AddCityAsCapital(City city, string countryCode);

    }
}
