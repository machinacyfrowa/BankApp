using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Transfer
    {
        private int id;
        private string source;
        private string target;
        private int amount;
        private DateTime date;

        public Transfer(int id, string source, string target, int amount, DateTime date)
        {
            this.id = id;
            this.source = source;
            this.target = target;
            this.amount = amount;
            this.date = date;
        }
        public int Id
        {
            get { return id; }
        }
        public string Source
        {
            get { return source; }
        }
        public string Target
        {
            get { return target; }
        }
        public int Amount
        {
            get { return amount; }
        }
        public DateTime Date
        {
            get { return date; }
        }
    }
}
