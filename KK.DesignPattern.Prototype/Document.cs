namespace KK.DesignPattern.Prototype
{
    internal class Document : IPrototype<Document>
    {
        private string _content = string.Empty;

        private DateTime _createDate = DateTime.Now;
        
        private List<string> _annotations = [];

        public void DisplayContent()
        {
            Console.WriteLine(this._content);
        }

        public void DisplayAnnotations()
        {
            foreach (var annotation in _annotations)
            {
                Console.WriteLine(annotation);
            }
        }

        public void DisplayCreateDate()
        {
            Console.WriteLine(this._createDate.ToString("HH:mm:ss:fff"));
        }

        public void AddContent(string content)
        {
            this._content += $"\n{content}";
        }

        public void AddAnnotation(string annotation)
        {
            this._annotations.Add(annotation);
        }

        public Document Clone()
        {
            // We create instance of the same class so we have access even to private fields
            // In this implementation we do not set _createDate -> clone will have different _createDate
            return new Document
            {
                _annotations = [..this._annotations],
                _content = this._content,
            };
        }

        public Document DeepClone()
        {
            // DeepClone copies all properties it also sets _createDate
            return new Document
            {
                _annotations = [.. this._annotations],
                _content = this._content,
                _createDate = this._createDate,
            };
        }
    }
}
