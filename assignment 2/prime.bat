@echo off

set /p num=Enter a number:

set /a divisor=2
set /a is_prime=1



:loop
if %divisor% lss %num% (
    set /a remainder= %num% %% %divisor%
    if %remainder% equ 0 (
        set /a is_prime=0
        goto endloop
    )
    set /a divisor+=1
    goto loop
)

:endloop
if %is_prime% equ 1 (
    echo %num% is a prime number.
) else (
    echo %num% is not a prime number.
)