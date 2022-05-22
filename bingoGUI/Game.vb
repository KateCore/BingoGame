Public Class Game
    Public myBoard As Board
    Public cpuBoard As Board
    Public over As Boolean
    Public inPlay As New List(Of Piece)
    Public current As String
    'Public OutPlay As New List(Of Piece)

    Public Sub New()
        Me.myBoard = New Board()
        Me.cpuBoard = New Board()
        Me.over = False
        Me.inPlay = makePieces()
    End Sub


    Private Function makePieces() As List(Of Piece)
        Dim tempList As New List(Of Piece)
        For x As Integer = 0 To 74
            If x < 15 Then
                Dim currentPiece As Piece = New Piece((x + 1), "B")
                currentPiece.name = "B" + (x + 1).ToString()
                tempList.Add(currentPiece)
            ElseIf x >= 15 And x < 30 Then
                Dim currentPiece As Piece = New Piece((x + 1), "I")
                currentPiece.name = "I" + (x + 1).ToString()
                tempList.Add(currentPiece)
            ElseIf x >= 30 And x < 45 Then
                Dim currentPiece As Piece = New Piece((x + 1), "N")
                currentPiece.name = "N" + (x + 1).ToString()
                tempList.Add(currentPiece)
            ElseIf x >= 45 And x < 60 Then
                Dim currentPiece As Piece = New Piece((x + 1), "G")
                currentPiece.name = "G" + (x + 1).ToString()
                tempList.Add(currentPiece)
            ElseIf x >= 60 Then
                Dim currentPiece As Piece = New Piece((x + 1), "O")
                currentPiece.name = "O" + (x + 1).ToString()
                tempList.Add(currentPiece)
            End If
        Next

        Return tempList
    End Function

    Function randomPiece() As String
        Dim min As Integer = 0
        Dim max As Integer = Me.inPlay.Count() - 1
        Dim rand As System.Random = New System.Random()
        Dim index As Integer = rand.Next(min, max)
        Dim nextPiece As String = Me.inPlay(index).name
        'delete piece from inPlay
        inPlay.RemoveAt(index)

        Return nextPiece
    End Function



	Public Function checkBingo(board As Board) As Boolean
		Dim Bingo As Boolean


		'check columns for bingo
		Dim y As Integer = 0
		For z As Integer = 0 To 4
			If board.squares(z, y).piece.covered And
					board.squares(z, y + 1).piece.covered And
					board.squares(z, y + 2).piece.covered And
					board.squares(z, y + 3).piece.covered And
					board.squares(z, y + 4).piece.covered Then
				Bingo = True
				Return Bingo
			Else
				Bingo = False
			End If
		Next

		'check rows for bingo
		Dim x As Integer = 0

		For z As Integer = 0 To 4
			If board.squares(x, y).piece.covered And
					board.squares(x + 1, z).piece.covered And
					board.squares(x + 2, z).piece.covered And
					board.squares(x + 3, z).piece.covered And
					board.squares(x + 4, z).piece.covered Then
				Bingo = True
				Return Bingo


			Else
				Bingo = False
			End If

		Next

		'check diagonal top left to bottom right
		If board.squares(0, 0).piece.covered And
				board.squares(1, 2).piece.covered And
				board.squares(2, 2).piece.covered And
				 board.squares(3, 3).piece.covered And
				board.squares(4, 4).piece.covered Then
			Bingo = True
			Return Bingo


		Else
			Bingo = False

		End If

		'check diagonal bottom left to top right
		If board.squares(0, 4).piece.covered And
				board.squares(1, 4).piece.covered And
				board.squares(2, 2).piece.covered And
				board.squares(3, 1).piece.covered And
				board.squares(4, 0).piece.covered Then
			Bingo = True
			Return Bingo


		Else
			Bingo = False

		End If

		Return Bingo

	End Function


End Class
