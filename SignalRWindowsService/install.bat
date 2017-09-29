sc create "SignalRChatService" binpath= "%~dp0SignalRChatService.exe"
sc failure "SignalRChatService" reset= 3600 actions= restart/500/restart/5000/restart/30000
sc start "SignalRChatService"
pause 