namespace StoreManager.Tests
{
    public sealed class SingleTon
    {
        public static volatile SingleTon _instances;
        private int _numberOfInstance = 0;

        private SingleTon()
        {
            _numberOfInstance++;
        }

        public static SingleTon Instance
        {
            get
            {
                if (_instances == null)
                {
                    _instances = new SingleTon();
                }
                return _instances;
            }
        }

        public bool CheckInstance()
        {
            if (_numberOfInstance == 0)
                return false;
            else
                return true;
        }
        public void CleareInstance()
        {
            _numberOfInstance = 0;
        }
    }
}
