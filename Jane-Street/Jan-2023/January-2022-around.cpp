// Code for the Jane Street monthly puzzle - January 2022

#include <iostream>
#include <utility>
#include <stack>
#include <vector>
#include <array>
using namespace std;

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
    int CONST_A = 7286424, CONST_B = 8681696, CONST_C = 2, CONST_D = 4719814;
    int a = CONST_A, b = CONST_B, c = CONST_C, d = CONST_D;
    while (iterations < 23) {
        int random = rand() % 1000;
        if (random == 0) {
            std::cout << "resetting now!\n";
            a = CONST_A; b = CONST_B; c = CONST_C; d = CONST_D;
        }
        else {
            int sign = rand() % 2;
            int choice = rand() % 4;
            if (sign == 0) {
                if (choice == 0) {
                    a += 1;
                }
                else if (choice == 1) {
                    b += 1;
                }
                else if (choice == 2) {
                    c += 1;
                }
                else {
                    d += 1;
                }
            }
            else {
                if (choice == 0) {
                    a -= 1;
                }
                else if (choice == 1) {
                    b -= 1;
                }
                else if (choice == 2 && c > 0) {
                    c -= 1;
                }
                else {
                    d -= 1;
                }
            }
        }
    std::cout << "a: " << a << " b: " << b << " c: " << c << " d: " << d << "\n";

    iterations = get_number_of_squares(a, b, c, d, 1);
    std::cout << iterations << "\n";
    }
    return 0;
}