Option Strict On
Option Explicit On

Public Class FantasyFootballMembers

    'Variable Declaration
    Private afName As String
    Private alName As String
    Private amemberID As Integer
    Private ateamName As String
    Private achampionship As Integer

    'GETTERS and SETTERS
    Public Property fName As String 'Get first name
        Get
            Return afName
        End Get
        Set(value As String)    'Set first name
            afName = value
        End Set
    End Property

    Public Property lName As String     'Get last name
        Get
            Return alName
        End Get
        Set(value As String)    'Set last name
            alName = value
        End Set
    End Property

    Public Property memberID As Integer      'Get member ID
        Get
            Return amemberID
        End Get
        Set(value As Integer)    'Set member ID
            amemberID = value
        End Set
    End Property

    Public Property teamName As String      'Get team name
        Get
            Return ateamName
        End Get
        Set(value As String)       'Set team name
            ateamName = value
        End Set
    End Property

    Public Property championship As Integer      'Get championship
        Get
            Return achampionship
        End Get
        Set(value As Integer)       'Set championship
            achampionship = CInt(value)
        End Set
    End Property

End Class
