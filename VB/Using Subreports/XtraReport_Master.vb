Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class XtraReport_Master
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
            CType(DirectCast(sender, XRSubreport).ReportSource, XtraReport_Detail).Parameters("paramCategoryID").Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
        End Sub
    End Class
End Namespace
