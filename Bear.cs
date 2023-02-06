namespace Bear
{
    public static class Bear
    {
        private bool _bearIsInitialized = false;
        public static void Initialize()
        {
            _bearIsInitialized = true;
        }

        internal CheckBearReady()
        {
            if (!_bearIsInitialized)
                Initialize();
            return _bearIsInitialized;
        }
    }
}