
using System;
namespace AccessibleTreeList_v23_2
{
    partial class SingletonDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLocation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDate,
            this.colDisplayName,
            this.colLocation});
            this.treeList1.Location = new System.Drawing.Point(12, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.Size = new System.Drawing.Size(416, 247);
            this.treeList1.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.Name = "colDate";
            // 
            // colDisplayName
            // 
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 0;
            // 
            // colLocation
            // 
            this.colLocation.Name = "colLocation";
            // 
            // SingletonDialog
            // 
            this.ClientSize = new System.Drawing.Size(440, 258);
            this.Controls.Add(this.treeList1);
            this.Name = "SingletonDialog";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            Console.WriteLine("完成初始化");
            Console.WriteLine(this.Controls);
        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDisplayName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLocation;
    }
}