﻿using BethanysPieShopHRM.ServerApp.Services.Data;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.ServerApp.Pages
{
    public partial class AgGridComp : ComponentBase
    {
        public int CarsCount { get; set; }       
        public List<Car> Cars { get; set; }
        public bool BtnControl { get; set; } = false;

        public Car SelectedCar{ get; set; }
        protected override void OnInitialized()
        {          

        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                if (Cars == null)
                {
                    var serializerSettings = new JsonSerializerSettings();
                    serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    var Jsonob = JsonObj.JsonString;
                    Cars = JsonConvert.DeserializeObject<List<Car>>(Jsonob, serializerSettings);
                    foreach (var car in Cars)
                    {
                        car.Id = Guid.NewGuid();
                    }
                    Console.WriteLine(Cars.Count);
                    CarsCount = Cars.Count;
                    StateHasChanged();
                }
            }
        }
        protected void BtnShow()
        {
            BtnControl = !BtnControl;
            StateHasChanged();
        }

        private void GridSelectionChanged(Car car)
        {
            SelectedCar= car;
        }

        private void RowDragEnded(List<Car> cars)
        {
            Cars = cars;
        }
    }

    public static class JsonObj
    {
        public static string JsonString { get; } = @"[
  {
    athlete: 'Michael Phelps',
    age: 23,
    country: 'United States',
    year: 2008,
    date: '24/08/2008',
    sport: 'Swimming',
    gold: 8,
    silver: 0,
    bronze: 0,
    total: 8,
  },
  {
    athlete: 'Michael Phelps',
    age: 19,
    country: 'United States',
    year: 2004,
    date: '29/08/2004',
    sport: 'Swimming',
    gold: 6,
    silver: 0,
    bronze: 2,
    total: 8,
  },
  {
    athlete: 'Michael Phelps',
    age: 27,
    country: 'United States',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 4,
    silver: 2,
    bronze: 0,
    total: 6,
  },
  {
    athlete: 'Natalie Coughlin',
    age: 25,
    country: 'United States',
    year: 2008,
    date: '24/08/2008',
    sport: 'Swimming',
    gold: 1,
    silver: 2,
    bronze: 3,
    total: 6,
  },
  {
    athlete: 'Aleksey Nemov',
    age: 24,
    country: 'Russia',
    year: 2000,
    date: '01/10/2000',
    sport: 'Gymnastics',
    gold: 2,
    silver: 1,
    bronze: 3,
    total: 6,
  },
  {
    athlete: 'Alicia Coutts',
    age: 24,
    country: 'Australia',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 1,
    silver: 3,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Missy Franklin',
    age: 17,
    country: 'United States',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 4,
    silver: 0,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Ryan Lochte',
    age: 27,
    country: 'United States',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 2,
    silver: 2,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Allison Schmitt',
    age: 22,
    country: 'United States',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 3,
    silver: 1,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Natalie Coughlin',
    age: 21,
    country: 'United States',
    year: 2004,
    date: '29/08/2004',
    sport: 'Swimming',
    gold: 2,
    silver: 2,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Ian Thorpe',
    age: 17,
    country: 'Australia',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 3,
    silver: 2,
    bronze: 0,
    total: 5,
  },
  {
    athlete: 'Dara Torres',
    age: 33,
    country: 'United States',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 2,
    silver: 0,
    bronze: 3,
    total: 5,
  },
  {
    athlete: 'Cindy Klassen',
    age: 26,
    country: 'Canada',
    year: 2006,
    date: '26/02/2006',
    sport: 'Speed Skating',
    gold: 1,
    silver: 2,
    bronze: 2,
    total: 5,
  },
  {
    athlete: 'Nastia Liukin',
    age: 18,
    country: 'United States',
    year: 2008,
    date: '24/08/2008',
    sport: 'Gymnastics',
    gold: 1,
    silver: 3,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Marit Bjørgen',
    age: 29,
    country: 'Norway',
    year: 2010,
    date: '28/02/2010',
    sport: 'Cross Country Skiing',
    gold: 3,
    silver: 1,
    bronze: 1,
    total: 5,
  },
  {
    athlete: 'Sun Yang',
    age: 20,
    country: 'China',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Kirsty Coventry',
    age: 24,
    country: 'Zimbabwe',
    year: 2008,
    date: '24/08/2008',
    sport: 'Swimming',
    gold: 1,
    silver: 3,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Libby Lenton-Trickett',
    age: 23,
    country: 'Australia',
    year: 2008,
    date: '24/08/2008',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Ryan Lochte',
    age: 24,
    country: 'United States',
    year: 2008,
    date: '24/08/2008',
    sport: 'Swimming',
    gold: 2,
    silver: 0,
    bronze: 2,
    total: 4,
  },
  {
    athlete: 'Inge de Bruijn',
    age: 30,
    country: 'Netherlands',
    year: 2004,
    date: '29/08/2004',
    sport: 'Swimming',
    gold: 1,
    silver: 1,
    bronze: 2,
    total: 4,
  },
  {
    athlete: 'Petria Thomas',
    age: 28,
    country: 'Australia',
    year: 2004,
    date: '29/08/2004',
    sport: 'Swimming',
    gold: 3,
    silver: 1,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Ian Thorpe',
    age: 21,
    country: 'Australia',
    year: 2004,
    date: '29/08/2004',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Inge de Bruijn',
    age: 27,
    country: 'Netherlands',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 3,
    silver: 1,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Gary Hall Jr.',
    age: 25,
    country: 'United States',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Michael Klim',
    age: 23,
    country: 'Australia',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 2,
    silver: 2,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Susie ONeill',
    age: 27,
    country: 'Australia',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 1,
    silver: 3,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Jenny Thompson',
    age: 27,
    country: 'United States',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 3,
    silver: 0,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Pieter van den Hoogenband',
    age: 22,
    country: 'Netherlands',
    year: 2000,
    date: '01/10/2000',
    sport: 'Swimming',
    gold: 2,
    silver: 0,
    bronze: 2,
    total: 4,
  },
  {
    athlete: 'An Hyeon-Su',
    age: 20,
    country: 'South Korea',
    year: 2006,
    date: '26/02/2006',
    sport: 'Short-Track Speed Skating',
    gold: 3,
    silver: 0,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Aliya Mustafina',
    age: 17,
    country: 'Russia',
    year: 2012,
    date: '12/08/2012',
    sport: 'Gymnastics',
    gold: 1,
    silver: 1,
    bronze: 2,
    total: 4,
  },
  {
    athlete: 'Shawn Johnson',
    age: 16,
    country: 'United States',
    year: 2008,
    date: '24/08/2008',
    sport: 'Gymnastics',
    gold: 1,
    silver: 3,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Dmitry Sautin',
    age: 26,
    country: 'Russia',
    year: 2000,
    date: '01/10/2000',
    sport: 'Diving',
    gold: 1,
    silver: 1,
    bronze: 2,
    total: 4,
  },
  {
    athlete: 'Leontien Zijlaard-van Moorsel',
    age: 30,
    country: 'Netherlands',
    year: 2000,
    date: '01/10/2000',
    sport: 'Cycling',
    gold: 3,
    silver: 1,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Petter Northug Jr.',
    age: 24,
    country: 'Norway',
    year: 2010,
    date: '28/02/2010',
    sport: 'Cross Country Skiing',
    gold: 2,
    silver: 1,
    bronze: 1,
    total: 4,
  },
  {
    athlete: 'Ole Einar Bjørndalen',
    age: 28,
    country: 'Norway',
    year: 2002,
    date: '24/02/2002',
    sport: 'Biathlon',
    gold: 4,
    silver: 0,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Janica Kostelic',
    age: 20,
    country: 'Croatia',
    year: 2002,
    date: '24/02/2002',
    sport: 'Alpine Skiing',
    gold: 3,
    silver: 1,
    bronze: 0,
    total: 4,
  },
  {
    athlete: 'Nathan Adrian',
    age: 23,
    country: 'United States',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 0,
    total: 3,
  },
  {
    athlete: 'Yannick Agnel',
    age: 20,
    country: 'France',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 2,
    silver: 1,
    bronze: 0,
    total: 3,
  },
  {
    athlete: 'Brittany Elmslie',
    age: 18,
    country: 'Australia',
    year: 2012,
    date: '12/08/2012',
    sport: 'Swimming',
    gold: 1,
    silver: 2,
    bronze: 0,
    total: 3,
  },
]";
    }

    public class Car
    {
        public Car()
        {

        }
        public Guid Id { get; set; }
        public string Athlete { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public int Year { get; set; }
        public string Sport { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public int Total { get; set; }
    }
}
