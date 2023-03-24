Imports System
Imports CSLog

Module Program
    Sub Main(args As String())
        Dim pattern As New CSLCustom("<BG=DarkBlue><FG=Yellow>{Timestamp} <FG=Red>[CUSTOM] <FG=Gray>: <FG=Green>{Message}")

        CSLogger.Log(Types.Debug, "Debug log")
        CSLogger.Log(Types.Info, "Info log")
        CSLogger.Log(Types.Warning, "Warning log")
        CSLogger.Log(Types.Error, "Error log")
        CSLogger.Log(Types.Critical, "Critical log")

        CSLogger.LogWithCustomProfile(pattern, "Custom log")
    End Sub
End Module
