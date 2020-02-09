namespace BlazorDemo.Dtos.Game
{
    public class Text : GameComponent
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Content { get; set; }
        public string FontFamilly { get; set; }
        public double FontSize { get; set; }
        public string TextAnchor { get; set; }
    }
}
