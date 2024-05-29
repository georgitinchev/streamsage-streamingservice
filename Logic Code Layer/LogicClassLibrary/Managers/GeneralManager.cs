using DTOs;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	// Abstract class with specifiable DTO type and Entity type for transform method + CRUD methods
	public abstract class GeneralManager<TDto, TEntity> where TEntity: Entity
	{
		public abstract TEntity? TransformDTOToEntity(TDto dto);
		public abstract TDto TransformEntityToDTO(TEntity entity);
		public abstract void Create(TEntity entity);
		public abstract TEntity Read(int id);
		public abstract void Update(TEntity entity);
		public abstract void Delete(int id);
    }
}
