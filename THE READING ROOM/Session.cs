namespace THE_READING_ROOM;

public static class Session
{
    private sealed record Account(string Password, string Role);
    private static readonly Dictionary<string, Account> Accounts = new(StringComparer.OrdinalIgnoreCase)
    {
        ["admin"] = new Account("admin123", "Admin"),
        ["cashier"] = new Account("cashier123", "Cashier")
    };

    public static string UserName { get; set; } = "Guest";
    public static string Role { get; set; } = "Cashier";

    public static bool TryLogin(string username, string password)
    {
        if (!Accounts.TryGetValue(username.Trim(), out var account) || account.Password != password)
            return false;
        UserName = username.Trim();
        Role = account.Role;
        return true;
    }

    public static bool RegisterCashier(string username, string password)
    {
        username = username.Trim();
        if (username.Length < 3 || Accounts.ContainsKey(username)) return false;
        Accounts[username] = new Account(password, "Cashier");
        return true;
    }

    public static void Clear()
    {
        UserName = "Guest";
        Role = "Cashier";
    }
}
