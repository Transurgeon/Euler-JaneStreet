from typing import List
from collections import defaultdict
from copy import deepcopy
import math 

class State:
    def __init__(self, size: int, row_sum: List[int], col_sum: List[int]):
        self.size = size
        self.grid = [[0] * size for _ in range(size)]
        self.rowSum = row_sum
        self.colSum = col_sum
        self.lastCenter = (0,0)

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

    def validateF_shape(self, move) -> bool:
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
                    # print("Invalid F shape, out of bounds points due to center being too close to border")
                    return False
                elif self.grid[new_row][new_col] != 0:
                    # print("Invalid F shape, value already exists at row:", row, "and col:", col)
                    return False
                else:
                    row_diff[new_row] += val
                    col_diff[new_col] += val
        for k in row_diff:
            if self.rowSum[k] < row_diff[k]:
                # print("Invalid F shape, exceeds row sum at index ", k)
                return False
        for k in col_diff:
            if self.colSum[k] < col_diff[k]:
                # print("Invalid F shape, exceeds col sum at index ", k)
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
    
    def isSolution(self):
        rows = len([s for s in self.rowSum if s == 0])
        cols = len([s for s in self.colSum if s == 0])
        if (rows == self.size - 1 and cols == self.size - 1):
            print("Found Solution!")
            return True
        return False

    def validateCenter(self, move):
        val = move.value
        for c in move.centers:
            row, col = c
            if row < val or row >= self.size - val or col < val or col >= self.size - val:
                # print("Invalid F shape, out of bounds points due to center being too close to border")
                return False
            if self.grid[row][col] != 0:
                # print("Invalid Center for the point at ", row, ", ", col)
                return False
        row, col = move.center
        rowConst = True
        colConst = True
        for j in range(row, row + val):
            rowConst = (self.rowSum[j] >= val**2 * 3) and rowConst
        for j in range(col, col + val):
            colConst = (self.rowSum[j] >= val**2 * 3) and colConst
        if not rowConst and not colConst:
            # print("Invalid Center, row or column sum exceeded")
            return False
        return True


class Move:
    def __init__(self, Ftype, center, value):
        self.Ftype = Ftype
        self.center = center
        self.value = value
        self.generateCenters()
        self.generateShifts()

    def generateShifts(self):
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

class Solution:
    def __init__(self, staty: State):
        self.stack = [staty]

    def depthySolver(self):
        three_centers = [(3,7)]
        self.generate3_shapes(three_centers)
        count = 0
        while count < 20:
            self.generateOthers()
            count += 1

    def generate3_shapes(self, three_centers):
        # fill in the grids of size 3
        s = self.stack.pop()
        for c in three_centers:
            if s.validateCenter(Move(1, c, 3)):
                for i in range(1, 9):
                    new_s = deepcopy(s)
                    m = Move(i, c, 3)
                    if (new_s.validateF_shape(m)):
                        self.stack.append(new_s)

    def generateOthers(self): 
        s = self.stack.pop(0)
        row, col = s.lastCenter
        print(row, col)
        for r in range(row, s.size):
            for c in range(col + 1, s.size):
                if s.validateCenter(Move(1, (r,c), 2)):
                    self.generateFshapes(s, (r,c), 2)
                    return
                if s.validateCenter(Move(1, (r,c), 1)):
                    self.generateFshapes(s, (r,c), 1)
                    return

    def generateFshapes(self, s, p, val):
        for i in range(1, 9):
            new_s = deepcopy(s)
            m = Move(i, p, val)
            if (new_s.validateF_shape(m)):
                new_s.lastCenter = p
                self.stack.insert(0, new_s)
                new_s.printState()

def findAllValidCenters(state: State):
    centers = []
    for i in range(0, state.size):
        for j in range(0, state.size):
            if state.validateCenter(Move(1, (i,j), 3)):
                centers.append((i,j))
    print(len(centers))

if __name__ == "__main__":
    #row_sum = [3, 9, 10, math.inf, 13, 8, 7, 2]
    #col_sum = [9, 12, 12, 10, 8, 8, math.inf, 2]

    row_sum = [14, 24, 24, 39, 43, math.inf, 22, 23, 29, 28, 34, 35, 29, 26, 26, 24, 20]
    col_sum = [13, 20, 22, 28, 30, 36, 35, 39, 49, 39, 39, math.inf, 23, 32, 23, 17, 13]

    s = State(17, row_sum, col_sum)
    sol = Solution(s)
    sol.depthySolver()