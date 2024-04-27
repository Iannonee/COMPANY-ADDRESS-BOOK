using ALIEN_CODER_2;
using System.Data.OleDb;
using System.Text;

namespace COMPANY_ADDRESS_BOOK
{
    public partial class frmMain : Form
    {
        #region CONNECTION TO DATABASE

        private static string provider = mpc.settingsJson.Access.Provider.ToString();
        private static string dataSource = "Data Source=" + Environment.CurrentDirectory + "\\COMPANYADDRESSBOOK.accdb;";
        private static string peristentSecurityInfo = mpc.settingsJson.Access.PersistSecurityInfo.ToString();
        private static string accessConnectionString = provider + dataSource + peristentSecurityInfo;
        private OleDbConnection connection = new OleDbConnection(accessConnectionString);

        #endregion

        public frmMain()
        {
            InitializeComponent();
            CUSTOM_DESIGN();
            COUNT_CONTACT();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region CUSTOMIZATION

        private void CUSTOM_DESIGN()
        {
            pnlContactSubMenu.Visible = false;
            pnlSubMenuAgency.Visible = false;
        }
        private void HIDE_SUBMENU()
        {
            if (pnlContactSubMenu.Visible)
            {
                pnlContactSubMenu.Visible = false;
            }
            if (pnlSubMenuAgency.Visible)
            {
                pnlSubMenuAgency.Visible = false;
            }
        }
        private void SHOW_SUBMENU(Panel submenu)
        {
            if (!submenu.Visible)
            {
                HIDE_SUBMENU();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        #endregion


        private void btnContact_Click(object sender, EventArgs e)
        {
            SHOW_SUBMENU(pnlContactSubMenu);
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            SHOW_SUBMENU(pnlSubMenuAgency);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        #region DATA ON LOAD

        private void COUNT_CONTACT()
        {
            try
            {
                connection.Open();
                string _strSql = COUNT_CONTACT_MAKE_QRY();

                OleDbCommand command = new OleDbCommand(_strSql, connection);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string counter = reader["CONTACT_NUMBER"].ToString();
                    //lblNumberOfContact.Text = counter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private string COUNT_CONTACT_MAKE_QRY()
        {
            StringBuilder _strSql = new StringBuilder();

            _strSql.Append(" SELECT \r\n");
            _strSql.Append("    COUNT(ID) AS CONTACT_NUMBER \r\n");
            _strSql.Append(" FROM \r\n");
            _strSql.Append("    CONTACT \r\n");
            _strSql.Append(" WHERE \r\n");
            _strSql.Append("    Deleted = 0 \r\n");

            return _strSql.ToString();
        }

        #endregion

        private Form activeForm = null;
        private void OPEN_CHILD_FORM(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistrationContact_Click(object sender, EventArgs e)
        {
            OPEN_CHILD_FORM(new frmRegister());

            HIDE_SUBMENU();
        }
    }
}
