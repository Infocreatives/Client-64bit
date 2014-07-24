Imports DevComponents.DotNetBar
Imports System.Data.SQLite
Imports System.IO
Public Class Challan
#Region "Declaration"
    Dim x As Integer = 0
    Dim conSqlite As New SQLiteConnection(SqliteDetails)
    Dim ds As New DataSet
#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cmbSelectProduct.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select a product", "Admin")
            cmbSelectProduct.Focus()
        ElseIf cmbBranch.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select a branch")
            cmbBranch.Focus()
        ElseIf cmbLessPaidBy.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select less paid by party or bank")
            cmbLessPaidBy.Focus()
        ElseIf cmbDAO.SelectedIndex = -1 Then
            MsgBox("Please select DAO")
            cmbDAO.Focus()
        ElseIf cmbBlock.SelectedIndex = -1 Then
            MsgBox("Please select Block")
            cmbBlock.Focus()
        ElseIf txtChallanNo.Text = Nothing Then
            MessageBoxEx.Show("Please enter challan no.")
            txtChallanNo.Focus()
        ElseIf txtChallanDate.Text = Nothing Then
            MessageBoxEx.Show("Please enter challan date.")
            btnDt1.Focus()
        ElseIf txtEno.Text = Nothing Then
            MessageBoxEx.Show("Please enter engine no.")
            txtEno.Focus()
        ElseIf txtCno.Text = Nothing And cmbSelectProduct.SelectedIndex <> 5 Then
            If cmbSelectProduct.SelectedIndex = 6 Or cmbSelectProduct.SelectedIndex = 7 Then
                MessageBoxEx.Show("Please enter pump no.")
                txtCno.Focus()
            Else
                MessageBoxEx.Show("Please enter chachis no.")
                txtCno.Focus()
            End If
            If txtPaymentDetails.Text = Nothing Then
                MessageBoxEx.Show("Please enter payment details")
                txtPaymentDetails.Focus()
            ElseIf cmbBranch.SelectedIndex = -1 Then
                MessageBoxEx.Show("Please select a branch")
                cmbBranch.Focus()
            End If
        ElseIf txtPaymentDetails.Text = Nothing Then
            MessageBoxEx.Show("Please enter payment details")
            txtPaymentDetails.Focus()
        Else
            PrintDocument1.Print()
            PrintDocument2.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
            If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Challan") Then
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Challan")
            End If
            PrintDocument2.PrinterSettings.PrintToFile = True
            PrintDocument2.PrinterSettings.PrintFileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Challan\" + txtOrderNo.Text + ".xps"
            PrintDocument2.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        x = CInt(txtSld.Text)
        Dim arrC() As String
        Dim strAll As String = ""
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from CHALLAN where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "ItemSelected")
            If ds.Tables.Count > 0 Then
                If ds.Tables("ItemSelected").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                        strAll = dr.Item("ChallanDetail").ToString
                        strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                        strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                        arrC = strAll.Split("|"c)
                        If arrC.Length = 10 Then
                            If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
                                e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
                            End If
                            e.Graphics.DrawString(txtLine1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 200 + x)
                            e.Graphics.DrawString(txtLine2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 220 + x)
                            e.Graphics.DrawString(txtLine3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 240 + x)
                            e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + txtLine4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 260 + x)

                            e.Graphics.DrawString(txtOrderNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 140, 305 + x)
                            e.Graphics.DrawString(txtOrderDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 540, 305 + x)

                            e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 195 + x)
                            e.Graphics.DrawString(txtChallanDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 240 + x)

                            e.Graphics.DrawString(arrC(5), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 695 + x)
                            e.Graphics.DrawString(arrC(7), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 740 + x)
                            e.Graphics.DrawString("VAT @" + arrC(6) + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 530, 740 + x)
                            e.Graphics.DrawString(arrC(8), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 830 + x)
                            e.Graphics.DrawString("Free", New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 780 + x)

                            Dim i As Integer = 0
                            Dim j As Integer = 825
                            Dim k As Integer = 0
                            Dim L As Integer = 0

                            Dim strWrd As String = arrC(9)
                            If strWrd.Length < 55 Then
                                e.Graphics.DrawString(strWrd, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = strWrd.Substring(k, 55).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(strWrd.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                                    j = j + 23
                                    L = i
                                    k = i
                                    If strWrd.Length < k + 55 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(strWrd.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                            End If

                            ''''''''''''''''''''''''''''''''''''''''''''''''
                            Dim arrSlno() As String
                            arrSlno = arrC(0).Split("$")
                            Dim int As Integer = 0
                            For index = 0 To arrSlno.Length - 2
                                Dim arrSing() As String = arrSlno(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrPerticular() As String
                            arrPerticular = arrC(1).Split("$")
                            For index = 0 To arrPerticular.Length - 2
                                Dim arrSing() As String = arrPerticular(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrQuantity() As String
                            arrQuantity = arrC(2).Split("$")
                            For index = 0 To arrQuantity.Length - 2
                                Dim arrSing() As String = arrQuantity(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrRate() As String
                            arrRate = arrC(3).Split("$")
                            For index = 0 To arrRate.Length - 2
                                Dim arrSing() As String = arrRate(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrAmount() As String
                            arrAmount = arrC(4).Split("$")
                            For index = 0 To arrAmount.Length - 2
                                Dim arrSing() As String = arrAmount(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            ''''''''''''''''''''''''''''''''''''''''''''''''
                            i = 0
                            k = 0
                            L = 0
                            j = 895 + x
                            If txtPaymentDetails.Text.ToString.Length < 60 Then
                                e.Graphics.DrawString(txtPaymentDetails.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                j = j + 20
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = txtPaymentDetails.Text.Substring(k, 60).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(txtPaymentDetails.Text.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                    j = j + 20
                                    L = i
                                    k = i
                                    If txtPaymentDetails.Text.Length < k + 60 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(txtPaymentDetails.Text.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                j += 20
                            End If
                        Else
                            MsgBox("Master setup not done for the selected product")
                            cmbSelectProduct.SelectedIndex = -1
                            e.Cancel = True
                        End If
                        arrC = strAll.Split("|"c)
                        If arrC.Length = 10 Then

                        Else
                            MsgBox("Please press refresh link")
                            cmbSelectProduct.SelectedIndex = -1
                            pnlDetails.Visible = False
                        End If
                    Next
                Else
                    MsgBox("Product Data not available. Please press refresh link.")
                    cmbSelectProduct.SelectedIndex = -1
                End If
            Else
                MsgBox("Product Data not available. Please press refresh link.")
                cmbSelectProduct.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conSqlite.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt1.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        txtChallanDate.Text = strDate
    End Sub

    Private Sub btnDt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt2.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        txtOrderDate.Text = strDate
    End Sub

    Private Sub Challan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbLessPaidBy.SelectedIndex = 0
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from PRODUCT where ItemType='2'", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "Product")
            If ds.Tables.Count > 0 Then
                If ds.Tables("Product").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("Product").Rows
                        cmbSelectProduct.Items.Add(New TextAndValueInComboExtension(dr.Item("ID").ToString, dr.Item("ItemName").ToString, dr.Item("IsPump").ToString))
                    Next
                Else
                    MsgBox("Product Data not available. Please press refresh link.")
                End If
            Else
                MsgBox("Product Data not available. Please press refresh link.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conSqlite.Close()
        End Try
    End Sub

    Private Sub ClearAll()
        cmbBranch.SelectedIndex = -1
        cmbSelectProduct.SelectedIndex = -1
        txtChallanNo.Clear()
        txtCno.Clear()
        txtEno.Clear()
        txtOrderNo.Clear()
        txtPaymentDetails.Clear()
        txtLine1.Clear()
        txtLine2.Clear()
        txtLine3.Clear()
        txtLine4.Clear()
        txtChallanDate.Clear()
        txtOrderDate.Clear()
        cmbSelectProduct.Focus()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        x = CInt(txtSld.Text)
        Dim arrC() As String
        Dim strAll As String = ""

        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from CHALLAN where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "ItemSelected")
            If ds.Tables.Count > 0 Then
                If ds.Tables("ItemSelected").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                        strAll = dr.Item("ChallanDetail").ToString
                        strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                        strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                        arrC = strAll.Split("|"c)
                        If arrC.Length = 10 Then
                            If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
                                e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
                            End If
                            e.Graphics.DrawString(txtLine1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 200 + x)
                            e.Graphics.DrawString(txtLine2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 220 + x)
                            e.Graphics.DrawString(txtLine3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 240 + x)
                            e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + txtLine4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 260 + x)

                            e.Graphics.DrawString(txtOrderNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 140, 305 + x)
                            e.Graphics.DrawString(txtOrderDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 540, 305 + x)

                            e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 195 + x)
                            e.Graphics.DrawString(txtChallanDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 240 + x)

                            e.Graphics.DrawString(arrC(5), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 695 + x)
                            e.Graphics.DrawString(arrC(7), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 740 + x)
                            e.Graphics.DrawString("VAT @" + arrC(6) + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 530, 740 + x)
                            e.Graphics.DrawString(arrC(8), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 830 + x)
                            e.Graphics.DrawString("Free", New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 780 + x)

                            Dim i As Integer = 0
                            Dim j As Integer = 825
                            Dim k As Integer = 0
                            Dim L As Integer = 0

                            Dim strWrd As String = arrC(9)
                            If strWrd.Length < 55 Then
                                e.Graphics.DrawString(strWrd, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = strWrd.Substring(k, 55).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(strWrd.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                                    j = j + 23
                                    L = i
                                    k = i
                                    If strWrd.Length < k + 55 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(strWrd.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                            End If

                            ''''''''''''''''''''''''''''''''''''''''''''''''
                            Dim arrSlno() As String
                            arrSlno = arrC(0).Split("$")
                            Dim int As Integer = 0
                            For index = 0 To arrSlno.Length - 2
                                Dim arrSing() As String = arrSlno(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrPerticular() As String
                            arrPerticular = arrC(1).Split("$")
                            For index = 0 To arrPerticular.Length - 2
                                Dim arrSing() As String = arrPerticular(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrQuantity() As String
                            arrQuantity = arrC(2).Split("$")
                            For index = 0 To arrQuantity.Length - 2
                                Dim arrSing() As String = arrQuantity(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrRate() As String
                            arrRate = arrC(3).Split("$")
                            For index = 0 To arrRate.Length - 2
                                Dim arrSing() As String = arrRate(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrAmount() As String
                            arrAmount = arrC(4).Split("$")
                            For index = 0 To arrAmount.Length - 2
                                Dim arrSing() As String = arrAmount(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            ''''''''''''''''''''''''''''''''''''''''''''''''
                            i = 0
                            k = 0
                            L = 0
                            j = 895 + x
                            If txtPaymentDetails.Text.ToString.Length < 60 Then
                                e.Graphics.DrawString(txtPaymentDetails.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                j = j + 20
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = txtPaymentDetails.Text.Substring(k, 60).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(txtPaymentDetails.Text.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                    j = j + 20
                                    L = i
                                    k = i
                                    If txtPaymentDetails.Text.Length < k + 60 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(txtPaymentDetails.Text.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, j)
                                j += 20
                            End If
                        Else
                            MsgBox("Master setup not done for the selected product")
                            cmbSelectProduct.SelectedIndex = -1
                            e.Cancel = True
                        End If
                        arrC = strAll.Split("|"c)
                        If arrC.Length = 10 Then

                        Else
                            MsgBox("Please press refresh link")
                            cmbSelectProduct.SelectedIndex = -1
                            pnlDetails.Visible = False
                        End If
                    Next
                Else
                    MsgBox("Product Data not available. Please press refresh link.")
                    cmbSelectProduct.SelectedIndex = -1
                End If
            Else
                MsgBox("Product Data not available. Please press refresh link.")
                cmbSelectProduct.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conSqlite.Close()
        End Try
    End Sub

    Private Sub sld_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sld.ValueChanged
        txtSld.Text = sld.Value
    End Sub

    Private Sub cmbSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectProduct.SelectedIndexChanged
        txtCno.Clear()
        If cmbSelectProduct.SelectedIndex = -1 Then
            pnlDetails.Visible = False
        Else
            Dim arrC() As String
            Dim strAll As String = ""
            Try
                conSqlite.Open()
                Dim daSqlite As New SQLiteDataAdapter("Select * from CHALLAN where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
                ds.Tables.Clear()
                daSqlite.Fill(ds, "ItemSelected")
                If ds.Tables.Count > 0 Then
                    If ds.Tables("ItemSelected").Rows.Count > 0 Then
                        For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                            strAll = dr.Item("ChallanDetail").ToString
                            strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                            strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                            arrC = strAll.Split("|"c)
                            If arrC.Length = 10 Then
                                lblAmount.Text = arrC(5)
                                lblVat.Text = arrC(7)
                                lblTotal.Text = arrC(8)
                                pnlDetails.Visible = True
                                If cmbSelectProduct.SelectedItem.Item.ToString = "True" Then
                                    Label9.Text = "Pump No. :"
                                Else
                                    Label9.Text = "Chassis No. :"
                                End If
                            Else
                                MsgBox("Please press refresh link")
                                cmbSelectProduct.SelectedIndex = -1
                                pnlDetails.Visible = False
                            End If
                        Next
                    Else
                        MsgBox("Product Data not available. Please press refresh link.")
                        cmbSelectProduct.SelectedIndex = -1
                    End If
                Else
                    MsgBox("Product Data not available. Please press refresh link.")
                    cmbSelectProduct.SelectedIndex = -1
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conSqlite.Close()
            End Try
        End If
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        txtChallanNo.Text = ""
        txtChallanNo.Width = 223
        txtChallanNo.Location = New Point(485, 140)
        txtLine4.Clear()
        cmbDAO.Items.Clear()
        cmbBlock.Items.Clear()
        If cmbBranch.SelectedIndex = -1 Then
            txtChallanNo.Enabled = False
        Else
            If cmbBranch.SelectedIndex = 0 Then
                lblCTag.Text = "B-"
                txtLine4.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Betnoti")
                cmbDAO.Items.Add("Bangiriposhi")
                cmbDAO.Items.Add("Baripada")
                cmbDAO.Items.Add("Udala")
            ElseIf cmbBranch.SelectedIndex = 1 Then
                lblCTag.Text = "K-"
                txtLine4.Text = "Keonjhar"
                cmbDAO.Items.Add("KEONJHAR")
                cmbDAO.Items.Add("GHATGAON")
                cmbDAO.Items.Add("ANANDAPUR")
                cmbDAO.Items.Add("CHAMPUA")
            Else
                lblCTag.Text = "R-"
                txtLine4.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Bahalda")
                cmbDAO.Items.Add("Jashipur")
                cmbDAO.Items.Add("Karanjia")
                cmbDAO.Items.Add("Rairangpur")
            End If
            txtChallanNo.Width = 203
            txtChallanNo.Left = lblCTag.Right + 4
            txtChallanNo.Enabled = True
        End If
    End Sub
    Private Sub cmbDAO_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDAO.SelectedIndexChanged
        cmbBlock.Items.Clear()
        If cmbDAO.SelectedIndex <> -1 Then
            If cmbDAO.SelectedItem.ToString = "Betnoti" Then
                cmbBlock.Items.Add("Betanati")
                cmbBlock.Items.Add("Badasahi")
                cmbBlock.Items.Add("Rasagobindapur")
                cmbBlock.Items.Add("Morada")
            ElseIf cmbDAO.SelectedItem.ToString = "Bangiriposhi" Then
                cmbBlock.Items.Add("Bangiriposhi")
                cmbBlock.Items.Add("Kuliana")
                cmbBlock.Items.Add("Saraskana")
            ElseIf cmbDAO.SelectedItem.ToString = "Baripada" Then
                cmbBlock.Items.Add("Baripada")
                cmbBlock.Items.Add("Samakhunta")
                cmbBlock.Items.Add("Suliapada")
            ElseIf cmbDAO.SelectedItem.ToString = "Udala" Then
                cmbBlock.Items.Add("Udala")
                cmbBlock.Items.Add("Kaptipada")
                cmbBlock.Items.Add("Khunta")
                cmbBlock.Items.Add("Gopabandhunagar")
            ElseIf cmbDAO.SelectedItem.ToString = "KEONJHAR" Then
                cmbBlock.Items.Add("Keonjhar")
                cmbBlock.Items.Add("Saharapada")
                cmbBlock.Items.Add("Telkoi")
            ElseIf cmbDAO.SelectedItem.ToString = "GHATGAON" Then
                cmbBlock.Items.Add("Ghatgaon")
                cmbBlock.Items.Add("Bansapal")
                cmbBlock.Items.Add("Patna")
                cmbBlock.Items.Add("Harichandanpur")
            ElseIf cmbDAO.SelectedItem.ToString = "ANANDAPUR" Then
                cmbBlock.Items.Add("Anandapur")
                cmbBlock.Items.Add("Ghasipura")
                cmbBlock.Items.Add("Hatadihi")
            ElseIf cmbDAO.SelectedItem.ToString = "CHAMPUA" Then
                cmbBlock.Items.Add("Champua")
                cmbBlock.Items.Add("Jhumpura")
                cmbBlock.Items.Add("Joda")
            ElseIf cmbDAO.SelectedItem.ToString = "Bahalda" Then
                cmbBlock.Items.Add("Bahalda")
                cmbBlock.Items.Add("Tiring")
                cmbBlock.Items.Add("Jamda")
            ElseIf cmbDAO.SelectedItem.ToString = "Jashipur" Then
                cmbBlock.Items.Add("Joshipur")
                cmbBlock.Items.Add("Raruan")
            ElseIf cmbDAO.SelectedItem.ToString = "Karanjia" Then
                cmbBlock.Items.Add("Karanjia")
                cmbBlock.Items.Add("Thakurmunda")
                cmbBlock.Items.Add("Sukruli")
            ElseIf cmbDAO.SelectedItem.ToString = "Rairangpur" Then
                cmbBlock.Items.Add("Rairangpur")
                cmbBlock.Items.Add("Bijatala")
                cmbBlock.Items.Add("Bisoi")
                cmbBlock.Items.Add("Kusumi")
            End If
        End If
    End Sub

    Private Sub cmbLessPaidBy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbLessPaidBy.SelectedIndexChanged
        txtLine1.Text = ""
        If cmbLessPaidBy.SelectedIndex = 1 Then
            txtLine1.Enabled = False
        Else
            txtLine1.Enabled = True
        End If
    End Sub
End Class
