using AceSoftAccess;
using AceSoftServices.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceSoft
{
    public sealed class DriverFactory
    {

        private static DriverFactory instance = null;
        private static readonly object padlock = new DriverFactory();

        public DriverFactory()
        {
        }

        public static DriverFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DriverFactory();
                    }
                    return instance;
                }
            }
        }
        public List<Driver> GetDrivers()
        {
            DriverController controller = new DriverController();

            return controller.Get().ToList();
        }

        public Driver GetDriverFromId(int id)
        {
            using (AceSoftDataEntities db = new AceSoftDataEntities())
            {
                var result = db.Drivers.Include(e => e.Employee)
                    .FirstOrDefault(e => e.Id == id);

                return result;
            }
        }

        public bool IsDuplicate(string surname, string mobile)
        {
            DriverController controller = new DriverController();

            return controller.IsDuplicate(surname, mobile);
        }


        public void UpsertDriver(Driver driver)
        {
            using (AceSoftDataEntities db = new AceSoftDataEntities())
            {
                if (driver != null)
                {
                    var result = db.Drivers.AsNoTracking().SingleOrDefault(d => d.Id == driver.Id);

                    if (result != null)
                    {
                        try
                        {
                            driver.Employee = null;
                            db.Drivers.Attach(driver);
                            db.Entry(driver).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

                    else
                    {
                        Driver newDriver = new Driver();
                        newDriver = driver;
                        //{
                        //    Address = driver.Address,
                        //    Car_Owned = driver.Car_Owned,
                        //    City = driver.City,
                        //    CPC_Expiry = driver.CPC_Expiry,
                        //    Digi_Expiry = driver.Digi_Expiry,
                        //    DoB = driver.DoB,
                        //    Email = driver.Email,
                        //    Forename = driver.Forename,
                        //    Id = driver.Id,
                        //    Last_Contact = driver.Last_Contact,
                        //    License_Checked = driver.License_Checked,
                        //    License_Expiry = driver.License_Expiry,
                        //    License_Next_Check = driver.License_Next_Check,
                        //    License_Num = driver.License_Num,
                        //    License_Valid = driver.License_Valid,
                        //    Mobile = driver.Mobile,
                        //    Nationality = driver.Nationality,
                        //    NI_Num = driver.NI_Num,
                        //    Postcode = driver.Postcode,
                        //    Staff_Contacted = driver.Staff_Contacted,
                        //    Surname = driver.Surname,
                        //    Telephone = driver.Telephone,
                        //    Archived = driver.Archived

                        //};

                        db.Drivers.Add(newDriver);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
