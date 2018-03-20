

Module Module1
    Private Declare Function SystemParametersInfo Lib “user32” Alias “SystemParametersInfoA” (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    Private Declare Auto Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    Private Declare Auto Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Const SW_HIDE As Integer = 0

    'Declare two constant

    Private Const SETDESKWALLPAPER = 20

    Private Const UPDATEINIFILE = &H1



    Sub Main()
        Dim hWndConsole As IntPtr
        hWndConsole = GetConsoleWindow()
        ShowWindow(hWndConsole, SW_HIDE)

        Dim webClient As New System.Net.WebClient

        webClient.DownloadFile("https://i.ytimg.com/vi/dQw4w9WgXcQ/maxresdefault.jpg", "C:\Users\" + Environment.UserName + "\rick.jpg")


        SystemParametersInfo(SETDESKWALLPAPER, 0, "C:\Users\" + Environment.UserName + "\rick.jpg", UPDATEINIFILE)

        MsgBox("You got Rick Rolled.", vbInformation, "Check your desktop background!")

        Dim form As New Form1()
        form.Show()

        My.Computer.Audio.Play("\\SERVER\share\roll.wav")
        System.Threading.Thread.Sleep(200000)

    End Sub




End Module
