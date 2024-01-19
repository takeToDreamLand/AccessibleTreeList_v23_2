using DevExpress.XtraBars;
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
            // 增强目标控件Accessibility能力，表现为单元格被识别时有更准确的名称。
            DevExpress.Accessibility.DXAccessible.QueryAccessibleInfo += (s, e) => {
                // 增强treeList2控件中树节点的Accessibility能力
                if (e.Role == AccessibleRole.OutlineItem 
                    && e.OwnerControl == this.treeList2)
                {
                    Console.WriteLine(e.Name);
                    return;
                }
                // 增强treeList2控件中树节点属性格的Accessibility能力
                if (e.Role == AccessibleRole.Cell // 树节点的属性格，或表格中的单元格
                   && e.OwnerControl == this.treeList2)
                {
                    TreeListAccessibleRowCellObject cellAccessible = e.GetDXAccessible<TreeListAccessibleRowCellObject>();
                    e.Name = cellAccessible.Value; // 用单元格属性代替默认的AccessibleName，一般为Name Row 1、Name Row 2之类的。
                    Console.WriteLine(e.Name);
                    return;
                }
            };
            OverwriteTree();
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
            DevExpress.XtraTreeList.TreeList new_tree = new DevExpress.XtraTreeList.TreeList();
            new_tree.Location = new System.Drawing.Point(0, 0);
            new_tree.MenuManager = this.tabFormDefaultManager1;
            new_tree.Name = "treeList1";
            new_tree.BeginUnboundLoad();
            new_tree.EndUnboundLoad();
            new_tree.OptionsBehavior.PopulateServiceColumns = true;
            new_tree.Size = new System.Drawing.Size(331, 209);
            new_tree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colEmployeeID,
            this.colLastName,
            this.colFirstName,
            this.colTitle,
            this.colTitleOfCourtesy,
            this.colBirthDate,
            this.colHireDate,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colHomePhone,
            this.colExtension,
            this.colSalary,
            this.colOnVacation,
            this.colPhoto,
            this.colNotes,
            this.colReportsTo});
            new_tree.TabIndex = 0;
            new_tree.AppendNode(new object[] {
            "3",
            "Leverling",
            "Janet",
            "Sales Representative",
            "Ms.",
            "1963-08-30T00:00:00",
            "1992-04-01T00:00:00",
            "722 Moss Bay Blvd.",
            "Kirkland",
            "WA",
            "98033",
            "USA",
            "(206) 555-3412",
            "3355",
            "2700",
            "0",
            "/9j/4ADY4//2QA=\r\n",
            "Janet has a BS degree in chemistry from Boston College (1984).  She has also comp" +
                "leted a certificate program in food retailing management.  Janet was hired as a " +
                "sales associate in 1991 and promoted to sales representative in February 1992.",
            "2"}, -1);
            this.tabFormContentContainer1.Controls.Clear();
            this.tabFormContentContainer1.Controls.Add(new_tree);
        }
        static int OpenFormCount = 1;
    }
}
