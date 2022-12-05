// Code for the Jane Street monthly puzzle - December 2022

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
using namespace std;

typedef std::array<std::array<bool, 6>, 6> visitedstate;

void printGrid(int grid[6][6], visitedstate visited, int length)
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {   
            if (visited[i][j] == false)
                std::cout << grid[i][j] << "\t";
            else 
                std::cout << "v \t";
        }
        std::cout << "\n";
    }
}

int positive_modulo(int i, int n)
{
    return ((i % n) + n) % n;
}

bool compare_modulo(int current, int next, int n)
{   
    int first = current % n;
    if (current < 0) 
        first = positive_modulo(current, n);
    int second = next % n;
    if (next < 0)
        second = positive_modulo(next, n); 
    return first == second;
}

stack<std::pair<int, int> > getValid_Adjacent_Squares(int row, int col, int grid[6][6], int iterations)
{
    // initialise stack
    std::stack<std::pair<int, int> > adj;

    if (col != 0 && compare_modulo(grid[row][col], grid[row][col - 1], iterations))
        adj.push(make_pair(row, col-1));

    if (row != 0 && compare_modulo(grid[row][col], grid[row - 1][col], iterations))
        adj.push(make_pair(row - 1, col));

    if (col != 5 && compare_modulo(grid[row][col], grid[row][col + 1], iterations))
        adj.push(make_pair(row, col+1));

    if (row != 5 && compare_modulo(grid[row][col], grid[row + 1][col], iterations))
        adj.push(make_pair(row + 1, col));
    return adj;
}

void depthSearch(int start_x, int start_y, int grid[6][6], visitedstate visited)
{

    bool winningRoute = false;
    int start_iter = 40;
    while (!winningRoute) {
            // initialise stack
        stack<pair<int, int> > st;
        st.push(make_pair(start_x, start_y)); 
        stack<int> iter;
        int iterations = start_iter;
        iter.push(iterations);
        std::vector<int> dice_values;

        std::vector < visitedstate > timeseries;
        timeseries.push_back(visited);
        // traverse the array whilst the stack isn't empty
        while (!st.empty())
        {
            std::pair<int, int> current = st.top();
            st.pop();

            int row = current.first;
            int col = current.second;
            
            std::cout << "The search is currently on square with value: " << grid[row][col] << "\n";
            
            visitedstate copy = timeseries.back();
            timeseries.pop_back();

            copy[row][col] = true;

            std::cout << "The grid currently looks like this: \n";
            printGrid(grid, copy, 6);

            iterations = iter.top();
            iter.pop();

            std::cout << "The current iteration value is: " << iterations << "\n";

            if (grid[row][col] == 5 || grid[row][col] == 77) {
                std::cout << "We have reached our desired goal of the upper right blue corner\n";
                winningRoute = true;
                break;
            }

            stack<std::pair<int, int> > adj = getValid_Adjacent_Squares(row, col, grid, iterations);
            
            bool validPath = false;
            while (!adj.empty())
            {
                std::pair<int, int> valid = adj.top();
                
                if (copy[valid.first][valid.second] == false) {
                    st.push(valid);
                    std::cout << "The square with value: " << grid[valid.first][valid.second] << " is congruent with: " << grid[row][col]
                        << " on iterations: " << iterations << "\n";
                    iter.push(iterations-1);
                    std::cout << "Pushing the following value to the iter stack: " << iterations-1 << "\n";
                    timeseries.push_back(copy);
                    dice_values.push_back((grid[row][col] - grid[valid.first][valid.second]) / iterations);
                    validPath = true;
                }
                adj.pop();
            }
            if (!validPath) {
                std::cout << "The path reached a dead-end and cannot continue, we must backtrack\n";
                std::cout << "------------------------------------------------------------------\n";
            }
            
        }
        std::cout << "dice_values = { ";
            for (int n : dice_values)
                std::cout << n << ", ";
        std::cout << "}; \n";

        std::cout << "This iteration value is unsuccessful, decrementing down to: " << start_iter - 1 << "\n";
        std::cout << "*****************************************************************\n";
        start_iter = start_iter - 1;
    }
}

int main()
{

    // initialising our 6 by 6 grid
    int grid[6][6] = {
        {0, 77, 32, 403, 337, 452},
        {5, 23, -4, 592, 445, 620},
        {-7, 2, 357, 452, 317, 395},
        {186, 42, 195, 704, 452, 228},
        {81, 123, 240, 443, 353, 508},
        {57, 33, 132, 268, 492, 732},
    };

    // initialising another array to keep track of visited squares
    visitedstate visited = {0};

    // fill the values in memory of the visited array to false
    //memset(visited, false, sizeof (visited[0][0] * 36));
    printGrid(grid, visited, 6);
    // call depthSearch function
    depthSearch(5, 5, grid, visited);
    return 0;
}