Public Class ABM
    Private Sub btnAAreas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAAreas.Click
        A_Areas.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompAlt.Click
        A_Compania.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompMod.Click
        M_Compania.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir1.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnACapacitadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACapacitadores.Click
        A_Capacitadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnATitulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnATitulos.Click
        Dim t_bandera As Boolean
        Me.Hide()
        DniC = InputBox("Ingrese DNI del capacitador para asignar titulos: ") 'Variable para carga de titulos con existencia de capacitadores
        Sql = "select count(*) from personas where dni=" & DniC & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            MsgBox("El capacitador ha sido encontrado.")
            t_bandera = True
        End If
        While RS(0) = 0
            MsgBox("El capacitador no se encuentra. Ingrese el dni nuevamente")
            DniC = InputBox("Ingrese DNI del capacitador para asignar titulos: ")
            Sql = "select count(*) from personas where dni=" & DniC & ""
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                MsgBox("El capacitador ha sido encontrado.")
                t_bandera = True
            End If
        End While
        If t_bandera = True Then
            A_Titulos.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnACursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACursos.Click
        A_Cursos.Show()
        Me.Hide()
    End Sub

    Private Sub btnMCapacitadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCapacitadores.Click
        M_Capacitadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuAdministracion.Show()
        Me.Hide()
    End Sub

    Private Sub btnAEdiciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAEdiciones.Click
        Dim e_bandera As Boolean
        Me.Hide()
        NCurso = InputBox("Ingrese nombre del curso para asignar ediciones: ") 'Variable para carga de titulos con existencia de capacitadores
        Sql = "select count(*) from cursos where curso='" & NCurso & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            MsgBox("El curso ha sido encontrado.")
            e_bandera = True
        End If
        While RS(0) = 0
            MsgBox("El curso no se encuentra. Ingrese el nombre nuevamente")
            NCurso = InputBox("Ingrese nombre del curso para asignar ediciones: ")
            Sql = "select count(*) from cursos where curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                MsgBox("El curso ha sido encontrado.")
                e_bandera = True
            End If
        End While
        If e_bandera = True Then
            A_Ediciones.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnAHCapacitadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAHCapacitadores.Click
        Dim hc_bandera As Boolean
        Me.Hide()
        DniC = InputBox("Ingrese DNI del capacitador para asignar horarios: ")
        Sql = "select count(*) from personas where dni=" & DniC & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            MsgBox("El capacitador ha sido encontrado.")
            hc_bandera = True
        End If
        While RS(0) = 0
            MsgBox("El capacitador no se encuentra. Ingrese el dni nuevamente")
            DniC = InputBox("Ingrese DNI del capacitador para asignar horarios: ")
            Sql = "select count(*) from personas where dni=" & DniC & ""
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                MsgBox("El capacitador ha sido encontrado.")
                hc_bandera = True
            End If
        End While
        If hc_bandera = True Then
            H_Capacitadores.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnARequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARequisitos.Click
        Dim pre_bandera As Boolean
        Me.Hide()
        NCurso = InputBox("Ingrese nombre del curso para asignar pre-requisitos: ") 'Variable para carga de requisitos con existencia de cursos
        Sql = "select count(*) from cursos where curso='" & NCurso & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            MsgBox("El curso ha sido encontrado.")
            Prerrequisitos = True
            pre_bandera = True
        End If
        While RS(0) = 0
            MsgBox("El curso no se encuentra. Ingrese el nombre nuevamente")
            NCurso = InputBox("Ingrese nombre del curso para asignar pre-requisitos: ")
            Sql = "select count(*) from cursos where curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                MsgBox("El curso ha sido encontrado.")
                Prerrequisitos = True
                pre_bandera = True
            End If
        End While
        If pre_bandera = True Then
            Prerreq.Show()
            Me.Hide()
        End If
    End Sub
End Class