#include <random>
#include <iostream>
using namespace std;

void play_single() {
    random_device rd; 
    mt19937 gen(rd()); 
    uniform_real_distribution<> dis(0,1.0);
    std::cout << "Hello, welcome to blackjack on the real number line" << std::endl;
    float x = dis(gen);
    std::cout << "Your starting value is: " << x << std::endl;
    std::cout << "Would you like to hit(1) or stay(0)?" << std::endl;
    bool answer;
    std::cin >> answer;
    while (answer) {
        std::cout << "You chose to hit" << std::endl;
        x += dis(gen);
        std::cout << "Your new value is: " << x << std::endl;
        if (x > 1.0) {
            std::cout << "You busted!" << std::endl;
            break;
        }
        std::cout << "Would you like to hit(1) or stay(0)?" << std::endl;
        std::cin >> answer;
    }
}

void average_bust(int n) {
    random_device rd; 
    mt19937 gen(rd()); 
    uniform_real_distribution<> dis(0,1.0);
    vector<int> busts(20, 0);
    float sum = 0;
    for (int i = 0; i < n; i++) {
        float x = dis(gen);
        int count = 0;
        while (x < 1.0) {
            x += dis(gen);
            count++;
        }
        busts[count]++;
    }
    for (int i = 0; i < 20; i++) {
        sum += (float)busts[i]/n;
        std::cout << std::fixed << "Average busts after " << i << " hits: " << sum << std::endl;
    }
}

void average_bust_below50(int n) {
    random_device rd; 
    mt19937 gen(rd()); 
    uniform_real_distribution<> dis(0,1.0);
    vector<int> busts(15, 0);
    int denom = 0;
    float sum = 0;
    for (int i = 0; i < n; i++) {
        float x = dis(gen);
        int count = 0;
        if (x < 0.5) {
            denom++;
            while (x < 1) {
                x += dis(gen);
                count++;
            }
        }
        if (count != 0) {
            busts[count]++;
        }
    }
    for (int i = 0; i < 15; i++) {
        sum += (float)busts[i]/denom;
        std::cout << std::fixed << "Average busts after " << i << " hits: " << sum << std::endl;
    }
}

int main()
{
    play_single();
    //average_bust(10000000);
    //average_bust_below50(1000000);
    return 0;
}