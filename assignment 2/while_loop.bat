@echo off
set /a count =0
:loop
if %count% leq 5 (
       echo %count%
       set /a count+=1
        goto loop
)