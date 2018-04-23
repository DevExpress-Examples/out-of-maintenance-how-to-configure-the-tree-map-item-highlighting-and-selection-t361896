Imports DevExpress.XtraTreeMap
Imports System
Imports System.Windows.Forms

Namespace HighlightingAndSelection
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            chkEnableHighlighting.Checked = treeMap.EnableHighlighting

            lbSelectionMode.DataSource = System.Enum.GetValues(GetType(ElementSelectionMode))
            lbSelectionMode.SelectedValue = treeMap.SelectionMode
        End Sub

        Private Sub chkEnableHighlighting_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEnableHighlighting.CheckedChanged
            treeMap.EnableHighlighting = chkEnableHighlighting.Checked
        End Sub

        Private Sub lbSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbSelectionMode.SelectedIndexChanged
            treeMap.SelectionMode = CType(lbSelectionMode.SelectedValue, ElementSelectionMode)
        End Sub
    End Class
End Namespace
