namespace HistoricalTrails.Permissions;

public static class HistoricalTrailsPermissions
{
    public const string GroupName = "HistoricalTrails";

    public static class HistoricalPlaces
    {
        public const string Default = GroupName + ".HistoricalPlaces";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class Customers
    {
        public const string Default = GroupName + ".Customers";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
