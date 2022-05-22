Public Class Square
    Public piece As Piece
    Private x As Integer
    Private y As Integer
    'constructor
    Public Sub New(x As Integer, y As Integer)
        'Me.piece = piece
        Me.x = x
        Me.y = y
    End Sub


    'getters and setters
    Public Property _piece() As Piece
        Get
            Return piece
        End Get
        Set(value As Piece)
            piece = value
        End Set
    End Property
    Public Property _x() As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            x = value
        End Set
    End Property
    Public Property _y() As Integer

        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property

    'methods
    Public Function getPieceName() As String
        Return piece.name
    End Function


End Class
