# inefficient
def solution(A):
    count = 0
    P = A[0]
    for index in range(1, len(A)-1):
        for next in range(2, len(A)-1):
            if A[index] < A[next]:
                count +=1
    return count


print solution([-1,6,3,4,7,4])