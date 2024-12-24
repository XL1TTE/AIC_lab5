using AIC_LAB5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_LAB5.DAL.Repository
{
    public interface IEntityRepository<Entity> where Entity: IEntity
    {
        IEnumerable<Entity> ReciveAll();
        public void Create(Entity entity);
        public void Update(Entity toUpdate, Entity newData);
        public void Delete(Entity entity);
    }
}
