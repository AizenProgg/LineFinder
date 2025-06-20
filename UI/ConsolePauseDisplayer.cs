namespace LineFinder.UI
{
    internal static class ConsolePauseDisplayer
    {
        public static void WaitForKeyPress()
        {
            Console.Write("\nAny button to continue...\n");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
