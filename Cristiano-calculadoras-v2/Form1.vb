Public Class Form1
    'Array global
    Dim T(9) As Integer

    'Procedure pra validar as respostas
    Sub Respostas(ByVal Acertos As Integer)
        'Validando as respostas
        If TextBox1.Text = T(0) Then
            TextBox1.ForeColor = Color.Green
        End If

        If TextBox2.Text = T(1) Then
            TextBox2.ForeColor = Color.Green
        End If

        If TextBox3.Text = T(2) Then
            TextBox3.ForeColor = Color.Green
        End If

        If TextBox4.Text = T(3) Then
            TextBox4.ForeColor = Color.Green
        End If

        If TextBox5.Text = T(4) Then
            TextBox5.ForeColor = Color.Green
        End If

        If TextBox6.Text = T(5) Then
            TextBox6.ForeColor = Color.Green
        End If

        If TextBox7.Text = T(6) Then
            TextBox7.ForeColor = Color.Green
        End If

        If TextBox8.Text = T(7) Then
            TextBox8.ForeColor = Color.Green
        End If

        If TextBox9.Text = T(8) Then
            TextBox9.ForeColor = Color.Green
        End If

        If TextBox10.Text = T(9) Then
            TextBox10.ForeColor = Color.Green
        End If

        'Contando os acertos
        For Each TextBox As Control In Me.Controls.OfType(Of TextBox)()
            'Text-box verde = acerto
            If TextBox.ForeColor = Color.Green Then
                Acertos = Acertos + 1
            End If
        Next

        'Informando os acertos
        Label2.Text = Acertos & "/10 acertos."
    End Sub

    'Cristiano automações
    Sub Tabuada(ByVal Number As Integer, ByVal Soma As Integer, ByVal Value As Integer) 'Number preenche a tabuada e soma é a tabuada.
        For I As Integer = 0 To 9
            'Preenchendo a tabuada
            T(I) = Number
            Number = Number + Soma

            'Gerando as questões
            Label1.Text &= Soma & " * " & Value.ToString() & vbCrLf
            Value = Value + 1
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adicionando as tabuadas
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")

        'Escondendo as text-box
        For Each TextBox As Control In Me.Controls.OfType(Of TextBox)()
            TextBox.Visible = False
        Next

        'Limpando a label
        Label1.Text = ""
        Label2.Text = ""

        'Escondendo os buttons
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Limpando a label
        Label1.Text = ""
        Label2.Text = ""

        'Escondendo os buttons
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True

        'Limpando as text-box
        For Each TextBox As Control In Me.Controls.OfType(Of TextBox)()
            TextBox.Text = ""
            TextBox.ForeColor = Color.Black
            TextBox.Visible = True
        Next

        'Tabuadas
        Select Case ComboBox1.SelectedIndex
            Case 0
                'Tabuada do 1
                Tabuada(1, 1, 1)
            Case 1
                'Tabuada do 2
                Tabuada(2, 2, 1)
            Case 2
                'Tabuada do 3
                Tabuada(3, 3, 1)
            Case 3
                'Tabuada do 4
                Tabuada(4, 4, 1)
            Case 4
                'Tabuada do 5
                Tabuada(5, 5, 1)
            Case 5
                'Tabuada do 6
                Tabuada(6, 6, 1)
            Case 6
                'Tabuada do 7
                Tabuada(7, 7, 1)
            Case 7
                'Tabuada do 8
                Tabuada(8, 8, 1)
            Case 8
                'Tabuada do 9
                Tabuada(9, 9, 1)
            Case 9
                'Tabuada do 10
                Tabuada(10, 10, 1)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Assumindo que você errou
        For Each TextBox As Control In Me.Controls.OfType(Of TextBox)()
            TextBox.ForeColor = Color.Red
        Next

        'Verificando as tabuadas
        Select Case ComboBox1.SelectedIndex
            Case 0 To 9
                Respostas(0) 'Procedure pra validar
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Vai
        If ComboBox1.SelectedIndex < 9 Then
            ComboBox1.SelectedIndex = ComboBox1.SelectedIndex + 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Volta
        If ComboBox1.SelectedIndex > 0 Then
            ComboBox1.SelectedIndex = ComboBox1.SelectedIndex - 1
        End If
    End Sub
End Class
