using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Models;
using Models.Repository;
using Newtonsoft.Json;
using Win.Properties;

namespace Win
{
    public class StaticSettings
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private HttpClient httpClient;

        public string FT = Win.Properties.Settings.Default.FundType;
        int? officeId = User.OfficeId();

        public StaticSettings()
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Program.URL)
            };
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {User.Token.AccessToken}");
        }

        private Years activeYear
        {
            get
            {
                var content = httpClient.GetAsync("api/StaticSetting/Year").Result;
                return JsonConvert.DeserializeObject<Years>(content.Content.ReadAsStringAsync().Result);
            }
        }

        public async Task<Offices> settings()
        {
            var client = await httpClient.GetAsync("api/Staticetting/DefaultOffice");
            var office = JsonConvert.DeserializeObject<Offices>(await client.Content.ReadAsStringAsync());
            return office;
        }

        public Offices Offices => settings().Result;
        public List<Signatories> chiefOfOffice => new UnitOfWork().Signatories.Get(m => m.Year == Year);

        public int Year
        {
            get
            {
                if (Settings.Default.UseDefaultYear == true)
                {
                    return Settings.Default.DefaultYear;
                }
                return activeYear.Year.ToInt();

            }
        }
        public int Id => settings().Id;
        //public  string PG => settings().PG;
        //public  string PGPos => settings().PGPos;
        //public  string PA => settings().PA;
        //public  string PAPos => settings().PAPos;
        //public  string PBO => settings().PBO;
        //public  string PBOPos => settings().PBOPos;
        //public  string PT => settings().PT;
        //public  string PTPos => settings().PTPos;
        //public  string PAccountant => settings().PAccountant;
        //public  string PAccountantPos => settings().PAccountantPos;
        //public  string PGSO => settings().PGSO;
        //public  string PGSOPosition => settings().PGSOPosition;
        public string OfficeName => settings().Result.OfficeName;
        public string Head => settings().Result.Chief;
        public string HeadPos => settings().Result.ChiefPosition;

        public string ResponsibilityCenter => settings().Result.ResponsibilityCenter;
        public string ResponsibilityCenterCode => settings().Result.ResponsibilityCenterCode;

        public int OfficeId
        {
            get
            {
                if (settings() == null)
                    return 0;
                return settings().Id;
            }
        }



    }
}
