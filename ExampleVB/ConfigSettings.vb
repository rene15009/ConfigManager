Public Class ConfigSettings
    Inherits SettingsBase

    Private Shared _ins As ConfigSettings
    Public Shared ReadOnly Property R As ConfigSettings
        Get
            If _ins Is Nothing Then _ins = New ConfigSettings
            Return _ins
        End Get
    End Property

    Private Sub New()
    End Sub

    Public Overrides ReadOnly Property Uno() As String
        Get
            Return Math.Abs(Convert.ToInt16(MyBase.Uno) * 1024).ToString
        End Get
    End Property

    Public ReadOnly Property AnotherProperty As String
        Get
            Return "rene"
        End Get
    End Property
End Class
