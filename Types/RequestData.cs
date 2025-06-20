namespace LineFinder.Types
{
    public class UserRequestData
    {
        private string path;
        private string lineText;

        public string Path { get { return path; } }
        public string LineText {  get { return lineText; } }
        public bool IsValidInput { get { return !(string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(lineText)); } }

        public void Parse()
        {
            Console.Write("Directory: ");
            path = Console.ReadLine();

            Console.Write("Text: ");
            lineText = Console.ReadLine();
        }
    }
}
