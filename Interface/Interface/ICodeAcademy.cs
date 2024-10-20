namespace Interface.Interface
{
    internal interface ICodeAcademy
    {
        public string CodeEmail
        {
            get; set;
        }
        public abstract string GenerateEmail();

    }
}
