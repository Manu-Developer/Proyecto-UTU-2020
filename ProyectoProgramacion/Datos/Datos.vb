Imports MySql.Data.MySqlClient

Public Class Datos

    Private connection As MySqlConnection = New MySqlConnection("datasource=localhost; username=root; password=52059150; database=fbravo") 'Conexion con la Base de Datos'

    Public Function checkConnection() 'Comprueba la Conexion con la Base de datos'
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            FormInfo.callFormWithMessage("Compruebe su conectividad a internet")
            Return False
        End Try
    End Function

    Private Function getConnection() 'Metodo para Obtener la Conexion'
        Return connection
    End Function


    Public Function login(username As TextBox, password As TextBox) 'Funcion Login'
        getConnection().open
        Dim command = New MySqlCommand("SELECT * from empleado where Username=@user", getConnection())
        command.Parameters.AddWithValue("@user", username.Text)
        command.CommandType = CommandType.Text

        Dim reader = command.ExecuteReader()
        If reader.Read Then
            If reader("Username").Equals(username.Text) And reader("Password").Equals(password.Text) Then
                Dim general As General = New General
                If reader("RolPrograma").Equals("G") Then
                    username.Text = ""
                    password.Text = ""
                    general.Show()
                ElseIf reader("RolPrograma").Equals("O") Then
                    username.Text = ""
                    password.Text = ""
                    general.btnModificarPrecio.Visible = False
                    general.btnReservas.Visible = False
                    general.btnModificarPrecio.Enabled = False
                    general.btnReservas.Enabled = False
                    general.Show()
                ElseIf reader("RolPrograma").Equals("R") Then
                    username.Text = ""
                    password.Text = ""
                    general.btnModificarPrecio.Visible = False
                    general.btnModificarPrecio.Enabled = False
                    general.btnGestion.Visible = False
                    general.btnGestion.Enabled = False
                    general.Show()
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
