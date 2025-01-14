namespace Api;

public class SharedData
{
    public static class Roles
    {
        public static string Admin = "admin";
        public static string Consumer = "consumer";
        public static IReadOnlyList<string> AllRoles
        {
            get => new List<string>() { Admin, Consumer };
        }
    }
}
