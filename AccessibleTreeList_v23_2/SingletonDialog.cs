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
    // 实现一个单例模式的对话框，对话框中含有一个树控件（TreeList）
    // 默认情况下，当第二次打开对话框，树控件内部会变得无法被UIA访问，换言之失去了Accessibility能力。
    // 通过调研发现，重新初始化和重新挂载树控件会有帮助。
    public partial class SingletonDialog : XtraForm
    {    
        public static SingletonDialog instance;
        private static int initCount;
        public SingletonDialog()
        {
            InitializeComponent();
            LoadTree();
        }

        public static SingletonDialog Instance
        {
            get
            {
                initCount += 1;
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SingletonDialog();
                }
                return instance;
            }
        }
        public void Reinit()
        {
            //InitializeComponent(); // 再次初始化
            LoadTree();
            //Controls.Clear(); // 清理，重新挂载Tree控件
            //Controls.Add(this.treeList1);
        }
        private void LoadTree()
        {
            this.treeList1.ClearNodes();
            this.treeList1.AppendNode(new object[] {
            string.Format("第{0}次初始化", initCount)}, -1);
        }
    }
}
