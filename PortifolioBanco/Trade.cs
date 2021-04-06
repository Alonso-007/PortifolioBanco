namespace PortifolioBanco
{
    public class Trade : ITrade
    {
        public override string ToString()
        {
            return $@"Value = {Value}; ClientSector = {ClientSector}";
        }

        private double value;
        public double Value 
        { 
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        private string clientSector;
        public string ClientSector 
        {
            get
            {
                return this.clientSector;
            }
            set 
            {
                this.clientSector = value;
            }
        }
    }
}