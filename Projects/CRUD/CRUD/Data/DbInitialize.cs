using System;
using CRUD.Models;

namespace CRUD.Data
{
    public class DbInitialize
    {
        public DbInitialize()
        {
        }

        public static void Initialize(CRUDContext Context)
        {
            var HospitalsList = new Hospitals[]
            {
                new Hospitals () {
                    HospitalId = 12, HospitalName = "hospital A" ,
                    DecisionMaker = "dr Saad ",
                    Email = "hospitala@moh.sa", Password = "123456",
                    Phone = " ", Services = "service 1"
                },
                new Hospitals () {
                    HospitalId = 11, HospitalName = "hospital B" ,
                    DecisionMaker = "dr Mohammad ",
                    Email = "hospitalb@moh.sa", Password = "123456",
                    Phone = " ", Services = "service 2"
                }
            };

            foreach (Hospitals ele in HospitalsList)
            {
                Context.Hospitals.Add(ele);
            }
            Context.SaveChanges();
        }
    }
}
