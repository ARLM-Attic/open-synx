#!/bin/bash
#Copyright (c) Etheral Studios 2012
#Synx for Linux v0.3

#Clean up from previous useage
music_checked=f
pictures_checked=f
videos_checked=f
movies_checked=f
podcasts_checked=f
clear
echo "Synx (c) Copyright Etheral Studios 2012"
echo "Synx for Linux v0.3 Beta - for more information go to http://opensynx.codeplex.com"

zenity --title="Synx v0.3 Beta" --info --text "This program will synchronise your Android device. Make sure you have read the documentation at http://opensynx.codeplex.com/documentation."

#Ask what content the user wants to synx
checkinput=$(zenity --list --checklist \
   --title="Synx v0.3 Beta" --text "Select what media to synx" --column=Boxes --column=Selections \
   TRUE "Synx Music" TRUE "Synx Pictures (and backup phone camera)" TRUE "Synx Videos" TRUE "Synx Movies" TRUE "Synx Podcasts" --separator=':' )

if [ -z "$checkinput" ] ; then
   zenity --title="Synx v0.3 Beta" --info --text "No media selected."
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
      "Synx Movies")
      movies_checked=t;;
      "Synx Podcasts")
      podcasts_checked=t;;
   esac
done
unset IFS

#Run a shell script on the Android device to make room for some synxy action
./adb push synx_organiser.sh /mnt/sdcard/synx_organiser.sh
./adb shell << EOF
cd /mnt/sdcard/
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
         zenity --title="Synx v0.3 Beta" --info --text "No media selected."
      fi
      zenity --title="Synx v0.3 Beta" --info --text "Your Music is about to be synxed. You will get a notification once this has completed."
      ./adb pull /mnt/sdcard/Music/ $MusicDir/
      ./adb push $MusicDir/ /mnt/sdcard/Music/
      zenity --title="Synx v0.3 Beta" --info --text "Your music has been synxed.";;
esac

case $pictures_checked in
   "t")
      echo Synxing Pictures...
      PicturesDir=$(zenity --file-selection --directory --filename=$HOME/Pictures/ --title="Select your Pictures folder")
      if [ -z "$PicturesDir" ] ; then
         zenity --title="Synx v0.3 Beta" --info --text "No media selected."
      fi
      zenity --title="Synx v0.3 Beta" --info --text "Your Pictures are about to be synxed. You will get a notification once this has completed."
      ./adb pull /mnt/sdcard/Pictures/ $PicturesDir/
      ./adb push $PicturesDir/ /mnt/sdcard/Music/

      if [ ! -d "$PicturesDir/Phone Camera" ]; then
         mkdir $PicturesDir/Phone\ Camera
      fi

      ./adb pull /mnt/sdcard/DCIM/ $PicturesDir/Phone\ Camera/
      zenity --title="Synx v0.3 Beta" --info --text "Your pictures have been synxed.";;
esac

case $videos_checked in
   "t")
      echo Synxing Videos...
      VideosDir=$(zenity --file-selection --directory --filename=$HOME/Videos/ --title="Select your Videos folder")
      if [ -z "$VideosDir" ] ; then
         zenity --title="Synx v0.3 Beta" --info --text "No media selected."
      fi
      zenity --title="Synx v0.3 Beta" --info --text "Your Videos are about to be synxed. You will get a notification once this has completed."
      ./adb pull /mnt/sdcard/Videos/ $VideosDir/
      ./adb push $VideosDir/ /mnt/sdcard/Videos/
      zenity --title="Synx v0.3 Beta" --info --text "Your videos have been synxed.";;
esac

case $movies_checked in
   "t")
      echo Synxing Movies...
      MoviesDir=$(zenity --file-selection --directory --filename=$HOME/Videos/ --title="Select your Movies folder")
      if [ -z "$MoviesDir" ] ; then
         zenity --title="Synx v0.3 Beta" --info --text "No media selected."
      fi
      zenity --title="Synx v0.3 Beta" --info --text "Your Movies are about to be synxed. You will get a notification once this has completed."
      ./adb pull /mnt/sdcard/Movies/ $MoviesDir/
      ./adb push $MoviesDir/ /mnt/sdcard/Movies/
      zenity --title="Synx v0.3 Beta" --info --text "Your videos have been synxed.";;
esac

case $podcasts_checked in
   "t")
      echo Synxing Podcasts...
      PodcastsDir=$(zenity --file-selection --directory --filename=$HOME/ --title="Select your Podcasts folder")
      if [ -z "$PodcastsDir" ] ; then
         zenity --title="Synx v0.3 Beta" --info --text "No media selected."
      fi
      zenity --title="Synx v0.3 Beta" --info --text "Your Podcasts are about to be synxed. You will get a notification once this has completed."
      ./adb pull /mnt/sdcard/Podcasts/ $PodcastsDir/
      ./adb push $PodcastsDir/ /mnt/sdcard/Podcasts/
      zenity --title="Synx v0.3 Beta" --info --text "Your podcasts have been synxed.";;
esac