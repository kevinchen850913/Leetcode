public class ParkingSystem
{
    int[] nums;
    public ParkingSystem(int big, int medium, int small)
    {
        nums = new int[] { 0, big, medium, small };
    }

    public bool AddCar(int carType)
    {
        if (nums[carType] > 0)
        {
            nums[carType]--;
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */