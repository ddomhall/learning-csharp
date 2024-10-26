namespace TimCoreyCourse.ClassLibrary.Models
{
    public class EventTest
    {
        public event EventHandler<string> Event;

        public void TriggerEvent()
        {
            Event?.Invoke(this, "the event was triggered");
        }
    }
}
