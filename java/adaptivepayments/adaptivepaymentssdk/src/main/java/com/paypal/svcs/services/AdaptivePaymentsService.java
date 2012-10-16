package com.paypal.svcs.services;
import java.io.*;
import com.paypal.core.BaseService;
import com.paypal.exception.*;
import com.paypal.core.credential.ICredential;
import com.paypal.core.APICallPreHandler;
import com.paypal.core.NVPUtil;
import com.paypal.core.nvp.NVPAPICallPreHandler;
import com.paypal.svcs.types.ap.CancelPreapprovalRequest;
import com.paypal.svcs.types.ap.CancelPreapprovalResponse;
import com.paypal.svcs.types.ap.ConfirmPreapprovalRequest;
import com.paypal.svcs.types.ap.ConfirmPreapprovalResponse;
import com.paypal.svcs.types.ap.ConvertCurrencyRequest;
import com.paypal.svcs.types.ap.ConvertCurrencyResponse;
import com.paypal.svcs.types.ap.ExecutePaymentRequest;
import com.paypal.svcs.types.ap.ExecutePaymentResponse;
import com.paypal.svcs.types.ap.GetAllowedFundingSourcesRequest;
import com.paypal.svcs.types.ap.GetAllowedFundingSourcesResponse;
import com.paypal.svcs.types.ap.GetPaymentOptionsRequest;
import com.paypal.svcs.types.ap.GetPaymentOptionsResponse;
import com.paypal.svcs.types.ap.PaymentDetailsRequest;
import com.paypal.svcs.types.ap.PaymentDetailsResponse;
import com.paypal.svcs.types.ap.PayRequest;
import com.paypal.svcs.types.ap.PayResponse;
import com.paypal.svcs.types.ap.PreapprovalDetailsRequest;
import com.paypal.svcs.types.ap.PreapprovalDetailsResponse;
import com.paypal.svcs.types.ap.PreapprovalRequest;
import com.paypal.svcs.types.ap.PreapprovalResponse;
import com.paypal.svcs.types.ap.RefundRequest;
import com.paypal.svcs.types.ap.RefundResponse;
import com.paypal.svcs.types.ap.SetPaymentOptionsRequest;
import com.paypal.svcs.types.ap.SetPaymentOptionsResponse;
import com.paypal.svcs.types.ap.GetFundingPlansRequest;
import com.paypal.svcs.types.ap.GetFundingPlansResponse;
import com.paypal.svcs.types.ap.GetAvailableShippingAddressesRequest;
import com.paypal.svcs.types.ap.GetAvailableShippingAddressesResponse;
import com.paypal.svcs.types.ap.GetShippingAddressesRequest;
import com.paypal.svcs.types.ap.GetShippingAddressesResponse;
import com.paypal.svcs.types.ap.GetUserLimitsRequest;
import com.paypal.svcs.types.ap.GetUserLimitsResponse;
import com.paypal.sdk.exceptions.OAuthException;

public class AdaptivePaymentsService extends BaseService{


	// Service Version
	public static final String SERVICE_VERSION = "1.8.1";

	// Service Name
	public static final String SERVICE_NAME = "AdaptivePayments";

	//SDK Name
	private static final String SDK_NAME="sdkname";
	
	//SDK Version
	private static final String SDK_VERSION="sdkversion";

	
	public AdaptivePaymentsService(File configFile) throws IOException {
		initConfig(configFile);
	}		

	public AdaptivePaymentsService(InputStream config) throws IOException {
		initConfig(config);
	}

