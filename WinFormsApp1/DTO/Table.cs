using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
