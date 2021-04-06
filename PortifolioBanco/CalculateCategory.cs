namespace PortifolioBanco
{
    public class CalculateCategory : ICalculateCategory
    {
        public string Category(ITrade t)
        {
            if (t.Value < Constantes.VALUERISK && t.ClientSector == "Public")
            {
                return Constantes.LOWRISK;
            }
            else if (t.Value > Constantes.VALUERISK && t.ClientSector == "Public")
            {
                return Constantes.MEDIUMRISK;
            }
            else if (t.Value > Constantes.VALUERISK && t.ClientSector == "Private")
            {
                return Constantes.HIGHRISK;
            }

            return "without parameter";
        }
    }
}