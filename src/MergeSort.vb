
Module MergeSortModule

  Sub MergeSort(ByRef nums As Array)

    ' マージソート
    Dim temp(nums.Length - 1) As Integer
    MergeSortSub(nums, 0, nums.Length - 1, temp)

  End Sub

  Sub MergeSortSub(ByRef nums As Array, ByVal left As Integer, ByVal right As Integer, ByRef temp As Integer())

    If left >= right Then
      Return
    End If

    Dim mid As Integer = (left + right) \ 2
    MergeSortSub(nums, left, mid, temp)
    MergeSortSub(nums, mid + 1, right, temp)
    Merge(nums, left, mid, right, temp)

  End Sub

  Sub Merge(ByRef nums As Array, ByVal left As Integer, ByVal mid As Integer, ByVal right As Integer, ByRef temp As Integer())

    Dim i As Integer = left
    Dim j As Integer = mid + 1
    Dim k As Integer = left

    Do
      If nums(i) < nums(j) Then
        temp(k) = nums(i)
        i += 1
      Else
        temp(k) = nums(j)
        j += 1
      End If
      k += 1
    Loop While i <= mid And j <= right

    If i > mid Then
      For l As Integer = j To right
        temp(k) = nums(l)
        k += 1
      Next
    Else
      For l As Integer = i To mid
        temp(k) = nums(l)
        k += 1
      Next
    End If

    For l As Integer = left To right
      nums(l) = temp(l)
    Next

  End Sub

End Module
