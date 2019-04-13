# O(log(N) + N)
def solution(A):
    if len(A) == 1:
        return 0

    S = sorted(A)
    for index in range(0, len(S)-1):
        if S[index] + 1 <> S[index + 1]:
            return 0
    return 1

print solution([1,2])