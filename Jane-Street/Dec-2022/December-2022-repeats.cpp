// Code for the Jane Street monthly puzzle - December 2022

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
using namespace std;

typedef std::array<std::array<bool, 6>, 6> visitedstate;
typedef std::vector<int> dices;
/*
Simple function that prints the current state of a grid
*/
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
/*
If a number is negative, its modulo value will also be negative. This is not what we want
We simply change it a bit to always return a positive value.
*/
int positive_modulo(int i, int n)
{
    return ((i % n) + n) % n;
}
/*

*/
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
/*

*/
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
/*

*/
void depthSearch(int start_x, int start_y, int grid[6][6], visitedstate visited)
{
    // initialise stack
    stack<pair<int, int> > st;
    st.push(make_pair(start_x, start_y)); 
    stack<int> iter;
    iter.push(1);
    int iterations = 1;
    std::vector<dices> dice_state;
    dices init;
    dice_state.push_back(init);
    // traverse the array whilst the stack isn't empty
    while (!st.empty())
    {
        std::pair<int, int> current = st.top();
        st.pop();

        int row = current.first;
        int col = current.second;
        
        std::cout << "The search is currently on square with value: " << grid[row][col] << "\n";
        
        visited[row][col] = true;

        dices dice_copy = dice_state.back();
        dice_state.pop_back();
        std::cout << "The grid currently looks like this: \n";
        printGrid(grid, visited, 6);

        iterations = iter.top();
        iter.pop();

        if (grid[row][col] == 732) {
            std::cout << "We have reached our desired goal of the upper right blue corner\n";
            break;
        }

        std::cout << "The current iteration value is: " << iterations << "\n";

        stack<std::pair<int, int> > adj = getValid_Adjacent_Squares(row, col, grid, iterations);
        
        bool validPath = false;
        while (!adj.empty())
        {
            std::pair<int, int> valid = adj.top();

            st.push(valid);
            std::cout << "The square with value: " << grid[valid.first][valid.second] << " is congruent with: " << grid[row][col]
                << " on iterations: " << iterations << "\n";
            iter.push(iterations+1);
            std::cout << "Pushing the following value to the iter stack: " << iterations+1 << "\n";
            dice_copy.push_back((grid[valid.first][valid.second] - grid[row][col]) / iterations);
            dice_state.push_back(dice_copy);
            validPath = true;

            adj.pop();
        }
        if (!validPath) {
            std::cout << "The path reached a dead-end and cannot continue, we must backtrack\n";
            std::cout << "------------------------------------------------------------------\n";
        }
        
    }
    dices dice_values = dice_state.back();
    std::cout << "final dice_values = { ";
        for (int i = 0; i < dice_values.size(); i++)
            std::cout << dice_values.at(i) << ", ";
    std::cout << "}; \n";
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

    // fill the values in memory of the visited array to false
    visitedstate visited = {0};
    // print the initial grid
    printGrid(grid, visited, 6);
    // call depthSearch function
    depthSearch(0, 0, grid, visited);
    return 0;
}