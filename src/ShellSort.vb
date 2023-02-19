
Module ShellSortModule

  Sub ShellSort(ByRef nums As Array)

    ' シェルソート
    Dim h As Integer = 1
    While h < nums.Length / 3
      h = 3 * h + 1
    End While
    While h >= 1
      For i As Integer = h To nums.Length - 1
        For j As Integer = i To h Step -h
          If nums(j) < nums(j - h) Then
            Dim temp As Integer = nums(j)
            nums(j) = nums(j - h)
            nums(j - h) = temp
          End If
        Next
      Next
      h = h / 3
    End While

  End Sub

End Module
