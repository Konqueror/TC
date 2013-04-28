// Task 2.1
Potato potato = new Potato();

if (potato != null)
    if(potato.HasBeenPeeled && !potato.IsRotten)
    {
        Cook(potato);
    }

//Task 2.2
if (InRange(y, minY, maxY) && InRange(y, minY, maxY) && shouldVisitCell)
{
    VisitCell();
}

private static bool InRange(int currentValue, int minValue, int maxValue)
{
    bool inRange = false;
    if (minValue >= currentValue && currentValue <= maxValue)
    {
        inRange = false;
    }
    
    return inRange;
}