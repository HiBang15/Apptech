using System;
namespace CRUD.Models
{
    public class HospitalDetails
    {
        public int HospitalDetailsId { get; set; }
        public int HospitalId { get; set; }
        public Hospitals Hospitals { get; set; }
        public int Available { get; set; }
        public int Unavailable { get; set; }
    }
}
