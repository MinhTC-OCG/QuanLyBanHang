namespace DTO
{
    public class TrinhDo_DTO
    {
        string MaTD_, TenTD;

        public TrinhDo_DTO()
        {
        }

        public TrinhDo_DTO(string maTD_, string tenTD)
        {
            MaTD_ = maTD_;
            TenTD = tenTD;
        }

        public string MaTD_1 { get => MaTD_; set => MaTD_ = value; }
        public string TenTD1 { get => TenTD; set => TenTD = value; }
    }
}
