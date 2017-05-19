using FileSystem.BLL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmRole : BaseForm
    {

        TreeNode _selectedNode = null;
        RoleLogic _roleLogic = new RoleLogic();
        UserLogic _userLogic = new UserLogic();
        FunctionLogic _functionLogic = new FunctionLogic();
        List<int > _lis = new List<int>();
        List<int> _lisUser = new List<int>();
        int _roleID = 0;
        Role _role = new Role();
        UserRoleLogic _userroleFunction = new UserRoleLogic();
        List<User > _deleteUser = new List<User >();
        List<int> _ruid = new List<int>();


        public FrmRole()
        {
            InitializeComponent();
        }

       

        private void FrmRole_Load(object sender, EventArgs e)
        {
            InitRoleTree();
            tvRole.ExpandAll();
        }

        private void InitRoleTree()
        {
            TreeNode root = tvRole.Nodes.Add("角色");
            AddChildNode(root);
        }

        private void AddChildNode(TreeNode pNode)
        {
            List<Role> list = _roleLogic.GetRoles();
            foreach (var r in list)
            {
                TreeNode node = new TreeNode(r.RoleName);
                node.Tag = r;
                node.Name = r.RoleID.ToString ();
                pNode.Nodes.Add(node);
            }
        }



   

        private void tvRole_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Role r = e.Node.Tag as Role;
            if (r == null) return;
            _role = r;
            _selectedNode = e.Node;
            lstUser.Tag = r;
            //FrmEditTree fet = new FrmEditTree(r.RoleID);                                      //_seleNode = e.Node;
            SeleUser(r);//显示可编辑用户
           
            SeleFunction(r);
            
            _roleID = r.RoleID;
        }

        private void SeleFunction(Role r)
        {
            InitFunctionTree(r);
        }

        private void InitFunctionTree(Role r)
        {
            lstFunction.Items.Clear();
            List<Function> list = _functionLogic.GetRoleFunction(r.RoleID);
            if (list == null) return;
            _lis.Clear();
            foreach (var f in list)
            {
                lstFunction.Items.Add(f.FunctionName);
                _lis.Add(f.FunctionID);
            }

        }

        private void SeleUser(Role r)
        {
            lstUser.Items.Clear();
            List<User> list = _userLogic.GetUsersByRID(r.RoleID);
            if (list == null) return;
            _lisUser.Clear();
            foreach (var u in list)
            {
                lstUser.Items.Add(u);
                lstUser.Tag = u;
                _deleteUser.Add(u);
                _lisUser.Add(u.UserID);
            }
        }

        private void btsele_Click(object sender, EventArgs e)
        {
            FrmEditTree fet = new FrmEditTree(_lis,_roleID );
            fet.ShowDialog();
        }

        private void btup_Click(object sender, EventArgs e)
        {
            User u = lstUser.SelectedItem as User;
            if (u == null) return;

            UserRole ur = new UserRole(u.UserID, _roleID);
            _userroleFunction.DeleteRoleUser(ur);
            lstUser.Items.Clear();
            
            SeleUser(_role);
        }

        private void btse_Click(object sender, EventArgs e)
        {
            FrmEditUser fdu = new FrmEditUser(_lisUser, _roleID);
            if(fdu.ShowDialog()== DialogResult.OK)
            {
                if (_selectedNode == null) return;
                Role r = _selectedNode.Tag as Role;
                SeleUser(r);
            }
        }

        private void lisRole_Click(object sender, EventArgs e)
        {
           User u = lstUser.Tag as User;
            foreach (var t in _deleteUser) {
                
                //if(t.UserID ==sender.)
                //{
                //    _userId = t.UserID;
                //}
            }                      
        }
    }
}

