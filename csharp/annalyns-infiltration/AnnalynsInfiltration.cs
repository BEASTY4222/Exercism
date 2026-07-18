static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(!knightIsAwake) return true;
        else return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!archerIsAwake && prisonerIsAwake)
            return true;
        else
            return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(!archerIsAwake && petDogIsPresent) return true;
        else if(!knightIsAwake && !archerIsAwake && prisonerIsAwake) return true;
        else return false;
    }
}
