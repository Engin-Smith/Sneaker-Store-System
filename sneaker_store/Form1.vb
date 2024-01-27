Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    'Dim con As SqlConnection
    'Dim cmd As SqlCommand
    'Dim rdr As SqlDataAdapter

    Private Sub btn_log_Click(sender As Object, e As EventArgs)

        If (txt_user.Text = "") Then
            MsgBox("Enter The Username")
            txt_user.Focus()
            Exit Sub
        End If
        If (txt_pass.Text = "") Then
            MsgBox("Enter The Password")
            txt_pass.Focus()
            Exit Sub
        End If
        'Try
        '    con = New SqlConnection("Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa") ' this's a connection string
        '    con.Open()
        '    cmd = New SqlCommand(" select * from tbl_login where username = '" & txt_user.Text & "' and password ='" & txt_pass.Text & "' ")
        '    cmd.Connection = con
        '    rdr = cmd.ExecuteReader()
        '    If (rdr.Read()) Then
        '        main.Show()
        '        Me.Hide()
        '    End If

        'Catch ex As Exception

        'End Try
        'Dim username As String = txt_user.Text
        'Dim password As String = txt_pass.Text

        '' Create a SqlConnection using the connection string
        'Using con As New SqlConnection(conn)
        '    con.Open()
        '    ' Create a SqlCommand to check the credentials
        '    Dim cmd As New SqlCommand("SELECT * FROM tbl_login WHERE username = @Username AND password = @Password", con)
        '    cmd.Parameters.AddWithValue("@Username", username)
        '    cmd.Parameters.AddWithValue("@Password", password)

        '    ' Execute the query and get the result
        '    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        '    ' Check if the credentials are valid
        '    If count > 0 Then
        '        'MessageBox.Show("Login successful!")
        '        MsgBox("success")
        '        ' Perform any additional actions you want to take after successful login
        '    Else
        '        MessageBox.Show("Invalid username or password.")
        '    End If
        'End Using
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tbl_login WHERE username='" + txt_user.Text + "' AND password='" + txt_pass.Text + "'", con)
        Dim sqlAD As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sqlAD.Fill(dt)

        If (dt.Rows.Count > 0) Then
            'MessageBox.Show("login succee")
            main.Show()
            Me.Hide()
            txt_pass.Text = ""
        Else
            MessageBox.Show("Inccorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_log_Click_1(sender As Object, e As EventArgs) Handles btn_log.Click
        If (txt_user.Text = "") Then
            MsgBox("Enter The Username")
            txt_user.Focus()
            Exit Sub
        End If
        If (txt_pass.Text = "") Then
            MsgBox("Enter The Password")
            txt_pass.Focus()
            Exit Sub
        End If
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tbl_login WHERE username='" + txt_user.Text + "' AND password='" + txt_pass.Text + "'", con)
        Dim sqlAD As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sqlAD.Fill(dt)

        If (dt.Rows.Count > 0) Then
            'MessageBox.Show("login succee")
            main.Show()
            Me.Hide()
            txt_pass.Text = ""
        Else
            MessageBox.Show("Inccorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ck_show_pass_CheckedChanged(sender As Object, e As EventArgs) Handles ck_show_pass.CheckedChanged
        If (ck_show_pass.Checked) Then
            txt_pass.UseSystemPasswordChar = False
        Else
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_log_Click_1(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_pass.UseSystemPasswordChar = False
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged
        txt_pass.UseSystemPasswordChar = True
    End Sub
End Class
