﻿namespace LogicClassLibrary.Entities
{
    public abstract class Entity
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime CreatedAt { get; protected set; } = DateTime.Now;

        public virtual void Update(int id, DateTime createdAt)
        {
            Id = id;
            CreatedAt = createdAt;
        }
    }
}
