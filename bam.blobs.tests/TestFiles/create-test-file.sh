#!/bin/bash

SIZE=$1
FILENAME=$2

head -c "$SIZE" /dev/urandom > "$FILENAME"