@echo off
if exist assignment1 (
   rmdir assignment1
   mkdir assignment1
)else (
  mkdir assignment1
)

dir

cd assignment1


if exist new_file1.txt (
  del new_file1.txt
  echo new file with new content>>new_file1.txt
)else  (
  type nul new_file1.txt
)

notepad new_file1.txt

cd ..