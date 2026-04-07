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

    public void AddEvent(GameEvent gameEvent)
    {
        _events.Add(gameEvent);
    }

    public IEnumerable<GameEvent> GetSpecificEvents(EventType specificEventType)
    {
        foreach (var gameEvent in _events)
        {
            if (gameEvent.EventType == specificEventType)
            {
                yield return gameEvent;
            }
        }
    }

    public IEnumerable<GameEvent> GetLastNEvents(int n)
    {
        for (var i = _events.Capacity - 1; i > _events.Capacity - 1 - n; i--)
        {
            yield return _events[i];
        }
    }
}