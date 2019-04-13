def solution(A):
    counters = [False] * (len(A) + 1)
    for value in A:
        if 1 <= value <= len(A) + 1:
            counters[value - 1] = True

    for index in range(len(A) + 1):
        if counters[index] == False:
            return index + 1

print solution([1, 3, 6, 4, 1, 2])

   