
Module ShuffleModule
  Sub Shuffle(ByRef nums As Array)

    ' Fisher-Yatesアルゴリズムによる配列のシャッフル
    Dim rand As New Random()
    For i As Integer = nums.Length - 1 To 1 Step -1
      Dim j As Integer = rand.Next(i + 1)
      Dim temp As Integer = nums(i)
      nums(i) = nums(j)
      nums(j) = temp
    Next

  End Sub
End Module
