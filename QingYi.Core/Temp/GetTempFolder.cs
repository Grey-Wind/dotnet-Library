namespace QingYi.Core.Temp
{
    public class GetTempFolder
    {
        public static string Get()
        {
            string tempFolderPath = Path.GetTempPath();
            return tempFolderPath;
        }
    }
}
