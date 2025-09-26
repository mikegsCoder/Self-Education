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
        public const string ZipFileMissingMsg = "Zip archive does not exist. Create it from the Text file.";

        // Empty text message:
        public const string EmptyTextMsg = "Your text is empty. Please write something.";

        // Success messages:
        public const string ReadTextSuccessMsg = "Your text file successfully read.";
        public const string WriteTextSuccessMsg = "Your text successfully saved.";
        public const string AddToZipSuccessMsg = "Your text file successfully added to zip.";
        public const string UnzippedSuccessMsg = "Your text file successfully unzipped.";
    }
}
