def solution(N, A):
    counters = [0]*N
    maxcount = 0
    for index in range(0, len(A)):
        print A[index] - 1
        if 1 <= A[index] <= N:
                counters[A[index] - 1] +=1
                if maxcount < counters[A[index] - 1]:
                        maxcount = counters[A[index] - 1]
        else:
                counters = [maxcount]*N
    return counters

print solution(5, [3,4,4,6,1,4,4])