namespace THE_READING_ROOM;

public static class Session
{
    public static string UserName { get; set; } = "Guest";
    public static string Role { get; set; } = "Cashier";

    public static void Clear()
    {
        UserName = "Guest";
        Role = "Cashier";
    }
}