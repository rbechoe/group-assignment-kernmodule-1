using UnityEngine;
using System.Collections.Generic;

// basic event system that takes no argument
public static class EventSystem
{
    // contains a dictionary of listeners and actions
    private static Dictionary<EventType, System.Action> eventDictionary = new Dictionary<EventType, System.Action>();

    // add new listener with action to dictionary
    public static void AddListener(EventType type, System.Action function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }

        eventDictionary[type] += (function);
    }

    // remove listener with action from dictionary
    public static void RemoveListener(EventType type, System.Action function)
    {
        if (eventDictionary.ContainsKey(type))
        {
            eventDictionary[type] -= (function);
        }
    }

    // execute event for all those listening
    public static void InvokeEvent(EventType type)
    {
        if (eventDictionary.ContainsKey(type))
        {
            eventDictionary[type]?.Invoke();
        }
    }
}

// basic event system that takes an argument
public static class EventSystem<T>
{
    // contains a dictionary of listeners and actions
    private static Dictionary<EventType, System.Action<T>> eventDictionary = new Dictionary<EventType, System.Action<T>>();

    // add new listener with action to dictionary
    public static void AddListener(EventType type, System.Action<T> function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }

        eventDictionary[type] += (function);
    }

    // remove listener with action from dictionary
    public static void RemoveListener(EventType type, System.Action<T> function)
    {
        if (eventDictionary.ContainsKey(type))
        {
            eventDictionary[type] -= (function);
        }
    }

    // execute event for all those listening
    public static void InvokeEvent(EventType type, T param)
    {
        if (eventDictionary.ContainsKey(type))
        {
            eventDictionary[type]?.Invoke(param);
        }
    }
}