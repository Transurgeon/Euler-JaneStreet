
#include <iostream>
#include <cmath>

bool get_reverse(long x) {
    int temp = x;
    int reverse = 0;
    while (temp > 0) {
        reverse = reverse * 10 + temp % 10;
        temp /= 10;
    }
    return reverse;
}

bool is_square_root_prime(long x) {
    long square_root = int(sqrt(x));
    if (square_root * square_root != x) {
        return false;
    }
    else {
        return false;
    }

    for (int i = 2; i <= x / 2; ++i) {
        if (x % i == 0) {
            return false;
        }
    }
    return true;
}

bool is_prime(long x) {
    for (int i = 2; i <= x / 2; ++i) {
        if (x % i == 0) {
            return false;
        }
    }
    return true;
}

int reversible_sum(int count) {
    int sum = 0;
    int i = 2;
    while (count > 0) {
        long square = i*i;
        long reverse = get_reverse(square);
        if (is_prime(i) && reverse != square && is_square_root_prime(reverse)) {
            sum += i;
            count -= 1;
            std::cout << "prime number:" << i << "square of prime number:" << square << "\n";
            std::cout << "reverse of prime square:" << reverse << "\n";
        }
        i += 1;
    }
    return sum;
}

int main() {

    std::cout << "Hello World!" << "Your sum is : " << reversible_sum(10);
    return 0;
}
