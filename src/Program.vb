
Module Program
  Sub Main()

    ' 配列を宣言
    Dim nums As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9}

    ' 配列の要素を表示
    Display("Original", nums)

    ' 配列をシャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

  End Sub
End Module
