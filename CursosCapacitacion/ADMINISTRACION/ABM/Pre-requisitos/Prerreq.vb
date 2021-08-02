Public Class Prerreq

    Private Sub Prerreq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If A_Edicion = True Then
            Sql = "select idarea from areas where nombre='" & A_Cursos.cboAreas.Text & "'"
            Procedure()
            RS.Read()
            Sql = "select Curso from cursos where idarea=" & RS(0) & " and Curso!='" & A_Cursos.txtNombre.Text & "'"
            Procedure()
            While RS.Read
                cboCursos.Items.Add(RS(0))
            End While
        Else
            Sql = "select a.idarea from areas a, cursos c where c.idarea=a.idarea and Curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            Sql = "select Curso from cursos where idarea=" & RS(0) & " and Curso!='" & NCurso & "'"
            Procedure()
            While RS.Read
                cboCursos.Items.Add(RS(0))
            End While
        End If
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim cur As Integer
        Dim req As Integer
        If A_Edicion = True Then
            Sql = "select idcurso from cursos where Curso='" & A_Cursos.txtNombre.Text & "'"
            Procedure()
            RS.Read()
            cur = RS(0)
            Sql = "select idcurso from cursos where Curso='" & cboCursos.Text & "'"
            Procedure()
            RS.Read()
            req = RS(0)
            If chkObligatorio.Checked = True Then
                Sql = "insert into prerreq values(" & cur & ", " & req & ", 1)"
                Procedure()
            Else
                Sql = "insert into prerreq values(" & cur & ", " & req & ", 0)"
                Procedure()
            End If
            Rta = MsgBox("¿Desea ingresar otro pre-requisito?", MsgBoxStyle.YesNo)
            If Rta = 6 Then
                cboCursos.Text = ""
                chkObligatorio.Checked = False
            Else
                MsgBox("Usted sera redirigido al menu principal")
                Prerrequisitos2 = False
                cboCursos.Text = ""
                chkObligatorio.Checked = False
                A_Ediciones.nudHora1.Value = 0
                A_Ediciones.nudhora2.Value = 0
                A_Ediciones.nudmm1.Value = 0
                A_Ediciones.nudmm2.Value = 0
                A_Edicion = False
                A_Cursos.txtNombre.Text = ""
                A_Cursos.txtNivel.Text = ""
                A_Cursos.txtDuracion.Text = ""
                A_Cursos.txtPuntaje.Text = ""
                A_Cursos.txtCosto.Text = ""
                A_Cursos.txtCupo.Text = ""
                A_Cursos.cboAreas.Text = ""
                A_Cursos.chkGerencial.Checked = False
                MenuAdministracion.Show()
                Me.Close()
            End If
        Else
            Sql = "select idcurso from cursos where Curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            cur = RS(0)
            Sql = "select idcurso from cursos where Curso='" & cboCursos.Text & "'"
            Procedure()
            RS.Read()
            req = RS(0)
            If chkObligatorio.Checked = True Then
                Sql = "insert into prerreq values(" & cur & ", " & req & ", 1)"
                Procedure()
            Else
                Sql = "insert into prerreq values(" & cur & ", " & req & ", 0)"
                Procedure()
            End If
            Rta = MsgBox("¿Desea ingresar otro pre-requisito?", MsgBoxStyle.YesNo)
            If Rta = 6 Then
                cboCursos.Text = ""
                chkObligatorio.Checked = False
            Else
                MsgBox("Usted sera redirigido al menu principal")
                Prerrequisitos = False
                MenuAdministracion.Show()
                Me.Close()
            End If
        End If
        
    End Sub

    Private Sub btnPrerreq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrerreq.Click
        Prerrequisitos = True
        Requisitos.Show()
        Me.Hide()
    End Sub
End Class