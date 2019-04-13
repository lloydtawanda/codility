def solution(A):
    # write your code in Python 2.7
    if len(A) == 0:
        return A
    s = 1000
    for idx, val in enumerate(A):
        a = sum(A[:idx + 1])
        b = sum(A[idx + 1:])
        v = abs(a - b)
        if(s > v):
            s = v
        #print "a = " + str(a)
        #print "b = " + str(b)
    return s


print solution([3,1,2,4,3])