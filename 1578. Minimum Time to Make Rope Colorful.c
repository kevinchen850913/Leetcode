int minCost(char* colors, int* neededTime, int neededTimeSize) {
    int rt = 0;
    for (int i = 1; i < neededTimeSize; i++)
    {
        if (*(colors + i) == *(colors + i - 1))
        {
            if (*(neededTime + i) >= *(neededTime + i - 1))
            {
                rt += *(neededTime + i - 1);
            }
            else
            {
                rt += *(neededTime + i);
                *(neededTime + i) = *(neededTime + i - 1);
            }
        }
    }
    return rt;
}