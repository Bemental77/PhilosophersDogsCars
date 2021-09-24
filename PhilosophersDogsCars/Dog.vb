
'Author: Casey Bement
'Date: 09/23/2021

Option Strict On
Option Explicit On
Public Class Dog
    'Define Class or Module Level Variables

    Private mstrBreed As String
    Private mstrWeight As String
    Private mstrColor As String

    Public Property Breed As String
        Get
            Return mstrBreed
        End Get
        Set(strvalue As String)
            mstrBreed = strvalue
        End Set
    End Property

    Public Property Weight As String
        Get
            Return mstrWeight
        End Get
        Set(strvalue As String)
            mstrWeight = strvalue
        End Set
    End Property

    Public Property Color As String
        Get
            Return mstrColor
        End Get
        Set(strvalue As String)
            mstrColor = strvalue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrBreed = String.Empty
        mstrWeight = String.Empty
        mstrColor = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strBreed As String)
        mstrBreed = strBreed
        mstrWeight = String.Empty
        mstrColor = String.Empty

    End Sub

    Public Function Dog_Description() As String
        Return mstrColor & " " & mstrBreed
    End Function

End Class
