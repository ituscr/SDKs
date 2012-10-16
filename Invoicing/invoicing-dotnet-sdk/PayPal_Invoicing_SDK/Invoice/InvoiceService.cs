using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.Invoice.Model;

namespace PayPal.Invoice 
{
	public partial class InvoiceService : BasePayPalService 
	{

		// Service Version
		private const string ServiceVersion = "1.6.0";

		// Service Name
		private const string ServiceName = "Invoice";
		
		//SDK Name
		private const string SDKName = "sdkname";
	
		//SDK Version
		private const string SDKVersion = "sdkversion";

		public InvoiceService() {}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest)
	 	{
	 		return CreateInvoice(createInvoiceRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateInvoice", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(sendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "SendInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest)
	 	{
	 		return SendInvoice(sendInvoiceRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(sendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "SendInvoice", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createAndSendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateAndSendInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest)
	 	{
	 		return CreateAndSendInvoice(createAndSendInvoiceRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createAndSendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateAndSendInvoice", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(updateInvoiceRequest.ToNVPString(string.Empty), ServiceName, "UpdateInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest)
	 	{
	 		return UpdateInvoice(updateInvoiceRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(updateInvoiceRequest.ToNVPString(string.Empty), ServiceName, "UpdateInvoice", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getInvoiceDetailsRequest.ToNVPString(string.Empty), ServiceName, "GetInvoiceDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest)
	 	{
	 		return GetInvoiceDetails(getInvoiceDetailsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getInvoiceDetailsRequest.ToNVPString(string.Empty), ServiceName, "GetInvoiceDetails", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CancelInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest)
	 	{
	 		return CancelInvoice(cancelInvoiceRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CancelInvoice", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(searchInvoicesRequest.ToNVPString(string.Empty), ServiceName, "SearchInvoices", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest)
	 	{
	 		return SearchInvoices(searchInvoicesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(searchInvoicesRequest.ToNVPString(string.Empty), ServiceName, "SearchInvoices", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsPaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsPaid", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest)
	 	{
	 		return MarkInvoiceAsPaid(markInvoiceAsPaidRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsPaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsPaid", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsUnpaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsUnpaid", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest)
	 	{
	 		return MarkInvoiceAsUnpaid(markInvoiceAsUnpaidRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsUnpaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsUnpaid", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsRefundedRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsRefunded", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest)
	 	{
	 		return MarkInvoiceAsRefunded(markInvoiceAsRefundedRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(markInvoiceAsRefundedRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsRefunded", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	}
}
