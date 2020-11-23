using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Newtonsoft.Json;

namespace Win.Accnts
{
    public partial class UCEarmarkPR : DevExpress.XtraEditors.XtraUserControl
    {
        private Appropriations appropriations;
        HttpClient httpClient;

        public UCEarmarkPR(Appropriations appropriations)
        {
            InitializeComponent();
            this.appropriations = appropriations;
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Program.URL)
            };
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {User.Token.AccessToken}");
            Init();
        }

        async void Init()
        {
            try
            {
                var prContent = await httpClient.PostAsync("api/appropriation/GETPR", new FormUrlEncodedContent(
                    new Dictionary<string, string>()
                    {
                        {"Id",appropriations.Id.ToString()}
                    }));
                var pr = await prContent.Content.ReadAsStringAsync();
                this.purchaseRequestsBindingSource.DataSource = JsonConvert.DeserializeObject<List<PurchaseRequests>>(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
