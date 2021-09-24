
'Author: Casey Bement
'Date: 09/23/2021

Option Strict On
Option Explicit On
Public Class Philosopher
    'Define Class or Module Level Variables

    Private mstrName As String
    Private mstrQuote As String
    Private mstrUserDate As String

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(strvalue As String)
            mstrName = strvalue
        End Set
    End Property

    Public Property Quote As String
        Get
            Return mstrQuote
        End Get
        Set(strvalue As String)
            mstrQuote = strvalue
        End Set
    End Property

    Public Property UserDate As String
        Get
            Return mstrUserDate
        End Get
        Set(strvalue As String)
            mstrUserDate = strvalue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrName = String.Empty
        mstrQuote = String.Empty
        mstrUserDate = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strName As String)
        mstrName = strName
        mstrUserDate = String.Empty
        mstrQuote = String.Empty

    End Sub

    Public Function Philosopher_Quote() As String
        Return mstrQuote
        MessageBox.Show(mstrQuote)
    End Function
End Class
