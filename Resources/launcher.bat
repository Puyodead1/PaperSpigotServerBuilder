@echo off
title PaperSpigot Launcher

where java >nul 2>nul
if %errorlevel%==1 (
    goto a
) else (
	goto b
)

:a
echo Java not found in path, program will now exit!
pause
exit

:b
echo Java installation found, starting server...
where "paperclip-*.jar" >nul 2>nul
if %errorlevel%==1 (
    goto c
) else (
	goto d
)

:c
echo PaperClip jar not found!
pause
exit

:d
echo PaperClip jar found, executing...
for /f %%i in ('dir /b "paperclip-*.jar"') do SET jar=%%i
java -jar %jar% --nogui
pause