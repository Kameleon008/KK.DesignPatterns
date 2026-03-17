using KK.DesignPattern.Observer.EventListeners;

namespace KK.DesignPattern.Observer;

public static class Program
{
    public static void Main()
    {
        var events = new EventManager();
        var editor = new FileEditor(events);

        var loggingListener = new EventListenerLogging();
        var alertsListener = new EventListenerAlerts();

        events.Subscribe(EventType.FileOpened, loggingListener);
        events.Subscribe(EventType.FileSaved, loggingListener);
        events.Subscribe(EventType.FileSaved, alertsListener);

        editor.OpenFile("SomeFile.txt");
        editor.SaveFile("SomeFile.txt");
    }
}