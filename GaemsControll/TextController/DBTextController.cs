using FalloutTQBlazor.DateBase;

namespace FalloutTQBlazor.GaemsControll.TextController
{
    public class DBTextController
    {

        public int Id { get; set; }
        public string? Text { get; set; }
        public string ShortText { get; set; }
        public int[]? SelectionOptions { get; set; }

        public DBTextController(string text,string shortText, int[] selectionOptions)
        {
            Text = text; 
            ShortText = shortText;
            SelectionOptions = selectionOptions;
        }

        public DBTextController(string text, string shortText)
        {
            Text = text;
            ShortText = shortText;
        }

        public DBTextController(string shortText)
        {
            ShortText = shortText;
        }

    }
}
