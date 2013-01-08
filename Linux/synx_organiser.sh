#!/bin/bash
#Synx (c) Copyright Etheral Studios 2012
#Synx Organiser v0.2

echo "Synx (c) Copyright Etheral Studios 2012"
echo "Synx for Linux v0.1.2 Alpha - for more information go to http://opensynx.codeplex.com"

cd /mnt/sdcard/

if [ ! -d "Music" ] ; then
	mkdir Music
fi

if [ ! -d "Pictures" ] ; then
	mkdir Pictures
fi

if [ ! -d "DCIM" ] ; then
	mkdir DCIM
fi

if [ ! -d "Videos" ] ; then
	mkdir Videos
fi

if [ ! -d "Movies" ] ; then
	mkdir Movies
fi

if [ ! -d "Podcasts" ] ; then
	mkdir Podcasts
fi