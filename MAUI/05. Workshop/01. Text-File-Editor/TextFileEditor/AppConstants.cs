namespace TextFileEditor
{
    public static class AppConstants
    {
        // File path and file names:
        public const string FilePath = @"../../../../";
        public const string TxtFileName = FilePath + "TextFile.txt";
        public const string ZipFileName = FilePath + "TextFile.zip";

        // File missing messages:
        public const string TxtFileMissingMsg = "Text file does not exist. Get it from the Zip file.";

        // Success messages:
        public const string ReadTextSuccessMsg = "Your text file successfully read.";
    }
}
