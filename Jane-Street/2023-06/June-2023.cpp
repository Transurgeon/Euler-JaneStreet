// code for the June 2023 Jane Street puzzle

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
#include <queue>
using namespace std;

typedef std::array<std::array<int, 5>, 5> grid;
//typedef std::vector<int> column_gcd;
//typedef std::vector<int> row_gcd;

const std::vector<int> col_gcds = {1, 1, 5, 4};
const std::vector<int> row_gcds = {5, 3, 123, 1};
const 

const std::vector<int> big_col_gcds = {5, 1, 6, 1, 8, 1, 22, 7, 8};
const std::vector<int> big_row_gcds = {55, 1, 6, 1, 24, 3, 6, 7, 2};

bool hasFullSubGrid(const std::vector<std::vector<int>>& grid) {
    int numRows = grid.size();
    int numCols = grid[0].size();

    for (int row = 0; row < numRows - 1; ++row) {
        for (int col = 0; col < numCols - 1; ++col) {
            if (grid[row][col] != 0 &&
                grid[row][col + 1] != 0 &&
                grid[row + 1][col] != 0 &&
                grid[row + 1][col + 1] != 0) {
                return true; 
            }
        }
    }
    return false;
}

bool hasConnectedFilledSquares(const std::vector<std::vector<int>>& grid) {
    int numRows = grid.size();
    int numCols = grid[0].size();
    std::vector<std::vector<bool>> visited(numRows, std::vector<bool>(numCols, false));

    // Find the first filled square
    int startRow = -1;
    int startCol = -1;
    for (int row = 0; row < numRows; ++row) {
        for (int col = 0; col < numCols; ++col) {
            if (grid[row][col] > 0) {
                startRow = row;
                startCol = col;
                break;
            }
        }
        if (startRow != -1 && startCol != -1) {
            break;
        }
    }

    if (startRow == -1 || startCol == -1) {
        return false; // No filled squares found
    }

    std::queue<std::pair<int, int>> squaresQueue;
    squaresQueue.push(std::make_pair(startRow, startCol));
    visited[startRow][startCol] = true;

    while (!squaresQueue.empty()) {
        int currentRow = squaresQueue.front().first;
        int currentCol = squaresQueue.front().second;
        squaresQueue.pop();

        // Check adjacent squares
        std::vector<std::pair<int, int>> neighbors = {
            {currentRow - 1, currentCol},
            {currentRow + 1, currentCol},
            {currentRow, currentCol - 1},
            {currentRow, currentCol + 1}
        };

        for (const auto& neighbor : neighbors) {
            int row = neighbor.first;
            int col = neighbor.second;
            if (row >= 0 && row < numRows && col >= 0 && col < numCols && grid[row][col] > 0 && !visited[row][col]) {
                squaresQueue.push(neighbor);
                visited[row][col] = true;
            }
        }
    }

    // Check if there are any unfilled squares left
    for (int row = 0; row < numRows; ++row) {
        for (int col = 0; col < numCols; ++col) {
            if (grid[row][col] == 0 && !visited[row][col]) {
                return false; // There are unfilled squares
            }
        }
    }

    return true; // All squares are filled and connected
}

bool verify_gcd(std::vector<int> col_gcds, std::vector<int> row_gcds, grid g) {

    return false;
}

int main()
{
    int start[5][5] = {
        {0, 0, 5, 4, 1},
        {0, 0, 0, 1, 1},
        {0, 0, 0, 0, 1},
        {0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0}
    };

    return 0;
}