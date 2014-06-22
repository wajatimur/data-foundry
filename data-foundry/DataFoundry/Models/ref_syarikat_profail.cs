using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Kpdnkk.Ebekalan.Models {
    
    public class ref_syarikat_profail {
        public ref_syarikat_profail() { }
        public virtual int RecordID { get; set; }
        public virtual string NamaSyarikat { get; set; }
        public virtual string Alamat { get; set; }
        public virtual string Komunikasi { get; set; }
        public virtual string JenisSyarikat { get; set; }
        public virtual string Pegawai { get; set; }
        public virtual string KodJenisPerniagaan { get; set; }
        public virtual string KodCawanganLama { get; set; }
        public virtual string KodNegeri { get; set; }
        public virtual string SenaraiKomoditi { get; set; }
        public virtual string NoDaftarInduk { get; set; }
        public virtual System.Nullable<int> SourceRecordID { get; set; }
        public virtual string KodJenisSyarikat { get; set; }
        public virtual string KodCawangan { get; set; }
    }
}
