using DevExpress.XtraTreeMap;
using System;
using System.Windows.Forms;

namespace HighlightingAndSelection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            chkEnableHighlighting.Checked = treeMap.EnableHighlighting;

            lbSelectionMode.DataSource = Enum.GetValues(typeof(ElementSelectionMode));
            lbSelectionMode.SelectedValue = treeMap.SelectionMode;
        }

        private void chkEnableHighlighting_CheckedChanged(object sender, EventArgs e) {
            treeMap.EnableHighlighting = chkEnableHighlighting.Checked;
        }

        private void lbSelectionMode_SelectedIndexChanged(object sender, EventArgs e) {
            treeMap.SelectionMode = (ElementSelectionMode)lbSelectionMode.SelectedValue;
        }
    }
}
