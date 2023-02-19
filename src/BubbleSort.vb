Module BubbleSortModule

	Sub BubbleSort(ByRef nums As Array)

    ' バブルソート
    For i As Integer = 0 To nums.Length - 1
      For j As Integer = nums.Length - 1 To i + 1 Step -1
        If nums(j) < nums(j - 1) Then
          Dim temp As Integer = nums(j)
          nums(j) = nums(j - 1)
          nums(j - 1) = temp
        End If
      Next
    Next

  End Sub

End Module
