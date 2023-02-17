#import as

shutdown = input("Wanna Shutdown your computer(yes/no): ")

if: shutdown == 'no'
	exit()
else:
	os.system("shutdown /s /t 1")	