using System;
public class Reservation : IReservation
{
    public Iguest Guest { get; set; }
    public Ihotel Room { get; set; }  

    public string Date { get; set; }



    Iguest IReservation.Guest => Guest;
    Ihotel IReservation.Hotel => Room;

    public Reservation(guest guest, room room, string date)
    {
        Guest = guest;
        Room = room;
        Date = date;
    }
}