Imports System.Data.SqlClient
Imports System.Data.SQLite
Public Class MainPage
    Dim con As New SqlConnection(ServerDetails)
    Dim conSqlite As New SQLiteConnection(SqliteDetails)
    Dim cmdSqlite As New SQLiteCommand()
    Dim ds As New DataSet
    Dim Result As String = ""

    Private Sub OpenChallan()
        Dim ChldForm As New Challan
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkChallan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChallan.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        pnlCenter.Visible = False
        pnlBase.Visible = False
        pnlSlide.Visible = False
        OpenChallan()
    End Sub
    Private Sub CloseMain()
        Me.ExpandablePanel1.Enabled = True
        pnlCenter.Visible = True
        pnlBase.Visible = True
        pnlSlide.Visible = True
    End Sub
    Private Sub OpenInvoice()
        Dim ChldForm As New Invoice
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkInvoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkInvoice.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        pnlCenter.Visible = False
        pnlBase.Visible = False
        'pnlSlide.Visible = False
        OpenInvoice()
    End Sub
    Private Sub OpenMiscInvoice()
        Dim ChldForm As New Misc
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkMisc_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMisc.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        pnlCenter.Visible = False
        pnlBase.Visible = False
        pnlSlide.Visible = False
        OpenMiscInvoice()
    End Sub
    Private Sub EnableDisable(ByVal Bool As Boolean)
        ExpandablePanel1.Enabled = Bool
        pnlImage.Visible = Not Bool
    End Sub

    Private Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            con.Open()
            ds.Tables.Clear()
            Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from PUSChallanDetails Where LTRIM(RTRIM(ISnull(ChallanData,''))) != ''", con)
            Dim da1 As SqlDataAdapter = New SqlDataAdapter("Select * from PUSInvoiceDetails Where LTRIM(RTRIM(ISnull(InvoiceData,''))) != ''", con)
            Dim da4 As SqlDataAdapter = New SqlDataAdapter("Select * from PUSTaxDetails Where LTRIM(RTRIM(ISnull(TaxData,''))) != ''", con)
            Dim da2 As SqlDataAdapter = New SqlDataAdapter("Select * from PUSFY", con)
            Dim da3 As SqlDataAdapter = New SqlDataAdapter("Select * from PUSItem", con)
            da.Fill(ds, "Challan")
            da1.Fill(ds, "Invoice")
            da2.Fill(ds, "FY")
            da3.Fill(ds, "PRODUCTS")
            da4.Fill(ds, "Tax")
            Result = "True"
        Catch ex As Exception
            ds.Tables.Clear()
            Result = ex.Message
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        EnableDisable(True)
        If Result = "True" Then
            Try
                conSqlite.Open()
                cmdSqlite.Connection = conSqlite
                cmdSqlite.CommandText = "CREATE TABLE IF NOT EXISTS INVOICE(ID INTEGER,InvoiceDetail TEXT);"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "CREATE TABLE IF NOT EXISTS CHALLAN(ID INTEGER,ChallanDetail TEXT);"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "CREATE TABLE IF NOT EXISTS TAX(ID INTEGER,TaxDetail TEXT);"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "CREATE TABLE IF NOT EXISTS FY(FY TEXT);"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "CREATE TABLE IF NOT EXISTS PRODUCT(ID INTEGER,ItemName TEXT,ItemType TEXT,IsPump TEXT);"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "DELETE FROM INVOICE;"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "DELETE FROM CHALLAN;"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "DELETE FROM TAX;"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "DELETE FROM FY;"
                cmdSqlite.ExecuteNonQuery()
                cmdSqlite.CommandText = "DELETE FROM PRODUCT;"
                cmdSqlite.ExecuteNonQuery()
                For Each dr As DataRow In ds.Tables("Challan").Rows
                    cmdSqlite.CommandText = "INSERT INTO CHALLAN(ID, ChallanDetail) VALUES ('" + dr.Item("ChallanID").ToString + "','" + dr.Item("ChallanData").ToString + "');"
                    cmdSqlite.ExecuteNonQuery()
                Next
                For Each dr As DataRow In ds.Tables("Invoice").Rows
                    cmdSqlite.CommandText = "INSERT INTO INVOICE(ID, InvoiceDetail) VALUES ('" + dr.Item("InvoiceID").ToString + "','" + dr.Item("InvoiceData").ToString + "');"
                    cmdSqlite.ExecuteNonQuery()
                Next
                For Each dr As DataRow In ds.Tables("Tax").Rows
                    cmdSqlite.CommandText = "INSERT INTO TAX(ID, TAXDetail) VALUES ('" + dr.Item("TAXID").ToString + "','" + dr.Item("TAXData").ToString + "');"
                    cmdSqlite.ExecuteNonQuery()
                Next
                cmdSqlite.CommandText = "INSERT INTO FY VALUES ('" + ds.Tables("FY").Rows(0).Item(0).ToString + "');"
                cmdSqlite.ExecuteNonQuery()
                For Each dr As DataRow In ds.Tables("PRODUCTS").Rows
                    cmdSqlite.CommandText = "INSERT INTO PRODUCT(ID,ItemName,ItemType,IsPump) VALUES ('" + dr.Item("ID").ToString + "','" + dr.Item("ItemName").ToString + "','" + dr.Item("ItemType").ToString + "','" + dr.Item("IsPump").ToString + "');"
                    cmdSqlite.ExecuteNonQuery()
                Next
                MsgBox("Bill Pricing updated successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conSqlite.Close()
            End Try
        Else
            MsgBox(Result)
        End If
    End Sub

    Private Sub ExpandablePanel1_Click(sender As System.Object, e As System.EventArgs) Handles ExpandablePanel1.Click

    End Sub

    Private Sub MainPage_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
       
    End Sub

    Private Sub MainPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles bnRefresh.Click
        If CheckInternetConnection() = True Then
            EnableDisable(False)
            bgWorker.RunWorkerAsync()
        Else
            InterNetError()
        End If
    End Sub

    Private Sub pnlBase_Resize(sender As Object, e As System.EventArgs) Handles pnlBase.Resize
        pnlImage.Left = pnlBase.Width / 2 - pnlImage.Width / 2
        pnlCenter.Left = pnlBase.Width / 2 - pnlCenter.Width / 2
        pnlSlide.Left = pnlBase.Width / 2 - pnlSlide.Width / 2
        pnlSlide.Top = Height - 200
    End Sub
    Private Sub OpenTax()
        Dim ChldForm As New Tax
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkTax_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTax.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        pnlCenter.Visible = False
        pnlBase.Visible = False
        pnlSlide.Visible = False
        OpenTax()
    End Sub
End Class