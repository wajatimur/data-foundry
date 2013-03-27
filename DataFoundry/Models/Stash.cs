using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFoundry.Models
{
    public class Stash
    {
        public virtual int Id { get; private set; }
        public virtual string TableName { get; set; }
        public virtual string RowHeader { get; set; }
        public virtual string RowData { get; set; }
        public virtual DateTime TimeCreated { get; set; }
    }
}
