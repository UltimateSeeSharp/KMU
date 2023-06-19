﻿using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

internal interface ICountryAccessLayer
{
    List<Country> GetCountries();

    void AddCountry(Country country);

    void EditCountry(Country country);

    void RemoveCountry(int id);

    Country GetCountryById(int id);
}