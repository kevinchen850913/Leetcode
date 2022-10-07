//©U§£¸Ñµª
public class H2O
{
    public int count;
    public H2O()
    {
        count = 0;
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        while (count > 1) { System.Threading.Thread.Sleep(1); }
        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
        count++;
    }

    public void Oxygen(Action releaseOxygen)
    {
        while (count < 2) { System.Threading.Thread.Sleep(1); }
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();
        count -= 2;
    }

}