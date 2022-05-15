namespace BlazorProducts.Client.Features
{
    public class PagingLink
    {
        public PagingLink(string text, int page, bool enabled)
        {
            Text = text;
            Page = page;
            Enabled = enabled;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Active { get; set; }
        public bool Enabled { get; set; }
    }
}
