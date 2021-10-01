using System.Collections.Generic;

// basic event system that takes no argument
public static class EventSystem
{
    // contains a dictionary of listeners and actions
    private static Dictionary<EventType, System.Action> eventDictionary = new Dictionary<EventType, System.Action>();

    // add new listener with action to dictionary
    public static void AddListener(EventType _type, System.Action _function)
    {
        if (!eventDictionary.ContainsKey(_type))
        {
            eventDictionary.Add(_type, null);
        }

        eventDictionary[_type] += (_function);
    }

    // remove listener with action from dictionary
    public static void RemoveListener(EventType _type, System.Action _function)
    {
        if (eventDictionary.ContainsKey(_type))
        {
            eventDictionary[_type] -= (_function);
        }
    }

    // execute event for all those listening
    public static void InvokeEvent(EventType _type)
    {
        if (eventDictionary.ContainsKey(_type))
        {
            eventDictionary[_type]?.Invoke();
        }
    }
}

// basic event system that takes an argument
public static class EventSystem<T>
{
    // contains a dictionary of listeners and actions
    private static Dictionary<EventType, System.Action<T>> eventDictionary = new Dictionary<EventType, System.Action<T>>();

    // add new listener with action to dictionary
    public static void AddListener(EventType _type, System.Action<T> _function)
    {
        if (!eventDictionary.ContainsKey(_type))
        {
            eventDictionary.Add(_type, null);
        }

        eventDictionary[_type] += (_function);
    }

    // remove listener with action from dictionary
    public static void RemoveListener(EventType _type, System.Action<T> _function)
    {
        if (eventDictionary.ContainsKey(_type))
        {
            eventDictionary[_type] -= (_function);
        }
    }

    // execute event for all those listening
    public static void InvokeEvent(EventType _type, T _param)
    {
        if (eventDictionary.ContainsKey(_type))
        {
            eventDictionary[_type]?.Invoke(_param);
        }
    }
}
