using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Дата транзакции 
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Количество денежных средств, участвовавших в транзакции
        /// </summary>
        public double Value { get; set; }
        
        /// <summary>
        /// Описание операции
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Транзакция (списывание или пополнение средств)
        /// </summary>
        /// <param name="transactionData">Дата транзакции</param>
        /// <param name="transactionValue">Количество денежных средств, участвовавших в транзакции</param>
        /// <param name="transactionDescr">Описание операции</param>
        public Transaction(DateTime transactionData, double transactionValue, string transactionDescr)
        {
            Data = transactionData;
            Value = transactionValue;
            Description = transactionDescr;
        }
    }
}
