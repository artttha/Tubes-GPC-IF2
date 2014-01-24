Option Strict On

Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure
Imports Emgu.CV.UI
Imports Emgu.CV.CvEnum

Public Class frmOCR
    ' variables

    Dim blnFirstTimeInResizeEvent As Boolean = True
    Dim intOrigFormWidth As Integer
    Dim intOrigFormHeight As Integer
    Dim intOrigTableLayoutPanelWidth As Integer
    Dim intOrigTableLayoutPanelHeight As Integer

    Dim imgImage As Image(Of Bgr, Byte) = Nothing
    Dim imgBlank As Image(Of Bgr, Byte) = Nothing

    Dim tess As Tesseract

    ' constructor
    Sub New()
        InitializeComponent() ' This call is required by the designer.
        intOrigFormWidth = Me.Width
        intOrigFormHeight = Me.Height
        intOrigTableLayoutPanelWidth = tblTextBoxAndImageBox.Width
        intOrigTableLayoutPanelHeight = tblTextBoxAndImageBox.Height

        Try
            tess = New Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_DEFAULT)
        Catch ex As Exception
            Me.Text = "Error saat inisialisasi object tesseract"
            txtOCR.Text = "Error saat inisialisasi object tesseract"
            txtFile.Enabled = False
            btnFile.Enabled = False
        End Try
    End Sub

    Private Sub frmOCR_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If (blnFirstTimeInResizeEvent = True) Then
            blnFirstTimeInResizeEvent = False
        Else
            tblTextBoxAndImageBox.Width = Me.Width - (intOrigFormWidth - intOrigTableLayoutPanelWidth)
            tblTextBoxAndImageBox.Height = Me.Height - (intOrigFormHeight - intOrigTableLayoutPanelHeight)
        End If
    End Sub

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim dialogResult As DialogResult = ofdFile.ShowDialog()
        If (dialogResult = Windows.Forms.DialogResult.OK Or dialogResult = Windows.Forms.DialogResult.Yes) Then
            txtFile.Text = ofdFile.FileName
        End If
    End Sub

    Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile.TextChanged
        txtFile.SelectionStart = txtFile.Text.Length
        If (txtFile.Text <> String.Empty) Then
            ProcessImageAndUpdateGUI()
        End If

    End Sub

    Sub ProcessImageAndUpdateGUI()
        Try
            imgImage = New Image(Of Bgr, Byte)(txtFile.Text)
        Catch ex As Exception
            Me.Text = "Error membuka file"
            Return
        End Try

        If (imgImage Is Nothing) Then
            Return
        End If

        Me.Text = "sedang proses . . . "
        ibImage.Image = imgBlank
        Application.DoEvents()

        tess.Recognize(imgImage)
        txtOCR.Text = tess.GetText()

        ibImage.Image = imgImage

        Me.Text = "selesai. . ."
    End Sub
End Class
