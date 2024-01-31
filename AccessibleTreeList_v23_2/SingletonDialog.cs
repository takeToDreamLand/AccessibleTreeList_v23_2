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
        public static SingletonDialog instance;
        public SingletonDialog()
        {
            InitializeComponent();
            LoadTree();
        }

        //public static SingletonDialog Instance
        //{
        //    get
        //    {
        //        if (instance == null || instance.IsDisposed)
        //        {
        //            instance = new SingletonDialog();
        //        }
        //        return instance;
        //    }
        //}
        public void Reinit()
        {
            LoadTree();
            //this.Controls.Clear();
            //this.Controls.Add(this.treeList1);

            //EnhanceAccessibility();
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
        void EnhanceAccessibility()
        {
            // 增强目标控件Accessibility能力，表现为单元格被识别时有更准确的名称。
            DevExpress.Accessibility.DXAccessible.QueryAccessibleInfo += (s, e) =>
            {
                // 增强treeList2控件中树节点的Accessibility能力
                if (e.Role == AccessibleRole.OutlineItem
                    && e.OwnerControl == this.treeList1)
                {
                    Console.WriteLine(e.Name);
                    return;
                }
            };
        }
    }
}
