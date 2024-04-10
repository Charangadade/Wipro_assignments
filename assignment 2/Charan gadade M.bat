@echo off
if exist Wipro_linux_new (
   echo directory exist
)else (
  mkdir new
)

dir

cd new

if exist new_file1.txt (
   echo file already exists
echo More content to append>>new_file1.txt
)else (
  echo Hello World>new_file1.txt
)

notepad new_file1.txt

cd ..