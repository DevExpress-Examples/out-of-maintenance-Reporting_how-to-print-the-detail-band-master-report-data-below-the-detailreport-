namespace dxSample {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.userControl_UsingDetailReportBandDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.userControl_SubreportsDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl_UsingDetailReportBandDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl_SubreportsDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.userControl_UsingDetailReportBandDocument,
            this.userControl_SubreportsDocument});
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.userControl_UsingDetailReportBandDocument,
            this.userControl_SubreportsDocument});
            // 
            // userControl_UsingDetailReportBandDocument
            // 
            this.userControl_UsingDetailReportBandDocument.Caption = "Master-Detail Report by using Detail Report Bands";
            this.userControl_UsingDetailReportBandDocument.ControlName = "UserControl_UsingDetailReportBand";
            this.userControl_UsingDetailReportBandDocument.ControlTypeName = "dxSample.UserControl_UsingDetailReportBand";
            // 
            // userControl_SubreportsDocument
            // 
            this.userControl_SubreportsDocument.Caption = "Master-Detail Report by using Subreports";
            this.userControl_SubreportsDocument.ControlName = "UserControl_Subreports";
            this.userControl_SubreportsDocument.ControlTypeName = "dxSample.UserControl_Subreports";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 794);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl_UsingDetailReportBandDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl_SubreportsDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document userControl_UsingDetailReportBandDocument;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document userControl_SubreportsDocument;
        private DevExpress.XtraBars.FormAssistant formAssistant1;

    }
}

