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
    public partial class FrmEditTree : Form
    {
        FunctionLogic _funLogic = new FunctionLogic();
        List <Role_Function > _seleFunction = new List<Role_Function> ();
        RoleFunctionLogic _roleFunction = new RoleFunctionLogic();
        FrmRole _frm = new FrmRole();
        List<int> _lis = new List<int> ();
        List<int> _fid = new List<int>();
        List<int> _deleFunction = new List<int>();
        bool _yes = true;
        int _rid = 0;
        List<Function> _lisfun = new List<Function>();
        public FrmEditTree(List <int> lis,int rid)
        {
            
            InitializeComponent();
            _lis = lis;
            _rid = rid;
        }
       

            private void FrmEditTree_Load(object sender, EventArgs e)
        {
            InitFunctionTree();//初始化左边的功能树状结构

        }

        private void InitFunctionTree()
        {
            Function f = _funLogic.GetFunctions(-1)[0];
            TreeNode root = tvFunctionTree .Nodes.Add(f.FunctionID.ToString(), f.FunctionName);
            AddChildNode(root, f.FunctionID);
            tvFunctionTree.ExpandAll();
        }
        private void AddChildNode(TreeNode pNode, int pid)
        {
            List<Function> childList = _funLogic.GetFunctions(pid);
            
            foreach (var f in childList)
            {
                
                TreeNode childNode = new TreeNode(f.FunctionName);
                childNode.Name = f.FunctionID.ToString();
                childNode.Tag = f;
                pNode.Nodes.Add(childNode);
                foreach (int t in _lis)
                {
                    if (t == f.FunctionID) {
                        childNode.Checked = true;
                    }

                } 
                AddChildNode(childNode, f.FunctionID);
            }
        }

        private void chksele_CheckedChanged(object sender, EventArgs e)
        {
            setChildNodeCheckedState(tvFunctionTree.Nodes[0], chksele.Checked);
        }
        public void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            currNode.Checked = state;
            foreach (TreeNode n in currNode.Nodes)
            {
                setChildNodeCheckedState(n, state);
            }
            
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvFunctionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectTheParentNodeSelect(e.Node, e.Node.Checked);
            Function f = e.Node.Tag as Function;
            if (e.Node.Checked ) {
            _fid.Add(f.FunctionID);
                _yes = true;
            }
            if(!e.Node.Checked)
            {
                _deleFunction.Add(f.FunctionID);
                _yes = false;
            }


        }
        /// <summary>
        /// 选中节点之后，选中节点的所有子节点
        /// </summary>
        /// <param name="currNode"></param>
        /// <param name="state"></param>
        private void SelectTheParentNodeSelect (TreeNode currNode, bool state)
        {
            TreeNodeCollection nodes = currNode.Nodes;
            if (nodes.Count > 0)
            {
                foreach (TreeNode tn in nodes)
                {
                    tn.Checked = state;
                    SelectTheParentNodeSelect(tn, state);
                }
            }
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            
            if (_yes)
            {
                foreach (var f in _lisfun )
                {
                    Role_Function rf = new Role_Function(_rid, f.FunctionID );
                    _roleFunction.AddRoleFunction(rf);
                }

            }
            else {
                foreach (var f in _deleFunction )
                {
                    Role_Function rf = new Role_Function(_rid, f);
                    _roleFunction.DeleteRoleFunction(rf);
                }
            }
            _lisfun.Clear();
            this.Close();
        }

        private void tvFunctionTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Function f = e.Node.Tag as Function;
            if(e.Node .Checked)
            {
                
                _lisfun.Add(f);
            }
            if(!e.Node .Checked)
            {
                _lisfun.Remove(f);
            }
        }
    }
}
