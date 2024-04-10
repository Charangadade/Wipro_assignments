@echo off
set count=0
set limit=5

:loop
if !count! geq %limit% (
    echo Count: !count!
    set /a count+=1

    goto loop
)
echo loop ended