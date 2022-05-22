Public Class Board
    Public bPieces As New List(Of Piece)
    Public iPieces As New List(Of Piece)
    Public nPieces As New List(Of Piece)
    Public gPieces As New List(Of Piece)
    Public oPieces As New List(Of Piece)
    Public squares(5, 5) As Square
    Public accepted As Boolean

    'constructor
    Public Sub New()
        Me.setBoard()
    End Sub

    'methods
    Public Sub setBoard()
        'creates a 5X5 board
        bPieces.Clear()
        iPieces.Clear()
        nPieces.Clear()
        gPieces.Clear()
        oPieces.Clear()
        For x As Integer = 0 To 4
            For y As Integer = 0 To 4
                squares(x, y) = New Square(x, y)
            Next
        Next

        'create array of all numbers
        Dim b As Integer = 1
        Dim i As Integer = 16
        Dim n As Integer = 31
        Dim g As Integer = 46
        Dim o As Integer = 61
        Dim bNumbers As New List(Of Integer)
        Dim iNumbers As New List(Of Integer)
        Dim nNumbers As New List(Of Integer)
        Dim gNumbers As New List(Of Integer)
        Dim oNumbers As New List(Of Integer)

        For x As Integer = 0 To 14
            bNumbers.Add(b)
            iNumbers.Add(i)
            nNumbers.Add(n)
            gNumbers.Add(g)
            oNumbers.Add(o)
            b += 1
            i += 1
            n += 1
            g += 1
            o += 1
        Next

        'set columns
        For x As Integer = 0 To 4
            Select Case x
                Case 0
                    'set b 
                    setCols(x, bPieces, "B", bNumbers)
                    Exit Select
                Case 1
                    'set i
                    setCols(x, iPieces, "I", iNumbers)
                    Exit Select

                Case 2
                    'set n
                    setCols(x, nPieces, "N", nNumbers)
                    Exit Select
                Case 3
                    'set g
                    setCols(x, gPieces, "G", gNumbers)
                    Exit Select
                Case 4
                    'set o
                    setCols(x, oPieces, "O", oNumbers)
                    Exit Select
            End Select
        Next
    End Sub
    Private Sub setCols(x As Integer, pieces As List(Of Piece), letter As String, numbers As List(Of Integer))
        Dim number As Integer


        For y As Integer = 0 To 4
            If x = 2 And y = 2 Then
                'set free space, does not need a number
                Dim currentPiece As Piece = New Piece(x, y, letter)
                currentPiece.name = "Free"
                currentPiece.coverPiece()
                pieces.Add(currentPiece)
                'set piece on board
                setPieceOnSpace(currentPiece, x, y)
            Else
                'set regular column
                Dim currentPiece As Piece = New Piece(x, y, letter)
                Dim min As Integer = 0
                Dim max As Integer = numbers.Count() - 1

                Dim rand As System.Random = New System.Random()
                'get number within correct range
                Dim n As Integer = rand.Next(min, max)
                number = numbers(n)
                currentPiece.number = number
                currentPiece.name = letter + number.ToString()
                numbers.RemoveAt(n)
                pieces.Add(currentPiece)
                'set piece on board
                setPieceOnSpace(currentPiece, x, y)
            End If
        Next
    End Sub
    Public Sub setPieceOnSpace(piece As Piece, x As Integer, y As Integer)
        squares(x, y).piece = piece
    End Sub
    Function showBoardPiece(x As Integer, y As Integer) As String
        If x = 2 And y = 2 Then
            Return squares(x, y).piece.name.ToString()
        Else
            Return squares(x, y).piece.number.ToString()
        End If


    End Function

    Public Function coverSpace(name As String, x As Integer, y As Integer) As Boolean

        If squares(x, y).getPieceName().Equals(name) Then
            'cover piece
            squares(x, y).piece.coverPiece()

        Else
            'do Not cover space
            'System.out.println("This piece is not your board!");


        End If

        Return squares(x, y).piece.covered
    End Function
    Public Sub coverCpuBoard(name As String)
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If name Is squares(x, y).getPieceName() Then
                    squares(x, y).piece.coverPiece()
                End If

            Next
        Next
    End Sub


End Class
