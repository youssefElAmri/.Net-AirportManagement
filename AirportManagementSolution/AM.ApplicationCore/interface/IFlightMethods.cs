﻿using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.publicinterface
{
    public interface IFlightMethods
    {
        List<Flight> GetFlights(string filterType, string filterValue);

    }
}
