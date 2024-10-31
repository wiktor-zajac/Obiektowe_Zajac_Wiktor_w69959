namespace OOP.Constructions.DTO
{
    internal class CreateConstructionDto
    {
        private BuildMaterialEnum _buildMaterial;

        public CreateConstructionDto(float height, float width, int entrances, BuildMaterialEnum buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            BuildMaterial = buildMaterial;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public BuildMaterialEnum BuildMaterial
        {
            get => _buildMaterial;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _buildMaterial = value;
            }
        }
    }
}
