using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class hotel
{
    private List<room> rooms;
    private List<Reservation> reservations;

   public string roomsFile = "C:\\Users\\ibrah\\VsCode\\New folder\\MCV-tasks\\MCV\\Csharp\\Fourthcs\\Hotel\\obj\\rooms.json";
    public string reservationsFile = "C:\\Users\\ibrah\\VsCode\\New folder\\MCV-tasks\\MCV\\Csharp\\Fourthcs\\Hotel\\obj\\reservations.json";

    public hotel()
    {
        rooms = LoadFromJson<room>(roomsFile) ?? new List<room>();
        reservations = LoadFromJson<Reservation>(reservationsFile) ?? new List<Reservation>();
    }

    public void AddRoom(Ihotel room)
    {
        rooms.Add((room)room);
        SaveToJson(roomsFile, rooms);
    }

    public bool MakeReservation(Iguest guest, string date)
    {
        foreach (var room in rooms)
        {
            if (room.IsAvailable && room.Capacity >= guest.NumberOfGuests)
            {
                room.IsAvailable = false;
                var reservation = new Reservation((guest)guest, room, date);
                reservations.Add(reservation);

                SaveToJson(roomsFile, rooms);
                SaveToJson(reservationsFile, reservations);

                Console.WriteLine($"Reserved {guest.Name} in Room {room.RoomNumber}");
                return true;
            }
        }

        Console.WriteLine($" No available room for {guest.Name}");
        return false;
    }

    public void ViewReservations()
    {
        Console.WriteLine("\n Reservations:");
        foreach (var res in reservations)
        {
            Console.WriteLine($"-Guest: {res.Guest.Name}  Room :{res.Room.RoomNumber} date: {res.Date}");
        }
    }




   private List<T> LoadFromJson<T>(string file)
{
    if (!File.Exists(file))
    {
        Console.WriteLine($"[!] File not found: {file}");
        return null;
    }

    try
    {
        string json = File.ReadAllText(file);
        return JsonSerializer.Deserialize<List<T>>(json);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[!] Failed to load JSON: {ex.Message}");
        return null;
    }
}


    private void SaveToJson<T>(string file, List<T> data)
    {
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(file, json);
    }


     public void ViewAvailableRooms()
{

    var loadedRooms = LoadFromJson<room>(roomsFile) ?? new List<room>();
    Console.WriteLine("\nAvailable Rooms:");
    foreach (var r in loadedRooms)
    {
        if (r.IsAvailable)
            Console.WriteLine($"- Room {r.RoomNumber} (Capacity: {r.Capacity})");
    }
}


}

