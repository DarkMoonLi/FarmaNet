using System;

namespace FarmaNetBackend.Models.Worker
{
    public class Worker
    {
        private int _idWorker;
        private int _idPosition;
        private string _name;
        private string _lastName;
        private string _email;
        private DateOnly _birthDate;
        private short _passportSeries;
        private short _passportNumber;
        private float _experience;

        public Worker(string name, string lastName, DateOnly birthDate,
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

        public Worker SetPositionId(int positionId)
        {
            _idPosition = positionId;

            return this;
        }

        public string GetName()
        {
            return _name;
        }

        public Worker SetName(string name)
        {
            _name = name;

            return this;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public Worker SetLastName(string lastName)
        {
            _lastName = lastName;

            return this;
        }

        public string GetEmail()
        {
            return _email;
        }

        public Worker SetEmail(string email)
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

        public Worker SetPassportSeries(short series)
        {
            _passportSeries = series;

            return this;
        }

        public short GetPassportNumber()
        {
            return _passportNumber;
        }

        public Worker SetPassportNumber(short number)
        {
            _passportNumber = number;

            return this;
        }

        public float GetExperience()
        {
            return _experience;
        }
    }
}
