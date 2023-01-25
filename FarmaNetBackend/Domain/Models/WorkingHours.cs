using System;

namespace FarmaNetBackend.Models.WorkingHours
{
    public class WorkingHours
    {
        private int _idWorkingHours;
        private int _idWorkerAccount;
        private DateOnly _date;
        private TimeOnly _time;
        private string _description;
    }
}
