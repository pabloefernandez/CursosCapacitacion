Imports System.Data.Odbc
Public Class EmpCont
    Dim comp As Integer
    Dim i As Integer
    Private Sub EmpCont_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAgregar.Enabled = False
        'Dim cont As Integer
        'Sql = "SELECT IDCOMP FROM COMPANIAS WHERE NOMBRE='" & contratos.txtNombreComp.Text & "'"
        'Procedure()
        'RS.Read()
        'comp = RS(0)
        'Sql = "SELECT nombre,apellido,email FROM EMPLEADOSCOMP E,PERSONAS P WHERE E.IDPERSONA=P.IDPERSONA AND E.IDCOMP=" & comp
        'Procedure()
        'While RS.Read = True
        'lstDatos.Items.Add(RS(0))
        'lstDatos.Items(cont).SubItems.Add(RS(1))
        'lstDatos.Items(cont).SubItems.Add(RS(2))
        'cont = cont + 1
        'End While
    End Sub

    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        btnAgregar.Enabled = True
        If contratos.txtEmp.Text = i Then
            MsgBox("Ya cargo a todos lo empleados ")
            btnAgregar.Enabled = False
            txtDni.Enabled = False
            btnTick.Enabled = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtDireccion.Enabled = False
            txtTelefono.Enabled = False
            txtDni.Enabled = False
            txtNacionalidad.Enabled = False
            txtEmail.Enabled = False
            txtDni.Clear()
        End If
        If y = True Then
            Sql = "SELECT COUNT(*) FROM PERSONAS P,EMPLEADOSCOMP em,Aprobemp E WHERE DNI=" & txtDni.Text & " AND P.idpersona=EM.idpersona and e.estado=1 and e.IDEMPLEADO=em.IDEMPLEADO AND E.IDCURSO IN(SELECT IDREQ FROM EDICIONES E,CURSOS C,prerreq WHERE idcur=c.idcurso and E.IDCURSO=C.IDCURSO AND CURSO='" & contratos.txtNombreC.Text & "' and obligatorio=1)"
            Procedure()
            RS.Read()
            If RS(0) >= 1 Then
                Sql = "select*from personas where dni=" & txtDni.Text
                Procedure()
                RS.Read()
                gbxDatos.Visible = True
                txtNombre.Text = RS(1)
                txtApellido.Text = RS(2)
                txtDireccion.Text = RS(3)
                txtTelefono.Text = RS(4)
                txtDni.Text = RS(5)
                txtNacionalidad.Text = RS(7)
                txtEmail.Text = RS(8)
            Else
                Rta = MsgBox("Este empleado no cumple los requisitos.", vbCrLf, "Desea ingresar otro empleado en su lugar?")
                If Rta = 6 Then
                    txtNombre.Clear()
                    txtApellido.Clear()
                    txtDireccion.Clear()
                    txtTelefono.Clear()
                    txtDni.Clear()
                    txtNacionalidad.Clear()
                    txtEmail.Clear()
                    txtDni.Focus()
                Else
                    MsgBox("Solicitud de contrato rechazada.Sera devuelto al menu principal")
                    Menu1.Show()
                    Me.Close()

                End If
            End If
        End If
        Sql = "select count(*) from personas where dni=" & txtDni.Text
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select*from personas where dni=" & txtDni.Text
            Procedure()
            RS.Read()
            gbxDatos.Visible = True
            txtNombre.Text = RS(1)
            txtApellido.Text = RS(2)
            txtDireccion.Text = RS(3)
            txtTelefono.Text = RS(4)
            txtDni.Text = RS(5)
            txtNacionalidad.Text = RS(7)
            txtEmail.Text = RS(8)
        Else
            gbxDatos.Visible = True
            Bandera = True
        End If
    End Sub


    Private Sub lstDatos_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)
        e.Cancel = True
        e.NewWidth = lstDatos.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim lista As ListViewItem = New ListViewItem(txtNombre.Text)
        Dim ID As Integer

        lista.SubItems.Add(txtNombre.Text)
        lista.SubItems.Add(txtApellido.Text)
        lista.SubItems.Add(txtDni.Text)
        lstDatos.Items.Add(lista)
        Rta = MsgBox("Esta seguro que quiere ingresar esos datos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            i = i + 1
        End If
        If Bandera = True Then
            If rdnFemenino.Checked = True Then
                Sql = "INSERT INTO Personas VALUES('','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTelefono.Text & "," & txtDni.Text & ",'" & dtpFecha.Text & "','" & txtNacionalidad.Text & "','F','" & txtEmail.Text & "')"
                Procedure()
                RS.Read()
                Sql = "SELECT IDPERSONA FROM PERSONAS WHERE DNI=" & txtDni.Text
                Procedure()
                RS.Read()
                ID = RS(0)
                Sql = "INSERT INTO EMPLEADOSCOMP VALUES(''," & ID & "," & comp & ",true)"
                Procedure()
                RS.Read()
            Else
                Sql = "INSERT INTO Personas VALUES('','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTelefono.Text & "," & txtDni.Text & ",'" & dtpFecha.Text & "','" & txtNacionalidad.Text & "','M','" & txtEmail.Text & "')"
                Procedure()
                RS.Read()
                Sql = "SELECT IDPERSONA FROM PERSONAS WHERE DNI=" & txtDni.Text
                Procedure()
                RS.Read()
                ID = RS(0)
                Sql = "INSERT INTO EMPLEADOSCOMP VALUES(''," & ID & "," & comp & ",true)"
                Procedure()
                RS.Read()
            End If
        Else
            Sql = "ME FALTA ESTO "
        End If

    End Sub
End Class