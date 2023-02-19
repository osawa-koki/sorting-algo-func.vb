
Module HeapSortModule

  Sub HeapSort(ByRef nums As Array)

    Dim n As Integer = nums.Length

    ' 最大ヒープを構築
    For i As Integer = n \ 2 - 1 To 0 Step -1
      Heapify(nums, n, i)
    Next

    ' ヒープから要素を1つずつ取り出し、昇順にソート
    For i As Integer = n - 1 To 0 Step -1
      ' 最大値を取り出し、配列の末尾と交換
      Dim temp As Integer = nums(0)
      nums(0) = nums(i)
      nums(i) = temp

      ' ヒープを再構築
      Heapify(nums, i, 0)
    Next

  End Sub

  Sub Heapify(nums() As Integer, n As Integer, i As Integer)

    Dim largest As Integer = i
    Dim left As Integer = i * 2 + 1
    Dim right As Integer = i * 2 + 2

    ' 左の子ノードが最大の場合
    If left < n AndAlso nums(left) > nums(largest) Then
      largest = left
    End If

    ' 右の子ノードが最大の場合
    If right < n AndAlso nums(right) > nums(largest) Then
      largest = right
    End If

    ' 最大の子ノードが親ノードより大きい場合、交換して再帰呼び出し
    If largest <> i Then
      Dim temp As Integer = nums(i)
      nums(i) = nums(largest)
      nums(largest) = temp

      Heapify(nums, n, largest)
    End If

  End Sub

End Module
