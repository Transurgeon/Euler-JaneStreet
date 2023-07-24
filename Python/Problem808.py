import math

def get_reverse(x):
    temp = x
    reverse = 0
    while temp > 0:
        reverse = reverse * 10 + temp % 10
        temp //= 10
    return reverse

def is_square_root_prime(x):
    square_root = int(math.sqrt(x))
    if square_root * square_root != x:
        return False
    return is_prime(square_root)

def reversible_sum(count):
    sum_result = 0
    i = 2
    while count > 0:
        square = i * i
        reverse = get_reverse(square)
        if is_prime(i) and reverse != square and is_square_root_prime(reverse):
            sum_result += i
            count -= 1
            print("prime number:", i, "square of prime number:", square)
            print("reverse of prime square:", reverse)
        i += 1
    return sum_result

def is_prime(x):
    if x < 2:
        return False
    for i in range(2, int(math.sqrt(x)) + 1):
        if x % i == 0:
            return False
    return True

if __name__ == "__main__":
    print("Your sum is:", reversible_sum(5))
