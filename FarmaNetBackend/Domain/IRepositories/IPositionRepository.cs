using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PositionDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IPositionRepository
    {
        public List<Position> GetPositions();
        public Position GetPositionById(int id);
        public void AddPosition(PositionDto positionDto);
        public void UpdatePosition(PositionDto positionDto);
        public void RemovePosition(int id);
    }
}
