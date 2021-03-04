using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a.Models;

namespace a.ViewModels
{
    public class LocationViewModel
    {
        public IEnumerable<Location> Locations { get; set; }

        public IEnumerable<Appointment> Appointments { get; set; }

        public IEnumerable<Timeslot> Timeslots { get; set; }
    }
}
