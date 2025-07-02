hotel hotel = new hotel();
bool running = true;

while (running)
{
    Console.WriteLine("\n Hotel Reservation System");
    Console.WriteLine("1. Add Room");
    Console.WriteLine("2. Make Reservation");
    Console.WriteLine("3. View All Reservations");
    Console.WriteLine("4. View Available Rooms");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter room number: ");
            int roomNum = int.Parse(Console.ReadLine());

            Console.Write("Enter room capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            hotel.AddRoom(new room(roomNum, capacity));
            Console.WriteLine(" Room added successfully.");
            break;

        case "2":
            Console.Write("Enter guest name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of guests: ");
            int numGuests = int.Parse(Console.ReadLine());

            Console.Write("Enter reservation date: ");
            string date = Console.ReadLine();

            Iguest guest = new guest(name, numGuests);
            hotel.MakeReservation(guest, date);
            break;

        case "3":
            hotel.ViewReservations();
            break;

           case "4":
            hotel.ViewAvailableRooms();
            break;
        case "5":
            running = false;
            Console.WriteLine(" Exiting system.");
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}
