# Map-of-hollows

You are given a rectangular map of the depths of a reservoir of size. For each card cell, its depth (integer) is given. We will call some cell of the map a hollow, if this cell is not on the boundary of the map, and all the cells adjacent to it have a strictly smaller depth.

Your task is to find all the cavities on the map and mark them with X.

Input format

The first line contains the integer size of the card. Each of the following lines contains positive numbers, written without spaces. Each digit (1-9) changes the depth of the corresponding card cell.

Output Format

Output the lines of the final map with marked cavities. XIII.

Example input data

4
1112
1912
1892
1234
Example Output

1112
1X12
18x2
1234
