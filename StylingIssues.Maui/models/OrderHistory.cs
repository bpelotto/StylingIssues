using System;
namespace StylingIssues.Maui.models
{

        public class OrderHistory
        {
            public double? Total { get; set; }

            public double? AmountPaid { get; set; }

            public string Type { get; set; }

            public string CcProcessorInvoiceId { get; set; }

            public string CcProcessorChargeId { get; set; }

            public DateTime? PaidOn { get; set; }

            public DateTime? CreatedOn { get; set; }

            public string ReceiptURL { get; set; }

            public string InvoiceItemsURL { get; set; }
        }
}

