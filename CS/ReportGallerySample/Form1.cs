using System;
using System.Windows.Forms;
// ...

namespace ReportGallerySample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btShowDesigner_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.ShowDesignerDialog();
        }
    }
}
