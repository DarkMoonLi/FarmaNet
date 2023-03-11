using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PositionDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IPositionRepository
    {
        public List<Position> GetPositions();
        public Position GetPositionById(int id);
        public void AddPosition(AddPositionDto positionDto);
        public void UpdatePosition(UpdatePositionDto positionDto);
        public void RemovePosition(int id);
    }
}
