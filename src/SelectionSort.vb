
Module SelectionSortModule

	Sub SelectionSort(ByRef nums As Array)

    ' 選択ソート
    For i As Integer = 0 To nums.Length - 1
      Dim min As Integer = i
      For j As Integer = i + 1 To nums.Length - 1
        If nums(j) < nums(min) Then
          min = j
        End If
      Next
      Dim temp As Integer = nums(i)
      nums(i) = nums(min)
      nums(min) = temp
    Next

  End Sub

End Module
