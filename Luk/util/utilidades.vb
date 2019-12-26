Imports DevExpress.XtraEditors

Public Class utilidades

    Public Function fecha() As String
        Return Now.ToString("dd/MM/yyyy hh:MM:ss")
    End Function

    Public Sub mensajes(mensaje As String, titulo As String, tipo As String)
        If tipo = "INF" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Information)
        End If
        If tipo = "WAR" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Warning)
        End If
        If tipo = "ERR" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function msj_confirmacion(mensaje As String, titulo As String) As Boolean
        Dim result As DialogResult = XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return result = DialogResult.Yes
    End Function

    Public Function CheckForm(_form As Form) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next

        Return False
    End Function

End Class
