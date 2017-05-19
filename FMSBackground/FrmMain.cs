using FileSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-11 14:13:04 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmMain : Form
    {
        FrmUser _frmUser;
        FrmRole _frmRole;
        FrmFunction _frmFun ;
        FrmDepartment _frmDep;
        Dictionary<string,BaseForm> _frmDict;


        public FrmMain()
        {
            InitializeComponent();
            _frmDict = new Dictionary<string, BaseForm>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitToolBarButtonAction();
            BaseForm firstTab = null;
            if (Factory.Create<AuthLogic>().Auth(GObj.SYSTEM_FUNCTION_USER))
            {
                _frmUser = new FrmUser();
                _frmUser.Show(dockPanel);
                firstTab = _frmUser;
                _frmDict.Add(tool_User.Text , _frmUser);
            }
            if (Factory.Create<AuthLogic>().Auth(GObj.SYSTEM_FUNCTION_DEPARTMENT))
            {
                _frmDep = new FrmDepartment();
                _frmDep.Show(dockPanel);
                if (firstTab == null)
                    firstTab = _frmDep;
                _frmDict.Add(tool_Dep.Text, _frmDep);

            }
            if (Factory.Create<AuthLogic>().Auth(GObj.SYSTEM_FUNCTION_ROLE))
            {
                _frmRole = new FrmRole();
                _frmRole.Show(dockPanel);
                if (firstTab == null)
                    firstTab = _frmRole;
                _frmDict.Add(tool_Role.Text, _frmRole);
            }
            if (Factory.Create<AuthLogic>().Auth(GObj.SYSTEM_FUNCTION_FUNCTION ))
            {
                _frmFun = new FrmFunction();
                _frmFun.Show(dockPanel);
                if (firstTab == null)
                    firstTab = _frmFun;
                _frmDict.Add(tool_Function .Text , _frmFun);
            }

            if (firstTab != null)
                firstTab.Show(dockPanel);
            //在底部状态栏显示当前登录的用户信息
            lblCurrentUser.Text = string.Format("当前管理员:{0}", GObj.CurrentUser.UserRealName);
        }
        private void InitToolBarButtonAction()
        {
            tool_User.Tag = _frmUser;
            tool_Role.Tag = _frmRole;
            tool_Dep.Tag = _frmDep;
            tool_Function.Tag = _frmFun;
        }

        private void tool_User_Click(object sender, EventArgs e)
        {

            string name = (sender as ToolStripButton).Text;


            _frmDict[name].Show(dockPanel);
        }

        private void tool_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Window_CloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_System_Password_Click(object sender, EventArgs e)
        {
            
            FrmUpUserPwd fup = new FrmUpUserPwd();
            fup.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmUpUserPwd fup = new FrmUpUserPwd();
            fup.ShowDialog();
        }
    }
}
