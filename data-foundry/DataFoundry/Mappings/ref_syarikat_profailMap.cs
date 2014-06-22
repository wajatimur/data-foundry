using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Kpdnkk.Ebekalan.Models {
    
    
    public class ref_syarikat_profailMap : ClassMap<ref_syarikat_profail> {
        
        public ref_syarikat_profailMap() {
			Table("ref_syarikat_profail");
			LazyLoad();
			Id(x => x.RecordID).GeneratedBy.Identity().Column("RecordID");
			Map(x => x.NamaSyarikat).Column("NamaSyarikat");
			Map(x => x.Alamat).Column("Alamat");
			Map(x => x.Komunikasi).Column("Komunikasi");
			Map(x => x.JenisSyarikat).Column("JenisSyarikat");
			Map(x => x.Pegawai).Column("Pegawai");
			Map(x => x.KodJenisPerniagaan).Column("KodJenisPerniagaan");
			Map(x => x.KodCawanganLama).Column("KodCawanganLama");
			Map(x => x.KodNegeri).Column("KodNegeri");
			Map(x => x.SenaraiKomoditi).Column("SenaraiKomoditi");
			Map(x => x.NoDaftarInduk).Column("NoDaftarInduk");
			Map(x => x.SourceRecordID).Column("SourceRecordID");
			Map(x => x.KodJenisSyarikat).Column("KodJenisSyarikat");
			Map(x => x.KodCawangan).Column("KodCawangan");
        }
    }
}
