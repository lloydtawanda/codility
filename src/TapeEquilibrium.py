def solution(A):
    # write your code in Python 2.7
    if len(A) == 0:
        return A

    h = A[0]
    t = sum(A[1:])    
    s = abs(h - t)
    for index in range(1, len(A)-1):
        h += A[index]
        t -= A[index]
        if(abs(h - t) < s):
            s = abs(h - t)
    return s


print solution([3,1,2,4,3])