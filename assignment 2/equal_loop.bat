@echo off


set count=0
set limit=5

:loop
if !count! equ %limit% (
    echo Count: !count!
    set \a count+=1
    goto loop
)
