using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class InterpretationManager : GeneralManager<InterpretationDTO, Interpretation>, IInterpretationManager
    {
        public IInterpretationDAL? interpretationDAL;
        public InterpretationManager(IInterpretationDAL _interpretationDAL)
        {
            this.interpretationDAL = _interpretationDAL;
        }

        public override Interpretation? TransformDTOToEntity(InterpretationDTO dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Interpretation(dto.UserId, dto.MovieId, dto.InterpretationText);
        }

        public override InterpretationDTO TransformEntityToDTO(Interpretation entity)
        {
            return new InterpretationDTO(entity.Id, entity.UserId, entity.MovieId, entity.InterpretationText);
        }

        public override void Create(InterpretationDTO dto)
        {
            var entity = TransformDTOToEntity(dto);
            if (entity != null)
            {
                interpretationDAL.CreateInterpretation(dto);
            }
        }

        public override InterpretationDTO Read(int id)
        {
            return interpretationDAL.ReadInterpretation(id);
        }

        public override void Update(InterpretationDTO dto)
        {
            interpretationDAL.UpdateInterpretation(dto);
        }

        public override void Delete(int id)
        {
            interpretationDAL.DeleteInterpretation(id);
        }

    }
}
