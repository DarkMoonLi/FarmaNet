using System;

namespace FarmaNetBackend.Models.Worker
{
    public class Worker
    {
        private int m_idWorker;
        private int m_idPosition;
        private string m_name;
        private string m_lastName;
        private string m_email;
        private DateTime m_birthDate;
        private short m_passportSeries;
        private short m_passportNumber;
        private float m_experience;

        public Worker(string name, string lastName, DateTime birthDate,
                      short passportSeries, short passportNumber, float experience = 0,
                      string email = "", int idPosition = 0)
        {
            m_name = name;
            m_lastName = lastName;
            m_birthDate = birthDate;
            m_passportSeries = passportSeries;
            m_passportNumber = passportNumber;
            m_experience = experience;
            m_email = email;
            m_idPosition = idPosition;
        }

        public int GetId()
        {
            return m_idWorker;
        }

        public int GetPositionId()
        {
            return m_idPosition;
        }

        public Worker SetPositionId(int positionId)
        {
            m_idPosition = positionId;

            return this;
        }

        public string GetName()
        {
            return m_name;
        }

        public Worker SetName(string name)
        {
            m_name = name;

            return this;
        }

        public string GetLastName()
        {
            return m_lastName;
        }

        public Worker SetLastName(string lastName)
        {
            m_lastName = lastName;

            return this;
        }

        public string GetEmail()
        {
            return m_email;
        }

        public Worker SetEmail(string email)
        {
            m_email = email;

            return this;
        }

        public DateTime GetBirthDate()
        {
            return m_birthDate;
        }

        public short GetPassportSeries()
        {
            return m_passportSeries;
        }

        public Worker SetPassportSeries(short series)
        {
            m_passportSeries = series;

            return this;
        }

        public short GetPassportNumber()
        {
            return m_passportNumber;
        }

        public Worker SetPassportNumber(short number)
        {
            m_passportNumber = number;

            return this;
        }

        public float GetExperience()
        {
            return m_experience;
        }
    }
}
