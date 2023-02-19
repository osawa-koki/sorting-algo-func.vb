
Module QuickSortModule

  Sub QuickSort(ByRef nums As Array)

    ' クイックソート
    QuickSortSub(nums, 0, nums.Length - 1)

  End Sub

  Sub QuickSortSub(ByRef nums As Array, ByVal left As Integer, ByVal right As Integer)

    If left >= right Then
      Return
    End If

    Dim pivot As Integer = nums((left + right) \ 2)
    Dim i As Integer = left
    Dim j As Integer = right

    Do
      While nums(i) < pivot
        i += 1
      End While
      While pivot < nums(j)
        j -= 1
      End While
      If i <= j Then
        Dim temp As Integer = nums(i)
        nums(i) = nums(j)
        nums(j) = temp
        i += 1
        j -= 1
      End If
    Loop While i <= j

    QuickSortSub(nums, left, j)
    QuickSortSub(nums, i, right)

  End Sub

End Module
