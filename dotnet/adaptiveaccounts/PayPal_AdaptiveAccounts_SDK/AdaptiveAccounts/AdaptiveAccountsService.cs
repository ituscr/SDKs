using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.AdaptiveAccounts.Model;

namespace PayPal.AdaptiveAccounts 
{
	public partial class AdaptiveAccountsService : BasePayPalService 
	{

		// Service Version
		private const string ServiceVersion = "1.0.3";

		// Service Name
		private const string ServiceName = "AdaptiveAccounts";
		
		//SDK Name
		private const string SDKName = "sdkname";
	
		//SDK Version
		private const string SDKVersion = "sdkversion";

		public AdaptiveAccountsService() {}

		/**	
          * Coutries Supported:
          *     AU - Australia
          *     CA - Canada
          *     CY - Cyprus
          *     CZ - Czech Republic
          *     DK - Denmark
          *     EE - Estonia
          *     FI - Finland
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HU - Hungary
          *     IT - Italy
          *     LV - Latvia
          *     LT - Lithuania
          *     LU - Luxembourg
          *     MT - Malta
          *     NL - Netherlands
          *     PL - Poland
          *     PT - Portugal
          *     SK - Slovak Republic
          *     SI - Slovenia
          *     ES - Spain
          *     SE - Sweden
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createAccountRequest.ToNVPString(string.Empty), ServiceName, "CreateAccount", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * Coutries Supported:
          *     AU - Australia
          *     CA - Canada
          *     CY - Cyprus
          *     CZ - Czech Republic
          *     DK - Denmark
          *     EE - Estonia
          *     FI - Finland
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HU - Hungary
          *     IT - Italy
          *     LV - Latvia
          *     LT - Lithuania
          *     LU - Luxembourg
          *     MT - Malta
          *     NL - Netherlands
          *     PL - Poland
          *     PT - Portugal
          *     SK - Slovak Republic
          *     SI - Slovenia
          *     ES - Spain
          *     SE - Sweden
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
	 	{
	 		return CreateAccount(createAccountRequest,(string) null);
	 	}
	 	
	 	/**	
          * Coutries Supported:
          *     AU - Australia
          *     CA - Canada
          *     CY - Cyprus
          *     CZ - Czech Republic
          *     DK - Denmark
          *     EE - Estonia
          *     FI - Finland
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HU - Hungary
          *     IT - Italy
          *     LV - Latvia
          *     LT - Lithuania
          *     LU - Luxembourg
          *     MT - Malta
          *     NL - Netherlands
          *     PL - Poland
          *     PT - Portugal
          *     SK - Slovak Republic
          *     SI - Slovenia
          *     ES - Spain
          *     SE - Sweden
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(createAccountRequest.ToNVPString(string.Empty), ServiceName, "CreateAccount", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     CA - Canada
          *     CZ - Czech Republic
          *     EU - European Union *
          *     FR - France
          *     DE - Germany
          *     GB - Great Britain
          *     GR - Greece
          *     IE - Ireland
          *     IL - Israel
          *     IT - Italy
          *     JP - Japan
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     US - United States
          *     * technically a group of countries
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getUserAgreementRequest.ToNVPString(string.Empty), ServiceName, "GetUserAgreement", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     CA - Canada
          *     CZ - Czech Republic
          *     EU - European Union *
          *     FR - France
          *     DE - Germany
          *     GB - Great Britain
          *     GR - Greece
          *     IE - Ireland
          *     IL - Israel
          *     IT - Italy
          *     JP - Japan
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     US - United States
          *     * technically a group of countries
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest)
	 	{
	 		return GetUserAgreement(getUserAgreementRequest,(string) null);
	 	}
	 	
	 	/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     CA - Canada
          *     CZ - Czech Republic
          *     EU - European Union *
          *     FR - France
          *     DE - Germany
          *     GB - Great Britain
          *     GR - Greece
          *     IE - Ireland
          *     IL - Israel
          *     IT - Italy
          *     JP - Japan
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     US - United States
          *     * technically a group of countries
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getUserAgreementRequest.ToNVPString(string.Empty), ServiceName, "GetUserAgreement", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getVerifiedStatusRequest.ToNVPString(string.Empty), ServiceName, "GetVerifiedStatus", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest)
	 	{
	 		return GetVerifiedStatus(getVerifiedStatusRequest,(string) null);
	 	}
	 	
	 	/**	
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getVerifiedStatusRequest.ToNVPString(string.Empty), ServiceName, "GetVerifiedStatus", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     CA - Canada
          *     FR - France
          *     DE - Germany
          *     IL - Israel
          *     IT - Italy
          *     NL - Netherlands
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addBankAccountRequest.ToNVPString(string.Empty), ServiceName, "AddBankAccount", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     CA - Canada
          *     FR - France
          *     DE - Germany
          *     IL - Israel
          *     IT - Italy
          *     NL - Netherlands
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest)
	 	{
	 		return AddBankAccount(addBankAccountRequest,(string) null);
	 	}
	 	
	 	/**	
          * Countries Supported:
          *     AU - Australia
          *     CA - Canada
          *     FR - France
          *     DE - Germany
          *     IL - Israel
          *     IT - Italy
          *     NL - Netherlands
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addBankAccountRequest.ToNVPString(string.Empty), ServiceName, "AddBankAccount", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addPaymentCardRequest.ToNVPString(string.Empty), ServiceName, "AddPaymentCard", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest)
	 	{
	 		return AddPaymentCard(addPaymentCardRequest,(string) null);
	 	}
	 	
	 	/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addPaymentCardRequest.ToNVPString(string.Empty), ServiceName, "AddPaymentCard", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(setFundingSourceConfirmedRequest.ToNVPString(string.Empty), ServiceName, "SetFundingSourceConfirmed", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest)
	 	{
	 		return SetFundingSourceConfirmed(setFundingSourceConfirmedRequest,(string) null);
	 	}
	 	
	 	/**	
          * To be updated.
          *    Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(setFundingSourceConfirmedRequest.ToNVPString(string.Empty), ServiceName, "SetFundingSourceConfirmed", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(checkComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "CheckComplianceStatus", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest)
	 	{
	 		return CheckComplianceStatus(checkComplianceStatusRequest,(string) null);
	 	}
	 	
	 	/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(checkComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "CheckComplianceStatus", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *    Supported FinancialProduct: PayPal netSpend Master
          *Prepaid Card
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addPartnerFinancialProductRequest.ToNVPString(string.Empty), ServiceName, "AddPartnerFinancialProduct", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddPartnerFinancialProductResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *    Supported FinancialProduct: PayPal netSpend Master
          *Prepaid Card
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest)
	 	{
	 		return AddPartnerFinancialProduct(addPartnerFinancialProductRequest,(string) null);
	 	}
	 	
	 	/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *    Supported FinancialProduct: PayPal netSpend Master
          *Prepaid Card
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(addPartnerFinancialProductRequest.ToNVPString(string.Empty), ServiceName, "AddPartnerFinancialProduct", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return AddPartnerFinancialProductResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          * To Activate POS - For a POC - Internal Purposes
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(activateProductRequest.ToNVPString(string.Empty), ServiceName, "ActivateProduct", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ActivateProductResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          * To Activate POS - For a POC - Internal Purposes
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest)
	 	{
	 		return ActivateProduct(activateProductRequest,(string) null);
	 	}
	 	
	 	/**	
          * To Activate POS - For a POC - Internal Purposes
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(activateProductRequest.ToNVPString(string.Empty), ServiceName, "ActivateProduct", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ActivateProductResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	}
}
