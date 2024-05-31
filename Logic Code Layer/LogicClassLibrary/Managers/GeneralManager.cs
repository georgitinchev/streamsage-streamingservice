using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Managers
{
    // Abstract class with specifiable DTO type and Entity type for transform method + CRUD methods
    public abstract class GeneralManager<TDto, TEntity> where TEntity : Entity
    {
        public abstract TEntity? TransformDTOToEntity(TDto dto);
        public abstract TDto TransformEntityToDTO(TEntity entity);
        public abstract void Create(TDto dto);
        public abstract TDto Read(int id);
        public abstract void Update(TDto dto);
        public abstract void Delete(int id);
    }
}
