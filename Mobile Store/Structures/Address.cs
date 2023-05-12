namespace Mobile_Store.Structures
{
    #region Address Structure
    /// <summary>
    /// Address DTOs
    /// </summary>
    public struct Address
    {
        public string? State { get; set; }
        public string? City { get; set; }
        public ushort? ZIP_Code { get; set; }
        public string? Country { get; set; }
    }
    #endregion
}