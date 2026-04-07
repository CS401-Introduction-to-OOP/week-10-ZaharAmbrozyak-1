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
        foreach (var gameEvent in _events)
        {
            yield return gameEvent;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}