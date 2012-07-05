
PayPal Auth Signature
=====================

This is a simple utility jar that allows you to generate third party authorization signature for your API call. 
The signature is computed based on the access token and associated secret obtained from the Permissions API. For more information, please refer to the Permissions API reference guide.


Prerequisites
-------------

   * Java 1.5+

Usage
-----


   import com.paypal.sdk.util.OAuthSignature; 
   import com.paypal.sdk.util.OAuthSignature.HTTPMethod;
   
   
   // Gather inputs required for computing signature   
   String apiUserName = "..._biz_api1.gmail.com"; 
   String apiPassword = "********";    
   String accessToken = "2WhQDDM4..."; 	                 // Obtained from the GetAccessToken API call
   String tokenSecret = "j0YhbTgcy.K5VjpQa7Ru8oM...";    // Obtained from the GetAccessToken API call   
   HTTPMethod httpMethod = OAuthSignature.HTTPMethod.POST;
   String scriptURI = "https://api.sandbox.paypal.com/nvp"; 
   Map queryParams = null;  
   
   // Obtain signature and set this value on the X-PP-AUTHORIZATION header in your outgoing API call
   String signature = OAuthSignature.getFullAuthString(apiUserName, apiPassword, 
           accessToken, tokenSecret, httpMethod, scriptURI, queryParams);
