import math

# This problem will need to create a function that counts the nth integer where the sum of its digits is prime.

def prime_list(high: int, low = 0):
    primes = []
    high = sum_of_digits(high - 1)
    low = sum_of_digits(low)
    for i in range(low, high + 1):
        if is_prime(i):
            primes.append(True)
        else:
            primes.append(False)
    return primes

def is_prime(x: int):
    if x < 2:
        return False
    for i in range(2, int(math.sqrt(x)) + 1):
        if x % i == 0:
            return False
    return True

def sum_of_digits(x: int):
    sum = 0
    while x > 0:
        sum += x % 10
        x //= 10
    return sum
    
def sliding_window(primes: list, order: int, windows: dict = {}):
    if order == 0:
        return windows
    else:
        high = 10
        sums = [sum(primes[:high])]
        for i in range(1, len(primes) - high + 1):
            sums.append(sums[i - 1] - primes[i - 1] + primes[i + high - 1])
        windows[order] = sums
    return sliding_window(sums, order - 1, windows)

def get_nth_sum_digit_prime(n: int, count: int, order: int, low: int = 0):
    high = low + 10 ** order
    primes = prime_list(high, low)
    windows = sliding_window(primes, order + 1)
    new_count = count + windows[1][0]
    if new_count < n:
        return get_nth_sum_digit_prime(n, new_count, order, high)
    elif new_count > n:
        return get_nth_sum_digit_prime(n, count, order - 1, low)
    else:
        return low
    
print(get_nth_sum_digit_prime(int(1e16), 0, 16))
