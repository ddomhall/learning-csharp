namespace TimCoreyCourse.ClassLibrary.AccessModifiers
{
    public class AccessModifierTest
    {
        public bool Public { get; set; }
        private bool _private { get; set; }
        public bool Private
        {
            get { return _private; }
            set { _private = value; }
        }

        internal bool _internal { get; set; }
        protected bool _protected { get; set; }
    }
}
