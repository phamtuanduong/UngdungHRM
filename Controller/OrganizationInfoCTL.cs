using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class OrganizationInfoCTL
    {
        private static OrganizationInfoCTL instance;

        private OrganizationInfo organizationInfo;

        public OrganizationInfoCTL()
        {
            organizationInfo = new OrganizationInfo();
        }
        public static OrganizationInfoCTL Instance
        {
            get { if (instance == null) instance = new OrganizationInfoCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            string query = "select * from Organization_General_Info";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                try
                {
                    organizationInfo = new OrganizationInfo(data.Rows[0]);
                    if (organizationInfo.OrganizationName != null)
                    {
                        return true;
                    }
                }
                catch { }
            }
            ;

            return false;
        }

        public OrganizationInfo GetInfo()
        {
            return organizationInfo;
        }

        public void Update()
        {

            OrganizationInfo d = organizationInfo;

            string query = string.Format("UPDATE [dbo].[Organization_General_Info] SET [OrganizationName]=N'{0}',[Phone]=N'{1}',[Email]=N'{2}',[AddressStreet1]=N'{3}'"
            + ",[City]=N'{4}',[Zip]=N'{5}',[Note]=N'{6}',[TaxID]=N'{7}',[RegistrationNumber]=N'{8}',[Fax]=N'{9}',[AddressStreet2]=N'{10}',[State]=N'{11}',[Country]=N'{12}'",
            d.OrganizationName, d.Phone, d.Email, d.Adrress1, d.City,d.Zip,d.Note,d.TaxID,d.RegistrationNumber,d.Fax,d.Adrress2,d.State,d.Country);

            if(SqlProvider.Instance.ExecuteScalar("select COUNT(*) from Organization_General_Info", null) < 1)
            {
                query = string.Format("insert into Organization_General_Info values (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}')",
                    d.OrganizationName, d.Phone, d.Email, d.Adrress1, d.City, d.Zip, d.Note, d.TaxID, d.RegistrationNumber, d.Fax, d.Adrress2, d.State, d.Country);

                SqlProvider.Instance.ExecuteNonQuery($"insert into Structure (Name) values (N'{d.OrganizationName}')");
            }

            SqlProvider.Instance.ExecuteNonQuery(query);

        }

        public void Add(OrganizationInfo info)
        {
            organizationInfo = info;
        }
    }
}
