class Accountant
{
    public static bool AskForBonus(Post worker, int hours)
    {
        return ((int)worker < hours) ? true : false;
    }
}
