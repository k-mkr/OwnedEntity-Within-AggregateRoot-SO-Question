namespace ConsoleApp1
{
    internal class DocumentVersion
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Version { get; set; } = "1.0.0.0";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DocumentVersion Clone()
        {
            return new DocumentVersion
            {
                Id = Id,
                Version = Version,
                CreatedDate = CreatedDate,
            };
        }
    }
}
