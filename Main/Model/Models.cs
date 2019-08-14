namespace Main
{
    /// <summary>
    /// 返回成功时候
    /// </summary>
    public class Result_Sucess
    {
        /// <summary>
        /// 成功推送的url条数
        /// </summary>
        public int Success { get; set; }
        /// <summary>
        /// 当天剩余的可推送url条数
        /// </summary>
        public int Remain { get; set; }
    }
    /// <summary>
    /// 返回错误时候
    /// </summary>
    public class Result_Error
    {
        /// <summary>
        /// 错误码，与状态码相同
        /// </summary>
        public int Error { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string Message { get; set; }
    }
}
