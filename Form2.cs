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
using System.Net.Http;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System.Text.Json;

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
        private async void Form2_Load(object sender, EventArgs e)
        {
            //ServerRootRespons class'ı çağırma
            ServerRootRespons serverRootRespons = new ServerRootRespons();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://9fa4da70-7dca-4859-be70-bddd4820b8c3.mock.pstmn.io/");
            HttpResponseMessage data = await client.GetAsync("api/webuser");
            string result = await data.Content.ReadAsStringAsync();
            label1.Text = result;

            //webserver içeriği result değişkenine çektikten sonra ServerRootRespons class'ına atma
            serverRootRespons = JsonSerializer.Deserialize<ServerRootRespons>(result);
            if(serverRootRespons.returnCode == 0)
            {           
                foreach (var i in serverRootRespons.data)
                {
                    dataGridView1.Rows.Add(i.id);
                }
            }

            //veri =  JsonConvert.DeserializeObject< List < veribaglantisi >> (result);

            dataGridView1.Rows.Add(result);
            
        }
    }
}
