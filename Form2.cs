using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace json_dosya_okuma_ve_2li_sistemden_10luk_sayıya_cevirme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public void PingHost(string hostname)
        {
        }
        veribaglantisi data;
        List<veribaglantisi> ver;
        private void Form2_Load(object sender, EventArgs e)
        {
            ver = new List<veribaglantisi>();
            ver.Add(new veribaglantisi() { id = 1, form_ad = "deneme", o_yetki = 2, y_yetki = 3 });

            foreach (var item in ver)
            {
                dataGridView1.Rows.Add(item.id, item.form_ad, item.o_yetki, item.y_yetki);
            }


            dataGridView1.DataSource = ver;
            if(ver == null)
            {
                MessageBox.Show("data boş");
            }
            else
            {

                MessageBox.Show("data dolu");
                dataGridView1.DataSource = ver;
            }
        }
    }
}
