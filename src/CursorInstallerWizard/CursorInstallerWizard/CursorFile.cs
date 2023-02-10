namespace CursorInstallerWizard
{
    internal class CursorFile
    {
        public string FName { get; set; }
        public string FPath { get; set; }
        public string CursorName { get; set; }
        public System.Drawing.Icon Icon { get; set; }

        public override string ToString()
        {
            return "[FName: " + FName + ", CursorName: " + CursorName + ", FPath: " + FPath + "]";
        }
    }
}