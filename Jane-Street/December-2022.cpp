// Code for the Jane Street monthly puzzle - December 2022

#include <iostream>
#include <utility>
#include <stack>
using namespace std;
void printGrid(int grid[6][6], bool visited[6][6], int length)
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

void depthSearch(int start_x, int start_y, int grid[6][6], bool visited[6][6])
{
    // initialise stack
    stack<pair<int, int> > st;
    st.push(make_pair(start_x, start_y)); 

    int iterations = 1;
    int backTrack = 0;
    // traverse the array whilst the stack isn't empty
    while (!st.empty())
    {
        std::pair<int, int> current = st.top();
        st.pop();

        int row = current.first;
        int col = current.second;

        std::cout << "The search is currently on square with value: " << grid[row][col] << "\n";

        visited[row][col] = true;

        std::cout << "This square hasn't been visited before \n";

        std::cout << "Here is the state of the grid before seeing the neighbors \n";
        printGrid(grid, visited, 6);

        if (grid[row][col] == 732) {
            std::cout << "We have reached our desired goal of the upper right blue corner";
            break;
        }
        stack<std::pair<int, int> > adj = getValid_Adjacent_Squares(row, col, grid, iterations);
    
        if (adj.size() > 1)
            backTrack = iterations;

        if (adj.empty())
            iterations = backTrack - 1;

        while (!adj.empty())
        {
            std::pair<int, int> valid = adj.top();

            if (visited[valid.first][valid.second] == false)
                st.push(valid);
                std::cout << "The square with value: " << grid[valid.first][valid.second] << " is congruent with: " << grid[row][col]
                    << " on iterations: " << iterations << "\n";
            adj.pop();
        }
        iterations += 1;
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
    bool visited[6][6];

    // fill the values in memory of the visited array to false
    memset(visited, false, sizeof visited);

    printGrid(grid, visited, 6);

    // call depthSearch function
    depthSearch(0, 0, grid, visited);
    return 0;
}