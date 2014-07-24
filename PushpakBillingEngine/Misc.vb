Imports System.IO
Imports System.Data.SQLite
Public Class Misc
    Dim conSqlite As New SQLiteConnection(SqliteDetails)
    Dim ds As New DataSet
    Dim TagDetails As String = ""
    Dim x As Integer = 5
    Dim slno As Integer = 1
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
                    Me.Close()
                End If
            Else
                MsgBox("Financial Year not set. Please set Financial year before proceeding.")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conSqlite.Close()
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cmbBranch.SelectedIndex = -1 Then
            MsgBox("please select a branch")
            cmbBranch.Focus()
        ElseIf txtTo.Text = Nothing Then
            MsgBox("Please enter details of the customer")
            txtTo.Focus()
            'ElseIf cmbDAO.SelectedIndex = -1 Then
            '    MsgBox("Please select DAO")
            '    cmbDAO.Focus()
            'ElseIf cmbBlock.SelectedIndex = -1 Then
            '    MsgBox("Please select Block")
            '    cmbBlock.Focus()
            'ElseIf txtChallanNo.Text = Nothing Then
            '   MsgBox("Please enter challan no.")
            '  txtChallanNo.Focus()
        ElseIf txtInvNo.Text = Nothing Then
            MsgBox("Please enter invoice no.")
            txtInvNo.Focus()
        ElseIf DataGridView1.Rows.Count <= 0 Then
            MsgBox("Please add items.")
            txtPerticular.Focus()
        ElseIf txtNetAmount.Text = Nothing Then
            MsgBox("Please enter Net amount.")
            txtNetAmount.Focus()
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
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim L As Integer = 0
        x = CInt(txtSld.Text) + 5
        e.Graphics.DrawString(txtTo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 205 + x)
        e.Graphics.DrawString(TextBox1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 230 + x)
        e.Graphics.DrawString(TextBox2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 255 + x)
        'e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + TextBox3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 280 + x)
        If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
            e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
        End If

        'e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 200 + x)
        'e.Graphics.DrawString(TextBox4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 235 + x)
        e.Graphics.DrawString(lblTag.Text + txtInvNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 275 + x)
        e.Graphics.DrawString(TextBox5.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 320 + x)
        e.Graphics.DrawString(lblTotal.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 750 + x)
        e.Graphics.DrawString(txtVat.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 790 + x)
        e.Graphics.DrawString("VAT @" + txtVatPercent.Text + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 520, 790 + x)
        e.Graphics.DrawString(txtNetAmount.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 850 + x)
        i = 0
        j = 850
        k = 0
        L = 0
        If TextBox6.Text.Length < 48 Then
            e.Graphics.DrawString(TextBox6.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
        Else
            Dim bool As Boolean = True
            While bool = True
                i = TextBox6.Text.Substring(k, 48).LastIndexOf(" "c) + L
                e.Graphics.DrawString(TextBox6.Text.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                j = j + 25
                L = i
                k = i
                If TextBox6.Text.Length < k + 48 Then
                    bool = False
                Else
                    bool = True
                End If
            End While
            e.Graphics.DrawString(TextBox6.Text.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
        End If
        j = 385 + x
        For Each dr As DataGridViewRow In DataGridView1.Rows
            i = 0
            k = 0
            L = 0
            e.Graphics.DrawString(dr.Cells(0).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
            e.Graphics.DrawString(dr.Cells(3).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 520, j)
            e.Graphics.DrawString(dr.Cells(4).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, j)
            e.Graphics.DrawString(dr.Cells(2).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 440, j)
            If dr.Cells(1).Value.ToString.Length < 35 Then
                e.Graphics.DrawString(dr.Cells(1).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                j = j + 20
            Else
                Dim bool As Boolean = True
                While bool = True
                    i = dr.Cells(1).Value.Substring(k, 35).LastIndexOf(" "c) + L
                    e.Graphics.DrawString(dr.Cells(1).Value.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                    j = j + 20
                    L = i
                    k = i
                    If dr.Cells(1).Value.Length < k + 35 Then
                        bool = False
                    Else
                        bool = True
                    End If
                End While
                e.Graphics.DrawString(dr.Cells(1).Value.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                j += 20
            End If
        Next
    End Sub

    Private Sub btnDt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt1.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        'TextBox4.Text = strDate
        TextBox5.Text = strDate
    End Sub

    Private Sub btnDt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDt2.Click
        datetm.ShowDialog(ShowDialogTypes.ShowDialogSystemModal)
        TextBox5.Text = strDate
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim int As Integer = 0
        int = DataGridView1.SelectedCells(0).ColumnIndex
        If int = 5 Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
        Dim dc As Decimal = 0.0
        If DataGridView1.Rows.Count = 0 Then
            lblTotal.Text = "0.00"
            slno = 1
        Else
            slno = 1
            For Each dr As DataGridViewRow In DataGridView1.Rows
                dc = dc + CDec(dr.Cells(4).Value)
                dr.Cells(0).Value = slno
                slno += 1
            Next
            lblTotal.Text = CStr(dc)
        End If
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtPerticular.Text = Nothing Then
            MessageBox.Show("Please enter a particular name.", "Mayur Chemicals", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPerticular.Focus()
            ''ElseIf txtQuantity.Text = Nothing Then
            ''  MessageBox.Show("Please enter a Quantity.", "Mayur Chemicals", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''txtQuantity.Focus()
        ElseIf txtRate.Text = Nothing Then
            MessageBox.Show("Please enter a rate.", "Mayur Chemicals", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRate.Focus()
        ElseIf txtAmount.Text = Nothing Then
            MessageBox.Show("Please enter an amount.", "Mayur Chemicals", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmount.Focus()
        Else
            If txtUnit.Text.Trim = "" Then
                DataGridView1.Rows.Add(slno, txtPerticular.Text, txtQuantity.Text, txtRate.Text, txtAmount.Text, "Delete")
            Else
                DataGridView1.Rows.Add(slno, txtPerticular.Text, txtQuantity.Text + " " + txtUnit.Text.Trim, txtRate.Text, txtAmount.Text, "Delete")
            End If
            slno += 1
            Dim dc As Decimal = 0.0
            For Each dr As DataGridViewRow In DataGridView1.Rows
                dc = dc + CDec(dr.Cells(4).Value)
            Next
            lblTotal.Text = CStr(dc)
            txtPerticular.Clear()
            txtQuantity.Clear()
            txtAmount.Clear()
            txtRate.Clear()
            txtUnit.Clear()
            txtPerticular.Focus()
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
    Private Sub txtNetAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNetAmount.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
    Private Sub lblTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.TextChanged
        If lblTotal.Text <> "0.00" Then
            txtVat.Text = Math.Round(CDec(lblTotal.Text) * (CSng(txtVatPercent.Text) / 100), 2)
            txtNetAmount.Text = CDec(lblTotal.Text) + (CDec(lblTotal.Text) * (CSng(txtVatPercent.Text) / 100))
        Else
            txtNetAmount.Clear()
            txtVat.Clear()
            TextBox6.Clear()
        End If
    End Sub

    Private Sub txtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVat.TextChanged
        If txtVat.Text <> Nothing Then
            txtNetAmount.Text = CDec(lblTotal.Text) + (CDec(txtVat.Text))
            TextBox6.Text = AmtInWord(CDec(txtNetAmount.Text))
        Else
            If txtNetAmount.Text <> Nothing Then
                TextBox6.Text = AmtInWord(CDec(txtNetAmount.Text))
                txtNetAmount.Text = CDec(lblTotal.Text)
            End If
        End If

    End Sub

    Private Sub txtNetAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNetAmount.TextChanged
        If txtNetAmount.Text <> Nothing Then
            TextBox6.Text = AmtInWord(CDec(txtNetAmount.Text))
        Else
            TextBox6.Clear()
        End If
    End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged
        If (txtRate.Text = Nothing And txtQuantity.Text = Nothing) Or (txtRate.Text = Nothing And txtQuantity.Text <> Nothing) Then
            txtAmount.Clear()
        ElseIf txtRate.Text <> Nothing And txtQuantity.Text = Nothing Then
            txtAmount.Text = txtRate.Text
        Else
            txtAmount.Text = CStr(CDec(txtQuantity.Text) * CDec(txtRate.Text))
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        If (txtRate.Text = Nothing And txtQuantity.Text = Nothing) Or (txtRate.Text = Nothing And txtQuantity.Text <> Nothing) Then
            txtAmount.Clear()
        ElseIf txtRate.Text <> Nothing And txtQuantity.Text = Nothing Then
            txtAmount.Text = txtRate.Text
        Else
            txtAmount.Text = CStr(CDec(txtQuantity.Text) * CDec(txtRate.Text))
        End If
    End Sub

    Private Sub txtWords_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = NoKey(Asc(e.KeyChar))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTag()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmbBranch.SelectedIndex = -1
        txtPerticular.Clear()
        txtQuantity.Clear()
        txtAmount.Clear()
        txtRate.Clear()
        txtTo.Clear()
        'txtChallanNo.Clear()
        txtInvNo.Clear()
        txtNetAmount.Clear()
        txtVat.Clear()
        lblTotal.Text = "0.00"
        TextBox1.Clear()
        TextBox2.Clear()
        'TextBox3.Clear()
        'TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        txtNetAmount.Clear()
        DataGridView1.Rows.Clear()
        txtTo.Focus()
    End Sub

    Private Sub txtVatPercentage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVatPercent.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtVatPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVatPercent.TextChanged
        If txtVatPercent.Text = "" Then
            txtVat.Clear()
            txtNetAmount.Text = lblTotal.Text
        Else
            txtVat.Text = CSng(lblTotal.Text) * CStr(txtVatPercent.Text) / 100
            txtNetAmount.Text = CSng(txtVat.Text) + CSng(lblTotal.Text)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim L As Integer = 0
        x = CInt(txtSld.Text) + 5
        e.Graphics.DrawString(txtTo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 65, 205 + x)
        e.Graphics.DrawString(TextBox1.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 230 + x)
        e.Graphics.DrawString(TextBox2.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 255 + x)
        'e.Graphics.DrawString("Block-" + cmbBlock.SelectedItem.ToString + ",Dist-" + TextBox3.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 60, 280 + x)
        If cmbBranch.SelectedIndex <> 2 And cmbBranch.SelectedIndex <> -1 Then
            e.Graphics.DrawString(cmbBranch.Text, New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 570, 70 + x)
        End If

        'e.Graphics.DrawString(lblCTag.Text + txtChallanNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 200 + x)
        'e.Graphics.DrawString(TextBox4.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 235 + x)
        e.Graphics.DrawString(lblTag.Text + txtInvNo.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 275 + x)
        e.Graphics.DrawString(TextBox5.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 320 + x)
        e.Graphics.DrawString(lblTotal.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 750 + x)
        e.Graphics.DrawString(txtVat.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 790 + x)
        e.Graphics.DrawString("VAT @" + txtVatPercent.Text + "%", New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 520, 790 + x)
        e.Graphics.DrawString(txtNetAmount.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, 850 + x)
        i = 0
        j = 850
        k = 0
        L = 0
        If TextBox6.Text.Length < 48 Then
            e.Graphics.DrawString(TextBox6.Text, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, 850 + x)
        Else
            Dim bool As Boolean = True
            While bool = True
                i = TextBox6.Text.Substring(k, 48).LastIndexOf(" "c) + L
                e.Graphics.DrawString(TextBox6.Text.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
                j = j + 25
                L = i
                k = i
                If TextBox6.Text.Length < k + 48 Then
                    bool = False
                Else
                    bool = True
                End If
            End While
            e.Graphics.DrawString(TextBox6.Text.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j + x)
        End If
        j = 385 + x
        For Each dr As DataGridViewRow In DataGridView1.Rows
            i = 0
            k = 0
            L = 0
            e.Graphics.DrawString(dr.Cells(0).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 50, j)
            e.Graphics.DrawString(dr.Cells(3).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 520, j)
            e.Graphics.DrawString(dr.Cells(4).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 650, j)
            e.Graphics.DrawString(dr.Cells(2).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 440, j)
            If dr.Cells(1).Value.ToString.Length < 35 Then
                e.Graphics.DrawString(dr.Cells(1).Value, New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                j = j + 20
            Else
                Dim bool As Boolean = True
                While bool = True
                    i = dr.Cells(1).Value.Substring(k, 35).LastIndexOf(" "c) + L
                    e.Graphics.DrawString(dr.Cells(1).Value.Substring(k, i - k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                    j = j + 20
                    L = i
                    k = i
                    If dr.Cells(1).Value.Length < k + 35 Then
                        bool = False
                    Else
                        bool = True
                    End If
                End While
                e.Graphics.DrawString(dr.Cells(1).Value.Substring(k).Trim(" "c), New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 100, j)
                j += 20
            End If
        Next
    End Sub

    Private Sub sld_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sld.ValueChanged
        txtSld.Text = sld.Value
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        txtInvNo.Text = ""
        txtInvNo.Width = 180
        txtInvNo.Location = New Point(718, 73)
        'txtChallanNo.Text = ""
        'txtChallanNo.Width = 180
        'TextBox3.Clear()
        'cmbDAO.Items.Clear()
        'cmbBlock.Items.Clear()
        'txtChallanNo.Location = New Point(417, 73)
        If cmbBranch.SelectedIndex = -1 Then
            txtInvNo.Enabled = False
            'txtChallanNo.Enabled = False
        Else
            If cmbBranch.SelectedIndex = 0 Then
                lblTag.Text = "BPD/"
                lblCTag.Text = "B-"
                TextBox3.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Betnoti")
                cmbDAO.Items.Add("Bangiriposhi")
                cmbDAO.Items.Add("Baripada")
                cmbDAO.Items.Add("Udala")
            ElseIf cmbBranch.SelectedIndex = 1 Then
                lblTag.Text = "KJR/"
                lblCTag.Text = "K-"
                TextBox3.Text = "Keonjhar"
                cmbDAO.Items.Add("KEONJHAR")
                cmbDAO.Items.Add("GHATGAON")
                cmbDAO.Items.Add("ANANDAPUR")
                cmbDAO.Items.Add("CHAMPUA")
            Else
                lblTag.Text = "RRP/"
                lblCTag.Text = "R-"
                TextBox3.Text = "Mayurbhanj"
                cmbDAO.Items.Add("Bahalda")
                cmbDAO.Items.Add("Jashipur")
                cmbDAO.Items.Add("Karanjia")
                cmbDAO.Items.Add("Rairangpur")
            End If
            lblTag.Text = lblTag.Text + TagDetails + "/"
            txtInvNo.Width = 93
            txtInvNo.Left = lblTag.Right + 4
            txtInvNo.Enabled = True
            'txtChallanNo.Width = 153
            'txtChallanNo.Left = lblCTag.Right + 4
            'txtChallanNo.Enabled = True
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
End Class
