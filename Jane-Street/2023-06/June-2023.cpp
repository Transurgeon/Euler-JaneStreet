// code for the June 2023 Jane Street puzzle

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
#include <queue>
#include <numeric> // For gcd function
using namespace std;

typedef std::array<std::array<int, 5>, 5> grid;

const std::vector<int> col_gcds = {1, 1, 5, 4};
const std::vector<int> row_gcds = {5, 3, 123, 1};

const std::vector<int> big_col_gcds = {5, 1, 6, 1, 8, 1, 22, 7, 8};
const std::vector<int> big_row_gcds = {55, 1, 6, 1, 24, 3, 6, 7, 2};

int gcd(int a, int b) {
    while (b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

void printGrid(grid g)
{
    for (int i = 0; i < g.size(); i++)
    {
        for (int j = 0; j < g[0].size(); j++)
        {   
            std::cout << g[i][j] << "\t";
        }
        std::cout << "\n";
    }
}

bool hasFullSubGrid(grid g) {
    int numRows = g.size();
    int numCols = g[0].size();

    for (int row = 0; row < numRows - 1; ++row) {
        for (int col = 0; col < numCols - 1; ++col) {
            if (g[row][col] != 0 &&
                g[row][col + 1] != 0 &&
                g[row + 1][col] != 0 &&
                g[row + 1][col + 1] != 0) {
                return true; 
            }
        }
    }
    return false;
}

bool hasConnectedFilledSquares(grid g) {
    int numRows = g.size();
    int numCols = g[0].size();
    std::vector<std::vector<bool>> visited(numRows, std::vector<bool>(numCols, false));

    // Find the first filled square
    int startRow = -1;
    int startCol = -1;
    for (int row = 0; row < numRows; ++row) {
        for (int col = 0; col < numCols; ++col) {
            if (g[row][col] > 0) {
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
            if (row >= 0 && row < numRows && col >= 0 && col < numCols && g[row][col] > 0 && !visited[row][col]) {
                squaresQueue.push(neighbor);
                visited[row][col] = true;
            }
        }
    }

    // Check if there are any filled squares left
    for (int row = 0; row < numRows; ++row) {
        for (int col = 0; col < numCols; ++col) {
            if (g[row][col] > 0 && !visited[row][col]) {
                return false; // There are filled squares
            }
        }
    }

    return true; // All squares are connected
}

bool verify_list_gcd(std::array<int, 5> list, int gcd_target) {
    std::vector<int> concat_ints;
    string str = "";
    for (int i = 0; i < list.size(); ++i) {
        if (list[i] > 0) {
            str += std::to_string(list[i]);
        }
        else {
            if (str == "") {
                continue;
            }
            concat_ints.push_back(std::stoi(str));
            str = "";
        }
    }
    if (!str.empty()) {
        concat_ints.push_back(std::stoi(str));
    }
    concat_ints.push_back(gcd_target);

    int result = concat_ints[0];
    for (int i = 0; i < concat_ints.size(); ++i) {
        result = gcd(result, concat_ints[i]);
    }
    return result == gcd_target;
}

bool verify_grid_gcd(std::vector<int> col_gcds, std::vector<int> row_gcds, grid g) {
    int numRows = g.size();
    int numCols = g[0].size();
    int target_gcd = -1;
    for (int row = 0; row < numRows; ++row) {
        target_gcd = row_gcds[row];
        if (!verify_list_gcd(g[row], target_gcd)) {
            return false;
        }
    }
    return false;
}
 
vector<int> list_multiples(int n, int max) {
    vector<int> multiples;
    for (int i = 1; i <= max; ++i) {
        std::cout << n * i << "\t";
        multiples.push_back(n * i);
    }
    return multiples;
}

int main()
{
    grid start = {0};
    start = {{
        {0, 4, 4, 4, 0},
        {0, 0, 0, 0, 0},
        {0, 4, 4, 4, 0},
        {0, 0, 0, 0, 0},
        {0, 4, 4, 4, 0}
    }};
    printGrid(start);
    std::cout << hasFullSubGrid(start) << std::endl;
    std::cout << hasConnectedFilledSquares(start) << std::endl;
    std::array<int, 5> numbers = {4, 5, 5, 0, 5};
    
    std::cout << verify_list_gcd(numbers, 5) << std::endl;
    list_multiples(3, 30);
    return 0;
}