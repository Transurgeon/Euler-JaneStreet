from typing import List
from collections import defaultdict
import math 

class State:
    def __init__(self, size: int, row_sum: List[int], col_sum: List[int]):
        self.size = size
        self.grid = [[0] * size for _ in range(size)]
        self.rowSum = row_sum
        self.colSum = col_sum
    
    def printState(self):
        """
        enumerate can iterate through a list while also giving access to an index
        s stores the string for each row
        and once we finish iterating through a row, we need to print s and make a new line
        """
        for i, row in enumerate(self.grid):
            s = ""
            if i == 0:
                col = ""
                brk = ""
                for c in self.colSum:
                    col += str(c) + " "
                    brk += "---"
                print(col)
                print(brk)
            for j, val in enumerate(row):
                s += str(val) + "  "
            print(s, "|", self.rowSum[i])

    def validateF_shape(self, move):
        row_diff = defaultdict(int)
        col_diff = defaultdict(int)
        val = move.value
        for s in move.shift:
            dx, dy = s
            for c in move.centers:
                row, col = c
                new_row = row + val * dx
                new_col = col + val * dy
                if new_row < 0 or new_row >= self.size or new_col < 0 or new_col >= self.size:
                    print("Invalid F shape, out of bounds points due to center being too close to border")
                    return False
                elif self.grid[new_row][new_col] != 0:
                    print("Invalid F shape, value already exists at row:", row, "and col:", col)
                    return False
                else:
                    row_diff[new_row] += val
                    col_diff[new_col] += val
        for k in row_diff:
            if row_sum[k] < row_diff[k]:
                print("Invalid F shape, exceeds row sum at index ", k)
                return False
        for k in col_diff:
            if col_sum[k] < col_diff[k]:
                print("Invalid F shape, exceeds col sum at index ", k)
                return False
        self.updateGrid(move, row_diff, col_diff)
        return True

    def updateGrid(self, move, row_diff, col_diff):
        val = move.value
        for s in move.shift:
            dx, dy = s
            for c in move.centers:
                row, col = c
                new_row = row + val * dx
                new_col = col + val * dy
                self.grid[new_row][new_col] = val
        for k in row_diff:
            self.rowSum[k] -= row_diff[k]
        for k in col_diff:
            self.colSum[k] -= col_diff[k]

class Move:
    def __init__(self, Ftype, center, value):
        self.Ftype = Ftype
        self.center = center
        self.value = value
        self.generateCenters()
        self.generateF_shape()

    def generateF_shape(self):
        shift = [(0,0)]
        if self.Ftype < 5:
            shift.append((-1,0))
            shift.append((1,0))
            if self.Ftype < 3:
                shift.append((0,1))
                if self.Ftype == 1:
                    shift.append((-1,-1))
                else:
                    shift.append((1,-1))
            else:
                shift.append((0,-1))
                if self.Ftype == 3:
                    shift.append((-1,1))
                else:
                    shift.append((1,1))
        else:
            shift.append((0,-1))
            shift.append((0,1))
            if self.Ftype < 7:
                shift.append((1,0))
                if self.Ftype == 5:
                    shift.append((-1,-1))
                else:
                    shift.append((-1,1))
            else:
                shift.append((-1,0))
                if self.Ftype == 7:
                    shift.append((1,1))
                else:
                    shift.append((1,-1))
        self.shift = shift

    def generateCenters(self):
        centers = []
        row, col = self.center
        for i in range(self.value):
            for j in range(self.value):
                centers.append((row + i, col + j))
        self.centers = centers

# row_sum = [3, 9, 10, math.inf, 13, 8, 7, 2]
# col_sum = [9, 12, 12, 10, 8, 8, math.inf, 2]

row_sum = [14, 24, 24, 39, 43, math.inf, 22, 23, 29, 28, 34, 35, 29, 26, 26, 24, 20]
col_sum = [13, 20, 22, 28, 30, 36, 35, 39, 49, 39, 39, math.inf, 23, 32, 23, 17, 13]

s = State(17, row_sum, col_sum)
s.printState()

m = Move(2, (2,2), 2)
s.validateF_shape(m)
s.printState()
