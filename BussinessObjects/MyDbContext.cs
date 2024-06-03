using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<MedicalFacility> MedicalFacilities { get; set; }
        public DbSet<ServicePriceList> ServicePriceLists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalFacility>().HasData(
                new MedicalFacility
                {
                    FacilityId = 1,
                    FacilityName = "Green Valley Hospital",
                    NoDoctors = 50,
                    NoStaffs = 200,
                    PrivateFacility = true,
                    Level = 4
                },
                new MedicalFacility
                {
                    FacilityId = 2,
                    FacilityName = "Sunrise Health Center",
                    NoDoctors = 30,
                    NoStaffs = 120,
                    PrivateFacility = false,
                    Level = 2
                },
                new MedicalFacility
                {
                    FacilityId = 3,
                    FacilityName = "Lakeside Clinic",
                    NoDoctors = 20,
                    NoStaffs = 80,
                    PrivateFacility = true,
                    Level = 1
                },
                new MedicalFacility
                {
                    FacilityId = 4,
                    FacilityName = "Downtown Medical Center",
                    NoDoctors = 40,
                    NoStaffs = 150,
                    PrivateFacility = false,
                    Level = 2
                },
                new MedicalFacility
                {
                    FacilityId = 5,
                    FacilityName = "Riverside Hospital",
                    NoDoctors = 60,
                    NoStaffs = 250,
                    PrivateFacility = true,
                    Level = 4
                },
                new MedicalFacility
                {
                    FacilityId = 6,
                    FacilityName = "Mountainview Health Facility",
                    NoDoctors = 25,
                    NoStaffs = 90,
                    PrivateFacility = false,
                    Level = 2
                },
                new MedicalFacility
                {
                    FacilityId = 7,
                    FacilityName = "Oceanview Clinic",
                    NoDoctors = 15,
                    NoStaffs = 60,
                    PrivateFacility = true,
                    Level = 5
                },
                new MedicalFacility
                {
                    FacilityId = 8,
                    FacilityName = "City Central Hospital",
                    NoDoctors = 55,
                    NoStaffs = 230,
                    PrivateFacility = false,
                    Level = 1
                },
                new MedicalFacility
                {
                    FacilityId = 9,
                    FacilityName = "Hilltop Medical Center",
                    NoDoctors = 35,
                    NoStaffs = 140,
                    PrivateFacility = true,
                    Level = 5
                },
                new MedicalFacility
                {
                    FacilityId = 10,
                    FacilityName = "Valley View Hospital",
                    NoDoctors = 45,
                    NoStaffs = 190,
                    PrivateFacility = false,
                    Level = 3
                }
            );

            modelBuilder.Entity<ServicePriceList>().HasData(
                new ServicePriceList
                {
                    ServiceId = 1,
                    ServiceLevel = 1,
                    ServiceName = "General Consultation",
                    ServicePrice = 50.00m
                },
                new ServicePriceList
                {
                    ServiceId = 2,
                    ServiceLevel = 1,
                    ServiceName = "Basic Health Checkup",
                    ServicePrice = 75.00m
                },
                new ServicePriceList
                {
                    ServiceId = 3,
                    ServiceLevel = 2,
                    ServiceName = "Specialist Consultation",
                    ServicePrice = 120.00m
                },
                new ServicePriceList
                {
                    ServiceId = 4,
                    ServiceLevel = 2,
                    ServiceName = "Advanced Health Checkup",
                    ServicePrice = 150.00m
                },
                new ServicePriceList
                {
                    ServiceId = 5,
                    ServiceLevel = 3,
                    ServiceName = "Emergency Care",
                    ServicePrice = 200.00m
                },
                new ServicePriceList
                {
                    ServiceId = 6,
                    ServiceLevel = 3,
                    ServiceName = "Surgical Procedure",
                    ServicePrice = 500.00m
                },
                new ServicePriceList
                {
                    ServiceId = 7,
                    ServiceLevel = 4,
                    ServiceName = "Inpatient Care",
                    ServicePrice = 1000.00m
                },
                new ServicePriceList
                {
                    ServiceId = 8,
                    ServiceLevel = 4,
                    ServiceName = "Intensive Care",
                    ServicePrice = 2000.00m
                },
                new ServicePriceList
                {
                    ServiceId = 9,
                    ServiceLevel = 5,
                    ServiceName = "Specialized Surgery",
                    ServicePrice = 5000.00m
                },
                new ServicePriceList
                {
                    ServiceId = 10,
                    ServiceLevel = 5,
                    ServiceName = "Comprehensive Health Package",
                    ServicePrice = 10000.00m
                }
            );
        }
    }
}
