Public Class Piece
    Public x As Integer
    Public y As Integer
    Public letter As String
    Public number As Integer
    Public name As String
    Public covered As Boolean
    'consructors
    Public Sub New(x As Integer, y As Integer, letter As String)
        'constructor for pieces that will go on the board
        Me.x = x
        Me.y = y
        Me.letter = letter
        Me.covered = False
    End Sub
    Public Sub New(number As Integer, letter As String)
        Me.number = number
        Me.letter = letter
    End Sub
    'getters and setters
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
    Public Property _letter() As String
        Get
            Return letter
        End Get
        Set(value As String)
            letter = value
        End Set
    End Property
    Public Property _number() As Integer
        Get
            Return number
        End Get
        Set(value As Integer)
            number = value
        End Set
    End Property
    Public Property _name() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property _covered() As Boolean
        Get
            Return covered
        End Get
        Set(value As Boolean)
            covered = value
        End Set
    End Property
    'methods
    Public Sub coverPiece()
        Me.covered = True
    End Sub



End Class
