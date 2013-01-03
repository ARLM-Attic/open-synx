#!/bin/bash
#Copyright (c) Etheral Studios 2012
#Synx for Linux v0.1

#Clean up from previous useage
music_checked=f
pictures_checked=f
videos_checked=f
clear
echo "Synx (c) Copyright Etheral Studios 2012"
echo "Synx for Linux v0.1 Alpha - for more information go to http://opensynx.codeplex.com"

zenity --title="Synx v0.1.1 Alpha" --info --text "This program will synchronise your Android device. Make sure you have read the documentation at http://opensynx.codeplex.com/documentation."

#Ask what content the user wants to synx
checkinput=$(zenity --list --checklist \
   --title="Synx v0.1.1 Alpha" --text "Select what media to synx" --column=Boxes --column=Selections \
   TRUE "Synx Music" TRUE "Synx Pictures (and backup phone camera)" TRUE "Synx Videos" --separator=':' )

if [ -z "$checkinput" ] ; then
   zenity --title="Synx v0.1.1 Alpha" --info --text "No media selected."
   exit 1
fi

IFS=":" ; for checkresults in $checkinput ; do 
   case $checkresults in
      "Synx Music")
      music_checked=t;;
      "Synx Pictures (and backup phone camera)")
      pictures_checked=t;;
      "Synx Videos")
      videos_checked=t;;
   esac
done
unset IFS

#Run a shell script on the Android device to make room for some synxy action
./adb push synx_organiser.sh /storage/emulated/legacy/synx_organiser.sh
./adb shell << EOF
cd /storage/emulated/legacy/
sh synx_organiser.sh
rm synx_organiser.sh
exit
EOF

#Synx!
case $music_checked in
   "t")
      echo Synxing Music...
      MusicDir=$(zenity --file-selection --directory --filename=$HOME/Music/ --title="Select your Music folder")
      if [ -z "$MusicDir" ] ; then
         zenity --title="Synx v0.1.1 Alpha" --info --text "No media selected."
         exit 1
      fi
      zenity --title="Synx v0.1.1 Alpha" --info --text "Your Music is about to be synxed. You will get a notification once this has completed."
      ./adb pull /storage/emulated/legacy/Music/ $MusicDir/
      ./adb push $MusicDir/ /storage/emulated/legacy/Music/
      notify-send Synx "Your music has been Synxed";;
esac

case $pictures_checked in
   "t")
      echo Synxing Pictures...
      PicturesDir=$(zenity --file-selection --directory --filename=$HOME/Pictures/ --title="Select your Pictures folder")
      if [ -z "$PicturesDir" ] ; then
         zenity --title="Synx v0.1.1 Alpha" --info --text "No media selected."
         exit 1
      fi
      zenity --title="Synx v0.1.1 Alpha" --info --text "Your Pictures are about to be synxed. You will get a notification once this has completed."
      ./adb pull /storage/emulated/legacy/Pictures/ $PicturesDir/
      ./adb push $PicturesDir/ /storage/emulated/legacy/Music/

      if [ ! -d "$PicturesDir/Phone Camera" ]; then
         mkdir $PicturesDir/Phone\ Camera
      fi

      ./adb pull /storage/emulated/legacy/DCIM/ $PicturesDir/Phone\ Camera/
      notify-send Synx "Your pictures have been Synxed";;
esac

case $videos_checked in
   "t")
      echo Synxing Videos...
      VideosDir=$(zenity --file-selection --directory --filename=$HOME/Videos/ --title="Select your Videos folder")
      if [ -z "$VideosDir" ] ; then
         zenity --title="Synx v0.1.1 Alpha" --info --text "No media selected."
         exit 1
      fi
      zenity --title="Synx v0.1.1 Alpha" --info --text "Your Videos are about to be synxed. You will get a notification once this has completed."
      ./adb pull /storage/emulated/legacy/Videos/ $VideosDir/
      ./adb push $VideosDir/ /storage/emulated/legacy/Videos/
      notify-send Synx "Your videos have been Synxed";;
esac