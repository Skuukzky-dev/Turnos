using Npgsql;
using TRNS.Core.DAL;

namespace PostgreSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                TRNS.Core.BO.cUser oUser = new TRNS.Core.BO.cUser();

                oUser.userName = "MILTON";
                oUser.password = "123456";
                oUser.tipoUsuarioID = 1;

                TRNS.Core.BLL.UsersMgr.Create(oUser);

             //   List<TRNS.Core.BO.cUser> lstUsers = TRNS.Core.BLL.UsersMgr.GetUsers();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
