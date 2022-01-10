Imports Oracle.ManagedDataAccess.Client
Module Conexion
    'String de conexión a la base de datos utilizando paquete Oracle.ManagedDataAccess.Client
    Public Function conexionBD() As OracleConnection
        Return New OracleConnection("User ID=system;Password=123456;Data Source=localhost:1521/XE;")
    End Function

    Public strConexion As OracleConnection = conexionBD()

    Public result As String
    Public cmd As New OracleCommand
    Public da As New OracleDataAdapter
    Public dt As New DataTable
    Public daLogin As OracleDataReader

    Public usuarioLogin As String
    Public perfilUsuario As String

    'Método para consultar a la base de datos
    Public Sub Consultar(ByVal sql As String, ByVal datos As Object)
        Try
            dt = New DataTable
            strConexion.Open()
            With cmd
                .Connection = strConexion
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            datos.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConexion.Close()
            da.Dispose()
        End Try
    End Sub

    'Método para insetar en la base de datos
    Public Sub Insertar(ByVal sql As String)
        Try
            strConexion.Open()
            With cmd
                .Connection = strConexion
                .CommandText = sql
                result = cmd.ExecuteNonQuery()
                If result = 0 Then
                    MessageBox.Show("Error al guardar en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El registro ha sido guardado en la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConexion.Close()
        End Try
    End Sub

    'Método para actualizar en la base de datos
    Public Sub Actualizar(ByVal sql As String)
        Try
            strConexion.Open()
            With cmd
                .Connection = strConexion
                .CommandText = sql
                result = cmd.ExecuteNonQuery()
                If result = 0 Then
                    MessageBox.Show("Error al actualizar en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El registro ha sido actualizado en la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConexion.Close()
        End Try
    End Sub

    'Método para eliminar de la base de datos
    Public Sub Eliminar(ByVal sql As String)
        Try
            strConexion.Open()
            With cmd
                .Connection = strConexion
                .CommandText = sql
                result = cmd.ExecuteNonQuery()
                If result = 0 Then
                    MessageBox.Show("Error al eliminar de la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El registro ha sido eliminado de la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConexion.Close()
        End Try
    End Sub

    'Método para iniciar sesión y verificar perfil
    Public Sub LoginS(ByVal usuario As String, ByVal contraseña As String)
        Try
            strConexion.Open()
            With cmd
                .Connection = strConexion
                .CommandText = "SELECT PERFIL FROM USUARIOS WHERE USUARIO='" & usuario & "' AND CLAVE='" & contraseña & "'"
                daLogin = cmd.ExecuteReader()
                If daLogin.Read Then
                    usuarioLogin = usuario
                    perfilUsuario = daLogin.GetString(0)
                Else
                    MessageBox.Show("El nombre de usuario o contraseña es incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    usuarioLogin = Nothing
                    perfilUsuario = Nothing
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConexion.Close()
        End Try
    End Sub

End Module
