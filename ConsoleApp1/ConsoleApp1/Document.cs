namespace ConsoleApp1
{
    internal class Document
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public List<DocumentVersion> Versions { get; set; } = new();

        public DocumentVersion LatestVersion { get; set; }

        public void IncrementVersison()
        {
            DocumentVersion version = new();

            Versions.Add(version);
            LatestVersion = version.Clone();
        }
    }
}
