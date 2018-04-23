Namespace dxSample
    Partial Public Class XtraReport_DetailReportBand
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport_DetailReportBand))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Categories"
            tableInfo1.Name = "Categories"
            columnInfo1.Name = "CategoryID"
            columnInfo2.Name = "CategoryName"
            columnInfo3.Name = "Description"
            columnInfo4.Name = "Picture"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            tableQuery2.Name = "Products"
            tableInfo2.Name = "Products"
            columnInfo5.Name = "ProductID"
            columnInfo6.Name = "ProductName"
            columnInfo7.Name = "SupplierID"
            columnInfo8.Name = "CategoryID"
            columnInfo9.Name = "QuantityPerUnit"
            columnInfo10.Name = "UnitPrice"
            columnInfo11.Name = "UnitsInStock"
            columnInfo12.Name = "UnitsOnOrder"
            columnInfo13.Name = "ReorderLevel"
            columnInfo14.Name = "Discontinued"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14})
            tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            masterDetailInfo1.Name = "FK_Products_Categories"
            Me.sqlDataSource1.Relations.Add(masterDetailInfo1)
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 16F)
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(393.3333F, 44.29165F)
            Me.xrLabel6.StyleName = "DataField"
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.Text = "xrLabel6"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(9.999943F, 64.70833F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(403.3333F, 18F)
            Me.xrLabel7.StyleName = "DataField"
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' DetailReport1
            ' 
            Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail2})
            Me.DetailReport1.DataMember = "Categories.FK_Products_Categories"
            Me.DetailReport1.DataSource = Me.sqlDataSource1
            Me.DetailReport1.Level = 0
            Me.DetailReport1.Name = "DetailReport1"
            ' 
            ' Detail2
            ' 
            Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail2.HeightF = 29.16667F
            Me.Detail2.Name = "Detail2"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.ProductName")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.2857142857142857R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.UnitPrice")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.2857142857142857R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.UnitsOnOrder")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.2857142857142857R
            ' 
            ' DetailReport2
            ' 
            Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail3})
            Me.DetailReport2.Level = 1
            Me.DetailReport2.Name = "DetailReport2"
            ' 
            ' Detail3
            ' 
            Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
            Me.Detail3.HeightF = 92.70834F
            Me.Detail3.Name = "Detail3"
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel7, Me.xrPictureBox1})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 0F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(649.9999F, 92.70834F)
            Me.xrPanel1.StylePriority.UseBackColor = False
            Me.xrPanel1.StylePriority.UseBorders = False
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(419.7083F, 10.00001F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(220.2916F, 72.70834F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            Me.xrPictureBox1.StylePriority.UseBorders = False
            ' 
            ' XtraReport_DetailReportBand
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport1, Me.DetailReport2})
            Me.ComponentStorage.Add(Me.sqlDataSource1)
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail2 As DevExpress.XtraReports.UI.DetailBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail3 As DevExpress.XtraReports.UI.DetailBand
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    End Class
End Namespace
