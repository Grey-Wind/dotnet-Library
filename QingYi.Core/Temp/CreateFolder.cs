namespace QingYi.Core.Temp
{
    public class CreateFolder
    {
        public static void Create(string newFolderName)
        {
            Folder.Create.CreateFolder(newFolderName, GetTempFolder.Get());
        }
    }
}
