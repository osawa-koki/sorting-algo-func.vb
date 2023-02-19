
Module Program
  Sub Main()

    ' 配列を宣言
    Dim nums As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9}

    ' 配列の要素を表示
    Display("Original", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' バブルソート
    BubbleSort(nums)
    Display("Bubble Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' 選択ソート
    SelectionSort(nums)
    Display("Selection Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' 挿入ソート
    InsertionSort(nums)
    Display("Insertion Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' クイックソート
    QuickSort(nums)
    Display("Quick Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' マージソート
    MergeSort(nums)
    Display("Merge Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' ヒープソート
    HeapSort(nums)
    Display("Heap Sorted", nums)

    ' シャッフル
    Shuffle(nums)
    Display("Shuffled", nums)

    ' シェルソート
    ShellSort(nums)
    Display("Shell Sorted", nums)

  End Sub
End Module
