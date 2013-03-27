using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Kpdnkk.Ebekalan.Models {
    
    
    public class ref_syarikatMap : ClassMap<ref_syarikat> {
        
        public ref_syarikatMap() {
			Table("ref_syarikat");
			LazyLoad();
			Id(x => x.RecordID).GeneratedBy.Identity().Column("RecordID");
			Map(x => x.NamaSyarikat).Column("NamaSyarikat");
			Map(x => x.NoLesen).Column("NoLesen");
			Map(x => x.JenisPerniagaan).Column("JenisPerniagaan");
			Map(x => x.BarangKawalan).Column("BarangKawalan");
			Map(x => x.AlamatPerniagaan).Column("AlamatPerniagaan");
			Map(x => x.PoskodAlamat).Column("PoskodAlamat");
			Map(x => x.KodNegeriAlamat).Column("KodNegeriAlamat");
			Map(x => x.NoTelefon).Column("NoTelefon");
			Map(x => x.NoFaks).Column("NoFaks");
			Map(x => x.URL).Column("URL");
			Map(x => x.NamaPegawai).Column("NamaPegawai");
			Map(x => x.KodJawatanPegawai).Column("KodJawatanPegawai");
			Map(x => x.EmailPegawai).Column("EmailPegawai");
			Map(x => x.NoHPPegawai).Column("NoHPPegawai");
			Map(x => x.TarikhDaftar).Column("TarikhDaftar");
			Map(x => x.StatusSyarikat).Column("StatusSyarikat");
			Map(x => x.AlamatStor).Column("AlamatStor");
			Map(x => x.PoskodStor).Column("PoskodStor");
			Map(x => x.KodNegeriStor).Column("KodNegeriStor");
			Map(x => x.NoTelefonStor).Column("NoTelefonStor");
			Map(x => x.NoFaksStor).Column("NoFaksStor");
			Map(x => x.PegawaiStor).Column("PegawaiStor");
			Map(x => x.KodJawatanPegawaiStor).Column("KodJawatanPegawaiStor");
			Map(x => x.NoHPPegawaiStor).Column("NoHPPegawaiStor");
			Map(x => x.KodLaluanSyarikat).Column("KodLaluanSyarikat");
			Map(x => x.JenisSyarikat).Column("JenisSyarikat");
			Map(x => x.BarangDisimpan).Column("BarangDisimpan");
			Map(x => x.KodCawangan).Column("KodCawangan");
			Map(x => x.KodWilayah).Column("KodWilayah");
			Map(x => x.KodZon).Column("KodZon");
        }
    }
}
