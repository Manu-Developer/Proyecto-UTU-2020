Imports MySql.Data.MySqlClient

Public Class Datos

    Private connection As MySqlConnection = New MySqlConnection("datasource=localhost; username=root; password=; database=hotelcanino")

    Public Function checkConnection()
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            FormInfo.callFormWithMessage("Error al Conectar a la Base de Datos")
            Return False
        End Try
    End Function

    Private Function getConnection()
        Return connection
    End Function


    Public Function login(username As TextBox, password As TextBox)
        getConnection().open
        Dim command = New MySqlCommand("SELECT * from login where Username=@user", getConnection())
        command.Parameters.AddWithValue("@user", username.Text)
        command.CommandType = CommandType.Text

        Dim reader = command.ExecuteReader()
        If reader.Read Then
            If reader("Username").Equals(username.Text) And reader("Password").Equals(password.Text) Then
                If reader("ROL").Equals("Gerente") Then
                    username.Text = ""
                    password.Text = ""
                    General.Show()
                ElseIf reader("ROL").Equals("Oficinista") Then
                    username.Text = ""
                    password.Text = ""
                    Dim oficinista As General = New General
                    oficinista.btnModificarPrecio.Visible = False
                    oficinista.btnReservas.Visible = False
                    oficinista.btnHEntrada.Visible = False
                    oficinista.btnHSalida.Visible = False
                    oficinista.btnModificarPrecio.Enabled = False
                    oficinista.btnReservas.Enabled = False
                    oficinista.btnHEntrada.Enabled = False
                    oficinista.btnHSalida.Enabled = False
                    oficinista.Show()
                ElseIf reader("ROL").Equals("Recepcionista") Then
                    username.Text = ""
                    password.Text = ""
                    Dim recepcionista As General = New General
                    recepcionista.btnModificarPrecio.Visible = False
                    recepcionista.btnModificarPrecio.Enabled = False
                    recepcionista.btnReservas.Visible = False
                    recepcionista.btnReservas.Enabled = False
                    recepcionista.Show()
                Else
                    FormInfo.callFormWithMessage("Tu Rol es incorrecto o no existe")
                    reader.Close()
                End If
                Return True
                getConnection().Close
            Else
                username.Text = ""
                password.Text = ""
                FormInfo.callFormWithMessage("Usuario o contraseña incorrectos")
                reader.Close()
                getConnection().Close
                Return False
            End If
        Else
            password.Text = ""
            FormInfo.callFormWithMessage("Esta cuenta no existe!")
            reader.Close()
            getConnection().Close
            Return False
        End If
    End Function
End Class
