namespace DataPackMC
{
    public enum PositionType
    {
        Absolute,
        Local,
        Relative,
        RelativeX,
        RelativeY,
        RelativeZ,
        RelativeXY,
        RelativeYZ,
        RelativeXZ
    }
    public class Position
    {
        string pos;

        public Position(int x, int y, int z, PositionType type=PositionType.Absolute)
        {
            switch(type)
            {
                case PositionType.Absolute:
                    pos = $"{x} {y} {z}";
                    break;
                case PositionType.Relative:
                    pos = $"~{x} ~{y} ~{z}";
                    break;
                case PositionType.Local:
                    pos = $"^{x} ^{y} ^{z}";
                    break;
                case PositionType.RelativeX:
                    pos = $"~{x} {y} {z}";
                    break;
                case PositionType.RelativeY:
                    pos = $"{x} ~{y} {z}";
                    break;
                case PositionType.RelativeZ:
                    pos = $"{x} {y} ~{z}";
                    break;
                case PositionType.RelativeXY:
                    pos = $"~{x} ~{y} {z}";
                    break;
                case PositionType.RelativeXZ:
                    pos = $"~{x} {y} ~{z}";
                    break;
                case PositionType.RelativeYZ:
                    pos = $"{x} ~{y} ~{z}";
                    break;
            }
        }
        public override string ToString()
        {
            return pos;
        }
    }
}