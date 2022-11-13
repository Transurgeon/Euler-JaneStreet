
#include <iostream>

long rect_count(int n, int m){
    int sum = 0;
    for (int i = 1; i <= n; i++){
        for (int b = 1; b <= m; b++){
            sum += (n+1-i)*(m+1-b);
        }
    }
    return sum;
}

int main() {
    int n = 1;
    int m = 1;
    int sum = 0;
    while (abs(2000000-sum) > 10) {
        int random = rand() % 100;
        if (random != 0){
            m+=1;
        }
        else{
            n+=1;
            m = 1;
            std::cout << "Your n value is being changed to " << n << "\n";
        }
        sum = rect_count(n, m);
    }

    std::cout << "Your rectangle count is : " << sum << "\n";

    std::cout << "Your n value is : " << n << " and your m value is : " << m << "\n";

    std::cout << "Your answer and area is : " << n*m;

    return 0;
}