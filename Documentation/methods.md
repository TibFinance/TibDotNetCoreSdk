
# Methods

## List Of Methods

* #### Customers
	* [Create a customer](#create-customer).
	* [List all service customers](#list-all-service-customers).
	* [Get a customer detail](#get-a-customer-detail).
	* [List the customers based on external identification](#list-the-customers-based-on-external-identification).
	* [Modify an existing customer](#modify-an-existing-customer).
	* [Delete a customer](#delete-a-customer).

* #### Payment methods
	* [Create bank account payment method](#create-bank-account-payment-method).
	* [Create credit card payment method](#create-credit-card-payment-method).
	* [Create Interac payment method](#create-Interac-payment-method).
	* [Change Interac Payment Method Question and Answer](#change-Interac-Payment-Method-Question-and-Answer)
	* [Get a specific payment method](#get-a-specific-payment-method).
	* [List payment methods](#list-payment-methods)
	* [Change the default payment method of a customer](#change-the-default-payment-method-of-a-customer).
	* [Delete payment method](#delete-payment-method).
	* 
* #### Payments / Transfers
	* [Create Bill](#create-bill).
	* [List Bill](#list-bill).
	* [Get Bill](#get-bill).
	* [Delete Bill](#delete-bill).
	* [Create Payment](#create-payment).
	* [Create Direct Deposit](#create-direct-deposit).
	* [Create Interac Transfer](#create-interac-transfer).
	* [Create from ACP File](#create-from-acp-file).
	* [Create Free Operation](#create-free-operation).
	* [Delete Transfer](#delete-transfer).
	* [Revert Transfer](#revert-transfer).
	* [List Recuring](#list-recuring).
	* [Delete Recuring process](#delete-recuring-process).
	* [Reporting of Operation](#reporting-of-operation)
	* [List Executed Operations](#list-executed-operations).
	* [List Transfers](#list-transfers).
	* [List Transfers Fast](#list-transfers-fast)
	* [List transfers For Bill Fast](#list-transfers-for-bill-fast).

* #### Merchants
	* [Merchant basic information object](#merchant-basic-information-object).
	* [Create new merchant](#create-new-merchant).
	* [Get merchant info ](#get-merchant-info)
	* [Update merchant](#update-merchant).
	* [Delete merchant](#delete-merchant).
	* [Update merchant basic info](#update-merchant-basic-info).
	* [Update merchant account info](#update-Merchant-Account-Info).

* #### Whitelabeling (UI Looks)
	* [Set WhiteLabeling](#set-whiteLabeling)
	* [Delete WhiteLabeling](#delete-whiteLabeling)
	* [Get WhiteLabeling](#get-whiteLabeling)
	* [Update WhiteLabeling Values](#update-whiteLabeling-alues)
	* [Get List of WhiteLabeling (related Services/Merchants)](#get-list-of-whiteLabeling)
	
* #### Clients
	* [sub-client](#sub-client)
	* [Set client default service fee settings](#set-client-default-service-fee-settings)
	* [Set client default service settings](#set-client-default-service-settings)
	* [Set client settings](#set-client-settings)
	* [Get client settings](#get-client-settings)
  
## Usage

## Customers Methods
` after you set up the api url and created a session you can start Using the Other Methods of the Sdk `

*here you see one Example but you'll see more Examples of Using the SDK in the ```Program.cs``` File*
### Create customer
```
var createCustomerArgs = new CreateCustomerArgs
{
	SessionToken = new Guid("") // Guid You Get For Creating a new Session,
	ServiceId = new Guid(""), // guid, Id of the Service you wanna add the Customer to.
	Customer = new CustomerEntity // the customer Object.
	{
		CustomerDescription = "", // customer description
		CustomerName = "", // customer name
		Language = LanguageEnum.English, // English or Frensh
		CustomerExternalId = "" // an Customer Identifier's if it exists
	}
};
var result = TibInvoker.Portal.CreateCustomer(createCustomerArgs);
```

### List all service customers
```
var GetServiceCustomersArgs = new Tib.Api.Model.Customer.ListCustomersArgs
{
	SessionToken = new Guid(""), // The session token you get when creating a new session.
	ServiceId = new Guid("") // The Service you want the Customers list of.
};
var result = TibInvoker.Portal.ListCustomers(GetServiceCustomersArgs);
```

### Get a customer detail
```
var GetCustomerDetailsArgs = new Tib.Api.Model.Customer.GetCustomerArgs{
	SessionToken = new Guid(""), // session token
	CustomerId = new Guid("") // customer Id
};
var result = TibInvoker.Portal.GetCustomer(GetCustomerDetailsArgs);
```

### List the customers based on external identification
```
var getCustomersByExternalIdArgs=  new Tib.Api.Model.Customer.GetCustomersByExternalIdArgs{
	SessionToken = new Guid(""),
	ExternalCustomerId = "" // External customer Id 
};
var result = TibInvoker.Portal.GetCustomersByExternalId(getCustomersByExternalIdArgs);
```

### Modify an existing customer
```
var updateCustomerArgs = new Tib.Api.Model.Customer.SaveCustomerArgs
{
	SessionToken = new Guid(""),
	Customer = new Tib.Api.Model.Customer.CustomerModel
	{
		CustomerId = new Guid(""),
		CustomerDescription = "",
		CustomerExternalId = "",
		CustomerName = "",
		Language = LanguageEnum.English,
	}
};
var result = TibInvoker.Portal.SaveCustomer(updateCustomerArgs);
```

### Delete a customer
```
var deleteCustomerArgs = new Tib.Api.Model.Customer.DeleteCustomerArgs
{
	SessionToken = new Guid(""),
	CustomerId = new Guid("")
};
var result = TibInvoker.Portal.DeleteCustomer(deleteCustomerArgs);
```

## Payment methods

### Create bank account payment method

```
var createdDirectAccountArgs = new Tib.Api.Model.PaymentMethod.CreateDirectAccountPaymentMethodArgs
{
	CustomerId = new Guid(""), // customer Id to add the payment method to .
	SessionToken = new Guid(""), // Session Id to be able to call the Api
	Account = new Tib.Api.Model.PaymentMethod.AccountModel // information about the payment method
	{
		AccountName = "", // the Account Name
		AccountNumber = "", /: the account number 
		BankNumber = "", // the bank number 
		CheckDigit = "", // the Check digits
		InstitutionNumber = "", // the institution number
		Owner = "", // the owner's name.
	},
	IsCustomerAutomaticPaymentMethod = false,
	IsCustomerWithdrawaAuthorized = false,
	Language = LanguageEnum.English,
}
var result = TibInvoker.Portal.CreateDirectAccountPaymentMethod(createdDirectAccountArgs)
```

### Create credit card payment method
```
var CreateCreditCardArgs = new Tib.Api.Model.PaymentMethod.CreateCreditCardPaymentMethodArgs
{
	CustomerId = new Guid(""),
	CreditCard = new Tib.Api.Model.PaymentMethod.CreditCardModel
	{
		CardOwner = "", // Card Owner Name
		CreditCardDescription = "", // A description to the card
		CreditCardRegisteredAddress = new AddressModel // Address registered for this card
		{
			AddressCity = "",
			CountryId = CountryIdEnum.USA,
			PostalZipCode = "",
			ProvinceStateId = ProvinceStateIdEnum.US_Alabama,
			StreetAddress = ""
		},
		CVD = "",
		ExpirationMonth = 5, // expiration month 
		ExpirationYear = 2029, // expiration Year
		Pan = 1231, // pan number
	},
	SessionToken = new Guid(""),
	Language = LanguageEnum.English,
	IsCustomerAutomaticPaymentMethod = false,
	SkipValidation = true
}
var result = TibInvoker.Portal.CreateCreditCardPaymentMethod(CreateCreditCardArgs)
```


### Create Interac payment method

``` 
var createInteracPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.CreateInteracPaymentMethodArgs{
	CustomerId = new Guid(),
	InteracInformation = new Tib.Api.Model.PaymentMethod.InteracModel
	{
		Description = "", // description of the method
		InteracAnswer = "", // intrac Answer
		InteracQuestion = "", // interac Question
		Owner = "", // the owner name
		TargetEmailAddress = "", // the target email
		TargetMobilePhoneNumber = "" // the target phone number
	},
	IsCustomerAutomaticPaymentMethod = false, 
	Language = LanguageEnum.English, 
        SessionToken = _session
}
var result  = TibInvoker.Portal.CreateInteracPaymentMethod(createInteracPaymentMethodArgs)
```

### Change Interac Payment Method Question and Answer
```
var changeInteracPaymentMethodQuestionAndAnswerArgs = new Tib.Api.Model.PaymentMethod.ChangeInteracPaymentMethodQuestionAndAnswerArgs
{
	SessionToken = new Guid(""),
	InteracAnswer = "",
	InteracPaymentMethodId = new Guid(""),
	InteracQuestion = "",
}; 
var result = TibInvoker.Portal.ChangeInteracPaymentMethodQuestionAndAnswer(changeInteracPaymentMethodQuestionAndAnswerArgs)
```

### Get a specific payment method
```
var getPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.GetPaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // Payment method Id 
	SessionToken = new Guid(""), // session Token
};
var result = TibInvoker.Portal.GetPaymentMethod(getPaymentMethodArgs);
```

### List payment methods
```
var getPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.GetPaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // Payment method Id 
	SessionToken = new Guid(""), // session Token
};
var result = TibInvoker.Portal.GetPaymentMethod(getPaymentMethodArgs);
```

### Change the default payment method of a customer
```
var listPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.ListPaymentMethodsArgs
{
	CustomerId = new Guid(""), // the Id of the customer that we need the payment method list of 
	SessionToken = new Guid(""),
};
var result = TibInvoker.Portal.ListPaymentMethods(listPaymentMethodArgs);
```

### Delete payment method
```
var deletePaymentMethodArgs = new Tib.Api.Model.PaymentMethod.DeletePaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // the payment method Id to delete
	SessionToken = new Guid("")
};
var result = TibInvoker.Portal.DeletePaymentMethod(deletePaymentMethodArgs);
```


### List Transfers
```
var result  = TibInvoker.Portal.ListTransfers(new Tib.Api.Model.Payment.ListTransfersArgs
      {
        SessionToken = _session,
        FromDate = new DateTime(2020, 01, 01),
        ExternalMerchantGroupId = "", 
        LevelFilterId = new Guid(), 
        MarkResolvedOnly = false, 
        PaymentFilterLevel = PaymentFilterLevelEnum.Bill, 
        TransferType = TransferTypeFlag.All, 
        ToDate = DateTime.Now,
        TransferGroupId = "",
        OnlyWithErrors = false,
      });

      ResponseHandler(result, JsonConvert.SerializeObject(result.Payments));
```

### List Transfers Fast
```
      var result = TibInvoker.Portal.ListTransfersFast(new Tib.Api.Model.Payment.ListTransfersFastArgs
      {
        SessionToken = _session,
        FromDate = new DateTime(2020, 01, 01),
        ExternalMerchantGroupId = "",
        MerchantId = new Guid(), // Merchant Id
        MarkResolvedOnly = false,
        TransferType = TransferTypeEnum.PaymentAndFreeCollection, // depending on the type of payment you wanna retrieve.
        ToDate = DateTime.Now,
        TransferGroupId = "",
        OnlyWithErrors = false,
      });

      ResponseHandler(result, JsonConvert.SerializeObject(result.Transfers));

```

### List transfers For Bill Fast
```
var result = TibInvoker.Portal.ListTransfersForBillFast(new Tib.Api.Model.Payment.ListTransfersForBillFastArgs
      {
        SessionToken = _session,
        BillId = new Guid() , // the bill Id 
        MerchantId = new Guid() // The Merchant Id .
      });

      ResponseHandler(result, JsonConvert.SerializeObject(result.Transfers));
```

## Bills / Payments / Transfers

### Create Bill
```
var createbillsArgs = new CreateBillArgs
{
    SessionToken = _session,
    BreakIfMerchantNeverBeenAuthorized = true,
    BillData = new BillEntity
    {
        BillAmount = amount,
        BillCurrency = (CurrencyEnum)currency,
        BillDescription = desc,
        BillTitle = title,
        Language = (LanguageEnum)language,
        MerchantId = _merchant,
        RelatedCustomerId = _customer,
        UseConvenientFeeRule = false
    }
};
var result = TibInvoker.Portal.CreateBill(createbillsArgs);
```

### List Bills

```
var getbillsArgs = new ListBillsArgs
{
    SessionToken = new Guid(""), // Session token
    ServiceId = new Guid(""), // the service Id
    FromDateTime = new DateTime(2020, 12, 31), // start date of get bills search query
    ToDateTime = DateTime.Now, // end date of the get bill search query
    MerchantId = _merchant // merchant Id 
}
```

### Get Bill

```
var getBillArgs = new GetBillArgs
{
    SessionToken = _session,
    BillId = _bill
}; 
var result = TibInvoker.Portal.GetBill(getBillArgs)
```

### Delete Bill
```
var deleteBillArgs = new DeleteBillArgs
{
    SessionToken = _session,
    BillId = _bill
};
var result = TibInvoker.Portal.DeleteBill();
```
*Keep in mind that you'll have to implement your own verification logic to avoid deleting a bill by mistake*

### Create Payment

```
var createPaymentArgs = new CreatePaymentArgs
{
    BillId = _bill,
    SessionToken = _session,
    CustomerEmail = customerEmail,
    PaymentInfo = new Tib.Api.Model.PaymentMethod.PaymentEntity
    {
        PaymentFlow = paymentFlow,
        Language = language
    },
    StatementDescription = ""
}; 
TibInvoker.Portal.CreatePayment(createPaymentArgs)
```

### Create Direct Deposit (this Methods is obsolete, Use CreateFreeOperation)
```
var createDirectDipositArgs = new CreateDirectDepositArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DepositDueDate = DateTime.Now.AddDays(1),
    DestinationAccount = new Tib.Api.Model.PaymentMethod.AccountModel
    {
        AccountName = accountName,
        BankNumber = bankNumber,
        CheckDigit = CheckDegit,
        InstitutionNumber = InsNumber,
        Owner = Owner,
        AccountNumber = accountNumber,
    },
    Language = LanguageEnum.English,
    OriginMerchantId = _merchant,
    StatementDescription = ""
}; 
var result = TibInvoker.Portal.CreateDirectDeposit(createDirectDipositArgs);
```

### Create Interac Transfer

```
var createDirectInteracTransactionArgs = new CreateDirectInteracTransactionArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DueDate = DateTime.Now.AddDays(1),
    InteracInformation = new Tib.Api.Model.PaymentMethod.InteracModel
    {
        Description = "description of the interac",
        InteracAnswer = "TheAnswer",
        InteracQuestion = "TheQuestion",
        Owner = "the Owner",
        TargetEmailAddress = "theEmail@gmail.com",
        TargetMobilePhoneNumber = "1212302190",
    },
    Language = LanguageEnum.English,
    MerchantId = _merchant,
    ReferenceNumber = "1233029920",
    TransferDirection = TransferDirectionEnum.Deposit,
    StatementDescription = ""
};
var result = TibInvoker.Portal.CreateDirectInteracTransaction(createDirectInteracTransactionArgs)
```
### Create from ACP file
```
var createTransactionFromRawArgs = new Tib.Api.Model.Bill.CreateTransactionFromRawArgs
{
    SessionToken = _session,
    MerchantId = _merchant,
    RawAcpFileContent = "",
}
var result = TibInvoker.Portal.CreateTransactionFromRaw(createTransactionFromRawArgs)
```
### Create Free Operation
```
var createDirectDepositArgs = new CreateDirectDepositArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DepositDueDate = DateTime.Now.AddDays(1),
    DestinationAccount = new Tib.Api.Model.PaymentMethod.AccountModel
    {
        AccountName = accountName,
        BankNumber = bankNumber,
        CheckDigit = CheckDegit,
        InstitutionNumber = InsNumber,
        Owner = Owner,
        AccountNumber = accountNumber,
    },
    Language = LanguageEnum.English,
    OriginMerchantId = _merchant,
    StatementDescription = ""
}
var result = var result = TibInvoker.Portal.CreateDirectDeposit(createTransactionFromRawArgs)
```
### Delete Transfer
```
var deletePaymentArgs = new DeletePaymentArgs
{
    SessionToken = _session,
    PaymentId = _payment.Value,
};
var result = TibInvoker.Portal.DeletePayment(deletePaymentArgs)
```
### Revert Transfer
```
var revertTransferArgs = new Tib.Api.Model.PaymentMethod.RevertTransferArgs
{
    SessionToken = _session,
    TransferId = _transfer.Value,
}; 
var result = TibInvoker.Portal.RevertTransfer(revertTransferArgs)
```
### List Recuring
```
var recuringList  = new GetRecuringTransfersArgs
{
    SessionToken = _session,
    ServiceID = _service
};
var return  = TibInvoker.Portal.GetRecuringTransfers(recuringList);
```

### Delete Recuring process
```
var deleteRecuringTransferArgs = new DeleteRecuringTransferArgs
{
    SessionToken = _session,
    RecuringTransferId = new Guid(""),
};
var result = TibInvoker.Portal.DeleteRecuringTransfer(deleteRecuringTransferArgs);
```

## Reporting of Operation

### List Executed Operations
```
var listExecutedOperationsArgs = new Tib.Api.Model.Report.ListExecutedOperationsArgs
{
    SessionToken = new Guid(""), // session token
    DateType = DateTypeEnum.CreatedDate,
    FromDate = new DateTime(2018, 01, 01),
    MerchantId = _merchant,
    ToDate = DateTime.Now,
    TransferType = TransferTypeFlag.All,
    OnlyWithErrors = false,
    TransferGroupId = "",
}
var result = TibInvoker.Portal.ListExecutedOperations(listExecutedOperationsArgs);
```

## Merchant Methods

### Create new merchant
```
var merchantArgs = new Tib.Api.Model.Service.GetMerchantArgs
{
	SessionToken = _session,
	MerchantId = _merchant
};
var result = TibInvoker.Portal.GetMerchant(merchantArgs);
```
### Get merchant info
```
var getMerchantArgs = new Tib.Api.Model.Service.GetMerchantArgs
{
	SessionToken = _session,
	MerchantId = _merchant
};
var result = TibInvoker.Portal.GetMerchant(getMerchantArgs);
```
### Update merchant
```
var saveMerchantArgs = new Tib.Api.Model.Service.SaveMerchantArgs
{
	SessionToken = _session,
	MerchantId = _merchant,
	MerchantInfo = new Tib.Api.Model.Service.MerchantModel
	{
		Account = new Tib.Api.Model.PaymentMethod.AccountModel { },
	}
}
var result = TibInvoker.Portal.SaveMerchant(saveMerchantArgs);
```
### Delete merchant
```
var deleteMerchantArgs = new Tib.Api.Model.Merchant.DeleteMerchantArgs
{
	SessionToken = _session,
	MerchantId = _merchant
};
var result = TibInvoker.Portal.DeleteMerchant(deleteMerchantArgs);
```
### Update merchant basic info 
```
var updateBasiInfoArgs = new Tib.Api.Model.Service.SaveMerchantBasicInfoArgs
{
	SessionToken = _session,
	MerchantId = _merchant,
	MerchantInfo = new Tib.Api.Model.Service.MerchantModelBasicInfo
	{
		EmailCopyTo = "EmailCopyTo@gmail.com",
		ExternalSystemId = "M3493LDO",
		Email = "email@email.d",
		FavoriteProvider = ProviderEnum.CA_CreditCard_BankOfAmerica,
		Language = LanguageEnum.English,
		MerchantCurrency = CurrencyEnum.USD,
		MerchantDescription = "merchant description",
		MerchantName = "merchant nameupdate vie SDK",
		PhoneNumber = "1234567890",
		ExternalSystemGroupId = "#PQSD23",
		Address = new AddressModel
		{
			AddressCity = "CIty",
			CountryId = CountryIdEnum.USA,
			PostalZipCode = "VP2039",
			ProvinceStateId = ProvinceStateIdEnum.US_Kentucky,
			StreetAddress = "0394FKDQSF sdlqjf"
		},
	}
};
var result = TibInvoker.Portal.SaveMerchantBasicInfo(updateBasiInfoArgs);
```
### Update merchant account info
```
var updateAccountInfoArgs =new Tib.Api.Model.Service.SaveMerchantAccountInfoArgs
{
	SessionToken = _session,
	MerchantId = _merchant,
	Account = new Tib.Api.Model.PaymentMethod.AccountModel
	{
		AccountName = "name Updated via SDK",
		AccountNumber = "1231213112312321",
		BankNumber = "123123",
		CheckDigit = "122",
		InstitutionNumber = "2133112",
		Owner = "okey",
	}
};
var result = TibInvoker.Portal.SaveMerchantAccountInfo(updateAccountInfoArgs);
```

## Whitelabeling (UI Looks)

The Whitelabeling can be set on multiple levels 

* Client
* Service
* Merchant

please See [whitelabeling levels enums](../README.md#WhiteLabeling-levels-enum)

The WhiteLabeling Use 2 main Objects `WhiteLabelingModel` and `WhiteLabelingDataModel`

The first is a container of white labeling Values for a single entity (client, service, merchant) and have a list of `WhiteLabelingDataModel`.

The Second one represents the values that a single whitelabeling cssProperty going to have.

*Note: To Chenge the logo the api accepts images as a base64 string so you will need to implement your own imageToBase64 and the pass the string to the api.*

The WhiteLabeling only support a number of parameters 

This is the list o f the properties that you can customize 
```
"company-name"
"logo-secound-part-color"
"logo-first-Part-color"
"logo-background"
"radio-button-color"
"checbox-color"
"sidenav-item-active-color"
"sidenav-button-trigger-color"
"button-color"
"logo"
"accepte-button-color"
"reject-button-color"
"navbar-backgournd-color"
"icon-size"
"title-font-family"
"title-font-size"
"subtitle-font-family"
"subtitle-font-size"
"subtitle-text-color"
```
you pass one of those to the cssProperty and pass the value you want it to be.


### Set WhiteLabeling
```
var localWhiteLabelingData = new List<WhiteLabelingDataModel>() // list of values you need for your whitelabeling
{	
	new WhiteLabelingDataModel {
		CssProperty = "button-color",
		CssValue = "testvalue"
	}
};
var whitelabelingArgs = new SetWhiteLabelingArgs
{
	SessionToken = _session,
	WhiteLabelingLevel = 1, // int value of WhitelabelingLevelsEnum
	WhiteLabelingData = localWhiteLabelingData
};
var result = TibInvoker.Portal.SetWhiteLabeling(whitelabelingArgs);
```
### Delete WhiteLabeling

```
var DeleteWhiteLabelingArgs = new DeleteWhitelabelinArgs
{
	SessionToken = _session,
	Id = new Guid(""), // Id of the whiteLabeling to delete.
	Level = (int)WhitelabelingLevelsEnum.Merchant // int value of WhitelabelingLevelsEnum
}
var result = TibInvoker.Portal.DeleteWhiteLabeling(DeleteWhiteLabelingArgs);
```

### Get WhiteLabeling
```
var getWhiteLabelingArgs = new GetWhiteLabelingArgs { 
	SessionToken = _session,
	WhiteLabelingLevel = type,
	Id = entityId
};
var result = TibInvoker.Portal.GetWhiteLabelingData(getWhiteLabelingArgs);
```  

### Update WhiteLabeling Values

```
var localWhiteLabelingToUpdate = new List<WhiteLabelingDataModel>() {
	new WhiteLabelingDataModel {
		WhiteLabelingDataId = new Guid(""), // WL data Id you wanna update
		CssProperty  = "", // the css Prop you wanna update
		CssValue = "Brown"
	}
};
var updateWhitelabelingArgs = new UpdateWhiteLabelingDataArgs
{
	SessionToken = _session,
	UpdatedWhiteLabelingData = localWhiteLabelingToUpdate // list of WL to update.
};
var result = TibInvoker.Portal.UpdateWhiteLabeling(updateWhitelabelingArgs);
```

### Get List of WhiteLabeling
```
var wlArgs = new GetWhiteLabelingArgs { 
	SessionToken = _session 
};
var result = TibInvoker.Portal.GetListWhiteLabeling(wlArgs);
```

## Clients
### sub-client
```
var createSubClientArgs = new Tib.Api.Model.SubClient.CreateSubClientArgs
{
	SessionToken = _session,
	Name = subClientName,
	Language = lang
};
var Result = TibInvoker.Portal.CreateSubClient(createSubClientArgs);
```
### Set client default service fee settings
```
var setClientDefaultServiceFeeSettingsArgs = new Tib.Api.Model.Service.SetClientDefaultServiceFeeSettingsArgs
{
	SessionToken = _session,
	ClientId = _clientId,
	ServiceFeeSettings = new Tib.Api.Model.Service.ServiceFeeSettingsModel
	{
		ConvenientFeeDebitAbsoluteFee = 0,
		ConvenientFeeCreditAbsoluteFee = 0,
		ConvenientFeeCreditMode = ConvenientFeeModeEnum.NotSet,
		ConvenientFeeCreditPercentageFee = 0,
		ConvenientFeeCreditRoundUpValue = 0,
		ConvenientFeeDebitMode = ConvenientFeeModeEnum.NotSet,
		ConvenientFeeDebitPercentageFee = 0,
		ConvenientFeeDebitRoundUpValue = 0,
		CreditCardAbsoluteFee = 0,
		CreditCardFeeMode = FeeModeEnum.NotSet,
		CreditCardFeeRoundUpValue = 0,
		CreditCardPercentageFee = 0,
		DebitAbsoluteFee = 0,
		DebitFeeMode = FeeModeEnum.NotSet,
		DebitFeeRoundUpValue = 0,
		DebitNFSFees = 0,
		DebitPercentageFee = 0,
		InteracFeeAbsolute = 0,
		InteracFeeCollectAbsolute = 0,
		InteracFeeCollectPercentage = 0,
		InteracFeePercentage = 0,
		NFSFileFees = 0,
		RevertCreditCardAbsoluteFees = 0,
		RevertCreditCardPercentageFees = 0,
		RevertDebitAbsoluteFees = 0,
		RevertDebitPercentageFees = 0
	// service Fees settings to apply . 
	}
};
var result = TibInvoker.Portal.SetClientDefaultServiceFeeSettings(setClientDefaultServiceFeeSettingsArgs);
```

### Set client default service settings
```
var setClientDefaultServiceFeeSettingsArgs = new Tib.Api.Model.Service.SetClientDefaultServiceFeeSettingsArgs
{
	SessionToken = _session,
	ClientId = _clientId,
	ServiceFeeSettings = new Tib.Api.Model.Service.ServiceFeeSettingsModel
	{
		ConvenientFeeDebitAbsoluteFee = 0,
		ConvenientFeeCreditAbsoluteFee = 0,
		ConvenientFeeCreditMode = ConvenientFeeModeEnum.NotSet,
		ConvenientFeeCreditPercentageFee = 0,
		ConvenientFeeCreditRoundUpValue = 0,
		ConvenientFeeDebitMode = ConvenientFeeModeEnum.NotSet,
		ConvenientFeeDebitPercentageFee = 0,
		ConvenientFeeDebitRoundUpValue = 0,
		CreditCardAbsoluteFee = 0,
		CreditCardFeeMode = FeeModeEnum.NotSet,
		CreditCardFeeRoundUpValue = 0,
		CreditCardPercentageFee = 0,
		DebitAbsoluteFee = 0,
		DebitFeeMode = FeeModeEnum.NotSet,
		DebitFeeRoundUpValue = 0,
		DebitNFSFees = 0,
		DebitPercentageFee = 0,
		InteracFeeAbsolute = 0,
		InteracFeeCollectAbsolute = 0,
		InteracFeeCollectPercentage = 0,
		InteracFeePercentage = 0,
		NFSFileFees = 0,
		RevertCreditCardAbsoluteFees = 0,
		RevertCreditCardPercentageFees = 0,
		RevertDebitAbsoluteFees = 0,
		RevertDebitPercentageFees = 0
	// service Fees settings to apply . 
	}
};
var result = TibInvoker.Portal.SetClientDefaultServiceSettings(setClientDefaultServiceFeeSettingsArgs);
```
### Set client settings
```
var setClientSettingArgs = new Tib.Api.Model.Service.SetClientSettingsArgs
{
	SessionToken = _session,
	CLientId = _clientId,
	ClientSettings = new Tib.Api.Model.Service.ClientSettings
	{
		CollectionLimitDaily = 93849,
		DepositLimitDaily = 2994949
	}
};
var result = TibInvoker.Portal.SetClientSettings(setClientSettingArgs);
```
### Get client settings

```
var getClientSettingsArgs = new Tib.Api.Model.Service.GetClientSettingsArgs
{
	SessionToken = _session,
	CLientId = _clientId
};
var result = TibInvoker.Portal.GetClientSettings(getClientSettingsArgs);
```
