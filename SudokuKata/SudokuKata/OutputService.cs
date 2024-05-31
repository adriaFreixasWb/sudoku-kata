namespace SudokuKata
{
    public static class OutputService
    {
        public static string Text { get; private set; } = string.Empty;
        public static void WriteLine(string text="") =>
            Text+=("\r\n"+text);
        public static void WriteLine(string template, params object[] args)=>
            WriteLine(string.Format(template, args));

    }
}
