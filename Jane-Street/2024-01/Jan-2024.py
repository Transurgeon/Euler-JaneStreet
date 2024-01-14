from typing import List
from collections import defaultdict
from copy import deepcopy
from sorcery import dict_of
import math 

class State:
    def __init__(self, size: int, row_sum: List[int], col_sum: List[int], regions: dict[List[tuple]]):
        self.size = size
        self.grid = [[0] * size for _ in range(size)]
        self.rowSum = row_sum
        self.colSum = col_sum
        self.lastCenters = [(0,0), (0,0)]
        self.regions = regions
        self.regionSum = {}

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
            self.printState()
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
            if self.rowSum[j] < val**2 * 2:
                return False
        for j in range(col, col + val):
            colConst = (self.colSum[j] >= val**2 * 3) and colConst
            if self.colSum[j] < val**2 * 2:
                return False
        if not rowConst and not colConst:
            # print("Invalid Center, row or column sum exceeded")
            return False
        # new constraint for verifying the sum of previous rows
        if row >= 3 and len([s for s in self.rowSum[:row-2] if s == 0]) not in {row-2, row-3}:
            # print("Did not fulfill previous row sum, must backtrack")
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
        count = 0
        s = self.stack[0]
        self.prepare3_shapes(s)
        self.stack.pop(-1)
        s = self.stack[0]
        while self.stack:
            if self.generate2_shapes(s):
                s = self.stack[0]
            else:
                if self.generate1_shapes(s):
                    s = self.stack[0]
                else:
                    if not s.isSolution():
                        s = self.stack.pop(0)
                    else:
                        print("Numbers of iterations: ",  count)
                        return
            count += 1
            if count % 100 == 0:
                self.stack[0].printState()

    def generate2_shapes(self, s):
        row, col = s.lastCenters[1]
        if (row,col) == (s.size - 1, s.size - 1):
            return False
        for i in range(col + 1, s.size):
            if s.validateCenter(Move(1, (row,i), 2)):
                    if self.generateFshapes(s, (row,i), 2) > 0:
                        s.lastCenters[1] = (row, i)
                        self.stack.append(s)
                        return True
        for r in range(row + 1, s.size):
            for c in range(0, s.size):
                if s.validateCenter(Move(1, (r,c), 2)):
                    if self.generateFshapes(s, (r,c), 2) > 0:
                        s.lastCenters[1] = (r, c)
                        self.stack.append(s)
                        return True
        s.lastCenters[1] = (s.size - 1, s.size - 1)
        return False

    def generate1_shapes(self, s): 
        row, col = s.lastCenters[0]
        if (row,col) == (s.size - 1, s.size - 1):
            return False
        for i in range(col + 1, s.size):
            if s.validateCenter(Move(1, (row,i), 1)):
                    if self.generateFshapes(s, (row,i), 1) > 0:
                        s.lastCenters[0] = (row, i)
                        self.stack.append(s)
                        return True
        for r in range(row + 1, s.size):
            for c in range(0, s.size):
                if s.validateCenter(Move(1, (r,c), 1)):
                    if self.generateFshapes(s, (r,c), 1) > 0:
                        s.lastCenters[0] = (r, c)
                        self.stack.append(s)
                        return True
        s.lastCenters[0] = (s.size - 1, s.size - 1)
        return False

    def generateFshapes(self, s, p, val):
        count = 0
        for i in range(1, 9):
            new_s = deepcopy(s)
            m = Move(i, p, val)
            if (new_s.validateF_shape(m)):
                count += 1
                new_s.lastCenters[val-1] = p
                self.stack.insert(0, new_s)
                # new_s.printState()
        return count

    def prepare3_shapes(self, s):
        center1 = [(3, 3)]
        center2 = (11, 8)
        for i in {2}:
            m = Move(i, center2, 3)
            for p in center1:
                new_s = deepcopy(s)
                new_s.validateF_shape(m)
                new_s.validateF_shape(Move(6, p, 3))
                new_s.validateF_shape(Move(2, (4, 9), 2))
                new_s.validateF_shape(Move(1, (3, 13), 2))
                new_s.validateF_shape(Move(6, (10, 4), 2))
                new_s.validateF_shape(Move(7, (9, 13), 2))
                new_s.validateF_shape(Move(1, (1, 15), 1))
                new_s.validateF_shape(Move(3, (1, 4), 1))
                self.stack.insert(0, new_s)

def findAllValidCenters(state: State):
    centers = []
    for i in range(0, state.size):
        for j in range(0, state.size):
            if state.validateCenter(Move(1, (i,j), 3)):
                centers.append((i,j))
    print(len(centers))

def generateRangePoints(p1, p2):
    points = []
    p1_row, p1_col = p1
    p2_row, p2_col = p2
    for i in range(p1_row, p2_row+1):
        for j in range(p1_col, p2_col+1):
            points.append((i, j))
    print(points)

