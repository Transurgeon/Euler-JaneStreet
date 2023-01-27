// Code for the Jane Street monthly puzzle - January 2022

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
using namespace std;

vector<int> get_backward_sequence(int a, int b, int c)
{   
    vector<int> sequence;
    if ((a + b + c) % 2 == 1) {
        sequence.push_back(3 * a - b - c);
        sequence.push_back(2 * a - 2 * b);
        sequence.push_back(a - b - c);
        return sequence;
    }
    else {
        sequence.push_back((3 * a - b - c)/2);
        sequence.push_back(a - b);
        sequence.push_back((a - b - c)/2);
        return sequence;
    }
}

void get_congruence_with_0(int a, int b, int c, int d)
{
    // find smallest value between a, b, c, d
    int smallest = a;
    if (b < smallest)
        smallest = b;
    if (c < smallest)
        smallest = c;
    if (d < smallest)    
        smallest = d;
    // subtract smallest from all values
    a -= smallest;
    b -= smallest;
    c -= smallest;
    d -= smallest;

    std::cout << "a: " << a << " b: " << b << " c: " << c << " d: " << d << "\n";
}

int get_number_of_squares(int a, int b, int c, int d, int iterations)
{   
    if (a == 0 && b == 0 && c == 0 && d == 0)
        return 1;

    int e = abs(a - b);
    int f = abs(b - c);
    int g = abs(c - d);
    int h = abs(d - a);

    std::cout << "e: " << e << " f: " << f << " g: " << g << " h: " << h << "\n"; 
    //get_congruence_with_0(e, f, g, h);
    return get_number_of_squares(e, f, g, h, iterations + 1) + 1;
}

int main()
{   
    int a = 1, b = 0, c = 0;
    while (a < 10000000) {
        std::cout << "a: " << a << " b: " << b << " c: " << c << " d: " << 0 << "\n";
        std::cout << get_number_of_squares(a, b, c, 0, 1) << "\n";
        vector<int> sequence = get_backward_sequence(a, b, c);
        a = sequence[0];
        b = sequence[1];
        c = sequence[2];
    }
    return 0;
}