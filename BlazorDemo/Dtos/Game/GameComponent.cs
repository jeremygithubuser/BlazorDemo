using System;

namespace BlazorDemo.Dtos.Game
{
    public abstract class GameComponent
    {
        public Guid Id { get; set; }
        public string Stroke { get; set; }
        public string Fill { get; set; }
    }
}
