@echo off
set /p num=Enter the number:

set /a rem=num %% 2

if %rem%  equ 0 (
	echo Entered number is even
) else (
 	echo Entered number is odd
)