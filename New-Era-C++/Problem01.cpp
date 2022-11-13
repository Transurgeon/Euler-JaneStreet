// Your First C++ Program

#include <iostream>

long summation(int x){
    return (x * (x+1))/2;
}
int main() {

    int sum = 0;

    sum += 3 * summation(999/3);
    sum += 5 * summation(999/5);
    sum -= 15 * summation(999/15);

    std::cout << "Hello World!" << "Your sum is : " << sum;
    return 0;
}
