import sys
import pyperclip
import time

User = userInput = input(
    "--- LINK CONVERTER ---\nWhats the link: ")

if 'https://music' in User:
    cutString = User[34:45]
elif 'https://www.music' in User:
    cutString = User[38:49]
elif 'https://youtube' in User:
    cutString = User[28:39]
elif 'https://www.youtube' in User:
    cutString = User[32:43]
elif 'https://youtu.be/' in User:
    cutString = User[17:28]
else:
    print("NO! TRY AGAIN!")
    time.sleep(1)
    sys.exit(1)


combinedString = 'https://shay.loan/' + cutString
pyperclip.copy(combinedString)
print("\nLink was created, it's been copied: " + combinedString + " (5s)")
time.sleep(5)
