Imports System.Windows.Forms
Public Class ComboboxAutoComplete

    'Estamos criando uma combobox usando a herança e sobreescrevendo alguns dos seus métodos

    Inherits ComboBox

    'Usamos esta variavel para sinalizar para a sub OnTextChanged se iremos ou nao iremos usar o autocompletar

    Private _AutoComplete As Boolean = True



        'Isto é disparadao quando uma tecla é pressionada na combo

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)

            'ativa auto completar somente quando a tecla pressionada não for backspace nem delete.

            _AutoComplete = e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back



            'Como sobre escrevemos o evento OnKeyDown event precisamos dizer para noossa classe "Base" que uma tecla foi pressionada

            MyBase.OnKeyDown(e)

        End Sub



        'disparado quando o texto na combo mudar

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)



            'somente faça se o usuário não pressionou backspace ou delete

            If _AutoComplete Then

                Dim TextEntered As String = Me.Text

                ' pega o texto atual fora da combo box

                Dim index As Integer = Me.FindString(TextEntered)

                'FindString é o metodo na combo box que estamos usando

                If index >= 0 Then

                    'se o texto não existir nos itens da combo então...

                    _AutoComplete = False

                    'desabilita o auto completar enquanto mudamos o indice selecionado

                    Me.SelectedIndex = index

                    'altera o index selecionado

                    _AutoComplete = True

                    'habilita o auto completar

                    Me.Select(TextEntered.Length, Me.Text.Length)

                    'seleciona somente o texto incluido

                End If

            End If



            MyBase.OnTextChanged(e)

            'Como sobre escrevemos o evento OnTextChanged event precisamos dizer para nossa classe "Base" que uma tecla foi pressionada

        End Sub



    End Class

