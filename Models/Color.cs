namespace TristanRoselact1.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public int NumViews { get; set; }
        public int NumVotes { get; set; }
        public int NumComments { get; set; }
        public int NumHearts { get; set; }
        public int Rank { get; set; }
        public DateTime DateCreated { get; set; }
        public string Hex { get; set; } = string.Empty;
        public Rgb RGB { get; set; } = new Rgb();
        public Hsv HSV { get; set; } = new Hsv();
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string BadgeUrl { get; set; } = string.Empty;
        public string ApiUrl { get; set; } = string.Empty;
    }

    public class Rgb
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }

    public class Hsv
    {
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Value { get; set; }
    }
}
