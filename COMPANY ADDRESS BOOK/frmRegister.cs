using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_ADDRESS_BOOK
{
    public partial class frmRegister : Form
    {
        #region CONNECTION TO DATABASE

        private static string provider = mpc.settingsJson.Access.Provider.ToString();
        private static string dataSource = "Data Source=" + Environment.CurrentDirectory + "\\COMPANYADDRESSBOOK.accdb;";
        private static string peristentSecurityInfo = mpc.settingsJson.Access.PersistSecurityInfo.ToString();
        private static string accessConnectionString = provider + dataSource + peristentSecurityInfo;
        private OleDbConnection connection = new OleDbConnection(accessConnectionString);

        #endregion

        public frmRegister()
        {
            InitializeComponent();
            OBTAIN_AGENCY();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void OBTAIN_AGENCY()
        {
            try
            {
                connection.Open();

                string _strSql = OBTAIN_AGENCY_MAKE_QRY();

                OleDbCommand command = new OleDbCommand(_strSql, connection);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbAgency.Items.Add(reader["ITEM"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private string OBTAIN_AGENCY_MAKE_QRY()
        {
            StringBuilder _strSql = new StringBuilder();

            _strSql.Append(" SELECT \r\n");
            _strSql.Append("    ID & '-' & Name AS ITEM \r\n");
            _strSql.Append(" FROM \r\n");
            _strSql.Append("    AGENCY \r\n");
            _strSql.Append(" WHERE \r\n");
            _strSql.Append("    Deleted = 0 \r\n");

            return _strSql.ToString();
        }
    }
}
