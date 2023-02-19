
Module CountSortModule

  Sub CountSort(ByRef nums As Array)

    ' カウントソート
    Dim max As Integer = nums(0)
    Dim min As Integer = nums(0)
    For i As Integer = 1 To nums.Length - 1
      If nums(i) > max Then
        max = nums(i)
      End If
      If nums(i) < min Then
        min = nums(i)
      End If
    Next

    Dim count(max - min) As Integer
    For i As Integer = 0 To nums.Length - 1
      count(nums(i) - min) += 1
    Next

    Dim index As Integer = 0
    For i As Integer = 0 To count.Length - 1
      For j As Integer = 0 To count(i) - 1
        nums(index) = i + min
        index += 1
      Next
    Next

  End Sub

End Module
