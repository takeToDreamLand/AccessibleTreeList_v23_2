using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AccessibleTreeList_v23_2
{
    public partial class SingletonDialog : XtraForm
    {    
        // 静态变量用于保存唯一实例
        private static SingletonDialog instance;

        // 私有构造函数，防止外部直接实例化
        public SingletonDialog()
        {
            InitializeComponent();
            LoadTree();
        }

        public static SingletonDialog Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SingletonDialog();
                }
                return instance;
            }
        }

       
        private void LoadTree()
        {
            this.treeList1.ClearNodes();
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.Size = new System.Drawing.Size(331, 209);
            this.treeList1.AppendNode(new object[] {
            "12/31/2022 00:00:00",
            "New Year\'s Eve",
            "Australia"}, -1);
            this.treeList1.AppendNode(new object[] {
            "01/01/2012 00:00:00",
            "New Year\'s Day",
            "Japan"}, -1);
            this.treeList1.AppendNode(new object[] {
            "01/01/2012 00:00:00",
            "New Year\'s Day",
            "Russia"}, -1);
            this.treeList1.AppendNode(new object[] {
            "01/01/2012 00:00:00",
            "New Year\'s Day",
            "United Arab Emirates"}, -1);
            this.treeList1.AppendNode(new object[] {
            "01/01/2012 00:00:00",
            "New Year\'s Day",
            "United Kingdom"}, -1);
            this.treeList1.AppendNode(new object[] {
            "01/01/2012 00:00:00",
            "New Year\'s Day",
            "United States"}, -1);
        }
    }
}
