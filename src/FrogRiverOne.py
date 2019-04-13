def solution(X, A):
    pos = [-1]*len(A)
    print pos
    uncovered = X          # Record the number of uncovered position
    for index in range(0,len(A)):
        if pos[A[index]-1] != -1:
            continue
        else:
            pos[A[index]-1] = index
            uncovered -= 1
            if uncovered == 0:
                return index
    return -1

print solution(5, [1,3,1,4,2,3,5,4])