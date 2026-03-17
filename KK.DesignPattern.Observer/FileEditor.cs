namespace KK.DesignPattern.Observer
{
    internal class FileEditor(EventManager eventManager)
    {
        private string _file = string.Empty;

        public void OpenFile(string name)
        {
            // Some logic of file opening
            this._file = $"Content of file {name}";
            eventManager.Notify(EventType.FileOpened, $"FILE OPENED: {name}");
        }

        public void SaveFile(string name)
        {
            // Some logic of file saving
            eventManager.Notify(EventType.FileSaved, $"FILE SAVED: {name}");
        }
    }
}
