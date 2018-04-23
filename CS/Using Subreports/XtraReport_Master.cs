using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class XtraReport_Master : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport_Master() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XtraReport_Detail)((XRSubreport)sender).ReportSource).Parameters["paramCategoryID"].Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
        }
    }
}
