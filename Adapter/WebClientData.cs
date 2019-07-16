namespace Adapter
{
    public class WebClientData
    {
        public string Name;
        public int ID;
        private string IP;
        private bool SSL;

        public WebClientData(string name, int iD, string iP, bool sSL)
        {
            Name = name;
            ID = iD;
            IP = iP;
            SSL = sSL;
        }

    }
}