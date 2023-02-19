Module InsertionSortModule

  Sub InsertionSort(ByRef nums As Array)

    ' 挿入ソート
    For i As Integer = 1 To nums.Length - 1
      Dim j As Integer = i
      While j > 0 AndAlso nums(j - 1) > nums(j)
        Dim tmp As Integer = nums(j)
        nums(j) = nums(j - 1)
        nums(j - 1) = tmp
        j -= 1
      End While
    Next

  End Sub

End Module
