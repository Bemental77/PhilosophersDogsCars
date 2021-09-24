'Author: Casey Bement
'Date: 09/23/2021

Option Strict On
Option Explicit On
Public Class Car
    'Define Class or Module Level Variables

    Private mstrMake As String
    Private mstrModel As String
    Private mstrColor As String

    Public Property Make As String
        Get
            Return mstrMake
        End Get
        Set(strvalue As String)
            mstrMake = strvalue
        End Set
    End Property

    Public Property Model As String
        Get
            Return mstrModel
        End Get
        Set(strvalue As String)
            mstrModel = strvalue
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
        mstrMake = String.Empty
        mstrModel = String.Empty
        mstrColor = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strMake As String)
        mstrMake = strMake
        mstrModel = String.Empty
        mstrColor = String.Empty

    End Sub

    Public Function Car_Name() As String
        Return mstrMake & " " & mstrModel
        MessageBox.Show(Car_Name)
    End Function
End Class
