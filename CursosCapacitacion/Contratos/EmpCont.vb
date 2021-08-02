Imports System.Data.Odbc
Public Class EmpCont

    Private Sub EmpCont_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAgregar.Enabled = False
        'Dim cont As Integer
        Sql = "SELECT IDCOMP FROM COMPANIAS WHERE NOMBRE='" & contratos.txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        comp = RS(0)
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
        If i < contratos.txtEmp.Text Then
            btnAgregar.Enabled = True
            txtNombre.Enabled = True
            txtApellido.Enabled = True
            txtDireccion.Enabled = True
            txtTelefono.Enabled = True
            txtNacionalidad.Enabled = True
            dtpFecha.Enabled = True
            txtEmail.Enabled = True
            rdnFemenino.Enabled = True
            rdnMasculino.Enabled = True
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
                dtpFecha.Text = RS(6)
                txtNacionalidad.Text = RS(7)
                txtEmail.Text = RS(9)
                If RS(8) = "M" Then
                    rdnMasculino.Checked = True
                ElseIf RS(8) = "F" Then
                    rdnFemenino.Checked = True
                End If
            Else
                gbxDatos.Visible = True
                Bandera = True
            End If
        End If
    End Sub
    Private Sub lstDatos_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)
        e.Cancel = True
        e.NewWidth = lstDatos.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim lista As ListViewItem = New ListViewItem(txtNombre.Text)
        Dim ID As Integer
        Rta = MsgBox("Esta seguro que quiere ingresar esos datos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            i = i + 1
            If y = True Then
                Sql = "SELECT COUNT(*) FROM PERSONAS P,EMPLEADOSCOMP em,aprobado_desaprobado E WHERE DNI=" & txtDni.Text & " AND P.idpersona=EM.idpersona and e.estado=1 and e.IDEMPLEADO=em.IDEMPLEADO AND E.IDCURSO IN(SELECT IDREQ FROM EDICIONES E,CURSOS C,prerreq WHERE idcur=c.idcurso and E.IDCURSO=C.IDCURSO AND CURSO='" & contratos.txtNombreC.Text & "' and obligatorio=1)"
                Procedure()
                RS.Read()
                If RS(0) >= 1 Then
                    lista.SubItems.Add(txtApellido.Text)
                    lista.SubItems.Add(txtDni.Text)
                    lstDatos.Items.Add(lista)
                Else
                    Rta = MsgBox("Este empleado no cumple los requisitos.Desea ingresar otro empleado en su lugar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
                    If Rta = 6 Then
                        i = i - 1
                        txtNombre.Clear()
                        txtApellido.Clear()
                        txtDireccion.Clear()
                        txtTelefono.Clear()
                        txtDni.Clear()
                        txtNacionalidad.Clear()
                        txtEmail.Clear()
                        txtDni.Focus()
                    Else
                        MsgBox("Solicitud de contrato rechazada.Sera devuelto al menu principal", MsgBoxStyle.Information)
                        MenuAdministracion.Show()
                        Me.Close()
                    End If
                End If
            End If
            If Bandera = True And y = False Then
                If rdnFemenino.Checked = True Then
                    Sql = "INSERT INTO Personas VALUES('','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTelefono.Text & "," & txtDni.Text & ",'" & dtpFecha.Value.ToString("yyyy/MM/dd") & "','" & txtNacionalidad.Text & "','F','" & txtEmail.Text & "')"
                    Procedure()
                    Sql = "SELECT IDPERSONA FROM PERSONAS WHERE DNI=" & txtDni.Text
                    Procedure()
                    RS.Read()
                    ID = RS(0)
                    Sql = "INSERT INTO EMPLEADOSCOMP VALUES(''," & ID & "," & comp & ",true,NULL)"
                    Procedure()
                    lista.SubItems.Add(txtApellido.Text)
                    lista.SubItems.Add(txtDni.Text)
                    lstDatos.Items.Add(lista)
                Else
                    Sql = "INSERT INTO Personas VALUES('','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTelefono.Text & "," & txtDni.Text & ",'" & dtpFecha.Value.ToString("yyyy/MM/dd") & "','" & txtNacionalidad.Text & "','M','" & txtEmail.Text & "')"
                    Procedure()
                    Sql = "SELECT IDPERSONA FROM PERSONAS WHERE DNI=" & txtDni.Text
                    Procedure()
                    RS.Read()
                    ID = RS(0)
                    Sql = "INSERT INTO EMPLEADOSCOMP VALUES(''," & ID & "," & comp & ",true,NULL)"
                    Procedure()
                    lista.SubItems.Add(txtApellido.Text)
                    lista.SubItems.Add(txtDni.Text)
                    lstDatos.Items.Add(lista)
                End If
            ElseIf Bandera = False And y = False Then
                Sql = "SELECT IDPERSONA FROM PERSONAS WHERE DNI=" & txtDni.Text
                Procedure()
                RS.Read()
                Sql = "INSERT INTO EMPLEADOSCOMP VALUES(''," & RS(0) & "," & comp & ",true,NULL)"
                Procedure()
                lista.SubItems.Add(txtApellido.Text)
                lista.SubItems.Add(txtDni.Text)
                lstDatos.Items.Add(lista)
            End If
            If contratos.txtEmp.Text = i Then
                MsgBox("Los empleados han sido cargados por completo", MsgBoxStyle.Information)
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
                Tipo_Pago.Show()
                Me.Hide()
            End If
            txtNombre.Clear()
            txtApellido.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()
            txtDni.Clear()
            txtNacionalidad.Clear()
            txtEmail.Clear()
            txtDni.Focus()
            rdnFemenino.Checked = False
            rdnMasculino.Checked = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtDireccion.Enabled = False
            txtTelefono.Enabled = False
            txtNacionalidad.Enabled = False
            txtEmail.Enabled = False
            rdnFemenino.Enabled = False
            rdnMasculino.Enabled = False
            dtpFecha.Enabled = False
            btnAgregar.Enabled = False
            Bandera = False
        End If
    End Sub
End Class