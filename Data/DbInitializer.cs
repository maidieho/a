using a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated(); //automatically create the database

            // Look for any locations.
            if (context.Location.Any())
            {
                return;   // DB has been seeded
            }

            var vaccines = new Vaccine[]
{
            new Vaccine{Manufacturer="Company A",Name="Vaccine A"},
            new Vaccine{Manufacturer="Company B",Name="Vaccine B"},
            new Vaccine{Manufacturer="Company C",Name="Vaccine C"}
};
            foreach (Vaccine v in vaccines)
            {
                context.Vaccine.Add(v);
            }
            context.SaveChanges();

            var locations = new Location[]
            {
            new Location{Name="Wanchai",Address="No. 1 Wanchai Road"},
            new Location{Name="Mongkok",Address="No. 1 Mongkok Road"},
            new Location{Name="Shatin",Address="No. 1 Shatin Road"},
            new Location{Name="Tsuen Wan",Address="No. 1 Tsuen Wan Road"},
            new Location{Name="Tuen Mun",Address="No. 1 Tuen Mun Road"}
            };

            foreach (Location l in locations)
            {
                context.Location.Add(l);
            }
            context.SaveChanges();

            var timeslots = new Timeslot[]
{
            new Timeslot{Time = "09:00 - 10:00"},
            new Timeslot{Time = "10:00 - 11:00"},
            new Timeslot{Time = "11:00 - 12:00"},
            new Timeslot{Time = "12:00 - 13:00"},
            new Timeslot{Time = "13:00 - 14:00"},
            new Timeslot{Time = "14:00 - 15:00"},
            new Timeslot{Time = "15:00 - 16:00"},
            new Timeslot{Time = "16:00 - 17:00"},
            new Timeslot{Time = "17:00 - 18:00"},
            new Timeslot{Time = "18:00 - 19:00"},
};
            foreach (Timeslot t in timeslots)
            {
                context.Timeslot.Add(t);
            }
            context.SaveChanges();

            var appointments = new Appointment[]
            {
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-01"),TimeslotID=1, IsBooked=false},
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-01"),TimeslotID=2, IsBooked=false},
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-01"),TimeslotID=3, IsBooked=true},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-01"),TimeslotID=4, IsBooked=false},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-01"),TimeslotID=5, IsBooked=false},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-01"),TimeslotID=6, IsBooked=false},
            new Appointment{LocationID=3, Date=DateTime.Parse("2021-05-01"),TimeslotID=7, IsBooked=false},
            new Appointment{LocationID=3, Date=DateTime.Parse("2021-05-01"),TimeslotID=8, IsBooked=true},
            new Appointment{LocationID=3, Date=DateTime.Parse("2021-05-01"),TimeslotID=9, IsBooked=false},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-01"),TimeslotID=10, IsBooked=false},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-02"),TimeslotID=1, IsBooked=false},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-02"),TimeslotID=2, IsBooked=false},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-02"),TimeslotID=3, IsBooked=true},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-02"),TimeslotID=4, IsBooked=true},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-02"),TimeslotID=5, IsBooked=false},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-02"),TimeslotID=6, IsBooked=false},
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-02"),TimeslotID=7, IsBooked=false},
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-02"),TimeslotID=8, IsBooked=false},
            new Appointment{LocationID=1, Date=DateTime.Parse("2021-05-02"),TimeslotID=9, IsBooked=false},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-02"),TimeslotID=10, IsBooked=false},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-03"),TimeslotID=1, IsBooked=false},
            new Appointment{LocationID=5, Date=DateTime.Parse("2021-05-03"),TimeslotID=2, IsBooked=false},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-03"),TimeslotID=3, IsBooked=false},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-03"),TimeslotID=4, IsBooked=false},
            new Appointment{LocationID=2, Date=DateTime.Parse("2021-05-03"),TimeslotID=5, IsBooked=false},
            new Appointment{LocationID=3, Date=DateTime.Parse("2021-05-03"),TimeslotID=6, IsBooked=false},
            new Appointment{LocationID=3, Date=DateTime.Parse("2021-05-03"),TimeslotID=7, IsBooked=true},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-03"),TimeslotID=8, IsBooked=false},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-03"),TimeslotID=9, IsBooked=false},
            new Appointment{LocationID=4, Date=DateTime.Parse("2021-05-03"),TimeslotID=10, IsBooked=false},

            };
            foreach (Appointment a in appointments)
            {
                context.Appointment.Add(a);
            }
            context.SaveChanges();
        }
    }
}
