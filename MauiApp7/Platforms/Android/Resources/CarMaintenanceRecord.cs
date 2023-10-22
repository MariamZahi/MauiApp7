using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7.Platforms.Android.Resources
{
    internal class CarMaintenanceRecord
    {
 
            public string Id { get; set; }
            public string ServiceType { get; set; }
            public DateTime Date { get; set; }
            public int Mileage { get; set; }
            public string Notes { get; set; }
        }
    }