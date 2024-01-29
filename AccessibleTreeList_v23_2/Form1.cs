using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Accessibility;
using DevExpress.Accessibility;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessibleTreeList_v23_2
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            //OverwriteCombo();
            OverwriteTree();
            EnhanceAccessibility();

        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        // 新建一个新的树控件替换Page0中的树控件
        void OverwriteTree()
        {
            //this.treeList1.Location = new System.Drawing.Point(0, 0);
            //this.treeList1.MenuManager = this.tabFormDefaultManager1;
            //this.treeList1.Name = "treeList1";
            //this.treeList1.BeginUnboundLoad();
            //this.treeList1.EndUnboundLoad();
            //this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            //this.treeList1.Size = new System.Drawing.Size(331, 209);
            //this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            //this.colEmployeeID,
            //this.colLastName,
            //this.colFirstName,
            //this.colTitle,
            //this.colTitleOfCourtesy,
            //this.colBirthDate,
            //this.colHireDate,
            //this.colAddress,
            //this.colCity,
            //this.colRegion,
            //this.colPostalCode,
            //this.colCountry,
            //this.colHomePhone,
            //this.colExtension,
            //this.colSalary,
            //this.colOnVacation,
            //this.colPhoto,
            //this.colNotes,
            //this.colReportsTo});
            //this.treeList1.TabIndex = 0;

            //this.tabFormContentContainer1.Controls.Clear();
            //this.tabFormContentContainer1.Controls.Add(this.treeList1);
        }
        void EnhanceAccessibility()
        {
            //// 增强目标控件Accessibility能力，表现为单元格被识别时有更准确的名称。
            //DevExpress.Accessibility.DXAccessible.QueryAccessibleInfo += (s, e) => {
            //    // 增强treeList2控件中树节点的Accessibility能力
            //    if (e.Role == AccessibleRole.OutlineItem
            //        && e.OwnerControl == this.treeList2)
            //    {
            //        Console.WriteLine(e.Name);
            //        return;
            //    }
            //    // 增强treeList2控件中树节点属性格的Accessibility能力
            //    if (e.Role == AccessibleRole.Cell // 树节点的属性格，或表格中的单元格
            //       && e.OwnerControl == this.treeList2)
            //    {
            //        TreeListAccessibleRowCellObject cellAccessible = e.GetDXAccessible<TreeListAccessibleRowCellObject>();
            //        e.Name = cellAccessible.Value; // 用单元格属性代替默认的AccessibleName，一般为Name Row 1、Name Row 2之类的。
            //        Console.WriteLine(e.Name);
            //        return;
            //    }
            //};
        }
        void OverwriteCombo()
        {

            ComboBoxEdit combo = new ComboBoxEdit();
            combo.Properties.Items.AddRange(new object[] {
                "Alex White",
                "Mike Norton",
                "Ann Arnaz",
                "Terry Bradley"
            });
            this.tabFormContentContainer1.Controls.Clear();
            this.tabFormContentContainer1.Controls.Add(combo);
        }
        static int OpenFormCount = 1;

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonDialog.Instance.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingletonDialog.Instance.ShowDialog();
        }
    }
    
}
