﻿namespace study4_be.Services.Request
{
    public class VnPayPaymentRequest
    {
        public required decimal Amount { get; set; }
        public string IpAddr { get; set; }
        public string OrderInfo { get; set; }
        public string OrderType { get; set; }
        public string TxnRef { get; set; }
        public string ExpireDate { get; set; }
    }
}
