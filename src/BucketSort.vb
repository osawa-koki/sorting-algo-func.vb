
Module BucketSortModule

  Sub BucketSort(ByRef nums As Array)

    ' バケツソート
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

    Dim bucketSize As Integer = 5
    Dim bucketCount As Integer = (max - min) \ bucketSize + 1
    Dim buckets(bucketCount - 1) As List(Of Integer)
    For i As Integer = 0 To bucketCount - 1
      buckets(i) = New List(Of Integer)
    Next

    For i As Integer = 0 To nums.Length - 1
      Dim bucketIndex As Integer = (nums(i) - min) \ bucketSize
      buckets(bucketIndex).Add(nums(i))
    Next

    Dim index As Integer = 0
    For i As Integer = 0 To bucketCount - 1
      Dim bucket As List(Of Integer) = buckets(i)
      bucket.Sort()
      For j As Integer = 0 To bucket.Count - 1
        nums(index) = bucket(j)
        index += 1
      Next
    Next

  End Sub

End Module