if __name__ == "__main__":
    r1 = [(0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (5, 0), (6, 0), (7, 0), (8, 0),
               (9, 0), (10, 0), (11, 0), (12, 0), (13, 0), (14, 0), (15, 0), (16, 0),
               (16, 1), (16, 2), (16, 3), (16, 4), (16, 5), (0, 1), (1, 1), (1, 2),
               (15, 1), (15, 4), (14, 4), (14, 5)]
    r2 = [(1, 4), (1, 5), (1, 6), (2, 4), (2, 5), (2, 6), (3, 4), (3, 5), (3, 6),
                (0, 2), (0, 3), (1, 3), (3, 3), (4, 3)]
    r5 = [(2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1), 
                (11, 1), (12, 1), (13, 1), (14, 1), (2, 2), (2, 3), (3, 2), (14, 2), 
                (15, 2), (15, 3)]
    r6 = [(6, 3), (6, 4), (6, 5), (4, 2), (5, 2), (5, 3), (5, 5), (7, 4)]
    r13 = [(6, 2), (7, 2), (8, 2), (9, 2), (10, 2), (11, 2), (12, 2), (9, 5),
                (7, 3), (8, 3), (9, 3), (10, 3), (11, 3), (8, 4), (9, 4), (10, 4)]
    r3 = [(0, 4), (0, 5), (0, 6), (0, 7), (0, 8), (0, 9), (1, 7), (1, 8), (1, 9),
                (2, 7), (2, 9), (3, 9)]
    r7 = [(4, 4), (4, 5), (4, 6), (4, 7), (3, 7), (3, 8), (2, 8), (5, 4)]
    r8 = [(5, 6), (5, 7), (5, 8), (6, 6), (6, 7), (6, 8), (7, 5), (7, 6), (8, 5),
                 (8, 6), (4, 8)]
    r16 = [(13, 2), (13, 3), (13, 4), (13, 5), (13, 6), (13, 7), (12, 3), (12, 4),
                 (12, 5), (12, 6), (12, 7), (14, 3), (11, 6), (11, 7), (11, 8), (10, 7), (10, 8)]
    r19 = [(16, 6), (16, 7), (16, 8), (16, 9), (16, 10), (16, 11), 
                (16, 12), (15, 5), (15, 6), (14, 6)]
    r20 = [(15, 7), (15, 8), (15, 9), (15, 10), (15, 11), (15, 12),
                 (15, 13), (14, 12), (14, 13), (16, 13), (13, 9), (14, 9)]
    r17 = [(12, 8), (12, 9), (12, 10), (13, 10), (11, 9), (13, 8), (14, 8), (14, 7)]
    r9 = [(5, 9), (6, 9), (7, 9), (7, 7), (8, 7), (9, 7), (7, 8),
                (9, 6), (10, 6), (10, 5), (11, 5), (11, 4)]
    r10 = [(4, 10), (5, 10), (6, 10), (7, 10), (8, 10), (9, 10), 
                (4, 9), (8, 8), (8, 9), (8, 11), (8, 12), (7, 12), (9, 12)]
    r4 = [(0, 10), (0, 11), (0, 12), (0, 13), (0, 14), (0, 15), (0, 16),
                (1, 16), (2, 16), (3, 16), (4, 16), (1, 15), (1, 10), (2, 10), 
                (3, 10), (3, 11), (4, 11), (5, 11), (6, 11), (7, 11), 
                (2, 12), (3, 12), (4, 12), (5, 12), (6, 12), (2, 13)]
    r11 = [(1, 11), (1, 12), (1, 13), (1, 14), (2, 11), (3, 13), (4, 13),
                (5, 13), (2, 14), (3, 14), (5, 14), (6, 14)]
    r12 = [(5, 16), (6, 16), (7, 16), (8, 16), (9, 16), (10, 16), 
                (11, 16), (12, 16), (13, 16), (14, 16), (15, 16), (16, 16), 
                (2, 15), (3, 15), (4, 15), (5, 15), (6, 15), (7, 15), (8, 15),
                (9, 15), (4, 14), (7, 14), (9, 14), (11, 14), (12, 14), (15, 14),
                (16, 14), (15, 15), (16, 15), (12, 15), (13, 15)]
    r15 = [(6, 13), (7, 13), (8, 13), (9, 13), (10, 13), (10, 11),
                 (10, 12), (10, 14), (10, 15), (8, 14), (9, 11), (11, 15)]
    r14 = [(9, 8), (9, 9), (10, 9), (10, 10), (11, 10), 
                (11, 11), (12, 11), (12, 12)]
    r18 = [(13, 11), (13, 12), (13, 13), (13, 14), (14, 10), (14, 11),
                (14, 14), (14, 15), (11, 12), (11, 13), (12, 13)]

    #row_sum = [3, 9, 10, math.inf, 13, 8, 7, 2]
    #col_sum = [9, 12, 12, 10, 8, 8, math.inf, 2]
    #s = State(8, row_sum, col_sum, {})
    #sol = Solution(s)
    #sol.depthySolver()

    regions = dict_of(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20)

    row_sum = [14, 24, 24, 39, 43, math.inf, 22, 23, 29, 28, 34, 35, 29, 26, 26, 24, 20]
    col_sum = [13, 20, 22, 28, 30, 36, 35, 39, 49, 39, 39, math.inf, 23, 32, 23, 17, 13]

    s = State(17, row_sum, col_sum, regions)
    sol = Solution(s)
    sol.depthySolver()
