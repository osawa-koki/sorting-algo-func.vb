Module DisplayModule
  Sub Display(ByVal title As String, ByRef nums As Array)

    Console.Write(title.PadRight(20) + ": ")

    For Each num As Integer In nums
      Console.Write(num.ToString() & " ")
    Next
    Console.WriteLine()

  End Sub
End Module
