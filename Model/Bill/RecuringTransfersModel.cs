using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object representing an active recuring transfer. 
    /// </summary>
    public class RecuringTransfersModel
    {

        /// <summary>
        /// Date of the next Transfer.
        /// </summary>
        public DateTime NextRecuringDate { get; set; }
        /// <summary>
        /// The identification of the recuring process of a transfer. This is not the transfer identification, but the fact that transfers will be automatically generated. 
        /// </summary>
        public Guid RecuringTransferId { get; set; }
        /// <summary>
        /// The Transfer Frequency enum.
        /// </summary>
        public TransferFrequencyEnum RecuringMode { get; set; }
        /// <summary>
        /// The starting date of the recuring process. This date is used to determine the first transfer and is used based on the recuring mode to determine the next transfer to be created. 
        /// </summary>
        public DateTime RecuringRefDate { get; set; }
        /// <summary>
        /// The date this recuring has been created. 
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// The merchant identification for which transfers will be created. 
        /// </summary>
        public Guid RelatedMerchantId { get; set; }
        /// <summary>
        /// The name of the merchant. This will appear on the customer statement. 
        /// </summary>
        public string RelatedMerchantName { get; set; }
        /// <summary>
        /// The name of the customer for which the transfers will be created. 
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// The customer identification for the created transfers. 
        /// </summary>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// The amount of the recuring transfer. 
        /// </summary>
        public decimal Amount { get; set; }
    }
}
