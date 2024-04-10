@echo off
for /l %%i in (1,2,10) do echo %%i

for /f "tokens=*" %%g in (	file1.txt) do echo %%g