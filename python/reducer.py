#!/usr/bin/env python

import sys

last_match = None
total_count = 0

for line in sys.stdin:
    line = line.strip()
    match, count = line.split('\t')
    count = int(count)

    if not last_match:
        last_match = match

    if last_match == match:
        total_count += count
    else:
        print '%s\t%s' % (last_match, total_count)
        total_count = 1
        last_match = match

print '%s\t%s' % (last_match, total_count)
