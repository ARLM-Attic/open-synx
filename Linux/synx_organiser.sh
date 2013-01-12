#!/bin/bash
#Synx (c) Copyright Etheral Studios 2012
#Synx Organiser v0.2.1

clear
echo "Synx Organiser (c) Copyright Etheral Studios 2012"
echo "Synx Organiser v0.2.1 Alpha - for more information go to http://opensynx.codeplex.com"
echo ""

cd /mnt/sdcard/

if [ ! -d "Music" ] ; then
    echo "No music direcotry found on device, making now..."
	mkdir Music
fi

if [ ! -d "Pictures" ] ; then
    echo "No pictures direcotry found on device, making now..."
	mkdir Pictures
fi

if [ ! -d "DCIM" ] ; then
    echo "No DCIM direcotry found on device, making now..."
	mkdir DCIM
fi

if [ ! -d "Videos" ] ; then
    echo "No videos direcotry found on device, making now..."
	mkdir Videos
fi

if [ ! -d "Movies" ] ; then
    echo "No movies direcotry found on device, making now..."
	mkdir Movies
fi

if [ ! -d "Podcasts" ] ; then
    echo "No podcasts direcotry found on device, making now..."
	mkdir Podcasts
fi
echo ""
echo "Back to you synx.sh"