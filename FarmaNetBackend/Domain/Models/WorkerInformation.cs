using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class WorkerInformation
    {
        public int _idWorkerInformation { get; set; }
        //public int _idPosition { get; set; }
        
        public string _name { get; set; }
        public string _lastName { get; set; }
        public string _email { get; set; }
        public DateOnly _birthDate { get; set; }
        public short _passportSeries { get; set; }
        public short _passportNumber { get; set; }
        public float _experience { get; set; }


        public Position Position { get; set; }

        public virtual List<WorkerAccount> WorkerAccounts { get; set; }

        /*
        public WorkerInformation(string name, string lastName, DateOnly birthDate,
                      short passportSeries, short passportNumber, float experience = 0,
                      string email = "", int idPosition = 0)
        {
            _name = name;
            _lastName = lastName;
            _birthDate = birthDate;
            _passportSeries = passportSeries;
            _passportNumber = passportNumber;
            _experience = experience;
            _email = email;
            _idPosition = idPosition;
        }

        public int GetId()
        {
            return _idWorker;
        }

        public int GetPositionId()
        {
            return _idPosition;
        }

        public WorkerInformation SetPositionId(int positionId)
        {
            _idPosition = positionId;

            return this;
        }

        public string GetName()
        {
            return _name;
        }

        public WorkerInformation SetName(string name)
        {
            _name = name;

            return this;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public WorkerInformation SetLastName(string lastName)
        {
            _lastName = lastName;

            return this;
        }

        public string GetEmail()
        {
            return _email;
        }

        public WorkerInformation SetEmail(string email)
        {
            _email = email;

            return this;
        }

        public DateOnly GetBirthDate()
        {
            return _birthDate;
        }

        public short GetPassportSeries()
        {
            return _passportSeries;
        }

        public WorkerInformation SetPassportSeries(short series)
        {
            _passportSeries = series;

            return this;
        }

        public short GetPassportNumber()
        {
            return _passportNumber;
        }

        public WorkerInformation SetPassportNumber(short number)
        {
            _passportNumber = number;

            return this;
        }

        public float GetExperience()
        {
            return _experience;
        }
        */
    }
}
