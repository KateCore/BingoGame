Public Class frmBingo
    Dim myGame As New Game
    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnShuffle_Click(Me, EventArgs.Empty)

    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click

        myGame.myBoard.setBoard()

        lblspaceB0.Text = myGame.myBoard.showBoardPiece(0, 0)
        lblspaceB1.Text = myGame.myBoard.showBoardPiece(0, 1)
        lblspaceB2.Text = myGame.myBoard.showBoardPiece(0, 2)
        lblspaceB3.Text = myGame.myBoard.showBoardPiece(0, 3)
        lblspaceB4.Text = myGame.myBoard.showBoardPiece(0, 4)
        lblspaceI0.Text = myGame.myBoard.showBoardPiece(1, 0)
        lblspaceI1.Text = myGame.myBoard.showBoardPiece(1, 1)
        lblspaceI2.Text = myGame.myBoard.showBoardPiece(1, 2)
        lblspaceI3.Text = myGame.myBoard.showBoardPiece(1, 3)
        lblspaceI4.Text = myGame.myBoard.showBoardPiece(1, 4)
        lblspaceN0.Text = myGame.myBoard.showBoardPiece(2, 0)
        lblspaceN1.Text = myGame.myBoard.showBoardPiece(2, 1)
        lblspaceN2.Text = myGame.myBoard.showBoardPiece(2, 2)
        lblspaceN3.Text = myGame.myBoard.showBoardPiece(2, 3)
        lblspaceN4.Text = myGame.myBoard.showBoardPiece(2, 4)
        lblspaceG0.Text = myGame.myBoard.showBoardPiece(3, 0)
        lblspaceG1.Text = myGame.myBoard.showBoardPiece(3, 1)
        lblspaceG2.Text = myGame.myBoard.showBoardPiece(3, 2)
        lblspaceG3.Text = myGame.myBoard.showBoardPiece(3, 3)
        lblspaceG4.Text = myGame.myBoard.showBoardPiece(3, 4)
        lblspaceO0.Text = myGame.myBoard.showBoardPiece(4, 0)
        lblspaceO1.Text = myGame.myBoard.showBoardPiece(4, 1)
        lblspaceO2.Text = myGame.myBoard.showBoardPiece(4, 2)
        lblspaceO3.Text = myGame.myBoard.showBoardPiece(4, 3)
        lblspaceO4.Text = myGame.myBoard.showBoardPiece(4, 4)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If Not myGame.over Then
            'cover free space
            lblspaceN2.BackColor = Color.Red

            'call a bingo piece
            myGame.current = myGame.randomPiece()
            lblCurrent.Text = myGame.current
        End If



    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Not myGame.over Then
            myGame.current = myGame.randomPiece()
            lblCurrent.Text = myGame.current
        End If

    End Sub

    Private Sub lblspaceB0_Click(sender As Object, e As EventArgs) Handles lblspaceB0.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 0, 0)
        If covered Then
            lblspaceB0.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As New frmWin
            bingoWin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lblspaceB1_Click(sender As Object, e As EventArgs) Handles lblspaceB1.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 0, 1)
        If covered Then
            lblspaceB1.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As New frmWin
            bingoWin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lblspaceB2_Click(sender As Object, e As EventArgs) Handles lblspaceB2.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 0, 2)
        If covered Then
            lblspaceB2.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceB3_Click(sender As Object, e As EventArgs) Handles lblspaceB3.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 0, 3)
        If covered Then
            lblspaceB3.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceB4_Click(sender As Object, e As EventArgs) Handles lblspaceB4.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 0, 4)
        If covered Then
            lblspaceB4.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceI0_Click(sender As Object, e As EventArgs) Handles lblspaceI0.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 1, 0)
        If covered Then
            lblspaceI0.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceI1_Click(sender As Object, e As EventArgs) Handles lblspaceI1.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 1, 1)
        If covered Then
            lblspaceI1.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceI2_Click(sender As Object, e As EventArgs) Handles lblspaceI2.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 1, 2)
        If covered Then
            lblspaceI2.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceI3_Click(sender As Object, e As EventArgs) Handles lblspaceI3.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 1, 3)
        If covered Then
            lblspaceI3.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceI4_Click(sender As Object, e As EventArgs) Handles lblspaceI4.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 1, 4)
        If covered Then
            lblspaceI4.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceN0_Click(sender As Object, e As EventArgs) Handles lblspaceN0.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 2, 0)
        If covered Then
            lblspaceN0.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceN1_Click(sender As Object, e As EventArgs) Handles lblspaceN1.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 2, 1)
        If covered Then
            lblspaceN1.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceN2_Click(sender As Object, e As EventArgs) Handles lblspaceN2.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 2, 2)
        If covered Then
            lblspaceN2.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceN3_Click(sender As Object, e As EventArgs) Handles lblspaceN3.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 2, 3)
        If covered Then
            lblspaceN3.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceN4_Click(sender As Object, e As EventArgs) Handles lblspaceN4.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 2, 4)
        If covered Then
            lblspaceN4.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceG0_Click(sender As Object, e As EventArgs) Handles lblspaceG0.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 3, 0)
        If covered Then
            lblspaceG0.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceG1_Click(sender As Object, e As EventArgs) Handles lblspaceG1.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 3, 1)
        If covered Then
            lblspaceG1.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceG2_Click(sender As Object, e As EventArgs) Handles lblspaceG2.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 3, 2)
        If covered Then
            lblspaceG2.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceG3_Click(sender As Object, e As EventArgs) Handles lblspaceG3.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 3, 3)
        If covered Then
            lblspaceG3.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceG4_Click(sender As Object, e As EventArgs) Handles lblspaceG4.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 3, 4)
        If covered Then
            lblspaceG4.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceO0_Click(sender As Object, e As EventArgs) Handles lblspaceO0.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 4, 0)
        If covered Then
            lblspaceO0.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceO1_Click(sender As Object, e As EventArgs) Handles lblspaceO1.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 4, 1)
        If covered Then
            lblspaceO1.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceO2_Click(sender As Object, e As EventArgs) Handles lblspaceO2.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 4, 2)
        If covered Then
            lblspaceO2.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceO3_Click(sender As Object, e As EventArgs) Handles lblspaceO3.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 4, 3)
        If covered Then
            lblspaceO3.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub lblspaceO4_Click(sender As Object, e As EventArgs) Handles lblspaceO4.Click
        Dim covered As Boolean
        covered = myGame.myBoard.coverSpace(myGame.current, 4, 4)
        If covered Then
            lblspaceO4.BackColor = Color.Red
        End If
        Dim bingo As Boolean
        bingo = myGame.checkBingo(myGame.myBoard)
        If bingo Then
            Dim bingoWin As frmWin = New frmWin()
            bingoWin.ShowDialog()
            Me.Hide()
        End If
    End Sub


End Class
