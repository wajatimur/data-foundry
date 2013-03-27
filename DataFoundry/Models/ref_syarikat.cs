using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Kpdnkk.Ebekalan.Models {
    
    public class ref_syarikat {
        public ref_syarikat() { }
        public virtual int RecordID { get; set; }
        public virtual string NamaSyarikat { get; set; }
        public virtual string NoLesen { get; set; }
        public virtual string JenisPerniagaan { get; set; }
        public virtual string BarangKawalan { get; set; }
        public virtual string AlamatPerniagaan { get; set; }
        public virtual string PoskodAlamat { get; set; }
        public virtual string KodNegeriAlamat { get; set; }
        public virtual string NoTelefon { get; set; }
        public virtual string NoFaks { get; set; }
        public virtual string URL { get; set; }
        public virtual string NamaPegawai { get; set; }
        public virtual string KodJawatanPegawai { get; set; }
        public virtual string EmailPegawai { get; set; }
        public virtual string NoHPPegawai { get; set; }
        public virtual string TarikhDaftar { get; set; }
        public virtual string StatusSyarikat { get; set; }
        public virtual string AlamatStor { get; set; }
        public virtual string PoskodStor { get; set; }
        public virtual string KodNegeriStor { get; set; }
        public virtual string NoTelefonStor { get; set; }
        public virtual string NoFaksStor { get; set; }
        public virtual string PegawaiStor { get; set; }
        public virtual string KodJawatanPegawaiStor { get; set; }
        public virtual string NoHPPegawaiStor { get; set; }
        public virtual string KodLaluanSyarikat { get; set; }
        public virtual string JenisSyarikat { get; set; }
        public virtual string BarangDisimpan { get; set; }
        public virtual string KodCawangan { get; set; }
        public virtual string KodWilayah { get; set; }
        public virtual string KodZon { get; set; }
    }
}
