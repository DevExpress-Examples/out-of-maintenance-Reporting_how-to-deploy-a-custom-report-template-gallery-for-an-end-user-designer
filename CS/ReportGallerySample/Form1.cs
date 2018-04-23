using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace ReportGallerySample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btShowDesigner_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.ShowDesignerDialog();
        }
    }
}
