using System;
using System.Collections.Generic;
using System.Linq;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();

            tabbedView1.QueryControl += tabbedView1_QueryControl;
        }


        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if (e.Document == userControl_UsingDetailReportBandDocument) {
                e.Control = new dxSample.UserControl_UsingDetailReportBand();
            }
            if (e.Document == userControl_SubreportsDocument) {
                e.Control = new dxSample.UserControl_Subreports();
            }
            if (e.Control == null) {
                e.Control = new System.Windows.Forms.Control();
            }
        }
    }
}
