Imports DevComponents.DotNetBar
Imports System.Data.SQLite
Imports System.IO

Public Class Invoice
    Dim x As Integer = 0
    Dim conSqlite As New SQLiteConnection(SqliteDetails)
    Dim ds As New DataSet
    Dim TagDetails As String = ""

    Private Sub GetTag()
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from FY", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "FY")
            If ds.Tables.Count > 0 Then
                If ds.Tables("FY").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("FY").Rows
                        TagDetails = dr.Item("FY").ToString
                    Next
                Else
                    MsgBox("Financial Year not set. Please set Financial year before proceeding")
                End If
            Else
                MsgBox("Financial Year not set. Please set Financial year before proceeding.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conSqlite.Close()
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cmbSelectProduct.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select a product.", "Admin")
        ElseIf cmbBranch.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select branch.", "Admin")
            cmbBranch.Focus()
        ElseIf cmbLessPaidBy.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select Less paid by party or bank.", "Admin")
            cmbLessPaidBy.Focus()
        ElseIf cmbDAO.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select DAO")
            cmbDAO.Focus()
        ElseIf cmbBlock.SelectedIndex = -1 Then
            MessageBoxEx.Show("Please select Block")
            cmbBlock.Focus()
        ElseIf txtChallanNo.Text = Nothing Then
            MessageBoxEx.Show("Please enter challan no.", "Admin")
            txtChallanNo.Focus()
        ElseIf txtCDate.Text = Nothing Then
            MessageBoxEx.Show("Please enter challan date.", "Admin")
            txtCDate.Focus()
        ElseIf txtInvNo.Text = Nothing Then
            MessageBoxEx.Show("Please enter invoice no.", "Admin")
            txtInvNo.Focus()
        ElseIf txtIDate.Text = Nothing Then
            MessageBoxEx.Show("Please enter Invoice date.", "Admin")
            txtIDate.Focus()
        ElseIf txtEno.Text = Nothing Then
            MessageBoxEx.Show("Please enter engine no.", "Admin")
            txtEno.Focus()
        ElseIf txtCno.Text = Nothing And cmbSelectProduct.SelectedIndex <> 5 Then
            If cmbSelectProduct.SelectedIndex = 6 Or cmbSelectProduct.SelectedIndex = 7 Then
                MessageBoxEx.Show("Please enter pump no.")
                txtCno.Focus()
            Else
                MessageBoxEx.Show("Please enter chachis no.")
                txtCno.Focus()
            End If
            If cmbLessPaidBy.SelectedIndex = -1 Then
                MessageBoxEx.Show("Please select Less paid by party or bank.", "Admin")
                cmbLessPaidBy.Focus()
            ElseIf cmbBranch.SelectedIndex = -1 Then
                MessageBoxEx.Show("Please select branch.", "Admin")
                cmbBranch.Focus()
            End If
        Else
            PrintDocument1.Print()
            PrintDocument2.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
            If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Invoice") Then
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Invoice")
            End If
            PrintDocument2.PrinterSettings.PrintToFile = True
            PrintDocument2.PrinterSettings.PrintFileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Invoice\" + txtInvNo.Text + ".xps"
            PrintDocument2.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        x = CInt(txtSld.Text)
        Dim arrI() As String
        Dim strAll As String = ""
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from INVOICE where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "ItemSelected")
            If ds.Tables.Count > 0 Then
                If ds.Tables("ItemSelected").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                        strAll = dr.Item("InvoiceDetail").ToString
                        strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                        strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                        strAll = strAll.Replace("zzzzz", cmbLessPaidBy.SelectedItem.ToString)
                        arrI = strAll.Split("|"c)
                        If arrI.Length = 10 Then
                            If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
                                e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
                            End If
                            e.Graphics.DrawString("/CREDIT", New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 473, 40 + x)

                            e.Graphics.DrawString(txtLine1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 205 + x)
                            e.Graphics.DrawString(txtLine2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 230 + x)
                            e.Graphics.DrawString(txtLine3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 255 + x)
                            e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + txtLine4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 280 + x)

                            e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 200 + x)
                            e.Graphics.DrawString(txtCDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 235 + x)
                            e.Graphics.DrawString(lblTag.Text + txtInvNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 275 + x)
                            e.Graphics.DrawString(txtIDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 320 + x)
                            e.Graphics.DrawString(arrI(5), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 750 + x)
                            e.Graphics.DrawString(arrI(7), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 665, 790 + x)
                            e.Graphics.DrawString("VAT @" + arrI(6) + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 520, 790 + x)
                            e.Graphics.DrawString(arrI(8), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 850 + x)

                            Dim i As Integer = 0
                            Dim j As Integer = 850 + x
                            Dim k As Integer = 0
                            Dim L As Integer = 0

                            Dim strWrd As String = ""
                            strWrd = arrI(9)
                            If strWrd.Length < 48 Then
                                e.Graphics.DrawString(strWrd, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = strWrd.Substring(k, 48).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(strWrd.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
                                    j = j + 25
                                    L = i
                                    k = i
                                    If strWrd.Length < k + 48 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(strWrd.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
                            End If

                            '''''''''''''''''''''''''''''''''''''''''''''''
                            Dim arrSlno() As String
                            arrSlno = arrI(0).Split("$")
                            Dim int As Integer = 0
                            For index = 0 To arrSlno.Length - 2
                                Dim arrSing() As String = arrSlno(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrPerticular() As String
                            arrPerticular = arrI(1).Split("$")
                            For index = 0 To arrPerticular.Length - 2
                                Dim arrSing() As String = arrPerticular(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrQuantity() As String
                            arrQuantity = arrI(2).Split("$")
                            For index = 0 To arrQuantity.Length - 2
                                Dim arrSing() As String = arrQuantity(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrRate() As String
                            arrRate = arrI(3).Split("$")
                            For index = 0 To arrRate.Length - 2
                                Dim arrSing() As String = arrRate(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrAmount() As String
                            arrAmount = arrI(4).Split("$")
                            For index = 0 To arrAmount.Length - 2
                                Dim arrSing() As String = arrAmount(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            '''''''''''''''''''''''''''''''''''''''''''''''   
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

    Private Sub btnDt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt1.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        txtCDate.Text = strDate
        txtIDate.Text = strDate
    End Sub

    Private Sub btnDt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt2.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        txtIDate.Text = strDate
    End Sub

    Private Sub Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbLessPaidBy.SelectedIndex = 0
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from PRODUCT where ItemType='1'", conSqlite)
            Dim daSqliteTag As New SQLiteDataAdapter("Select * from FY", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "Product")
            daSqliteTag.Fill(ds, "FYTag")
            If ds.Tables.Count > 0 Then
                If ds.Tables("FYTag").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("FYTag").Rows
                        TagDetails = ds.Tables("FYTag").Rows(0).Item(0).ToString
                    Next
                Else
                    MsgBox("Financial year details not available. Please press refresh link.")
                    Exit Sub
                End If
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtLine1.Clear()
        txtLine2.Clear()
        txtLine3.Clear()
        txtLine4.Clear()
        txtCDate.Clear()
        txtIDate.Clear()
        cmbLessPaidBy.SelectedIndex = -1
        cmbBranch.SelectedIndex = -1
        txtChallanNo.Clear()
        txtCno.Clear()
        txtEno.Clear()
        txtInvNo.Clear()
        cmbSelectProduct.SelectedIndex = -1
        cmbSelectProduct.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub sld_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sld.ValueChanged
        txtSld.Text = sld.Value
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
      x = CInt(txtSld.Text)
        Dim arrI() As String
        Dim strAll As String = ""
        Try
            conSqlite.Open()
            Dim daSqlite As New SQLiteDataAdapter("Select * from INVOICE where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
            ds.Tables.Clear()
            daSqlite.Fill(ds, "ItemSelected")
            If ds.Tables.Count > 0 Then
                If ds.Tables("ItemSelected").Rows.Count > 0 Then
                    For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                        strAll = dr.Item("InvoiceDetail").ToString
                        strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                        strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                        strAll = strAll.Replace("zzzzz", cmbLessPaidBy.SelectedItem.ToString)
                        arrI = strAll.Split("|"c)
                        If arrI.Length = 10 Then
                            If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
                                e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
                            End If
                            e.Graphics.DrawString("/CREDIT", New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 473, 40 + x)

                            e.Graphics.DrawString(txtLine1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 205 + x)
                            e.Graphics.DrawString(txtLine2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 230 + x)
                            e.Graphics.DrawString(txtLine3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 255 + x)
                            e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + txtLine4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 280 + x)

                            e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 200 + x)
                            e.Graphics.DrawString(txtCDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 235 + x)
                            e.Graphics.DrawString(lblTag.Text + txtInvNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 275 + x)
                            e.Graphics.DrawString(txtIDate.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 320 + x)
                            e.Graphics.DrawString(arrI(5), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 750 + x)
                            e.Graphics.DrawString(arrI(7), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 665, 790 + x)
                            e.Graphics.DrawString("VAT @" + arrI(6) + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 520, 790 + x)
                            e.Graphics.DrawString(arrI(8), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 850 + x)

                            Dim i As Integer = 0
                            Dim j As Integer = 850 + x
                            Dim k As Integer = 0
                            Dim L As Integer = 0

                            Dim strWrd As String = ""
                            strWrd = arrI(9)
                            If strWrd.Length < 48 Then
                                e.Graphics.DrawString(strWrd, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
                            Else
                                Dim bool As Boolean = True
                                While bool = True
                                    i = strWrd.Substring(k, 48).LastIndexOf(" "c) + L
                                    e.Graphics.DrawString(strWrd.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
                                    j = j + 25
                                    L = i
                                    k = i
                                    If strWrd.Length < k + 48 Then
                                        bool = False
                                    Else
                                        bool = True
                                    End If
                                End While
                                e.Graphics.DrawString(strWrd.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
                            End If

                            '''''''''''''''''''''''''''''''''''''''''''''''
                            Dim arrSlno() As String
                            arrSlno = arrI(0).Split("$")
                            Dim int As Integer = 0
                            For index = 0 To arrSlno.Length - 2
                                Dim arrSing() As String = arrSlno(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrPerticular() As String
                            arrPerticular = arrI(1).Split("$")
                            For index = 0 To arrPerticular.Length - 2
                                Dim arrSing() As String = arrPerticular(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrQuantity() As String
                            arrQuantity = arrI(2).Split("$")
                            For index = 0 To arrQuantity.Length - 2
                                Dim arrSing() As String = arrQuantity(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrRate() As String
                            arrRate = arrI(3).Split("$")
                            For index = 0 To arrRate.Length - 2
                                Dim arrSing() As String = arrRate(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            Dim arrAmount() As String
                            arrAmount = arrI(4).Split("$")
                            For index = 0 To arrAmount.Length - 2
                                Dim arrSing() As String = arrAmount(index).Split("~")
                                e.Graphics.DrawString(arrSing(2), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, arrSing(0), arrSing(1))
                            Next
                            '''''''''''''''''''''''''''''''''''''''''''''''   
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

    Private Sub cmbSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectProduct.SelectedIndexChanged
        txtCno.Clear()
        cmbBranch.SelectedIndex = -1
        cmbBranch.Enabled = False
        If cmbSelectProduct.SelectedIndex = -1 Then
            pnlDetails.Visible = False
        Else
            cmbBranch.Enabled = True
            Dim arrC() As String
            Dim strAll As String = ""
            Try
                conSqlite.Open()
                Dim daSqlite As New SQLiteDataAdapter("Select * from INVOICE where ID='" + cmbSelectProduct.SelectedItem.ItemValue.ToString + "'", conSqlite)
                ds.Tables.Clear()
                daSqlite.Fill(ds, "ItemSelected")
                If ds.Tables.Count > 0 Then
                    If ds.Tables("ItemSelected").Rows.Count > 0 Then
                        For Each dr As DataRow In ds.Tables("ItemSelected").Rows
                            strAll = dr.Item("InvoiceDetail").ToString
                            strAll = strAll.Replace("xxxxxxxxxx", txtEno.Text)
                            strAll = strAll.Replace("yyyyyyyyyy", txtCno.Text)
                            arrC = strAll.Split("|"c)
                            If arrC.Length = 10 Then
                                lblAmount.Text = arrC(5)
                                lblVat.Text = arrC(7)
                                lblTotal.Text = arrC(8)
                                pnlDetails.Visible = True
                                If cmbSelectProduct.SelectedItem.Item.ToString = "True" Then
                                    Label18.Text = "Pump No. :"
                                Else
                                    Label18.Text = "Chassis No. :"
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
        txtInvNo.Text = ""
        txtInvNo.Width = 238
        txtInvNo.Location = New Point(498, 191)
        txtChallanNo.Text = ""
        txtChallanNo.Width = 238
        txtChallanNo.Location = New Point(498, 107)
        txtLine4.Clear()
        cmbDAO.Items.Clear()
        cmbBlock.Items.Clear()
        If cmbBranch.SelectedIndex = -1 Then
            txtInvNo.Enabled = False
            txtChallanNo.Enabled = False
        Else
            If cmbBranch.SelectedIndex = 0 Then
                If cmbSelectProduct.SelectedIndex > 8 Then
                    lblTag.Text = "TAX/"
                Else
                    lblTag.Text = "BPD/"
                End If
                lblCTag.Text = "B-"
                txtLine4.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Betnoti")
                cmbDAO.Items.Add("Bangiriposhi")
                cmbDAO.Items.Add("Baripada")
                cmbDAO.Items.Add("Udala")
            ElseIf cmbBranch.SelectedIndex = 1 Then
                If cmbSelectProduct.SelectedIndex > 8 Then
                    lblTag.Text = "TAX/"
                Else
                    lblTag.Text = "KJR/"
                End If
                lblCTag.Text = "K-"
                txtLine4.Text = "Keonjhar"
                cmbDAO.Items.Add("KEONJHAR")
                cmbDAO.Items.Add("GHATGAON")
                cmbDAO.Items.Add("ANANDAPUR")
                cmbDAO.Items.Add("CHAMPUA")
            Else
                If cmbSelectProduct.SelectedIndex > 8 Then
                    lblTag.Text = "TAX/"
                Else
                    lblTag.Text = "RRP/"
                End If
                lblCTag.Text = "R-"
                txtLine4.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Bahalda")
                cmbDAO.Items.Add("Jashipur")
                cmbDAO.Items.Add("Karanjia")
                cmbDAO.Items.Add("Rairangpur")
            End If
            lblTag.Text = lblTag.Text + TagDetails + "/"
            txtInvNo.Width = 157
            txtInvNo.Left = lblTag.Right + 4
            txtInvNo.Enabled = True
            txtChallanNo.Width = 214
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

    Private Sub txtInvNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInvNo.TextChanged

    End Sub

    Private Sub cmbLessPaidBy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbLessPaidBy.SelectedIndexChanged
        txtLine1.Text = ""
        If cmbLessPaidBy.SelectedIndex = 1 Then
            txtLine1.Enabled = False
        Else
            txtLine1.Enabled = True
        End If
    End Sub

    Private Sub txtIDate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIDate.TextChanged

    End Sub
End Class
