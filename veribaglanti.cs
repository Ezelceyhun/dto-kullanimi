
using System.Windows.Forms;

namespace json_dosya_okuma_ve_2li_sistemden_10luk_sayıya_cevirme
{
    class veribaglantisi
    {
        public int id {  get; set; }
        public string form_ad { get; set; }
        public int o_yetki { get; set; }
        public int y_yetki { get; set; }
        public veribaglantisi(int id, string form_ad, int o_yetki, int y_yetki)
        {
            this.id = id;
            this.form_ad = form_ad;
            this.o_yetki = o_yetki;
            this.y_yetki = y_yetki;
        }
        public veribaglantisi()
        {
            MessageBox.Show("boş veri ");
        }
    }
}