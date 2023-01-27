// Code for the Jane Street monthly puzzle - January 2022

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
using namespace std;

struct quad
{
    int a;
    int b;
    int c;
    int d;
};

int get_number_of_squares(int a, int b, int c, int d, int iterations)
{   
    if (a == 0 && b == 0 && c == 0 && d == 0)
        return 1;

    int e = abs(a - b);
    int f = abs(b - c);
    int g = abs(c - d);
    int h = abs(d - a);

    //std::cout << "e: " << e << " f: " << f << " g: " << g << " h: " << h << "\n"; 
    return get_number_of_squares(e, f, g, h, iterations + 1) + 1;
}

int main()
{   
    int iterations = 0;
    int CONST_A = 7286422, CONST_B = 8681694, CONST_C = 0, CONST_D = 4719812;
    int a = CONST_A, b = CONST_B, c = CONST_C, d = CONST_D;
    vector<quad> quads;
    while (true) {
        std::cout << "a: " << a << " b: " << b << " c: " << c << " d: " << d << "\n";
        iterations = get_number_of_squares(a, b, c, d, 1);
        std::cout << iterations << "\n";

        if (iterations >= 23) {
            std::cout << "new record!\n";
            break;
        }
        if (iterations == 22) {
            quad new_quad = {a, b, c, d};
            quads.push_back(new_quad);
        }
        if (quads.size() == 10) {
            std::cout << "int CONST_A = " << quads.back().a << ", CONST_B = " << quads.back().b << ", CONST_C = " << quads.back().c << ", CONST_D = " << quads.back().d << ";\n"; 
            break;
        }
        int choice = rand() % 3;
        if (choice == 0) {
            a -= 1;
        }
        else if (choice == 1) {
            b -= 1;
        }
        else {
            d -= 1;
        }
    }
    return 0;
}