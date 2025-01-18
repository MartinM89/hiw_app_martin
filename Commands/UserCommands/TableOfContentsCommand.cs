public class TableOfContentsCommand : Command
{
    public TableOfContentsCommand(GetServices getServices)
        : base(
            "content",
            "Content",
            "Shows a table of contents of a product <conten [product id]>",
            false,
            getServices
        ) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
