#Created by Nicholas Webster 27/10/11
#Modified by:
#Nicholas Webster

read -p "Android Device Location: " DevDrv
read -p "Music Directory: " MusicDir

echo "Synxing..."
sudo cp -r $MusicDir $DevDrv
echo "Synxed!"