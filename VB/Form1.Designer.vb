Namespace dxSample
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.userControl_UsingDetailReportBandDocument = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.userControl_SubreportsDocument = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.userControl_UsingDetailReportBandDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.userControl_SubreportsDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.userControl_UsingDetailReportBandDocument, Me.userControl_SubreportsDocument})
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.userControl_UsingDetailReportBandDocument, Me.userControl_SubreportsDocument})
            ' 
            ' userControl_UsingDetailReportBandDocument
            ' 
            Me.userControl_UsingDetailReportBandDocument.Caption = "Master-Detail Report by using Detail Report Bands"
            Me.userControl_UsingDetailReportBandDocument.ControlName = "UserControl_UsingDetailReportBand"
            Me.userControl_UsingDetailReportBandDocument.ControlTypeName = "dxSample.UserControl_UsingDetailReportBand"
            ' 
            ' userControl_SubreportsDocument
            ' 
            Me.userControl_SubreportsDocument.Caption = "Master-Detail Report by using Subreports"
            Me.userControl_SubreportsDocument.ControlName = "UserControl_Subreports"
            Me.userControl_SubreportsDocument.ControlTypeName = "dxSample.UserControl_Subreports"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1005, 794)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.userControl_UsingDetailReportBandDocument, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.userControl_SubreportsDocument, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private userControl_UsingDetailReportBandDocument As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private userControl_SubreportsDocument As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private formAssistant1 As DevExpress.XtraBars.FormAssistant

    End Class
End Namespace

