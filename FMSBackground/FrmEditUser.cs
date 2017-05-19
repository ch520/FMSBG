using FileSystem.BLL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmEditUser : Form
    {
        List<int> _lis = new List<int>();
        UserRoleLogic _userRoleLogic = new UserRoleLogic();
        UserLogic _userLogin = new UserLogic();
        List<int> _uid = new List<int>();
        List<int> _deleUser = new List<int>();
        int _rid = 0;
       
        List<User> _lisuser = new List<User>();
        public FrmEditUser(List<int> lis, int rid)
        {
            InitializeComponent();
            _lis = lis;
            _rid = rid;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
        }
        private void InitUserTree()
        {
            TreeNode root = tvindUser.Nodes.Add("所有用户");
            AddChildNode(root);
        }
        private void AddChildNode(TreeNode pNode)
        {
            List<User> list = _userLogin.GetUsers();

            foreach (var u in list)
            {
                TreeNode node = pNode.Nodes.Add(u.UserRealName);
                node.Tag = u;
                foreach (int r in _lis)
                {
                    if (r == u.UserID)
                    {
                        node.Remove();
                    }
                }

            }
            tvindUser.ExpandAll();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void chkSele_CheckedChanged(object sender, EventArgs e)
        {
            setChildNodeCheckedState(tvindUser.Nodes[0], chkSele.Checked);
        }
        public void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            currNode.Checked = state;
            foreach (TreeNode n in currNode.Nodes)
            {
                setChildNodeCheckedState(n, state);
            }

        }

        private void btYes_Click(object sender, EventArgs e)
        {
            
            foreach (var t in _deleUser)
            {
                UserRole rf = new UserRole( t,_rid);
                _userRoleLogic.AddUsrRole(rf);
            }
            DialogResult = DialogResult.OK;
          
        }
        private void tvindUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            User f = e.Node.Tag as User;

            if (e.Node.Checked)
            {
                _deleUser.Add(f.UserID);

            }
        }
       
    }
 }

