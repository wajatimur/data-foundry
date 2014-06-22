using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DataFoundry.Models;


namespace DataFoundry.Mappings
{
    public class StashMap: ClassMap<Stash>
    {
        public StashMap()
        {
            Id(x => x.Id);
            Map(x => x.TableName);
            Map(x => x.RowHeader);
            Map(x => x.RowData);
            Map(x => x.TimeCreated);
        }
    }
}
