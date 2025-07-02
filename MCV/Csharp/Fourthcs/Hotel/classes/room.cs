public class room : Ihotel
{
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; } = true;

    public room(int roomNumber, int capacity)
    {
        RoomNumber = roomNumber;
        Capacity = capacity;
    }
}
