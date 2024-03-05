using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class WebUsersDto
    {
        public int Id { get; set; }
        // [Column("WEBUSERID")]
        public string webUserID { get; set; }
        // [Column("AD_SOYAD")]
        public string name { get; set; }
        // [Column("AD_SOYAD")]
        public string authType { get; set; }
        //[Column("EMAIL")]
        public string email { get; set; }
        // [Column("PASSWORD")]
        public string password { get; set; }
        // [Column("ROLE")]
        public Int64 readOnlyAccess { get; set; }
        public Int64 readWriteAccess { get; set; }
        //IsActive
        public int isActive { get; set; }
    }
}
