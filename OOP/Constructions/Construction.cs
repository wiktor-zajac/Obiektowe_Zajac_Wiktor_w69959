namespace OOP.Constructions
{
    internal class Construction
    {
        private string _buildMaterial;

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get => _buildMaterial;
            set => ArgumentException.ThrowIfNullOrEmpty(value);
        }
    }
}
