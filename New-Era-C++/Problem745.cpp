
#include <iostream>

int main() {
    int squares = 10;
    int summands = 100;
    int total = 0;
    for (int i = squares; i > 0; i--) {
        int count = (summands/(i*i));
        total += i * i * count;
        summands -= count;
        std::cout << "square value: " << i*i << " count: " << count << " summands: " << summands << "\n";
    }

    std::cout << "Hello World! " << "Your answer is:" << total;
    return 0;
}