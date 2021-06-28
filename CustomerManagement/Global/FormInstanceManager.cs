namespace CustomerManagement.Global
{
    public static class FormInstanceManager
    {
        public static Dashboard DashboardSingleton { get; }

        static FormInstanceManager()
        {
            DashboardSingleton = new Dashboard();
        }
    }
}