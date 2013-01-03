#!/bin/bash
#Synx (c) Copyright Etheral Studios 2012
#Synx Organiser v0.1.1

cd /storage/emulated/legacy/

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