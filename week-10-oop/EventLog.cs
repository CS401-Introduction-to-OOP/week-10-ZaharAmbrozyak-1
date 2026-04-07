using System.Collections;

namespace week_10_oop;

public class EventLog : IEnumerable<GameEvent>
{
    private List<GameEvent> _events;

    public EventLog()
    {
        _events = [];
    }
    public IEnumerator<GameEvent> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}