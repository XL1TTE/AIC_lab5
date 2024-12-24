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
        /// <summary>
        /// Получает все сущности из базы данных.
        /// </summary>
        /// <returns>Коллекция сущностей.</returns>
        IEnumerable<Entity> ReciveAll();
        /// <summary>
        /// Добавляет сущнсоть в базу данных.
        /// </summary>
        /// <param name="entity">Обхект сущности для добавления.</param>
        public void Create(Entity entity);
        /// <summary>
        /// Обновляет существующую сущность в базе данных на новую.
        /// </summary>
        /// <param name="toUpdate">Сущность для обновления (Важен только id).</param>
        /// <param name="newData">Сущность на которую нужно обновить.</param>
        public void Update(Entity toUpdate, Entity newData);
        /// <summary>
        /// Удаляет сущность из базы данных.
        /// </summary>
        /// <param name="entity">Сузщность, которую нужно удалить.</param>
        public void Delete(Entity entity);
    }
}
