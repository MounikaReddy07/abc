Imports System

Public Class basic
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label1.Text = "First VB"

        Dim Expression1 As Double
        Expression1 = 5 * 3
        Label2.Text = Expression1

    End Sub
    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = IsNumeric() Then



        End If

        Dim i As Integer
        If i > 0 Then
            Label3.Text = "It is a positive number"

            ' Response.Write("<script language=""javascript"">alert('It is a positive number');</script>")
        End If

    End Sub
End Class