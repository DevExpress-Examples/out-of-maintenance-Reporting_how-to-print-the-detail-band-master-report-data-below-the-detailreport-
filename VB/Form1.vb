Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()

            AddHandler tabbedView1.QueryControl, AddressOf tabbedView1_QueryControl
        End Sub


        Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
            If e.Document Is userControl_UsingDetailReportBandDocument Then
                e.Control = New dxSample.UserControl_UsingDetailReportBand()
            End If
            If e.Document Is userControl_SubreportsDocument Then
                e.Control = New dxSample.UserControl_Subreports()
            End If
            If e.Control Is Nothing Then
                e.Control = New System.Windows.Forms.Control()
            End If
        End Sub
    End Class
End Namespace
