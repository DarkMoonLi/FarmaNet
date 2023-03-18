using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PositionDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
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

        public Position GetPositionById(GetPositionDto positionDto)
        {
            return _context.Positions.FirstOrDefault(p => p.PositionId == positionDto.PositionId);
        }

        public void AddPosition(AddPositionDto positionDto)
        {
            Position position = positionDto.ConvertToPosition();

            _context.Positions.Add(position);
            _context.SaveChanges();
        }

        public void UpdatePosition(UpdatePositionDto positionDto)
        {
            Position position = GetPositionById(new GetPositionDto { PositionId = positionDto.PositionId });

            if (position != null)
            {
                position.Post = positionDto.Position;
                position.SalaryInHours = positionDto.SalaryInHours;

                _context.Positions.Update(position);
                _context.SaveChanges();
            }
        }

        public void RemovePosition(GetPositionDto positionDto)
        {
            Position position = GetPositionById(positionDto);

            if (position != null)
            {
                _context.Remove(position);
                _context.SaveChanges();
            }
        }
    }
}
