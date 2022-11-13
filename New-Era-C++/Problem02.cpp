// Your First C++ Program

#include <iostream>

int main() {
    
    int f1 = 1;
    int f2 = 2;
    int sum = 0;
    int even_sum = 2;
    while(sum <= 4000000){
        sum = f1 + f2;
        if (sum % 2 == 0){
            even_sum += sum;
        }
        f1=f2;
        f2=sum;
    }
    std::cout << "Hello World!" << "Your counter is:" << even_sum;
    return 0;
}