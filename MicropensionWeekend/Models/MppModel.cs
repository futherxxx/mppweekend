using System;

namespace MicropensionWeekend.Controllers
{
    internal class MppModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string Agent { get; set; }
        public string Pin { get; set; }
        public string EmployerCode { get; set; }
        public string Phone { get; set; }
        public int Amount { get; set; }
        public string Channel { get; set; }
        public DateTime LastPayDate { get; set; }
    }
}