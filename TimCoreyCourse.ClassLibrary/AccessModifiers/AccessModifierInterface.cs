namespace TimCoreyCourse.ClassLibrary.AccessModifiers
{
    public class AccessModifierInterface : AccessModifierTest
    {
        public bool Protected
        {
            get { return _protected; }
            set { _protected = value; }
        }

        public bool Internal
        {
            get { return _internal; }
            set { _internal = value; }
        }


    }
}
