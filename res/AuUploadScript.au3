;Wait 10 seconds for the Upload window to appear
WinWait("[CLSAA:#32770]","",10)
;Set the file name test on the Edit field
ControlSetText("�ļ��ϴ�","","Edit1","D:\Lyratesting2Project1\res\image.jpg")

Sleep(2000)

;Click on the open button

ControlClick("�ļ��ϴ�","","Button1");

;Sleep(2000)

