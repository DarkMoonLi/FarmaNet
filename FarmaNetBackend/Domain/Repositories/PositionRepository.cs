using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PositionDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Domain.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        readonly ApplicationDbContext _context;

        public PositionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Position> GetPositions()
        {
            return _context.Positions.ToList();
        }

        public Position GetPositionById(int id)
        {
            return (Position)_context.Positions.Where(p => p.PositionId == id);
        }

        public void AddPosition(AddPositionDto positionDto)
        {
            Position position = positionDto.ConvertToPosition();

            _context.Positions.Add(position);
        }

        public void UpdatePosition(UpdatePositionDto positionDto)
        { }

        public void RemovePosition(int id)
        {
            Position position = _context.Positions.FirstOrDefault(p => p.PositionId == id);

            if (position != null)
            {
                _context.Remove(position);
            }
        }
    }
}
