#Created by Nicholas Webster 27/10/11
#Modified by:
#Nicholas Webster

echo "Installing Synx..."
sudo cp synx /usr/bin
sudo mkdir /usr/bin/synxfiles
sudo cp main.py /usr/bin/synxfiles
sudo cp synxer.sh /usr/bin/synxfiles
sudo chmod +x /usr/bin/synx