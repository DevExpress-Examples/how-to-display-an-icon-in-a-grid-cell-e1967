﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data

Namespace ImageColumn
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = GetDateTable()
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataBind()
		End Sub
		Private Function GetDateTable() As Object
			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("Value", GetType(String))
			table.Rows.Add(1, "attach")
			table.Rows.Add(2, "n/a")
			table.Rows.Add(3, Nothing)
			table.Rows.Add(4, "back")
			Return table
		End Function


		Protected Function GetImageName(ByVal dataValue As Object) As String
			Dim val As String = String.Empty
			Try
				val = CStr(dataValue)
			Catch
			End Try

			Select Case val
				Case "attach"
					Return "~/Images/attach32x32.png"
				Case "back"
					Return "~/Images/back32x32.png"
				Case Else
					Return "~/Images/1x1.gif"
			End Select
		End Function

	End Class
End Namespace
