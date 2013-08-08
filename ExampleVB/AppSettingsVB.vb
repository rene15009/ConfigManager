
Imports System
Imports System.Configuration
'-------------------------------------------------------------------------------------------------------------
'Notas este código fue generado por la plantilla AppSettings.tt cualquier cambio debe hacerse en la misma
'Generado: 08/08/2013 17:17:45
'-------------------------------------------------------------------------------------------------------------
Public Class SettingsBase

    Public Overridable ReadOnly Property Uno As String
        Get
            Return ConfigurationManager.AppSettings.Item("Uno")
        End Get
    End Property

    Public Overridable ReadOnly Property Dos As String
        Get
            Return ConfigurationManager.AppSettings.Item("Dos")
        End Get
    End Property

    Public Overridable ReadOnly Property Tres As String
        Get
            Return ConfigurationManager.AppSettings.Item("Tres")
        End Get
    End Property

    Public Overridable ReadOnly Property Cuatro As String
        Get
            Return ConfigurationManager.AppSettings.Item("Cuatro")
        End Get
    End Property

    Public Overridable ReadOnly Property Some_Property As String
        Get
            Return ConfigurationManager.AppSettings.Item("Some:Property")
        End Get
    End Property

    Public Overridable ReadOnly Property Webpages_Version As String
        Get
            Return ConfigurationManager.AppSettings.Item("Webpages:Version")
        End Get
    End Property

    Public Overridable ReadOnly Property Webpages_Enabled As String
        Get
            Return ConfigurationManager.AppSettings.Item("Webpages Enabled")
        End Get
    End Property

    Public Overridable ReadOnly Property Preserve_LoginUrl As String
        Get
            Return ConfigurationManager.AppSettings.Item("Preserve-LoginUrl")
        End Get
    End Property

    Public Overridable ReadOnly Property ClientValñidationEnabled As String
        Get
            Return ConfigurationManager.AppSettings.Item("ClientValñidationEnabled")
        End Get
    End Property

    Public Overridable ReadOnly Property Unobtrusiv_JavaScriptEnabled As String
        Get
            Return ConfigurationManager.AppSettings.Item("Unobtrusiv JavaScriptEnabled")
        End Get
    End Property



    Public Function GetListSettings() As IEnumerable

        Dim l As New List(Of KeyValuePair(Of String, String))

        l.Add(New KeyValuePair(Of String, String)("Uno", Uno))
        l.Add(New KeyValuePair(Of String, String)("Dos", Dos))
        l.Add(New KeyValuePair(Of String, String)("Tres", Tres))
        l.Add(New KeyValuePair(Of String, String)("Cuatro", Cuatro))
        l.Add(New KeyValuePair(Of String, String)("Some:Property", Some_Property))
        l.Add(New KeyValuePair(Of String, String)("Webpages:Version", Webpages_Version))
        l.Add(New KeyValuePair(Of String, String)("Webpages Enabled", Webpages_Enabled))
        l.Add(New KeyValuePair(Of String, String)("Preserve-LoginUrl", Preserve_LoginUrl))
        l.Add(New KeyValuePair(Of String, String)("ClientValñidationEnabled", ClientValñidationEnabled))
        l.Add(New KeyValuePair(Of String, String)("Unobtrusiv JavaScriptEnabled", Unobtrusiv_JavaScriptEnabled))

        Return l
    End Function

End Class


