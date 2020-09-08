using System;
namespace CRUD.Models
{
    public class HospitalDetails
    {
        public int Hospitaldetailsid { get; set; }
        public int Hospitalid { get; set; }
        public Hospitals Hospitals { get; set; }
        public int Available { get; set; }
        public int Unavailable { get; set; }
    }
}
