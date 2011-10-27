#Created by Nicholas Webster 26/10/11
#Modified by:
#Nicholas Webster

import os

os.system('clear')
synx = "synx"
exit = "exit"

print "Welcome to the Python port of Synx! If this has helped you please donate."
command = raw_input("Type your command: ")

if command == synx:
    os.system('sh /usr/bin/synxfiles/synxer.sh')

elif command == exit:
    os.system('clear')

else:
    os.system('clear')
    print "Sorry I did not understand that."