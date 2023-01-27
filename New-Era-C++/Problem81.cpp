
#include <iostream>
#include <fstream>
#include <vector>
using namespace std;

int main() {
    
    // Create a text string, which is used to output the text file
    string myText;

    // Read from the text file
    ifstream MyReadFile("p081_matrix.txt");

    // Use a while loop together with the getline() function to read the file line by line
    while (getline (MyReadFile, myText)) {
    // Output the text from the file
    // cout << myText;
    }

    // Close the file
    MyReadFile.close();

    // initialising the example 5 by 5 grid
    int grid[5][5] = {
        {131, 673, 234, 103, 18},
        {201, 96, 342, 965, 150},
        {630, 803, 746, 422, 111},
        {537, 699, 497, 121, 956},
        {805, 732, 524, 37, 331},
    };

    return 0;
}