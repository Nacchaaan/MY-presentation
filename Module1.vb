Module Module1
    '定数
    Const ROCK As Integer = 1      ' グー
    Const SCISSORS As Integer = 2  ' チョキ
    Const PAPER As Integer = 3     ' パー

    Sub Main()
        ' 表示用ジャンケンの手を初期化
        Dim arrHands() As String = {"グー", "チョキ", "パー"}
        While True
            showChoices(arrHands)
            Dim choice As Integer = Console.ReadLine()

        End While

        'TODO
    End Sub

    Sub showChoices(arrHands)
        Console.WriteLine("【ジャンケンの手を選択してください】")
        Console.WriteLine($"{ROCK}：{arrHands(0)}")
        Console.WriteLine($"{SCISSORS}：{arrHands(1)}")
        Console.WriteLine($"{PAPER}：{arrHands(2)}")
    End Sub
    Function generateRandomNumber() As Integer
        Dim rnd As New Random()
        Dim number As Integer = rnd.Next(1, 101)
        Return number
    End Function

    Function janken(choice As Integer) As Integer
        
         
    End Function
End Module
