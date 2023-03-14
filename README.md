## Ban Desktop Shortcuts

Some apps like Discord and Postman insist on creating Windows Desktop shortcuts each time they update. 

Run this simple program to remove them: I myself run it as a scheduled task one minute after user log on.

### Usage
Create a text file called "shortcuts.txt" in the same directory as the executable. Put the names of the shortcuts you want to remove in there, one per line. Then run the program.

```
SHORTCUTS.TXT
Discord.lnk
Postman.lnk
```
