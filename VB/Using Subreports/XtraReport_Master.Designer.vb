Namespace dxSample
    Partial Public Class XtraReport_Master
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport_Master))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine2, Me.xrSubreport1, Me.xrLine1, Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 151.0417F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 137.375F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(650F, 13.625F)
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 43.75F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 13.625F)
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(393.75F, 57.37498F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(226.4583F, 80F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(18.75F, 105.2083F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(356.25F, 23F)
            Me.xrLabel2.Text = "xrLabel2"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 16F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(18.75F, 64.16667F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(356.25F, 41.04167F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
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
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ReportSource = New dxSample.XtraReport_Detail()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(650F, 43.75F)
            ' 
            ' XtraReport_Master
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.ComponentStorage.Add(Me.sqlDataSource1)
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "14.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private xrLine2 As DevExpress.XtraReports.UI.XRLine
    End Class
End Namespace