	public AdaptivePaymentsService(String configFilePath) throws IOException {
		initConfig(configFilePath);
	}



		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public CancelPreapprovalResponse cancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(cancelPreapprovalRequest.toNVPString(), SERVICE_NAME, "CancelPreapproval", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return CancelPreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public CancelPreapprovalResponse cancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return cancelPreapproval(cancelPreapprovalRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public CancelPreapprovalResponse cancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(cancelPreapprovalRequest.toNVPString(), SERVICE_NAME, "CancelPreapproval", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return CancelPreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConfirmPreapprovalResponse confirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(confirmPreapprovalRequest.toNVPString(), SERVICE_NAME, "ConfirmPreapproval", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ConfirmPreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConfirmPreapprovalResponse confirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return confirmPreapproval(confirmPreapprovalRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConfirmPreapprovalResponse confirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(confirmPreapprovalRequest.toNVPString(), SERVICE_NAME, "ConfirmPreapproval", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ConfirmPreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConvertCurrencyResponse convertCurrency(ConvertCurrencyRequest convertCurrencyRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(convertCurrencyRequest.toNVPString(), SERVICE_NAME, "ConvertCurrency", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ConvertCurrencyResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConvertCurrencyResponse convertCurrency(ConvertCurrencyRequest convertCurrencyRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return convertCurrency(convertCurrencyRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ConvertCurrencyResponse convertCurrency(ConvertCurrencyRequest convertCurrencyRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(convertCurrencyRequest.toNVPString(), SERVICE_NAME, "ConvertCurrency", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ConvertCurrencyResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ExecutePaymentResponse executePayment(ExecutePaymentRequest executePaymentRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(executePaymentRequest.toNVPString(), SERVICE_NAME, "ExecutePayment", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ExecutePaymentResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ExecutePaymentResponse executePayment(ExecutePaymentRequest executePaymentRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return executePayment(executePaymentRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public ExecutePaymentResponse executePayment(ExecutePaymentRequest executePaymentRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(executePaymentRequest.toNVPString(), SERVICE_NAME, "ExecutePayment", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return ExecutePaymentResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAllowedFundingSourcesResponse getAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getAllowedFundingSourcesRequest.toNVPString(), SERVICE_NAME, "GetAllowedFundingSources", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetAllowedFundingSourcesResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAllowedFundingSourcesResponse getAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getAllowedFundingSources(getAllowedFundingSourcesRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAllowedFundingSourcesResponse getAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getAllowedFundingSourcesRequest.toNVPString(), SERVICE_NAME, "GetAllowedFundingSources", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetAllowedFundingSourcesResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetPaymentOptionsResponse getPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getPaymentOptionsRequest.toNVPString(), SERVICE_NAME, "GetPaymentOptions", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetPaymentOptionsResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetPaymentOptionsResponse getPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getPaymentOptions(getPaymentOptionsRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetPaymentOptionsResponse getPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getPaymentOptionsRequest.toNVPString(), SERVICE_NAME, "GetPaymentOptions", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetPaymentOptionsResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PaymentDetailsResponse paymentDetails(PaymentDetailsRequest paymentDetailsRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(paymentDetailsRequest.toNVPString(), SERVICE_NAME, "PaymentDetails", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PaymentDetailsResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PaymentDetailsResponse paymentDetails(PaymentDetailsRequest paymentDetailsRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return paymentDetails(paymentDetailsRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PaymentDetailsResponse paymentDetails(PaymentDetailsRequest paymentDetailsRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(paymentDetailsRequest.toNVPString(), SERVICE_NAME, "PaymentDetails", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PaymentDetailsResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PayResponse pay(PayRequest payRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(payRequest.toNVPString(), SERVICE_NAME, "Pay", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PayResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PayResponse pay(PayRequest payRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return pay(payRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PayResponse pay(PayRequest payRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(payRequest.toNVPString(), SERVICE_NAME, "Pay", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PayResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalDetailsResponse preapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(preapprovalDetailsRequest.toNVPString(), SERVICE_NAME, "PreapprovalDetails", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PreapprovalDetailsResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalDetailsResponse preapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return preapprovalDetails(preapprovalDetailsRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalDetailsResponse preapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(preapprovalDetailsRequest.toNVPString(), SERVICE_NAME, "PreapprovalDetails", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PreapprovalDetailsResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalResponse preapproval(PreapprovalRequest preapprovalRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(preapprovalRequest.toNVPString(), SERVICE_NAME, "Preapproval", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalResponse preapproval(PreapprovalRequest preapprovalRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return preapproval(preapprovalRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public PreapprovalResponse preapproval(PreapprovalRequest preapprovalRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(preapprovalRequest.toNVPString(), SERVICE_NAME, "Preapproval", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return PreapprovalResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public RefundResponse refund(RefundRequest refundRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(refundRequest.toNVPString(), SERVICE_NAME, "Refund", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return RefundResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public RefundResponse refund(RefundRequest refundRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return refund(refundRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public RefundResponse refund(RefundRequest refundRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(refundRequest.toNVPString(), SERVICE_NAME, "Refund", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return RefundResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public SetPaymentOptionsResponse setPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(setPaymentOptionsRequest.toNVPString(), SERVICE_NAME, "SetPaymentOptions", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return SetPaymentOptionsResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public SetPaymentOptionsResponse setPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return setPaymentOptions(setPaymentOptionsRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public SetPaymentOptionsResponse setPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(setPaymentOptionsRequest.toNVPString(), SERVICE_NAME, "SetPaymentOptions", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return SetPaymentOptionsResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetFundingPlansResponse getFundingPlans(GetFundingPlansRequest getFundingPlansRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getFundingPlansRequest.toNVPString(), SERVICE_NAME, "GetFundingPlans", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetFundingPlansResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetFundingPlansResponse getFundingPlans(GetFundingPlansRequest getFundingPlansRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getFundingPlans(getFundingPlansRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetFundingPlansResponse getFundingPlans(GetFundingPlansRequest getFundingPlansRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getFundingPlansRequest.toNVPString(), SERVICE_NAME, "GetFundingPlans", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetFundingPlansResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAvailableShippingAddressesResponse getAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getAvailableShippingAddressesRequest.toNVPString(), SERVICE_NAME, "GetAvailableShippingAddresses", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetAvailableShippingAddressesResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAvailableShippingAddressesResponse getAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getAvailableShippingAddresses(getAvailableShippingAddressesRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetAvailableShippingAddressesResponse getAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getAvailableShippingAddressesRequest.toNVPString(), SERVICE_NAME, "GetAvailableShippingAddresses", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetAvailableShippingAddressesResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetShippingAddressesResponse getShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getShippingAddressesRequest.toNVPString(), SERVICE_NAME, "GetShippingAddresses", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetShippingAddressesResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetShippingAddressesResponse getShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getShippingAddresses(getShippingAddressesRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetShippingAddressesResponse getShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getShippingAddressesRequest.toNVPString(), SERVICE_NAME, "GetShippingAddresses", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetShippingAddressesResponse.createInstance(NVPUtil.decode(response), "", -1);
	}
		
	/**	
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetUserLimitsResponse getUserLimits(GetUserLimitsRequest getUserLimitsRequest, String apiUsername) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getUserLimitsRequest.toNVPString(), SERVICE_NAME, "GetUserLimits", apiUsername, getAccessToken(), getTokenSecret());
	    ((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetUserLimitsResponse.createInstance(NVPUtil.decode(response), "", -1);
	 }
	 
	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetUserLimitsResponse getUserLimits(GetUserLimitsRequest getUserLimitsRequest) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	return getUserLimits(getUserLimitsRequest, (String) null);
	 }

	/** 
	 * AUTO_GENERATED
	 * @throws SSLConfigurationException
	 * @throws InvalidCredentialException
	 * @throws UnsupportedEncodingException
	 * @throws IOException
	 * @throws HttpErrorException
	 * @throws InvalidResponseDataException
	 * @throws ClientActionRequiredException
	 * @throws MissingCredentialException
	 * @throws InterruptedException
	 * @throws OAuthException
	 */
	 public GetUserLimitsResponse getUserLimits(GetUserLimitsRequest getUserLimitsRequest, ICredential credential) throws SSLConfigurationException, InvalidCredentialException, UnsupportedEncodingException, IOException, HttpErrorException, InvalidResponseDataException, ClientActionRequiredException, MissingCredentialException, InterruptedException, OAuthException {
	 	APICallPreHandler apiCallPreHandler = null;
		apiCallPreHandler = new NVPAPICallPreHandler(getUserLimitsRequest.toNVPString(), SERVICE_NAME, "GetUserLimits", credential);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkName(SDK_NAME);
		((NVPAPICallPreHandler) apiCallPreHandler).setSdkVersion(SDK_VERSION);
	 	String response = call(apiCallPreHandler);
		return GetUserLimitsResponse.createInstance(NVPUtil.decode(response), "", -1);
	}

}