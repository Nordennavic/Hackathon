using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{

    public class Service
    {
        /// <summary>
        /// ПОМЕТЬ САМ!
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описание услуги
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Стоимость подключения
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="servDescr">Описание услуги</param>
        /// <param name="cost">Стоимость подключения</param>
        Service(int id, string servDescr, int cost)
        {
            Id = id;
            Description = servDescr;
            Cost = cost;
        }
        Service()
        {
        }
    }
}