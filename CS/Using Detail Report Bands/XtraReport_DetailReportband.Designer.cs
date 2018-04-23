namespace dxSample {
    partial class XtraReport_DetailReportBand {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport_DetailReportBand));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.Name = "Categories";
            tableInfo1.Name = "Categories";
            columnInfo1.Name = "CategoryID";
            columnInfo2.Name = "CategoryName";
            columnInfo3.Name = "Description";
            columnInfo4.Name = "Picture";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            tableQuery2.Name = "Products";
            tableInfo2.Name = "Products";
            columnInfo5.Name = "ProductID";
            columnInfo6.Name = "ProductName";
            columnInfo7.Name = "SupplierID";
            columnInfo8.Name = "CategoryID";
            columnInfo9.Name = "QuantityPerUnit";
            columnInfo10.Name = "UnitPrice";
            columnInfo11.Name = "UnitsInStock";
            columnInfo12.Name = "UnitsOnOrder";
            columnInfo13.Name = "ReorderLevel";
            columnInfo14.Name = "Discontinued";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo5,
            columnInfo6,
            columnInfo7,
            columnInfo8,
            columnInfo9,
            columnInfo10,
            columnInfo11,
            columnInfo12,
            columnInfo13,
            columnInfo14});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo2});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1,
            tableQuery2});
            masterDetailInfo1.DetailQueryName = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "Categories";
            masterDetailInfo1.Name = "FK_Products_Categories";
            this.sqlDataSource1.Relations.Add(masterDetailInfo1);
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName")});
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(393.3333F, 44.29165F);
            this.xrLabel6.StyleName = "DataField";
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(9.999943F, 64.70833F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(403.3333F, 18F);
            this.xrLabel7.StyleName = "DataField";
            this.xrLabel7.Text = "xrLabel7";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2});
            this.DetailReport1.DataMember = "Categories.FK_Products_Categories";
            this.DetailReport1.DataSource = this.sqlDataSource1;
            this.DetailReport1.Level = 0;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail2.HeightF = 29.16667F;
            this.Detail2.Name = "Detail2";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.FK_Products_Categories.ProductName")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.2857142857142857D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.FK_Products_Categories.UnitPrice")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 0.2857142857142857D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.FK_Products_Categories.UnitsOnOrder")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 0.2857142857142857D;
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3});
            this.DetailReport2.Level = 1;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail3.HeightF = 92.70834F;
            this.Detail3.Name = "Detail3";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel7,
            this.xrPictureBox1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(649.9999F, 92.70834F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(419.7083F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(220.2916F, 72.70834F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox1.StylePriority.UseBorders = false;
            // 
            // XtraReport_DetailReportBand
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport1,
            this.DetailReport2});
            this.ComponentStorage.Add(this.sqlDataSource1);
            this.DataMember = "Categories";
            this.DataSource = this.sqlDataSource1;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
    }
}
