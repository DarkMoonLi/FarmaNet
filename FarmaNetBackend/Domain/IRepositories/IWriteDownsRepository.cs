﻿using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.WriteDownsDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IWriteDownsRepository
    {
        public List<WriteDowns> GetWriteDowns();
        public WriteDowns GetWriteDownById(int id);
        public void AddWriteDown(WriteDownsDto writeDownsDto);
        public void UpdateWriteDown(WriteDownsDto writeDownsDto);
        public void RemoveWriteDown(int id);
    }
}