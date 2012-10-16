using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.AdaptivePayments.Model;

namespace PayPal.AdaptivePayments 
{
	public partial class AdaptivePaymentsService : BasePayPalService 
	{

		// Service Version
		private const string ServiceVersion = "1.8.1";

		// Service Name
		private const string ServiceName = "AdaptivePayments";
		
		//SDK Name
		private const string SDKName = "sdkname";
	
		//SDK Version
		private const string SDKVersion = "sdkversion";

		public AdaptivePaymentsService() {}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "CancelPreapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest)
	 	{
	 		return CancelPreapproval(cancelPreapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "CancelPreapproval", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(confirmPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "ConfirmPreapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest)
	 	{
	 		return ConfirmPreapproval(confirmPreapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(confirmPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "ConfirmPreapproval", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(convertCurrencyRequest.ToNVPString(string.Empty), ServiceName, "ConvertCurrency", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest)
	 	{
	 		return ConvertCurrency(convertCurrencyRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(convertCurrencyRequest.ToNVPString(string.Empty), ServiceName, "ConvertCurrency", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(executePaymentRequest.ToNVPString(string.Empty), ServiceName, "ExecutePayment", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest)
	 	{
	 		return ExecutePayment(executePaymentRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(executePaymentRequest.ToNVPString(string.Empty), ServiceName, "ExecutePayment", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAllowedFundingSourcesRequest.ToNVPString(string.Empty), ServiceName, "GetAllowedFundingSources", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest)
	 	{
	 		return GetAllowedFundingSources(getAllowedFundingSourcesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAllowedFundingSourcesRequest.ToNVPString(string.Empty), ServiceName, "GetAllowedFundingSources", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "GetPaymentOptions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest)
	 	{
	 		return GetPaymentOptions(getPaymentOptionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "GetPaymentOptions", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(paymentDetailsRequest.ToNVPString(string.Empty), ServiceName, "PaymentDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest)
	 	{
	 		return PaymentDetails(paymentDetailsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(paymentDetailsRequest.ToNVPString(string.Empty), ServiceName, "PaymentDetails", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(payRequest.ToNVPString(string.Empty), ServiceName, "Pay", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PayResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest)
	 	{
	 		return Pay(payRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(payRequest.ToNVPString(string.Empty), ServiceName, "Pay", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PayResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(preapprovalDetailsRequest.ToNVPString(string.Empty), ServiceName, "PreapprovalDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest)
	 	{
	 		return PreapprovalDetails(preapprovalDetailsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(preapprovalDetailsRequest.ToNVPString(string.Empty), ServiceName, "PreapprovalDetails", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(preapprovalRequest.ToNVPString(string.Empty), ServiceName, "Preapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest)
	 	{
	 		return Preapproval(preapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(preapprovalRequest.ToNVPString(string.Empty), ServiceName, "Preapproval", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(refundRequest.ToNVPString(string.Empty), ServiceName, "Refund", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RefundResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest)
	 	{
	 		return Refund(refundRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(refundRequest.ToNVPString(string.Empty), ServiceName, "Refund", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RefundResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(setPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "SetPaymentOptions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest)
	 	{
	 		return SetPaymentOptions(setPaymentOptionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(setPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "SetPaymentOptions", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getFundingPlansRequest.ToNVPString(string.Empty), ServiceName, "GetFundingPlans", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest)
	 	{
	 		return GetFundingPlans(getFundingPlansRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getFundingPlansRequest.ToNVPString(string.Empty), ServiceName, "GetFundingPlans", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAvailableShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetAvailableShippingAddresses", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest)
	 	{
	 		return GetAvailableShippingAddresses(getAvailableShippingAddressesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAvailableShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetAvailableShippingAddresses", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetShippingAddresses", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest)
	 	{
	 		return GetShippingAddresses(getShippingAddressesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetShippingAddresses", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getUserLimitsRequest.ToNVPString(string.Empty), ServiceName, "GetUserLimits", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest)
	 	{
	 		return GetUserLimits(getUserLimitsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getUserLimitsRequest.ToNVPString(string.Empty), ServiceName, "GetUserLimits", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	}
}
