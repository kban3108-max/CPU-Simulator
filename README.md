A Simple CPU Simulator Made In C#

## how to use tutorial:

1. download the APK (if you're looking for how to use the source code then scroll down to tutorial 2 or if you want to use the DLL scroll down to tutorial 3)
2. install it
3. give it all file access and notifications (steps vary per device)
4. enjoy

## how to use tutorial 2:

1. install the source
2. copy into IDE of choice
3. run or modify the paths to match your OS (I'll do it soon trust) then run
4. enjoy

## how to use tutorial 3:

1. install the DLL
2. put it in the same folder as your main file
3. in your main file put these lines of code:
using CPU; // put this at the top of the file
CPUIns CI = new CPUIns();
CI.RUN();
5. compile it alongside your main file using the flag '-r:./simplecpu.dll'
6. enjoy

**Warning**: currently the source code is optimized for the android filesystem soon I'll add more versions but for now you can rewrite the file IO segments for operating systems.

## License: 
[LICENSE](LICENSE)
