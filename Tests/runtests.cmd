@echo off
for /F "delims=;" %%i in ('dir /b /x c:\progra~1\NUnit*') do set n_dir=%%i
for /F "delims=;" %%i in ('dir /b /x c:\progra~2\NUnit*') do set n_dir2=%%i
IF NOT DEFINED n_dir (
set NUNIT=c:\progra~2\%n_dir2%
) else (
set NUNIT=c:\progra~1\%n_dir%
)

echo using nunit: %NUNIT% and %1
if not exist "%NUNIT%\bin\net-2.0\nunit-console.exe" (
echo running %NUNIT%\bin\nunit-console.exe %1
"%NUNIT%\bin\nunit-console.exe" %1
) else (
echo running %NUNIT%\bin\net-2.0\nunit-console.exe %1
"%NUNIT%\bin\net-2.0\nunit-console.exe" %1
)